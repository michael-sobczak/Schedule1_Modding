internal class GregorianCalendarHelper // TypeDefIndex: 4832
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; // 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras; // 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int get_MaxYear() { }

	// RVA: 0x1BAB640 Offset: 0x1BAA040 VA: 0x181BAB640
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x1BAAAF0 Offset: 0x1BA94F0 VA: 0x181BAAAF0
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	// RVA: 0x1BAAA30 Offset: 0x1BA9430 VA: 0x181BAAA30
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x1BAB020 Offset: 0x1BA9A20 VA: 0x181BAB020
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x1BAA3E0 Offset: 0x1BA8DE0 VA: 0x181BAA3E0 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x1BAA1F0 Offset: 0x1BA8BF0 VA: 0x181BAA1F0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1BAA170 Offset: 0x1BA8B70 VA: 0x181BAA170
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x1BAB040 Offset: 0x1BA9A40 VA: 0x181BAB040
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1BA9F70 Offset: 0x1BA8970 VA: 0x181BA9F70
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x1BAA5D0 Offset: 0x1BA8FD0 VA: 0x181BAA5D0
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1BAA640 Offset: 0x1BA9040 VA: 0x181BAA640
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1BAA6E0 Offset: 0x1BA90E0 VA: 0x181BAA6E0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1BAA890 Offset: 0x1BA9290 VA: 0x181BAA890
	public int GetDaysInYear(int year, int era) { }

	// RVA: 0x1BAA920 Offset: 0x1BA9320 VA: 0x181BAA920
	public int GetEra(DateTime time) { }

	// RVA: 0x1BAB700 Offset: 0x1BAA100 VA: 0x181BAB700
	public int[] get_Eras() { }

	// RVA: 0x1BAAA60 Offset: 0x1BA9460 VA: 0x181BAAA60
	public int GetMonth(DateTime time) { }

	// RVA: 0x1BAAAD0 Offset: 0x1BA94D0 VA: 0x181BAAAD0
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1BAAE70 Offset: 0x1BA9870 VA: 0x181BAAE70
	public int GetYear(DateTime time) { }

	// RVA: 0x1BAAFA0 Offset: 0x1BA99A0 VA: 0x181BAAFA0
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x1BAB210 Offset: 0x1BA9C10 VA: 0x181BAB210
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1BAB350 Offset: 0x1BA9D50 VA: 0x181BAB350
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

	// RVA: 0x1BAB550 Offset: 0x1BA9F50 VA: 0x181BAB550
	private static void .cctor() { }
}
