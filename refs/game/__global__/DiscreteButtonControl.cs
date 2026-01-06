public class DiscreteButtonControl : ButtonControl // TypeDefIndex: 7774
{
	// Fields
	public int minValue; // 0x148
	public int maxValue; // 0x14C
	public int wrapAtValue; // 0x150
	public int nullValue; // 0x154
	public DiscreteButtonControl.WriteMode writeMode; // 0x158

	// Methods

	// RVA: 0x2779A80 Offset: 0x2778480 VA: 0x182779A80 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2779BA0 Offset: 0x27785A0 VA: 0x182779BA0 Slot: 17
	public override float ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x2779C70 Offset: 0x2778670 VA: 0x182779C70 Slot: 18
	public override void WriteValueIntoState(float value, void* statePtr) { }

	// RVA: 0x2779DC0 Offset: 0x27787C0 VA: 0x182779DC0
	public void .ctor() { }
}
