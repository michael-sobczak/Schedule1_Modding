public class VolumetricLightTracker : MonoBehaviour // TypeDefIndex: 1272
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("Override")]
	private bool _Override; // 0x20
	[FormerlySerializedAs("Enabled")]
	[SerializeField]
	private bool _Enabled; // 0x21
	public Light light; // 0x28
	public OptimizedLight optimizedLight; // 0x30
	public VolumetricLightBeamSD beam; // 0x38
	public VolumetricDustParticles dust; // 0x40

	// Properties
	public bool Override { get; set; }
	public bool Enabled { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Override() { }

	// RVA: 0x624B90 Offset: 0x623590 VA: 0x180624B90
	public void set_Override(bool value) { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_Enabled() { }

	// RVA: 0x624B80 Offset: 0x623580 VA: 0x180624B80
	public void set_Enabled(bool value) { }

	// RVA: 0x624890 Offset: 0x623290 VA: 0x180624890
	private void AssignReferences() { }

	// RVA: 0x624A30 Offset: 0x623430 VA: 0x180624A30
	private void UpdateEffectsState() { }

	// RVA: 0x624A20 Offset: 0x623420 VA: 0x180624A20
	private void Awake() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
