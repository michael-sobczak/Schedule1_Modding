public static class GraphicsUtils // TypeDefIndex: 220
{
	// Fields
	private static Texture2D s_WhiteTexture; // 0x0
	private static Mesh s_Quad; // 0x8

	// Properties
	public static bool isLinearColorSpace { get; }
	public static bool supportsDX11 { get; }
	public static Texture2D whiteTexture { get; }
	public static Mesh quad { get; }

	// Methods

	// RVA: 0x699ED0 Offset: 0x6988D0 VA: 0x180699ED0
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x69A1D0 Offset: 0x698BD0 VA: 0x18069A1D0
	public static bool get_supportsDX11() { }

	// RVA: 0x69A200 Offset: 0x698C00 VA: 0x18069A200
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x699EF0 Offset: 0x6988F0 VA: 0x180699EF0
	public static Mesh get_quad() { }

	// RVA: 0x699B70 Offset: 0x698570 VA: 0x180699B70
	public static void Blit(Material material, int pass) { }

	// RVA: 0x699C70 Offset: 0x698670 VA: 0x180699C70
	public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = True, bool clearDepth = False) { }

	// RVA: 0x699E10 Offset: 0x698810 VA: 0x180699E10
	public static void Destroy(Object obj) { }

	// RVA: 0x699E90 Offset: 0x698890 VA: 0x180699E90
	public static void Dispose() { }
}
