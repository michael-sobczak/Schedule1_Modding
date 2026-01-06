internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 8258
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	public void .ctor(int pos) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Pos() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_Pos(int value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2564FE0 Offset: 0x25639E0 VA: 0x182564FE0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 6
	public override bool get_IsNullable() { }
}
