public sealed class LabelExpression : Expression // TypeDefIndex: 15156
{
	// Fields
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x1FB7950 Offset: 0x1FB6350 VA: 0x181FB7950
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0x1B1E570 Offset: 0x1B1CF70 VA: 0x181B1E570 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0xF728E0 Offset: 0xF712E0 VA: 0x180F728E0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_DefaultValue() { }

	// RVA: 0x1FB7890 Offset: 0x1FB6290 VA: 0x181FB7890 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB78C0 Offset: 0x1FB62C0 VA: 0x181FB78C0
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }
}
