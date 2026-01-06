public class XmlConvert // TypeDefIndex: 8095
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0x25333F0 Offset: 0x2531DF0 VA: 0x1825333F0
	public static string EncodeName(string name) { }

	// RVA: 0x2533390 Offset: 0x2531D90 VA: 0x182533390
	public static string EncodeLocalName(string name) { }

	// RVA: 0x2532B10 Offset: 0x2531510 VA: 0x182532B10
	public static string DecodeName(string name) { }

	// RVA: 0x2533440 Offset: 0x2531E40 VA: 0x182533440
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x2533DE0 Offset: 0x25327E0 VA: 0x182533DE0
	private static int FromHex(char digit) { }

	// RVA: 0x2533CB0 Offset: 0x25326B0 VA: 0x182533CB0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0x2533D60 Offset: 0x2532760 VA: 0x182533D60
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x2534140 Offset: 0x2532B40 VA: 0x182534140
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x2538B40 Offset: 0x2537540 VA: 0x182538B40
	public static string VerifyName(string name) { }

	// RVA: 0x2538210 Offset: 0x2536C10 VA: 0x182538210
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x2538CA0 Offset: 0x25376A0 VA: 0x182538CA0
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x2538830 Offset: 0x2537230 VA: 0x182538830
	public static string VerifyNCName(string name) { }

	// RVA: 0x25389D0 Offset: 0x25373D0 VA: 0x1825389D0
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x2537F30 Offset: 0x2536930 VA: 0x182537F30
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x2538E70 Offset: 0x2537870 VA: 0x182538E70
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x2538490 Offset: 0x2536E90 VA: 0x182538490
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x2538000 Offset: 0x2536A00 VA: 0x182538000
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x25383C0 Offset: 0x2536DC0 VA: 0x1825383C0
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x25355A0 Offset: 0x2533FA0 VA: 0x1825355A0
	public static string ToString(bool value) { }

	// RVA: 0x2535240 Offset: 0x2533C40 VA: 0x182535240
	public static string ToString(char value) { }

	// RVA: 0x25351D0 Offset: 0x2533BD0 VA: 0x1825351D0
	public static string ToString(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x25356E0 Offset: 0x25340E0 VA: 0x1825356E0
	public static string ToString(sbyte value) { }

	// RVA: 0x2535130 Offset: 0x2533B30 VA: 0x182535130
	public static string ToString(short value) { }

	// RVA: 0x2535160 Offset: 0x2533B60 VA: 0x182535160
	public static string ToString(int value) { }

	// RVA: 0x2535710 Offset: 0x2534110 VA: 0x182535710
	public static string ToString(long value) { }

	// RVA: 0x25351A0 Offset: 0x2533BA0 VA: 0x1825351A0
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2535100 Offset: 0x2533B00 VA: 0x182535100
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2535290 Offset: 0x2533C90 VA: 0x182535290
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2535330 Offset: 0x2533D30 VA: 0x182535330
	public static string ToString(ulong value) { }

	// RVA: 0x2535000 Offset: 0x2533A00 VA: 0x182535000
	public static string ToString(float value) { }

	// RVA: 0x2534F00 Offset: 0x2533900 VA: 0x182534F00
	public static string ToString(double value) { }

	// RVA: 0x25355F0 Offset: 0x2533FF0 VA: 0x1825355F0
	public static string ToString(TimeSpan value) { }

	// RVA: 0x2535650 Offset: 0x2534050 VA: 0x182535650
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x2535360 Offset: 0x2533D60 VA: 0x182535360
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x25352C0 Offset: 0x2533CC0 VA: 0x1825352C0
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x2535190 Offset: 0x2533B90 VA: 0x182535190
	public static string ToString(Guid value) { }

	// RVA: 0x25341B0 Offset: 0x2532BB0 VA: 0x1825341B0
	public static bool ToBoolean(string s) { }

	// RVA: 0x2535F90 Offset: 0x2534990 VA: 0x182535F90
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x2534400 Offset: 0x2532E00 VA: 0x182534400
	public static char ToChar(string s) { }

	// RVA: 0x25363B0 Offset: 0x2534DB0 VA: 0x1825363B0
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x2534A20 Offset: 0x2533420 VA: 0x182534A20
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x2536540 Offset: 0x2534F40 VA: 0x182536540
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x2534CD0 Offset: 0x25336D0 VA: 0x182534CD0
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x25370D0 Offset: 0x2535AD0 VA: 0x1825370D0
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliant(False)]
	// RVA: 0x2534D60 Offset: 0x2533760 VA: 0x182534D60
	public static sbyte ToSByte(string s) { }

	// RVA: 0x2537290 Offset: 0x2535C90 VA: 0x182537290
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x2534C40 Offset: 0x2533640 VA: 0x182534C40
	public static short ToInt16(string s) { }

	// RVA: 0x2536C20 Offset: 0x2535620 VA: 0x182536C20
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x2534C70 Offset: 0x2533670 VA: 0x182534C70
	public static int ToInt32(string s) { }

	// RVA: 0x2536DB0 Offset: 0x25357B0 VA: 0x182536DB0
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x2534CA0 Offset: 0x25336A0 VA: 0x182534CA0
	public static long ToInt64(string s) { }

	// RVA: 0x2536F40 Offset: 0x2535940 VA: 0x182536F40
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x25343D0 Offset: 0x2532DD0 VA: 0x1825343D0
	public static byte ToByte(string s) { }

	// RVA: 0x2536220 Offset: 0x2534C20 VA: 0x182536220
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliant(False)]
	// RVA: 0x25358A0 Offset: 0x25342A0 VA: 0x1825358A0
	public static ushort ToUInt16(string s) { }

	// RVA: 0x2537780 Offset: 0x2536180 VA: 0x182537780
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x25358D0 Offset: 0x25342D0 VA: 0x1825358D0
	public static uint ToUInt32(string s) { }

	// RVA: 0x2537910 Offset: 0x2536310 VA: 0x182537910
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x2535900 Offset: 0x2534300 VA: 0x182535900
	public static ulong ToUInt64(string s) { }

	// RVA: 0x2537AA0 Offset: 0x25364A0 VA: 0x182537AA0
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x2534D90 Offset: 0x2533790 VA: 0x182534D90
	public static float ToSingle(string s) { }

	// RVA: 0x2537420 Offset: 0x2535E20 VA: 0x182537420
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x2534AB0 Offset: 0x25334B0 VA: 0x182534AB0
	public static double ToDouble(string s) { }

	// RVA: 0x2536700 Offset: 0x2535100 VA: 0x182536700
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x2535C10 Offset: 0x2534610 VA: 0x182535C10
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x2538FA0 Offset: 0x25379A0 VA: 0x182538FA0
	internal static double XPathRound(double value) { }

	// RVA: 0x2535740 Offset: 0x2534140 VA: 0x182535740
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x25376D0 Offset: 0x25360D0 VA: 0x1825376D0
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x25391D0 Offset: 0x2537BD0 VA: 0x1825391D0
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x25316F0 Offset: 0x25300F0 VA: 0x1825316F0
	private static void CreateAllDateTimeFormats() { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	// RVA: 0x2534810 Offset: 0x2533210 VA: 0x182534810
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x2534980 Offset: 0x2533380 VA: 0x182534980
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x25345B0 Offset: 0x2532FB0 VA: 0x1825345B0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x25344D0 Offset: 0x2532ED0 VA: 0x1825344D0
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x2534C20 Offset: 0x2533620 VA: 0x182534C20
	public static Guid ToGuid(string s) { }

	// RVA: 0x25369C0 Offset: 0x25353C0 VA: 0x1825369C0
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x2533FA0 Offset: 0x25329A0 VA: 0x182533FA0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x2534070 Offset: 0x2532A70 VA: 0x182534070
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x2535930 Offset: 0x2534330 VA: 0x182535930
	internal static Uri ToUri(string s) { }

	// RVA: 0x2537C30 Offset: 0x2536630 VA: 0x182537C30
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x2533EF0 Offset: 0x25328F0 VA: 0x182533EF0
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x2535F20 Offset: 0x2534920 VA: 0x182535F20
	internal static string TrimString(string value) { }

	// RVA: 0x2535EB0 Offset: 0x25348B0 VA: 0x182535EB0
	internal static string TrimStringStart(string value) { }

	// RVA: 0x2535E40 Offset: 0x2534840 VA: 0x182535E40
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x2533E80 Offset: 0x2532880 VA: 0x182533E80
	internal static string[] SplitString(string value) { }

	// RVA: 0x2533E10 Offset: 0x2532810 VA: 0x182533E10
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x1BBBFA0 Offset: 0x1BBA9A0 VA: 0x181BBBFA0
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x25385B0 Offset: 0x2536FB0 VA: 0x1825385B0
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x2531E40 Offset: 0x2530840 VA: 0x182531E40
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2531C10 Offset: 0x2530610 VA: 0x182531C10
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2531F20 Offset: 0x2530920 VA: 0x182531F20
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x2531D60 Offset: 0x2530760 VA: 0x182531D60
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2532880 Offset: 0x2531280 VA: 0x182532880
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0x2532920 Offset: 0x2531320 VA: 0x182532920
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0x25329A0 Offset: 0x25313A0 VA: 0x1825329A0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2532660 Offset: 0x2531060 VA: 0x182532660
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0x2532280 Offset: 0x2530C80 VA: 0x182532280
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0x2532480 Offset: 0x2530E80 VA: 0x182532480
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x2532070 Offset: 0x2530A70 VA: 0x182532070
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x2532150 Offset: 0x2530B50 VA: 0x182532150
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0x2531FA0 Offset: 0x25309A0 VA: 0x182531FA0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x2532770 Offset: 0x2531170 VA: 0x182532770
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x25326B0 Offset: 0x25310B0 VA: 0x1825326B0
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x2539090 Offset: 0x2537A90 VA: 0x182539090
	private static void .cctor() { }
}
