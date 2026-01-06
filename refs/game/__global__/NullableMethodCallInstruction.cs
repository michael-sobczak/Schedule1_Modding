internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 15583
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF8F60 Offset: 0x1FF7960 VA: 0x181FF8F60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FF8B50 Offset: 0x1FF7550 VA: 0x181FF8B50
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x1FF8AB0 Offset: 0x1FF74B0 VA: 0x181FF8AB0
	public static Instruction CreateGetValue() { }
}
