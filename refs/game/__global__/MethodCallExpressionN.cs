internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15180
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6A30 Offset: 0x1FB5430 VA: 0x181FB6A30
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x1FB92B0 Offset: 0x1FB7CB0 VA: 0x181FB92B0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1FB9380 Offset: 0x1FB7D80 VA: 0x181FB9380 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB9310 Offset: 0x1FB7D10 VA: 0x181FB9310 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
