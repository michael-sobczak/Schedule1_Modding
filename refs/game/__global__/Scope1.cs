internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 15122
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FBADB0 Offset: 0x1FB97B0 VA: 0x181FBADB0
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x1FA3A60 Offset: 0x1FA2460 VA: 0x181FA3A60
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x1FBABF0 Offset: 0x1FB95F0 VA: 0x181FBABF0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FBAC70 Offset: 0x1FB9670 VA: 0x181FBAC70 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FBAC80 Offset: 0x1FB9680 VA: 0x181FBAC80 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
