internal class BlockN : BlockExpression // TypeDefIndex: 15120
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA4D30 Offset: 0x1FA3730 VA: 0x181FA4D30
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x1FA4BF0 Offset: 0x1FA35F0 VA: 0x181FA4BF0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1FA4DA0 Offset: 0x1FA37A0 VA: 0x181FA4DA0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FA4C50 Offset: 0x1FA3650 VA: 0x181FA4C50 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA4C90 Offset: 0x1FA3690 VA: 0x181FA4C90 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
