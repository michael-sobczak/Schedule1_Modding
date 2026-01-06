public static class ImageConversion // TypeDefIndex: 19255
{
	// Methods

	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	[Extension]
	// RVA: 0x2D00B80 Offset: 0x2CFF580 VA: 0x182D00B80
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	// RVA: 0x2D00C10 Offset: 0x2CFF610 VA: 0x182D00C10
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[Extension]
	// RVA: 0x2D00BC0 Offset: 0x2CFF5C0 VA: 0x182D00BC0
	public static bool LoadImage(Texture2D tex, byte[] data) { }
}
