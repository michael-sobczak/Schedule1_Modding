internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 11261
{
	// Methods

	// RVA: 0x1D86830 Offset: 0x1D85230 VA: 0x181D86830
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1D90D60 Offset: 0x1D8F760 VA: 0x181D90D60
	public void Populate(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1D8DDD0 Offset: 0x1D8C7D0 VA: 0x181D8DDD0
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x1D8DE80 Offset: 0x1D8C880 VA: 0x181D8DE80
	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	// RVA: 0x1D8CED0 Offset: 0x1D8B8D0 VA: 0x181D8CED0
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x1D8E0C0 Offset: 0x1D8CAC0 VA: 0x181D8E0C0
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1D88C10 Offset: 0x1D87610 VA: 0x181D88C10
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x1D88900 Offset: 0x1D87300 VA: 0x181D88900
	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x1D8C670 Offset: 0x1D8B070 VA: 0x181D8C670
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x1D87570 Offset: 0x1D85F70 VA: 0x181D87570
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x1D8DFC0 Offset: 0x1D8C9C0 VA: 0x181D8DFC0
	internal string GetExpectedDescription(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x1D8DEE0 Offset: 0x1D8C8E0 VA: 0x181D8DEE0
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1D8B8A0 Offset: 0x1D8A2A0 VA: 0x181D8B8A0
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x1D91410 Offset: 0x1D8FE10 VA: 0x181D91410
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x1D91B20 Offset: 0x1D90520 VA: 0x181D91B20
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x1D92B80 Offset: 0x1D91580 VA: 0x181D92B80
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x1D8D6D0 Offset: 0x1D8C0D0 VA: 0x181D8D6D0
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x1D88FD0 Offset: 0x1D879D0 VA: 0x181D88FD0
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[NullableContext(2)]
	// RVA: 0x1D8E1B0 Offset: 0x1D8CBB0 VA: 0x181D8E1B0
	private bool HasNoDefinedType(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x1D8D890 Offset: 0x1D8C290 VA: 0x181D8D890
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x1D93380 Offset: 0x1D91D80 VA: 0x181D93380
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1D86DE0 Offset: 0x1D857E0 VA: 0x181D86DE0
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0x1D86B00 Offset: 0x1D85500 VA: 0x181D86B00
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	// RVA: 0x1D93960 Offset: 0x1D92360 VA: 0x181D93960
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0x1D89B40 Offset: 0x1D88540 VA: 0x181D89B40
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1D89890 Offset: 0x1D88290 VA: 0x181D89890
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1D8E450 Offset: 0x1D8CE50 VA: 0x181D8E450
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x1D8E2A0 Offset: 0x1D8CCA0 VA: 0x181D8E2A0
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x1D8E600 Offset: 0x1D8D000 VA: 0x181D8E600
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1D8F710 Offset: 0x1D8E110 VA: 0x181D8F710
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1D93AD0 Offset: 0x1D924D0 VA: 0x181D93AD0
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x1D8F0D0 Offset: 0x1D8DAD0 VA: 0x181D8F0D0
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1D88150 Offset: 0x1D86B50 VA: 0x181D88150
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x1D87FB0 Offset: 0x1D869B0 VA: 0x181D87FB0
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x1D876A0 Offset: 0x1D860A0 VA: 0x181D876A0
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0x1D8A1B0 Offset: 0x1D88BB0 VA: 0x181D8A1B0
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x1D8CBA0 Offset: 0x1D8B5A0 VA: 0x181D8CBA0
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x1D921C0 Offset: 0x1D90BC0 VA: 0x181D921C0
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x1D89EB0 Offset: 0x1D888B0 VA: 0x181D89EB0
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1D8FFB0 Offset: 0x1D8E9B0 VA: 0x181D8FFB0
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x1D93780 Offset: 0x1D92180 VA: 0x181D93780
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x1D87460 Offset: 0x1D85E60 VA: 0x181D87460
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x1D93130 Offset: 0x1D91B30 VA: 0x181D93130
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x1D91350 Offset: 0x1D8FD50 VA: 0x181D91350
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x1D8D230 Offset: 0x1D8BC30 VA: 0x181D8D230
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x1D93260 Offset: 0x1D91C60 VA: 0x181D93260
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x1D8E130 Offset: 0x1D8CB30 VA: 0x181D8E130
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }
}
