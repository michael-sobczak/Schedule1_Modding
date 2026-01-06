public class VolumetricCookieHD : MonoBehaviour // TypeDefIndex: 277
{
	// Fields
	public const string ClassName = "VolumetricCookieHD";
	[SerializeField]
	private float m_Contribution; // 0x20
	[SerializeField]
	private Texture m_CookieTexture; // 0x28
	[SerializeField]
	private CookieChannel m_Channel; // 0x30
	[SerializeField]
	private bool m_Negative; // 0x34
	[SerializeField]
	private Vector2 m_Translation; // 0x38
	[SerializeField]
	private float m_Rotation; // 0x40
	[SerializeField]
	private Vector2 m_Scale; // 0x44
	private VolumetricLightBeamHD m_Master; // 0x50

	// Properties
	public float contribution { get; set; }
	public Texture cookieTexture { get; set; }
	public CookieChannel channel { get; set; }
	public bool negative { get; set; }
	public Vector2 translation { get; set; }
	public float rotation { get; set; }
	public Vector2 scale { get; set; }

	// Methods

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_contribution() { }

	// RVA: 0x6A3630 Offset: 0x6A2030 VA: 0x1806A3630
	public void set_contribution(float value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Texture get_cookieTexture() { }

	// RVA: 0x6A3650 Offset: 0x6A2050 VA: 0x1806A3650
	public void set_cookieTexture(Texture value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public CookieChannel get_channel() { }

	// RVA: 0x6A3620 Offset: 0x6A2020 VA: 0x1806A3620
	public void set_channel(CookieChannel value) { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_negative() { }

	// RVA: 0x6A36E0 Offset: 0x6A20E0 VA: 0x1806A36E0
	public void set_negative(bool value) { }

	// RVA: 0x57CCD0 Offset: 0x57B6D0 VA: 0x18057CCD0
	public Vector2 get_translation() { }

	// RVA: 0x6A3760 Offset: 0x6A2160 VA: 0x1806A3760
	public void set_translation(Vector2 value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_rotation() { }

	// RVA: 0x6A36F0 Offset: 0x6A20F0 VA: 0x1806A36F0
	public void set_rotation(float value) { }

	// RVA: 0x6A3600 Offset: 0x6A2000 VA: 0x1806A3600
	public Vector2 get_scale() { }

	// RVA: 0x6A3710 Offset: 0x6A2110 VA: 0x1806A3710
	public void set_scale(Vector2 value) { }

	// RVA: 0x6A3480 Offset: 0x6A1E80 VA: 0x1806A3480
	private void SetDirty() { }

	// RVA: 0x6A3100 Offset: 0x6A1B00 VA: 0x1806A3100
	public static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom) { }

	// RVA: 0x6A33C0 Offset: 0x6A1DC0 VA: 0x1806A33C0
	private void Awake() { }

	// RVA: 0x6A3470 Offset: 0x6A1E70 VA: 0x1806A3470
	private void OnEnable() { }

	// RVA: 0x6A3470 Offset: 0x6A1E70 VA: 0x1806A3470
	private void OnDisable() { }

	// RVA: 0x6A3470 Offset: 0x6A1E70 VA: 0x1806A3470
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x6A3500 Offset: 0x6A1F00 VA: 0x1806A3500
	private void Start() { }

	// RVA: 0x6A3410 Offset: 0x6A1E10 VA: 0x1806A3410
	private void OnDestroy() { }

	// RVA: 0x6A3560 Offset: 0x6A1F60 VA: 0x1806A3560
	public void .ctor() { }
}
