public class RegexConverter : JsonConverter // TypeDefIndex: 11405
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0x1DE6480 Offset: 0x1DE4E80 VA: 0x181DE6480 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0x1DE6170 Offset: 0x1DE4B70 VA: 0x181DE6170
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0x1DE62A0 Offset: 0x1DE4CA0 VA: 0x181DE62A0
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0x1DE5B20 Offset: 0x1DE4520 VA: 0x181DE5B20 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DE6000 Offset: 0x1DE4A00 VA: 0x181DE6000
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0x1DE5D20 Offset: 0x1DE4720 VA: 0x181DE5D20
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0x1DE5A10 Offset: 0x1DE4410 VA: 0x181DE5A10 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x1DE5AA0 Offset: 0x1DE44A0 VA: 0x181DE5AA0
	private bool IsRegex(Type objectType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
