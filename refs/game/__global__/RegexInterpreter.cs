internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 9563
{
	// Fields
	private readonly RegexCode _code; // 0x80
	private readonly CultureInfo _culture; // 0x88
	private int _operator; // 0x90
	private int _codepos; // 0x94
	private bool _rightToLeft; // 0x98
	private bool _caseInsensitive; // 0x99

	// Methods

	// RVA: 0x2625DA0 Offset: 0x26247A0 VA: 0x182625DA0
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x26254C0 Offset: 0x2623EC0 VA: 0x1826254C0 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x2622C10 Offset: 0x2621610 VA: 0x182622C10
	private void Advance(int i) { }

	// RVA: 0x2625430 Offset: 0x2623E30 VA: 0x182625430
	private void Goto(int newpos) { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void Textto(int newpos) { }

	// RVA: 0x2625D80 Offset: 0x2624780 VA: 0x182625D80
	private void Trackto(int newpos) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	private int Textstart() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	private int Textpos() { }

	// RVA: 0x2625D60 Offset: 0x2624760 VA: 0x182625D60
	private int Trackpos() { }

	// RVA: 0x2625D20 Offset: 0x2624720 VA: 0x182625D20
	private void TrackPush() { }

	// RVA: 0x2625CB0 Offset: 0x26246B0 VA: 0x182625CB0
	private void TrackPush(int I1) { }

	// RVA: 0x2625C20 Offset: 0x2624620 VA: 0x182625C20
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x2625B70 Offset: 0x2624570 VA: 0x182625B70
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x2625B00 Offset: 0x2624500 VA: 0x182625B00
	private void TrackPush2(int I1) { }

	// RVA: 0x2625A70 Offset: 0x2624470 VA: 0x182625A70
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x2622C90 Offset: 0x2621690 VA: 0x182622C90
	private void Backtrack() { }

	// RVA: 0x2625730 Offset: 0x2624130 VA: 0x182625730
	private void SetOperator(int op) { }

	// RVA: 0x1E858E0 Offset: 0x1E842E0 VA: 0x181E858E0
	private void TrackPop() { }

	// RVA: 0x2625A60 Offset: 0x2624460 VA: 0x182625A60
	private void TrackPop(int framesize) { }

	// RVA: 0x2625A30 Offset: 0x2624430 VA: 0x182625A30
	private int TrackPeek() { }

	// RVA: 0x26259F0 Offset: 0x26243F0 VA: 0x1826259F0
	private int TrackPeek(int i) { }

	// RVA: 0x2625850 Offset: 0x2624250 VA: 0x182625850
	private void StackPush(int I1) { }

	// RVA: 0x26257F0 Offset: 0x26241F0 VA: 0x1826257F0
	private void StackPush(int I1, int I2) { }

	// RVA: 0x26257D0 Offset: 0x26241D0 VA: 0x1826257D0
	private void StackPop() { }

	// RVA: 0x26257E0 Offset: 0x26241E0 VA: 0x1826257E0
	private void StackPop(int framesize) { }

	// RVA: 0x2625760 Offset: 0x2624160 VA: 0x182625760
	private int StackPeek() { }

	// RVA: 0x2625790 Offset: 0x2624190 VA: 0x182625790
	private int StackPeek(int i) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	private int Operator() { }

	// RVA: 0x2625500 Offset: 0x2623F00 VA: 0x182625500
	private int Operand(int i) { }

	// RVA: 0x26254F0 Offset: 0x2623EF0 VA: 0x1826254F0
	private int Leftchars() { }

	// RVA: 0x2625720 Offset: 0x2624120 VA: 0x182625720
	private int Rightchars() { }

	// RVA: 0x2622D90 Offset: 0x2621790 VA: 0x182622D90
	private int Bump() { }

	// RVA: 0x2623460 Offset: 0x2621E60 VA: 0x182623460
	private int Forwardchars() { }

	// RVA: 0x26233C0 Offset: 0x2621DC0 VA: 0x1826233C0
	private char Forwardcharnext() { }

	// RVA: 0x2625890 Offset: 0x2624290 VA: 0x182625890
	private bool Stringmatch(string str) { }

	// RVA: 0x2625550 Offset: 0x2623F50 VA: 0x182625550
	private bool Refmatch(int index, int len) { }

	// RVA: 0x2622D70 Offset: 0x2621770 VA: 0x182622D70
	private void Backwardnext() { }

	// RVA: 0x2622DB0 Offset: 0x26217B0 VA: 0x182622DB0
	private char CharAt(int j) { }

	// RVA: 0x2622DD0 Offset: 0x26217D0 VA: 0x182622DD0 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x2623480 Offset: 0x2621E80 VA: 0x182623480 Slot: 4
	protected override void Go() { }
}
