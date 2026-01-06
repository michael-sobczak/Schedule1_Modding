internal class StyleSyntaxParser // TypeDefIndex: 7192
{
	// Fields
	private List<Expression> m_ProcessExpressionList; // 0x10
	private Stack<Expression> m_ExpressionStack; // 0x18
	private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
	private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28

	// Methods

	// RVA: 0x2E53620 Offset: 0x2E52020 VA: 0x182E53620
	public Expression Parse(string syntax) { }

	// RVA: 0x2E52480 Offset: 0x2E50E80 VA: 0x182E52480
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E537D0 Offset: 0x2E521D0 VA: 0x182E537D0
	private void ProcessCombinatorStack() { }

	// RVA: 0x2E53470 Offset: 0x2E51E70 VA: 0x182E53470
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E51BF0 Offset: 0x2E505F0 VA: 0x182E51BF0
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E52720 Offset: 0x2E51120 VA: 0x182E52720
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E51E40 Offset: 0x2E50840 VA: 0x182E51E40
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E52CB0 Offset: 0x2E516B0 VA: 0x182E52CB0
	private Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x2E52E60 Offset: 0x2E51860 VA: 0x182E52E60
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E52A20 Offset: 0x2E51420 VA: 0x182E52A20
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	// RVA: 0x2E53310 Offset: 0x2E51D10 VA: 0x182E53310
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	// RVA: 0x2E51B20 Offset: 0x2E50520 VA: 0x182E51B20
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2E51BA0 Offset: 0x2E505A0 VA: 0x182E51BA0
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x2E51B80 Offset: 0x2E50580 VA: 0x182E51B80
	private static bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x2E51BC0 Offset: 0x2E505C0 VA: 0x182E51BC0
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x2E53B30 Offset: 0x2E52530 VA: 0x182E53B30
	public void .ctor() { }
}
