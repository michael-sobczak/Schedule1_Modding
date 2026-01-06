public class JsonProperty // TypeDefIndex: 11253
{
	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; // 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB0
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xB8
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { get; set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
	public JsonConverter MemberConverter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; set; }
	public bool IsRequiredSpecified { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldSerialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> GetIsSpecified { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal JsonContract get_PropertyContract() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_PropertyName() { }

	// RVA: 0x1D86010 Offset: 0x1D84A10 VA: 0x181D86010
	public void set_PropertyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Nullable<int> get_Order() { }

	[CompilerGenerated]
	// RVA: 0xCC6430 Offset: 0xCC4E30 VA: 0x180CC6430
	public void set_Order(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public IAttributeProvider get_AttributeProvider() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Type get_PropertyType() { }

	// RVA: 0x1D860A0 Offset: 0x1D84AA0 VA: 0x181D860A0
	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_Converter(JsonConverter value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public JsonConverter get_MemberConverter() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_Ignored() { }

	[CompilerGenerated]
	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D85F50 Offset: 0x1D84950 VA: 0x181D85F50
	public bool get_Readable() { }

	[CompilerGenerated]
	// RVA: 0x1D86120 Offset: 0x1D84B20 VA: 0x181D86120
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D32B60 Offset: 0x1D31560 VA: 0x181D32B60
	public bool get_Writable() { }

	[CompilerGenerated]
	// RVA: 0x1D32D10 Offset: 0x1D31710 VA: 0x181D32D10
	public void set_Writable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D85EC0 Offset: 0x1D848C0 VA: 0x181D85EC0
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	// RVA: 0x1D85FC0 Offset: 0x1D849C0 VA: 0x181D85FC0
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x1D85EB0 Offset: 0x1D848B0 VA: 0x181D85EB0
	public object get_DefaultValue() { }

	// RVA: 0x1D85FA0 Offset: 0x1D849A0 VA: 0x181D85FA0
	public void set_DefaultValue(object value) { }

	// RVA: 0x1D85D40 Offset: 0x1D84740 VA: 0x181D85D40
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x1D85F60 Offset: 0x1D84960 VA: 0x181D85F60
	public Required get_Required() { }

	// RVA: 0x1D86130 Offset: 0x1D84B30 VA: 0x181D86130
	public void set_Required(Required value) { }

	// RVA: 0x1D85EE0 Offset: 0x1D848E0 VA: 0x181D85EE0
	public bool get_IsRequiredSpecified() { }

	[CompilerGenerated]
	// RVA: 0x1D85ED0 Offset: 0x1D848D0 VA: 0x181D85ED0
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x1D85FD0 Offset: 0x1D849D0 VA: 0x181D85FD0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x143F240 Offset: 0x143DC40 VA: 0x18143F240
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	// RVA: 0xAA7270 Offset: 0xAA5C70 VA: 0x180AA7270
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0xCD54F0 Offset: 0xCD3EF0 VA: 0x180CD54F0
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	// RVA: 0xAA7280 Offset: 0xAA5C80 VA: 0x180AA7280
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0xAA7260 Offset: 0xAA5C60 VA: 0x180AA7260
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	public void set_ShouldDeserialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_SetIsSpecified(Action<object, object> value) { }

	[NullableContext(1)]
	// RVA: 0x1D85E00 Offset: 0x1D84800 VA: 0x181D85E00 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x1D85F20 Offset: 0x1D84920 VA: 0x181D85F20
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x1D85FE0 Offset: 0x1D849E0 VA: 0x181D85FE0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1D85F40 Offset: 0x1D84940 VA: 0x181D85F40
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x1D86000 Offset: 0x1D84A00 VA: 0x181D86000
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x1D85F30 Offset: 0x1D84930 VA: 0x181D85F30
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x1D85FF0 Offset: 0x1D849F0 VA: 0x181D85FF0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x1D85E50 Offset: 0x1D84850 VA: 0x181D85E50
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
