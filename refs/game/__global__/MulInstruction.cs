internal abstract class MulInstruction : Instruction // TypeDefIndex: 15472
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF2C70 Offset: 0x1FF1670 VA: 0x181FF2C70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FF27F0 Offset: 0x1FF11F0 VA: 0x181FF27F0
	public static Instruction Create(Type type) { }
}
