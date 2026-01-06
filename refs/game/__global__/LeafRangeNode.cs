internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 8267
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x2565100 Offset: 0x2563B00 VA: 0x182565100
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x2565150 Offset: 0x2563B50 VA: 0x182565150
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Decimal get_Max() { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Decimal get_Min() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public BitSet get_NextIteration() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x25650B0 Offset: 0x2563AB0 VA: 0x1825650B0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}
