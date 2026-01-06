internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 7894
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0xCF72A0 Offset: 0xCF5CA0 VA: 0x180CF72A0 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x23AA880 Offset: 0x23A9280 VA: 0x1823AA880 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x23AA3F0 Offset: 0x23A8DF0 VA: 0x1823AA3F0
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x23AA700 Offset: 0x23A9100 VA: 0x1823AA700
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}
