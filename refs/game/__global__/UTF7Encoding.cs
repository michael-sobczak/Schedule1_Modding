public class UTF7Encoding : Encoding // TypeDefIndex: 4129
{
	// Fields
	internal static readonly UTF7Encoding s_default; // 0x0
	private byte[] _base64Bytes; // 0x38
	private sbyte[] _base64Values; // 0x40
	private bool[] _directEncode; // 0x48
	private bool _allowOptionals; // 0x50

	// Methods

	// RVA: 0x1AC6610 Offset: 0x1AC5010 VA: 0x181AC6610
	public void .ctor() { }

	// RVA: 0x1AC6640 Offset: 0x1AC5040 VA: 0x181AC6640
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x1AC6250 Offset: 0x1AC4C50 VA: 0x181AC6250
	private void MakeTables() { }

	// RVA: 0x1AC64D0 Offset: 0x1AC4ED0 VA: 0x181AC64D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1AC4530 Offset: 0x1AC2F30 VA: 0x181AC4530 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AC5E70 Offset: 0x1AC4870 VA: 0x181AC5E70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AC47E0 Offset: 0x1AC31E0 VA: 0x181AC47E0 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1AC4740 Offset: 0x1AC3140 VA: 0x181AC4740 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC4600 Offset: 0x1AC3000 VA: 0x181AC4600 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1AC4C60 Offset: 0x1AC3660 VA: 0x181AC4C60 Slot: 20
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1AC4990 Offset: 0x1AC3390 VA: 0x181AC4990 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC52C0 Offset: 0x1AC3CC0 VA: 0x181AC52C0 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1AC54F0 Offset: 0x1AC3EF0 VA: 0x181AC54F0 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC53F0 Offset: 0x1AC3DF0 VA: 0x181AC53F0 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1AC5930 Offset: 0x1AC4330 VA: 0x181AC5930 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1AC5C00 Offset: 0x1AC4600 VA: 0x181AC5C00 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1AC6070 Offset: 0x1AC4A70 VA: 0x181AC6070 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1AC4700 Offset: 0x1AC3100 VA: 0x181AC4700 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1AC4F30 Offset: 0x1AC3930 VA: 0x181AC4F30 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1AC56A0 Offset: 0x1AC40A0 VA: 0x181AC56A0 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC56E0 Offset: 0x1AC40E0 VA: 0x181AC56E0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1AC5D30 Offset: 0x1AC4730 VA: 0x181AC5D30 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1AC5DD0 Offset: 0x1AC47D0 VA: 0x181AC5DD0 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1AC5EF0 Offset: 0x1AC48F0 VA: 0x181AC5EF0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1AC5FE0 Offset: 0x1AC49E0 VA: 0x181AC5FE0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1AC6590 Offset: 0x1AC4F90 VA: 0x181AC6590
	private static void .cctor() { }
}
