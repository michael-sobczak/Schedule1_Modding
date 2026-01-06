internal sealed class PopInstruction : Instruction // TypeDefIndex: 15554
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FFA500 Offset: 0x1FF8F00 VA: 0x181FFA500 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FFA460 Offset: 0x1FF8E60 VA: 0x181FFA460 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FFA490 Offset: 0x1FF8E90 VA: 0x181FFA490
	private static void .cctor() { }
}
