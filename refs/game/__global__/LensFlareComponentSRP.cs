public sealed class LensFlareComponentSRP : MonoBehaviour // TypeDefIndex: 13782
{
	// Fields
	[SerializeField]
	private LensFlareDataSRP m_LensFlareData; // 0x20
	[Min(0)]
	public float intensity; // 0x28
	[Min(1E-05)]
	public float maxAttenuationDistance; // 0x2C
	[Min(1E-05)]
	public float maxAttenuationScale; // 0x30
	public AnimationCurve distanceAttenuationCurve; // 0x38
	public AnimationCurve scaleByDistanceCurve; // 0x40
	public bool attenuationByLightShape; // 0x48
	public AnimationCurve radialScreenAttenuationCurve; // 0x50
	public bool useOcclusion; // 0x58
	[Min(0)]
	public float occlusionRadius; // 0x5C
	public bool useBackgroundCloudOcclusion; // 0x60
	[Range(1, 64)]
	public uint sampleCount; // 0x64
	public float occlusionOffset; // 0x68
	[Min(0)]
	public float scale; // 0x6C
	public bool allowOffScreen; // 0x70
	public bool volumetricCloudOcclusion; // 0x71
	private static float sCelestialAngularRadius; // 0x0
	public TextureCurve occlusionRemapCurve; // 0x78

	// Properties
	public LensFlareDataSRP lensFlareData { get; set; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LensFlareDataSRP get_lensFlareData() { }

	// RVA: 0x2A1EBF0 Offset: 0x2A1D5F0 VA: 0x182A1EBF0
	public void set_lensFlareData(LensFlareDataSRP value) { }

	// RVA: 0x2A1EB20 Offset: 0x2A1D520 VA: 0x182A1EB20
	public float celestialProjectedOcclusionRadius(Camera mainCam) { }

	// RVA: 0x2A1E570 Offset: 0x2A1CF70 VA: 0x182A1E570
	private void OnEnable() { }

	// RVA: 0x2A1E510 Offset: 0x2A1CF10 VA: 0x182A1E510
	private void OnDisable() { }

	// RVA: 0x2A1E640 Offset: 0x2A1D040 VA: 0x182A1E640
	private void OnValidate() { }

	// RVA: 0x2A1E770 Offset: 0x2A1D170 VA: 0x182A1E770
	public void .ctor() { }

	// RVA: 0x2A1E730 Offset: 0x2A1D130 VA: 0x182A1E730
	private static void .cctor() { }
}
