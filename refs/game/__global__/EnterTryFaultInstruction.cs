internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 15257
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }
	internal TryFaultHandler Handler { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	internal void .ctor(int targetIndex) { }

	// RVA: 0x1FAA060 Offset: 0x1FA8A60 VA: 0x181FAA060 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal TryFaultHandler get_Handler() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x1FA9DC0 Offset: 0x1FA87C0 VA: 0x181FA9DC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
