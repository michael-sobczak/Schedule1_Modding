public class DataTableConverter : JsonConverter // TypeDefIndex: 11393
{
	// Methods

	// RVA: 0x1DD41D0 Offset: 0x1DD2BD0 VA: 0x181DD41D0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD3EB0 Offset: 0x1DD28B0 VA: 0x181DD3EB0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD37E0 Offset: 0x1DD21E0 VA: 0x181DD37E0
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0x1DD3CA0 Offset: 0x1DD26A0 VA: 0x181DD3CA0
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0x1DD3750 Offset: 0x1DD2150 VA: 0x181DD3750 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
