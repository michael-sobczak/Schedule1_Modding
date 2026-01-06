public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 11399
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0x1DD4B10 Offset: 0x1DD3510 VA: 0x181DD4B10
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0x1DD4D60 Offset: 0x1DD3760 VA: 0x181DD4D60
	private static DiscriminatedUnionConverter.Union CreateUnion(Type t) { }

	// RVA: 0x1DD5E70 Offset: 0x1DD4870 VA: 0x181DD5E70 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DD56B0 Offset: 0x1DD40B0 VA: 0x181DD56B0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DD4880 Offset: 0x1DD3280 VA: 0x181DD4880 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1DD63C0 Offset: 0x1DD4DC0 VA: 0x181DD63C0
	private static void .cctor() { }
}
