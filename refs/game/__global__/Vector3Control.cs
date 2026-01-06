public class Vector3Control : InputControl<Vector3> // TypeDefIndex: 7787
{
	// Fields
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; // 0x118
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; // 0x120
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; // 0x128

	// Properties
	[InputControl(offset = 0, displayName = "X")]
	public AxisControl x { get; set; }
	[InputControl(offset = 4, displayName = "Y")]
	public AxisControl y { get; set; }
	[InputControl(offset = 8, displayName = "Z")]
	public AxisControl z { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public AxisControl get_x() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public AxisControl get_y() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	public void set_y(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public AxisControl get_z() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_z(AxisControl value) { }

	// RVA: 0x278C8E0 Offset: 0x278B2E0 VA: 0x18278C8E0
	public void .ctor() { }

	// RVA: 0x278C5B0 Offset: 0x278AFB0 VA: 0x18278C5B0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x278C6A0 Offset: 0x278B0A0 VA: 0x18278C6A0 Slot: 17
	public override Vector3 ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x278C7D0 Offset: 0x278B1D0 VA: 0x18278C7D0 Slot: 18
	public override void WriteValueIntoState(Vector3 value, void* statePtr) { }

	// RVA: 0x278C4E0 Offset: 0x278AEE0 VA: 0x18278C4E0 Slot: 6
	public override float EvaluateMagnitude(void* statePtr) { }

	// RVA: 0x278C2E0 Offset: 0x278ACE0 VA: 0x18278C2E0 Slot: 15
	protected override FourCC CalculateOptimizedControlDataType() { }
}
