internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 15527
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF8A80 Offset: 0x1FF7480 VA: 0x181FF8A80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FF89A0 Offset: 0x1FF73A0 VA: 0x181FF89A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FF8A10 Offset: 0x1FF7410 VA: 0x181FF8A10
	private static void .cctor() { }
}
