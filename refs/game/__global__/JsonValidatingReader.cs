public class JsonValidatingReader : JsonReader, IJsonLineInfo // TypeDefIndex: 11080
{
	// Fields
	private readonly JsonReader _reader; // 0x78
	private readonly Stack<JsonValidatingReader.SchemaScope> _stack; // 0x80
	private JsonSchema _schema; // 0x88
	private JsonSchemaModel _model; // 0x90
	private JsonValidatingReader.SchemaScope _currentScope; // 0x98
	[CompilerGenerated]
	private ValidationEventHandler ValidationEventHandler; // 0xA0
	private static readonly IList<JsonSchemaModel> EmptySchemaList; // 0x0

	// Properties
	public override object Value { get; }
	public override int Depth { get; }
	public override string Path { get; }
	public override char QuoteChar { get; set; }
	public override JsonToken TokenType { get; }
	public override Type ValueType { get; }
	private IList<JsonSchemaModel> CurrentSchemas { get; }
	private IList<JsonSchemaModel> CurrentMemberSchemas { get; }
	public JsonSchema Schema { get; set; }
	public JsonReader Reader { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D45100 Offset: 0x1D43B00 VA: 0x181D45100
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1D45C90 Offset: 0x1D44690 VA: 0x181D45C90
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1D45C60 Offset: 0x1D44660 VA: 0x181D45C60 Slot: 17
	public override object get_Value() { }

	// RVA: 0x1D45BA0 Offset: 0x1D445A0 VA: 0x181D45BA0 Slot: 19
	public override int get_Depth() { }

	// RVA: 0x1D45BD0 Offset: 0x1D445D0 VA: 0x181D45BD0 Slot: 20
	public override string get_Path() { }

	// RVA: 0x1A45310 Offset: 0x1A43D10 VA: 0x181A45310 Slot: 14
	public override char get_QuoteChar() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	protected internal override void set_QuoteChar(char value) { }

	// RVA: 0x1D45C00 Offset: 0x1D44600 VA: 0x181D45C00 Slot: 16
	public override JsonToken get_TokenType() { }

	// RVA: 0x1D45C30 Offset: 0x1D44630 VA: 0x181D45C30 Slot: 18
	public override Type get_ValueType() { }

	// RVA: 0x1D41790 Offset: 0x1D40190 VA: 0x181D41790
	private void Push(JsonValidatingReader.SchemaScope scope) { }

	// RVA: 0x1D413F0 Offset: 0x1D3FDF0 VA: 0x181D413F0
	private JsonValidatingReader.SchemaScope Pop() { }

	// RVA: 0x1D45B80 Offset: 0x1D44580 VA: 0x181D45B80
	private IList<JsonSchemaModel> get_CurrentSchemas() { }

	// RVA: 0x1D451B0 Offset: 0x1D43BB0 VA: 0x181D451B0
	private IList<JsonSchemaModel> get_CurrentMemberSchemas() { }

	// RVA: 0x1D41800 Offset: 0x1D40200 VA: 0x181D41800
	private void RaiseError(string message, JsonSchemaModel schema) { }

	// RVA: 0x1D41350 Offset: 0x1D3FD50 VA: 0x181D41350
	private void OnValidationEvent(JsonSchemaException exception) { }

	// RVA: 0x1D45050 Offset: 0x1D43A50 VA: 0x181D45050
	public void .ctor(JsonReader reader) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public JsonSchema get_Schema() { }

	// RVA: 0x1D45D40 Offset: 0x1D44740 VA: 0x181D45D40
	public void set_Schema(JsonSchema value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public JsonReader get_Reader() { }

	// RVA: 0x1D40CF0 Offset: 0x1D3F6F0 VA: 0x181D40CF0 Slot: 31
	public override void Close() { }

	// RVA: 0x1D43E50 Offset: 0x1D42850 VA: 0x181D43E50
	private void ValidateNotDisallowed(JsonSchemaModel schema) { }

	// RVA: 0x1D40DA0 Offset: 0x1D3F7A0 VA: 0x181D40DA0
	private Nullable<JsonSchemaType> GetCurrentNodeSchemaType() { }

	// RVA: 0x1D41C70 Offset: 0x1D40670 VA: 0x181D41C70 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x1D41AA0 Offset: 0x1D404A0 VA: 0x181D41AA0 Slot: 24
	public override byte[] ReadAsBytes() { }

	// RVA: 0x1D41BB0 Offset: 0x1D405B0 VA: 0x181D41BB0 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1D41C10 Offset: 0x1D40610 VA: 0x181D41C10 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1D41A50 Offset: 0x1D40450 VA: 0x181D41A50 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1D41CC0 Offset: 0x1D406C0 VA: 0x181D41CC0 Slot: 23
	public override string ReadAsString() { }

	// RVA: 0x1D41B50 Offset: 0x1D40550 VA: 0x181D41B50 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1D41AF0 Offset: 0x1D404F0 VA: 0x181D41AF0 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1D41D10 Offset: 0x1D40710 VA: 0x181D41D10 Slot: 21
	public override bool Read() { }

	// RVA: 0x1D41F20 Offset: 0x1D40920 VA: 0x181D41F20
	private void ValidateCurrentToken() { }

	// RVA: 0x1D44710 Offset: 0x1D43110 VA: 0x181D44710
	private void WriteToken(IList<JsonSchemaModel> schemas) { }

	// RVA: 0x1D42E30 Offset: 0x1D41830 VA: 0x181D42E30
	private void ValidateEndObject(JsonSchemaModel schema) { }

	// RVA: 0x1D42C30 Offset: 0x1D41630 VA: 0x181D42C30
	private void ValidateEndArray(JsonSchemaModel schema) { }

	// RVA: 0x1D44110 Offset: 0x1D42B10 VA: 0x181D44110
	private void ValidateNull(JsonSchemaModel schema) { }

	// RVA: 0x1D41EE0 Offset: 0x1D408E0 VA: 0x181D41EE0
	private void ValidateBoolean(JsonSchemaModel schema) { }

	// RVA: 0x1D44340 Offset: 0x1D42D40 VA: 0x181D44340
	private void ValidateString(JsonSchemaModel schema) { }

	// RVA: 0x1D43770 Offset: 0x1D42170 VA: 0x181D43770
	private void ValidateInteger(JsonSchemaModel schema) { }

	// RVA: 0x1D414A0 Offset: 0x1D3FEA0 VA: 0x181D414A0
	private void ProcessValue() { }

	// RVA: 0x1D431E0 Offset: 0x1D41BE0 VA: 0x181D431E0
	private void ValidateFloat(JsonSchemaModel schema) { }

	// RVA: 0x1D40D30 Offset: 0x1D3F730 VA: 0x181D40D30
	private static double FloatingPointRemainder(double dividend, double divisor) { }

	// RVA: 0x1D411D0 Offset: 0x1D3FBD0 VA: 0x181D411D0
	private static bool IsZero(double value) { }

	// RVA: 0x1D44170 Offset: 0x1D42B70 VA: 0x181D44170
	private void ValidatePropertyName(JsonSchemaModel schema) { }

	// RVA: 0x1D40F70 Offset: 0x1D3F970 VA: 0x181D40F70
	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName) { }

	// RVA: 0x1D41EC0 Offset: 0x1D408C0 VA: 0x181D41EC0
	private bool ValidateArray(JsonSchemaModel schema) { }

	// RVA: 0x1D44150 Offset: 0x1D42B50 VA: 0x181D44150
	private bool ValidateObject(JsonSchemaModel schema) { }

	// RVA: 0x1D41D80 Offset: 0x1D40780 VA: 0x181D41D80
	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType) { }

	// RVA: 0x1D41230 Offset: 0x1D3FC30 VA: 0x181D41230 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1D41290 Offset: 0x1D3FC90 VA: 0x181D41290 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1D412F0 Offset: 0x1D3FCF0 VA: 0x181D412F0 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x1D44FC0 Offset: 0x1D439C0 VA: 0x181D44FC0
	private static void .cctor() { }
}
