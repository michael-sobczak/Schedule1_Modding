public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 11401
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD6E20 Offset: 0x1DD5820 VA: 0x181DD6E20 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD7130 Offset: 0x1DD5B30 VA: 0x181DD7130
	private object ReadValue(JsonReader reader) { }

	// RVA: 0x1DD6E30 Offset: 0x1DD5830 VA: 0x181DD6E30
	private object ReadList(JsonReader reader) { }

	// RVA: 0x1DD6F60 Offset: 0x1DD5960 VA: 0x181DD6F60
	private object ReadObject(JsonReader reader) { }

	// RVA: 0x1DD6DA0 Offset: 0x1DD57A0 VA: 0x181DD6DA0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
