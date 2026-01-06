internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15435
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

	// RVA: 0x1FE3890 Offset: 0x1FE2290 VA: 0x181FE3890 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE37F0 Offset: 0x1FE21F0 VA: 0x181FE37F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FE3780 Offset: 0x1FE2180 VA: 0x181FE3780 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
