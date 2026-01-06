internal class UTF16Decoder : Decoder // TypeDefIndex: 8102
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x25296D0 Offset: 0x25280D0 VA: 0x1825296D0
	public void .ctor(bool bigEndian) { }

	// RVA: 0x1AB5350 Offset: 0x1AB3D50 VA: 0x181AB5350 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x25293B0 Offset: 0x2527DB0 VA: 0x1825293B0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x25294B0 Offset: 0x2527EB0 VA: 0x1825294B0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2529120 Offset: 0x2527B20 VA: 0x182529120 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}
