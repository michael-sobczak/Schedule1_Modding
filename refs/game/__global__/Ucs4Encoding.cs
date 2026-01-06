internal class Ucs4Encoding : Encoding // TypeDefIndex: 8104
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x252AC20 Offset: 0x2529620 VA: 0x18252AC20 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public override byte[] GetBytes(string s) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x252AC90 Offset: 0x2529690 VA: 0x18252AC90 Slot: 23
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x252ACC0 Offset: 0x25296C0 VA: 0x18252ACC0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x252AD00 Offset: 0x2529700 VA: 0x18252AD00 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 31
	public override int get_CodePage() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x252AF90 Offset: 0x2529990 VA: 0x18252AF90
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x252AEC0 Offset: 0x25298C0 VA: 0x18252AEC0
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x252AD20 Offset: 0x2529720 VA: 0x18252AD20
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x252ADF0 Offset: 0x25297F0 VA: 0x18252ADF0
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x252AD10 Offset: 0x2529710 VA: 0x18252AD10
	public void .ctor() { }
}
