internal abstract class CastInstruction : Instruction // TypeDefIndex: 15588
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FE4FF0 Offset: 0x1FE39F0 VA: 0x181FE4FF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE4760 Offset: 0x1FE3160 VA: 0x181FE4760
	public static Instruction Create(Type t) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }
}
