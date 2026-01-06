internal class NewInstruction : Instruction // TypeDefIndex: 15490
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1B60630 Offset: 0x1B5F030 VA: 0x181B60630
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF5DF0 Offset: 0x1FF47F0 VA: 0x181FF5DF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FF5B60 Offset: 0x1FF4560 VA: 0x181FF5B60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FF5A20 Offset: 0x1FF4420 VA: 0x181FF5A20
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x1FF5C80 Offset: 0x1FF4680 VA: 0x181FF5C80 Slot: 3
	public override string ToString() { }
}
