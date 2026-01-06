internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 15252
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FA69F0 Offset: 0x1FA53F0 VA: 0x181FA69F0 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1FA6A80 Offset: 0x1FA5480 VA: 0x181FA6A80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FA69B0 Offset: 0x1FA53B0 VA: 0x181FA69B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA4E80 Offset: 0x1FA3880 VA: 0x181FA4E80
	public void .ctor() { }
}
