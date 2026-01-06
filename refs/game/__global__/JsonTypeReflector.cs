internal static class JsonTypeReflector // TypeDefIndex: 11267
{
	// Fields
	private static Nullable<bool> _dynamicCodeGeneration; // 0x0
	private static Nullable<bool> _fullyTrusted; // 0x2
	public const string IdPropertyName = "$id";
	public const string RefPropertyName = "$ref";
	public const string TypePropertyName = "$type";
	public const string ValuePropertyName = "$value";
	public const string ArrayValuesPropertyName = "$values";
	public const string ShouldSerializePrefix = "ShouldSerialize";
	public const string SpecifiedPostfix = "Specified";
	public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";
	[Nullable(new[] { 1, 1, 1, 2, 1, 1 })]
	private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache; // 0x8
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool DynamicCodeGeneration { get; }
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7AE0 Offset: 0xEE64E0 VA: 0x180EE7AE0
	|-JsonTypeReflector.GetCachedAttribute<object>
	*/

	// RVA: 0x1DACA80 Offset: 0x1DAB480 VA: 0x181DACA80
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0x1DAD490 Offset: 0x1DABE90 VA: 0x181DAD490
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x1DAD540 Offset: 0x1DABF40 VA: 0x181DAD540
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x1DAD8F0 Offset: 0x1DAC2F0 VA: 0x181DAD8F0
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x1DAD7D0 Offset: 0x1DAC1D0 VA: 0x181DAD7D0
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x1DACC90 Offset: 0x1DAB690 VA: 0x181DACC90
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0x1DACD80 Offset: 0x1DAB780 VA: 0x181DACD80
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0x1DAD180 Offset: 0x1DABB80 VA: 0x181DAD180
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0x1DAD320 Offset: 0x1DABD20 VA: 0x181DAD320
	private static Func<object[], object> GetCreator(Type type) { }

	// RVA: 0x1DAD100 Offset: 0x1DABB00 VA: 0x181DAD100
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x1DACE70 Offset: 0x1DAB870 VA: 0x181DACE70
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7940 Offset: 0xEE6340 VA: 0x180EE7940
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7570 Offset: 0xEE5F70 VA: 0x180EE7570
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x1DADAD0 Offset: 0x1DAC4D0 VA: 0x181DADAD0
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0x1DADB40 Offset: 0x1DAC540 VA: 0x181DADB40
	public static bool IsSerializable(object provider) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7800 Offset: 0xEE6200 VA: 0x180EE7800
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x1DADD20 Offset: 0x1DAC720 VA: 0x181DADD20
	public static bool get_DynamicCodeGeneration() { }

	// RVA: 0x1DADE10 Offset: 0x1DAC810 VA: 0x181DADE10
	public static bool get_FullyTrusted() { }

	// RVA: 0x1DADF30 Offset: 0x1DAC930 VA: 0x181DADF30
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x1DADBB0 Offset: 0x1DAC5B0 VA: 0x181DADBB0
	private static void .cctor() { }
}
