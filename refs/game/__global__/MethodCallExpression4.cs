internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15186
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB8E90 Offset: 0x1FB7890 VA: 0x181FB8E90
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1FB8C60 Offset: 0x1FB7660 VA: 0x181FB8C60 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB8D30 Offset: 0x1FB7730 VA: 0x181FB8D30 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
