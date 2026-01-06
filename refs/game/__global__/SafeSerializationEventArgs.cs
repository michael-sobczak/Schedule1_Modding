public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 4442
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x1B552F0 Offset: 0x1B53CF0 VA: 0x181B552F0
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal IList<object> get_SerializedStates() { }

	// RVA: 0x1B552C0 Offset: 0x1B53CC0 VA: 0x181B552C0
	internal void .ctor() { }
}
