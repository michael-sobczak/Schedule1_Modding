internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 15262
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FA9140 Offset: 0x1FA7B40 VA: 0x181FA9140 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA90D0 Offset: 0x1FA7AD0 VA: 0x181FA90D0
	private static void .cctor() { }
}
