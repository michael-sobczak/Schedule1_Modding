internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 15255
{
	// Fields
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x18
	private readonly bool _hasValue; // 0x19
	private readonly bool _labelTargetGetsValue; // 0x1A

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FB5DB0 Offset: 0x1FB47B0 VA: 0x181FB5DB0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA5280 Offset: 0x1FA3C80 VA: 0x181FA5280 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA52C0 Offset: 0x1FA3CC0 VA: 0x181FA52C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB5D60 Offset: 0x1FB4760 VA: 0x181FB5D60
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1FB5AA0 Offset: 0x1FB44A0 VA: 0x181FB5AA0
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1FB5C10 Offset: 0x1FB4610 VA: 0x181FB5C10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB5CF0 Offset: 0x1FB46F0 VA: 0x181FB5CF0
	private static void .cctor() { }
}
