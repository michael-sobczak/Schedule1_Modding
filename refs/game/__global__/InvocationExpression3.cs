internal sealed class InvocationExpression3 : InvocationExpression // TypeDefIndex: 15153
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB7080 Offset: 0x1FB5A80 VA: 0x181FB7080
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1FB6EC0 Offset: 0x1FB58C0 VA: 0x181FB6EC0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6F80 Offset: 0x1FB5980 VA: 0x181FB6F80 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
