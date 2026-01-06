internal sealed class InvocationExpression5 : InvocationExpression // TypeDefIndex: 15155
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38
	private readonly Expression _arg4; // 0x40

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB7560 Offset: 0x1FB5F60 VA: 0x181FB7560
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1FB7340 Offset: 0x1FB5D40 VA: 0x181FB7340 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1FB7430 Offset: 0x1FB5E30 VA: 0x181FB7430 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
