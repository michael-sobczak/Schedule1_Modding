internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 15383
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FCDF30 Offset: 0x1FCC930 VA: 0x181FCDF30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x1FCDAB0 Offset: 0x1FCC4B0 VA: 0x181FCDAB0
	public static Instruction Create(Type type) { }
}
