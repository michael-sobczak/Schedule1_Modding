internal static class RendererLighting // TypeDefIndex: 8718
{
	// Fields
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private static readonly ShaderTagId k_NormalsRenderingPassName; // 0x8
	private static readonly Color k_NormalClearColor; // 0xC
	private static readonly string k_SpriteLightKeyword; // 0x20
	private static readonly string k_UsePointLightCookiesKeyword; // 0x28
	private static readonly string k_LightQualityFastKeyword; // 0x30
	private static readonly string k_UseNormalMap; // 0x38
	private static readonly string k_UseAdditiveBlendingKeyword; // 0x40
	private static readonly string[] k_UseBlendStyleKeywords; // 0x48
	private static readonly int[] k_BlendFactorsPropIDs; // 0x50
	private static readonly int[] k_MaskFilterPropIDs; // 0x58
	private static readonly int[] k_InvertedFilterPropIDs; // 0x60
	private static GraphicsFormat s_RenderTextureFormatToUse; // 0x68
	private static bool s_HasSetupRenderTextureFormatToUse; // 0x6C
	private static readonly int k_SrcBlendID; // 0x70
	private static readonly int k_DstBlendID; // 0x74
	private static readonly int k_FalloffIntensityID; // 0x78
	private static readonly int k_FalloffDistanceID; // 0x7C
	private static readonly int k_LightColorID; // 0x80
	private static readonly int k_VolumeOpacityID; // 0x84
	private static readonly int k_CookieTexID; // 0x88
	private static readonly int k_FalloffLookupID; // 0x8C
	private static readonly int k_LightPositionID; // 0x90
	private static readonly int k_LightInvMatrixID; // 0x94
	private static readonly int k_InnerRadiusMultID; // 0x98
	private static readonly int k_OuterAngleID; // 0x9C
	private static readonly int k_InnerAngleMultID; // 0xA0
	private static readonly int k_LightLookupID; // 0xA4
	private static readonly int k_IsFullSpotlightID; // 0xA8
	private static readonly int k_LightZDistanceID; // 0xAC
	private static readonly int k_PointLightCookieTexID; // 0xB0

	// Methods

	// RVA: 0x2A8A010 Offset: 0x2A88A10 VA: 0x182A8A010
	private static GraphicsFormat GetRenderTextureFormat() { }

	[Extension]
	// RVA: 0x2A89560 Offset: 0x2A87F60 VA: 0x182A89560
	public static void CreateNormalMapRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale) { }

	[Extension]
	// RVA: 0x2A89AD0 Offset: 0x2A884D0 VA: 0x182A89AD0
	public static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(IRenderPass2D pass, RenderingData renderingData) { }

	[Extension]
	// RVA: 0x2A88FC0 Offset: 0x2A879C0 VA: 0x182A88FC0
	public static void CreateCameraSortingLayerRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod) { }

	// RVA: 0x2A89A10 Offset: 0x2A88410 VA: 0x182A89A10
	public static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled) { }

	[Extension]
	// RVA: 0x2A897E0 Offset: 0x2A881E0 VA: 0x182A897E0
	public static void DisableAllKeywords(IRenderPass2D pass, CommandBuffer cmd) { }

	[Extension]
	// RVA: 0x2A8A300 Offset: 0x2A88D00 VA: 0x182A8A300
	public static void ReleaseRenderTextures(IRenderPass2D pass, CommandBuffer cmd) { }

	// RVA: 0x2A898A0 Offset: 0x2A882A0 VA: 0x182A898A0
	public static void DrawPointLight(CommandBuffer cmd, Light2D light, Mesh lightMesh, Material material) { }

	// RVA: 0x2A88C80 Offset: 0x2A87680 VA: 0x182A88C80
	private static bool CanCastShadows(Light2D light, int layerToRender) { }

	// RVA: 0x2A88D00 Offset: 0x2A87700 VA: 0x182A88D00
	private static bool CanCastVolumetricShadows(Light2D light, int endLayerValue) { }

	// RVA: 0x2A8CE80 Offset: 0x2A8B880 VA: 0x182A8CE80
	private static bool ShouldRenderLight(Light2D light, int blendStyleIndex, int layerToRender) { }

	// RVA: 0x2A8A410 Offset: 0x2A88E10 VA: 0x182A8A410
	private static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, List<Light2D> lights) { }

	[Extension]
	// RVA: 0x2A8ACF0 Offset: 0x2A896F0 VA: 0x182A8ACF0
	public static void RenderLightVolumes(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, int endLayerValue, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights) { }

	[Extension]
	// RVA: 0x2A8CAF0 Offset: 0x2A8B4F0 VA: 0x182A8CAF0
	public static void SetShapeLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd) { }

	// RVA: 0x2A89FE0 Offset: 0x2A889E0 VA: 0x182A89FE0
	private static float GetNormalizedInnerRadius(Light2D light) { }

	// RVA: 0x2A89FD0 Offset: 0x2A889D0 VA: 0x182A89FD0
	private static float GetNormalizedAngle(float angle) { }

	// RVA: 0x2A8A150 Offset: 0x2A88B50 VA: 0x182A8A150
	private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix) { }

	// RVA: 0x2A8C280 Offset: 0x2A8AC80 VA: 0x182A8C280
	private static void SetGeneralLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light) { }

	// RVA: 0x2A8C410 Offset: 0x2A8AE10 VA: 0x182A8C410
	private static void SetPointLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light) { }

	[Extension]
	// RVA: 0x2A88D60 Offset: 0x2A87760 VA: 0x182A88D60
	public static void ClearDirtyLighting(IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed) { }

	[Extension]
	// RVA: 0x2A8BAB0 Offset: 0x2A8A4B0 VA: 0x182A8BAB0
	internal static void RenderNormals(IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget, ref bool bFirstClear) { }

	[Extension]
	// RVA: 0x2A8B580 Offset: 0x2A89F80 VA: 0x182A8B580
	public static void RenderLights(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc) { }

	// RVA: 0x2A8C1D0 Offset: 0x2A8ABD0 VA: 0x182A8C1D0
	private static void SetBlendModes(Material material, BlendMode src, BlendMode dst) { }

	// RVA: 0x2A89C20 Offset: 0x2A88620 VA: 0x182A89C20
	private static uint GetLightMaterialIndex(Light2D light, bool isVolume) { }

	// RVA: 0x2A89170 Offset: 0x2A87B70 VA: 0x182A89170
	private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	[Extension]
	// RVA: 0x2A89D90 Offset: 0x2A88790 VA: 0x182A89D90
	private static Material GetLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	// RVA: 0x2A8CF20 Offset: 0x2A8B920 VA: 0x182A8CF20
	private static void .cctor() { }
}
