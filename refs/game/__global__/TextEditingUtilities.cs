internal class TextEditingUtilities // TypeDefIndex: 17623
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	private TextHandle m_TextHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	public bool multiline; // 0x26
	private string m_Text; // 0x28
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; // 0x0

	// Properties
	private bool hasSelection { get; }
	internal bool revealCursor { set; }
	private int cursorIndex { get; set; }
	private int selectIndex { get; set; }
	public string text { get; set; }

	// Methods

	// RVA: 0x2D24530 Offset: 0x2D22F30 VA: 0x182D24530
	private bool get_hasSelection() { }

	// RVA: 0x2D245F0 Offset: 0x2D22FF0 VA: 0x182D245F0
	internal void set_revealCursor(bool value) { }

	// RVA: 0x2D24500 Offset: 0x2D22F00 VA: 0x182D24500
	private int get_cursorIndex() { }

	// RVA: 0x2D245B0 Offset: 0x2D22FB0 VA: 0x182D245B0
	private void set_cursorIndex(int value) { }

	// RVA: 0x2D24580 Offset: 0x2D22F80 VA: 0x182D24580
	private int get_selectIndex() { }

	// RVA: 0x2D24630 Offset: 0x2D23030 VA: 0x182D24630
	private void set_selectIndex(int value) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public string get_text() { }

	// RVA: 0x2D24670 Offset: 0x2D23070 VA: 0x182D24670
	public void set_text(string value) { }

	// RVA: 0x2D24480 Offset: 0x2D22E80 VA: 0x182D24480
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x2D243E0 Offset: 0x2D22DE0 VA: 0x182D243E0
	public bool UpdateImeState() { }

	// RVA: 0x2D24360 Offset: 0x2D22D60 VA: 0x182D24360
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x2D24290 Offset: 0x2D22C90 VA: 0x182D24290
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x2D22B30 Offset: 0x2D21530 VA: 0x182D22B30
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x2D22A50 Offset: 0x2D21450 VA: 0x182D22A50
	public void EnableCursorPreviewState() { }

	// RVA: 0x2D24210 Offset: 0x2D22C10 VA: 0x182D24210
	public void RestoreCursorState() { }

	[VisibleToOtherModules]
	// RVA: 0x2D22C40 Offset: 0x2D21640 VA: 0x182D22C40
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x2D23670 Offset: 0x2D22070 VA: 0x182D23670
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x2D23430 Offset: 0x2D21E30 VA: 0x182D23430
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x2D22D60 Offset: 0x2D21760 VA: 0x182D22D60
	private void InitKeyActions() { }

	// RVA: 0x2D220C0 Offset: 0x2D20AC0 VA: 0x182D220C0
	public bool DeleteLineBack() { }

	// RVA: 0x2D22590 Offset: 0x2D20F90 VA: 0x182D22590
	public bool DeleteWordBack() { }

	// RVA: 0x2D22750 Offset: 0x2D21150 VA: 0x182D22750
	public bool DeleteWordForward() { }

	// RVA: 0x2D228D0 Offset: 0x2D212D0 VA: 0x182D228D0
	public bool Delete() { }

	// RVA: 0x2D21E90 Offset: 0x2D20890 VA: 0x182D21E90
	public bool Backspace() { }

	// RVA: 0x2D22290 Offset: 0x2D20C90 VA: 0x182D22290
	public bool DeleteSelection() { }

	// RVA: 0x2D240F0 Offset: 0x2D22AF0 VA: 0x182D240F0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x2D233D0 Offset: 0x2D21DD0 VA: 0x182D233D0
	public void Insert(char c) { }

	// RVA: 0x2D22030 Offset: 0x2D20A30 VA: 0x182D22030
	public bool CanPaste() { }

	// RVA: 0x2D22090 Offset: 0x2D20A90 VA: 0x182D22090
	public bool Cut() { }

	// RVA: 0x2D23540 Offset: 0x2D21F40 VA: 0x182D23540
	public bool Paste() { }

	// RVA: 0x2D24060 Offset: 0x2D22A60 VA: 0x182D24060
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x2D234C0 Offset: 0x2D21EC0 VA: 0x182D234C0
	internal void OnBlur() { }

	// RVA: 0x2D24370 Offset: 0x2D22D70 VA: 0x182D24370
	internal bool TouchScreenKeyboardShouldBeUsed() { }
}
