public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable // TypeDefIndex: 3735
{
	// Fields
	public const long TicksPerMillisecond = 10000;
	private const double MillisecondsPerTick = 0.0001;
	public const long TicksPerSecond = 10000000;
	private const double SecondsPerTick = 1E-07;
	public const long TicksPerMinute = 600000000;
	private const double MinutesPerTick = 1.6666666666666667E-09;
	public const long TicksPerHour = 36000000000;
	private const double HoursPerTick = 2.7777777777777777E-11;
	public const long TicksPerDay = 864000000000;
	private const double DaysPerTick = 1.1574074074074074E-12;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	internal const long MaxSeconds = 922337203685;
	internal const long MinSeconds = -922337203685;
	internal const long MaxMilliSeconds = 922337203685477;
	internal const long MinMilliSeconds = -922337203685477;
	internal const long TicksPerTenthSecond = 1000000;
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal readonly long _ticks; // 0x0

	// Properties
	public long Ticks { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public double TotalDays { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(long ticks) { }

	// RVA: 0x1C8B550 Offset: 0x1C89F50 VA: 0x181C8B550
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x1C8B490 Offset: 0x1C89E90 VA: 0x181C8B490
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public long get_Ticks() { }

	// RVA: 0x1C8B640 Offset: 0x1C8A040 VA: 0x181C8B640
	public int get_Days() { }

	// RVA: 0x1C8B660 Offset: 0x1C8A060 VA: 0x181C8B660
	public int get_Hours() { }

	// RVA: 0x1C8B6A0 Offset: 0x1C8A0A0 VA: 0x181C8B6A0
	public int get_Minutes() { }

	// RVA: 0x1C8B6F0 Offset: 0x1C8A0F0 VA: 0x181C8B6F0
	public int get_Seconds() { }

	// RVA: 0x1C8B740 Offset: 0x1C8A140 VA: 0x181C8B740
	public double get_TotalDays() { }

	// RVA: 0x1C8B760 Offset: 0x1C8A160 VA: 0x181C8B760
	public double get_TotalHours() { }

	// RVA: 0x1C8B780 Offset: 0x1C8A180 VA: 0x181C8B780
	public double get_TotalMilliseconds() { }

	// RVA: 0x1C8B7B0 Offset: 0x1C8A1B0 VA: 0x181C8B7B0
	public double get_TotalMinutes() { }

	// RVA: 0x1C8B7D0 Offset: 0x1C8A1D0 VA: 0x181C8B7D0
	public double get_TotalSeconds() { }

	// RVA: 0x1C8AA80 Offset: 0x1C89480 VA: 0x181C8AA80
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x1C8AC10 Offset: 0x1C89610 VA: 0x181C8AC10
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8AB20 Offset: 0x1C89520 VA: 0x181C8AB20 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C8AB00 Offset: 0x1C89500 VA: 0x181C8AB00 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x1C8ACC0 Offset: 0x1C896C0 VA: 0x181C8ACC0
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x1C8AC30 Offset: 0x1C89630 VA: 0x181C8AC30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x1C66530 Offset: 0x1C64F30 VA: 0x181C66530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C8AD20 Offset: 0x1C89720 VA: 0x181C8AD20
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x1C8AEA0 Offset: 0x1C898A0 VA: 0x181C8AEA0
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x1C8AD80 Offset: 0x1C89780 VA: 0x181C8AD80
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x1C8ADE0 Offset: 0x1C897E0 VA: 0x181C8ADE0
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x1C8AFB0 Offset: 0x1C899B0 VA: 0x181C8AFB0
	public TimeSpan Negate() { }

	// RVA: 0x1C8AE40 Offset: 0x1C89840 VA: 0x181C8AE40
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x1C8B170 Offset: 0x1C89B70 VA: 0x181C8B170
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x1C8B1F0 Offset: 0x1C89BF0 VA: 0x181C8B1F0
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x1C8B0F0 Offset: 0x1C89AF0 VA: 0x181C8B0F0
	public static TimeSpan Parse(string s) { }

	// RVA: 0x1C8B060 Offset: 0x1C89A60 VA: 0x181C8B060
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1C8B290 Offset: 0x1C89C90 VA: 0x181C8B290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C8B2F0 Offset: 0x1C89CF0 VA: 0x181C8B2F0 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C8B360 Offset: 0x1C89D60 VA: 0x181C8B360 Slot: 8
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1C8B9B0 Offset: 0x1C8A3B0 VA: 0x181C8B9B0
	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	// RVA: 0x1C8B8F0 Offset: 0x1C8A2F0 VA: 0x181C8B8F0
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B7F0 Offset: 0x1C8A1F0 VA: 0x181C8B7F0
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B8E0 Offset: 0x1C8A2E0 VA: 0x181C8B8E0
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B8D0 Offset: 0x1C8A2D0 VA: 0x181C8B8D0
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B8C0 Offset: 0x1C8A2C0 VA: 0x181C8B8C0
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B8B0 Offset: 0x1C8A2B0 VA: 0x181C8B8B0
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1C8B410 Offset: 0x1C89E10 VA: 0x181C8B410
	private static void .cctor() { }
}
