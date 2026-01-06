internal struct JsonParser // TypeDefIndex: 7818
{
	// Fields
	private readonly string m_Text; // 0x0
	private readonly int m_Length; // 0x8
	private int m_Position; // 0xC
	private bool m_MatchAnyElementInArray; // 0x10
	private bool m_DryRun; // 0x11

	// Properties
	public bool isAtEnd { get; }

	// Methods

	// RVA: 0x2786B80 Offset: 0x2785580 VA: 0x182786B80
	public void .ctor(string json) { }

	// RVA: 0x27868A0 Offset: 0x27852A0 VA: 0x1827868A0
	public void Reset() { }

	// RVA: 0x2786AB0 Offset: 0x27854B0 VA: 0x182786AB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2785540 Offset: 0x2783F40 VA: 0x182785540
	public bool NavigateToProperty(string path) { }

	// RVA: 0x2785360 Offset: 0x2783D60 VA: 0x182785360
	public bool CurrentPropertyHasValueEqualTo(JsonParser.JsonValue expectedValue) { }

	// RVA: 0x2786680 Offset: 0x2785080 VA: 0x182786680
	public bool ParseToken(char token) { }

	// RVA: 0x2786860 Offset: 0x2785260 VA: 0x182786860
	public bool ParseValue() { }

	// RVA: 0x2786760 Offset: 0x2785160 VA: 0x182786760
	public bool ParseValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2786490 Offset: 0x2784E90 VA: 0x182786490
	public bool ParseStringValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2785970 Offset: 0x2784370 VA: 0x182785970
	public bool ParseArrayValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2786270 Offset: 0x2784C70 VA: 0x182786270
	public bool ParseObjectValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2785D90 Offset: 0x2784790 VA: 0x182785D90
	public bool ParseNumber(out JsonParser.JsonValue result) { }

	// RVA: 0x2785C30 Offset: 0x2784630 VA: 0x182785C30
	public bool ParseBooleanValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2785D30 Offset: 0x2784730 VA: 0x182785D30
	public bool ParseNullValue(out JsonParser.JsonValue result) { }

	// RVA: 0x2786950 Offset: 0x2785350 VA: 0x182786950
	public bool SkipToValue() { }

	// RVA: 0x27868B0 Offset: 0x27852B0 VA: 0x1827868B0
	private bool SkipString(string text) { }

	// RVA: 0x2786A20 Offset: 0x2785420 VA: 0x182786A20
	private void SkipWhitespace() { }

	// RVA: 0x2786C10 Offset: 0x2785610 VA: 0x182786C10
	public bool get_isAtEnd() { }
}
