using System;
using System.IO;
using System.Reflection;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using S1API.Logging;
using UnityEngine;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.ImageUtils instead. This class will be made internal in a future version.")]
public static class ImageUtils
{
	private static readonly Log _loggerInstance = new Log("ImageUtils");

	public static Sprite? LoadImage(string fileName)
	{
		string text = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, fileName);
		if (!File.Exists(text))
		{
			_loggerInstance.Error("❌ Icon file not found: " + text);
			return null;
		}
		try
		{
			byte[] data = File.ReadAllBytes(text);
			return LoadImageRaw(data);
		}
		catch (Exception ex)
		{
			_loggerInstance.Error("❌ Failed to load sprite: " + ex);
		}
		return null;
	}

	public static Sprite? LoadImageRaw(byte[] data)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		try
		{
			Texture2D val = new Texture2D(2, 2);
			if (ImageConversion.LoadImage(val, Il2CppStructArray<byte>.op_Implicit(data)))
			{
				return TextureToSprite(val);
			}
		}
		catch (Exception ex)
		{
			_loggerInstance.Error("❌ Failed to load sprite: " + ex);
		}
		return null;
	}

	public static Sprite? TextureToSprite(Texture2D? texture, float pixelsPerUnit = 100f)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)texture == (Object)null)
		{
			return null;
		}
		return Sprite.Create(texture, new Rect(0f, 0f, (float)((Texture)texture).width, (float)((Texture)texture).height), new Vector2(0.5f, 0.5f), pixelsPerUnit);
	}

	public static Sprite? LoadImageFromResource(Assembly assembly, string resourceName, float pixelsPerUnit = 100f, FilterMode filterMode = (FilterMode)1)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		if (assembly == null)
		{
			_loggerInstance.Error("❌ Assembly is null when loading resource: " + resourceName);
			return null;
		}
		try
		{
			using Stream stream = assembly.GetManifestResourceStream(resourceName);
			if (stream == null)
			{
				_loggerInstance.Error("❌ Resource not found: " + resourceName);
				return null;
			}
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			Texture2D val = new Texture2D(2, 2, (TextureFormat)4, false);
			if (ImageConversion.LoadImage(val, Il2CppStructArray<byte>.op_Implicit(array), false))
			{
				((Texture)val).filterMode = filterMode;
				return Sprite.Create(val, new Rect(0f, 0f, (float)((Texture)val).width, (float)((Texture)val).height), new Vector2(0.5f, 0.5f), pixelsPerUnit);
			}
		}
		catch (Exception value)
		{
			_loggerInstance.Error($"❌ Failed to load sprite from resource '{resourceName}': {value}");
		}
		return null;
	}
}
