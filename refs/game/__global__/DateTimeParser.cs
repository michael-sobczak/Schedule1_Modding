internal struct DateTimeParser // TypeDefIndex: 11127
{
	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38
	private const short MaxFractionDigits = 7;

	// Methods

	// RVA: 0x1D61470 Offset: 0x1D5FE70 VA: 0x181D61470
	private static void .cctor() { }

	// RVA: 0x1D61350 Offset: 0x1D5FD50 VA: 0x181D61350
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x1D60980 Offset: 0x1D5F380 VA: 0x181D60980
	private bool ParseDate(int start) { }

	// RVA: 0x1D60C40 Offset: 0x1D5F640 VA: 0x181D60C40
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1D60CC0 Offset: 0x1D5F6C0 VA: 0x181D60CC0
	private bool ParseTime(ref int start) { }

	// RVA: 0x1D610F0 Offset: 0x1D5FAF0 VA: 0x181D610F0
	private bool ParseZone(int start) { }

	// RVA: 0x1D60870 Offset: 0x1D5F270 VA: 0x181D60870
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x1D607F0 Offset: 0x1D5F1F0 VA: 0x181D607F0
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x1D60940 Offset: 0x1D5F340 VA: 0x181D60940
	private bool ParseChar(int start, char ch) { }
}
