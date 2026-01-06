internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 15083
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1F83F20 Offset: 0x1F82920 VA: 0x181F83F20
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1DB2C00 Offset: 0x1DB1600 VA: 0x181DB2C00 Slot: 5
	public sealed override Type get_Type() { }
}
