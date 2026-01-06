public class BlockExpression : Expression // TypeDefIndex: 15115
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0xD3C090 Offset: 0xD3AA90 VA: 0x180D3C090
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1C02300 Offset: 0x1C00D00 VA: 0x181C02300
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x1FA4B00 Offset: 0x1FA3500 VA: 0x181FA4B00
	internal void .ctor() { }

	// RVA: 0x1FA4890 Offset: 0x1FA3290 VA: 0x181FA4890 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FA4B80 Offset: 0x1FA3580 VA: 0x181FA4B80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1FA4B90 Offset: 0x1FA3590 VA: 0x181FA4B90 Slot: 5
	public override Type get_Type() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA48C0 Offset: 0x1FA32C0 VA: 0x181FA48C0 Slot: 10
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x1FA4B50 Offset: 0x1FA3550 VA: 0x181FA4B50 Slot: 11
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA48F0 Offset: 0x1FA32F0 VA: 0x181FA48F0 Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1FA4920 Offset: 0x1FA3320 VA: 0x181FA4920 Slot: 13
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4AD0 Offset: 0x1FA34D0 VA: 0x181FA4AD0 Slot: 14
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x1FA4970 Offset: 0x1FA3370 VA: 0x181FA4970
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}
