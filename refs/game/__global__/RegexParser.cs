internal sealed class RegexParser // TypeDefIndex: 9567
{
	// Fields
	private RegexNode _stack; // 0x10
	private RegexNode _group; // 0x18
	private RegexNode _alternation; // 0x20
	private RegexNode _concatenation; // 0x28
	private RegexNode _unit; // 0x30
	private string _pattern; // 0x38
	private int _currentPos; // 0x40
	private CultureInfo _culture; // 0x48
	private int _autocap; // 0x50
	private int _capcount; // 0x54
	private int _captop; // 0x58
	private int _capsize; // 0x5C
	private Hashtable _caps; // 0x60
	private Hashtable _capnames; // 0x68
	private int[] _capnumlist; // 0x70
	private List<string> _capnamelist; // 0x78
	private RegexOptions _options; // 0x80
	private List<RegexOptions> _optionsStack; // 0x88
	private bool _ignoreNextParen; // 0x90
	private static readonly byte[] s_category; // 0x0

	// Methods

	// RVA: 0x2633FE0 Offset: 0x26329E0 VA: 0x182633FE0
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x2633E40 Offset: 0x2632840 VA: 0x182633E40
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x2633150 Offset: 0x2631B50 VA: 0x182633150
	public static string Escape(string input) { }

	// RVA: 0x2638640 Offset: 0x2637040 VA: 0x182638640
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x2638390 Offset: 0x2636D90 VA: 0x182638390
	private void SetPattern(string Re) { }

	// RVA: 0x26345A0 Offset: 0x2632FA0 VA: 0x1826345A0
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x2637990 Offset: 0x2636390 VA: 0x182637990
	private RegexNode ScanRegex() { }

	// RVA: 0x2638220 Offset: 0x2636C20 VA: 0x182638220
	private RegexNode ScanReplacement() { }

	// RVA: 0x26357A0 Offset: 0x26341A0 VA: 0x1826357A0
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x2636A20 Offset: 0x2635420 VA: 0x182636A20
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x2635340 Offset: 0x2633D40 VA: 0x182635340
	private void ScanBlank() { }

	// RVA: 0x26346D0 Offset: 0x26330D0 VA: 0x1826346D0
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x2634C80 Offset: 0x2633680 VA: 0x182634C80
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x26365F0 Offset: 0x2634FF0 VA: 0x1826365F0
	private RegexNode ScanDollar() { }

	// RVA: 0x26356E0 Offset: 0x26340E0 VA: 0x1826356E0
	private string ScanCapname() { }

	// RVA: 0x26377F0 Offset: 0x26361F0 VA: 0x1826377F0
	private char ScanOctal() { }

	// RVA: 0x2636530 Offset: 0x2634F30 VA: 0x182636530
	private int ScanDecimal() { }

	// RVA: 0x26376D0 Offset: 0x26360D0 VA: 0x1826376D0
	private char ScanHex(int c) { }

	// RVA: 0x2633330 Offset: 0x2631D30 VA: 0x182633330
	private static int HexDigit(char ch) { }

	// RVA: 0x2636460 Offset: 0x2634E60 VA: 0x182636460
	private char ScanControl() { }

	// RVA: 0x26334C0 Offset: 0x2631EC0 VA: 0x1826334C0
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x2637890 Offset: 0x2636290 VA: 0x182637890
	private void ScanOptions() { }

	// RVA: 0x2636090 Offset: 0x2634A90 VA: 0x182636090
	private char ScanCharEscape() { }

	// RVA: 0x2633C70 Offset: 0x2632670 VA: 0x182633C70
	private string ParseProperty() { }

	// RVA: 0x26384D0 Offset: 0x2636ED0 VA: 0x1826384D0
	private int TypeFromCode(char ch) { }

	// RVA: 0x2633BD0 Offset: 0x26325D0 VA: 0x182633BD0
	private static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x2632BF0 Offset: 0x26315F0 VA: 0x182632BF0
	private void CountCaptures() { }

	// RVA: 0x2633A70 Offset: 0x2632470 VA: 0x182633A70
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x2633900 Offset: 0x2632300 VA: 0x182633900
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x2633B80 Offset: 0x2632580 VA: 0x182633B80
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x2632440 Offset: 0x2630E40 VA: 0x182632440
	private void AssignNameSlots() { }

	// RVA: 0x2632B20 Offset: 0x2631520 VA: 0x182632B20
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x26333A0 Offset: 0x2631DA0 VA: 0x1826333A0
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x2633370 Offset: 0x2631D70 VA: 0x182633370
	private bool IsCaptureName(string capname) { }

	// RVA: 0x2638580 Offset: 0x2636F80 VA: 0x182638580
	private bool UseOptionN() { }

	// RVA: 0x2638560 Offset: 0x2636F60 VA: 0x182638560
	private bool UseOptionI() { }

	// RVA: 0x2638570 Offset: 0x2636F70 VA: 0x182638570
	private bool UseOptionM() { }

	// RVA: 0x2638590 Offset: 0x2636F90 VA: 0x182638590
	private bool UseOptionS() { }

	// RVA: 0x26385A0 Offset: 0x2636FA0 VA: 0x1826385A0
	private bool UseOptionX() { }

	// RVA: 0x2638550 Offset: 0x2636F50 VA: 0x182638550
	private bool UseOptionE() { }

	// RVA: 0x26335E0 Offset: 0x2631FE0 VA: 0x1826335E0
	private static bool IsSpecial(char ch) { }

	// RVA: 0x2633660 Offset: 0x2632060 VA: 0x182633660
	private static bool IsStopperX(char ch) { }

	// RVA: 0x26334E0 Offset: 0x2631EE0 VA: 0x1826334E0
	private static bool IsQuantifier(char ch) { }

	// RVA: 0x26336E0 Offset: 0x26320E0 VA: 0x1826336E0
	private bool IsTrueQuantifier() { }

	// RVA: 0x2633560 Offset: 0x2631F60 VA: 0x182633560
	private static bool IsSpace(char ch) { }

	// RVA: 0x2633440 Offset: 0x2631E40 VA: 0x182633440
	private static bool IsMetachar(char ch) { }

	// RVA: 0x2631D70 Offset: 0x2630770 VA: 0x182631D70
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x2634480 Offset: 0x2632E80 VA: 0x182634480
	private void PushGroup() { }

	// RVA: 0x2634250 Offset: 0x2632C50 VA: 0x182634250
	private void PopGroup() { }

	// RVA: 0xB2C8B0 Offset: 0xB2B2B0 VA: 0x180B2C8B0
	private bool EmptyStack() { }

	// RVA: 0x2638400 Offset: 0x2636E00 VA: 0x182638400
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x2631AC0 Offset: 0x26304C0 VA: 0x182631AC0
	private void AddAlternate() { }

	// RVA: 0x2631D30 Offset: 0x2630730 VA: 0x182631D30
	private void AddConcatenate() { }

	// RVA: 0x2631BF0 Offset: 0x26305F0 VA: 0x182631BF0
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	private RegexNode Unit() { }

	// RVA: 0x2632240 Offset: 0x2630C40 VA: 0x182632240
	private void AddUnitOne(char ch) { }

	// RVA: 0x2632160 Offset: 0x2630B60 VA: 0x182632160
	private void AddUnitNotone(char ch) { }

	// RVA: 0x2632320 Offset: 0x2630D20 VA: 0x182632320
	private void AddUnitSet(string cc) { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x26323C0 Offset: 0x2630DC0 VA: 0x1826323C0
	private void AddUnitType(int type) { }

	// RVA: 0x2631F90 Offset: 0x2630990 VA: 0x182631F90
	private void AddGroup() { }

	// RVA: 0x2634500 Offset: 0x2632F00 VA: 0x182634500
	private void PushOptions() { }

	// RVA: 0x26343E0 Offset: 0x2632DE0 VA: 0x1826343E0
	private void PopOptions() { }

	// RVA: 0x2633100 Offset: 0x2631B00 VA: 0x182633100
	private bool EmptyOptionsStack() { }

	// RVA: 0x2634380 Offset: 0x2632D80 VA: 0x182634380
	private void PopKeepOptions() { }

	// RVA: 0x2633860 Offset: 0x2632260 VA: 0x182633860
	private ArgumentException MakeException(string message) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	private int Textpos() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	private void Textto(int pos) { }

	// RVA: 0x2634640 Offset: 0x2633040 VA: 0x182634640
	private char RightCharMoveRight() { }

	// RVA: 0x26338F0 Offset: 0x26322F0 VA: 0x1826338F0
	private void MoveRight() { }

	// RVA: 0xA30360 Offset: 0xA2ED60 VA: 0x180A30360
	private void MoveRight(int i) { }

	// RVA: 0x26338E0 Offset: 0x26322E0 VA: 0x1826338E0
	private void MoveLeft() { }

	// RVA: 0x2632BB0 Offset: 0x26315B0 VA: 0x182632BB0
	private char CharAt(int i) { }

	// RVA: 0x2634670 Offset: 0x2633070 VA: 0x182634670
	internal char RightChar() { }

	// RVA: 0x26346A0 Offset: 0x26330A0 VA: 0x1826346A0
	private char RightChar(int i) { }

	// RVA: 0x2632BD0 Offset: 0x26315D0 VA: 0x182632BD0
	private int CharsRight() { }

	// RVA: 0x26385B0 Offset: 0x2636FB0 VA: 0x1826385B0
	private static void .cctor() { }
}
