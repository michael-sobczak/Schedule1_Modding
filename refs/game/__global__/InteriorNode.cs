internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 8260
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x2564420 Offset: 0x2562E20 VA: 0x182564420
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2564640 Offset: 0x2563040 VA: 0x182564640 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
