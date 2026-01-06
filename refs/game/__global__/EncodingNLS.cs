internal abstract class EncodingNLS : Encoding // TypeDefIndex: 4117
{
	// Methods

	// RVA: 0x1ABA5B0 Offset: 0x1AB8FB0 VA: 0x181ABA5B0
	protected void .ctor(int codePage) { }

	// RVA: 0x1AB9360 Offset: 0x1AB7D60 VA: 0x181AB9360 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1AB91C0 Offset: 0x1AB7BC0 VA: 0x181AB91C0 Slot: 12
	public override int GetByteCount(string s) { }

	// RVA: 0x1AB9260 Offset: 0x1AB7C60 VA: 0x181AB9260 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1AB9510 Offset: 0x1AB7F10 VA: 0x181AB9510 Slot: 20
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1AB9910 Offset: 0x1AB8310 VA: 0x181AB9910 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1AB97E0 Offset: 0x1AB81E0 VA: 0x181AB97E0 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1AB9BE0 Offset: 0x1AB85E0 VA: 0x181AB9BE0 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1AB9D90 Offset: 0x1AB8790 VA: 0x181AB9D90 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1AB9FC0 Offset: 0x1AB89C0 VA: 0x181AB9FC0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1AB9E90 Offset: 0x1AB8890 VA: 0x181AB9E90 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1ABA3D0 Offset: 0x1AB8DD0 VA: 0x181ABA3D0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1ABA290 Offset: 0x1AB8C90 VA: 0x181ABA290 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1ABA330 Offset: 0x1AB8D30 VA: 0x181ABA330 Slot: 33
	public override Encoder GetEncoder() { }
}
