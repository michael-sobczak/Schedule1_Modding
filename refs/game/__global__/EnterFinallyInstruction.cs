internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 15258
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	private void .ctor(int labelIndex) { }

	// RVA: 0x1FA96C0 Offset: 0x1FA80C0 VA: 0x181FA96C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1FA94A0 Offset: 0x1FA7EA0 VA: 0x181FA94A0
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x1FA95B0 Offset: 0x1FA7FB0 VA: 0x181FA95B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA9650 Offset: 0x1FA8050 VA: 0x181FA9650
	private static void .cctor() { }
}
