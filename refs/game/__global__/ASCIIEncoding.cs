public class ASCIIEncoding : Encoding // TypeDefIndex: 4094
{
	// Fields
	internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default; // 0x0

	// Methods

	// RVA: 0x1CEE0F0 Offset: 0x1CECAF0 VA: 0x181CEE0F0
	public void .ctor() { }

	// RVA: 0x1CEE000 Offset: 0x1CECA00 VA: 0x181CEE000 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1CEC170 Offset: 0x1CEAB70 VA: 0x181CEC170 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1CEC320 Offset: 0x1CEAD20 VA: 0x181CEC320 Slot: 12
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x1CEBD40 Offset: 0x1CEA740 VA: 0x181CEBD40 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1CECC90 Offset: 0x1CEB690 VA: 0x181CECC90 Slot: 20
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1CEC9C0 Offset: 0x1CEB3C0 VA: 0x181CEC9C0 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1CEC890 Offset: 0x1CEB290 VA: 0x181CEC890 Slot: 22
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1CECF60 Offset: 0x1CEB960 VA: 0x181CECF60 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1CED110 Offset: 0x1CEBB10 VA: 0x181CED110 Slot: 24
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1CED810 Offset: 0x1CEC210 VA: 0x181CED810 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1CED3B0 Offset: 0x1CEBDB0 VA: 0x181CED3B0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1CEDE20 Offset: 0x1CEC820 VA: 0x181CEDE20 Slot: 37
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x1CEBE40 Offset: 0x1CEA840 VA: 0x181CEBE40 Slot: 15
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x1CEC3C0 Offset: 0x1CEADC0 VA: 0x181CEC3C0 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1CED210 Offset: 0x1CEBC10 VA: 0x181CED210 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1CED4E0 Offset: 0x1CEBEE0 VA: 0x181CED4E0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1CEDBA0 Offset: 0x1CEC5A0 VA: 0x181CEDBA0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1CEDCE0 Offset: 0x1CEC6E0 VA: 0x181CEDCE0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1CEDAE0 Offset: 0x1CEC4E0 VA: 0x181CEDAE0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1CEDB40 Offset: 0x1CEC540 VA: 0x181CEDB40 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1CEE040 Offset: 0x1CECA40 VA: 0x181CEE040
	private static void .cctor() { }
}
