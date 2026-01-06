public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 4111
{
	// Fields
	private char _charUnknown; // 0x98
	private char _charUnknownHigh; // 0x9A
	private char _charUnknownLow; // 0x9C
	private int _index; // 0xA0

	// Methods

	// RVA: 0x1AB6AB0 Offset: 0x1AB54B0 VA: 0x181AB6AB0
	public void .ctor() { }

	// RVA: 0x1AB6D20 Offset: 0x1AB5720 VA: 0x181AB6D20
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x1AB6B00 Offset: 0x1AB5500 VA: 0x181AB6B00
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1AB6D60 Offset: 0x1AB5760 VA: 0x181AB6D60
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}
