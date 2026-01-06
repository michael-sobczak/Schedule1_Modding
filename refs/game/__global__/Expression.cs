public abstract class Expression // TypeDefIndex: 15114
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x1F86F20 Offset: 0x1F85920 VA: 0x181F86F20
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x1F8F450 Offset: 0x1F8DE50 VA: 0x181F8F450
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1F8DA40 Offset: 0x1F8C440 VA: 0x181F8DA40
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x1F8D780 Offset: 0x1F8C180 VA: 0x181F8D780
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x1F8F1F0 Offset: 0x1F8DBF0 VA: 0x181F8F1F0
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1F8EF30 Offset: 0x1F8D930 VA: 0x181F8EF30
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x1F8F870 Offset: 0x1F8E270 VA: 0x181F8F870
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x1F91FD0 Offset: 0x1F909D0 VA: 0x181F91FD0
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x1F98B40 Offset: 0x1F97540 VA: 0x181F98B40
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x1F9E180 Offset: 0x1F9CB80 VA: 0x181F9E180
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x1F9DFC0 Offset: 0x1F9C9C0 VA: 0x181F9DFC0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x1F9DC20 Offset: 0x1F9C620 VA: 0x181F9DC20
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x1F92090 Offset: 0x1F90A90 VA: 0x181F92090
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x1F922C0 Offset: 0x1F90CC0 VA: 0x181F922C0
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x1F9E9A0 Offset: 0x1F9D3A0 VA: 0x181F9E9A0
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x1F9F580 Offset: 0x1F9DF80 VA: 0x181F9F580
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x1F925B0 Offset: 0x1F90FB0 VA: 0x181F925B0
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x1F942D0 Offset: 0x1F92CD0 VA: 0x181F942D0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F93500 Offset: 0x1F91F00 VA: 0x181F93500
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F8C120 Offset: 0x1F8AB20 VA: 0x181F8C120
	public static BinaryExpression Equal(Expression left, Expression right) { }

	// RVA: 0x1F8C190 Offset: 0x1F8AB90 VA: 0x181F8C190
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F99DD0 Offset: 0x1F987D0 VA: 0x181F99DD0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x1F97B40 Offset: 0x1F96540 VA: 0x181F97B40
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	// RVA: 0x1F97BB0 Offset: 0x1F965B0 VA: 0x181F97BB0
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F99F60 Offset: 0x1F98960 VA: 0x181F99F60
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x1F8D0D0 Offset: 0x1F8BAD0 VA: 0x181F8D0D0
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1F904D0 Offset: 0x1F8EED0 VA: 0x181F904D0
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F932B0 Offset: 0x1F91CB0 VA: 0x181F932B0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F903B0 Offset: 0x1F8EDB0 VA: 0x181F903B0
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F93190 Offset: 0x1F91B90 VA: 0x181F93190
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x1F8CE80 Offset: 0x1F8B880 VA: 0x181F8CE80
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x1F86030 Offset: 0x1F84A30 VA: 0x181F86030
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	// RVA: 0x1F85AD0 Offset: 0x1F844D0 VA: 0x181F85AD0
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F98360 Offset: 0x1F96D60 VA: 0x181F98360
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F8A0D0 Offset: 0x1F88AD0 VA: 0x181F8A0D0
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x1F9C670 Offset: 0x1F9B070 VA: 0x181F9C670
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x1F85880 Offset: 0x1F84280 VA: 0x181F85880
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F85360 Offset: 0x1F83D60 VA: 0x181F85360
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F9DCF0 Offset: 0x1F9C6F0 VA: 0x181F9DCF0
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x1F850A0 Offset: 0x1F83AA0 VA: 0x181F850A0
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F85620 Offset: 0x1F84020 VA: 0x181F85620
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F9B2E0 Offset: 0x1F99CE0 VA: 0x181F9B2E0
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F9ADC0 Offset: 0x1F997C0 VA: 0x181F9ADC0
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F9AB00 Offset: 0x1F99500 VA: 0x181F9AB00
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F9B080 Offset: 0x1F99A80 VA: 0x181F9B080
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F8BE20 Offset: 0x1F8A820 VA: 0x181F8BE20
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F8BB60 Offset: 0x1F8A560 VA: 0x181F8BB60
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F96320 Offset: 0x1F94D20 VA: 0x181F96320
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F96060 Offset: 0x1F94A60 VA: 0x181F96060
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F96D60 Offset: 0x1F95760 VA: 0x181F96D60
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F96840 Offset: 0x1F95240 VA: 0x181F96840
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F96580 Offset: 0x1F94F80 VA: 0x181F96580
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F96B00 Offset: 0x1F95500 VA: 0x181F96B00
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F92330 Offset: 0x1F90D30 VA: 0x181F92330
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x1F8EDC0 Offset: 0x1F8D7C0 VA: 0x181F8EDC0
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x1F92F50 Offset: 0x1F91950 VA: 0x181F92F50
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F92CB0 Offset: 0x1F916B0 VA: 0x181F92CB0
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F9A8C0 Offset: 0x1F992C0 VA: 0x181F9A8C0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F9A620 Offset: 0x1F99020 VA: 0x181F9A620
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F86350 Offset: 0x1F84D50 VA: 0x181F86350
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F86090 Offset: 0x1F84A90 VA: 0x181F86090
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F988E0 Offset: 0x1F972E0 VA: 0x181F988E0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F980A0 Offset: 0x1F96AA0 VA: 0x181F980A0
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F8C570 Offset: 0x1F8AF70 VA: 0x181F8C570
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F8C2B0 Offset: 0x1F8ACB0 VA: 0x181F8C2B0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F98FD0 Offset: 0x1F979D0 VA: 0x181F98FD0
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1F98E30 Offset: 0x1F97830 VA: 0x181F98E30
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1F86AC0 Offset: 0x1F854C0 VA: 0x181F86AC0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x1F87B10 Offset: 0x1F86510 VA: 0x181F87B10
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	// RVA: 0x1F87D50 Offset: 0x1F86750 VA: 0x181F87D50
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1F87A00 Offset: 0x1F86400 VA: 0x181F87A00
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1F87C20 Offset: 0x1F86620 VA: 0x181F87C20
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1F87FA0 Offset: 0x1F869A0 VA: 0x181F87FA0
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	// RVA: 0x1F87910 Offset: 0x1F86310 VA: 0x181F87910
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x1F87870 Offset: 0x1F86270 VA: 0x181F87870
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x1F88030 Offset: 0x1F86A30 VA: 0x181F88030
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x1F87BB0 Offset: 0x1F865B0 VA: 0x181F87BB0
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x1F87E30 Offset: 0x1F86830 VA: 0x181F87E30
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x1F87640 Offset: 0x1F86040 VA: 0x181F87640
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x1F87120 Offset: 0x1F85B20 VA: 0x181F87120
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1F9F250 Offset: 0x1F9DC50 VA: 0x181F9F250
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x1F8E930 Offset: 0x1F8D330 VA: 0x181F8E930
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x1F94360 Offset: 0x1F92D60 VA: 0x181F94360
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x1F8AA20 Offset: 0x1F89420 VA: 0x181F8AA20
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x1F8A790 Offset: 0x1F89190 VA: 0x181F8A790
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x1F905F0 Offset: 0x1F8EFF0 VA: 0x181F905F0
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	// RVA: 0x1F8AE90 Offset: 0x1F89890 VA: 0x181F8AE90
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x1F8AC40 Offset: 0x1F89640 VA: 0x181F8AC40
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x1F8C080 Offset: 0x1F8AA80 VA: 0x181F8C080
	public static DefaultExpression Empty() { }

	// RVA: 0x1F8BAB0 Offset: 0x1F8A4B0 VA: 0x181F8BAB0
	public static DefaultExpression Default(Type type) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1F9F9B0 Offset: 0x1F9E3B0 VA: 0x181F9F9B0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x1F9FAA0 Offset: 0x1F9E4A0 VA: 0x181F9FAA0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x1F99D80 Offset: 0x1F98780 VA: 0x181F99D80 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x1F9F760 Offset: 0x1F9E160 VA: 0x181F9F760 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x1F85070 Offset: 0x1F83A70 VA: 0x181F85070 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1F99C30 Offset: 0x1F98630 VA: 0x181F99C30
	public Expression ReduceAndCheck() { }

	// RVA: 0x1F9B690 Offset: 0x1F9A090 VA: 0x181F9B690 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F9A0F0 Offset: 0x1F98AF0 VA: 0x181F9A0F0
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x1F9A210 Offset: 0x1F98C10 VA: 0x181F9A210
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x1F88090 Offset: 0x1F86A90 VA: 0x181F88090
	public static GotoExpression Break(LabelTarget target) { }

	// RVA: 0x1F9A4B0 Offset: 0x1F98EB0 VA: 0x181F9A4B0
	public static GotoExpression Return(LabelTarget target) { }

	// RVA: 0x1F9A560 Offset: 0x1F98F60 VA: 0x181F9A560
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	// RVA: 0x1F90340 Offset: 0x1F8ED40 VA: 0x181F90340
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	// RVA: 0x1F90290 Offset: 0x1F8EC90 VA: 0x181F90290
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x1F94600 Offset: 0x1F93000 VA: 0x181F94600
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1F9C990 Offset: 0x1F9B390 VA: 0x181F9C990
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x1F9C820 Offset: 0x1F9B220 VA: 0x181F9C820
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x1F947C0 Offset: 0x1F931C0 VA: 0x181F947C0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x1F86680 Offset: 0x1F85080 VA: 0x181F86680
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x1F866E0 Offset: 0x1F850E0 VA: 0x181F866E0
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x1F999E0 Offset: 0x1F983E0 VA: 0x181F999E0
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x1F946F0 Offset: 0x1F930F0 VA: 0x181F946F0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1F9CC60 Offset: 0x1F9B660 VA: 0x181F9CC60
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1F9C340 Offset: 0x1F9AD40 VA: 0x181F9C340
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x1F9BE30 Offset: 0x1F9A830 VA: 0x181F9BE30
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x1F90F80 Offset: 0x1F8F980 VA: 0x181F90F80
	internal static InvocationExpression Invoke(Expression expression) { }

	// RVA: 0x1F917B0 Offset: 0x1F901B0 VA: 0x181F917B0
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x1F91080 Offset: 0x1F8FA80 VA: 0x181F91080
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	// RVA: 0x1F91270 Offset: 0x1F8FC70 VA: 0x181F91270
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1F91930 Offset: 0x1F90330 VA: 0x181F91930
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1F914B0 Offset: 0x1F8FEB0 VA: 0x181F914B0
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1F908D0 Offset: 0x1F8F2D0 VA: 0x181F908D0
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	// RVA: 0x1F8D560 Offset: 0x1F8BF60 VA: 0x181F8D560
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x1F92830 Offset: 0x1F91230 VA: 0x181F92830
	public static LabelExpression Label(LabelTarget target) { }

	// RVA: 0x1F92760 Offset: 0x1F91160 VA: 0x181F92760
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x1F92930 Offset: 0x1F91330 VA: 0x181F92930
	public static LabelTarget Label() { }

	// RVA: 0x1F926C0 Offset: 0x1F910C0 VA: 0x181F926C0
	public static LabelTarget Label(string name) { }

	// RVA: 0x1F92A80 Offset: 0x1F91480 VA: 0x181F92A80
	public static LabelTarget Label(Type type) { }

	// RVA: 0x1F929C0 Offset: 0x1F913C0 VA: 0x181F929C0
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x1F8B3A0 Offset: 0x1F89DA0 VA: 0x181F8B3A0
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9EF00 Offset: 0xE9D900 VA: 0x180E9EF00
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9F210 Offset: 0xE9DC10 VA: 0x180E9F210
	|-Expression.Lambda<object>
	|
	|-RVA: 0xE9EF80 Offset: 0xE9D980 VA: 0x180E9EF80
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9F000 Offset: 0xE9DA00 VA: 0x180E9F000
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9F090 Offset: 0xE9DA90 VA: 0x180E9F090
	|-Expression.Lambda<object>
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F92AD0 Offset: 0x1F914D0 VA: 0x181F92AD0
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x1F92BD0 Offset: 0x1F915D0 VA: 0x181F92BD0
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1F9D2F0 Offset: 0x1F9BCF0 VA: 0x181F9D2F0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x1F933D0 Offset: 0x1F91DD0 VA: 0x181F933D0
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x1F8C960 Offset: 0x1F8B360 VA: 0x181F8C960
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x1F8C7D0 Offset: 0x1F8B1D0 VA: 0x181F8C7D0
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x1F99860 Offset: 0x1F98260 VA: 0x181F99860
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x1F994F0 Offset: 0x1F97EF0 VA: 0x181F994F0
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x1F94950 Offset: 0x1F93350 VA: 0x181F94950
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x1F895D0 Offset: 0x1F87FD0 VA: 0x181F895D0
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x1F89950 Offset: 0x1F88350 VA: 0x181F89950
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x1F89AA0 Offset: 0x1F884A0 VA: 0x181F89AA0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1F88AA0 Offset: 0x1F874A0 VA: 0x181F88AA0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1F89690 Offset: 0x1F88090 VA: 0x181F89690
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1F88F00 Offset: 0x1F87900 VA: 0x181F88F00
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1F89C70 Offset: 0x1F88670 VA: 0x181F89C70
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	// RVA: 0x1F8A070 Offset: 0x1F88A70 VA: 0x181F8A070
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x1F894C0 Offset: 0x1F87EC0 VA: 0x181F894C0
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x1F89D00 Offset: 0x1F88700 VA: 0x181F89D00
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x1F89D70 Offset: 0x1F88770 VA: 0x181F89D70
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x1F88CE0 Offset: 0x1F876E0 VA: 0x181F88CE0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1F89230 Offset: 0x1F87C30 VA: 0x181F89230
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1F89F10 Offset: 0x1F88910 VA: 0x181F89F10
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x1F88140 Offset: 0x1F86B40 VA: 0x181F88140
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x1F9DA50 Offset: 0x1F9C450 VA: 0x181F9DA50
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x1F9E260 Offset: 0x1F9CC60 VA: 0x181F9E260
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x1F9C5D0 Offset: 0x1F9AFD0 VA: 0x181F9C5D0
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x1F9C5C0 Offset: 0x1F9AFC0 VA: 0x181F9C5C0
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x1F8EDB0 Offset: 0x1F8D7B0 VA: 0x181F8EDB0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x1F9C5B0 Offset: 0x1F9AFB0 VA: 0x181F9C5B0
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1F9DCB0 Offset: 0x1F9C6B0 VA: 0x181F9DCB0
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x1F9B710 Offset: 0x1F9A110 VA: 0x181F9B710
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x1F8CB60 Offset: 0x1F8B560 VA: 0x181F8CB60
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x1F91BD0 Offset: 0x1F905D0 VA: 0x181F91BD0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x1F865B0 Offset: 0x1F84FB0 VA: 0x181F865B0
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x1F97AE0 Offset: 0x1F964E0 VA: 0x181F97AE0
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x1F97650 Offset: 0x1F96050 VA: 0x181F97650
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x1F97380 Offset: 0x1F95D80 VA: 0x181F97380
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x1F98BF0 Offset: 0x1F975F0 VA: 0x181F98BF0
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x1F98CC0 Offset: 0x1F976C0 VA: 0x181F98CC0
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x1F9F510 Offset: 0x1F9DF10 VA: 0x181F9F510
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x1F9F400 Offset: 0x1F9DE00 VA: 0x181F9F400
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x1F9B6A0 Offset: 0x1F9A0A0 VA: 0x181F9B6A0
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x1F94DB0 Offset: 0x1F937B0 VA: 0x181F94DB0
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x1F9E360 Offset: 0x1F9CD60 VA: 0x181F9E360
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x1F9B980 Offset: 0x1F9A380 VA: 0x181F9B980
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	// RVA: 0x1F9B880 Offset: 0x1F9A280 VA: 0x181F9B880
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	// RVA: 0x1F95000 Offset: 0x1F93A00 VA: 0x181F95000
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x1F8FDA0 Offset: 0x1F8E7A0 VA: 0x181F8FDA0
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x1F8FF40 Offset: 0x1F8E940 VA: 0x181F8FF40
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x1F8E500 Offset: 0x1F8CF00 VA: 0x181F8E500
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x1F8FB30 Offset: 0x1F8E530 VA: 0x181F8FB30
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x1F8FCA0 Offset: 0x1F8E6A0 VA: 0x181F8FCA0
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x1F8E0F0 Offset: 0x1F8CAF0 VA: 0x181F8E0F0
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x1F971A0 Offset: 0x1F95BA0 VA: 0x181F971A0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x1F9BA80 Offset: 0x1F9A480 VA: 0x181F9BA80
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x1F96FC0 Offset: 0x1F959C0 VA: 0x181F96FC0
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x1F97CD0 Offset: 0x1F966D0 VA: 0x181F97CD0
	public static UnaryExpression Not(Expression expression) { }

	// RVA: 0x1F97D20 Offset: 0x1F96720 VA: 0x181F97D20
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x1F91E30 Offset: 0x1F90830 VA: 0x181F91E30
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x1F92410 Offset: 0x1F90E10 VA: 0x181F92410
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x1F97F00 Offset: 0x1F96900 VA: 0x181F97F00
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x1F9B720 Offset: 0x1F9A120 VA: 0x181F9B720
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x1F9BC20 Offset: 0x1F9A620 VA: 0x181F9BC20
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x1F8B340 Offset: 0x1F89D40 VA: 0x181F8B340
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x1F8B130 Offset: 0x1F89B30 VA: 0x181F8B130
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x1F8AEF0 Offset: 0x1F898F0 VA: 0x181F8AEF0
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x1F86D00 Offset: 0x1F85700 VA: 0x181F86D00
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x1F99B10 Offset: 0x1F98510 VA: 0x181F99B10
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x1F9B540 Offset: 0x1F99F40 VA: 0x181F9B540
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x1F90730 Offset: 0x1F8F130 VA: 0x181F90730
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x1F8B910 Offset: 0x1F8A310 VA: 0x181F8B910
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x1F99490 Offset: 0x1F97E90 VA: 0x181F99490
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	// RVA: 0x1F99430 Offset: 0x1F97E30 VA: 0x181F99430
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1F993D0 Offset: 0x1F97DD0 VA: 0x181F993D0
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1F98DD0 Offset: 0x1F977D0 VA: 0x181F98DD0
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1F98D70 Offset: 0x1F97770 VA: 0x181F98D70
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x1F94B00 Offset: 0x1F93500 VA: 0x181F94B00
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x1F9F920 Offset: 0x1F9E320 VA: 0x181F9F920
	private static void .cctor() { }
}
