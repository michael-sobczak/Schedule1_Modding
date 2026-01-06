internal abstract class NegateInstruction : Instruction // TypeDefIndex: 15485
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF5760 Offset: 0x1FF4160 VA: 0x181FF5760 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FF5440 Offset: 0x1FF3E40 VA: 0x181FF5440
	public static Instruction Create(Type type) { }
}
