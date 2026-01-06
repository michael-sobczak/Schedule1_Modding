public static class TextureFormatUtilities // TypeDefIndex: 17077
{
	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x29C4580 Offset: 0x29C2F80 VA: 0x1829C4580
	private static void .cctor() { }

	// RVA: 0x29C4330 Offset: 0x29C2D30 VA: 0x1829C4330
	private static bool IsObsolete(object value) { }

	// RVA: 0x29C4160 Offset: 0x29C2B60 VA: 0x1829C4160
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[Extension]
	// RVA: 0x29C44F0 Offset: 0x29C2EF0 VA: 0x1829C44F0
	internal static bool IsSupported(RenderTextureFormat format) { }

	[Extension]
	// RVA: 0x29C4460 Offset: 0x29C2E60 VA: 0x1829C4460
	internal static bool IsSupported(TextureFormat format) { }
}
