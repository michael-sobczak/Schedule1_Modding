internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 15552
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(object value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF0650 Offset: 0x1FEF050 VA: 0x181FF0650 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FF0530 Offset: 0x1FEEF30 VA: 0x181FF0530 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FF05C0 Offset: 0x1FEEFC0 VA: 0x181FF05C0 Slot: 3
	public override string ToString() { }
}
