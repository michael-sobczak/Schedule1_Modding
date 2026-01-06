public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15647
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x2007960 Offset: 0x2006360 VA: 0x182007960
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x2007A20 Offset: 0x2006420 VA: 0x182007A20 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IgnoreCase() { }

	// RVA: 0x20077D0 Offset: 0x20061D0 VA: 0x1820077D0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }

	// RVA: 0x1FE3A60 Offset: 0x1FE2460 VA: 0x181FE3A60
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
