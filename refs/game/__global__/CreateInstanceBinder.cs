public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 15623
{
	// Methods

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1FE6C00 Offset: 0x1FE5600 VA: 0x181FE6C00 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
