public class Config : ScriptableObject // TypeDefIndex: 227
{
	// Fields
	public const string ClassName = "Config";
	public const string kAssetName = "VLBConfigOverride";
	public const string kAssetNameExt = ".asset";
	public bool geometryOverrideLayer; // 0x18
	public int geometryLayerID; // 0x1C
	public string geometryTag; // 0x20
	public int geometryRenderQueue; // 0x28
	public int geometryRenderQueueHD; // 0x2C
	[FormerlySerializedAs("renderPipeline")]
	[FormerlySerializedAs("_RenderPipeline")]
	[SerializeField]
	private RenderPipeline m_RenderPipeline; // 0x30
	[FormerlySerializedAs("renderingMode")]
	[FormerlySerializedAs("_RenderingMode")]
	[SerializeField]
	private RenderingMode m_RenderingMode; // 0x34
	public float ditheringFactor; // 0x38
	public bool useLightColorTemperature; // 0x3C
	public int sharedMeshSides; // 0x40
	public int sharedMeshSegments; // 0x44
	public float hdBeamsCameraBlendingDistance; // 0x48
	public int urpDepthCameraScriptableRendererIndex; // 0x4C
	[Range(0.01, 2)]
	public float globalNoiseScale; // 0x50
	public Vector3 globalNoiseVelocity; // 0x54
	public string fadeOutCameraTag; // 0x60
	[HighlightNull]
	public Texture3D noiseTexture3D; // 0x68
	[HighlightNull]
	public ParticleSystem dustParticlesPrefab; // 0x70
	[HighlightNull]
	public Texture2D ditheringNoiseTexture; // 0x78
	[HighlightNull]
	public Texture2D jitteringNoiseTexture; // 0x80
	public FeatureEnabledColorGradient featureEnabledColorGradient; // 0x88
	public bool featureEnabledDepthBlend; // 0x8C
	public bool featureEnabledNoise3D; // 0x8D
	public bool featureEnabledDynamicOcclusion; // 0x8E
	public bool featureEnabledMeshSkewing; // 0x8F
	public bool featureEnabledShaderAccuracyHigh; // 0x90
	public bool featureEnabledShadow; // 0x91
	public bool featureEnabledCookie; // 0x92
	[SerializeField]
	private RaymarchingQuality[] m_RaymarchingQualities; // 0x98
	[SerializeField]
	private int m_DefaultRaymarchingQualityUniqueID; // 0xA0
	[SerializeField]
	private int pluginVersion; // 0xA4
	[SerializeField]
	private Material _DummyMaterial; // 0xA8
	[SerializeField]
	private Material _DummyMaterialHD; // 0xB0
	[SerializeField]
	private Shader _BeamShader; // 0xB8
	[SerializeField]
	private Shader _BeamShaderHD; // 0xC0
	private Transform m_CachedFadeOutCamera; // 0xC8
	private static Config ms_Instance; // 0x0

	// Properties
	public RenderPipeline renderPipeline { get; set; }
	public RenderingMode renderingMode { get; set; }
	public bool SD_useSinglePassShader { get; }
	public bool SD_requiresDoubleSidedMesh { get; }
	public Transform fadeOutCameraTransform { get; }
	public int defaultRaymarchingQualityUniqueID { get; }
	public int raymarchingQualitiesCount { get; }
	public bool isHDRPExposureWeightSupported { get; }
	public bool hasRenderPipelineMismatch { get; }
	public static Config Instance { get; }

	// Methods

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public RenderPipeline get_renderPipeline() { }

	// RVA: 0x697620 Offset: 0x696020 VA: 0x180697620
	public void set_renderPipeline(RenderPipeline value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public RenderingMode get_renderingMode() { }

	// RVA: 0x697680 Offset: 0x696080 VA: 0x180697680
	public void set_renderingMode(RenderingMode value) { }

	// RVA: 0x6966E0 Offset: 0x6950E0 VA: 0x1806966E0
	public bool IsSRPBatcherSupported() { }

	// RVA: 0x6962A0 Offset: 0x694CA0 VA: 0x1806962A0
	public RenderingMode GetActualRenderingMode(ShaderMode shaderMode) { }

	// RVA: 0x697470 Offset: 0x695E70 VA: 0x180697470
	public bool get_SD_useSinglePassShader() { }

	// RVA: 0x697470 Offset: 0x695E70 VA: 0x180697470
	public bool get_SD_requiresDoubleSidedMesh() { }

	// RVA: 0x696320 Offset: 0x694D20 VA: 0x180696320
	public Shader GetBeamShader(ShaderMode mode) { }

	// RVA: 0x696300 Offset: 0x694D00 VA: 0x180696300
	private ref Shader GetBeamShaderInternal(ShaderMode mode) { }

	// RVA: 0x6966B0 Offset: 0x6950B0 VA: 0x1806966B0
	private int GetRenderQueueInternal(ShaderMode mode) { }

	// RVA: 0x696750 Offset: 0x695150 VA: 0x180696750
	public Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced) { }

	// RVA: 0x6972C0 Offset: 0x695CC0 VA: 0x1806972C0
	public void SetURPScriptableRendererIndexToDepthCamera(Camera camera) { }

	// RVA: 0x6974D0 Offset: 0x695ED0 VA: 0x1806974D0
	public Transform get_fadeOutCameraTransform() { }

	// RVA: 0x696210 Offset: 0x694C10 VA: 0x180696210
	public void ForceUpdateFadeOutCamera() { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public int get_defaultRaymarchingQualityUniqueID() { }

	// RVA: 0x6964D0 Offset: 0x694ED0 VA: 0x1806964D0
	public RaymarchingQuality GetRaymarchingQualityForIndex(int index) { }

	// RVA: 0x696500 Offset: 0x694F00 VA: 0x180696500
	public RaymarchingQuality GetRaymarchingQualityForUniqueID(int id) { }

	// RVA: 0x696550 Offset: 0x694F50 VA: 0x180696550
	public int GetRaymarchingQualityIndexForUniqueID(int id) { }

	// RVA: 0x6966C0 Offset: 0x6950C0 VA: 0x1806966C0
	public bool IsRaymarchingQualityUniqueIDValid(int id) { }

	// RVA: 0x6975F0 Offset: 0x695FF0 VA: 0x1806975F0
	public int get_raymarchingQualitiesCount() { }

	// RVA: 0x695FC0 Offset: 0x6949C0 VA: 0x180695FC0
	private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded) { }

	// RVA: 0x6975E0 Offset: 0x695FE0 VA: 0x1806975E0
	public bool get_isHDRPExposureWeightSupported() { }

	// RVA: 0x6975B0 Offset: 0x695FB0 VA: 0x1806975B0
	public bool get_hasRenderPipelineMismatch() { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x696B90 Offset: 0x695590 VA: 0x180696B90
	private static void OnStartup() { }

	// RVA: 0x697100 Offset: 0x695B00 VA: 0x180697100
	public void Reset() { }

	// RVA: 0x696D90 Offset: 0x695790 VA: 0x180696D90
	private void RefreshGlobalShaderProperties() { }

	// RVA: 0x696EC0 Offset: 0x6958C0 VA: 0x180696EC0
	public void ResetInternalData() { }

	// RVA: 0x696970 Offset: 0x695370 VA: 0x180696970
	public ParticleSystem NewVolumetricDustParticles() { }

	// RVA: 0x696B60 Offset: 0x695560 VA: 0x180696B60
	private void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0x696340 Offset: 0x694D40 VA: 0x180696340
	public static Config get_Instance() { }

	// RVA: 0x696710 Offset: 0x695110 VA: 0x180696710
	private static Config LoadAssetInternal(string assetName) { }

	// RVA: 0x696340 Offset: 0x694D40 VA: 0x180696340
	private static Config GetInstance(bool assertIfNotFound) { }

	// RVA: 0x697340 Offset: 0x695D40 VA: 0x180697340
	public void .ctor() { }
}
