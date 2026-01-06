public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 10987
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x20
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x28
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x30
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x38
	internal Nullable<bool> _isReference; // 0x40
	internal Nullable<bool> _itemIsReference; // 0x42
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x44
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x4C
	private Type _namingStrategyType; // 0x58
	[Nullable(new[] { 2, 1 })]
	private object[] _namingStrategyParameters; // 0x60

	// Properties
	public string Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public Type ItemConverterType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; set; }
	public Type NamingStrategyType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; set; }
	internal NamingStrategy NamingStrategyInstance { get; set; }
	public bool IsReference { get; set; }
	public bool ItemIsReference { get; set; }
	public ReferenceLoopHandling ItemReferenceLoopHandling { get; set; }
	public TypeNameHandling ItemTypeNameHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Id(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_ItemConverterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_ItemConverterParameters(object[] value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Type get_NamingStrategyType() { }

	// RVA: 0x1D08E60 Offset: 0x1D07860 VA: 0x181D08E60
	public void set_NamingStrategyType(Type value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0x1D08E30 Offset: 0x1D07830 VA: 0x181D08E30
	public void set_NamingStrategyParameters(object[] value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal NamingStrategy get_NamingStrategyInstance() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

	// RVA: 0x1D08BB0 Offset: 0x1D075B0 VA: 0x181D08BB0
	public bool get_IsReference() { }

	// RVA: 0x1D08CB0 Offset: 0x1D076B0 VA: 0x181D08CB0
	public void set_IsReference(bool value) { }

	// RVA: 0x1D08BF0 Offset: 0x1D075F0 VA: 0x181D08BF0
	public bool get_ItemIsReference() { }

	// RVA: 0x1D08D10 Offset: 0x1D07710 VA: 0x181D08D10
	public void set_ItemIsReference(bool value) { }

	// RVA: 0x1D08C30 Offset: 0x1D07630 VA: 0x181D08C30
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	// RVA: 0x1D08D70 Offset: 0x1D07770 VA: 0x181D08D70
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1D08C70 Offset: 0x1D07670 VA: 0x181D08C70
	public TypeNameHandling get_ItemTypeNameHandling() { }

	// RVA: 0x1D08DD0 Offset: 0x1D077D0 VA: 0x181D08DD0
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	protected void .ctor(string id) { }
}
