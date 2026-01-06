internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 15256
{
	// Fields
	private readonly bool _hasFinally; // 0x18
	private TryCatchFinallyHandler _tryHandler; // 0x20

	// Properties
	internal TryCatchFinallyHandler Handler { get; }
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal TryCatchFinallyHandler get_Handler() { }

	// RVA: 0x1FA52C0 Offset: 0x1FA3CC0 VA: 0x181FA52C0 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x1FA9D30 Offset: 0x1FA8730 VA: 0x181FA9D30
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x1FA9740 Offset: 0x1FA8140 VA: 0x181FA9740
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x1FA96F0 Offset: 0x1FA80F0 VA: 0x181FA96F0
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x1FA97A0 Offset: 0x1FA81A0 VA: 0x181FA97A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FA9D70 Offset: 0x1FA8770 VA: 0x181FA9D70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA9CB0 Offset: 0x1FA86B0 VA: 0x181FA9CB0 Slot: 3
	public override string ToString() { }
}
