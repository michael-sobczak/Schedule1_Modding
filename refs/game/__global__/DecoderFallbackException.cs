public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 4100
{
	// Fields
	private byte[] _bytesUnknown; // 0x98
	private int _index; // 0xA0

	// Methods

	// RVA: 0x1CEFDA0 Offset: 0x1CEE7A0 VA: 0x181CEFDA0
	public void .ctor() { }

	// RVA: 0x1CEFD50 Offset: 0x1CEE750 VA: 0x181CEFD50
	public void .ctor(string message, byte[] bytesUnknown, int index) { }

	// RVA: 0x1AB6D60 Offset: 0x1AB5760 VA: 0x181AB6D60
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}
