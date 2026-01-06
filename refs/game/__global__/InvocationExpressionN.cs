internal sealed class InvocationExpressionN : InvocationExpression // TypeDefIndex: 15149
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB76B0 Offset: 0x1FB60B0 VA: 0x181FB76B0
	public void .ctor(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	// RVA: 0x1FB75E0 Offset: 0x1FB5FE0 VA: 0x181FB75E0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x1FB76F0 Offset: 0x1FB60F0 VA: 0x181FB76F0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB7640 Offset: 0x1FB6040 VA: 0x181FB7640 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
