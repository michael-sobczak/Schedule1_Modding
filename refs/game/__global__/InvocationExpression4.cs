internal sealed class InvocationExpression4 : InvocationExpression // TypeDefIndex: 15154
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB72D0 Offset: 0x1FB5CD0 VA: 0x181FB72D0
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1FB70E0 Offset: 0x1FB5AE0 VA: 0x181FB70E0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB71B0 Offset: 0x1FB5BB0 VA: 0x181FB71B0 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
