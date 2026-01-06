internal sealed class ExprException // TypeDefIndex: 12946
{
	// Methods

	// RVA: 0x2092820 Offset: 0x2091220 VA: 0x182092820
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x20927C0 Offset: 0x20911C0 VA: 0x1820927C0
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x2092880 Offset: 0x2091280 VA: 0x182092880
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x2092760 Offset: 0x2091160 VA: 0x182092760
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x2092700 Offset: 0x2091100 VA: 0x182092700
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x20919D0 Offset: 0x20903D0 VA: 0x1820919D0
	public static Exception InvokeArgument() { }

	// RVA: 0x2091D80 Offset: 0x2090780 VA: 0x182091D80
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x2091BA0 Offset: 0x20905A0 VA: 0x182091BA0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x2091C70 Offset: 0x2090670 VA: 0x182091C70
	public static Exception MissingOperator(string token) { }

	// RVA: 0x2092170 Offset: 0x2090B70 VA: 0x182092170
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x2091310 Offset: 0x208FD10 VA: 0x182091310
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x20910E0 Offset: 0x208FAE0 VA: 0x1820910E0
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x2092200 Offset: 0x2090C00 VA: 0x182092200
	public static Exception UnboundName(string name) { }

	// RVA: 0x2091830 Offset: 0x2090230 VA: 0x182091830
	public static Exception InvalidString(string str) { }

	// RVA: 0x2092290 Offset: 0x2090C90 VA: 0x182092290
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x2091F50 Offset: 0x2090950 VA: 0x182091F50
	public static Exception SyntaxError() { }

	// RVA: 0x2091280 Offset: 0x208FC80 VA: 0x182091280
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x2091D00 Offset: 0x2090700 VA: 0x182091D00
	public static Exception MissingRightParen() { }

	// RVA: 0x2092460 Offset: 0x2090E60 VA: 0x182092460
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x2092320 Offset: 0x2090D20 VA: 0x182092320
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x2090EA0 Offset: 0x208F8A0 VA: 0x182090EA0
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x2090F80 Offset: 0x208F980 VA: 0x182090F80
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x2091710 Offset: 0x2090110 VA: 0x182091710
	public static Exception InvalidName(string name) { }

	// RVA: 0x2091470 Offset: 0x208FE70 VA: 0x182091470
	public static Exception InvalidDate(string date) { }

	// RVA: 0x2091E10 Offset: 0x2090810 VA: 0x182091E10
	public static Exception NonConstantArgument() { }

	// RVA: 0x20917A0 Offset: 0x20901A0 VA: 0x1820917A0
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x20913F0 Offset: 0x208FDF0 VA: 0x1820913F0
	public static Exception InWithoutParentheses() { }

	// RVA: 0x2091370 Offset: 0x208FD70 VA: 0x182091370
	public static Exception InWithoutList() { }

	// RVA: 0x2091580 Offset: 0x208FF80 VA: 0x182091580
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x2091E90 Offset: 0x2090890 VA: 0x182091E90
	public static Exception Overflow(Type type) { }

	// RVA: 0x2090C70 Offset: 0x208F670 VA: 0x182090C70
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x2090BA0 Offset: 0x208F5A0 VA: 0x182090BA0
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x2092050 Offset: 0x2090A50 VA: 0x182092050
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x2090A80 Offset: 0x208F480 VA: 0x182090A80
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x2092640 Offset: 0x2091040 VA: 0x182092640
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x2091680 Offset: 0x2090080 VA: 0x182091680
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x2091B10 Offset: 0x2090510 VA: 0x182091B10
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x2091FD0 Offset: 0x20909D0 VA: 0x182091FD0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x2092530 Offset: 0x2090F30 VA: 0x182092530
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x2090D80 Offset: 0x208F780 VA: 0x182090D80
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x2090970 Offset: 0x208F370 VA: 0x182090970
	public static Exception AggregateArgument() { }

	// RVA: 0x20909F0 Offset: 0x208F3F0 VA: 0x1820909F0
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x2091060 Offset: 0x208FA60 VA: 0x182091060
	public static Exception EvalNoContext() { }

	// RVA: 0x2091160 Offset: 0x208FB60 VA: 0x182091160
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x2090E10 Offset: 0x208F810 VA: 0x182090E10
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x20911F0 Offset: 0x208FBF0 VA: 0x1820911F0
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x2091A10 Offset: 0x2090410 VA: 0x182091A10
	public static Exception LookupArgument() { }

	// RVA: 0x2091940 Offset: 0x2090340 VA: 0x182091940
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x2091500 Offset: 0x208FF00 VA: 0x182091500
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x2091600 Offset: 0x2090000 VA: 0x182091600
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x20918C0 Offset: 0x20902C0 VA: 0x1820918C0
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x2091A90 Offset: 0x2090490 VA: 0x182091A90
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x20925D0 Offset: 0x2090FD0 VA: 0x1820925D0
	public static Exception UnsupportedDataType(Type type) { }
}
