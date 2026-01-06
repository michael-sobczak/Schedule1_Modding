internal sealed class ExpressionParser // TypeDefIndex: 12940
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x2096040 Offset: 0x2094A40 VA: 0x182096040
	internal void .ctor(DataTable table) { }

	// RVA: 0x2093030 Offset: 0x2091A30 VA: 0x182093030
	internal void LoadExpression(string data) { }

	// RVA: 0x2095B20 Offset: 0x2094520 VA: 0x182095B20
	internal void StartScan() { }

	// RVA: 0x2093640 Offset: 0x2092040 VA: 0x182093640
	internal ExpressionNode Parse() { }

	// RVA: 0x2093260 Offset: 0x2091C60 VA: 0x182093260
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x2093170 Offset: 0x2091B70 VA: 0x182093170
	private ExpressionNode NodePop() { }

	// RVA: 0x2093130 Offset: 0x2091B30 VA: 0x182093130
	private ExpressionNode NodePeek() { }

	// RVA: 0x20931B0 Offset: 0x2091BB0 VA: 0x1820931B0
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x2092AD0 Offset: 0x20914D0 VA: 0x182092AD0
	private void BuildExpression(int pri) { }

	// RVA: 0x2092E50 Offset: 0x2091850 VA: 0x182092E50
	internal void CheckToken(Tokens token) { }

	// RVA: 0x20953E0 Offset: 0x2093DE0 VA: 0x1820953E0
	internal Tokens Scan() { }

	// RVA: 0x2094DC0 Offset: 0x20937C0 VA: 0x182094DC0
	private void ScanNumeric() { }

	// RVA: 0x2094BA0 Offset: 0x20935A0 VA: 0x182094BA0
	private void ScanName() { }

	// RVA: 0x2094C80 Offset: 0x2093680 VA: 0x182094C80
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x2094A80 Offset: 0x2093480 VA: 0x182094A80
	private void ScanDate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ScanBinaryConstant() { }

	// RVA: 0x2094FA0 Offset: 0x20939A0 VA: 0x182094FA0
	private void ScanReserved() { }

	// RVA: 0x2095250 Offset: 0x2093C50 VA: 0x182095250
	private void ScanString(char escape) { }

	// RVA: 0x2095330 Offset: 0x2093D30 VA: 0x182095330
	internal void ScanToken(Tokens token) { }

	// RVA: 0x2095390 Offset: 0x2093D90 VA: 0x182095390
	private void ScanWhite() { }

	// RVA: 0x2093020 Offset: 0x2091A20 VA: 0x182093020
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x2092EA0 Offset: 0x20918A0 VA: 0x182092EA0
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x2092FC0 Offset: 0x20919C0 VA: 0x182092FC0
	private bool IsDigit(char ch) { }

	// RVA: 0x2092F40 Offset: 0x2091940 VA: 0x182092F40
	private bool IsAlpha(char ch) { }

	// RVA: 0x2095BC0 Offset: 0x20945C0 VA: 0x182095BC0
	private static void .cctor() { }
}
