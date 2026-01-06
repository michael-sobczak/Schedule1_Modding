public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 348
{
	// Fields
	public const string ClassName = "VolumetricDustParticles";
	[Range(0, 1)]
	public float alpha; // 0x20
	[Range(0.0001, 0.1)]
	public float size; // 0x24
	public ParticlesDirection direction; // 0x28
	public Vector3 velocity; // 0x2C
	[Obsolete("Use 'velocity' instead")]
	public float speed; // 0x38
	public float density; // 0x3C
	[MinMaxRange(0, 1)]
	public MinMaxRangeFloat spawnDistanceRange; // 0x40
	[Obsolete("Use 'spawnDistanceRange' instead")]
	public float spawnMinDistance; // 0x48
	[Obsolete("Use 'spawnDistanceRange' instead")]
	public float spawnMaxDistance; // 0x4C
	public bool cullingEnabled; // 0x50
	public float cullingMaxDistance; // 0x54
	[CompilerGenerated]
	private bool <isCulled>k__BackingField; // 0x58
	[SerializeField]
	private float m_AlphaAdditionalRuntime; // 0x5C
	private ParticleSystem m_Particles; // 0x60
	private ParticleSystemRenderer m_Renderer; // 0x68
	private Material m_Material; // 0x70
	private Gradient m_GradientCached; // 0x78
	private bool m_RuntimePropertiesDirty; // 0x80
	private static bool ms_NoMainCameraLogged; // 0x0
	private static Camera ms_MainCamera; // 0x8
	private VolumetricLightBeamAbstractBase m_Master; // 0x88

	// Properties
	public bool isCulled { get; set; }
	public float alphaAdditionalRuntime { get; set; }
	public bool particlesAreInstantiated { get; }
	public int particlesCurrentCount { get; }
	public int particlesMaxCount { get; }
	public Camera mainCamera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_isCulled() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	private void set_isCulled(bool value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_alphaAdditionalRuntime() { }

	// RVA: 0x7BF090 Offset: 0x7BDA90 VA: 0x1807BF090
	public void set_alphaAdditionalRuntime(float value) { }

	// RVA: 0x7BEF30 Offset: 0x7BD930 VA: 0x1807BEF30
	public bool get_particlesAreInstantiated() { }

	// RVA: 0x7BEF80 Offset: 0x7BD980 VA: 0x1807BEF80
	public int get_particlesCurrentCount() { }

	// RVA: 0x7BF000 Offset: 0x7BDA00 VA: 0x1807BF000
	public int get_particlesMaxCount() { }

	// RVA: 0x7BED50 Offset: 0x7BD750 VA: 0x1807BED50
	public Camera get_mainCamera() { }

	// RVA: 0x7BE490 Offset: 0x7BCE90 VA: 0x1807BE490
	private void Start() { }

	// RVA: 0x7BCDD0 Offset: 0x7BB7D0 VA: 0x1807BCDD0
	private void InstantiateParticleSystem() { }

	// RVA: 0x7BD160 Offset: 0x7BBB60 VA: 0x1807BD160
	private void OnEnable() { }

	// RVA: 0x7BD2B0 Offset: 0x7BBCB0 VA: 0x1807BD2B0
	private void SetActive(bool active) { }

	// RVA: 0x7BD210 Offset: 0x7BBC10 VA: 0x1807BD210
	private void SetActiveAndPlay() { }

	// RVA: 0x7BD170 Offset: 0x7BBB70 VA: 0x1807BD170
	private void Play() { }

	// RVA: 0x7BD150 Offset: 0x7BBB50 VA: 0x1807BD150
	private void OnDisable() { }

	// RVA: 0x7BD040 Offset: 0x7BBA40 VA: 0x1807BD040
	private void OnDestroy() { }

	// RVA: 0x7BEAA0 Offset: 0x7BD4A0 VA: 0x1807BEAA0
	private void Update() { }

	// RVA: 0x7BD350 Offset: 0x7BBD50 VA: 0x1807BD350
	private void SetParticleProperties() { }

	// RVA: 0x7BCD70 Offset: 0x7BB770 VA: 0x1807BCD70
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0x7BE560 Offset: 0x7BCF60 VA: 0x1807BE560
	private void UpdateCulling() { }

	// RVA: 0x7BEC50 Offset: 0x7BD650 VA: 0x1807BEC50
	public void .ctor() { }
}
