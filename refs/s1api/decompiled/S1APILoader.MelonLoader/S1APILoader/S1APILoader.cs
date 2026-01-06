using System;
using System.IO;
using System.Reflection;
using MelonLoader;

namespace S1APILoader;

public class S1APILoader : MelonPlugin
{
	private const string BuildFolderName = "S1API";

	public override void OnPreModsLoaded()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		if (directoryName == null)
		{
			throw new Exception("Failed to identify plugins folder.");
		}
		string fullPath = Path.GetFullPath(Path.Combine(directoryName, "../Mods"));
		string folder = Path.Combine(directoryName, "S1API");
		string text = (MelonUtils.IsGameIl2Cpp() ? "Il2Cpp" : "Mono");
		string build = ((!MelonUtils.IsGameIl2Cpp()) ? "Il2Cpp" : "Mono");
		MelonLogger.Msg("Loading S1API for " + text + "...");
		NormalizeBuild(fullPath, text, shouldBeEnabled: true, "S1API.{0}.MelonLoader.dll");
		NormalizeBuild(fullPath, build, shouldBeEnabled: false, "S1API.{0}.MelonLoader.dll");
		NormalizeBuild(folder, text, shouldBeEnabled: true, "S1API.{0}.dll");
		NormalizeBuild(folder, build, shouldBeEnabled: false, "S1API.{0}.dll");
		MelonLogger.Msg("Successfully loaded S1API for " + text + "!");
	}

	private static void NormalizeBuild(string folder, string build, bool shouldBeEnabled, string fileNamePattern)
	{
		if (!Directory.Exists(folder))
		{
			return;
		}
		string path = string.Format(fileNamePattern, build);
		string text = Path.Combine(folder, path);
		string text2 = text + ".disabled";
		bool flag = File.Exists(text);
		bool flag2 = File.Exists(text2);
		if (!flag && !flag2)
		{
			return;
		}
		if (shouldBeEnabled)
		{
			if (flag && !flag2)
			{
				return;
			}
			string text3 = null;
			if (flag2)
			{
				text3 = text2;
			}
			if (flag)
			{
				text3 = ChooseNewest(text3, text);
			}
			if (text3 != null)
			{
				if (StringComparer.OrdinalIgnoreCase.Equals(text3, text2))
				{
					SafeDelete(text);
					SafeMoveReplace(text2, text);
				}
				else if (flag2)
				{
					SafeDelete(text2);
				}
			}
		}
		else
		{
			if ((!flag && flag2) || !flag)
			{
				return;
			}
			SafeDelete(text2);
			if (!SafeMoveReplace(text, text2) || File.Exists(text))
			{
				MelonLogger.Warning("Failed to disable '" + text + "'. File may be locked or in use.");
				if (File.Exists(text))
				{
					TryCopyAndDelete(text, text2);
				}
			}
		}
	}

	private static string ChooseNewest(string? currentBestPath, string candidatePath)
	{
		if (currentBestPath == null)
		{
			return candidatePath;
		}
		Version version = TryGetAssemblyVersion(currentBestPath);
		Version version2 = TryGetAssemblyVersion(candidatePath);
		if (version != null && version2 != null)
		{
			return (version2 > version) ? candidatePath : currentBestPath;
		}
		DateTime safeWriteTimeUtc = GetSafeWriteTimeUtc(currentBestPath);
		DateTime safeWriteTimeUtc2 = GetSafeWriteTimeUtc(candidatePath);
		return (safeWriteTimeUtc2 > safeWriteTimeUtc) ? candidatePath : currentBestPath;
	}

	private static Version? TryGetAssemblyVersion(string path)
	{
		try
		{
			return AssemblyName.GetAssemblyName(path).Version;
		}
		catch
		{
			return null;
		}
	}

	private static DateTime GetSafeWriteTimeUtc(string path)
	{
		try
		{
			return File.GetLastWriteTimeUtc(path);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	private static bool SafeMoveReplace(string sourcePath, string destinationPath)
	{
		try
		{
			if (File.Exists(destinationPath))
			{
				File.Delete(destinationPath);
			}
			File.Move(sourcePath, destinationPath);
			return true;
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("Failed to move '" + sourcePath + "' to '" + destinationPath + "': " + ex.Message);
			return false;
		}
	}

	private static void TryCopyAndDelete(string sourcePath, string destinationPath)
	{
		try
		{
			if (File.Exists(destinationPath))
			{
				File.Delete(destinationPath);
			}
			File.Copy(sourcePath, destinationPath, overwrite: true);
			try
			{
				File.Delete(sourcePath);
			}
			catch
			{
				MelonLogger.Warning("Copied '" + sourcePath + "' to '" + destinationPath + "' but could not delete source. You may need to manually delete it.");
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("Failed to copy '" + sourcePath + "' to '" + destinationPath + "': " + ex.Message);
		}
	}

	private static void SafeDelete(string path)
	{
		try
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("Failed to delete '" + path + "': " + ex.Message);
		}
	}
}
