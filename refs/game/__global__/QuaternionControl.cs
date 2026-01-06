public class QuaternionControl : InputControl<Quaternion> // TypeDefIndex: 7781
{
	// Fields
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; // 0x120
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; // 0x128
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; // 0x130
	[CompilerGenerated]
	private AxisControl <w>k__BackingField; // 0x138

	// Properties
	[InputControl(displayName = "X")]
	public AxisControl x { get; set; }
	[InputControl(displayName = "Y")]
	public AxisControl y { get; set; }
	[InputControl(displayName = "Z")]
	public AxisControl z { get; set; }
	[InputControl(displayName = "W")]
	public AxisControl w { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public AxisControl get_x() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public AxisControl get_y() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_y(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public AxisControl get_z() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	public void set_z(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public AxisControl get_w() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	public void set_w(AxisControl value) { }

	// RVA: 0x278A690 Offset: 0x2789090 VA: 0x18278A690
	public void .ctor() { }

	// RVA: 0x278A2C0 Offset: 0x2788CC0 VA: 0x18278A2C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x278A3F0 Offset: 0x2788DF0 VA: 0x18278A3F0 Slot: 17
	public override Quaternion ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x278A550 Offset: 0x2788F50 VA: 0x18278A550 Slot: 18
	public override void WriteValueIntoState(Quaternion value, void* statePtr) { }

	// RVA: 0x278A000 Offset: 0x2788A00 VA: 0x18278A000 Slot: 15
	protected override FourCC CalculateOptimizedControlDataType() { }
}
