internal class DerSequenceReader // TypeDefIndex: 9605
{
	// Fields
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; // 0x20

	// Properties
	private int ContentLength { set; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_ContentLength(int value) { }

	// RVA: 0x262E120 Offset: 0x262CB20 VA: 0x18262E120
	internal void .ctor(byte[] data) { }

	// RVA: 0x262E160 Offset: 0x262CB60 VA: 0x18262E160
	internal void .ctor(byte[] data, int offset, int length) { }

	// RVA: 0x262DFB0 Offset: 0x262C9B0 VA: 0x18262DFB0
	private void .ctor(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length) { }

	// RVA: 0x262E190 Offset: 0x262CB90 VA: 0x18262E190
	internal bool get_HasData() { }

	// RVA: 0x262C790 Offset: 0x262B190 VA: 0x18262C790
	internal byte PeekTag() { }

	// RVA: 0x262DEF0 Offset: 0x262C8F0 VA: 0x18262DEF0
	internal void SkipValue() { }

	// RVA: 0x262CF40 Offset: 0x262B940 VA: 0x18262CF40
	internal byte[] ReadNextEncodedValue() { }

	// RVA: 0x262CAE0 Offset: 0x262B4E0 VA: 0x18262CAE0
	internal bool ReadBoolean() { }

	// RVA: 0x262CE90 Offset: 0x262B890 VA: 0x18262CE90
	internal int ReadInteger() { }

	// RVA: 0x262CE60 Offset: 0x262B860 VA: 0x18262CE60
	internal byte[] ReadIntegerBytes() { }

	// RVA: 0x262C950 Offset: 0x262B350 VA: 0x18262C950
	internal byte[] ReadBitString() { }

	// RVA: 0x262CFF0 Offset: 0x262B9F0 VA: 0x18262CFF0
	internal byte[] ReadOctetString() { }

	// RVA: 0x262D020 Offset: 0x262BA20 VA: 0x18262D020
	internal string ReadOidAsString() { }

	// RVA: 0x262DA30 Offset: 0x262C430 VA: 0x18262DA30
	internal string ReadUtf8String() { }

	// RVA: 0x262CBB0 Offset: 0x262B5B0 VA: 0x18262CBB0
	private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x262D450 Offset: 0x262BE50 VA: 0x18262D450
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x262D460 Offset: 0x262BE60 VA: 0x18262D460
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x262D370 Offset: 0x262BD70 VA: 0x18262D370
	internal string ReadPrintableString() { }

	// RVA: 0x262CD80 Offset: 0x262B780 VA: 0x18262CD80
	internal string ReadIA5String() { }

	// RVA: 0x262D470 Offset: 0x262BE70 VA: 0x18262D470
	internal string ReadT61String() { }

	// RVA: 0x262DB10 Offset: 0x262C510 VA: 0x18262DB10
	internal DateTime ReadX509Date() { }

	// RVA: 0x262D9F0 Offset: 0x262C3F0 VA: 0x18262D9F0
	internal DateTime ReadUtcTime() { }

	// RVA: 0x262CD40 Offset: 0x262B740 VA: 0x18262CD40
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x262C870 Offset: 0x262B270 VA: 0x18262C870
	internal string ReadBMPString() { }

	// RVA: 0x262DF40 Offset: 0x262C940 VA: 0x18262DF40
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x262D790 Offset: 0x262C190 VA: 0x18262D790
	private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString) { }

	// RVA: 0x262CC90 Offset: 0x262B690 VA: 0x18262CC90
	private byte[] ReadContentAsBytes() { }

	// RVA: 0x262C710 Offset: 0x262B110 VA: 0x18262C710
	private void EatTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x262C5A0 Offset: 0x262AFA0 VA: 0x18262C5A0
	private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position) { }

	// RVA: 0x262C6D0 Offset: 0x262B0D0 VA: 0x18262C6D0
	private int EatLength() { }

	// RVA: 0x262DBE0 Offset: 0x262C5E0 VA: 0x18262DBE0
	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) { }
}
