public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15613
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; // 0x18

	// Properties
	public ExpressionType Operation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public ExpressionType get_Operation() { }

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	// RVA: 0x1FE3980 Offset: 0x1FE2380 VA: 0x181FE3980 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
