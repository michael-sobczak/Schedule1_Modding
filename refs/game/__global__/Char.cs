public struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible // TypeDefIndex: 3610
{
	// Fields
	private readonly char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] s_categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x1BBFC50 Offset: 0x1BBE650 VA: 0x181BBFC50
	private static bool IsLatin1(char ch) { }

	// RVA: 0x1BBF9E0 Offset: 0x1BBE3E0 VA: 0x181BBF9E0
	private static bool IsAscii(char ch) { }

	// RVA: 0x1BBF790 Offset: 0x1BBE190 VA: 0x181BBF790
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x1BBF780 Offset: 0x1BBE180 VA: 0x181BBF780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BBF6F0 Offset: 0x1BBE0F0 VA: 0x181BBF6F0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC81950 Offset: 0xC80350 VA: 0x180C81950 Slot: 6
	public bool Equals(char obj) { }

	// RVA: 0x1BBF4C0 Offset: 0x1BBDEC0 VA: 0x181BBF4C0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1BBF4B0 Offset: 0x1BBDEB0 VA: 0x181BBF4B0 Slot: 5
	public int CompareTo(char value) { }

	// RVA: 0x1BC1060 Offset: 0x1BBFA60 VA: 0x181BC1060 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BC10B0 Offset: 0x1BBFAB0 VA: 0x181BC10B0 Slot: 22
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1BC1100 Offset: 0x1BBFB00 VA: 0x181BC1100
	public static string ToString(char c) { }

	// RVA: 0x1BC0760 Offset: 0x1BBF160 VA: 0x181BC0760
	public static char Parse(string s) { }

	// RVA: 0x1BC12D0 Offset: 0x1BBFCD0 VA: 0x181BC12D0
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x1BBFA80 Offset: 0x1BBE480 VA: 0x181BBFA80
	public static bool IsDigit(char c) { }

	// RVA: 0x1BBF470 Offset: 0x1BBDE70 VA: 0x181BBF470
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x1BBFD10 Offset: 0x1BBE710 VA: 0x181BBFD10
	public static bool IsLetter(char c) { }

	// RVA: 0x1BC0510 Offset: 0x1BBEF10 VA: 0x181BC0510
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x1BC0540 Offset: 0x1BBEF40 VA: 0x181BC0540
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x1BC0450 Offset: 0x1BBEE50 VA: 0x181BC0450
	public static bool IsUpper(char c) { }

	// RVA: 0x1BBFE10 Offset: 0x1BBE810 VA: 0x181BBFE10
	public static bool IsLower(char c) { }

	// RVA: 0x1BBF490 Offset: 0x1BBDE90 VA: 0x181BBF490
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x1BC0160 Offset: 0x1BBEB60 VA: 0x181BC0160
	public static bool IsPunctuation(char c) { }

	// RVA: 0x1BBF460 Offset: 0x1BBDE60 VA: 0x181BBF460
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x1BBFC60 Offset: 0x1BBE660 VA: 0x181BBFC60
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1BC1230 Offset: 0x1BBFC30 VA: 0x181BC1230
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x1BC11A0 Offset: 0x1BBFBA0 VA: 0x181BC11A0
	public static char ToUpper(char c) { }

	// RVA: 0x1BC1110 Offset: 0x1BBFB10 VA: 0x181BC1110
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x1BC0F30 Offset: 0x1BBF930 VA: 0x181BC0F30
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x1BC0FD0 Offset: 0x1BBF9D0 VA: 0x181BC0FD0
	public static char ToLower(char c) { }

	// RVA: 0x1BC0EA0 Offset: 0x1BBF8A0 VA: 0x181BC0EA0
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 7
	public TypeCode GetTypeCode() { }

	// RVA: 0x1BC0820 Offset: 0x1BBF220 VA: 0x181BC0820 Slot: 8
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 9
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1BC0C00 Offset: 0x1BBF600 VA: 0x181BC0C00 Slot: 10
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1BC08B0 Offset: 0x1BBF2B0 VA: 0x181BC08B0 Slot: 11
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1BC0AE0 Offset: 0x1BBF4E0 VA: 0x181BC0AE0 Slot: 12
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1BC0DB0 Offset: 0x1BBF7B0 VA: 0x181BC0DB0 Slot: 13
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1BC0B60 Offset: 0x1BBF560 VA: 0x181BC0B60 Slot: 14
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1BC0E00 Offset: 0x1BBF800 VA: 0x181BC0E00 Slot: 15
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1BC0BB0 Offset: 0x1BBF5B0 VA: 0x181BC0BB0 Slot: 16
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1BC0E50 Offset: 0x1BBF850 VA: 0x181BC0E50 Slot: 17
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1BC0C80 Offset: 0x1BBF680 VA: 0x181BC0C80 Slot: 18
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1BC0A50 Offset: 0x1BBF450 VA: 0x181BC0A50 Slot: 19
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1BC09C0 Offset: 0x1BBF3C0 VA: 0x181BC09C0 Slot: 20
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1BC0930 Offset: 0x1BBF330 VA: 0x181BC0930 Slot: 21
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1BC0D10 Offset: 0x1BBF710 VA: 0x181BC0D10 Slot: 23
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1BBF9F0 Offset: 0x1BBE3F0 VA: 0x181BBF9F0
	public static bool IsControl(char c) { }

	// RVA: 0x1BBF480 Offset: 0x1BBDE80 VA: 0x181BBF480
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x1BBFED0 Offset: 0x1BBE8D0 VA: 0x181BBFED0
	public static bool IsNumber(char c) { }

	// RVA: 0x1BBFFB0 Offset: 0x1BBE9B0 VA: 0x181BBFFB0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x1BBF4A0 Offset: 0x1BBDEA0 VA: 0x181BBF4A0
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1BC0210 Offset: 0x1BBEC10 VA: 0x181BC0210
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x1BC0230 Offset: 0x1BBEC30 VA: 0x181BC0230
	public static bool IsSeparator(char c) { }

	// RVA: 0x1BC0430 Offset: 0x1BBEE30 VA: 0x181BC0430
	public static bool IsSurrogate(char c) { }

	// RVA: 0x1BC0310 Offset: 0x1BBED10 VA: 0x181BC0310
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x1BC05E0 Offset: 0x1BBEFE0 VA: 0x181BC05E0
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x1BBF800 Offset: 0x1BBE200 VA: 0x181BBF800
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x1BBF880 Offset: 0x1BBE280 VA: 0x181BBF880
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1BBFC30 Offset: 0x1BBE630 VA: 0x181BBFC30
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1BBFB00 Offset: 0x1BBE500 VA: 0x181BBFB00
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x1BBFDF0 Offset: 0x1BBE7F0 VA: 0x181BBFDF0
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1BC02E0 Offset: 0x1BBECE0 VA: 0x181BC02E0
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1BBF5A0 Offset: 0x1BBDFA0 VA: 0x181BBF5A0
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1BC1300 Offset: 0x1BBFD00 VA: 0x181BC1300
	private static void .cctor() { }
}
