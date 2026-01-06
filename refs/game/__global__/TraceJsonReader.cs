internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 11277
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override char QuoteChar { get; set; }
	public override JsonToken TokenType { get; }
	[Nullable(2)]
	public override object Value { get; }
	[Nullable(2)]
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1DAF580 Offset: 0x1DADF80 VA: 0x181DAF580
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x1DAEF40 Offset: 0x1DAD940 VA: 0x181DAEF40
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x1DAF4B0 Offset: 0x1DADEB0 VA: 0x181DAF4B0 Slot: 21
	public override bool Read() { }

	// RVA: 0x1DAF3B0 Offset: 0x1DADDB0 VA: 0x181DAF3B0 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	[NullableContext(2)]
	// RVA: 0x1DAF430 Offset: 0x1DADE30 VA: 0x181DAF430 Slot: 23
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x1DAF110 Offset: 0x1DADB10 VA: 0x181DAF110 Slot: 24
	public override byte[] ReadAsBytes() { }

	// RVA: 0x1DAF2A0 Offset: 0x1DADCA0 VA: 0x181DAF2A0 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1DAF330 Offset: 0x1DADD30 VA: 0x181DAF330 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1DAF090 Offset: 0x1DADA90 VA: 0x181DAF090 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1DAF220 Offset: 0x1DADC20 VA: 0x181DAF220 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1DAF190 Offset: 0x1DADB90 VA: 0x181DAF190 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1DAF530 Offset: 0x1DADF30 VA: 0x181DAF530
	public void WriteCurrentToken() { }

	// RVA: 0x1D45BA0 Offset: 0x1D445A0 VA: 0x181D45BA0 Slot: 19
	public override int get_Depth() { }

	// RVA: 0x1D45BD0 Offset: 0x1D445D0 VA: 0x181D45BD0 Slot: 20
	public override string get_Path() { }

	// RVA: 0x1A45310 Offset: 0x1A43D10 VA: 0x181A45310 Slot: 14
	public override char get_QuoteChar() { }

	// RVA: 0x1DAF6F0 Offset: 0x1DAE0F0 VA: 0x181DAF6F0 Slot: 15
	protected internal override void set_QuoteChar(char value) { }

	// RVA: 0x1D45C00 Offset: 0x1D44600 VA: 0x181D45C00 Slot: 16
	public override JsonToken get_TokenType() { }

	[NullableContext(2)]
	// RVA: 0x1D45C60 Offset: 0x1D44660 VA: 0x181D45C60 Slot: 17
	public override object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x1D45C30 Offset: 0x1D44630 VA: 0x181D45C30 Slot: 18
	public override Type get_ValueType() { }

	// RVA: 0x1DAEF10 Offset: 0x1DAD910 VA: 0x181DAEF10 Slot: 31
	public override void Close() { }

	// RVA: 0x1DAEF70 Offset: 0x1DAD970 VA: 0x181DAEF70 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1DAEFD0 Offset: 0x1DAD9D0 VA: 0x181DAEFD0 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1DAF030 Offset: 0x1DADA30 VA: 0x181DAF030 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
}
