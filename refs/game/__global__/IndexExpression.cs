public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 15147
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB5EF0 Offset: 0x1FB48F0 VA: 0x181FB5EF0
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x1FB5FF0 Offset: 0x1FB49F0 VA: 0x181FB5FF0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1FB6000 Offset: 0x1FB4A00 VA: 0x181FB6000 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Object() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public PropertyInfo get_Indexer() { }

	// RVA: 0x1FB5E10 Offset: 0x1FB4810 VA: 0x181FB5E10 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1FB5FA0 Offset: 0x1FB49A0 VA: 0x181FB5FA0 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x1FB5DE0 Offset: 0x1FB47E0 VA: 0x181FB5DE0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB5E70 Offset: 0x1FB4870 VA: 0x181FB5E70
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }
}
