internal class Filter : AstNode // TypeDefIndex: 8553
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; }
	public AstNode Condition { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public AstNode get_Input() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AstNode get_Condition() { }
}
