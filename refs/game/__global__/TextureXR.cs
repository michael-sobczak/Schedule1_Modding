public static class TextureXR // TypeDefIndex: 13833
{
	// Fields
	private static int m_MaxViews; // 0x0
	private static Texture m_BlackUIntTexture2DArray; // 0x8
	private static Texture m_BlackUIntTexture; // 0x10
	private static RTHandle m_BlackUIntTexture2DArrayRTH; // 0x18
	private static RTHandle m_BlackUIntTextureRTH; // 0x20
	private static Texture2DArray m_ClearTexture2DArray; // 0x28
	private static Texture2D m_ClearTexture; // 0x30
	private static RTHandle m_ClearTexture2DArrayRTH; // 0x38
	private static RTHandle m_ClearTextureRTH; // 0x40
	private static Texture2DArray m_MagentaTexture2DArray; // 0x48
	private static Texture2D m_MagentaTexture; // 0x50
	private static RTHandle m_MagentaTexture2DArrayRTH; // 0x58
	private static RTHandle m_MagentaTextureRTH; // 0x60
	private static Texture2D m_BlackTexture; // 0x68
	private static Texture3D m_BlackTexture3D; // 0x70
	private static Texture2DArray m_BlackTexture2DArray; // 0x78
	private static RTHandle m_BlackTexture2DArrayRTH; // 0x80
	private static RTHandle m_BlackTextureRTH; // 0x88
	private static RTHandle m_BlackTexture3DRTH; // 0x90
	private static Texture2DArray m_WhiteTexture2DArray; // 0x98
	private static RTHandle m_WhiteTexture2DArrayRTH; // 0xA0
	private static RTHandle m_WhiteTextureRTH; // 0xA8

	// Properties
	public static int maxViews { set; }
	public static int slices { get; }
	public static bool useTexArray { get; }
	public static TextureDimension dimension { get; }

	// Methods

	// RVA: 0x2A46970 Offset: 0x2A45370 VA: 0x182A46970
	public static void set_maxViews(int value) { }

	// RVA: 0x2A468D0 Offset: 0x2A452D0 VA: 0x182A468D0
	public static int get_slices() { }

	// RVA: 0x2A46920 Offset: 0x2A45320 VA: 0x182A46920
	public static bool get_useTexArray() { }

	// RVA: 0x2A46850 Offset: 0x2A45250 VA: 0x182A46850
	public static TextureDimension get_dimension() { }

	// RVA: 0x2A458E0 Offset: 0x2A442E0 VA: 0x182A458E0
	public static RTHandle GetBlackUIntTexture() { }

	// RVA: 0x2A459A0 Offset: 0x2A443A0 VA: 0x182A459A0
	public static RTHandle GetClearTexture() { }

	// RVA: 0x2A45A60 Offset: 0x2A44460 VA: 0x182A45A60
	public static RTHandle GetMagentaTexture() { }

	// RVA: 0x2A45810 Offset: 0x2A44210 VA: 0x182A45810
	public static RTHandle GetBlackTexture() { }

	// RVA: 0x2A457B0 Offset: 0x2A441B0 VA: 0x182A457B0
	public static RTHandle GetBlackTextureArray() { }

	// RVA: 0x2A45750 Offset: 0x2A44150 VA: 0x182A45750
	public static RTHandle GetBlackTexture3D() { }

	// RVA: 0x2A45B20 Offset: 0x2A44520 VA: 0x182A45B20
	public static RTHandle GetWhiteTexture() { }

	// RVA: 0x2A45BF0 Offset: 0x2A445F0 VA: 0x182A45BF0
	public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x2A45530 Offset: 0x2A43F30 VA: 0x182A45530
	private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) { }

	// RVA: 0x2A450D0 Offset: 0x2A43AD0 VA: 0x182A450D0
	private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x2A45350 Offset: 0x2A43D50 VA: 0x182A45350
	private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x2A45000 Offset: 0x2A43A00 VA: 0x182A45000
	private static Texture3D CreateBlackTexture3D(string name) { }

	// RVA: 0x2A46810 Offset: 0x2A45210 VA: 0x182A46810
	private static void .cctor() { }
}
