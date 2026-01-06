internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 15264
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1B5FE70 Offset: 0x1B5E870 VA: 0x181B5FE70
	private void .ctor(bool hasValue) { }

	// RVA: 0x1FA9240 Offset: 0x1FA7C40 VA: 0x181FA9240 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA9230 Offset: 0x1FA7C30 VA: 0x181FA9230 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA9170 Offset: 0x1FA7B70 VA: 0x181FA9170
	private static void .cctor() { }
}
