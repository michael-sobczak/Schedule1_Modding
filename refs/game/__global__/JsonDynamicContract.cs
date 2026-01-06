public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 11247
{
	// Fields
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
	[Nullable(new[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8

	// Properties
	public JsonPropertyCollection Properties { get; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> PropertyNameResolver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public Func<string, string> get_PropertyNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_PropertyNameResolver(Func<string, string> value) { }

	// RVA: 0x1D83B80 Offset: 0x1D82580 VA: 0x181D83B80
	private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) { }

	// RVA: 0x1D83C80 Offset: 0x1D82680 VA: 0x181D83C80
	private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) { }

	// RVA: 0x1D84030 Offset: 0x1D82A30 VA: 0x181D84030
	public void .ctor(Type underlyingType) { }

	// RVA: 0x1D83D80 Offset: 0x1D82780 VA: 0x181D83D80
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0x1D83EE0 Offset: 0x1D828E0 VA: 0x181D83EE0
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }
}
