internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 15261
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1FB7F50 Offset: 0x1FB6950 VA: 0x181FB7F50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FB7EB0 Offset: 0x1FB68B0 VA: 0x181FB7EB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB7EE0 Offset: 0x1FB68E0 VA: 0x181FB7EE0
	private static void .cctor() { }
}
