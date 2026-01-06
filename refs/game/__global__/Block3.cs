internal sealed class Block3 : BlockExpression // TypeDefIndex: 15117
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA3CB0 Offset: 0x1FA26B0 VA: 0x181FA3CB0
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1FA3AF0 Offset: 0x1FA24F0 VA: 0x181FA3AF0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FA3970 Offset: 0x1FA2370 VA: 0x181FA3970 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA3BA0 Offset: 0x1FA25A0 VA: 0x181FA3BA0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
