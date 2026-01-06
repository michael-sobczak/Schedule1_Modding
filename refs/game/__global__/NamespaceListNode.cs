internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 8259
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x2566330 Offset: 0x2564D30 VA: 0x182566330 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x2565FC0 Offset: 0x25649C0 VA: 0x182565FC0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2565F80 Offset: 0x2564980 VA: 0x182565F80 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x2566360 Offset: 0x2564D60 VA: 0x182566360 Slot: 6
	public override bool get_IsNullable() { }
}
