internal class TextSelectingUtilities // TypeDefIndex: 17628
{
	// Fields
	public TextEditor.DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPosStart; // 0x1C
	private int m_DblClickInitPosEnd; // 0x20
	private TextHandle m_TextHandle; // 0x28
	private const int kMoveDownHeight = 5;
	private const char kNewLineChar = '\xa';
	private bool m_RevealCursor; // 0x30
	private int m_CursorIndex; // 0x34
	internal int m_SelectIndex; // 0x38
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; // 0x0
	internal Action OnCursorIndexChange; // 0x40
	internal Action OnSelectIndexChange; // 0x48
	internal Action OnRevealCursorChange; // 0x50

	// Properties
	public bool hasSelection { get; }
	public bool revealCursor { get; set; }
	private int m_CharacterCount { get; }
	private int characterCount { get; }
	private TextElementInfo[] m_TextElementInfos { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public string selectedText { get; }

	// Methods

	// RVA: 0x2D28890 Offset: 0x2D27290 VA: 0x182D28890
	public bool get_hasSelection() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_revealCursor() { }

	// RVA: 0x2D28A80 Offset: 0x2D27480 VA: 0x182D28A80
	public void set_revealCursor(bool value) { }

	// RVA: 0x2D288D0 Offset: 0x2D272D0 VA: 0x182D288D0
	private int get_m_CharacterCount() { }

	// RVA: 0x2D287A0 Offset: 0x2D271A0 VA: 0x182D287A0
	private int get_characterCount() { }

	// RVA: 0x2D28900 Offset: 0x2D27300 VA: 0x182D28900
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x2D28880 Offset: 0x2D27280 VA: 0x182D28880
	public int get_cursorIndex() { }

	// RVA: 0x2D28A50 Offset: 0x2D27450 VA: 0x182D28A50
	public void set_cursorIndex(int value) { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x2D28930 Offset: 0x2D27330 VA: 0x182D28930
	public int get_selectIndex() { }

	// RVA: 0x2D28AB0 Offset: 0x2D274B0 VA: 0x182D28AB0
	public void set_selectIndex(int value) { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x2D28940 Offset: 0x2D27340 VA: 0x182D28940
	public string get_selectedText() { }

	// RVA: 0x2D28750 Offset: 0x2D27150 VA: 0x182D28750
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x2D25450 Offset: 0x2D23E50 VA: 0x182D25450
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x2D26CD0 Offset: 0x2D256D0 VA: 0x182D26CD0
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x2D25B10 Offset: 0x2D24510 VA: 0x182D25B10
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x2D255A0 Offset: 0x2D23FA0 VA: 0x182D255A0
	private void InitKeyActions() { }

	// RVA: 0x2D24980 Offset: 0x2D23380 VA: 0x182D24980
	public void ClearCursorPos() { }

	// RVA: 0x2D26C40 Offset: 0x2D25640 VA: 0x182D26C40
	public void OnFocus(bool selectAll = True) { }

	// RVA: 0x2D273B0 Offset: 0x2D25DB0 VA: 0x182D273B0
	public void SelectAll() { }

	// RVA: 0x2D27A50 Offset: 0x2D26450 VA: 0x182D27A50
	public void SelectNone() { }

	// RVA: 0x2D27970 Offset: 0x2D26370 VA: 0x182D27970
	public void SelectLeft() { }

	// RVA: 0x2D27D20 Offset: 0x2D26720 VA: 0x182D27D20
	public void SelectRight() { }

	// RVA: 0x2D28450 Offset: 0x2D26E50 VA: 0x182D28450
	public void SelectUp() { }

	// RVA: 0x2D27850 Offset: 0x2D26250 VA: 0x182D27850
	public void SelectDown() { }

	// RVA: 0x2D27E00 Offset: 0x2D26800 VA: 0x182D27E00
	public void SelectTextEnd() { }

	// RVA: 0x2D27E40 Offset: 0x2D26840 VA: 0x182D27E40
	public void SelectTextStart() { }

	// RVA: 0x2D283F0 Offset: 0x2D26DF0 VA: 0x182D283F0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x2D27E70 Offset: 0x2D26870 VA: 0x182D27E70
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x2D28600 Offset: 0x2D27000 VA: 0x182D28600
	public void SelectWordRight() { }

	// RVA: 0x2D284B0 Offset: 0x2D26EB0 VA: 0x182D284B0
	public void SelectWordLeft() { }

	// RVA: 0x2D27910 Offset: 0x2D26310 VA: 0x182D27910
	public void SelectGraphicalLineStart() { }

	// RVA: 0x2D278B0 Offset: 0x2D262B0 VA: 0x182D278B0
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x2D27BF0 Offset: 0x2D265F0 VA: 0x182D27BF0
	public void SelectParagraphForward() { }

	// RVA: 0x2D27AA0 Offset: 0x2D264A0 VA: 0x182D27AA0
	public void SelectParagraphBackward() { }

	// RVA: 0x2D27520 Offset: 0x2D25F20 VA: 0x182D27520
	public void SelectCurrentWord() { }

	// RVA: 0x2D27420 Offset: 0x2D25E20 VA: 0x182D27420
	public void SelectCurrentParagraph() { }

	// RVA: 0x2D264C0 Offset: 0x2D24EC0 VA: 0x182D264C0
	public void MoveRight() { }

	// RVA: 0x2D25F30 Offset: 0x2D24930 VA: 0x182D25F30
	public void MoveLeft() { }

	// RVA: 0x2D267D0 Offset: 0x2D251D0 VA: 0x182D267D0
	public void MoveUp() { }

	// RVA: 0x2D25CD0 Offset: 0x2D246D0 VA: 0x182D25CD0
	public void MoveDown() { }

	// RVA: 0x2D26170 Offset: 0x2D24B70 VA: 0x182D26170
	public void MoveLineStart() { }

	// RVA: 0x2D26020 Offset: 0x2D24A20 VA: 0x182D26020
	public void MoveLineEnd() { }

	// RVA: 0x2D25E90 Offset: 0x2D24890 VA: 0x182D25E90
	public void MoveGraphicalLineStart() { }

	// RVA: 0x2D25DF0 Offset: 0x2D247F0 VA: 0x182D25DF0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x2D26610 Offset: 0x2D25010 VA: 0x182D26610
	public void MoveTextStart() { }

	// RVA: 0x2D265B0 Offset: 0x2D24FB0 VA: 0x182D265B0
	public void MoveTextEnd() { }

	// RVA: 0x2D263B0 Offset: 0x2D24DB0 VA: 0x182D263B0
	public void MoveParagraphForward() { }

	// RVA: 0x2D262B0 Offset: 0x2D24CB0 VA: 0x182D262B0
	public void MoveParagraphBackward() { }

	// RVA: 0x2D26A30 Offset: 0x2D25430 VA: 0x182D26A30
	public void MoveWordRight() { }

	// RVA: 0x2D26720 Offset: 0x2D25120 VA: 0x182D26720
	public void MoveToStartOfNextWord() { }

	// RVA: 0x2D26670 Offset: 0x2D25070 VA: 0x182D26670
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x2D268E0 Offset: 0x2D252E0 VA: 0x182D268E0
	public void MoveWordLeft() { }

	// RVA: 0x2D25BA0 Offset: 0x2D245A0 VA: 0x182D25BA0
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x2D24CC0 Offset: 0x2D236C0 VA: 0x182D24CC0
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x2D24BF0 Offset: 0x2D235F0 VA: 0x182D24BF0
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x2D25C40 Offset: 0x2D24640 VA: 0x182D25C40
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x2D27ED0 Offset: 0x2D268D0 VA: 0x182D27ED0
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x2D24FA0 Offset: 0x2D239A0 VA: 0x182D24FA0
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x2D25020 Offset: 0x2D23A20 VA: 0x182D25020
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x2D250C0 Offset: 0x2D23AC0 VA: 0x182D250C0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x2D24EB0 Offset: 0x2D238B0 VA: 0x182D24EB0
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x2D24D90 Offset: 0x2D23790 VA: 0x182D24D90
	private int FindEndOfClassification(int p, TextSelectingUtilities.Direction dir) { }

	// RVA: 0x2D24800 Offset: 0x2D23200 VA: 0x182D24800
	private int ClampTextIndex(int index) { }

	// RVA: 0x2D24B00 Offset: 0x2D23500 VA: 0x182D24B00
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x2D25A30 Offset: 0x2D24430 VA: 0x182D25A30
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x2D25560 Offset: 0x2D23F60 VA: 0x182D25560
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x2D272D0 Offset: 0x2D25CD0 VA: 0x182D272D0
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x2D26B60 Offset: 0x2D25560 VA: 0x182D26B60
	public int NextCodePointIndex(int index) { }

	// RVA: 0x2D253A0 Offset: 0x2D23DA0 VA: 0x182D253A0
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x2D252E0 Offset: 0x2D23CE0 VA: 0x182D252E0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x2D24990 Offset: 0x2D23390 VA: 0x182D24990
	public void Copy() { }

	// RVA: 0x2D24830 Offset: 0x2D23230 VA: 0x182D24830
	private TextSelectingUtilities.CharacterType ClassifyChar(int index) { }
}
