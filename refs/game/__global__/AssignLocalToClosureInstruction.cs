internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 15439
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	internal void .ctor(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FE3950 Offset: 0x1FE2350 VA: 0x181FE3950 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE38C0 Offset: 0x1FE22C0 VA: 0x181FE38C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
