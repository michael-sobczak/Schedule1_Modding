public sealed class TryExpression : Expression // TypeDefIndex: 15207
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1FBD9A0 Offset: 0x1FBC3A0 VA: 0x181FBD9A0
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1FBDA70 Offset: 0x1FBC470 VA: 0x181FBDA70 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Expression get_Finally() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Expression get_Fault() { }

	// RVA: 0x1FBD870 Offset: 0x1FBC270 VA: 0x181FBD870 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FBD8A0 Offset: 0x1FBC2A0 VA: 0x181FBD8A0
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}
