internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15181
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6450 Offset: 0x1FB4E50 VA: 0x181FB6450
	public void .ctor(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	// RVA: 0x1FB6900 Offset: 0x1FB5300 VA: 0x181FB6900 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1FB69E0 Offset: 0x1FB53E0 VA: 0x181FB69E0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6960 Offset: 0x1FB5360 VA: 0x181FB6960 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
