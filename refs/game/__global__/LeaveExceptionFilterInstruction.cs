internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 15263
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FB7C40 Offset: 0x1FB6640 VA: 0x181FB7C40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB7BD0 Offset: 0x1FB65D0 VA: 0x181FB7BD0
	private static void .cctor() { }
}
