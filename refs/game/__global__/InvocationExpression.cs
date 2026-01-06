public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 15148
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB77D0 Offset: 0x1FB61D0 VA: 0x181FB77D0
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1DF3BD0 Offset: 0x1DF25D0 VA: 0x181DF3BD0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Expression() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB7770 Offset: 0x1FB6170 VA: 0x181FB7770 Slot: 12
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1FB7860 Offset: 0x1FB6260 VA: 0x181FB7860 Slot: 13
	public virtual int get_ArgumentCount() { }

	// RVA: 0x1FB7740 Offset: 0x1FB6140 VA: 0x181FB7740 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB77A0 Offset: 0x1FB61A0 VA: 0x181FB77A0 Slot: 14
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
