public sealed class SerializationObjectManager // TypeDefIndex: 4428
{
	// Fields
	private readonly Dictionary<object, object> _objectSeenTable; // 0x10
	private readonly StreamingContext _context; // 0x18
	private SerializationEventHandler _onSerializedHandler; // 0x28

	// Methods

	// RVA: 0x1B40D00 Offset: 0x1B3F700 VA: 0x181B40D00
	public void .ctor(StreamingContext context) { }

	// RVA: 0x1B40B50 Offset: 0x1B3F550 VA: 0x181B40B50
	public void RegisterObject(object obj) { }

	// RVA: 0x1B40B10 Offset: 0x1B3F510 VA: 0x181B40B10
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x1B40A70 Offset: 0x1B3F470 VA: 0x181B40A70
	private void AddOnSerialized(object obj) { }
}
