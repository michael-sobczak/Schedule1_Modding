internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15431
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	internal void .ctor(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF0500 Offset: 0x1FEEF00 VA: 0x181FF0500 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FF0450 Offset: 0x1FEEE50 VA: 0x181FF0450 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FF03E0 Offset: 0x1FEEDE0 VA: 0x181FF03E0 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
