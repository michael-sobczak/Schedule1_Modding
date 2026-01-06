public class BinaryExpression : Expression // TypeDefIndex: 15080
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x1F82C10 Offset: 0x1F81610 VA: 0x181F82C10
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x1F82CA0 Offset: 0x1F816A0 VA: 0x181F82CA0 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1F80F10 Offset: 0x1F7F910 VA: 0x181F80F10
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_Right() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Left() { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50
	public MethodInfo get_Method() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x1F826D0 Offset: 0x1F810D0 VA: 0x181F826D0
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x1F82650 Offset: 0x1F81050 VA: 0x181F82650 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1F80DF0 Offset: 0x1F7F7F0 VA: 0x181F80DF0
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x1F82510 Offset: 0x1F80F10 VA: 0x181F82510
	private Expression ReduceVariable() { }

	// RVA: 0x1F81640 Offset: 0x1F80040 VA: 0x181F81640
	private Expression ReduceMember() { }

	// RVA: 0x1F80F20 Offset: 0x1F7F920 VA: 0x181F80F20
	private Expression ReduceIndex() { }

	// RVA: 0x1F82CD0 Offset: 0x1F816D0 VA: 0x181F82CD0
	public LambdaExpression get_Conversion() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x1F82F00 Offset: 0x1F81900 VA: 0x181F82F00
	public bool get_IsLifted() { }

	// RVA: 0x1F82E80 Offset: 0x1F81880 VA: 0x181F82E80
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1F80DC0 Offset: 0x1F7F7C0 VA: 0x181F80DC0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1F82CF0 Offset: 0x1F816F0 VA: 0x181F82CF0
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x1F830C0 Offset: 0x1F81AC0 VA: 0x181F830C0
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x1F81B50 Offset: 0x1F80550 VA: 0x181F81B50
	internal Expression ReduceUserdefinedLifted() { }
}
