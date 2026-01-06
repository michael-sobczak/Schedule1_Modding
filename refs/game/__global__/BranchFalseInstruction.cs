internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 15250
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1FA4E90 Offset: 0x1FA3890 VA: 0x181FA4E90 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1FA4F20 Offset: 0x1FA3920 VA: 0x181FA4F20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA4DF0 Offset: 0x1FA37F0 VA: 0x181FA4DF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA4E80 Offset: 0x1FA3880 VA: 0x181FA4E80
	public void .ctor() { }
}
