public class UnicodeEncoding : Encoding // TypeDefIndex: 4135
{
	// Fields
	internal static readonly UnicodeEncoding s_bigEndianDefault; // 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x20

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1AE1050 Offset: 0x1ADFA50 VA: 0x181AE1050
	public void .ctor() { }

	// RVA: 0x1AE1000 Offset: 0x1ADFA00 VA: 0x181AE1000
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1AE0F80 Offset: 0x1ADF980 VA: 0x181AE0F80
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	// RVA: 0x1AE0CC0 Offset: 0x1ADF6C0 VA: 0x181AE0CC0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1ADD100 Offset: 0x1ADBB00 VA: 0x181ADD100 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1ADDA00 Offset: 0x1ADC400 VA: 0x181ADDA00 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1ADDAA0 Offset: 0x1ADC4A0 VA: 0x181ADDAA0 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1ADDBA0 Offset: 0x1ADC5A0 VA: 0x181ADDBA0 Slot: 20
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1ADE7E0 Offset: 0x1ADD1E0 VA: 0x181ADE7E0 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1ADEAB0 Offset: 0x1ADD4B0 VA: 0x181ADEAB0 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1ADF580 Offset: 0x1ADDF80 VA: 0x181ADF580 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1ADF480 Offset: 0x1ADDE80 VA: 0x181ADF480 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1AE0370 Offset: 0x1ADED70 VA: 0x181AE0370 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AE0240 Offset: 0x1ADEC40 VA: 0x181AE0240 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1AE0AE0 Offset: 0x1ADF4E0 VA: 0x181AE0AE0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1ADD2B0 Offset: 0x1ADBCB0 VA: 0x181ADD2B0 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1ADDE70 Offset: 0x1ADC870 VA: 0x181ADDE70 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1ADEBE0 Offset: 0x1ADD5E0 VA: 0x181ADEBE0 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1ADF730 Offset: 0x1ADE130 VA: 0x181ADF730 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1AE06A0 Offset: 0x1ADF0A0 VA: 0x181AE06A0 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1AE0640 Offset: 0x1ADF040 VA: 0x181AE0640 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1AE0A30 Offset: 0x1ADF430 VA: 0x181AE0A30 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1AE1080 Offset: 0x1ADFA80 VA: 0x181AE1080 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1AE07A0 Offset: 0x1ADF1A0 VA: 0x181AE07A0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1AE08E0 Offset: 0x1ADF2E0 VA: 0x181AE08E0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1ADCFE0 Offset: 0x1ADB9E0 VA: 0x181ADCFE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AE0700 Offset: 0x1ADF100 VA: 0x181AE0700 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE0DB0 Offset: 0x1ADF7B0 VA: 0x181AE0DB0
	private static void .cctor() { }
}
