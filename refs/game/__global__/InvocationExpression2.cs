internal sealed class InvocationExpression2 : InvocationExpression // TypeDefIndex: 15152
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6E70 Offset: 0x1FB5870 VA: 0x181FB6E70
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1FB6CF0 Offset: 0x1FB56F0 VA: 0x181FB6CF0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6DA0 Offset: 0x1FB57A0 VA: 0x181FB6DA0 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
