internal class SplitReader // TypeDefIndex: 12732
{
	// Fields
	private long _tick; // 0x10
	private int _expectedMessages; // 0x18
	private ushort _receivedMessages; // 0x1C
	private PooledWriter _writer; // 0x20

	// Methods

	// RVA: 0xD70540 Offset: 0xD6EF40 VA: 0x180D70540
	internal void .ctor() { }

	// RVA: 0xD703A0 Offset: 0xD6EDA0 VA: 0x180D703A0
	internal void GetHeader(PooledReader reader, out int expectedMessages) { }

	// RVA: 0xD70420 Offset: 0xD6EE20 VA: 0x180D70420
	internal void Write(uint tick, PooledReader reader, int expectedMessages) { }

	// RVA: 0xD70310 Offset: 0xD6ED10 VA: 0x180D70310
	internal ArraySegment<byte> GetFullMessage() { }

	// RVA: 0xD703E0 Offset: 0xD6EDE0 VA: 0x180D703E0
	private void Reset(uint tick = 0, int expectedMessages = 0) { }
}
