internal class Operand : AstNode // TypeDefIndex: 8573
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public object OperandValue { get; }

	// Methods

	// RVA: 0x24A2730 Offset: 0x24A1130 VA: 0x1824A2730
	public void .ctor(string val) { }

	// RVA: 0x24A2770 Offset: 0x24A1170 VA: 0x1824A2770
	public void .ctor(double val) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public object get_OperandValue() { }
}
