public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 11400
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x1DD6A20 Offset: 0x1DD5420 VA: 0x181DD6A20 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD6670 Offset: 0x1DD5070 VA: 0x181DD6670
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0x1DD6790 Offset: 0x1DD5190 VA: 0x181DD6790 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD6570 Offset: 0x1DD4F70 VA: 0x181DD6570
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0x1DD6530 Offset: 0x1DD4F30 VA: 0x181DD6530 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
