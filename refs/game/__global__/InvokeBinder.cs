public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 15644
{
	// Methods

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x2003310 Offset: 0x2001D10 VA: 0x182003310 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
