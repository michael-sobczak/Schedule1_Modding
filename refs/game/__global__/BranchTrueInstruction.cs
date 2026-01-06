internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 15251
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1FA5680 Offset: 0x1FA4080 VA: 0x181FA5680 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1FA5710 Offset: 0x1FA4110 VA: 0x181FA5710 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA55F0 Offset: 0x1FA3FF0 VA: 0x181FA55F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA4E80 Offset: 0x1FA3880 VA: 0x181FA4E80
	public void .ctor() { }
}
