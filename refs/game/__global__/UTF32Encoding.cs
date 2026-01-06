public sealed class UTF32Encoding : Encoding // TypeDefIndex: 4124
{
	// Fields
	internal static readonly UTF32Encoding s_default; // 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	private bool _emitUTF32ByteOrderMark; // 0x38
	private bool _isThrowException; // 0x39
	private bool _bigEndian; // 0x3A

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1AC42E0 Offset: 0x1AC2CE0 VA: 0x181AC42E0
	public void .ctor() { }

	// RVA: 0x1AC4380 Offset: 0x1AC2D80 VA: 0x181AC4380
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1AC4310 Offset: 0x1AC2D10 VA: 0x181AC4310
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1AC4050 Offset: 0x1AC2A50 VA: 0x181AC4050 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1AC1BA0 Offset: 0x1AC05A0 VA: 0x181AC1BA0 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1AC1D50 Offset: 0x1AC0750 VA: 0x181AC1D50 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC1DF0 Offset: 0x1AC07F0 VA: 0x181AC1DF0 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1AC22F0 Offset: 0x1AC0CF0 VA: 0x181AC22F0 Slot: 20
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1AC1EF0 Offset: 0x1AC08F0 VA: 0x181AC1EF0 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC21C0 Offset: 0x1AC0BC0 VA: 0x181AC21C0 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1AC2F10 Offset: 0x1AC1910 VA: 0x181AC2F10 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC2E10 Offset: 0x1AC1810 VA: 0x181AC2E10 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1AC31F0 Offset: 0x1AC1BF0 VA: 0x181AC31F0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC30C0 Offset: 0x1AC1AC0 VA: 0x181AC30C0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1AC3E50 Offset: 0x1AC2850 VA: 0x181AC3E50 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1AC1820 Offset: 0x1AC0220 VA: 0x181AC1820 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1AC25C0 Offset: 0x1AC0FC0 VA: 0x181AC25C0 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1AC2AB0 Offset: 0x1AC14B0 VA: 0x181AC2AB0 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC34C0 Offset: 0x1AC1EC0 VA: 0x181AC34C0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC4030 Offset: 0x1AC2A30 VA: 0x181AC4030
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1AC3B40 Offset: 0x1AC2540 VA: 0x181AC3B40
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x1AC3B60 Offset: 0x1AC2560 VA: 0x181AC3B60
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x1AC3950 Offset: 0x1AC2350 VA: 0x181AC3950 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1AC39F0 Offset: 0x1AC23F0 VA: 0x181AC39F0 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1AC3B80 Offset: 0x1AC2580 VA: 0x181AC3B80 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1AC3CC0 Offset: 0x1AC26C0 VA: 0x181AC3CC0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1AC3DA0 Offset: 0x1AC27A0 VA: 0x181AC3DA0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1AC43D0 Offset: 0x1AC2DD0 VA: 0x181AC43D0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1AC1750 Offset: 0x1AC0150 VA: 0x181AC1750 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AC3A90 Offset: 0x1AC2490 VA: 0x181AC3A90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AC4140 Offset: 0x1AC2B40 VA: 0x181AC4140
	private static void .cctor() { }
}
