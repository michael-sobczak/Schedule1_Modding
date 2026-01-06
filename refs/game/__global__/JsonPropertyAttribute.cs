public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 11001
{
	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x60
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; // 0x70
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public Type ItemConverterType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; set; }
	public Type NamingStrategyType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; set; }
	public NullValueHandling NullValueHandling { get; set; }
	public DefaultValueHandling DefaultValueHandling { get; set; }
	public ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public ObjectCreationHandling ObjectCreationHandling { get; set; }
	public TypeNameHandling TypeNameHandling { get; set; }
	public bool IsReference { get; set; }
	public int Order { get; set; }
	public Required Required { get; set; }
	public string PropertyName { get; set; }
	public ReferenceLoopHandling ItemReferenceLoopHandling { get; set; }
	public TypeNameHandling ItemTypeNameHandling { get; set; }
	public bool ItemIsReference { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_ItemConverterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_ItemConverterParameters(object[] value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_NamingStrategyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_NamingStrategyParameters(object[] value) { }

	// RVA: 0x1D0EC10 Offset: 0x1D0D610 VA: 0x181D0EC10
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1D0EF70 Offset: 0x1D0D970 VA: 0x181D0EF70
	public void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1D0EAD0 Offset: 0x1D0D4D0 VA: 0x181D0EAD0
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x1D0ED90 Offset: 0x1D0D790 VA: 0x181D0ED90
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1D0ECD0 Offset: 0x1D0D6D0 VA: 0x181D0ECD0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x1D0F090 Offset: 0x1D0DA90 VA: 0x181D0F090
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1D0EC50 Offset: 0x1D0D650 VA: 0x181D0EC50
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1D0EFD0 Offset: 0x1D0D9D0 VA: 0x181D0EFD0
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1D0ED50 Offset: 0x1D0D750 VA: 0x181D0ED50
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x1D0F150 Offset: 0x1D0DB50 VA: 0x181D0F150
	public void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1D0EB10 Offset: 0x1D0D510 VA: 0x181D0EB10
	public bool get_IsReference() { }

	// RVA: 0x1D0EDF0 Offset: 0x1D0D7F0 VA: 0x181D0EDF0
	public void set_IsReference(bool value) { }

	// RVA: 0x1D0EC90 Offset: 0x1D0D690 VA: 0x181D0EC90
	public int get_Order() { }

	// RVA: 0x1D0F030 Offset: 0x1D0DA30 VA: 0x181D0F030
	public void set_Order(int value) { }

	// RVA: 0x1D0ED10 Offset: 0x1D0D710 VA: 0x181D0ED10
	public Required get_Required() { }

	// RVA: 0x1D0F0F0 Offset: 0x1D0DAF0 VA: 0x181D0F0F0
	public void set_Required(Required value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_PropertyName(string value) { }

	// RVA: 0x1D0EB90 Offset: 0x1D0D590 VA: 0x181D0EB90
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	// RVA: 0x1D0EEB0 Offset: 0x1D0D8B0 VA: 0x181D0EEB0
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1D0EBD0 Offset: 0x1D0D5D0 VA: 0x181D0EBD0
	public TypeNameHandling get_ItemTypeNameHandling() { }

	// RVA: 0x1D0EF10 Offset: 0x1D0D910 VA: 0x181D0EF10
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1D0EB50 Offset: 0x1D0D550 VA: 0x181D0EB50
	public bool get_ItemIsReference() { }

	// RVA: 0x1D0EE50 Offset: 0x1D0D850 VA: 0x181D0EE50
	public void set_ItemIsReference(bool value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1D0EA90 Offset: 0x1D0D490 VA: 0x181D0EA90
	public void .ctor(string propertyName) { }
}
