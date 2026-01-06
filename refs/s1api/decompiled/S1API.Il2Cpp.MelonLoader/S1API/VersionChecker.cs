using System;
using System.IO;
using System.Linq;
using System.Reflection;
using MelonLoader;
using MelonLoader.Utils;

namespace S1API;

public static class VersionChecker
{
	private const string PROBLEMATIC_VERSION = "0.7.1";

	private const string RECOMMENDED_VERSION_1 = "0.7.0";

	private const string RECOMMENDED_VERSION_2 = "0.7.2-nightly";

	public static void CheckMelonLoaderVersion()
	{
		try
		{
			string melonLoaderVersion = GetMelonLoaderVersion();
			if (string.IsNullOrEmpty(melonLoaderVersion))
			{
				MelonLogger.Warning("[S1API VersionChecker] Could not determine MelonLoader version!");
				return;
			}
			MelonLogger.Msg("========================================");
			MelonLogger.Msg("[S1API VersionChecker] MelonLoader Version Detected: " + melonLoaderVersion);
			MelonLogger.Msg("========================================");
			if (IsProblematicVersion(melonLoaderVersion))
			{
				ShowBigWarning(melonLoaderVersion);
			}
			else
			{
				MelonLogger.Msg("[S1API VersionChecker] Your MelonLoader version appears to be compatible!");
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[S1API VersionChecker] Version check failed: " + ex.Message);
		}
	}

	private static string GetMelonLoaderVersion()
	{
		try
		{
			Assembly assembly = typeof(MelonMod).Assembly;
			PropertyInfo propertyInfo = assembly.GetType("MelonLoader.Properties.BuildInfo")?.GetProperty("VersionNumber");
			if (propertyInfo?.GetValue(null) != null)
			{
				object value = propertyInfo.GetValue(null);
				return value.ToString() ?? GetVersionFromAssembly(assembly);
			}
			return GetVersionFromAssembly(assembly);
		}
		catch
		{
			try
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly2 in assemblies)
				{
					string name = assembly2.GetName().Name;
					if (name != null && (name.Equals("MelonLoader") || name.Equals("MelonLoader.Core")))
					{
						return GetVersionFromAssembly(assembly2);
					}
				}
			}
			catch
			{
			}
			return null;
		}
	}

	private static string GetVersionFromAssembly(Assembly assembly)
	{
		Version version = assembly.GetName().Version;
		if (version != null)
		{
			return $"{version.Major}.{version.Minor}.{version.Build}";
		}
		return null;
	}

	private static bool IsProblematicVersion(string version)
	{
		if (string.IsNullOrEmpty(version))
		{
			return false;
		}
		return version.StartsWith("0.7.1", StringComparison.OrdinalIgnoreCase);
	}

	private static void ShowBigWarning(string detectedVersion)
	{
		string text = $"\r\n╔════════════════════════════════════════════════════════════════════════╗\r\n║                                                                        ║\r\n║                        !!! URGENT WARNING !!!                          ║\r\n║                                                                        ║\r\n║                YOU ARE USING MELONLOADER VERSION {detectedVersion,-21} ║\r\n║                                                                        ║\r\n║      This version is KNOWN TO HAVE CRITICAL ISSUES and may cause:      ║\r\n║                                                                        ║\r\n║                - Game crashes and unexpected behavior                  ║\r\n║                - Mod incompatibility and loading failures              ║\r\n║                - Performance issues and memory leaks                   ║\r\n║                - Random errors and instability                         ║\r\n║                                                                        ║\r\n║           PLEASE UPDATE IMMEDIATELY to one of these versions:          ║\r\n║                                                                        ║\r\n║                ► {"0.7.0",-27} (Stable Release)          ║\r\n║                ► {"0.7.2-nightly",-27} (Latest Nightly)          ║\r\n║                                                                        ║\r\n║      Download: https://melonwiki.xyz/#/?id=automated-installation      ║\r\n║                                                                        ║\r\n╚════════════════════════════════════════════════════════════════════════╝";
		MelonLogger.Error(text);
		MelonLogger.Error("[S1API VersionChecker] DETECTED PROBLEMATIC MELONLOADER VERSION: " + detectedVersion);
		MelonLogger.Error("[S1API VersionChecker] PLEASE UPDATE TO 0.7.0 OR 0.7.2-nightly");
		MelonLogger.Error(string.Concat(Enumerable.Repeat(Environment.NewLine, 2)));
		MelonLogger.Warning("[S1API VersionChecker] IMPORTANT: This message will be available in logs for your reference at \n" + Path.Combine(MelonEnvironment.MelonLoaderLogsDirectory, "Latest.log"));
	}
}
