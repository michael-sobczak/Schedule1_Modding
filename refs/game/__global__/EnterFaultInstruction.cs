internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 15260
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	private void .ctor(int labelIndex) { }

	// RVA: 0x1FA9470 Offset: 0x1FA7E70 VA: 0x181FA9470 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FA9270 Offset: 0x1FA7C70 VA: 0x181FA9270
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x1FA9380 Offset: 0x1FA7D80 VA: 0x181FA9380 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA9400 Offset: 0x1FA7E00 VA: 0x181FA9400
	private static void .cctor() { }
}
