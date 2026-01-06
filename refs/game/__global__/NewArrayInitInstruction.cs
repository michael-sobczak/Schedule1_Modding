internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 15237
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1B60630 Offset: 0x1B5F030 VA: 0x181B60630
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB9ED0 Offset: 0x1FB88D0 VA: 0x181FB9ED0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FB9E40 Offset: 0x1FB8840 VA: 0x181FB9E40 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
