internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15191
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB68A0 Offset: 0x1FB52A0 VA: 0x181FB68A0
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1FB66A0 Offset: 0x1FB50A0 VA: 0x181FB66A0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB6760 Offset: 0x1FB5160 VA: 0x181FB6760 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
