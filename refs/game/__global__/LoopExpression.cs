public sealed class LoopExpression : Expression // TypeDefIndex: 15168
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	// RVA: 0x1FB8130 Offset: 0x1FB6B30 VA: 0x181FB8130
	internal void .ctor(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x1FB81E0 Offset: 0x1FB6BE0 VA: 0x181FB81E0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1FB81D0 Offset: 0x1FB6BD0 VA: 0x181FB81D0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public LabelTarget get_BreakLabel() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LabelTarget get_ContinueLabel() { }

	// RVA: 0x1FB8070 Offset: 0x1FB6A70 VA: 0x181FB8070 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB80A0 Offset: 0x1FB6AA0 VA: 0x181FB80A0
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }
}
