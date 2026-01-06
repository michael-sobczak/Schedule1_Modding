internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15436
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	internal void .ctor(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FFC890 Offset: 0x1FFB290 VA: 0x181FFC890 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FFC7F0 Offset: 0x1FFB1F0 VA: 0x181FFC7F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FFC780 Offset: 0x1FFB180 VA: 0x181FFC780 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
