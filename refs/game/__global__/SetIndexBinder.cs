public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15646
{
	// Methods

	// RVA: 0x20075A0 Offset: 0x2005FA0 VA: 0x1820075A0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x20077A0 Offset: 0x20061A0 VA: 0x1820077A0
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
