public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 3618
{
	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	public static readonly DateTimeOffset UnixEpoch; // 0x20
	private readonly DateTime _dateTime; // 0x0
	private readonly short _offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset Now { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public TimeSpan Offset { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x1C4AEE0 Offset: 0x1C498E0 VA: 0x181C4AEE0
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x1C4B1D0 Offset: 0x1C49BD0 VA: 0x181C4B1D0
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x1C4AC20 Offset: 0x1C49620 VA: 0x181C4AC20
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1C4AFF0 Offset: 0x1C499F0 VA: 0x181C4AFF0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	// RVA: 0x1C4B320 Offset: 0x1C49D20 VA: 0x181C4B320
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	// RVA: 0x1C4B0E0 Offset: 0x1C49AE0 VA: 0x181C4B0E0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	// RVA: 0x1C4BB20 Offset: 0x1C4A520 VA: 0x181C4BB20
	public static DateTimeOffset get_Now() { }

	// RVA: 0x1C4B5D0 Offset: 0x1C49FD0 VA: 0x181C4B5D0
	public DateTime get_DateTime() { }

	// RVA: 0x1C4BE10 Offset: 0x1C4A810 VA: 0x181C4BE10
	public DateTime get_UtcDateTime() { }

	// RVA: 0x1C4B7D0 Offset: 0x1C4A1D0 VA: 0x181C4B7D0
	public DateTime get_LocalDateTime() { }

	// RVA: 0x1C4B400 Offset: 0x1C49E00 VA: 0x181C4B400
	private DateTime get_ClockDateTime() { }

	// RVA: 0x1C4B620 Offset: 0x1C4A020 VA: 0x181C4B620
	public int get_Day() { }

	// RVA: 0x1C4B6E0 Offset: 0x1C4A0E0 VA: 0x181C4B6E0
	public int get_Hour() { }

	// RVA: 0x1C4B880 Offset: 0x1C4A280 VA: 0x181C4B880
	public int get_Millisecond() { }

	// RVA: 0x1C4B970 Offset: 0x1C4A370 VA: 0x181C4B970
	public int get_Minute() { }

	// RVA: 0x1C4BA60 Offset: 0x1C4A460 VA: 0x181C4BA60
	public int get_Month() { }

	// RVA: 0x1C4BB80 Offset: 0x1C4A580 VA: 0x181C4BB80
	public TimeSpan get_Offset() { }

	// RVA: 0x1C4BBB0 Offset: 0x1C4A5B0 VA: 0x181C4BBB0
	public int get_Second() { }

	// RVA: 0x1C4BCA0 Offset: 0x1C4A6A0 VA: 0x181C4BCA0
	public long get_Ticks() { }

	// RVA: 0x1C4BD50 Offset: 0x1C4A750 VA: 0x181C4BD50
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x1C4BEC0 Offset: 0x1C4A8C0 VA: 0x181C4BEC0
	public int get_Year() { }

	// RVA: 0x1C48740 Offset: 0x1C47140 VA: 0x181C48740
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x1C493B0 Offset: 0x1C47DB0 VA: 0x181C493B0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x1C485F0 Offset: 0x1C46FF0 VA: 0x181C485F0 Slot: 6
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x1C487E0 Offset: 0x1C471E0 VA: 0x181C487E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C48980 Offset: 0x1C47380 VA: 0x181C48980 Slot: 7
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x1C48A50 Offset: 0x1C47450 VA: 0x181C48A50
	public static DateTimeOffset FromFileTime(long fileTime) { }

	// RVA: 0x1C49520 Offset: 0x1C47F20 VA: 0x181C49520 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1C49640 Offset: 0x1C48040 VA: 0x181C49640 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C4AA70 Offset: 0x1C49470 VA: 0x181C4AA70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C48BD0 Offset: 0x1C475D0 VA: 0x181C48BD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C49320 Offset: 0x1C47D20 VA: 0x181C49320
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1C49070 Offset: 0x1C47A70 VA: 0x181C49070
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x1C48C90 Offset: 0x1C47690 VA: 0x181C48C90
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x1C49700 Offset: 0x1C48100 VA: 0x181C49700
	public long ToFileTime() { }

	// RVA: 0x1C498E0 Offset: 0x1C482E0 VA: 0x181C498E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C499A0 Offset: 0x1C483A0 VA: 0x181C499A0
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x1C49800 Offset: 0x1C48200 VA: 0x181C49800 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C49AE0 Offset: 0x1C484E0 VA: 0x181C49AE0 Slot: 10
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1C49A70 Offset: 0x1C48470 VA: 0x181C49A70
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1C4A2A0 Offset: 0x1C48CA0 VA: 0x181C4A2A0
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1C49BF0 Offset: 0x1C485F0 VA: 0x181C49BF0
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1C49FB0 Offset: 0x1C489B0 VA: 0x181C49FB0
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1C4A6B0 Offset: 0x1C490B0 VA: 0x181C4A6B0
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x1C4A570 Offset: 0x1C48F70 VA: 0x181C4A570
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1C4A830 Offset: 0x1C49230 VA: 0x181C4A830
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1C4C040 Offset: 0x1C4AA40 VA: 0x181C4C040
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x1C4C130 Offset: 0x1C4AB30 VA: 0x181C4C130
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1C4BF70 Offset: 0x1C4A970 VA: 0x181C4BF70
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1C4C060 Offset: 0x1C4AA60 VA: 0x181C4C060
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1C4A950 Offset: 0x1C49350 VA: 0x181C4A950
	private static void .cctor() { }
}
