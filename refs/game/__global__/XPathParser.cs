internal class XPathParser // TypeDefIndex: 8600
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static Dictionary<string, XPathParser.ParamInfo> s_functionTable; // 0x48
	private static Dictionary<string, Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x24BF010 Offset: 0x24BDA10 VA: 0x1824BF010
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x24BCEF0 Offset: 0x24BB8F0 VA: 0x1824BCEF0
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x24BE000 Offset: 0x24BCA00 VA: 0x1824BE000
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x24BCCB0 Offset: 0x24BB6B0 VA: 0x1824BCCB0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x24BCDF0 Offset: 0x24BB7F0 VA: 0x1824BCDF0
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x24BE8C0 Offset: 0x24BD2C0 VA: 0x1824BE8C0
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x24BCBB0 Offset: 0x24BB5B0 VA: 0x1824BCBB0
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x24BDA60 Offset: 0x24BC460 VA: 0x1824BDA60
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x24BED30 Offset: 0x24BD730 VA: 0x1824BED30
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x24BEE30 Offset: 0x24BD830 VA: 0x1824BEE30
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x24BCA00 Offset: 0x24BB400 VA: 0x1824BCA00
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x24BE140 Offset: 0x24BCB40 VA: 0x1824BE140
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x24BD080 Offset: 0x24BBA80 VA: 0x1824BD080
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x24BE440 Offset: 0x24BCE40 VA: 0x1824BE440
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x24BD140 Offset: 0x24BBB40 VA: 0x1824BD140
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x24BE9E0 Offset: 0x24BD3E0 VA: 0x1824BE9E0
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x24BCB60 Offset: 0x24BB560 VA: 0x1824BCB60
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x24BEAC0 Offset: 0x24BD4C0 VA: 0x1824BEAC0
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x24BDC10 Offset: 0x24BC610 VA: 0x1824BDC10
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x24BCAD0 Offset: 0x24BB4D0 VA: 0x1824BCAD0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x24BE5D0 Offset: 0x24BCFD0 VA: 0x1824BE5D0
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x24BD2A0 Offset: 0x24BBCA0 VA: 0x1824BD2A0
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x24BB940 Offset: 0x24BA340 VA: 0x1824BB940
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x24BF1D0 Offset: 0x24BDBD0 VA: 0x1824BF1D0
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x24BCB90 Offset: 0x24BB590 VA: 0x1824BCB90
	private void NextLex() { }

	// RVA: 0x24BF200 Offset: 0x24BDC00 VA: 0x1824BF200
	private bool TestOp(string op) { }

	// RVA: 0x24BB8D0 Offset: 0x24BA2D0 VA: 0x1824BB8D0
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x24BBC40 Offset: 0x24BA640 VA: 0x1824BBC40
	private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x24BB9C0 Offset: 0x24BA3C0 VA: 0x1824BB9C0
	private static Dictionary<string, Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x24BC910 Offset: 0x24BB310 VA: 0x1824BC910
	private Axis.AxisType GetAxis() { }

	// RVA: 0x24BF250 Offset: 0x24BDC50 VA: 0x1824BF250
	private static void .cctor() { }
}
