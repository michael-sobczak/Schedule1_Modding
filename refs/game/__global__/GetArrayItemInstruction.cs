internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 15240
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB58C0 Offset: 0x1FB42C0 VA: 0x181FB58C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FB5790 Offset: 0x1FB4190 VA: 0x181FB5790 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB5850 Offset: 0x1FB4250 VA: 0x181FB5850
	private static void .cctor() { }
}
