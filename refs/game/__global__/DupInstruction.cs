internal sealed class DupInstruction : Instruction // TypeDefIndex: 15555
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FE83A0 Offset: 0x1FE6DA0 VA: 0x181FE83A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE8300 Offset: 0x1FE6D00 VA: 0x181FE8300 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FE8330 Offset: 0x1FE6D30 VA: 0x181FE8330
	private static void .cctor() { }
}
