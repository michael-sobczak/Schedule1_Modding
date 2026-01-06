public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 11404
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0x1DE4A20 Offset: 0x1DE3420 VA: 0x181DE4A20
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0x1DE5090 Offset: 0x1DE3A90 VA: 0x181DE5090 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DE4C20 Offset: 0x1DE3620 VA: 0x181DE4C20 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DE4920 Offset: 0x1DE3320 VA: 0x181DE4920 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1DE5320 Offset: 0x1DE3D20 VA: 0x181DE5320
	private static void .cctor() { }
}
