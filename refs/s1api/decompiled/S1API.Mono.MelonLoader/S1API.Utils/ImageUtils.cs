using System.Reflection;
using S1API.Internal.Utils;
using UnityEngine;

namespace S1API.Utils;

public static class ImageUtils
{
	public static Sprite? LoadImage(string fileName)
	{
		return global::S1API.Internal.Utils.ImageUtils.LoadImage(fileName);
	}

	public static Sprite? LoadImageRaw(byte[] data)
	{
		return global::S1API.Internal.Utils.ImageUtils.LoadImageRaw(data);
	}

	public static Sprite? TextureToSprite(Texture2D? texture, float pixelsPerUnit = 100f)
	{
		return global::S1API.Internal.Utils.ImageUtils.TextureToSprite(texture, pixelsPerUnit);
	}

	public static Sprite? LoadImageFromResource(Assembly assembly, string resourceName, float pixelsPerUnit = 100f, FilterMode filterMode = (FilterMode)1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return global::S1API.Internal.Utils.ImageUtils.LoadImageFromResource(assembly, resourceName, pixelsPerUnit, filterMode);
	}
}
