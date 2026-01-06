public sealed class TypeBinaryExpression : Expression // TypeDefIndex: 15208
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	public Type TypeOperand { get; }

	// Methods

	// RVA: 0x1FBDB70 Offset: 0x1FBC570 VA: 0x181FBDB70
	internal void .ctor(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	// RVA: 0x1FBDC10 Offset: 0x1FBC610 VA: 0x181FBDC10 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_TypeOperand() { }

	// RVA: 0x1FBDA80 Offset: 0x1FBC480 VA: 0x181FBDA80 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FBDAB0 Offset: 0x1FBC4B0 VA: 0x181FBDAB0
	public TypeBinaryExpression Update(Expression expression) { }
}
