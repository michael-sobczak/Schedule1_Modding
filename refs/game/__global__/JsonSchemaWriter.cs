internal class JsonSchemaWriter // TypeDefIndex: 11299
{
	// Fields
	private readonly JsonWriter _writer; // 0x10
	private readonly JsonSchemaResolver _resolver; // 0x18

	// Methods

	// RVA: 0x1DA2E00 Offset: 0x1DA1800 VA: 0x181DA2E00
	public void .ctor(JsonWriter writer, JsonSchemaResolver resolver) { }

	// RVA: 0x1DA1190 Offset: 0x1D9FB90 VA: 0x181DA1190
	private void ReferenceOrWriteSchema(JsonSchema schema) { }

	// RVA: 0x1DA1840 Offset: 0x1DA0240 VA: 0x181DA1840
	public void WriteSchema(JsonSchema schema) { }

	// RVA: 0x1DA15C0 Offset: 0x1D9FFC0 VA: 0x181DA15C0
	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties) { }

	// RVA: 0x1DA12B0 Offset: 0x1D9FCB0 VA: 0x181DA12B0
	private void WriteItems(JsonSchema schema) { }

	// RVA: 0x1DA2980 Offset: 0x1DA1380 VA: 0x181DA2980
	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type) { }

	// RVA: 0x1DA1560 Offset: 0x1D9FF60 VA: 0x181DA1560
	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value) { }
}
