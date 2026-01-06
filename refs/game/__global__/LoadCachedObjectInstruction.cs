internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 15553
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	internal void .ctor(uint index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF0060 Offset: 0x1FEEA60 VA: 0x181FF0060 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FEFE00 Offset: 0x1FEE800 VA: 0x181FEFE00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FEFEB0 Offset: 0x1FEE8B0 VA: 0x181FEFEB0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1FF0000 Offset: 0x1FEEA00 VA: 0x181FF0000 Slot: 3
	public override string ToString() { }
}
