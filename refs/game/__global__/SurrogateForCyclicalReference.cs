internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate // TypeDefIndex: 4432
{
	// Fields
	private ISerializationSurrogate innerSurrogate; // 0x10

	// Methods

	// RVA: 0x1B42190 Offset: 0x1B40B90 VA: 0x181B42190 Slot: 4
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B42280 Offset: 0x1B40C80 VA: 0x181B42280 Slot: 5
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }
}
