public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15645
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

	// RVA: 0x2003400 Offset: 0x2001E00 VA: 0x182003400 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}
