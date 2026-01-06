public class PressureSensor : Sensor // TypeDefIndex: 7414
{
	// Fields
	[CompilerGenerated]
	private AxisControl <atmosphericPressure>k__BackingField; // 0x190
	[CompilerGenerated]
	private static PressureSensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Atmospheric Pressure", noisy = True)]
	public AxisControl atmosphericPressure { get; set; }
	public static PressureSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_atmosphericPressure() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_atmosphericPressure(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x281A520 Offset: 0x2818F20 VA: 0x18281A520
	public static PressureSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x281A560 Offset: 0x2818F60 VA: 0x18281A560
	private static void set_current(PressureSensor value) { }

	// RVA: 0x281A430 Offset: 0x2818E30 VA: 0x18281A430 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x281A490 Offset: 0x2818E90 VA: 0x18281A490 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x281A3C0 Offset: 0x2818DC0 VA: 0x18281A3C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
