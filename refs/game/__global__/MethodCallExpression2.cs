internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15184
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB8920 Offset: 0x1FB7320 VA: 0x181FB8920
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1FB8780 Offset: 0x1FB7180 VA: 0x181FB8780 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB8830 Offset: 0x1FB7230 VA: 0x181FB8830 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
