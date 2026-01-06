using System;
using System.IO;
using System.Reflection;
using S1API.Logging;
using UnityEngine;

namespace S1API.Rendering;

public static class TextureUtils
{
	private static readonly Log Logger = new Log("TextureUtils");

	public static Texture2D LoadTextureFromResource(Assembly assembly, string resourceName, FilterMode filterMode = (FilterMode)1, TextureWrapMode wrapMode = (TextureWrapMode)1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (assembly == null)
		{
			Logger.Error("Assembly is null when loading texture resource: " + resourceName);
			return null;
		}
		try
		{
			using Stream stream = assembly.GetManifestResourceStream(resourceName);
			if (stream == null)
			{
				Logger.Error("Texture resource not found: " + resourceName);
				return null;
			}
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return LoadTextureFromBytes(array, filterMode, wrapMode);
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to load texture from resource '{resourceName}': {arg}");
			return null;
		}
	}

	public static Texture2D LoadTextureFromBytes(byte[] imageData, FilterMode filterMode = (FilterMode)1, TextureWrapMode wrapMode = (TextureWrapMode)1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Texture2D val = new Texture2D(2, 2, (TextureFormat)4, false);
			if (ImageConversion.LoadImage(val, imageData, false))
			{
				((Texture)val).filterMode = filterMode;
				((Texture)val).wrapMode = wrapMode;
				return val;
			}
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to load texture from bytes: {arg}");
		}
		return null;
	}

	public static Texture2D LoadTextureFromFile(string filePath, FilterMode filterMode = (FilterMode)1, TextureWrapMode wrapMode = (TextureWrapMode)1)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(filePath))
		{
			Logger.Error("Texture file not found: " + filePath);
			return null;
		}
		try
		{
			byte[] imageData = File.ReadAllBytes(filePath);
			return LoadTextureFromBytes(imageData, filterMode, wrapMode);
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to load texture from file '{filePath}': {arg}");
			return null;
		}
	}
}
