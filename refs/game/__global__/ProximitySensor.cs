public class ProximitySensor : Sensor // TypeDefIndex: 7415
{
	// Fields
	[CompilerGenerated]
	private AxisControl <distance>k__BackingField; // 0x190
	[CompilerGenerated]
	private static ProximitySensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Distance", noisy = True)]
	public AxisControl distance { get; set; }
	public static ProximitySensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_distance() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_distance(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x281A720 Offset: 0x2819120 VA: 0x18281A720
	public static ProximitySensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x281A760 Offset: 0x2819160 VA: 0x18281A760
	private static void set_current(ProximitySensor value) { }

	// RVA: 0x281A630 Offset: 0x2819030 VA: 0x18281A630 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x281A690 Offset: 0x2819090 VA: 0x18281A690 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x281A5C0 Offset: 0x2818FC0 VA: 0x18281A5C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
