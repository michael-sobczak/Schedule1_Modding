public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15625
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IgnoreCase() { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1FE8250 Offset: 0x1FE6C50 VA: 0x181FE8250 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
