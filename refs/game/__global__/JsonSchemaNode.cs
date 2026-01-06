internal class JsonSchemaNode // TypeDefIndex: 11293
{
	// Fields
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> <Schemas>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> <Properties>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> <PatternProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly List<JsonSchemaNode> <Items>k__BackingField; // 0x30
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalProperties>k__BackingField; // 0x38
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalItems>k__BackingField; // 0x40

	// Properties
	public string Id { get; }
	public ReadOnlyCollection<JsonSchema> Schemas { get; }
	public Dictionary<string, JsonSchemaNode> Properties { get; }
	public Dictionary<string, JsonSchemaNode> PatternProperties { get; }
	public List<JsonSchemaNode> Items { get; }
	public JsonSchemaNode AdditionalProperties { get; set; }
	public JsonSchemaNode AdditionalItems { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ReadOnlyCollection<JsonSchema> get_Schemas() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Dictionary<string, JsonSchemaNode> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Dictionary<string, JsonSchemaNode> get_PatternProperties() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<JsonSchemaNode> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public JsonSchemaNode get_AdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_AdditionalProperties(JsonSchemaNode value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public JsonSchemaNode get_AdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_AdditionalItems(JsonSchemaNode value) { }

	// RVA: 0x1DA0B90 Offset: 0x1D9F590 VA: 0x181DA0B90
	public void .ctor(JsonSchema schema) { }

	// RVA: 0x1DA0D70 Offset: 0x1D9F770 VA: 0x181DA0D70
	private void .ctor(JsonSchemaNode source, JsonSchema schema) { }

	// RVA: 0x1DA08A0 Offset: 0x1D9F2A0 VA: 0x181DA08A0
	public JsonSchemaNode Combine(JsonSchema schema) { }

	// RVA: 0x1DA0910 Offset: 0x1D9F310 VA: 0x181DA0910
	public static string GetId(IEnumerable<JsonSchema> schemata) { }
}
