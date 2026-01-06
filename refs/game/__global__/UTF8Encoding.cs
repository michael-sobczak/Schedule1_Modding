public class UTF8Encoding : Encoding // TypeDefIndex: 4133
{
	// Fields
	private const int UTF8_CODEPAGE = 65001;
	internal static readonly UTF8Encoding.UTF8EncodingSealed s_default; // 0x0
	internal static readonly byte[] s_preamble; // 0x8
	internal readonly bool _emitUTF8Identifier; // 0x38
	private bool _isThrowException; // 0x39
	private const int FinalByte = 536870912;
	private const int SupplimentarySeq = 268435456;
	private const int ThreeByteSeq = 134217728;

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1AC9F80 Offset: 0x1AC8980 VA: 0x181AC9F80
	public void .ctor() { }

	// RVA: 0x1AC9FB0 Offset: 0x1AC89B0 VA: 0x181AC9FB0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1AC9F20 Offset: 0x1AC8920 VA: 0x181AC9F20
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1AC9D50 Offset: 0x1AC8750 VA: 0x181AC9D50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1AC6F90 Offset: 0x1AC5990 VA: 0x181AC6F90 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1AC6820 Offset: 0x1AC5220 VA: 0x181AC6820 Slot: 12
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC7140 Offset: 0x1AC5B40 VA: 0x181AC7140 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1AC7DF0 Offset: 0x1AC67F0 VA: 0x181AC7DF0 Slot: 20
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1AC80C0 Offset: 0x1AC6AC0 VA: 0x181AC80C0 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC7CC0 Offset: 0x1AC66C0 VA: 0x181AC7CC0 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1AC8960 Offset: 0x1AC7360 VA: 0x181AC8960 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC8860 Offset: 0x1AC7260 VA: 0x181AC8860 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1AC8B10 Offset: 0x1AC7510 VA: 0x181AC8B10 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC95D0 Offset: 0x1AC7FD0 VA: 0x181AC95D0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1AC9B40 Offset: 0x1AC8540 VA: 0x181AC9B40 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1AC68C0 Offset: 0x1AC52C0 VA: 0x181AC68C0 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1AC9D40 Offset: 0x1AC8740 VA: 0x181AC9D40
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1AC9D30 Offset: 0x1AC8730 VA: 0x181AC9D30
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1AC9D20 Offset: 0x1AC8720 VA: 0x181AC9D20
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1AC74A0 Offset: 0x1AC5EA0 VA: 0x181AC74A0 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1AC8390 Offset: 0x1AC6D90 VA: 0x181AC8390 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC8DE0 Offset: 0x1AC77E0 VA: 0x181AC8DE0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC67A0 Offset: 0x1AC51A0 VA: 0x181AC67A0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1AC6750 Offset: 0x1AC5150 VA: 0x181AC6750
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1AC7240 Offset: 0x1AC5C40 VA: 0x181AC7240
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1AC9700 Offset: 0x1AC8100 VA: 0x181AC9700 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1AC9760 Offset: 0x1AC8160 VA: 0x181AC9760 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1AC9830 Offset: 0x1AC8230 VA: 0x181AC9830 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1AC9970 Offset: 0x1AC8370 VA: 0x181AC9970 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1AC9AB0 Offset: 0x1AC84B0 VA: 0x181AC9AB0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1AC9FE0 Offset: 0x1AC89E0 VA: 0x181AC9FE0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1AC6680 Offset: 0x1AC5080 VA: 0x181AC6680 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AC97C0 Offset: 0x1AC81C0 VA: 0x181AC97C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AC9E40 Offset: 0x1AC8840 VA: 0x181AC9E40
	private static void .cctor() { }
}
