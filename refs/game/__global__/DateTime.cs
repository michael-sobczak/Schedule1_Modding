public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable // TypeDefIndex: 3616
{
	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	internal const long UnixEpochTicks = 621355968000000000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] s_daysToMonth365; // 0x0
	private static readonly int[] s_daysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	public static readonly DateTime UnixEpoch; // 0x20
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private readonly ulong _dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }
	public static DateTime UtcNow { get; }

	// Methods

	// RVA: 0x1C5C7B0 Offset: 0x1C5B1B0 VA: 0x181C5C7B0
	public void .ctor(long ticks) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	private void .ctor(ulong dateData) { }

	// RVA: 0x1C5CED0 Offset: 0x1C5B8D0 VA: 0x181C5CED0
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x1C5CAD0 Offset: 0x1C5B4D0 VA: 0x181C5CAD0
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x1C5CB70 Offset: 0x1C5B570 VA: 0x181C5CB70
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x1C5C410 Offset: 0x1C5AE10 VA: 0x181C5C410
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x1C5CDC0 Offset: 0x1C5B7C0 VA: 0x181C5CDC0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x1C5CBF0 Offset: 0x1C5B5F0 VA: 0x181C5CBF0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1C5C840 Offset: 0x1C5B240 VA: 0x181C5C840
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	// RVA: 0x1C5C4B0 Offset: 0x1C5AEB0 VA: 0x181C5C4B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C5D1D0 Offset: 0x1C5BBD0 VA: 0x181C5D1D0
	internal long get_InternalTicks() { }

	// RVA: 0x1C5D1B0 Offset: 0x1C5BBB0 VA: 0x181C5D1B0
	private ulong get_InternalKind() { }

	// RVA: 0x1C58D30 Offset: 0x1C57730 VA: 0x181C58D30
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x1C58C10 Offset: 0x1C57610 VA: 0x181C58C10
	private DateTime Add(double value, int scale) { }

	// RVA: 0x1C585A0 Offset: 0x1C56FA0 VA: 0x181C585A0
	public DateTime AddDays(double value) { }

	// RVA: 0x1C58600 Offset: 0x1C57000 VA: 0x181C58600
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x1C58660 Offset: 0x1C57060 VA: 0x181C58660
	public DateTime AddMonths(int months) { }

	// RVA: 0x1C589D0 Offset: 0x1C573D0 VA: 0x181C589D0
	public DateTime AddSeconds(double value) { }

	// RVA: 0x1C58A30 Offset: 0x1C57430 VA: 0x181C58A30
	public DateTime AddTicks(long value) { }

	// RVA: 0x1C58B40 Offset: 0x1C57540 VA: 0x181C58B40
	public DateTime AddYears(int value) { }

	// RVA: 0x1C58EE0 Offset: 0x1C578E0 VA: 0x181C58EE0
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x1C58D90 Offset: 0x1C57790 VA: 0x181C58D90 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C58E80 Offset: 0x1C57880 VA: 0x181C58E80 Slot: 23
	public int CompareTo(DateTime value) { }

	// RVA: 0x1C58F60 Offset: 0x1C57960 VA: 0x181C58F60
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x1C5B0D0 Offset: 0x1C59AD0 VA: 0x181C5B0D0
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x1C59130 Offset: 0x1C57B30 VA: 0x181C59130
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x1C59270 Offset: 0x1C57C70 VA: 0x181C59270 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1C59330 Offset: 0x1C57D30 VA: 0x181C59330 Slot: 24
	public bool Equals(DateTime value) { }

	// RVA: 0x1C59430 Offset: 0x1C57E30 VA: 0x181C59430
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x1C59390 Offset: 0x1C57D90 VA: 0x181C59390
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x1C597C0 Offset: 0x1C581C0 VA: 0x181C597C0
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x1C59700 Offset: 0x1C58100 VA: 0x181C59700
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x1C5AFE0 Offset: 0x1C599E0 VA: 0x181C5AFE0 Slot: 25
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C59DA0 Offset: 0x1C587A0 VA: 0x181C59DA0
	public bool IsDaylightSavingTime() { }

	// RVA: 0x1C5A700 Offset: 0x1C59100 VA: 0x181C5A700
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x1C5B190 Offset: 0x1C59B90 VA: 0x181C5B190
	public long ToBinary() { }

	// RVA: 0x1C5CFC0 Offset: 0x1C5B9C0 VA: 0x181C5CFC0
	public DateTime get_Date() { }

	// RVA: 0x1C598F0 Offset: 0x1C582F0 VA: 0x181C598F0
	private int GetDatePart(int part) { }

	// RVA: 0x1C59AE0 Offset: 0x1C584E0 VA: 0x181C59AE0
	internal void GetDatePart(out int year, out int month, out int day) { }

	// RVA: 0x1C5D0D0 Offset: 0x1C5BAD0 VA: 0x181C5D0D0
	public int get_Day() { }

	// RVA: 0x1C5D040 Offset: 0x1C5BA40 VA: 0x181C5D040
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x1C59CD0 Offset: 0x1C586D0 VA: 0x181C59CD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5D120 Offset: 0x1C5BB20 VA: 0x181C5D120
	public int get_Hour() { }

	// RVA: 0x1C59D40 Offset: 0x1C58740 VA: 0x181C59D40
	internal bool IsAmbiguousDaylightSavingTime() { }

	// RVA: 0x1C5D1F0 Offset: 0x1C5BBF0 VA: 0x181C5D1F0
	public DateTimeKind get_Kind() { }

	// RVA: 0x1C5D260 Offset: 0x1C5BC60 VA: 0x181C5D260
	public int get_Millisecond() { }

	// RVA: 0x1C5D2F0 Offset: 0x1C5BCF0 VA: 0x181C5D2F0
	public int get_Minute() { }

	// RVA: 0x1C5D380 Offset: 0x1C5BD80 VA: 0x181C5D380
	public int get_Month() { }

	// RVA: 0x1C5D3D0 Offset: 0x1C5BDD0 VA: 0x181C5D3D0
	public static DateTime get_Now() { }

	// RVA: 0x1C5D550 Offset: 0x1C5BF50 VA: 0x181C5D550
	public int get_Second() { }

	// RVA: 0x1C5D5E0 Offset: 0x1C5BFE0 VA: 0x181C5D5E0
	public long get_Ticks() { }

	// RVA: 0x1C5D630 Offset: 0x1C5C030 VA: 0x181C5D630
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x1C5D700 Offset: 0x1C5C100 VA: 0x181C5D700
	public int get_Year() { }

	// RVA: 0x1C59E80 Offset: 0x1C58880 VA: 0x181C59E80
	public static bool IsLeapYear(int year) { }

	// RVA: 0x1C5A600 Offset: 0x1C59000 VA: 0x181C5A600
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C5A4C0 Offset: 0x1C58EC0 VA: 0x181C5A4C0
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x1C5A340 Offset: 0x1C58D40 VA: 0x181C5A340
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x1C59F60 Offset: 0x1C58960 VA: 0x181C59F60
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x1C5A120 Offset: 0x1C58B20 VA: 0x181C5A120
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x1C5A780 Offset: 0x1C59180 VA: 0x181C5A780
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x1C5B440 Offset: 0x1C59E40 VA: 0x181C5B440
	public long ToFileTime() { }

	// RVA: 0x1C5B320 Offset: 0x1C59D20 VA: 0x181C5B320
	public long ToFileTimeUtc() { }

	// RVA: 0x1C5B760 Offset: 0x1C5A160 VA: 0x181C5B760
	public DateTime ToLocalTime() { }

	// RVA: 0x1C5B4E0 Offset: 0x1C59EE0 VA: 0x181C5B4E0
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x1C5B7B0 Offset: 0x1C5A1B0 VA: 0x181C5B7B0
	public string ToShortDateString() { }

	// RVA: 0x1C5B820 Offset: 0x1C5A220 VA: 0x181C5B820
	public string ToShortTimeString() { }

	// RVA: 0x1C5B900 Offset: 0x1C5A300 VA: 0x181C5B900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C5BA00 Offset: 0x1C5A400 VA: 0x181C5BA00
	public string ToString(string format) { }

	// RVA: 0x1C5B9A0 Offset: 0x1C5A3A0 VA: 0x181C5B9A0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C5B890 Offset: 0x1C5A290 VA: 0x181C5B890 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C5BCC0 Offset: 0x1C5A6C0 VA: 0x181C5BCC0 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C5BA60 Offset: 0x1C5A460 VA: 0x181C5BA60
	public DateTime ToUniversalTime() { }

	// RVA: 0x1C5C0B0 Offset: 0x1C5AAB0 VA: 0x181C5C0B0
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x1C5BDB0 Offset: 0x1C5A7B0 VA: 0x181C5BDB0
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x1C5D750 Offset: 0x1C5C150 VA: 0x181C5D750
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x1C5DAE0 Offset: 0x1C5C4E0 VA: 0x181C5DAE0
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x1C5DBE0 Offset: 0x1C5C5E0 VA: 0x181C5DBE0
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x1C5D860 Offset: 0x1C5C260 VA: 0x181C5D860
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x1C5D9A0 Offset: 0x1C5C3A0 VA: 0x181C5D9A0
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x1C5DA70 Offset: 0x1C5C470 VA: 0x181C5DA70
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x1C5DA00 Offset: 0x1C5C400 VA: 0x181C5DA00
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x1C5D930 Offset: 0x1C5C330 VA: 0x181C5D930
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x1C5D8C0 Offset: 0x1C5C2C0 VA: 0x181C5D8C0
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C5A7F0 Offset: 0x1C591F0 VA: 0x181C5A7F0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C5A910 Offset: 0x1C59310 VA: 0x181C5A910 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C5AC70 Offset: 0x1C59670 VA: 0x181C5AC70 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C5A880 Offset: 0x1C59280 VA: 0x181C5A880 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C5AAC0 Offset: 0x1C594C0 VA: 0x181C5AAC0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C5AE30 Offset: 0x1C59830 VA: 0x181C5AE30 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C5AB50 Offset: 0x1C59550 VA: 0x181C5AB50 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C5AEC0 Offset: 0x1C598C0 VA: 0x181C5AEC0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C5ABE0 Offset: 0x1C595E0 VA: 0x181C5ABE0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C5AF50 Offset: 0x1C59950 VA: 0x181C5AF50 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C5AD00 Offset: 0x1C59700 VA: 0x181C5AD00 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C5AA30 Offset: 0x1C59430 VA: 0x181C5AA30 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C5A9A0 Offset: 0x1C593A0 VA: 0x181C5A9A0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C5AD90 Offset: 0x1C59790 VA: 0x181C5AD90 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1C5BAC0 Offset: 0x1C5A4C0 VA: 0x181C5BAC0
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x1C5D6A0 Offset: 0x1C5C0A0 VA: 0x181C5D6A0
	public static DateTime get_UtcNow() { }

	// RVA: 0x1C59D30 Offset: 0x1C58730 VA: 0x181C59D30
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	internal long ToBinaryRaw() { }

	// RVA: 0x1C5C2D0 Offset: 0x1C5ACD0 VA: 0x181C5C2D0
	private static void .cctor() { }
}
