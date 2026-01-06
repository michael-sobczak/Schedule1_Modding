internal abstract class BinXmlDateTime // TypeDefIndex: 7899
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x1C43DE0 Offset: 0x1C427E0 VA: 0x181C43DE0
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x23ABEF0 Offset: 0x23AA8F0 VA: 0x1823ABEF0
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x23ABE20 Offset: 0x23AA820 VA: 0x1823ABE20
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x23AC040 Offset: 0x23AAA40 VA: 0x1823AC040
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x23AC670 Offset: 0x23AB070 VA: 0x1823AC670
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x23AC180 Offset: 0x23AAB80 VA: 0x1823AC180
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x23AC570 Offset: 0x23AAF70 VA: 0x1823AC570
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x23AC410 Offset: 0x23AAE10 VA: 0x1823AC410
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x23AB030 Offset: 0x23A9A30 VA: 0x1823AB030
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x23AB260 Offset: 0x23A9C60 VA: 0x1823AB260
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x23AB410 Offset: 0x23A9E10 VA: 0x1823AB410
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x23AC8C0 Offset: 0x23AB2C0 VA: 0x1823AC8C0
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x23ACBE0 Offset: 0x23AB5E0 VA: 0x1823ACBE0
	public static string XsdDateToString(long val) { }

	// RVA: 0x23ADC00 Offset: 0x23AC600 VA: 0x1823ADC00
	public static string XsdTimeToString(long val) { }

	// RVA: 0x23ABB90 Offset: 0x23AA590 VA: 0x1823ABB90
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x23ABAB0 Offset: 0x23AA4B0 VA: 0x1823ABAB0
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x23ABD10 Offset: 0x23AA710 VA: 0x1823ABD10
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x23ABCA0 Offset: 0x23AA6A0 VA: 0x1823ABCA0
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x23AD590 Offset: 0x23ABF90 VA: 0x1823AD590
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x23AD330 Offset: 0x23ABD30 VA: 0x1823AD330
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x23ADA30 Offset: 0x23AC430 VA: 0x1823ADA30
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x23ACE50 Offset: 0x23AB850 VA: 0x1823ACE50
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x23AD050 Offset: 0x23ABA50 VA: 0x1823AD050
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x23AD810 Offset: 0x23AC210 VA: 0x1823AD810
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x23AD650 Offset: 0x23AC050 VA: 0x1823AD650
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x23AD400 Offset: 0x23ABE00 VA: 0x1823AD400
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x23ADA90 Offset: 0x23AC490 VA: 0x1823ADA90
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x23ACED0 Offset: 0x23AB8D0 VA: 0x1823ACED0
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x23AD170 Offset: 0x23ABB70 VA: 0x1823AD170
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x23AD890 Offset: 0x23AC290 VA: 0x1823AD890
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x23AB7A0 Offset: 0x23AA1A0 VA: 0x1823AB7A0
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x23AB810 Offset: 0x23AA210 VA: 0x1823AB810
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x23ABA60 Offset: 0x23AA460 VA: 0x1823ABA60
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x23AB690 Offset: 0x23AA090 VA: 0x1823AB690
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x23AB560 Offset: 0x23A9F60 VA: 0x1823AB560
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x23ADE10 Offset: 0x23AC810 VA: 0x1823ADE10
	private static void .cctor() { }
}
