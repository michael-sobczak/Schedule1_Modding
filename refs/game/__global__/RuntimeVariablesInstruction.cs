internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 15450
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(int count) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FFC080 Offset: 0x1FFAA80 VA: 0x181FFC080 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FFBEC0 Offset: 0x1FFA8C0 VA: 0x181FFBEC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
