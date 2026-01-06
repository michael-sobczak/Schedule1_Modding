internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15189
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB6450 Offset: 0x1FB4E50 VA: 0x181FB6450
	public void .ctor(MethodInfo method, Expression instance, Expression arg0) { }

	// RVA: 0x1FB62F0 Offset: 0x1FB4CF0 VA: 0x181FB62F0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6390 Offset: 0x1FB4D90 VA: 0x181FB6390 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
