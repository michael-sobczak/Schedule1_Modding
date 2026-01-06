internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 15265
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FA9D30 Offset: 0x1FA8730 VA: 0x181FA9D30
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x1FB7E80 Offset: 0x1FB6880 VA: 0x181FB7E80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA52C0 Offset: 0x1FA3CC0 VA: 0x181FA52C0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA52C0 Offset: 0x1FA3CC0 VA: 0x181FA52C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB7C70 Offset: 0x1FB6670 VA: 0x181FB7C70
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x1FB7DC0 Offset: 0x1FB67C0 VA: 0x181FB7DC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB7E10 Offset: 0x1FB6810 VA: 0x181FB7E10
	private static void .cctor() { }
}
