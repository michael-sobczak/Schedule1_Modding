public class StepCounter : Sensor // TypeDefIndex: 7418
{
	// Fields
	[CompilerGenerated]
	private IntegerControl <stepCounter>k__BackingField; // 0x190
	[CompilerGenerated]
	private static StepCounter <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Step Counter", noisy = True)]
	public IntegerControl stepCounter { get; set; }
	public static StepCounter current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public IntegerControl get_stepCounter() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_stepCounter(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x281BD00 Offset: 0x281A700 VA: 0x18281BD00
	public static StepCounter get_current() { }

	[CompilerGenerated]
	// RVA: 0x281BD40 Offset: 0x281A740 VA: 0x18281BD40
	private static void set_current(StepCounter value) { }

	// RVA: 0x281BC10 Offset: 0x281A610 VA: 0x18281BC10 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x281BC70 Offset: 0x281A670 VA: 0x18281BC70 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x281BBA0 Offset: 0x281A5A0 VA: 0x18281BBA0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
