internal static class ShadowRendering // TypeDefIndex: 8731
{
	// Fields
	private static readonly int k_LightPosID; // 0x0
	private static readonly int k_SelfShadowingID; // 0x4
	private static readonly int k_ShadowStencilGroupID; // 0x8
	private static readonly int k_ShadowIntensityID; // 0xC
	private static readonly int k_ShadowVolumeIntensityID; // 0x10
	private static readonly int k_ShadowRadiusID; // 0x14
	private static readonly int k_ShadowColorMaskID; // 0x18
	private static readonly int k_ShadowModelMatrixID; // 0x1C
	private static readonly int k_ShadowModelInvMatrixID; // 0x20
	private static readonly int k_ShadowModelScaleID; // 0x24
	private static readonly ProfilingSampler m_ProfilingSamplerShadows; // 0x28
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsA; // 0x30
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsR; // 0x38
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsG; // 0x40
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsB; // 0x48
	private static RTHandle[] m_RenderTargets; // 0x50
	private static int[] m_RenderTargetIds; // 0x58
	private static RenderTargetIdentifier[] m_LightInputTextures; // 0x60
	private static readonly Color[] k_ColorLookup; // 0x68
	private static readonly ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup; // 0x70
	[CompilerGenerated]
	private static uint <maxTextureCount>k__BackingField; // 0x78

	// Properties
	public static uint maxTextureCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2AD3310 Offset: 0x2AD1D10 VA: 0x182AD3310
	public static uint get_maxTextureCount() { }

	[CompilerGenerated]
	// RVA: 0x2AD3360 Offset: 0x2AD1D60 VA: 0x182AD3360
	private static void set_maxTextureCount(uint value) { }

	// RVA: 0x2AD0FF0 Offset: 0x2ACF9F0 VA: 0x182AD0FF0
	public static void InitializeBudget(uint maxTextureCount) { }

	// RVA: 0x2AD03B0 Offset: 0x2ACEDB0 VA: 0x182AD03B0
	private static Material[] CreateMaterials(Shader shader, int pass = 0) { }

	[Extension]
	// RVA: 0x2AD0B30 Offset: 0x2ACF530 VA: 0x182AD0B30
	private static Material GetProjectedShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	// RVA: 0x2AD0EC0 Offset: 0x2ACF8C0 VA: 0x182AD0EC0
	private static Material GetStencilOnlyShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	// RVA: 0x2AD0C60 Offset: 0x2ACF660 VA: 0x182AD0C60
	private static Material GetSpriteSelfShadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	// RVA: 0x2AD0D90 Offset: 0x2ACF790 VA: 0x182AD0D90
	private static Material GetSpriteUnshadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	[Extension]
	// RVA: 0x2AD0A00 Offset: 0x2ACF400 VA: 0x182AD0A00
	private static Material GetGeometryUnshadowMaterial(Renderer2DData rendererData, int colorIndex) { }

	// RVA: 0x2AD0540 Offset: 0x2ACEF40 VA: 0x182AD0540
	public static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex) { }

	// RVA: 0x2AD1490 Offset: 0x2ACFE90 VA: 0x182AD1490
	public static bool PrerenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, int shadowIndex, float shadowIntensity) { }

	// RVA: 0x2AD2950 Offset: 0x2AD1350 VA: 0x182AD2950
	public static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex) { }

	// RVA: 0x2AD0960 Offset: 0x2ACF360 VA: 0x182AD0960
	public static void DisableGlobalShadowTexture(CommandBuffer cmdBuffer) { }

	// RVA: 0x2AD07C0 Offset: 0x2ACF1C0 VA: 0x182AD07C0
	private static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer) { }

	// RVA: 0x2AD1770 Offset: 0x2AD0170 VA: 0x182AD1770
	public static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex) { }

	// RVA: 0x2AD2B00 Offset: 0x2AD1500 VA: 0x182AD2B00
	public static void SetShadowProjectionGlobals(CommandBuffer cmdBuffer, ShadowCaster2D shadowCaster) { }

	// RVA: 0x2AD1820 Offset: 0x2AD0220 VA: 0x182AD1820
	public static bool RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, int colorBit) { }

	// RVA: 0x2AD2C70 Offset: 0x2AD1670 VA: 0x182AD2C70
	private static void .cctor() { }
}
