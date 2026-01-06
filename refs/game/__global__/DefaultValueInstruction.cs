internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 15278
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(Type type) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FA7ED0 Offset: 0x1FA68D0 VA: 0x181FA7ED0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA7E30 Offset: 0x1FA6830 VA: 0x181FA7E30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA7E70 Offset: 0x1FA6870 VA: 0x181FA7E70 Slot: 3
	public override string ToString() { }
}
