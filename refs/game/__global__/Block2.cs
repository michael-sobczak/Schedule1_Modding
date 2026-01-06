internal sealed class Block2 : BlockExpression // TypeDefIndex: 15116
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA3A60 Offset: 0x1FA2460 VA: 0x181FA3A60
	internal void .ctor(Expression arg0, Expression arg1) { }

	// RVA: 0x1FA38E0 Offset: 0x1FA22E0 VA: 0x181FA38E0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FA3970 Offset: 0x1FA2370 VA: 0x181FA3970 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA3980 Offset: 0x1FA2380 VA: 0x181FA3980 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
