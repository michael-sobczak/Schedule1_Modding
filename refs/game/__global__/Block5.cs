internal sealed class Block5 : BlockExpression // TypeDefIndex: 15119
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28
	private readonly Expression _arg4; // 0x30

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA4230 Offset: 0x1FA2C30 VA: 0x181FA4230
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1FA4000 Offset: 0x1FA2A00 VA: 0x181FA4000 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FA3970 Offset: 0x1FA2370 VA: 0x181FA3970 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA40D0 Offset: 0x1FA2AD0 VA: 0x181FA40D0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
