public class ConditionalExpression : Expression // TypeDefIndex: 15131
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x1FA6E50 Offset: 0x1FA5850 VA: 0x181FA6E50
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x1FA6B40 Offset: 0x1FA5540 VA: 0x181FA6B40
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1F80D90 Offset: 0x1F7F790 VA: 0x181F80D90 Slot: 5
	public override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_Test() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_IfTrue() { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50
	public Expression get_IfFalse() { }

	// RVA: 0x1FA6AE0 Offset: 0x1FA54E0 VA: 0x181FA6AE0 Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x1FA6AB0 Offset: 0x1FA54B0 VA: 0x181FA6AB0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FA6D80 Offset: 0x1FA5780 VA: 0x181FA6D80
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }
}
