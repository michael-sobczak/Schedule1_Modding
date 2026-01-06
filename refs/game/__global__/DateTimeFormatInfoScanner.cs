internal class DateTimeFormatInfoScanner // TypeDefIndex: 4803
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x1BA1800 Offset: 0x1BA0200 VA: 0x181BA1800
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x1BA16B0 Offset: 0x1BA00B0 VA: 0x181BA16B0
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x1BA05A0 Offset: 0x1B9EFA0 VA: 0x181BA05A0
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x1BA07D0 Offset: 0x1B9F1D0 VA: 0x181BA07D0
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x1BA1640 Offset: 0x1BA0040 VA: 0x181BA1640
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x1BA0A00 Offset: 0x1B9F400 VA: 0x181BA0A00
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x1BA1420 Offset: 0x1B9FE20 VA: 0x181BA1420
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x1BA0EE0 Offset: 0x1B9F8E0 VA: 0x181BA0EE0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1BA11E0 Offset: 0x1B9FBE0 VA: 0x181BA11E0
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x1BA1360 Offset: 0x1B9FD60 VA: 0x181BA1360
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x1BA1320 Offset: 0x1B9FD20 VA: 0x181BA1320
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x1BA1310 Offset: 0x1B9FD10 VA: 0x181BA1310
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x1BA0E30 Offset: 0x1B9F830 VA: 0x181BA0E30
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x1BA0D50 Offset: 0x1B9F750 VA: 0x181BA0D50
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x1BA0B00 Offset: 0x1B9F500 VA: 0x181BA0B00
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x1BA1780 Offset: 0x1BA0180 VA: 0x181BA1780
	public void .ctor() { }
}
