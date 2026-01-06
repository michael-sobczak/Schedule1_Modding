public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver // TypeDefIndex: 8759
{
	// Fields
	private Shader m_DefaultShader; // 0x18
	private ScriptableRenderer[] m_Renderers; // 0x20
	[SerializeField]
	private int k_AssetVersion; // 0x28
	[SerializeField]
	private int k_AssetPreviousVersion; // 0x2C
	[SerializeField]
	private RendererType m_RendererType; // 0x30
	[EditorBrowsable(1)]
	[Obsolete("Use m_RendererDataList instead.")]
	[SerializeField]
	internal ScriptableRendererData m_RendererData; // 0x38
	[SerializeField]
	internal ScriptableRendererData[] m_RendererDataList; // 0x40
	[SerializeField]
	internal int m_DefaultRendererIndex; // 0x48
	[SerializeField]
	private bool m_RequireDepthTexture; // 0x4C
	[SerializeField]
	private bool m_RequireOpaqueTexture; // 0x4D
	[SerializeField]
	private Downsampling m_OpaqueDownsampling; // 0x50
	[SerializeField]
	private bool m_SupportsTerrainHoles; // 0x54
	[SerializeField]
	private bool m_SupportsHDR; // 0x55
	[SerializeField]
	private HDRColorBufferPrecision m_HDRColorBufferPrecision; // 0x58
	[SerializeField]
	private MsaaQuality m_MSAA; // 0x5C
	[SerializeField]
	private float m_RenderScale; // 0x60
	[SerializeField]
	private UpscalingFilterSelection m_UpscalingFilter; // 0x64
	[SerializeField]
	private bool m_FsrOverrideSharpness; // 0x68
	[SerializeField]
	private float m_FsrSharpness; // 0x6C
	[SerializeField]
	private bool m_EnableLODCrossFade; // 0x70
	[SerializeField]
	private LODCrossFadeDitheringType m_LODCrossFadeDitheringType; // 0x74
	[SerializeField]
	private ShEvalMode m_ShEvalMode; // 0x78
	[SerializeField]
	private LightRenderingMode m_MainLightRenderingMode; // 0x7C
	[SerializeField]
	private bool m_MainLightShadowsSupported; // 0x80
	[SerializeField]
	private ShadowResolution m_MainLightShadowmapResolution; // 0x84
	[SerializeField]
	private LightRenderingMode m_AdditionalLightsRenderingMode; // 0x88
	[SerializeField]
	private int m_AdditionalLightsPerObjectLimit; // 0x8C
	[SerializeField]
	private bool m_AdditionalLightShadowsSupported; // 0x90
	[SerializeField]
	private ShadowResolution m_AdditionalLightsShadowmapResolution; // 0x94
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierLow; // 0x98
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierMedium; // 0x9C
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierHigh; // 0xA0
	[SerializeField]
	private bool m_ReflectionProbeBlending; // 0xA4
	[SerializeField]
	private bool m_ReflectionProbeBoxProjection; // 0xA5
	[SerializeField]
	private float m_ShadowDistance; // 0xA8
	[SerializeField]
	private int m_ShadowCascadeCount; // 0xAC
	[SerializeField]
	private float m_Cascade2Split; // 0xB0
	[SerializeField]
	private Vector2 m_Cascade3Split; // 0xB4
	[SerializeField]
	private Vector3 m_Cascade4Split; // 0xBC
	[SerializeField]
	private float m_CascadeBorder; // 0xC8
	[SerializeField]
	private float m_ShadowDepthBias; // 0xCC
	[SerializeField]
	private float m_ShadowNormalBias; // 0xD0
	[SerializeField]
	private bool m_SoftShadowsSupported; // 0xD4
	[SerializeField]
	private bool m_ConservativeEnclosingSphere; // 0xD5
	[SerializeField]
	private int m_NumIterationsEnclosingSphere; // 0xD8
	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality; // 0xDC
	[SerializeField]
	private LightCookieResolution m_AdditionalLightsCookieResolution; // 0xE0
	[SerializeField]
	private LightCookieFormat m_AdditionalLightsCookieFormat; // 0xE4
	[SerializeField]
	private bool m_UseSRPBatcher; // 0xE8
	[SerializeField]
	private bool m_SupportsDynamicBatching; // 0xE9
	[SerializeField]
	private bool m_MixedLightingSupported; // 0xEA
	[SerializeField]
	private bool m_SupportsLightCookies; // 0xEB
	[SerializeField]
	private bool m_SupportsLightLayers; // 0xEC
	[SerializeField]
	[Obsolete]
	private PipelineDebugLevel m_DebugLevel; // 0xF0
	[SerializeField]
	private StoreActionsOptimization m_StoreActionsOptimization; // 0xF4
	[SerializeField]
	private bool m_EnableRenderGraph; // 0xF8
	[SerializeField]
	private bool m_UseAdaptivePerformance; // 0xF9
	[SerializeField]
	private ColorGradingMode m_ColorGradingMode; // 0xFC
	[SerializeField]
	private int m_ColorGradingLutSize; // 0x100
	[SerializeField]
	private bool m_UseFastSRGBLinearConversion; // 0x104
	[SerializeField]
	private bool m_SupportDataDrivenLensFlare; // 0x105
	[SerializeField]
	private ShadowQuality m_ShadowType; // 0x108
	[SerializeField]
	private bool m_LocalShadowsSupported; // 0x10C
	[SerializeField]
	private ShadowResolution m_LocalShadowsAtlasResolution; // 0x110
	[SerializeField]
	private int m_MaxPixelLights; // 0x114
	[SerializeField]
	private ShadowResolution m_ShadowAtlasResolution; // 0x118
	[SerializeField]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode; // 0x11C
	[SerializeField]
	private UniversalRenderPipelineAsset.TextureResources m_Textures; // 0x120
	public const int k_MinLutSize = 16;
	public const int k_MaxLutSize = 65;
	internal const int k_ShadowCascadeMinCount = 1;
	internal const int k_ShadowCascadeMaxCount = 4;
	public static readonly int AdditionalLightsDefaultShadowResolutionTierLow; // 0x0
	public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium; // 0x4
	public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh; // 0x8
	private static GraphicsFormat[][] s_LightCookieFormatList; // 0x10
	[SerializeField]
	private int m_ShaderVariantLogLevel; // 0x128
	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
	[SerializeField]
	private ShadowCascadesOption m_ShadowCascades; // 0x12C

	// Properties
	public ScriptableRenderer scriptableRenderer { get; }
	internal ScriptableRendererData scriptableRendererData { get; }
	internal GraphicsFormat additionalLightsCookieFormat { get; }
	internal Vector2Int additionalLightsCookieResolution { get; }
	internal int[] rendererIndexList { get; }
	public bool supportsCameraDepthTexture { get; set; }
	public bool supportsCameraOpaqueTexture { get; set; }
	public Downsampling opaqueDownsampling { get; }
	public bool supportsTerrainHoles { get; }
	public StoreActionsOptimization storeActionsOptimization { get; set; }
	public bool supportsHDR { get; set; }
	public HDRColorBufferPrecision hdrColorBufferPrecision { get; set; }
	public int msaaSampleCount { get; set; }
	public float renderScale { get; set; }
	public bool enableLODCrossFade { get; }
	public LODCrossFadeDitheringType lodCrossFadeDitheringType { get; }
	public UpscalingFilterSelection upscalingFilter { get; set; }
	public bool fsrOverrideSharpness { get; set; }
	public float fsrSharpness { get; set; }
	public ShEvalMode shEvalMode { get; set; }
	public LightRenderingMode mainLightRenderingMode { get; set; }
	public bool supportsMainLightShadows { get; set; }
	public int mainLightShadowmapResolution { get; set; }
	public LightRenderingMode additionalLightsRenderingMode { get; set; }
	public int maxAdditionalLightsCount { get; set; }
	public bool supportsAdditionalLightShadows { get; set; }
	public int additionalLightsShadowmapResolution { get; set; }
	public int additionalLightsShadowResolutionTierLow { get; set; }
	public int additionalLightsShadowResolutionTierMedium { get; set; }
	public int additionalLightsShadowResolutionTierHigh { get; set; }
	public bool reflectionProbeBlending { get; set; }
	public bool reflectionProbeBoxProjection { get; set; }
	public float shadowDistance { get; set; }
	public int shadowCascadeCount { get; set; }
	public float cascade2Split { get; set; }
	public Vector2 cascade3Split { get; set; }
	public Vector3 cascade4Split { get; set; }
	public float cascadeBorder { get; set; }
	public float shadowDepthBias { get; set; }
	public float shadowNormalBias { get; set; }
	public bool supportsSoftShadows { get; set; }
	internal SoftShadowQuality softShadowQuality { get; set; }
	public bool supportsDynamicBatching { get; set; }
	public bool supportsMixedLighting { get; }
	public bool supportsLightCookies { get; }
	[Obsolete("This is obsolete, UnityEngine.Rendering.ShaderVariantLogLevel instead.", False)]
	public bool supportsLightLayers { get; }
	public bool useRenderingLayers { get; }
	public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode { get; }
	[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary.", False)]
	public PipelineDebugLevel debugLevel { get; }
	public bool useSRPBatcher { get; set; }
	internal bool enableRenderGraph { get; set; }
	public ColorGradingMode colorGradingMode { get; set; }
	public int colorGradingLutSize { get; set; }
	public bool useFastSRGBLinearConversion { get; }
	public bool supportDataDrivenLensFlare { get; }
	public bool useAdaptivePerformance { get; set; }
	public bool conservativeEnclosingSphere { get; set; }
	public int numIterationsEnclosingSphere { get; set; }
	public override Material defaultMaterial { get; }
	public override Material defaultParticleMaterial { get; }
	public override Material defaultLineMaterial { get; }
	public override Material defaultTerrainMaterial { get; }
	public override Material defaultUIMaterial { get; }
	public override Material defaultUIOverdrawMaterial { get; }
	public override Material defaultUIETC1SupportedMaterial { get; }
	public override Material default2DMaterial { get; }
	public override Material default2DMaskMaterial { get; }
	public Material decalMaterial { get; }
	public override Shader defaultShader { get; }
	public override string[] renderingLayerMaskNames { get; }
	public override string[] prefixedRenderingLayerMaskNames { get; }
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string[] lightLayerMaskNames { get; }
	public UniversalRenderPipelineAsset.TextureResources textures { get; }
	[Obsolete("Use UniversalRenderPipelineGlobalSettings.instance.shaderVariantLogLevel", False)]
	public ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
	public ShadowCascadesOption shadowCascadeOption { get; set; }

	// Methods

	// RVA: 0x2AD8EF0 Offset: 0x2AD78F0 VA: 0x182AD8EF0
	public ScriptableRendererData LoadBuiltinRendererData(RendererType type = 1) { }

	// RVA: 0x2AD8530 Offset: 0x2AD6F30 VA: 0x182AD8530 Slot: 25
	protected override RenderPipeline CreatePipeline() { }

	// RVA: 0x2AD8AA0 Offset: 0x2AD74A0 VA: 0x182AD8AA0
	internal void DestroyRenderers() { }

	// RVA: 0x2AD8A60 Offset: 0x2AD7460 VA: 0x182AD8A60
	private void DestroyRenderer(ref ScriptableRenderer renderer) { }

	// RVA: 0x2AD91F0 Offset: 0x2AD7BF0 VA: 0x182AD91F0 Slot: 27
	protected override void OnDisable() { }

	// RVA: 0x2AD8800 Offset: 0x2AD7200 VA: 0x182AD8800
	private void CreateRenderers() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private Material GetMaterial(DefaultMaterialType materialType) { }

	// RVA: 0x2AD9F00 Offset: 0x2AD8900 VA: 0x182AD9F00
	public ScriptableRenderer get_scriptableRenderer() { }

	// RVA: 0x2AD8C20 Offset: 0x2AD7620 VA: 0x182AD8C20
	public ScriptableRenderer GetRenderer(int index) { }

	// RVA: 0x2AD9E50 Offset: 0x2AD8850 VA: 0x182AD9E50
	internal ScriptableRendererData get_scriptableRendererData() { }

	// RVA: 0x2AD99B0 Offset: 0x2AD83B0 VA: 0x182AD99B0
	internal GraphicsFormat get_additionalLightsCookieFormat() { }

	// RVA: 0x2AD9BD0 Offset: 0x2AD85D0 VA: 0x182AD9BD0
	internal Vector2Int get_additionalLightsCookieResolution() { }

	// RVA: 0x2AD9D70 Offset: 0x2AD8770 VA: 0x182AD9D70
	internal int[] get_rendererIndexList() { }

	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	public bool get_supportsCameraDepthTexture() { }

	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	public void set_supportsCameraDepthTexture(bool value) { }

	// RVA: 0x4B5410 Offset: 0x4B3E10 VA: 0x1804B5410
	public bool get_supportsCameraOpaqueTexture() { }

	// RVA: 0x26D5E70 Offset: 0x26D4870 VA: 0x1826D5E70
	public void set_supportsCameraOpaqueTexture(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public Downsampling get_opaqueDownsampling() { }

	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool get_supportsTerrainHoles() { }

	// RVA: 0xD9E760 Offset: 0xD9D160 VA: 0x180D9E760
	public StoreActionsOptimization get_storeActionsOptimization() { }

	// RVA: 0xD9EBD0 Offset: 0xD9D5D0 VA: 0x180D9EBD0
	public void set_storeActionsOptimization(StoreActionsOptimization value) { }

	// RVA: 0x2519EA0 Offset: 0x25188A0 VA: 0x182519EA0
	public bool get_supportsHDR() { }

	// RVA: 0x2ADA790 Offset: 0x2AD9190 VA: 0x182ADA790
	public void set_supportsHDR(bool value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public HDRColorBufferPrecision get_hdrColorBufferPrecision() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_hdrColorBufferPrecision(HDRColorBufferPrecision value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public int get_msaaSampleCount() { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	public void set_msaaSampleCount(int value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_renderScale() { }

	// RVA: 0x2ADA3F0 Offset: 0x2AD8DF0 VA: 0x182ADA3F0
	public void set_renderScale(float value) { }

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_enableLODCrossFade() { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public LODCrossFadeDitheringType get_lodCrossFadeDitheringType() { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public UpscalingFilterSelection get_upscalingFilter() { }

	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_upscalingFilter(UpscalingFilterSelection value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_fsrOverrideSharpness() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_fsrOverrideSharpness(bool value) { }

	// RVA: 0x4CD190 Offset: 0x4CBB90 VA: 0x1804CD190
	public float get_fsrSharpness() { }

	// RVA: 0xA7BCA0 Offset: 0xA7A6A0 VA: 0x180A7BCA0
	public void set_fsrSharpness(float value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public ShEvalMode get_shEvalMode() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	internal void set_shEvalMode(ShEvalMode value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public LightRenderingMode get_mainLightRenderingMode() { }

	// RVA: 0xD9EBC0 Offset: 0xD9D5C0 VA: 0x180D9EBC0
	internal void set_mainLightRenderingMode(LightRenderingMode value) { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_supportsMainLightShadows() { }

	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	internal void set_supportsMainLightShadows(bool value) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public int get_mainLightShadowmapResolution() { }

	// RVA: 0x9883D0 Offset: 0x986DD0 VA: 0x1809883D0
	internal void set_mainLightShadowmapResolution(int value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	public LightRenderingMode get_additionalLightsRenderingMode() { }

	// RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	internal void set_additionalLightsRenderingMode(LightRenderingMode value) { }

	// RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0
	public int get_maxAdditionalLightsCount() { }

	// RVA: 0x2ADA350 Offset: 0x2AD8D50 VA: 0x182ADA350
	public void set_maxAdditionalLightsCount(int value) { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	public bool get_supportsAdditionalLightShadows() { }

	// RVA: 0x979B10 Offset: 0x978510 VA: 0x180979B10
	internal void set_supportsAdditionalLightShadows(bool value) { }

	// RVA: 0x1D0F570 Offset: 0x1D0DF70 VA: 0x181D0F570
	public int get_additionalLightsShadowmapResolution() { }

	// RVA: 0x286EEE0 Offset: 0x286D8E0 VA: 0x18286EEE0
	internal void set_additionalLightsShadowmapResolution(int value) { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_additionalLightsShadowResolutionTierLow() { }

	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	internal void set_additionalLightsShadowResolutionTierLow(int value) { }

	// RVA: 0x614470 Offset: 0x612E70 VA: 0x180614470
	public int get_additionalLightsShadowResolutionTierMedium() { }

	// RVA: 0x286EEA0 Offset: 0x286D8A0 VA: 0x18286EEA0
	internal void set_additionalLightsShadowResolutionTierMedium(int value) { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public int get_additionalLightsShadowResolutionTierHigh() { }

	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	internal void set_additionalLightsShadowResolutionTierHigh(int value) { }

	// RVA: 0x2AD8B50 Offset: 0x2AD7550 VA: 0x182AD8B50
	internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier) { }

	// RVA: 0x8B3440 Offset: 0x8B1E40 VA: 0x1808B3440
	public bool get_reflectionProbeBlending() { }

	// RVA: 0x8B3530 Offset: 0x8B1F30 VA: 0x1808B3530
	internal void set_reflectionProbeBlending(bool value) { }

	// RVA: 0x8B3420 Offset: 0x8B1E20 VA: 0x1808B3420
	public bool get_reflectionProbeBoxProjection() { }

	// RVA: 0x8B3510 Offset: 0x8B1F10 VA: 0x1808B3510
	internal void set_reflectionProbeBoxProjection(bool value) { }

	// RVA: 0x2ADA240 Offset: 0x2AD8C40 VA: 0x182ADA240
	public float get_shadowDistance() { }

	// RVA: 0x2ADA6F0 Offset: 0x2AD90F0 VA: 0x182ADA6F0
	public void set_shadowDistance(float value) { }

	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	public int get_shadowCascadeCount() { }

	// RVA: 0x2ADA4D0 Offset: 0x2AD8ED0 VA: 0x182ADA4D0
	public void set_shadowCascadeCount(int value) { }

	// RVA: 0x7C1800 Offset: 0x7C0200 VA: 0x1807C1800
	public float get_cascade2Split() { }

	// RVA: 0x7C2590 Offset: 0x7C0F90 VA: 0x1807C2590
	internal void set_cascade2Split(float value) { }

	// RVA: 0x2AD9BF0 Offset: 0x2AD85F0 VA: 0x182AD9BF0
	public Vector2 get_cascade3Split() { }

	// RVA: 0x1D819F0 Offset: 0x1D803F0 VA: 0x181D819F0
	internal void set_cascade3Split(Vector2 value) { }

	// RVA: 0x10F95E0 Offset: 0x10F7FE0 VA: 0x1810F95E0
	public Vector3 get_cascade4Split() { }

	// RVA: 0x10F99B0 Offset: 0x10F83B0 VA: 0x1810F99B0
	internal void set_cascade4Split(Vector3 value) { }

	// RVA: 0x526FD0 Offset: 0x5259D0 VA: 0x180526FD0
	public float get_cascadeBorder() { }

	// RVA: 0x98CB10 Offset: 0x98B510 VA: 0x18098CB10
	public void set_cascadeBorder(float value) { }

	// RVA: 0x673C50 Offset: 0x672650 VA: 0x180673C50
	public float get_shadowDepthBias() { }

	// RVA: 0x2ADA680 Offset: 0x2AD9080 VA: 0x182ADA680
	public void set_shadowDepthBias(float value) { }

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_shadowNormalBias() { }

	// RVA: 0x2ADA710 Offset: 0x2AD9110 VA: 0x182ADA710
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x2389970 Offset: 0x2388370 VA: 0x182389970
	public bool get_supportsSoftShadows() { }

	// RVA: 0x238A630 Offset: 0x2389030 VA: 0x18238A630
	internal void set_supportsSoftShadows(bool value) { }

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	internal SoftShadowQuality get_softShadowQuality() { }

	// RVA: 0xB39BD0 Offset: 0xB385D0 VA: 0x180B39BD0
	internal void set_softShadowQuality(SoftShadowQuality value) { }

	// RVA: 0x5233B0 Offset: 0x521DB0 VA: 0x1805233B0
	public bool get_supportsDynamicBatching() { }

	// RVA: 0x2ADA780 Offset: 0x2AD9180 VA: 0x182ADA780
	public void set_supportsDynamicBatching(bool value) { }

	// RVA: 0x2ADA280 Offset: 0x2AD8C80 VA: 0x182ADA280
	public bool get_supportsMixedLighting() { }

	// RVA: 0x2ADA260 Offset: 0x2AD8C60 VA: 0x182ADA260
	public bool get_supportsLightCookies() { }

	// RVA: 0x2ADA270 Offset: 0x2AD8C70 VA: 0x182ADA270
	public bool get_supportsLightLayers() { }

	// RVA: 0x2ADA270 Offset: 0x2AD8C70 VA: 0x182ADA270
	public bool get_useRenderingLayers() { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public PipelineDebugLevel get_debugLevel() { }

	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_useSRPBatcher() { }

	// RVA: 0x9B36D0 Offset: 0x9B20D0 VA: 0x1809B36D0
	public void set_useSRPBatcher(bool value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	internal bool get_enableRenderGraph() { }

	// RVA: 0x1A3AEE0 Offset: 0x1A398E0 VA: 0x181A3AEE0
	internal void set_enableRenderGraph(bool value) { }

	// RVA: 0x5232A0 Offset: 0x521CA0 VA: 0x1805232A0
	public ColorGradingMode get_colorGradingMode() { }

	// RVA: 0x7C2510 Offset: 0x7C0F10 VA: 0x1807C2510
	public void set_colorGradingMode(ColorGradingMode value) { }

	// RVA: 0x2302490 Offset: 0x2300E90 VA: 0x182302490
	public int get_colorGradingLutSize() { }

	// RVA: 0x2ADA310 Offset: 0x2AD8D10 VA: 0x182ADA310
	public void set_colorGradingLutSize(int value) { }

	// RVA: 0xAF0550 Offset: 0xAEEF50 VA: 0x180AF0550
	public bool get_useFastSRGBLinearConversion() { }

	// RVA: 0x2ADA250 Offset: 0x2AD8C50 VA: 0x182ADA250
	public bool get_supportDataDrivenLensFlare() { }

	// RVA: 0x51DBD0 Offset: 0x51C5D0 VA: 0x18051DBD0
	public bool get_useAdaptivePerformance() { }

	// RVA: 0x2ADA7A0 Offset: 0x2AD91A0 VA: 0x182ADA7A0
	public void set_useAdaptivePerformance(bool value) { }

	// RVA: 0x2AD9C10 Offset: 0x2AD8610 VA: 0x182AD9C10
	public bool get_conservativeEnclosingSphere() { }

	// RVA: 0x2ADA340 Offset: 0x2AD8D40 VA: 0x182ADA340
	public void set_conservativeEnclosingSphere(bool value) { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	public int get_numIterationsEnclosingSphere() { }

	// RVA: 0xB39BE0 Offset: 0xB385E0 VA: 0x180B39BE0
	public void set_numIterationsEnclosingSphere(int value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override Material get_defaultMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 13
	public override Material get_defaultParticleMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	public override Material get_defaultLineMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public override Material get_defaultTerrainMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public override Material get_defaultUIMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public override Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public override Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public override Material get_default2DMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 20
	public override Material get_default2DMaskMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public Material get_decalMaterial() { }

	// RVA: 0x2AD9C20 Offset: 0x2AD8620 VA: 0x182AD9C20 Slot: 21
	public override Shader get_defaultShader() { }

	// RVA: 0x2AD9DF0 Offset: 0x2AD87F0 VA: 0x182AD9DF0 Slot: 4
	public override string[] get_renderingLayerMaskNames() { }

	// RVA: 0x2AD9D10 Offset: 0x2AD8710 VA: 0x182AD9D10 Slot: 5
	public override string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x2AD9CD0 Offset: 0x2AD86D0 VA: 0x182AD9CD0
	public string[] get_lightLayerMaskNames() { }

	// RVA: 0x2ADA290 Offset: 0x2AD8C90 VA: 0x182ADA290
	public UniversalRenderPipelineAsset.TextureResources get_textures() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	public void OnBeforeSerialize() { }

	// RVA: 0x2AD8F40 Offset: 0x2AD7940 VA: 0x182AD8F40 Slot: 29
	public void OnAfterDeserialize() { }

	// RVA: 0x2AD94C0 Offset: 0x2AD7EC0 VA: 0x182AD94C0
	private float ValidateShadowBias(float value) { }

	// RVA: 0x2AD9210 Offset: 0x2AD7C10 VA: 0x182AD9210
	private int ValidatePerObjectLights(int value) { }

	// RVA: 0x2AD92A0 Offset: 0x2AD7CA0 VA: 0x182AD92A0
	private float ValidateRenderScale(float value) { }

	// RVA: 0x2AD9310 Offset: 0x2AD7D10 VA: 0x182AD9310
	internal bool ValidateRendererDataList(bool partial = False) { }

	// RVA: 0x2AD9420 Offset: 0x2AD7E20 VA: 0x182AD9420
	internal bool ValidateRendererData(int index) { }

	// RVA: 0x2ADA150 Offset: 0x2AD8B50 VA: 0x182ADA150
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	// RVA: 0x2ADA470 Offset: 0x2AD8E70 VA: 0x182ADA470
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	// RVA: 0x2ADA1B0 Offset: 0x2AD8BB0 VA: 0x182ADA1B0
	public ShadowCascadesOption get_shadowCascadeOption() { }

	// RVA: 0x2ADA5E0 Offset: 0x2AD8FE0 VA: 0x182ADA5E0
	public void set_shadowCascadeOption(ShadowCascadesOption value) { }

	// RVA: 0x2AD9760 Offset: 0x2AD8160 VA: 0x182AD9760
	public void .ctor() { }

	// RVA: 0x2AD9520 Offset: 0x2AD7F20 VA: 0x182AD9520
	private static void .cctor() { }
}
