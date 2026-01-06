public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 11355
{
	// Fields
	private readonly JToken _root; // 0x78
	[Nullable(2)]
	private string _initialPath; // 0x80
	[Nullable(2)]
	private JToken _parent; // 0x88
	[Nullable(2)]
	private JToken _current; // 0x90

	// Properties
	[Nullable(2)]
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public JToken get_CurrentToken() { }

	// RVA: 0x1DDCC50 Offset: 0x1DDB650 VA: 0x181DDCC50
	public void .ctor(JToken token) { }

	// RVA: 0x1DDCCC0 Offset: 0x1DDB6C0 VA: 0x181DDCCC0
	public void .ctor(JToken token, string initialPath) { }

	// RVA: 0x1DDC140 Offset: 0x1DDAB40 VA: 0x181DDC140 Slot: 21
	public override bool Read() { }

	// RVA: 0x1DDB900 Offset: 0x1DDA300 VA: 0x181DDB900
	private bool ReadOver(JToken t) { }

	// RVA: 0x1DDC100 Offset: 0x1DDAB00 VA: 0x181DDC100
	private bool ReadToEnd() { }

	// RVA: 0x1DDB5C0 Offset: 0x1DD9FC0 VA: 0x181DDB5C0
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0x1DDB850 Offset: 0x1DDA250 VA: 0x181DDB850
	private bool ReadInto(JContainer c) { }

	// RVA: 0x1DDC2E0 Offset: 0x1DDACE0 VA: 0x181DDC2E0
	private bool SetEnd(JContainer c) { }

	// RVA: 0x1DDC490 Offset: 0x1DDAE90 VA: 0x181DDC490
	private void SetToken(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x1DDC2B0 Offset: 0x1DDACB0 VA: 0x181DDC2B0
	private string SafeToString(object value) { }

	// RVA: 0x1DDB730 Offset: 0x1DDA130 VA: 0x181DDB730 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1DDB790 Offset: 0x1DDA190 VA: 0x181DDB790 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1DDB7F0 Offset: 0x1DDA1F0 VA: 0x181DDB7F0 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x1DDCD50 Offset: 0x1DDB750 VA: 0x181DDCD50 Slot: 20
	public override string get_Path() { }
}
