public class DefaultContractResolver : IContractResolver // TypeDefIndex: 11223
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; // 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Properties
	internal static IContractResolver Instance { get; }
	public bool DynamicCodeGeneration { get; }
	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; set; }
	public bool IgnoreSerializableInterface { get; set; }
	public bool IgnoreSerializableAttribute { get; set; }
	public bool IgnoreIsSpecifiedMembers { get; set; }
	public bool IgnoreShouldSerializeMembers { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }

	// Methods

	// RVA: 0x1D7E510 Offset: 0x1D7CF10 VA: 0x181D7E510
	internal static IContractResolver get_Instance() { }

	// RVA: 0x1D7E4B0 Offset: 0x1D7CEB0 VA: 0x181D7E4B0
	public bool get_DynamicCodeGeneration() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_SerializeCompilerGeneratedMembers(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D80 Offset: 0x562780 VA: 0x180563D80
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	// RVA: 0xD63380 Offset: 0xD61D80 VA: 0x180D63380
	public void set_IgnoreSerializableInterface(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D7E500 Offset: 0x1D7CF00 VA: 0x181D7E500
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	// RVA: 0x1D7E570 Offset: 0x1D7CF70 VA: 0x181D7E570
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D7E4F0 Offset: 0x1D7CEF0 VA: 0x181D7E4F0
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	// RVA: 0x1D7E560 Offset: 0x1D7CF60 VA: 0x181D7E560
	public void set_IgnoreIsSpecifiedMembers(bool value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IgnoreShouldSerializeMembers() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_IgnoreShouldSerializeMembers(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0x1D7E3B0 Offset: 0x1D7CDB0 VA: 0x181D7E3B0
	public void .ctor() { }

	// RVA: 0x1D7C250 Offset: 0x1D7AC50 VA: 0x181D7C250 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0x1D78F80 Offset: 0x1D77980 VA: 0x181D78F80
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0x1D7A640 Offset: 0x1D79040 VA: 0x181D7A640 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0x1D7DA40 Offset: 0x1D7C440 VA: 0x181D7DA40
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0x1D77B00 Offset: 0x1D76500 VA: 0x181D77B00 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0x1D7DD20 Offset: 0x1D7C720 VA: 0x181D7DD20
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0x1D7A1A0 Offset: 0x1D78BA0 VA: 0x181D7A1A0
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0x1D7C3C0 Offset: 0x1D7ADC0 VA: 0x181D7C3C0
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0x1D790A0 Offset: 0x1D77AA0 VA: 0x181D790A0
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0x1D7A3A0 Offset: 0x1D78DA0 VA: 0x181D7A3A0
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0x1D7A5F0 Offset: 0x1D78FF0 VA: 0x181D7A5F0
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0x1D76530 Offset: 0x1D74F30 VA: 0x181D76530 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0x1D7BE90 Offset: 0x1D7A890 VA: 0x181D7BE90
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0x1D78740 Offset: 0x1D77140 VA: 0x181D78740 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0x1D7C200 Offset: 0x1D7AC00 VA: 0x181D7C200 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0x1D7A100 Offset: 0x1D78B00 VA: 0x181D7A100
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0x1D7B050 Offset: 0x1D79A50 VA: 0x181D7B050
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0x1D7BF60 Offset: 0x1D7A960 VA: 0x181D7BF60
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0x1D79500 Offset: 0x1D77F00 VA: 0x181D79500
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x1D7B340 Offset: 0x1D79D40 VA: 0x181D7B340
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0x1D7DB60 Offset: 0x1D7C560 VA: 0x181D7DB60
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x1D7DC40 Offset: 0x1D7C640 VA: 0x181D7DC40
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0x1D79E20 Offset: 0x1D78820 VA: 0x181D79E20
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0x1D76DF0 Offset: 0x1D757F0 VA: 0x181D76DF0 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0x1D76180 Offset: 0x1D74B80 VA: 0x181D76180 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0x1D78200 Offset: 0x1D76C00 VA: 0x181D78200 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0x1D77A20 Offset: 0x1D76420 VA: 0x181D77A20 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0x1D777B0 Offset: 0x1D761B0 VA: 0x181D777B0 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0x1D77410 Offset: 0x1D75E10 VA: 0x181D77410 Slot: 16
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0x1D78F10 Offset: 0x1D77910 VA: 0x181D78F10 Slot: 17
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0x1D76700 Offset: 0x1D75100 VA: 0x181D76700 Slot: 18
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0x1D7B610 Offset: 0x1D7A010 VA: 0x181D7B610
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0x1D7B480 Offset: 0x1D79E80 VA: 0x181D7B480
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0x1D76060 Offset: 0x1D74A60 VA: 0x181D76060
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0x1D7B670 Offset: 0x1D7A070 VA: 0x181D7B670
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0x1D79FE0 Offset: 0x1D789E0 VA: 0x181D79FE0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1D78330 Offset: 0x1D76D30 VA: 0x181D78330 Slot: 19
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 20
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x1D77AA0 Offset: 0x1D764A0 VA: 0x181D77AA0 Slot: 21
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0x1D78A40 Offset: 0x1D77440 VA: 0x181D78A40 Slot: 22
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0x1D7D2F0 Offset: 0x1D7BCF0 VA: 0x181D7D2F0
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0x1D78C90 Offset: 0x1D77690 VA: 0x181D78C90
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0x1D7CFA0 Offset: 0x1D7B9A0 VA: 0x181D7CFA0
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x1D7C390 Offset: 0x1D7AD90 VA: 0x181D7C390 Slot: 23
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0x1D7C360 Offset: 0x1D7AD60 VA: 0x181D7C360 Slot: 24
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0x1D7C310 Offset: 0x1D7AD10 VA: 0x181D7C310 Slot: 25
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xB1E190 Offset: 0xB1CB90 VA: 0x180B1E190
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0x1D7DDC0 Offset: 0x1D7C7C0 VA: 0x181D7DDC0
	private static void .cctor() { }
}
