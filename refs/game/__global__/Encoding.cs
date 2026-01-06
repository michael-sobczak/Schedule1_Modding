public abstract class Encoding : ICloneable // TypeDefIndex: 4141
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Dictionary<int, Encoding> encodings; // 0x40
	private const int MIMECONTF_MAILNEWS = 1;
	private const int MIMECONTF_BROWSER = 2;
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;
	private const int MIMECONTF_SAVABLE_BROWSER = 512;
	private const int CodePageDefault = 0;
	private const int CodePageNoOEM = 1;
	private const int CodePageNoMac = 2;
	private const int CodePageNoThread = 3;
	private const int CodePageNoSymbol = 42;
	private const int CodePageUnicode = 1200;
	private const int CodePageBigEndian = 1201;
	private const int CodePageWindows1252 = 1252;
	private const int CodePageMacGB2312 = 10008;
	private const int CodePageGB2312 = 20936;
	private const int CodePageMacKorean = 10003;
	private const int CodePageDLLKorean = 20949;
	private const int ISO2022JP = 50220;
	private const int ISO2022JPESC = 50221;
	private const int ISO2022JPSISO = 50222;
	private const int ISOKorean = 50225;
	private const int ISOSimplifiedCN = 50227;
	private const int EUCJP = 51932;
	private const int ChineseHZ = 52936;
	private const int DuplicateEUCCN = 51936;
	private const int EUCCN = 936;
	private const int EUCKR = 51949;
	internal const int CodePageASCII = 20127;
	internal const int ISO_8859_1 = 28591;
	private const int ISCIIAssemese = 57006;
	private const int ISCIIBengali = 57003;
	private const int ISCIIDevanagari = 57002;
	private const int ISCIIGujarathi = 57010;
	private const int ISCIIKannada = 57008;
	private const int ISCIIMalayalam = 57009;
	private const int ISCIIOriya = 57007;
	private const int ISCIIPanjabi = 57011;
	private const int ISCIITamil = 57004;
	private const int ISCIITelugu = 57005;
	private const int GB18030 = 54936;
	private const int ISO_8859_8I = 38598;
	private const int ISO_8859_8_Visual = 28598;
	private const int ENC50229 = 50229;
	private const int CodePageUTF7 = 65000;
	private const int CodePageUTF8 = 65001;
	private const int CodePageUTF32 = 12000;
	private const int CodePageUTF32BE = 12001;
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual ReadOnlySpan<byte> Preamble { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	[ComVisible(False)]
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisible(False)]
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x1AD10B0 Offset: 0x1ACFAB0 VA: 0x181AD10B0
	protected void .ctor() { }

	// RVA: 0x1AD10F0 Offset: 0x1ACFAF0 VA: 0x181AD10F0
	protected void .ctor(int codePage) { }

	// RVA: 0x1AD0CB0 Offset: 0x1ACF6B0 VA: 0x181AD0CB0 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x1AD0B00 Offset: 0x1ACF500 VA: 0x181AD0B00
	internal void OnDeserializing() { }

	// RVA: 0x1AD0AB0 Offset: 0x1ACF4B0 VA: 0x181AD0AB0
	internal void OnDeserialized() { }

	[OnDeserializing]
	// RVA: 0x1AD0B00 Offset: 0x1ACF500 VA: 0x181AD0B00
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x1AD0AB0 Offset: 0x1ACF4B0 VA: 0x181AD0AB0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x50B620 Offset: 0x50A020 VA: 0x18050B620
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1ACE2B0 Offset: 0x1ACCCB0 VA: 0x181ACE2B0
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD0B40 Offset: 0x1ACF540 VA: 0x181AD0B40
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD1440 Offset: 0x1ACFE40 VA: 0x181AD1440
	private static object get_InternalSyncObject() { }

	// RVA: 0x1ACFB00 Offset: 0x1ACE500 VA: 0x181ACFB00
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x1ACF800 Offset: 0x1ACE200 VA: 0x181ACF800
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x1ACFA70 Offset: 0x1ACE470 VA: 0x181ACFA70
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x1AD0710 Offset: 0x1ACF110 VA: 0x181AD0710 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1AD15A0 Offset: 0x1ACFFA0 VA: 0x181AD15A0 Slot: 7
	public virtual ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1ACF5F0 Offset: 0x1ACDFF0 VA: 0x181ACF5F0
	private void GetDataItem() { }

	// RVA: 0x1AD13F0 Offset: 0x1ACFDF0 VA: 0x181AD13F0 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x1AD1400 Offset: 0x1ACFE00 VA: 0x181AD1400 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x1AD1920 Offset: 0x1AD0320 VA: 0x181AD1920 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x1AD1A30 Offset: 0x1AD0430 VA: 0x181AD1A30
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x1AD1960 Offset: 0x1AD0360 VA: 0x181AD1960
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisible(False)]
	// RVA: 0x1ACE1E0 Offset: 0x1ACCBE0 VA: 0x181ACE1E0 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_IsReadOnly() { }

	// RVA: 0x1AD1180 Offset: 0x1ACFB80 VA: 0x181AD1180
	public static Encoding get_ASCII() { }

	// RVA: 0x1AD14E0 Offset: 0x1ACFEE0 VA: 0x181AD14E0
	private static Encoding get_Latin1() { }

	// RVA: 0x1ACE7F0 Offset: 0x1ACD1F0 VA: 0x181ACE7F0 Slot: 12
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetByteCount(char[] chars, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x1ACE890 Offset: 0x1ACD290 VA: 0x181ACE890 Slot: 14
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1ACEA30 Offset: 0x1ACD430 VA: 0x181ACEA30 Slot: 15
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1ACEDB0 Offset: 0x1ACD7B0 VA: 0x181ACEDB0 Slot: 16
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1ACECC0 Offset: 0x1ACD6C0 VA: 0x181ACECC0 Slot: 17
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1ACEE60 Offset: 0x1ACD860 VA: 0x181ACEE60 Slot: 19
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1ACEF70 Offset: 0x1ACD970 VA: 0x181ACEF70 Slot: 20
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1ACED90 Offset: 0x1ACD790 VA: 0x181ACED90 Slot: 21
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1ACEA50 Offset: 0x1ACD450 VA: 0x181ACEA50 Slot: 22
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x1ACF020 Offset: 0x1ACDA20 VA: 0x181ACF020 Slot: 24
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1ACF1C0 Offset: 0x1ACDBC0 VA: 0x181ACF1C0 Slot: 25
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1ACF540 Offset: 0x1ACDF40 VA: 0x181ACF540 Slot: 26
	public virtual char[] GetChars(byte[] bytes) { }

	// RVA: 0x1ACF1E0 Offset: 0x1ACDBE0 VA: 0x181ACF1E0 Slot: 27
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1ACF2D0 Offset: 0x1ACDCD0 VA: 0x181ACF2D0 Slot: 29
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1ACF2B0 Offset: 0x1ACDCB0 VA: 0x181ACF2B0 Slot: 30
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1AD0810 Offset: 0x1ACF210 VA: 0x181AD0810
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x1AD0910 Offset: 0x1ACF310 VA: 0x181AD0910
	public string GetString(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 31
	public virtual int get_CodePage() { }

	// RVA: 0x1ACF720 Offset: 0x1ACE120 VA: 0x181ACF720 Slot: 32
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1ACE260 Offset: 0x1ACCC60 VA: 0x181ACE260
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x1AD1310 Offset: 0x1ACFD10 VA: 0x181AD1310
	public static Encoding get_Default() { }

	// RVA: 0x1ACF790 Offset: 0x1ACE190 VA: 0x181ACF790 Slot: 33
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x1AD0760 Offset: 0x1ACF160 VA: 0x181AD0760 Slot: 36
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x1AD0A80 Offset: 0x1ACF480 VA: 0x181AD0A80 Slot: 37
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1AD1850 Offset: 0x1AD0250 VA: 0x181AD1850
	public static Encoding get_Unicode() { }

	// RVA: 0x1AD1240 Offset: 0x1ACFC40 VA: 0x181AD1240
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x1AD16D0 Offset: 0x1AD00D0 VA: 0x181AD16D0
	public static Encoding get_UTF7() { }

	// RVA: 0x1AD1790 Offset: 0x1AD0190 VA: 0x181AD1790
	public static Encoding get_UTF8() { }

	// RVA: 0x1AD1610 Offset: 0x1AD0010 VA: 0x181AD1610
	public static Encoding get_UTF32() { }

	// RVA: 0x1ACE680 Offset: 0x1ACD080 VA: 0x181ACE680 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AD06A0 Offset: 0x1ACF0A0 VA: 0x181AD06A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ACE7A0 Offset: 0x1ACD1A0 VA: 0x181ACE7A0 Slot: 38
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1ACE750 Offset: 0x1ACD150 VA: 0x181ACE750 Slot: 39
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x1AD0D50 Offset: 0x1ACF750 VA: 0x181AD0D50
	internal void ThrowBytesOverflow() { }

	// RVA: 0x1AD0E60 Offset: 0x1ACF860 VA: 0x181AD0E60
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x1AD0F00 Offset: 0x1ACF900 VA: 0x181AD0F00
	internal void ThrowCharsOverflow() { }

	// RVA: 0x1AD1010 Offset: 0x1ACFA10 VA: 0x181AD1010
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}
