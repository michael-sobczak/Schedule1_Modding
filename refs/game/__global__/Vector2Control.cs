public class Vector2Control : InputControl<Vector2> // TypeDefIndex: 7786
{
	// Fields
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; // 0x110
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; // 0x118

	// Properties
	[InputControl(offset = 0, displayName = "X")]
	public AxisControl x { get; set; }
	[InputControl(offset = 4, displayName = "Y")]
	public AxisControl y { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public AxisControl get_x() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public AxisControl get_y() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	public void set_y(AxisControl value) { }

	// RVA: 0x278C200 Offset: 0x278AC00 VA: 0x18278C200
	public void .ctor() { }

	// RVA: 0x278BF80 Offset: 0x278A980 VA: 0x18278BF80 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x278C040 Offset: 0x278AA40 VA: 0x18278C040 Slot: 17
	public override Vector2 ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x278C120 Offset: 0x278AB20 VA: 0x18278C120 Slot: 18
	public override void WriteValueIntoState(Vector2 value, void* statePtr) { }

	// RVA: 0x278BEB0 Offset: 0x278A8B0 VA: 0x18278BEB0 Slot: 6
	public override float EvaluateMagnitude(void* statePtr) { }

	// RVA: 0x278BD30 Offset: 0x278A730 VA: 0x18278BD30 Slot: 15
	protected override FourCC CalculateOptimizedControlDataType() { }
}
