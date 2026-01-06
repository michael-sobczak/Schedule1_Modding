public class GraphicsFormatUtility // TypeDefIndex: 12346
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	[FreeFunction("GetGraphicsFormat_Native_Texture")]
	// RVA: 0x2CF02C0 Offset: 0x2CEECC0 VA: 0x182CF02C0
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x2CF04D0 Offset: 0x2CEEED0 VA: 0x182CF04D0
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0340 Offset: 0x2CEED40 VA: 0x182CF0340
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x2CF0450 Offset: 0x2CEEE50 VA: 0x182CF0450
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = False)]
	// RVA: 0x2CF0300 Offset: 0x2CEED00 VA: 0x182CF0300
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x2CF0380 Offset: 0x2CEED80 VA: 0x182CF0380
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CEFF40 Offset: 0x2CEE940 VA: 0x182CEFF40
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x2CEFF80 Offset: 0x2CEE980 VA: 0x182CEFF80
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CEFF00 Offset: 0x2CEE900 VA: 0x182CEFF00
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x2CEFFF0 Offset: 0x2CEE9F0 VA: 0x182CEFFF0
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0900 Offset: 0x2CEF300 VA: 0x182CF0900
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF05D0 Offset: 0x2CEEFD0 VA: 0x182CF05D0
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0550 Offset: 0x2CEEF50 VA: 0x182CF0550
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0590 Offset: 0x2CEEF90 VA: 0x182CF0590
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CEFEC0 Offset: 0x2CEE8C0 VA: 0x182CEFEC0
	public static uint GetComponentCount(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0280 Offset: 0x2CEEC80 VA: 0x182CF0280
	public static string GetFormatString(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0790 Offset: 0x2CEF190 VA: 0x182CF0790
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x2CF07D0 Offset: 0x2CEF1D0 VA: 0x182CF07D0
	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CEFE40 Offset: 0x2CEE840 VA: 0x182CEFE40
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x2CEFDD0 Offset: 0x2CEE7D0 VA: 0x182CEFDD0
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0750 Offset: 0x2CEF150 VA: 0x182CF0750
	public static bool IsAlphaOnlyFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0710 Offset: 0x2CEF110 VA: 0x182CF0710
	public static bool HasAlphaChannel(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0880 Offset: 0x2CEF280 VA: 0x182CF0880
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF08C0 Offset: 0x2CEF2C0 VA: 0x182CF08C0
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	// RVA: 0x2CF0840 Offset: 0x2CEF240 VA: 0x182CF0840
	public static bool IsCrunchFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF06D0 Offset: 0x2CEF0D0 VA: 0x182CF06D0
	public static FormatSwizzle GetSwizzleR(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0690 Offset: 0x2CEF090 VA: 0x182CF0690
	public static FormatSwizzle GetSwizzleG(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0650 Offset: 0x2CEF050 VA: 0x182CF0650
	public static FormatSwizzle GetSwizzleB(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CF0610 Offset: 0x2CEF010 VA: 0x182CF0610
	public static FormatSwizzle GetSwizzleA(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CEFE80 Offset: 0x2CEE880 VA: 0x182CEFE80
	public static uint GetBlockSize(GraphicsFormat format) { }

	// RVA: 0x2CF0940 Offset: 0x2CEF340 VA: 0x182CF0940
	private static void .cctor() { }
}
