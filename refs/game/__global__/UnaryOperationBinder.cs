public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15648
{
	// Methods

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x200D1E0 Offset: 0x200BBE0 VA: 0x18200D1E0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
