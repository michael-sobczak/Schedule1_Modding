internal class JsonSchemaBuilder // TypeDefIndex: 11284
{
	// Fields
	private readonly IList<JsonSchema> _stack; // 0x10
	private readonly JsonSchemaResolver _resolver; // 0x18
	private readonly IDictionary<string, JsonSchema> _documentSchemas; // 0x20
	private JsonSchema _currentSchema; // 0x28
	private JObject _rootSchema; // 0x30

	// Properties
	private JsonSchema CurrentSchema { get; }

	// Methods

	// RVA: 0x1D9C7D0 Offset: 0x1D9B1D0 VA: 0x181D9C7D0
	public void .ctor(JsonSchemaResolver resolver) { }

	// RVA: 0x1D9BAA0 Offset: 0x1D9A4A0 VA: 0x181D9BAA0
	private void Push(JsonSchema value) { }

	// RVA: 0x1D99430 Offset: 0x1D97E30 VA: 0x181D99430
	private JsonSchema Pop() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	private JsonSchema get_CurrentSchema() { }

	// RVA: 0x1D9BB70 Offset: 0x1D9A570 VA: 0x181D9BB70
	internal JsonSchema Read(JsonReader reader) { }

	// RVA: 0x1D9C720 Offset: 0x1D9B120 VA: 0x181D9C720
	private string UnescapeReference(string reference) { }

	// RVA: 0x1D9BC90 Offset: 0x1D9A690 VA: 0x181D9BC90
	private JsonSchema ResolveReferences(JsonSchema schema) { }

	// RVA: 0x1D98CA0 Offset: 0x1D976A0 VA: 0x181D98CA0
	private JsonSchema BuildSchema(JToken token) { }

	// RVA: 0x1D9A5D0 Offset: 0x1D98FD0 VA: 0x181D9A5D0
	private void ProcessSchemaProperties(JObject schemaObject) { }

	// RVA: 0x1D99A60 Offset: 0x1D98460 VA: 0x181D99A60
	private void ProcessExtends(JToken token) { }

	// RVA: 0x1D996B0 Offset: 0x1D980B0 VA: 0x181D996B0
	private void ProcessEnum(JToken token) { }

	// RVA: 0x1D995D0 Offset: 0x1D97FD0 VA: 0x181D995D0
	private void ProcessAdditionalProperties(JToken token) { }

	// RVA: 0x1D994F0 Offset: 0x1D97EF0 VA: 0x181D994F0
	private void ProcessAdditionalItems(JToken token) { }

	// RVA: 0x1D9A1A0 Offset: 0x1D98BA0 VA: 0x181D9A1A0
	private IDictionary<string, JsonSchema> ProcessProperties(JToken token) { }

	// RVA: 0x1D99DA0 Offset: 0x1D987A0 VA: 0x181D99DA0
	private void ProcessItems(JToken token) { }

	// RVA: 0x1D9B680 Offset: 0x1D9A080 VA: 0x181D9B680
	private Nullable<JsonSchemaType> ProcessType(JToken token) { }

	// RVA: 0x1D992B0 Offset: 0x1D97CB0 VA: 0x181D992B0
	internal static JsonSchemaType MapType(string type) { }

	// RVA: 0x1D991A0 Offset: 0x1D97BA0 VA: 0x181D991A0
	internal static string MapType(JsonSchemaType type) { }
}
