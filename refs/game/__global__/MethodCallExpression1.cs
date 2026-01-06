internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15183
{
	// Fields
	private object _arg0; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6A30 Offset: 0x1FB5430 VA: 0x181FB6A30
	public void .ctor(MethodInfo method, Expression arg0) { }

	// RVA: 0x1FB8630 Offset: 0x1FB7030 VA: 0x181FB8630 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB86D0 Offset: 0x1FB70D0 VA: 0x181FB86D0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
