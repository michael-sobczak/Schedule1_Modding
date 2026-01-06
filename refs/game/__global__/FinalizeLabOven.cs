public class FinalizeLabOven : Task // TypeDefIndex: 791
{
	// Fields
	public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1;
	public float SMASH_VELOCITY_THRESHOLD; // 0xA0
	public float SMASH_COOLDOWN; // 0xA4
	public const int REQUIRED_IMPACTS = 3;
	[CompilerGenerated]
	private LabOven <Oven>k__BackingField; // 0xA8
	private Coroutine startSequence; // 0xB0
	private LabOvenHammer hammer; // 0xB8
	private int impactCount; // 0xC0
	private float timeSinceLastImpact; // 0xC4

	// Properties
	public LabOven Oven { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public LabOven get_Oven() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	private void set_Oven(LabOven value) { }

	// RVA: 0x58A670 Offset: 0x589070 VA: 0x18058A670
	public void .ctor(LabOven oven) { }

	// RVA: 0x58A630 Offset: 0x589030 VA: 0x18058A630 Slot: 9
	public override void Update() { }

	// RVA: 0x58A1D0 Offset: 0x588BD0 VA: 0x18058A1D0 Slot: 6
	public override void StopTask() { }

	[IteratorStateMachine(typeof(FinalizeLabOven.<StartSequence>d__15))]
	// RVA: 0x58A160 Offset: 0x588B60 VA: 0x18058A160
	private IEnumerator StartSequence() { }

	// RVA: 0x589A20 Offset: 0x588420 VA: 0x180589A20
	public void Collision(Collision col) { }

	// RVA: 0x589E80 Offset: 0x588880 VA: 0x180589E80
	private void Shatter() { }

	[IteratorStateMachine(typeof(FinalizeLabOven.<<Shatter>g__Routine|17_0>d))]
	[CompilerGenerated]
	// RVA: 0x58A5C0 Offset: 0x588FC0 VA: 0x18058A5C0
	private IEnumerator <Shatter>g__Routine|17_0() { }
}
