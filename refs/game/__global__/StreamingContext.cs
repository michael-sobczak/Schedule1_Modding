public struct StreamingContext // TypeDefIndex: 4452
{
	// Fields
	internal readonly object m_additionalContext; // 0x0
	internal readonly StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x1B594F0 Offset: 0x1B57EF0 VA: 0x181B594F0
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0xB2C8C0 Offset: 0xB2B2C0 VA: 0x180B2C8C0
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public object get_Context() { }

	// RVA: 0x1B59440 Offset: 0x1B57E40 VA: 0x181B59440 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public StreamingContextStates get_State() { }
}
