public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 11236
{
	// Fields
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; // 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; }
	public bool IsMultidimensionalArray { get; }
	internal bool IsArray { get; }
	internal bool ShouldCreateWrapper { get; }
	internal bool CanDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	// RVA: 0x1A3AE20 Offset: 0x1A39820 VA: 0x181A3AE20
	public bool get_IsMultidimensionalArray() { }

	[CompilerGenerated]
	// RVA: 0x8D1FE0 Offset: 0x8D09E0 VA: 0x1808D1FE0
	internal bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x1D817D0 Offset: 0x1D801D0 VA: 0x181D817D0
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	// RVA: 0x1D81670 Offset: 0x1D80070 VA: 0x181D81670
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x1D817E0 Offset: 0x1D801E0 VA: 0x181D817E0
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x1D816F0 Offset: 0x1D800F0 VA: 0x181D816F0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x1D817F0 Offset: 0x1D801F0 VA: 0x181D817F0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x9876E0 Offset: 0x9860E0 VA: 0x1809876E0
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x1D81680 Offset: 0x1D80080 VA: 0x181D81680
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x1D80200 Offset: 0x1D7EC00 VA: 0x181D80200
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x1D7FBC0 Offset: 0x1D7E5C0 VA: 0x181D7FBC0
	internal IWrappedCollection CreateWrapper(object list) { }

	[NullableContext(1)]
	// RVA: 0x1D7F940 Offset: 0x1D7E340 VA: 0x181D7F940
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	// RVA: 0x1D80060 Offset: 0x1D7EA60 VA: 0x181D80060
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }
}
