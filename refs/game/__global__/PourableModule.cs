public class PourableModule : ItemModule // TypeDefIndex: 2433
{
	// Fields
	[CompilerGenerated]
	private bool <IsPouring>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <NormalizedPourRate>k__BackingField; // 0x34
	[CompilerGenerated]
	private float <LiquidLevel>k__BackingField; // 0x38
	[Header("Settings")]
	public string LiquidType; // 0x40
	public float PourRate; // 0x48
	public float AngleFromUpToPour; // 0x4C
	public bool OnlyEmptyOverFillable; // 0x50
	public float LiquidCapacity_L; // 0x54
	public Color LiquidColor; // 0x58
	public float DefaultLiquid_L; // 0x68
	[Header("References")]
	public ParticleSystem[] PourParticles; // 0x70
	public Transform PourPoint; // 0x78
	public LiquidContainer LiquidContainer; // 0x80
	public Draggable Draggable; // 0x88
	public DraggableConstraint DraggableConstraint; // 0x90
	public AudioSourceController PourSound; // 0x98
	[Header("Particles")]
	public Color PourParticlesColor; // 0xA0
	public float ParticleMinMultiplier; // 0xB0
	public float ParticleMaxMultiplier; // 0xB4
	private float[] particleMinSizes; // 0xB8
	private float[] particleMaxSizes; // 0xC0
	private Fillable activeFillable; // 0xC8
	private float timeSinceFillableHit; // 0xD0

	// Properties
	public bool IsPouring { get; set; }
	public float NormalizedPourRate { get; set; }
	public float LiquidLevel { get; set; }
	public float NormalizedLiquidLevel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsPouring() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IsPouring(bool value) { }

	[CompilerGenerated]
	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_NormalizedPourRate() { }

	[CompilerGenerated]
	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	private void set_NormalizedPourRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_LiquidLevel() { }

	[CompilerGenerated]
	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	protected void set_LiquidLevel(float value) { }

	// RVA: 0x8928C0 Offset: 0x8912C0 VA: 0x1808928C0
	public float get_NormalizedLiquidLevel() { }

	// RVA: 0x891D90 Offset: 0x890790 VA: 0x180891D90 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x8916C0 Offset: 0x8900C0 VA: 0x1808916C0 Slot: 4
	public override void ActivateModule(StationItem item) { }

	// RVA: 0x891880 Offset: 0x890280 VA: 0x180891880 Slot: 6
	protected virtual void FixedUpdate() { }

	// RVA: 0x892260 Offset: 0x890C60 VA: 0x180892260 Slot: 7
	protected virtual void UpdatePouring() { }

	// RVA: 0x892170 Offset: 0x890B70 VA: 0x180892170
	private void UpdatePourSound() { }

	// RVA: 0x8917C0 Offset: 0x8901C0 VA: 0x1808917C0 Slot: 8
	public virtual void ChangeLiquidLevel(float change) { }

	// RVA: 0x891CD0 Offset: 0x8906D0 VA: 0x180891CD0 Slot: 9
	public virtual void SetLiquidLevel(float level) { }

	// RVA: 0x891AA0 Offset: 0x8904A0 VA: 0x180891AA0 Slot: 10
	protected virtual void PourAmount(float amount) { }

	// RVA: 0x8919E0 Offset: 0x8903E0 VA: 0x1808919E0
	private void ParticleCollision(GameObject other) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	protected virtual bool CanPour() { }

	// RVA: 0x892820 Offset: 0x891220 VA: 0x180892820
	public void .ctor() { }
}
