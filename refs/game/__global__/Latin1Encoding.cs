internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 4119
{
	// Fields
	internal static readonly Latin1Encoding s_default; // 0x0
	private static readonly char[] arrayCharBestFit; // 0x8

	// Methods

	// RVA: 0x1ABBF60 Offset: 0x1ABA960 VA: 0x181ABBF60
	public void .ctor() { }

	// RVA: 0x1ABBF10 Offset: 0x1ABA910 VA: 0x181ABBF10
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ABBD50 Offset: 0x1ABA750 VA: 0x181ABBD50 Slot: 40
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ABB340 Offset: 0x1AB9D40 VA: 0x181ABB340 Slot: 15
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x1ABB5B0 Offset: 0x1AB9FB0 VA: 0x181ABB5B0 Slot: 21
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1ABBA40 Offset: 0x1ABA440 VA: 0x181ABBA40 Slot: 25
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1ABBA50 Offset: 0x1ABA450 VA: 0x181ABBA50 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1ABBAD0 Offset: 0x1ABA4D0 VA: 0x181ABBAD0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1ABBC10 Offset: 0x1ABA610 VA: 0x181ABBC10 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1ABB2F0 Offset: 0x1AB9CF0 VA: 0x181ABB2F0 Slot: 38
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1ABBE30 Offset: 0x1ABA830 VA: 0x181ABBE30
	private static void .cctor() { }
}
