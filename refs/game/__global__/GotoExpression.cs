public sealed class GotoExpression : Expression // TypeDefIndex: 15144
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x1FB59E0 Offset: 0x1FB43E0 VA: 0x181FB59E0
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1FB5A90 Offset: 0x1FB4490 VA: 0x181FB5A90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Value() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x1FB58F0 Offset: 0x1FB42F0 VA: 0x181FB58F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB5920 Offset: 0x1FB4320 VA: 0x181FB5920
	public GotoExpression Update(LabelTarget target, Expression value) { }
}
