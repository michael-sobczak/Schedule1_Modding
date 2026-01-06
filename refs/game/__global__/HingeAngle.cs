public class HingeAngle : Sensor // TypeDefIndex: 7419
{
	// Fields
	[CompilerGenerated]
	private AxisControl <angle>k__BackingField; // 0x190
	[CompilerGenerated]
	private static HingeAngle <current>k__BackingField; // 0x0

	// Properties
	public AxisControl angle { get; set; }
	public static HingeAngle current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_angle() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_angle(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x2808500 Offset: 0x2806F00 VA: 0x182808500
	public static HingeAngle get_current() { }

	[CompilerGenerated]
	// RVA: 0x2808540 Offset: 0x2806F40 VA: 0x182808540
	private static void set_current(HingeAngle value) { }

	// RVA: 0x2808410 Offset: 0x2806E10 VA: 0x182808410 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2808470 Offset: 0x2806E70 VA: 0x182808470 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28083A0 Offset: 0x2806DA0 VA: 0x1828083A0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
