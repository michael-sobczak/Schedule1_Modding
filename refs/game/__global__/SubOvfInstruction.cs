internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 15571
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FFD730 Offset: 0x1FFC130 VA: 0x181FFD730 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FFD390 Offset: 0x1FFBD90 VA: 0x181FFD390
	public static Instruction Create(Type type) { }
}
