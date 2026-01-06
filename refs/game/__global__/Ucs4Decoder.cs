internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 8109
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x252A4E0 Offset: 0x2528EE0 VA: 0x18252A4E0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x252A4F0 Offset: 0x2528EF0 VA: 0x18252A4F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x252A2A0 Offset: 0x2528CA0 VA: 0x18252A2A0 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x252A6B0 Offset: 0x25290B0 VA: 0x18252A6B0
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x25299D0 Offset: 0x25283D0 VA: 0x1825299D0
	protected void .ctor() { }
}
