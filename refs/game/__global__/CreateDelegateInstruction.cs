internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 15572
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x1FE6BA0 Offset: 0x1FE55A0 VA: 0x181FE6BA0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FE6BD0 Offset: 0x1FE55D0 VA: 0x181FE6BD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE69D0 Offset: 0x1FE53D0 VA: 0x181FE69D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
