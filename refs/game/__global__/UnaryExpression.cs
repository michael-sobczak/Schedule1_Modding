public sealed class UnaryExpression : Expression // TypeDefIndex: 15209
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1FBF320 Offset: 0x1FBDD20 VA: 0x181FBF320
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Expression get_Operand() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public MethodInfo get_Method() { }

	// RVA: 0x1FBF480 Offset: 0x1FBDE80 VA: 0x181FBF480
	public bool get_IsLifted() { }

	// RVA: 0x1FBF400 Offset: 0x1FBDE00 VA: 0x181FBF400
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1FBDEE0 Offset: 0x1FBC8E0 VA: 0x181FBDEE0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FBF3D0 Offset: 0x1FBDDD0 VA: 0x181FBF3D0 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1FBF1D0 Offset: 0x1FBDBD0 VA: 0x181FBF1D0 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1FBF6F0 Offset: 0x1FBE0F0 VA: 0x181FBF6F0
	private bool get_IsPrefix() { }

	// RVA: 0x1FBDF10 Offset: 0x1FBC910 VA: 0x181FBDF10
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1FBEE80 Offset: 0x1FBD880 VA: 0x181FBEE80
	private Expression ReduceVariable() { }

	// RVA: 0x1FBE860 Offset: 0x1FBD260 VA: 0x181FBE860
	private Expression ReduceMember() { }

	// RVA: 0x1FBE060 Offset: 0x1FBCA60 VA: 0x181FBE060
	private Expression ReduceIndex() { }

	// RVA: 0x1FBF250 Offset: 0x1FBDC50 VA: 0x181FBF250
	public UnaryExpression Update(Expression operand) { }
}
