public abstract class JsonConverter // TypeDefIndex: 10989
{
	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
