public static class ShaderUtilities // TypeDefIndex: 14959
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x2C20000 Offset: 0x2C1EA00 VA: 0x182C20000
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x2C1FEE0 Offset: 0x2C1E8E0 VA: 0x182C1FEE0
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x2C1FBA0 Offset: 0x2C1E5A0 VA: 0x182C1FBA0
	private static void .cctor() { }

	// RVA: 0x2C1E7A0 Offset: 0x2C1D1A0 VA: 0x182C1E7A0
	public static void GetShaderPropertyIDs() { }

	// RVA: 0x2C1F5D0 Offset: 0x2C1DFD0 VA: 0x182C1F5D0
	public static void UpdateShaderRatios(Material mat) { }

	// RVA: 0x2C1D080 Offset: 0x2C1BA80 VA: 0x182C1D080
	public static Vector4 GetFontExtent(Material material) { }

	// RVA: 0x2C1F400 Offset: 0x2C1DE00 VA: 0x182C1F400
	public static bool IsMaskingEnabled(Material material) { }

	// RVA: 0x2C1DCA0 Offset: 0x2C1C6A0 VA: 0x182C1DCA0
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	// RVA: 0x2C1CC50 Offset: 0x2C1B650 VA: 0x182C1CC50
	private static float ComputePaddingForProperties(Material mat) { }

	// RVA: 0x2C1D0D0 Offset: 0x2C1BAD0 VA: 0x182C1D0D0
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }
}
