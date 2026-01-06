internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 15573
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(Type type) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FFF9C0 Offset: 0x1FFE3C0 VA: 0x181FFF9C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FFF8F0 Offset: 0x1FFE2F0 VA: 0x181FFF8F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FFF960 Offset: 0x1FFE360 VA: 0x181FFF960 Slot: 3
	public override string ToString() { }
}
