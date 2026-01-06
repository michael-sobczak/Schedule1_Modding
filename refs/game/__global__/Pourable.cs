public class Pourable : Draggable // TypeDefIndex: 776
{
	// Fields
	[CompilerGenerated]
	private bool <IsPouring>k__BackingField; // 0xC0
	public Action onInitialPour; // 0xC8
	[Header("Pourable settings")]
	public bool Unlimited; // 0xD0
	public float StartQuantity; // 0xD4
	public float PourRate_L; // 0xD8
	public float AngleFromUpToPour; // 0xDC
	[Tooltip("Multiplier for pour rate when pourable is shaken up and down")]
	public float ShakeBoostRate; // 0xE0
	public bool AffectsCoverage; // 0xE4
	[Header("Particles")]
	public float ParticleMinMultiplier; // 0xE8
	public float ParticleMaxMultiplier; // 0xEC
	[Header("Pourable References")]
	public ParticleSystem[] PourParticles; // 0xF0
	public Transform PourPoint; // 0xF8
	public AudioSourceController PourLoop; // 0x100
	[Header("Trash")]
	public TrashItem TrashItem; // 0x108
	[HideInInspector]
	public GrowContainer TargetGrowContainer; // 0x110
	[CompilerGenerated]
	private float <NormalizedPourRate>k__BackingField; // 0x118
	[CompilerGenerated]
	private float <CurrentQuantity>k__BackingField; // 0x11C
	protected bool hasPoured; // 0x120
	protected bool autoSetCurrentQuantity; // 0x121
	private float[] particleMinSizes; // 0x128
	private float[] particleMaxSizes; // 0x130
	private AverageAcceleration accelerometer; // 0x138

	// Properties
	public bool IsPouring { get; set; }
	public float NormalizedPourRate { get; set; }
	public float CurrentQuantity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_IsPouring() { }

	[CompilerGenerated]
	// RVA: 0x4E8DF0 Offset: 0x4E77F0 VA: 0x1804E8DF0
	protected void set_IsPouring(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5933D0 Offset: 0x591DD0 VA: 0x1805933D0
	public float get_NormalizedPourRate() { }

	[CompilerGenerated]
	// RVA: 0x5933F0 Offset: 0x591DF0 VA: 0x1805933F0
	private void set_NormalizedPourRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_CurrentQuantity() { }

	[CompilerGenerated]
	// RVA: 0x5933E0 Offset: 0x591DE0 VA: 0x1805933E0
	protected void set_CurrentQuantity(float value) { }

	// RVA: 0x592A30 Offset: 0x591430 VA: 0x180592A30 Slot: 14
	protected virtual void Start() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected override void Update() { }

	// RVA: 0x592750 Offset: 0x591150 VA: 0x180592750 Slot: 9
	protected override void FixedUpdate() { }

	// RVA: 0x592D10 Offset: 0x591710 VA: 0x180592D10 Slot: 15
	protected virtual void UpdatePouring() { }

	// RVA: 0x592780 Offset: 0x591180 VA: 0x180592780
	private float GetShakeBoost() { }

	// RVA: 0x592870 Offset: 0x591270 VA: 0x180592870 Slot: 16
	protected virtual void PourAmount(float amount) { }

	// RVA: 0x592800 Offset: 0x591200 VA: 0x180592800
	protected bool IsPourPointOverPot() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 17
	protected virtual bool CanPour() { }

	// RVA: 0x593370 Offset: 0x591D70 VA: 0x180593370
	public void .ctor() { }
}
