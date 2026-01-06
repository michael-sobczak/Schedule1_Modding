public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15642
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

	// RVA: 0x20031F0 Offset: 0x2001BF0 VA: 0x1820031F0
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x20032B0 Offset: 0x2001CB0 VA: 0x1820032B0 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IgnoreCase() { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x2003100 Offset: 0x2001B00 VA: 0x182003100 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }
}
