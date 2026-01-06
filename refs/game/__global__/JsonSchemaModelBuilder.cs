internal class JsonSchemaModelBuilder // TypeDefIndex: 11291
{
	// Fields
	private JsonSchemaNodeCollection _nodes; // 0x10
	private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels; // 0x18
	private JsonSchemaNode _node; // 0x20

	// Methods

	// RVA: 0x1DA00A0 Offset: 0x1D9EAA0 VA: 0x181DA00A0
	public JsonSchemaModel Build(JsonSchema schema) { }

	// RVA: 0x1D9F370 Offset: 0x1D9DD70 VA: 0x181D9F370
	public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema) { }

	// RVA: 0x1D9EEA0 Offset: 0x1D9D8A0 VA: 0x181D9EEA0
	public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target) { }

	// RVA: 0x1D9F1F0 Offset: 0x1D9DBF0 VA: 0x181D9F1F0
	public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema) { }

	// RVA: 0x1D9ED50 Offset: 0x1D9D750 VA: 0x181D9ED50
	public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema) { }

	// RVA: 0x1D9ED10 Offset: 0x1D9D710 VA: 0x181D9ED10
	public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema) { }

	// RVA: 0x1D9ECD0 Offset: 0x1D9D6D0 VA: 0x181D9ECD0
	public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema) { }

	// RVA: 0x1D9F9E0 Offset: 0x1D9E3E0 VA: 0x181D9F9E0
	private JsonSchemaModel BuildNodeModel(JsonSchemaNode node) { }

	// RVA: 0x1DA01A0 Offset: 0x1D9EBA0 VA: 0x181DA01A0
	public void .ctor() { }
}
