internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15190
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6650 Offset: 0x1FB5050 VA: 0x181FB6650
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x1FB6490 Offset: 0x1FB4E90 VA: 0x181FB6490 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6540 Offset: 0x1FB4F40 VA: 0x181FB6540 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
