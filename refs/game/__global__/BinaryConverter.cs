public class BinaryConverter : JsonConverter // TypeDefIndex: 11389
{
	// Fields
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x1DD1790 Offset: 0x1DD0190 VA: 0x181DD1790 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD0E80 Offset: 0x1DCF880 VA: 0x181DD0E80
	private byte[] GetByteArray(object value) { }

	// RVA: 0x1DD0CC0 Offset: 0x1DCF6C0 VA: 0x181DD0CC0
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0x1DD1300 Offset: 0x1DCFD00 VA: 0x181DD1300 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD10A0 Offset: 0x1DCFAA0 VA: 0x181DD10A0
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0x1DD0BA0 Offset: 0x1DCF5A0 VA: 0x181DD0BA0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
