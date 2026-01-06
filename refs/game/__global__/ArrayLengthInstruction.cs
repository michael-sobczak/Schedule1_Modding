internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 15242
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FA38B0 Offset: 0x1FA22B0 VA: 0x181FA38B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1FA37A0 Offset: 0x1FA21A0 VA: 0x181FA37A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA3840 Offset: 0x1FA2240 VA: 0x181FA3840
	private static void .cctor() { }
}
