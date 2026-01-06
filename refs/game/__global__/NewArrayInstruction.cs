internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 15238
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(Type elementType) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB9F90 Offset: 0x1FB8990 VA: 0x181FB9F90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FB9F00 Offset: 0x1FB8900 VA: 0x181FB9F00 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
