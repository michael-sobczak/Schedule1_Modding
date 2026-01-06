internal class Operator : AstNode // TypeDefIndex: 8576
{
	// Fields
	private static Operator.Op[] s_invertOp; // 0x0
	private Operator.Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public Operator.Op OperatorType { get; }
	public AstNode Operand1 { get; }
	public AstNode Operand2 { get; }

	// Methods

	// RVA: 0x24A27E0 Offset: 0x24A11E0 VA: 0x1824A27E0
	public static Operator.Op InvertOperator(Operator.Op op) { }

	// RVA: 0x165BA70 Offset: 0x165A470 VA: 0x18165BA70
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x24A28E0 Offset: 0x24A12E0 VA: 0x1824A28E0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public Operator.Op get_OperatorType() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AstNode get_Operand1() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public AstNode get_Operand2() { }

	// RVA: 0x24A2850 Offset: 0x24A1250 VA: 0x1824A2850
	private static void .cctor() { }
}
