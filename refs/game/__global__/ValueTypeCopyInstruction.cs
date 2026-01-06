internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 15440
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2000E90 Offset: 0x1FFF890 VA: 0x182000E90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2000DD0 Offset: 0x1FFF7D0 VA: 0x182000DD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x2000E20 Offset: 0x1FFF820 VA: 0x182000E20
	private static void .cctor() { }
}
