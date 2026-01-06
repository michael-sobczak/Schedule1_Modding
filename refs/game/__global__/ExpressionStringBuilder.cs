internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 15140
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x1FB3ED0 Offset: 0x1FB28D0 VA: 0x181FB3ED0
	private void .ctor() { }

	// RVA: 0x1FB1D00 Offset: 0x1FB0700 VA: 0x181FB1D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB1AC0 Offset: 0x1FB04C0 VA: 0x181FB1AC0
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x1FB1AC0 Offset: 0x1FB04C0 VA: 0x181FB1AC0
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x1FB19B0 Offset: 0x1FB03B0 VA: 0x181FB19B0
	private int GetId(object o) { }

	// RVA: 0x1FB1CC0 Offset: 0x1FB06C0 VA: 0x181FB1CC0
	private void Out(string s) { }

	// RVA: 0x1FB1CE0 Offset: 0x1FB06E0 VA: 0x181FB1CE0
	private void Out(char c) { }

	// RVA: 0x1FB18D0 Offset: 0x1FB02D0 VA: 0x181FB18D0
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x1FA67B0 Offset: 0x1FA51B0 VA: 0x181FA67B0
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9D7A0 Offset: 0xE9C1A0 VA: 0x180E9D7A0
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9D550 Offset: 0xE9BF50 VA: 0x180E9D550
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x1FB1D30 Offset: 0x1FB0730 VA: 0x181FB1D30 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1FB3730 Offset: 0x1FB2130 VA: 0x181FB3730 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9D9F0 Offset: 0xE9C3F0 VA: 0x180E9D9F0
	|-ExpressionStringBuilder.VisitLambda<object>
	|
	|-RVA: 0xE9D840 Offset: 0xE9C240 VA: 0x180E9D840
	|-ExpressionStringBuilder.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FB2740 Offset: 0x1FB1140 VA: 0x181FB2740 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x1FB2860 Offset: 0x1FB1260 VA: 0x181FB2860 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x1FB1BE0 Offset: 0x1FB05E0 VA: 0x181FB1BE0
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x1FB32C0 Offset: 0x1FB1CC0 VA: 0x181FB32C0 Slot: 17
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1FB3090 Offset: 0x1FB1A90 VA: 0x181FB3090 Slot: 12
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x1FB33E0 Offset: 0x1FB1DE0 VA: 0x181FB33E0 Slot: 19
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1FB35F0 Offset: 0x1FB1FF0 VA: 0x181FB35F0 Slot: 20
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1FB3890 Offset: 0x1FB2290 VA: 0x181FB3890 Slot: 24
	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1FB39B0 Offset: 0x1FB23B0 VA: 0x181FB39B0 Slot: 25
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1FB2360 Offset: 0x1FB0D60 VA: 0x181FB2360 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1FB2A20 Offset: 0x1FB1420 VA: 0x181FB2A20 Slot: 9
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1FB31D0 Offset: 0x1FB1BD0 VA: 0x181FB31D0 Slot: 14
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x1FB2D00 Offset: 0x1FB1700 VA: 0x181FB2D00 Slot: 11
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1FB3260 Offset: 0x1FB1C60 VA: 0x181FB3260 Slot: 16
	protected internal override Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1FB2630 Offset: 0x1FB1030 VA: 0x181FB2630 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1FB3830 Offset: 0x1FB2230 VA: 0x181FB3830 Slot: 23
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x1FB2E90 Offset: 0x1FB1890 VA: 0x181FB2E90 Slot: 18
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1FB2AE0 Offset: 0x1FB14E0 VA: 0x181FB2AE0 Slot: 10
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x1FB1810 Offset: 0x1FB0210 VA: 0x181FB1810
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x1FB1AD0 Offset: 0x1FB04D0 VA: 0x181FB1AD0
	private static bool IsBool(Expression node) { }
}
