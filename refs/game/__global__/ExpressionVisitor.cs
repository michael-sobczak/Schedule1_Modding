public abstract class ExpressionVisitor // TypeDefIndex: 15142
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1FB5310 Offset: 0x1FB3D10 VA: 0x181FB5310 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x1FB5340 Offset: 0x1FB3D40 VA: 0x181FB5340
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x1FB42D0 Offset: 0x1FB2CD0 VA: 0x181FB42D0
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x1FB4E60 Offset: 0x1FB3860 VA: 0x181FB4E60
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9EC50 Offset: 0xE9D650 VA: 0x180E9EC50
	|-ExpressionVisitor.Visit<object>
	|
	|-RVA: 0xE9E800 Offset: 0xE9D200 VA: 0x180E9E800
	|-ExpressionVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9E250 Offset: 0xE9CC50 VA: 0x180E9E250
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9E370 Offset: 0xE9CD70 VA: 0x180E9E370
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: 0x1FB42E0 Offset: 0x1FB2CE0 VA: 0x181FB42E0 Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1FB43D0 Offset: 0x1FB2DD0 VA: 0x181FB43D0 Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1FB4600 Offset: 0x1FB3000 VA: 0x181FB4600 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 9
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1FA7140 Offset: 0x1FA5B40 VA: 0x181FA7140 Slot: 10
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x1FB4750 Offset: 0x1FB3150 VA: 0x181FB4750 Slot: 11
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1FB4910 Offset: 0x1FB3310 VA: 0x181FB4910 Slot: 12
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 13
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x1FB49B0 Offset: 0x1FB33B0 VA: 0x181FB49B0 Slot: 14
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9E740 Offset: 0xE9D140 VA: 0x180E9E740
	|-ExpressionVisitor.VisitLambda<object>
	|
	|-RVA: 0xE9E680 Offset: 0xE9D080 VA: 0x180E9E680
	|-ExpressionVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FB4A70 Offset: 0x1FB3470 VA: 0x181FB4A70 Slot: 16
	protected internal virtual Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1FB4B60 Offset: 0x1FB3560 VA: 0x181FB4B60 Slot: 17
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1FB4840 Offset: 0x1FB3240 VA: 0x181FB4840 Slot: 18
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1FB4C10 Offset: 0x1FB3610 VA: 0x181FB4C10 Slot: 19
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1FB4CE0 Offset: 0x1FB36E0 VA: 0x181FB4CE0 Slot: 20
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 21
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1FB44C0 Offset: 0x1FB2EC0 VA: 0x181FB44C0 Slot: 22
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1FB4E70 Offset: 0x1FB3870 VA: 0x181FB4E70 Slot: 23
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x1FB5040 Offset: 0x1FB3A40 VA: 0x181FB5040 Slot: 24
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1FB5120 Offset: 0x1FB3B20 VA: 0x181FB5120 Slot: 25
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1FB41B0 Offset: 0x1FB2BB0 VA: 0x181FB41B0
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x1FB3F40 Offset: 0x1FB2940 VA: 0x181FB3F40
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x1FB40E0 Offset: 0x1FB2AE0 VA: 0x181FB40E0
	private static void ValidateChildType(Type before, Type after, string methodName) { }
}
