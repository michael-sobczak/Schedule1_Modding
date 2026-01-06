public abstract class Calendar : ICloneable // TypeDefIndex: 4828
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1B9FEA0 Offset: 0x1B9E8A0 VA: 0x181B9FEA0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1B9FE50 Offset: 0x1B9E850 VA: 0x181B9FE50 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1B9FBD0 Offset: 0x1B9E5D0 VA: 0x181B9FBD0
	protected void .ctor() { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisible(False)]
	// RVA: 0x1B9F480 Offset: 0x1B9DE80 VA: 0x181B9F480 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x1B9FB50 Offset: 0x1B9E550 VA: 0x181B9FB50
	internal void VerifyWritable() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1B9FBF0 Offset: 0x1B9E5F0 VA: 0x181B9FBF0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetDaysInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetYear(DateTime time);

	// RVA: 0x1B9F550 Offset: 0x1B9DF50 VA: 0x181B9F550 Slot: 20
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool IsLeapYear(int year, int era);

	// RVA: 0x1B9F8E0 Offset: 0x1B9E2E0 VA: 0x181B9F8E0 Slot: 22
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x1B9FA50 Offset: 0x1B9E450 VA: 0x181B9FA50 Slot: 24
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1B9F680 Offset: 0x1B9E080 VA: 0x181B9F680 Slot: 25
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x1B9F600 Offset: 0x1B9E000 VA: 0x181B9F600 Slot: 26
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x1B9F570 Offset: 0x1B9DF70 VA: 0x181B9F570 Slot: 27
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 28
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x1B9FEF0 Offset: 0x1B9E8F0 VA: 0x181B9FEF0 Slot: 29
	public virtual void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1B9F940 Offset: 0x1B9E340 VA: 0x181B9F940 Slot: 30
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x1B9F710 Offset: 0x1B9E110 VA: 0x181B9F710
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1B9F500 Offset: 0x1B9DF00 VA: 0x181B9F500
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}
