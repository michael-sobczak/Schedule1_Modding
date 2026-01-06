public class VolumetricFogProfile : ScriptableObject // TypeDefIndex: 9226
{
	// Fields
	[Range(1, 16)]
	[Header("Rendering")]
	public int raymarchQuality; // 0x18
	[Tooltip("Determines the minimum step size. Increase to improve performance / decrease to improve accuracy. When increasing this value, you can also increase 'Jittering' amount to improve quality.")]
	public float raymarchMinStep; // 0x1C
	public float jittering; // 0x20
	[Range(0, 2)]
	public float dithering; // 0x24
	[Tooltip("The render queue for this renderer. By default, all transparent objects use a render queue of 3000. Use a lower value to render before all transparent objects.")]
	public int renderQueue; // 0x28
	[Tooltip("Optional sorting layer Id (number) for this renderer. By default 0. Usually used to control the order with other transparent renderers, like Sprite Renderer.")]
	public int sortingLayerID; // 0x2C
	[Tooltip("Optional sorting order for this renderer. Used to control the order with other transparent renderers, like Sprite Renderer.")]
	public int sortingOrder; // 0x30
	[Header("Density")]
	[Tooltip("Do not use any noise at all")]
	public bool constantDensity; // 0x34
	public Texture2D noiseTexture; // 0x38
	[Tooltip("Size of the final noise used by the shader. Reduce to improve performance on old devices.")]
	public VolumetricFogNoiseSize noiseTextureOptimizedSize; // 0x40
	[Range(0, 3)]
	public float noiseStrength; // 0x44
	public float noiseScale; // 0x48
	public float noiseFinalMultiplier; // 0x4C
	public bool useDetailNoise; // 0x50
	public Texture3D detailTexture; // 0x58
	public float detailScale; // 0x60
	[Range(0, 1)]
	public float detailStrength; // 0x64
	public float detailOffset; // 0x68
	public float density; // 0x6C
	[Header("Geometry")]
	public VolumetricFogShape shape; // 0x70
	[Range(0, 1)]
	public float border; // 0x74
	[Tooltip("Ignores volume height and use a custom height defined by this profile")]
	public bool customHeight; // 0x78
	public float height; // 0x7C
	public float verticalOffset; // 0x80
	[Tooltip("When enabled, makes fog appear at certain distance from a camera")]
	public float distance; // 0x84
	[Range(0, 1)]
	public float distanceFallOff; // 0x88
	[Tooltip("Maximum distance from camera")]
	public float maxDistance; // 0x8C
	[Range(0, 1)]
	public float maxDistanceFallOff; // 0x90
	[Tooltip("Fits the fog altitude to the terrain heightmap")]
	public bool terrainFit; // 0x94
	public VolumetricFog.HeightmapCaptureResolution terrainFitResolution; // 0x98
	[Tooltip("Which objects will be included in the heightmap capture. By default all objects are included but you may want to restrict this to just the terrain.")]
	public LayerMask terrainLayerMask; // 0x9C
	[Tooltip("The height of fog above terrain surface.")]
	public float terrainFogHeight; // 0xA0
	public float terrainFogMinAltitude; // 0xA4
	public float terrainFogMaxAltitude; // 0xA8
	[ColorUsage(False)]
	[Header("Colors")]
	public Color albedo; // 0xAC
	public bool enableDepthGradient; // 0xBC
	[GradientUsage(True, 1)]
	public Gradient depthGradient; // 0xC0
	public float depthGradientMaxDistance; // 0xC8
	public bool enableHeightGradient; // 0xCC
	[GradientUsage(True, 1)]
	public Gradient heightGradient; // 0xD0
	public float brightness; // 0xD8
	[Range(0, 2)]
	public float deepObscurance; // 0xDC
	public Color specularColor; // 0xE0
	[Range(0, 1)]
	public float specularThreshold; // 0xF0
	[Range(0, 1)]
	public float specularIntensity; // 0xF4
	[Header("Animation")]
	public float turbulence; // 0xF8
	public Vector3 windDirection; // 0xFC
	public bool useCustomDetailNoiseWindDirection; // 0x108
	public Vector3 detailNoiseWindDirection; // 0x10C
	[Header("Directional Light")]
	[Tooltip("Enable to synchronize fog light intensity and color with the Sun and the Moon (must be assigned into Volumetric Fog Manager)")]
	public bool dayNightCycle; // 0x118
	[Tooltip("When day/night cycle option is disabled, customize the direction of the Sun light.")]
	public Vector3 sunDirection; // 0x11C
	[Tooltip("Custom sun color when day/night cycle is disabled")]
	public Color sunColor; // 0x128
	[Tooltip("Custom sun intensity when day/night cycle is disabled")]
	public float sunIntensity; // 0x138
	[Tooltip("Ambient light influence")]
	public float ambientLightMultiplier; // 0x13C
	public DiffusionModel lightDiffusionModel; // 0x140
	[Range(0, 256)]
	public float lightDiffusionPower; // 0x144
	public float lightDiffusionIntensity; // 0x148
	public bool receiveShadows; // 0x14C
	[Range(0, 1)]
	public float shadowIntensity; // 0x150
	[Tooltip("Removes shadowed fog")]
	[Range(0, 1)]
	public float shadowCancellation; // 0x154
	public float shadowMaxDistance; // 0x158
	[Tooltip("Uses the directional light cookie")]
	public bool cookie; // 0x15C
	[Header("Distant Fog")]
	[Tooltip("Enables exponential distant fog. Use this option to cover horizon/sky/far distances with optimal performance")]
	public bool distantFog; // 0x15D
	public float distantFogStartDistance; // 0x160
	public float distantFogDistanceDensity; // 0x164
	public float distantFogMaxHeight; // 0x168
	public float distantFogHeightDensity; // 0x16C
	public Color distantFogColor; // 0x170
	public float distantFogDiffusionIntensity; // 0x180
	public int distantFogRenderQueue; // 0x184
	public float distantFogBaseAltitude; // 0x188
	[CompilerGenerated]
	private OnSettingsChanged onSettingsChanged; // 0x190
	public Texture2D depthGradientTex; // 0x198
	public Texture2D heightGradientTex; // 0x1A0
	private Color[] depthGradientColors; // 0x1A8
	private Color[] heightGradientColors; // 0x1B0
	private static readonly List<float> colorKeysTimes; // 0x0
	private static readonly List<float> alphaKeysTimes; // 0x8

	// Methods

	[CompilerGenerated]
	// RVA: 0x2AC1930 Offset: 0x2AC0330 VA: 0x182AC1930
	public void add_onSettingsChanged(OnSettingsChanged value) { }

	[CompilerGenerated]
	// RVA: 0x2AC19E0 Offset: 0x2AC03E0 VA: 0x182AC19E0
	public void remove_onSettingsChanged(OnSettingsChanged value) { }

	// RVA: 0x2AC0C50 Offset: 0x2ABF650 VA: 0x182AC0C50
	private void OnEnable() { }

	// RVA: 0x2AC0D60 Offset: 0x2ABF760 VA: 0x182AC0D60
	private void OnValidate() { }

	// RVA: 0x2AC0DA0 Offset: 0x2ABF7A0 VA: 0x182AC0DA0
	public void ValidateSettings() { }

	// RVA: 0x2AC0150 Offset: 0x2ABEB50 VA: 0x182AC0150
	public void Lerp(VolumetricFogProfile p1, VolumetricFogProfile p2, float t) { }

	// RVA: 0x2ABF770 Offset: 0x2ABE170 VA: 0x182ABF770
	private void LerpGradient(Gradient g, Gradient a, Gradient b, float t) { }

	// RVA: 0x2AC1690 Offset: 0x2AC0090 VA: 0x182AC1690
	public void .ctor() { }

	// RVA: 0x2AC15C0 Offset: 0x2ABFFC0 VA: 0x182AC15C0
	private static void .cctor() { }
}
