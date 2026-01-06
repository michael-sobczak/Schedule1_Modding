internal sealed class Block4 : BlockExpression // TypeDefIndex: 15118
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA3F40 Offset: 0x1FA2940 VA: 0x181FA3F40
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1FA3D50 Offset: 0x1FA2750 VA: 0x181FA3D50 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FA3970 Offset: 0x1FA2370 VA: 0x181FA3970 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA3E10 Offset: 0x1FA2810 VA: 0x181FA3E10 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
