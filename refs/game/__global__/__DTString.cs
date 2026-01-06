internal struct __DTString // TypeDefIndex: 3641
{
	// Fields
	internal ReadOnlySpan<char> Value; // 0x0
	internal int Index; // 0x10
	internal char m_current; // 0x14
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static readonly char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal int Length { get; }
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x1C79D00 Offset: 0x1C78700 VA: 0x181C79D00
	internal int get_Length() { }

	// RVA: 0x1C79B20 Offset: 0x1C78520 VA: 0x181C79B20
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x1C79C20 Offset: 0x1C78620 VA: 0x181C79C20
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x1C780E0 Offset: 0x1C76AE0 VA: 0x181C780E0
	internal bool GetNext() { }

	// RVA: 0x1C77EC0 Offset: 0x1C768C0 VA: 0x181C77EC0
	internal bool AtEnd() { }

	// RVA: 0x1C77E20 Offset: 0x1C76820 VA: 0x181C77E20
	internal bool Advance(int count) { }

	// RVA: 0x1C78180 Offset: 0x1C76B80 VA: 0x181C78180
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C78560 Offset: 0x1C76F60 VA: 0x181C78560
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x1C789D0 Offset: 0x1C773D0 VA: 0x181C789D0
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x1C78B10 Offset: 0x1C77510 VA: 0x181C78B10
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x1C78FE0 Offset: 0x1C779E0 VA: 0x181C78FE0
	internal bool Match(string str) { }

	// RVA: 0x1C79150 Offset: 0x1C77B50 VA: 0x181C79150
	internal bool Match(char ch) { }

	// RVA: 0x1C788E0 Offset: 0x1C772E0 VA: 0x181C788E0
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x1C78490 Offset: 0x1C76E90 VA: 0x181C78490
	internal int GetRepeatCount() { }

	// RVA: 0x1C78020 Offset: 0x1C76A20 VA: 0x181C78020
	internal bool GetNextDigit() { }

	// RVA: 0x1C77FD0 Offset: 0x1C769D0 VA: 0x181C77FD0
	internal char GetChar() { }

	// RVA: 0x1C77FF0 Offset: 0x1C769F0 VA: 0x181C77FF0
	internal int GetDigit() { }

	// RVA: 0x1C798C0 Offset: 0x1C782C0 VA: 0x181C798C0
	internal void SkipWhiteSpaces() { }

	// RVA: 0x1C79780 Offset: 0x1C78180 VA: 0x181C79780
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x1C79980 Offset: 0x1C78380 VA: 0x181C79980
	internal void TrimTail() { }

	// RVA: 0x1C79500 Offset: 0x1C77F00 VA: 0x181C79500
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x1C79210 Offset: 0x1C77C10 VA: 0x181C79210
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x1C78780 Offset: 0x1C77180 VA: 0x181C78780
	internal DTSubString GetSubString() { }

	// RVA: 0x1C77F30 Offset: 0x1C76930 VA: 0x181C77F30
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x1C79AA0 Offset: 0x1C784A0 VA: 0x181C79AA0
	private static void .cctor() { }
}
