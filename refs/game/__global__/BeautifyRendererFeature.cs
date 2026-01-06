public class BeautifyRendererFeature : ScriptableRendererFeature // TypeDefIndex: 9304
{
	// Fields
	public const string SKW_SHARPEN = "BEAUTIFY_SHARPEN";
	public const string SKW_TONEMAP_ACES = "BEAUTIFY_ACES_TONEMAP";
	public const string SKW_LUT = "BEAUTIFY_LUT";
	public const string SKW_LUT3D = "BEAUTIFY_3DLUT";
	public const string SKW_BLOOM = "BEAUTIFY_BLOOM";
	public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH";
	public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER";
	public const string SKW_BLOOM_PROP_THRESHOLDING = "BEAUTIFY_BLOOM_PROP_THRESHOLDING";
	public const string SKW_DIRT = "BEAUTIFY_DIRT";
	public const string SKW_ANAMORPHIC_FLARES_USE_DEPTH = "BEAUTIFY_ANAMORPHIC_FLARES_USE_DEPTH";
	public const string SKW_ANAMORPHIC_FLARES_USE_LAYER = "BEAUTIFY_ANAMORPHIC_FLARES_USE_LAYER";
	public const string SKW_ANAMORPHIC_PROP_THRESHOLDING = "BEAUTIFY_ANAMORPHIC_PROP_THRESHOLDING";
	public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD";
	public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DOF_TRANSPARENT";
	public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING";
	public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK";
	public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE";
	public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION";
	public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE";
	public const string SKW_OUTLINE_DEPTH_FADE = "BEAUTIFY_DEPTH_FADE";
	public const string SKW_TURBO = "BEAUTIFY_TURBO";
	public const string SKW_COLOR_TWEAKS = "BEAUTIFY_COLOR_TWEAKS";
	public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION";
	public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION";
	public const string SKW_DITHER = "BEAUTIFY_DITHER";
	public const string SKW_CHROMATIC_ABERRATION = "BEAUTIFY_CABERRATION";
	public const string SKW_FRAME = "BEAUTIFY_FRAME";
	public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK";
	public const string SKW_SUN_FLARES_USE_GHOSTS = "BEAUTIFY_SF_USE_GHOSTS";
	public const string SKW_SUN_FLARES_OCCLUSION_INIT = "BEAUTIFY_SF_OCCLUSION_INIT";
	public const string SKW_SUN_FLARES_OCCLUSION_SIMPLE = "BEAUTIFY_SF_OCCLUSION_SIMPLE";
	public const string SKW_SUN_FLARES_OCCLUSION_SMOOTH = "BEAUTIFY_SF_OCCLUSION_SMOOTH";
	public const string SKW_CUSTOM_DEPTH_ALPHA_TEST = "DEPTH_PREPASS_ALPHA_TEST";
	public const string SKW_EDGE_ANTIALIASING = "BEAUTIFY_EDGE_AA";
	[SerializeField]
	[HideInInspector]
	private Shader shader; // 0x20
	private BeautifyRendererFeature.BeautifyRenderPass m_BeautifyRenderPass; // 0x28
	private BeautifyRendererFeature.BeautifyDoFTransparentMaskPass m_BeautifyDoFTransparentMaskPass; // 0x30
	private BeautifyRendererFeature.BeautifyBloomLumMaskPass m_BeautifyBloomLumMaskPass; // 0x38
	private BeautifyRendererFeature.BeautifyAnamorphicFlaresLumMaskPass m_BeautifyAnamorphicFlaresLumMaskPass; // 0x40
	private BeautifyRendererFeature.BeautifyClearColorTarget m_BeautifyClearColorTarget; // 0x48
	[Tooltip("Note: this option is ignored if Direct Write To Camera option in Beautify volume inspector is enabled.")]
	public RenderPassEvent renderPassEvent; // 0x50
	[Tooltip("Allows Beautify to be executed even if camera has Post Processing option disabled.")]
	public bool ignorePostProcessingOption; // 0x54
	[Tooltip("Ensures color buffer is cleared before rendering in XR. This option solves an issue with OpenXR and occlusion mesh which causes color bleeding when bloom is enabled.")]
	public bool clearXRColorBuffer; // 0x55
	[Tooltip("Specify which cameras can render Beautify effects")]
	public LayerMask cameraLayerMask; // 0x58
	public static bool installed; // 0x0
	public static bool ignoringPostProcessingOption; // 0x1

	// Methods

	// RVA: 0x2AB8F40 Offset: 0x2AB7940 VA: 0x182AB8F40
	private void OnDisable() { }

	// RVA: 0x2AB8CF0 Offset: 0x2AB76F0 VA: 0x182AB8CF0 Slot: 5
	public override void Create() { }

	// RVA: 0x2AB8980 Offset: 0x2AB7380 VA: 0x182AB8980 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2AB8F90 Offset: 0x2AB7990 VA: 0x182AB8F90
	public void .ctor() { }
}
