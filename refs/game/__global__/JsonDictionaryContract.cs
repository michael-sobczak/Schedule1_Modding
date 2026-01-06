public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 11246
{
	// Fields
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 1 })]
	private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x110
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> DictionaryKeyResolver { get; set; }
	public Type DictionaryKeyType { get; }
	public Type DictionaryValueType { get; }
	internal JsonContract KeyContract { get; set; }
	internal bool ShouldCreateWrapper { get; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Func<string, string> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_DictionaryKeyResolver(Func<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	internal JsonContract get_KeyContract() { }

	[CompilerGenerated]
	// RVA: 0x4E8E20 Offset: 0x4E7820 VA: 0x1804E8E20
	internal void set_KeyContract(JsonContract value) { }

	[CompilerGenerated]
	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0x1D83AA0 Offset: 0x1D824A0 VA: 0x181D83AA0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x1D83A30 Offset: 0x1D82430 VA: 0x181D83A30
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x1D82DB0 Offset: 0x1D817B0 VA: 0x181D82DB0
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x1D82A50 Offset: 0x1D81450 VA: 0x181D82A50
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[NullableContext(1)]
	// RVA: 0x1D82780 Offset: 0x1D81180 VA: 0x181D82780
	internal IDictionary CreateTemporaryDictionary() { }
}
