public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15641
{
	// Methods

	// RVA: 0x2003010 Offset: 0x2001A10 VA: 0x182003010 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}
