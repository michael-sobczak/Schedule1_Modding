internal class ScopeN : ScopeExpression // TypeDefIndex: 15123
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1FA3A60 Offset: 0x1FA2460 VA: 0x181FA3A60
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x1FBAE90 Offset: 0x1FB9890 VA: 0x181FBAE90 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1FBB080 Offset: 0x1FB9A80 VA: 0x181FBB080 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1FBAEF0 Offset: 0x1FB98F0 VA: 0x181FBAEF0 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FBAF30 Offset: 0x1FB9930 VA: 0x181FBAF30 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
