internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature // TypeDefIndex: 8996
{
	// Fields
	[SerializeField]
	private ScreenSpaceAmbientOcclusionSettings m_Settings; // 0x20
	[SerializeField]
	[Reload("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, 1)]
	[HideInInspector]
	internal Texture2D[] m_BlueNoise256Textures; // 0x28
	[SerializeField]
	[HideInInspector]
	[Reload("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", 1)]
	private Shader m_Shader; // 0x30
	private Material m_Material; // 0x38
	private ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass m_SSAOPass; // 0x40
	internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";
	internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE";
	internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
	internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";
	internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";
	internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";
	internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
	internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";
	internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";
	internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";

	// Properties
	internal ScreenSpaceAmbientOcclusionSettings settings { get; }

	// Methods

	// RVA: 0x2B165A0 Offset: 0x2B14FA0 VA: 0x182B165A0
	internal ref ScreenSpaceAmbientOcclusionSettings get_settings() { }

	// RVA: 0x2B25340 Offset: 0x2B23D40 VA: 0x182B25340 Slot: 5
	public override void Create() { }

	// RVA: 0x2B25060 Offset: 0x2B23A60 VA: 0x182B25060 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2B253F0 Offset: 0x2B23DF0 VA: 0x182B253F0 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2B25510 Offset: 0x2B23F10 VA: 0x182B25510
	private bool GetMaterials() { }

	// RVA: 0x2B25600 Offset: 0x2B24000 VA: 0x182B25600
	public void .ctor() { }
}
