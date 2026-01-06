internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 11262
{
	// Fields
	[Nullable(2)]
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x1DABBE0 Offset: 0x1DAA5E0 VA: 0x181DABBE0
	public void .ctor(JsonSerializer serializer) { }

	[NullableContext(2)]
	// RVA: 0x1DA9FE0 Offset: 0x1DA89E0 VA: 0x181DA9FE0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1DA4620 Offset: 0x1DA3020 VA: 0x181DA4620
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1DA4520 Offset: 0x1DA2F20 VA: 0x181DA4520
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x1DA45A0 Offset: 0x1DA2FA0 VA: 0x181DA45A0
	private JsonContract GetContract(object value) { }

	// RVA: 0x1DA94D0 Offset: 0x1DA7ED0 VA: 0x181DA94D0
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1DA9890 Offset: 0x1DA8290 VA: 0x181DA9890
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1DA5400 Offset: 0x1DA3E00 VA: 0x181DA5400
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1DAA640 Offset: 0x1DA9040 VA: 0x181DAA640
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1DAA570 Offset: 0x1DA8F70 VA: 0x181DAA570
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	// RVA: 0x1DA4110 Offset: 0x1DA2B10 VA: 0x181DA4110
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1DAB2D0 Offset: 0x1DA9CD0 VA: 0x181DAB2D0
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x1DA4C50 Offset: 0x1DA3650 VA: 0x181DA4C50
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x1DAAA50 Offset: 0x1DA9450 VA: 0x181DAAA50
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x1DA97E0 Offset: 0x1DA81E0 VA: 0x181DA97E0
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x1DA5280 Offset: 0x1DA3C80 VA: 0x181DA5280
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x1DA5100 Offset: 0x1DA3B00 VA: 0x181DA5100
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x1DA8930 Offset: 0x1DA7330 VA: 0x181DA8930
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA3870 Offset: 0x1DA2270 VA: 0x181DA3870
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x1DAAD30 Offset: 0x1DA9730 VA: 0x181DAAD30
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA4E80 Offset: 0x1DA3880 VA: 0x181DA4E80
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0x1DAB110 Offset: 0x1DA9B10 VA: 0x181DAB110
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x1DAB9F0 Offset: 0x1DAA3F0 VA: 0x181DAB9F0
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x1DA5490 Offset: 0x1DA3E90 VA: 0x181DA5490
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA7D00 Offset: 0x1DA6700 VA: 0x181DA7D00
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA86E0 Offset: 0x1DA70E0 VA: 0x181DA86E0
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA82C0 Offset: 0x1DA6CC0 VA: 0x181DA82C0
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1DAB4D0 Offset: 0x1DA9ED0 VA: 0x181DAB4D0
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA73B0 Offset: 0x1DA5DB0 VA: 0x181DA73B0
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA63C0 Offset: 0x1DA4DC0 VA: 0x181DA63C0
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1DAA4C0 Offset: 0x1DA8EC0 VA: 0x181DAA4C0
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	// RVA: 0x1DAA830 Offset: 0x1DA9230 VA: 0x181DAA830
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA58C0 Offset: 0x1DA42C0 VA: 0x181DA58C0
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1DA46F0 Offset: 0x1DA30F0 VA: 0x181DA46F0
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x1DA4E00 Offset: 0x1DA3800 VA: 0x181DA4E00
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1DAA2F0 Offset: 0x1DA8CF0 VA: 0x181DAA2F0
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x1DA4F30 Offset: 0x1DA3930 VA: 0x181DA4F30
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }
}
