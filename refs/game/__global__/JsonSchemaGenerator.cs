public class JsonSchemaGenerator // TypeDefIndex: 11289
{
	// Fields
	[CompilerGenerated]
	private UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField; // 0x10
	private IContractResolver _contractResolver; // 0x18
	private JsonSchemaResolver _resolver; // 0x20
	private readonly IList<JsonSchemaGenerator.TypeSchema> _stack; // 0x28
	private JsonSchema _currentSchema; // 0x30

	// Properties
	public UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get; set; }
	public IContractResolver ContractResolver { get; set; }
	private JsonSchema CurrentSchema { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_UndefinedSchemaIdHandling(UndefinedSchemaIdHandling value) { }

	// RVA: 0x1D9EC30 Offset: 0x1D9D630 VA: 0x181D9EC30
	public IContractResolver get_ContractResolver() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	private JsonSchema get_CurrentSchema() { }

	// RVA: 0x1D9EA90 Offset: 0x1D9D490 VA: 0x181D9EA90
	private void Push(JsonSchemaGenerator.TypeSchema typeSchema) { }

	// RVA: 0x1D9E920 Offset: 0x1D9D320 VA: 0x181D9E920
	private JsonSchemaGenerator.TypeSchema Pop() { }

	// RVA: 0x1D9E320 Offset: 0x1D9CD20 VA: 0x181D9E320
	public JsonSchema Generate(Type type) { }

	// RVA: 0x1D9E300 Offset: 0x1D9CD00 VA: 0x181D9E300
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver) { }

	// RVA: 0x1D9E1B0 Offset: 0x1D9CBB0 VA: 0x181D9E1B0
	public JsonSchema Generate(Type type, bool rootSchemaNullable) { }

	// RVA: 0x1D9E240 Offset: 0x1D9CC40 VA: 0x181D9E240
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { }

	// RVA: 0x1D9E6A0 Offset: 0x1D9D0A0 VA: 0x181D9E6A0
	private string GetTitle(Type type) { }

	// RVA: 0x1D9E3A0 Offset: 0x1D9CDA0 VA: 0x181D9E3A0
	private string GetDescription(Type type) { }

	// RVA: 0x1D9E730 Offset: 0x1D9D130 VA: 0x181D9E730
	private string GetTypeId(Type type, bool explicitOnly) { }

	// RVA: 0x1D9CB20 Offset: 0x1D9B520 VA: 0x181D9CB20
	private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required) { }

	// RVA: 0x1D9CAF0 Offset: 0x1D9B4F0 VA: 0x181D9CAF0
	private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x1D9DDF0 Offset: 0x1D9C7F0 VA: 0x181D9DDF0
	private void GenerateObjectSchema(Type type, JsonObjectContract contract) { }

	// RVA: 0x1D9CB00 Offset: 0x1D9B500 VA: 0x181D9CB00
	private void GenerateISerializableContract(Type type, JsonISerializableContract contract) { }

	// RVA: 0x1D9E830 Offset: 0x1D9D230 VA: 0x181D9E830
	internal static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag) { }

	// RVA: 0x1D9E4A0 Offset: 0x1D9CEA0 VA: 0x181D9E4A0
	private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired) { }

	// RVA: 0x1D9EBB0 Offset: 0x1D9D5B0 VA: 0x181D9EBB0
	public void .ctor() { }
}
