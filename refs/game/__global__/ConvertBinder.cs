public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 15622
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Type get_Type() { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1FE6920 Offset: 0x1FE5320 VA: 0x181FE6920 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
