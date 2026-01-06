public class LightSensor : Sensor // TypeDefIndex: 7413
{
	// Fields
	[CompilerGenerated]
	private AxisControl <lightLevel>k__BackingField; // 0x190
	[CompilerGenerated]
	private static LightSensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Light Level", noisy = True)]
	public AxisControl lightLevel { get; set; }
	public static LightSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_lightLevel() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_lightLevel(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x2818E10 Offset: 0x2817810 VA: 0x182818E10
	public static LightSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2818E50 Offset: 0x2817850 VA: 0x182818E50
	private static void set_current(LightSensor value) { }

	// RVA: 0x2818D20 Offset: 0x2817720 VA: 0x182818D20 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2818D80 Offset: 0x2817780 VA: 0x182818D80 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x2818CB0 Offset: 0x28176B0 VA: 0x182818CB0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
