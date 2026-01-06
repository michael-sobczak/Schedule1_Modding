public class VolumetricFogManager : MonoBehaviour, IVolumetricFogManager // TypeDefIndex: 9203
{
	// Fields
	private static PointLightManager _pointLightManager; // 0x0
	private static FogVoidManager _fogVoidManager; // 0x8
	private static VolumetricFogManager _instance; // 0x10
	[Tooltip("Directional light used as the Sun")]
	public Light sun; // 0x20
	[Tooltip("Directional light used as the Moon")]
	public Light moon; // 0x28
	[Tooltip("Flip depth texture. Use only as a workaround to a bug in URP if the depth shows inverted in GameView. Alternatively you can enable MSAA or HDR instead of using this option.")]
	public bool flipDepthTexture; // 0x30
	[Tooltip("Enable this option to choose this manager when others could be loaded from sub-scenes")]
	public bool mainManager; // 0x31
	[Tooltip("Optionally specify which transparent layers must be included in the depth prepass. Use only to avoid fog clipping with certain transparent objects.")]
	public LayerMask includeTransparent; // 0x34
	[Tooltip("Cull mode for the transparent depth prepass")]
	public CullMode transparentCullMode; // 0x38
	[Tooltip("Optionally specify which semi-transparent (materials using alpha clipping or cut-off) must be included in the depth prepass. Use only to avoid fog clipping with certain transparent objects.")]
	public LayerMask includeSemiTransparent; // 0x3C
	[Range(0, 1)]
	[Tooltip("Optionally determines the alpha cut off for semitransparent objects")]
	public float alphaCutOff; // 0x40
	[Range(0, 1)]
	[Tooltip("Light scattering effect through fog")]
	public float scattering; // 0x44
	[Tooltip("Threshold applied to input brightness")]
	public float scatteringThreshold; // 0x48
	[Tooltip("Brightness multiplier applied to input")]
	public float scatteringIntensity; // 0x4C
	[Tooltip("Absorption or brightness decay inside the fog")]
	[Range(0, 1)]
	public float scatteringAbsorption; // 0x50
	public Color scatteringTint; // 0x54
	[Tooltip("Uses higher resolution intermediate buffers and edge-aware upsampling filter")]
	public bool scatteringHighQuality; // 0x64
	[Range(1, 8)]
	public float downscaling; // 0x68
	[Tooltip("Depth-based detection threshold for the upscaling reconstruction filter")]
	public float downscalingEdgeDepthThreshold; // 0x6C
	[Range(0, 6)]
	public int blurPasses; // 0x70
	[Range(1, 8)]
	public float blurDownscaling; // 0x74
	[Range(0.1, 4)]
	public float blurSpread; // 0x78
	[Tooltip("Uses 16-bit RGBA floating point pixel format for rendering & blur fog volumes. If disabled, 8-bit RGBA pixel format will be used which can improve performance on certain devices. Note that if you use bloom or other HDR-based effects, you should enable this HDR option as well.")]
	public bool blurHDR; // 0x7C
	[Tooltip("Enable to use an edge-aware blur.")]
	public bool blurEdgePreserve; // 0x7D
	[Tooltip("Ignores blur when fog color intensity is below this value.")]
	public float blurEdgeDepthThreshold; // 0x80
	[Range(0, 0.2)]
	public float ditherStrength; // 0x84
	private const string SKW_FLIP_DEPTH_TEXTURE = "VF2_FLIP_DEPTH_TEXTURE";
	public const uint FOG_VOLUMES_RENDERING_LAYER = 131072;

	// Properties
	public string managerName { get; }
	public static bool allowFogVoidRotation { get; }
	public static VolumetricFogManager instance { get; }
	public static PointLightManager pointLightManager { get; }
	public static FogVoidManager fogVoidManager { get; }

	// Methods

	// RVA: 0x2A994E0 Offset: 0x2A97EE0 VA: 0x182A994E0 Slot: 4
	public string get_managerName() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_allowFogVoidRotation() { }

	// RVA: 0x2A99400 Offset: 0x2A97E00 VA: 0x182A99400
	public static VolumetricFogManager get_instance() { }

	// RVA: 0x2A98BD0 Offset: 0x2A975D0 VA: 0x182A98BD0
	public static VolumetricFogManager GetManagerIfExists() { }

	// RVA: 0x2A99510 Offset: 0x2A97F10 VA: 0x182A99510
	public static PointLightManager get_pointLightManager() { }

	// RVA: 0x2A99370 Offset: 0x2A97D70 VA: 0x182A99370
	public static FogVoidManager get_fogVoidManager() { }

	// RVA: 0x2A98DE0 Offset: 0x2A977E0 VA: 0x182A98DE0
	private void OnEnable() { }

	// RVA: 0x2A990D0 Offset: 0x2A97AD0 VA: 0x182A990D0
	private void OnValidate() { }

	// RVA: 0x2A99220 Offset: 0x2A97C20 VA: 0x182A99220
	private void SetupLights() { }

	// RVA: 0x2A99120 Offset: 0x2A97B20 VA: 0x182A99120
	private void SetupDepthPrePass() { }

	// RVA: 0x2A98B10 Offset: 0x2A97510 VA: 0x182A98B10
	public static GameObject CreateFogVolume(string name) { }

	// RVA: 0x2A989F0 Offset: 0x2A973F0 VA: 0x182A989F0
	public static GameObject CreateFogVoid(string name) { }

	// RVA: 0x2A98930 Offset: 0x2A97330 VA: 0x182A98930
	public static GameObject CreateFogSubVolume(string name) { }

	// RVA: 0x2A99320 Offset: 0x2A97D20 VA: 0x182A99320
	public void .ctor() { }
}
