public class LiquidVolume : MonoBehaviour // TypeDefIndex: 391
{
	// Fields
	public static bool FORCE_GLES_COMPATIBILITY; // 0x0
	[CompilerGenerated]
	private PropertiesChangedEvent onPropertiesChanged; // 0x20
	[SerializeField]
	private TOPOLOGY _topology; // 0x28
	[SerializeField]
	private DETAIL _detail; // 0x2C
	[SerializeField]
	[Range(0, 1)]
	private float _level; // 0x30
	[SerializeField]
	[Range(0, 1)]
	private float _levelMultiplier; // 0x34
	[SerializeField]
	[Tooltip("Uses directional light color")]
	private bool _useLightColor; // 0x38
	[SerializeField]
	[Tooltip("Uses directional light direction for day/night cycle")]
	private bool _useLightDirection; // 0x39
	[SerializeField]
	private Light _directionalLight; // 0x40
	[SerializeField]
	[ColorUsage(True)]
	private Color _liquidColor1; // 0x48
	[SerializeField]
	[Range(0.1, 4.85)]
	private float _liquidScale1; // 0x58
	[SerializeField]
	[ColorUsage(True)]
	private Color _liquidColor2; // 0x5C
	[SerializeField]
	[Range(2, 4.85)]
	private float _liquidScale2; // 0x6C
	[SerializeField]
	[Range(0, 1)]
	private float _alpha; // 0x70
	[ColorUsage(True)]
	[SerializeField]
	private Color _emissionColor; // 0x74
	[SerializeField]
	private bool _ditherShadows; // 0x84
	[SerializeField]
	[Range(0, 1)]
	private float _murkiness; // 0x88
	[SerializeField]
	[Range(0, 1)]
	private float _turbulence1; // 0x8C
	[Range(0, 1)]
	[SerializeField]
	private float _turbulence2; // 0x90
	[SerializeField]
	private float _frecuency; // 0x94
	[Range(0, 2)]
	[SerializeField]
	private float _speed; // 0x98
	[Range(0, 5)]
	[SerializeField]
	private float _sparklingIntensity; // 0x9C
	[SerializeField]
	[Range(0, 1)]
	private float _sparklingAmount; // 0xA0
	[SerializeField]
	[Range(0, 10)]
	private float _deepObscurance; // 0xA4
	[SerializeField]
	[ColorUsage(True)]
	private Color _foamColor; // 0xA8
	[SerializeField]
	[Range(0.01, 1)]
	private float _foamScale; // 0xB8
	[SerializeField]
	[Range(0, 0.1)]
	private float _foamThickness; // 0xBC
	[SerializeField]
	[Range(-1, 1)]
	private float _foamDensity; // 0xC0
	[SerializeField]
	[Range(4, 100)]
	private float _foamWeight; // 0xC4
	[SerializeField]
	[Range(0, 1)]
	private float _foamTurbulence; // 0xC8
	[SerializeField]
	private bool _foamVisibleFromBottom; // 0xCC
	[SerializeField]
	private bool _smokeEnabled; // 0xCD
	[ColorUsage(True)]
	[SerializeField]
	private Color _smokeColor; // 0xD0
	[SerializeField]
	[Range(0.01, 1)]
	private float _smokeScale; // 0xE0
	[Range(0, 10)]
	[SerializeField]
	private float _smokeBaseObscurance; // 0xE4
	[SerializeField]
	[Range(0, 10)]
	private float _smokeHeightAtten; // 0xE8
	[Range(0, 20)]
	[SerializeField]
	private float _smokeSpeed; // 0xEC
	[SerializeField]
	private bool _fixMesh; // 0xF0
	public Mesh originalMesh; // 0xF8
	public Vector3 originalPivotOffset; // 0x100
	[SerializeField]
	private Vector3 _pivotOffset; // 0x10C
	[SerializeField]
	private bool _limitVerticalRange; // 0x118
	[Range(0, 1.5)]
	[SerializeField]
	private float _upperLimit; // 0x11C
	[SerializeField]
	[Range(-1.5, 1.5)]
	private float _lowerLimit; // 0x120
	[SerializeField]
	private int _subMeshIndex; // 0x124
	[SerializeField]
	private Material _flaskMaterial; // 0x128
	[SerializeField]
	[Range(0, 1)]
	private float _flaskThickness; // 0x130
	[SerializeField]
	[Range(0, 1)]
	private float _glossinessInternal; // 0x134
	[SerializeField]
	private bool _scatteringEnabled; // 0x138
	[Range(1, 16)]
	[SerializeField]
	private int _scatteringPower; // 0x13C
	[Range(0, 10)]
	[SerializeField]
	private float _scatteringAmount; // 0x140
	[SerializeField]
	private bool _refractionBlur; // 0x144
	[Range(0, 1)]
	[SerializeField]
	private float _blurIntensity; // 0x148
	[SerializeField]
	private int _liquidRaySteps; // 0x14C
	[SerializeField]
	private int _foamRaySteps; // 0x150
	[SerializeField]
	private int _smokeRaySteps; // 0x154
	[SerializeField]
	private Texture2D _bumpMap; // 0x158
	[Range(0, 1)]
	[SerializeField]
	private float _bumpStrength; // 0x160
	[SerializeField]
	[Range(0, 10)]
	private float _bumpDistortionScale; // 0x164
	[SerializeField]
	private Vector2 _bumpDistortionOffset; // 0x168
	[SerializeField]
	private Texture2D _distortionMap; // 0x170
	[SerializeField]
	private Texture2D _texture; // 0x178
	[SerializeField]
	private Vector2 _textureScale; // 0x180
	[SerializeField]
	private Vector2 _textureOffset; // 0x188
	[SerializeField]
	[Range(0, 10)]
	private float _distortionAmount; // 0x190
	[SerializeField]
	private bool _depthAware; // 0x194
	[SerializeField]
	private float _depthAwareOffset; // 0x198
	[SerializeField]
	private bool _irregularDepthDebug; // 0x19C
	[SerializeField]
	private bool _depthAwareCustomPass; // 0x19D
	[SerializeField]
	private bool _depthAwareCustomPassDebug; // 0x19E
	[Range(0, 5)]
	[SerializeField]
	private float _doubleSidedBias; // 0x1A0
	[SerializeField]
	private float _backDepthBias; // 0x1A4
	[SerializeField]
	private LEVEL_COMPENSATION _rotationLevelCompensation; // 0x1A8
	[SerializeField]
	private bool _ignoreGravity; // 0x1AC
	[SerializeField]
	private bool _reactToForces; // 0x1AD
	[SerializeField]
	private Vector3 _extentsScale; // 0x1B0
	[SerializeField]
	[Range(1, 3)]
	private int _noiseVariation; // 0x1BC
	[SerializeField]
	private bool _allowViewFromInside; // 0x1C0
	[SerializeField]
	private bool _debugSpillPoint; // 0x1C1
	[SerializeField]
	private int _renderQueue; // 0x1C4
	[SerializeField]
	private Cubemap _reflectionTexture; // 0x1C8
	[SerializeField]
	[Range(0.1, 5)]
	private float _physicsMass; // 0x1D0
	[SerializeField]
	[Range(0, 0.2)]
	private float _physicsAngularDamp; // 0x1D4
	private const int SHADER_KEYWORD_DEPTH_AWARE_INDEX = 0;
	private const int SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX = 1;
	private const int SHADER_KEYWORD_IGNORE_GRAVITY_INDEX = 2;
	private const int SHADER_KEYWORD_NON_AABB_INDEX = 3;
	private const int SHADER_KEYWORD_TOPOLOGY_INDEX = 4;
	private const int SHADER_KEYWORD_REFRACTION_INDEX = 5;
	private const string SHADER_KEYWORD_DEPTH_AWARE = "LIQUID_VOLUME_DEPTH_AWARE";
	private const string SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS = "LIQUID_VOLUME_DEPTH_AWARE_PASS";
	private const string SHADER_KEYWORD_NON_AABB = "LIQUID_VOLUME_NON_AABB";
	private const string SHADER_KEYWORD_IGNORE_GRAVITY = "LIQUID_VOLUME_IGNORE_GRAVITY";
	private const string SHADER_KEYWORD_SPHERE = "LIQUID_VOLUME_SPHERE";
	private const string SHADER_KEYWORD_CUBE = "LIQUID_VOLUME_CUBE";
	private const string SHADER_KEYWORD_CYLINDER = "LIQUID_VOLUME_CYLINDER";
	private const string SHADER_KEYWORD_IRREGULAR = "LIQUID_VOLUME_IRREGULAR";
	private const string SHADER_KEYWORD_FP_RENDER_TEXTURE = "LIQUID_VOLUME_FP_RENDER_TEXTURES";
	private const string SHADER_KEYWORD_USE_REFRACTION = "LIQUID_VOLUME_USE_REFRACTION";
	private const string SPILL_POINT_GIZMO = "SpillPointGizmo";
	public Material liqMat; // 0x1D8
	private Material liqMatSimple; // 0x1E0
	private Material liqMatDefaultNoFlask; // 0x1E8
	private Mesh mesh; // 0x1F0
	public Renderer mr; // 0x1F8
	private static readonly List<Material> mrSharedMaterials; // 0x8
	private Vector3 lastPosition; // 0x200
	private Vector3 lastScale; // 0x20C
	private Quaternion lastRotation; // 0x218
	private string[] shaderKeywords; // 0x228
	private bool camInside; // 0x230
	private float lastDistanceToCam; // 0x234
	private DETAIL currentDetail; // 0x238
	private Vector4 turb; // 0x23C
	private Vector4 shaderTurb; // 0x24C
	private float turbulenceSpeed; // 0x25C
	private float murkinessSpeed; // 0x260
	private float liquidLevelPos; // 0x264
	private bool shouldUpdateMaterialProperties; // 0x268
	private int currentNoiseVariation; // 0x26C
	private float levelMultipled; // 0x270
	private Texture2D noise3DUnwrapped; // 0x278
	private Texture3D[] noise3DTex; // 0x280
	private Color[][] colors3D; // 0x288
	private Vector3[] verticesUnsorted; // 0x290
	private Vector3[] verticesSorted; // 0x298
	private static Vector3[] rotatedVertices; // 0x10
	private int[] verticesIndices; // 0x2A0
	private float volumeRef; // 0x2A8
	private float lastLevelVolumeRef; // 0x2AC
	private Vector3 inertia; // 0x2B0
	private Vector3 lastAvgVelocity; // 0x2BC
	private float angularVelocity; // 0x2C8
	private float angularInertia; // 0x2CC
	private float turbulenceDueForces; // 0x2D0
	private Quaternion liquidRot; // 0x2D4
	private float prevThickness; // 0x2E4
	private GameObject spillPointGizmo; // 0x2E8
	private static string[] defaultContainerNames; // 0x18
	private Color[] pointLightColorBuffer; // 0x2F0
	private Vector4[] pointLightPositionBuffer; // 0x2F8
	private int lastPointLightCount; // 0x300
	private static readonly Dictionary<Mesh, LiquidVolume.MeshCache> meshCache; // 0x20
	private readonly List<Vector3> verts; // 0x308
	private readonly List<Vector3> cutPoints; // 0x310
	private Vector3 cutPlaneCenter; // 0x318
	[SerializeField]
	private Mesh fixedMesh; // 0x328

	// Properties
	public TOPOLOGY topology { get; set; }
	public DETAIL detail { get; set; }
	public float level { get; set; }
	public float levelMultiplier { get; set; }
	public bool useLightColor { get; set; }
	public bool useLightDirection { get; set; }
	public Light directionalLight { get; set; }
	public Color liquidColor1 { get; set; }
	public float liquidScale1 { get; set; }
	public Color liquidColor2 { get; set; }
	public float liquidScale2 { get; set; }
	public float alpha { get; set; }
	public Color emissionColor { get; set; }
	public bool ditherShadows { get; set; }
	public float murkiness { get; set; }
	public float turbulence1 { get; set; }
	public float turbulence2 { get; set; }
	public float frecuency { get; set; }
	public float speed { get; set; }
	public float sparklingIntensity { get; set; }
	public float sparklingAmount { get; set; }
	public float deepObscurance { get; set; }
	public Color foamColor { get; set; }
	public float foamScale { get; set; }
	public float foamThickness { get; set; }
	public float foamDensity { get; set; }
	public float foamWeight { get; set; }
	public float foamTurbulence { get; set; }
	public bool foamVisibleFromBottom { get; set; }
	public bool smokeEnabled { get; set; }
	public Color smokeColor { get; set; }
	public float smokeScale { get; set; }
	public float smokeBaseObscurance { get; set; }
	public float smokeHeightAtten { get; set; }
	public float smokeSpeed { get; set; }
	public bool fixMesh { get; set; }
	public Vector3 pivotOffset { get; set; }
	public bool limitVerticalRange { get; set; }
	public float upperLimit { get; set; }
	public float lowerLimit { get; set; }
	public int subMeshIndex { get; set; }
	public Material flaskMaterial { get; set; }
	public float flaskThickness { get; set; }
	public float glossinessInternal { get; set; }
	public bool scatteringEnabled { get; set; }
	public int scatteringPower { get; set; }
	public float scatteringAmount { get; set; }
	public bool refractionBlur { get; set; }
	public float blurIntensity { get; set; }
	public int liquidRaySteps { get; set; }
	public int foamRaySteps { get; set; }
	public int smokeRaySteps { get; set; }
	public Texture2D bumpMap { get; set; }
	public float bumpStrength { get; set; }
	public float bumpDistortionScale { get; set; }
	public Vector2 bumpDistortionOffset { get; set; }
	public Texture2D distortionMap { get; set; }
	public Texture2D texture { get; set; }
	public Vector2 textureScale { get; set; }
	public Vector2 textureOffset { get; set; }
	public float distortionAmount { get; set; }
	public bool depthAware { get; set; }
	public float depthAwareOffset { get; set; }
	public bool irregularDepthDebug { get; set; }
	public bool depthAwareCustomPass { get; set; }
	public bool depthAwareCustomPassDebug { get; set; }
	public float doubleSidedBias { get; set; }
	public float backDepthBias { get; set; }
	public LEVEL_COMPENSATION rotationLevelCompensation { get; set; }
	public bool ignoreGravity { get; set; }
	public bool reactToForces { get; set; }
	public Vector3 extentsScale { get; set; }
	public int noiseVariation { get; set; }
	public bool allowViewFromInside { get; set; }
	public bool debugSpillPoint { get; set; }
	public int renderQueue { get; set; }
	public Cubemap reflectionTexture { get; set; }
	public float physicsMass { get; set; }
	public float physicsAngularDamp { get; set; }
	public static bool useFPRenderTextures { get; }
	public float liquidSurfaceYPosition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8D1E70 Offset: 0x8D0870 VA: 0x1808D1E70
	public void add_onPropertiesChanged(PropertiesChangedEvent value) { }

	[CompilerGenerated]
	// RVA: 0x8D2190 Offset: 0x8D0B90 VA: 0x1808D2190
	public void remove_onPropertiesChanged(PropertiesChangedEvent value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public TOPOLOGY get_topology() { }

	// RVA: 0x8D4A80 Offset: 0x8D3480 VA: 0x1808D4A80
	public void set_topology(TOPOLOGY value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public DETAIL get_detail() { }

	// RVA: 0x8D2930 Offset: 0x8D1330 VA: 0x1808D2930
	public void set_detail(DETAIL value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_level() { }

	// RVA: 0x8D3710 Offset: 0x8D2110 VA: 0x1808D3710
	public void set_level(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_levelMultiplier() { }

	// RVA: 0x8D3690 Offset: 0x8D2090 VA: 0x1808D3690
	public void set_levelMultiplier(float value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_useLightColor() { }

	// RVA: 0x8D4C70 Offset: 0x8D3670 VA: 0x1808D4C70
	public void set_useLightColor(bool value) { }

	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_useLightDirection() { }

	// RVA: 0x8D4CE0 Offset: 0x8D36E0 VA: 0x1808D4CE0
	public void set_useLightDirection(bool value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Light get_directionalLight() { }

	// RVA: 0x8D29A0 Offset: 0x8D13A0 VA: 0x1808D29A0
	public void set_directionalLight(Light value) { }

	// RVA: 0x4F9FE0 Offset: 0x4F89E0 VA: 0x1804F9FE0
	public Color get_liquidColor1() { }

	// RVA: 0x8D3800 Offset: 0x8D2200 VA: 0x1808D3800
	public void set_liquidColor1(Color value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_liquidScale1() { }

	// RVA: 0x8D3A30 Offset: 0x8D2430 VA: 0x1808D3A30
	public void set_liquidScale1(float value) { }

	// RVA: 0x8D2040 Offset: 0x8D0A40 VA: 0x1808D2040
	public Color get_liquidColor2() { }

	// RVA: 0x8D38E0 Offset: 0x8D22E0 VA: 0x1808D38E0
	public void set_liquidColor2(Color value) { }

	// RVA: 0x4CD190 Offset: 0x4CBB90 VA: 0x1804CD190
	public float get_liquidScale2() { }

	// RVA: 0x8D3AB0 Offset: 0x8D24B0 VA: 0x1808D3AB0
	public void set_liquidScale2(float value) { }

	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_alpha() { }

	// RVA: 0x8D2250 Offset: 0x8D0C50 VA: 0x1808D2250
	public void set_alpha(float value) { }

	// RVA: 0x8D1FB0 Offset: 0x8D09B0 VA: 0x1808D1FB0
	public Color get_emissionColor() { }

	// RVA: 0x8D2CE0 Offset: 0x8D16E0 VA: 0x1808D2CE0
	public void set_emissionColor(Color value) { }

	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060
	public bool get_ditherShadows() { }

	// RVA: 0x8D2BF0 Offset: 0x8D15F0 VA: 0x1808D2BF0
	public void set_ditherShadows(bool value) { }

	// RVA: 0x6A5250 Offset: 0x6A3C50 VA: 0x1806A5250
	public float get_murkiness() { }

	// RVA: 0x8D3BB0 Offset: 0x8D25B0 VA: 0x1808D3BB0
	public void set_murkiness(float value) { }

	// RVA: 0x8D2160 Offset: 0x8D0B60 VA: 0x1808D2160
	public float get_turbulence1() { }

	// RVA: 0x8D4AF0 Offset: 0x8D34F0 VA: 0x1808D4AF0
	public void set_turbulence1(float value) { }

	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	public float get_turbulence2() { }

	// RVA: 0x8D4B70 Offset: 0x8D3570 VA: 0x1808D4B70
	public void set_turbulence2(float value) { }

	// RVA: 0x8D2000 Offset: 0x8D0A00 VA: 0x1808D2000
	public float get_frecuency() { }

	// RVA: 0x8D34B0 Offset: 0x8D1EB0 VA: 0x1808D34B0
	public void set_frecuency(float value) { }

	// RVA: 0x8B33F0 Offset: 0x8B1DF0 VA: 0x1808B33F0
	public float get_speed() { }

	// RVA: 0x8D4740 Offset: 0x8D3140 VA: 0x1808D4740
	public void set_speed(float value) { }

	// RVA: 0x6A5280 Offset: 0x6A3C80 VA: 0x1806A5280
	public float get_sparklingIntensity() { }

	// RVA: 0x8D46C0 Offset: 0x8D30C0 VA: 0x1808D46C0
	public void set_sparklingIntensity(float value) { }

	// RVA: 0x8B3450 Offset: 0x8B1E50 VA: 0x1808B3450
	public float get_sparklingAmount() { }

	// RVA: 0x8D4640 Offset: 0x8D3040 VA: 0x1808D4640
	public void set_sparklingAmount(float value) { }

	// RVA: 0x6A5290 Offset: 0x6A3C90 VA: 0x1806A5290
	public float get_deepObscurance() { }

	// RVA: 0x8D26E0 Offset: 0x8D10E0 VA: 0x1808D26E0
	public void set_deepObscurance(float value) { }

	// RVA: 0x5013A0 Offset: 0x4FFDA0 VA: 0x1805013A0
	public Color get_foamColor() { }

	// RVA: 0x8D3070 Offset: 0x8D1A70 VA: 0x1808D3070
	public void set_foamColor(Color value) { }

	// RVA: 0x4F2360 Offset: 0x4F0D60 VA: 0x1804F2360
	public float get_foamScale() { }

	// RVA: 0x8D3240 Offset: 0x8D1C40 VA: 0x1808D3240
	public void set_foamScale(float value) { }

	// RVA: 0x4F2430 Offset: 0x4F0E30 VA: 0x1804F2430
	public float get_foamThickness() { }

	// RVA: 0x8D32C0 Offset: 0x8D1CC0 VA: 0x1808D32C0
	public void set_foamThickness(float value) { }

	// RVA: 0x8D1FF0 Offset: 0x8D09F0 VA: 0x1808D1FF0
	public float get_foamDensity() { }

	// RVA: 0x8D3150 Offset: 0x8D1B50 VA: 0x1808D3150
	public void set_foamDensity(float value) { }

	// RVA: 0x4E8C80 Offset: 0x4E7680 VA: 0x1804E8C80
	public float get_foamWeight() { }

	// RVA: 0x8D3430 Offset: 0x8D1E30 VA: 0x1808D3430
	public void set_foamWeight(float value) { }

	// RVA: 0x526FD0 Offset: 0x5259D0 VA: 0x180526FD0
	public float get_foamTurbulence() { }

	// RVA: 0x8D3340 Offset: 0x8D1D40 VA: 0x1808D3340
	public void set_foamTurbulence(float value) { }

	// RVA: 0x526FF0 Offset: 0x5259F0 VA: 0x180526FF0
	public bool get_foamVisibleFromBottom() { }

	// RVA: 0x8D33C0 Offset: 0x8D1DC0 VA: 0x1808D33C0
	public void set_foamVisibleFromBottom(bool value) { }

	// RVA: 0x64B210 Offset: 0x649C10 VA: 0x18064B210
	public bool get_smokeEnabled() { }

	// RVA: 0x8D43E0 Offset: 0x8D2DE0 VA: 0x1808D43E0
	public void set_smokeEnabled(bool value) { }

	// RVA: 0x8D2100 Offset: 0x8D0B00 VA: 0x1808D2100
	public Color get_smokeColor() { }

	// RVA: 0x8D4300 Offset: 0x8D2D00 VA: 0x1808D4300
	public void set_smokeColor(Color value) { }

	// RVA: 0x51E8E0 Offset: 0x51D2E0 VA: 0x18051E8E0
	public float get_smokeScale() { }

	// RVA: 0x8D4540 Offset: 0x8D2F40 VA: 0x1808D4540
	public void set_smokeScale(float value) { }

	// RVA: 0x510800 Offset: 0x50F200 VA: 0x180510800
	public float get_smokeBaseObscurance() { }

	// RVA: 0x8D4280 Offset: 0x8D2C80 VA: 0x1808D4280
	public void set_smokeBaseObscurance(float value) { }

	// RVA: 0x8D2110 Offset: 0x8D0B10 VA: 0x1808D2110
	public float get_smokeHeightAtten() { }

	// RVA: 0x8D4450 Offset: 0x8D2E50 VA: 0x1808D4450
	public void set_smokeHeightAtten(float value) { }

	// RVA: 0x51D960 Offset: 0x51C360 VA: 0x18051D960
	public float get_smokeSpeed() { }

	// RVA: 0x8D45C0 Offset: 0x8D2FC0 VA: 0x1808D45C0
	public void set_smokeSpeed(float value) { }

	// RVA: 0x8D1FE0 Offset: 0x8D09E0 VA: 0x1808D1FE0
	public bool get_fixMesh() { }

	// RVA: 0x8D2E90 Offset: 0x8D1890 VA: 0x1808D2E90
	public void set_fixMesh(bool value) { }

	// RVA: 0x8D2090 Offset: 0x8D0A90 VA: 0x1808D2090
	public Vector3 get_pivotOffset() { }

	// RVA: 0x8D3DA0 Offset: 0x8D27A0 VA: 0x1808D3DA0
	public void set_pivotOffset(Vector3 value) { }

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_limitVerticalRange() { }

	// RVA: 0x8D3790 Offset: 0x8D2190 VA: 0x1808D3790
	public void set_limitVerticalRange(bool value) { }

	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_upperLimit() { }

	// RVA: 0x8D4BF0 Offset: 0x8D35F0 VA: 0x1808D4BF0
	public void set_upperLimit(float value) { }

	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float get_lowerLimit() { }

	// RVA: 0x8D3B30 Offset: 0x8D2530 VA: 0x1808D3B30
	public void set_lowerLimit(float value) { }

	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public int get_subMeshIndex() { }

	// RVA: 0x8D47C0 Offset: 0x8D31C0 VA: 0x1808D47C0
	public void set_subMeshIndex(int value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Material get_flaskMaterial() { }

	// RVA: 0x8D2F00 Offset: 0x8D1900 VA: 0x1808D2F00
	public void set_flaskMaterial(Material value) { }

	// RVA: 0x718AA0 Offset: 0x7174A0 VA: 0x180718AA0
	public float get_flaskThickness() { }

	// RVA: 0x8D2FF0 Offset: 0x8D19F0 VA: 0x1808D2FF0
	public void set_flaskThickness(float value) { }

	// RVA: 0x8D2010 Offset: 0x8D0A10 VA: 0x1808D2010
	public float get_glossinessInternal() { }

	// RVA: 0x8D3530 Offset: 0x8D1F30 VA: 0x1808D3530
	public void set_glossinessInternal(float value) { }

	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90
	public bool get_scatteringEnabled() { }

	// RVA: 0x8D41A0 Offset: 0x8D2BA0 VA: 0x1808D41A0
	public void set_scatteringEnabled(bool value) { }

	// RVA: 0x6BFD80 Offset: 0x6BE780 VA: 0x1806BFD80
	public int get_scatteringPower() { }

	// RVA: 0x8D4210 Offset: 0x8D2C10 VA: 0x1808D4210
	public void set_scatteringPower(int value) { }

	// RVA: 0x8D20F0 Offset: 0x8D0AF0 VA: 0x1808D20F0
	public float get_scatteringAmount() { }

	// RVA: 0x8D4120 Offset: 0x8D2B20 VA: 0x1808D4120
	public void set_scatteringAmount(float value) { }

	// RVA: 0x8D20C0 Offset: 0x8D0AC0 VA: 0x1808D20C0
	public bool get_refractionBlur() { }

	// RVA: 0x8D3FD0 Offset: 0x8D29D0 VA: 0x1808D3FD0
	public void set_refractionBlur(bool value) { }

	// RVA: 0x513070 Offset: 0x511A70 VA: 0x180513070
	public float get_blurIntensity() { }

	// RVA: 0x8D2380 Offset: 0x8D0D80 VA: 0x1808D2380
	public void set_blurIntensity(float value) { }

	// RVA: 0x6BFD00 Offset: 0x6BE700 VA: 0x1806BFD00
	public int get_liquidRaySteps() { }

	// RVA: 0x8D39C0 Offset: 0x8D23C0 VA: 0x1808D39C0
	public void set_liquidRaySteps(int value) { }

	// RVA: 0x653850 Offset: 0x652250 VA: 0x180653850
	public int get_foamRaySteps() { }

	// RVA: 0x8D31D0 Offset: 0x8D1BD0 VA: 0x1808D31D0
	public void set_foamRaySteps(int value) { }

	// RVA: 0x83ABD0 Offset: 0x8395D0 VA: 0x18083ABD0
	public int get_smokeRaySteps() { }

	// RVA: 0x8D44D0 Offset: 0x8D2ED0 VA: 0x1808D44D0
	public void set_smokeRaySteps(int value) { }

	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020
	public Texture2D get_bumpMap() { }

	// RVA: 0x8D2560 Offset: 0x8D0F60 VA: 0x1808D2560
	public void set_bumpMap(Texture2D value) { }

	// RVA: 0x8D1F50 Offset: 0x8D0950 VA: 0x1808D1F50
	public float get_bumpStrength() { }

	// RVA: 0x8D2650 Offset: 0x8D1050 VA: 0x1808D2650
	public void set_bumpStrength(float value) { }

	// RVA: 0x8D1F40 Offset: 0x8D0940 VA: 0x1808D1F40
	public float get_bumpDistortionScale() { }

	// RVA: 0x8D24E0 Offset: 0x8D0EE0 VA: 0x1808D24E0
	public void set_bumpDistortionScale(float value) { }

	// RVA: 0x8D1F20 Offset: 0x8D0920 VA: 0x1808D1F20
	public Vector2 get_bumpDistortionOffset() { }

	// RVA: 0x8D2430 Offset: 0x8D0E30 VA: 0x1808D2430
	public void set_bumpDistortionOffset(Vector2 value) { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public Texture2D get_distortionMap() { }

	// RVA: 0x8D2B00 Offset: 0x8D1500 VA: 0x1808D2B00
	public void set_distortionMap(Texture2D value) { }

	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public Texture2D get_texture() { }

	// RVA: 0x8D4990 Offset: 0x8D3390 VA: 0x1808D4990
	public void set_texture(Texture2D value) { }

	// RVA: 0x8D2140 Offset: 0x8D0B40 VA: 0x1808D2140
	public Vector2 get_textureScale() { }

	// RVA: 0x8D48E0 Offset: 0x8D32E0 VA: 0x1808D48E0
	public void set_textureScale(Vector2 value) { }

	// RVA: 0x8D2120 Offset: 0x8D0B20 VA: 0x1808D2120
	public Vector2 get_textureOffset() { }

	// RVA: 0x8D4830 Offset: 0x8D3230 VA: 0x1808D4830
	public void set_textureOffset(Vector2 value) { }

	// RVA: 0x8D1FA0 Offset: 0x8D09A0 VA: 0x1808D1FA0
	public float get_distortionAmount() { }

	// RVA: 0x8D2A80 Offset: 0x8D1480 VA: 0x1808D2A80
	public void set_distortionAmount(float value) { }

	// RVA: 0x8D1F90 Offset: 0x8D0990 VA: 0x1808D1F90
	public bool get_depthAware() { }

	// RVA: 0x8D28C0 Offset: 0x8D12C0 VA: 0x1808D28C0
	public void set_depthAware(bool value) { }

	// RVA: 0x8D1F80 Offset: 0x8D0980 VA: 0x1808D1F80
	public float get_depthAwareOffset() { }

	// RVA: 0x8D2840 Offset: 0x8D1240 VA: 0x1808D2840
	public void set_depthAwareOffset(float value) { }

	// RVA: 0x8D2030 Offset: 0x8D0A30 VA: 0x1808D2030
	public bool get_irregularDepthDebug() { }

	// RVA: 0x8D3620 Offset: 0x8D2020 VA: 0x1808D3620
	public void set_irregularDepthDebug(bool value) { }

	// RVA: 0x8D1F70 Offset: 0x8D0970 VA: 0x1808D1F70
	public bool get_depthAwareCustomPass() { }

	// RVA: 0x8D27D0 Offset: 0x8D11D0 VA: 0x1808D27D0
	public void set_depthAwareCustomPass(bool value) { }

	// RVA: 0x8D1F60 Offset: 0x8D0960 VA: 0x1808D1F60
	public bool get_depthAwareCustomPassDebug() { }

	// RVA: 0x8D2760 Offset: 0x8D1160 VA: 0x1808D2760
	public void set_depthAwareCustomPassDebug(bool value) { }

	// RVA: 0x792650 Offset: 0x791050 VA: 0x180792650
	public float get_doubleSidedBias() { }

	// RVA: 0x8D2C60 Offset: 0x8D1660 VA: 0x1808D2C60
	public void set_doubleSidedBias(float value) { }

	// RVA: 0x8D1F10 Offset: 0x8D0910 VA: 0x1808D1F10
	public float get_backDepthBias() { }

	// RVA: 0x8D2300 Offset: 0x8D0D00 VA: 0x1808D2300
	public void set_backDepthBias(float value) { }

	// RVA: 0x8D20E0 Offset: 0x8D0AE0 VA: 0x1808D20E0
	public LEVEL_COMPENSATION get_rotationLevelCompensation() { }

	// RVA: 0x8D40B0 Offset: 0x8D2AB0 VA: 0x1808D40B0
	public void set_rotationLevelCompensation(LEVEL_COMPENSATION value) { }

	// RVA: 0x8D2020 Offset: 0x8D0A20 VA: 0x1808D2020
	public bool get_ignoreGravity() { }

	// RVA: 0x8D35B0 Offset: 0x8D1FB0 VA: 0x1808D35B0
	public void set_ignoreGravity(bool value) { }

	// RVA: 0x8D20B0 Offset: 0x8D0AB0 VA: 0x1808D20B0
	public bool get_reactToForces() { }

	// RVA: 0x8D3E70 Offset: 0x8D2870 VA: 0x1808D3E70
	public void set_reactToForces(bool value) { }

	// RVA: 0x8D1FC0 Offset: 0x8D09C0 VA: 0x1808D1FC0
	public Vector3 get_extentsScale() { }

	// RVA: 0x8D2DC0 Offset: 0x8D17C0 VA: 0x1808D2DC0
	public void set_extentsScale(Vector3 value) { }

	// RVA: 0x8D2060 Offset: 0x8D0A60 VA: 0x1808D2060
	public int get_noiseVariation() { }

	// RVA: 0x8D3C30 Offset: 0x8D2630 VA: 0x1808D3C30
	public void set_noiseVariation(int value) { }

	// RVA: 0x796410 Offset: 0x794E10 VA: 0x180796410
	public bool get_allowViewFromInside() { }

	// RVA: 0x8D2230 Offset: 0x8D0C30 VA: 0x1808D2230
	public void set_allowViewFromInside(bool value) { }

	// RVA: 0x796400 Offset: 0x794E00 VA: 0x180796400
	public bool get_debugSpillPoint() { }

	// RVA: 0x8D26D0 Offset: 0x8D10D0 VA: 0x1808D26D0
	public void set_debugSpillPoint(bool value) { }

	// RVA: 0x8D20D0 Offset: 0x8D0AD0 VA: 0x1808D20D0
	public int get_renderQueue() { }

	// RVA: 0x8D4040 Offset: 0x8D2A40 VA: 0x1808D4040
	public void set_renderQueue(int value) { }

	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public Cubemap get_reflectionTexture() { }

	// RVA: 0x8D3EE0 Offset: 0x8D28E0 VA: 0x1808D3EE0
	public void set_reflectionTexture(Cubemap value) { }

	// RVA: 0x8D2080 Offset: 0x8D0A80 VA: 0x1808D2080
	public float get_physicsMass() { }

	// RVA: 0x8D3D20 Offset: 0x8D2720 VA: 0x1808D3D20
	public void set_physicsMass(float value) { }

	// RVA: 0x8D2070 Offset: 0x8D0A70 VA: 0x1808D2070
	public float get_physicsAngularDamp() { }

	// RVA: 0x8D3CA0 Offset: 0x8D26A0 VA: 0x1808D3CA0
	public void set_physicsAngularDamp(float value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool get_useFPRenderTextures() { }

	// RVA: 0x8CC190 Offset: 0x8CAB90 VA: 0x1808CC190
	private void OnEnable() { }

	// RVA: 0x8CD000 Offset: 0x8CBA00 VA: 0x1808CD000
	private void Reset() { }

	// RVA: 0x8CBEF0 Offset: 0x8CA8F0 VA: 0x1808CBEF0
	private void OnDestroy() { }

	// RVA: 0x8CCC00 Offset: 0x8CB600 VA: 0x1808CCC00
	private void RenderObject() { }

	// RVA: 0x8CC3A0 Offset: 0x8CADA0 VA: 0x1808CC3A0
	public void OnWillRenderObject() { }

	// RVA: 0x8C9BB0 Offset: 0x8C85B0 VA: 0x1808C9BB0
	private void FixedUpdate() { }

	// RVA: 0x8CC180 Offset: 0x8CAB80 VA: 0x1808CC180
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x8C96F0 Offset: 0x8C80F0 VA: 0x1808C96F0
	public void ClearMeshCache() { }

	// RVA: 0x8CC6C0 Offset: 0x8CB0C0 VA: 0x1808CC6C0
	private void ReadVertices() { }

	// RVA: 0x8D4D50 Offset: 0x8D3750 VA: 0x1808D4D50
	private int vertexComparer(Vector3 v0, Vector3 v1) { }

	// RVA: 0x8CD890 Offset: 0x8CC290 VA: 0x1808CD890
	private void UpdateAnimations() { }

	// RVA: 0x8CCAD0 Offset: 0x8CB4D0 VA: 0x1808CCAD0
	public void UpdateMaterialProperties() { }

	// RVA: 0x8CFB40 Offset: 0x8CE540 VA: 0x1808CFB40
	private void UpdateMaterialPropertiesNow() { }

	// RVA: 0x8C84D0 Offset: 0x8C6ED0 VA: 0x1808C84D0
	private Color ApplyGlobalAlpha(Color originalColor) { }

	// RVA: 0x8CB980 Offset: 0x8CA380 VA: 0x1808CB980
	private void GetRenderer() { }

	// RVA: 0x8CE6B0 Offset: 0x8CD0B0 VA: 0x1808CE6B0
	private void UpdateLevels(bool updateShaderKeywords = True) { }

	// RVA: 0x8CD580 Offset: 0x8CBF80 VA: 0x1808CD580
	private void RotateVertices() { }

	// RVA: 0x8CD770 Offset: 0x8CC170 VA: 0x1808CD770
	private float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 zeroPoint) { }

	// RVA: 0x8C9CE0 Offset: 0x8C86E0 VA: 0x1808C9CE0
	public float GetMeshVolumeUnderLevelFast(float level01, float yExtent) { }

	// RVA: 0x8CB960 Offset: 0x8CA360 VA: 0x1808CB960
	public float GetMeshVolumeWSFast() { }

	// RVA: 0x8C9D50 Offset: 0x8C8750 VA: 0x1808C9D50
	public float GetMeshVolumeUnderLevelWSFast(float level) { }

	// RVA: 0x8C9600 Offset: 0x8C8000 VA: 0x1808C9600
	private Vector3 ClampVertexToSlicePlane(Vector3 p, Vector3 q, float level) { }

	// RVA: 0x8CB8F0 Offset: 0x8CA2F0 VA: 0x1808CB8F0
	public float GetMeshVolumeUnderLevel(float level01, float yExtent) { }

	// RVA: 0x8CB970 Offset: 0x8CA370 VA: 0x1808CB970
	public float GetMeshVolumeWS() { }

	// RVA: 0x8CA0F0 Offset: 0x8C8AF0 VA: 0x1808CA0F0
	public float GetMeshVolumeUnderLevelWS(float level) { }

	// RVA: 0x8CC630 Offset: 0x8CB030 VA: 0x1808CC630
	private int PolygonSortOnPlane(Vector3 p1, Vector3 p2) { }

	// RVA: 0x8D1760 Offset: 0x8D0160 VA: 0x1808D1760
	private void UpdateTurbulence() { }

	// RVA: 0x8C8DB0 Offset: 0x8C77B0 VA: 0x1808C8DB0
	private void CheckInsideOut() { }

	// RVA: 0x8CC3B0 Offset: 0x8CADB0 VA: 0x1808CC3B0
	private bool PointInAABB(Vector3 point) { }

	// RVA: 0x8CC4A0 Offset: 0x8CAEA0 VA: 0x1808CC4A0
	private bool PointInCylinder(Vector3 point) { }

	// RVA: 0x8CE3D0 Offset: 0x8CCDD0 VA: 0x1808CE3D0
	private void UpdateInsideOut() { }

	// RVA: 0x8D2050 Offset: 0x8D0A50 VA: 0x1808D2050
	public float get_liquidSurfaceYPosition() { }

	// RVA: 0x8CBAF0 Offset: 0x8CA4F0 VA: 0x1808CBAF0
	public bool GetSpillPoint(out Vector3 spillPosition, float apertureStart = 1) { }

	// RVA: 0x8CBB20 Offset: 0x8CA520 VA: 0x1808CBB20
	public bool GetSpillPoint(out Vector3 spillPosition, out float spillAmount, float apertureStart = 1, LEVEL_COMPENSATION rotationCompensation = 0) { }

	// RVA: 0x8D1220 Offset: 0x8CFC20 VA: 0x1808D1220
	private void UpdateSpillPointGizmo() { }

	// RVA: 0x8C8500 Offset: 0x8C6F00 VA: 0x1808C8500
	public void BakeRotation() { }

	// RVA: 0x8C89B0 Offset: 0x8C73B0 VA: 0x1808C89B0
	public void CenterPivot() { }

	// RVA: 0x8C8A10 Offset: 0x8C7410 VA: 0x1808C8A10
	public void CenterPivot(Vector3 offset) { }

	// RVA: 0x8CCB40 Offset: 0x8CB540 VA: 0x1808CCB40
	public void RefreshMeshAndCollider() { }

	// RVA: 0x8CCAD0 Offset: 0x8CB4D0 VA: 0x1808CCAD0
	public void Redraw() { }

	// RVA: 0x8C92B0 Offset: 0x8C7CB0 VA: 0x1808C92B0
	private void CheckMeshDisplacement() { }

	// RVA: 0x8CD420 Offset: 0x8CBE20 VA: 0x1808CD420
	private void RestoreOriginalMesh() { }

	// RVA: 0x8C9770 Offset: 0x8C8170 VA: 0x1808C9770
	public void CopyFrom(LiquidVolume lv) { }

	// RVA: 0x8D1B60 Offset: 0x8D0560 VA: 0x1808D1B60
	public void .ctor() { }

	// RVA: 0x8D1900 Offset: 0x8D0300 VA: 0x1808D1900
	private static void .cctor() { }
}
