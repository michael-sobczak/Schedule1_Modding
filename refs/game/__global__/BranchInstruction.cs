internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 15253
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x18
	internal readonly bool _hasValue; // 0x19

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FA4FC0 Offset: 0x1FA39C0 VA: 0x181FA4FC0 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1FA4F50 Offset: 0x1FA3950 VA: 0x181FA4F50
	internal void .ctor() { }

	// RVA: 0x1FA4F80 Offset: 0x1FA3980 VA: 0x181FA4F80
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x1FA5290 Offset: 0x1FA3C90 VA: 0x181FA5290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA5280 Offset: 0x1FA3C80 VA: 0x181FA5280 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA52C0 Offset: 0x1FA3CC0 VA: 0x181FA52C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
