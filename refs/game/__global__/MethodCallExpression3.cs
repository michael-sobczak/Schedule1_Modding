internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15185
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB8BA0 Offset: 0x1FB75A0 VA: 0x181FB8BA0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1FB89C0 Offset: 0x1FB73C0 VA: 0x181FB89C0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB8A80 Offset: 0x1FB7480 VA: 0x181FB8A80 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
