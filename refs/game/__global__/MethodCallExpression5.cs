internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15187
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB91D0 Offset: 0x1FB7BD0 VA: 0x181FB91D0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1FB8F60 Offset: 0x1FB7960 VA: 0x181FB8F60 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB9050 Offset: 0x1FB7A50 VA: 0x181FB9050 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
