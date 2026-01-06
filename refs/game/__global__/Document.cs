internal class Document : IEnumerable, ICloneable // TypeDefIndex: 5583
{
	// Fields
	private Line document; // 0x10
	private int lines; // 0x18
	private Line sentinel; // 0x20
	private int document_id; // 0x28
	private Random random; // 0x30
	internal string password_char; // 0x38
	private StringBuilder password_cache; // 0x40
	private bool calc_pass; // 0x48
	private int char_count; // 0x4C
	private bool enable_links; // 0x50
	public static readonly StringFormat string_format; // 0x0
	private int recalc_suspended; // 0x54
	private bool recalc_pending; // 0x58
	private int recalc_start; // 0x5C
	private int recalc_end; // 0x60
	private bool recalc_optimize; // 0x64
	private int update_suspended; // 0x68
	private bool update_pending; // 0x6C
	private int update_start; // 0x70
	internal bool multiline; // 0x74
	internal HorizontalAlignment alignment; // 0x78
	internal bool wrap; // 0x7C
	internal UndoManager undo; // 0x80
	internal Document.Marker caret; // 0x88
	internal Document.Marker selection_start; // 0xA0
	internal Document.Marker selection_end; // 0xB8
	internal bool selection_visible; // 0xD0
	internal Document.Marker selection_anchor; // 0xD8
	internal Document.Marker selection_prev; // 0xF0
	internal bool selection_end_anchor; // 0x108
	internal int viewport_x; // 0x10C
	internal int viewport_y; // 0x110
	internal int offset_x; // 0x114
	internal int offset_y; // 0x118
	internal int viewport_width; // 0x11C
	internal int viewport_height; // 0x120
	internal int document_x; // 0x124
	internal int document_y; // 0x128
	internal int crlf_size; // 0x12C
	internal TextBoxBase owner; // 0x130
	internal static int caret_width; // 0x8
	internal static int caret_shift; // 0xC
	internal int left_margin; // 0x138
	internal int top_margin; // 0x13C
	internal int right_margin; // 0x140
	private EventHandler CaretMoved; // 0x148
	private EventHandler WidthChanged; // 0x150
	private EventHandler HeightChanged; // 0x158
	private EventHandler LengthChanged; // 0x160
	private EventHandler UIASelectionChanged; // 0x168
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$mapC; // 0x10

	// Properties
	internal Line Root { get; }
	internal int Lines { get; }
	internal Line CaretLine { get; }
	internal int CaretPosition { get; }
	internal Point Caret { get; }
	internal LineTag CaretTag { get; set; }
	internal bool EnableLinks { get; }
	internal string PasswordChar { set; }
	private StringBuilder PasswordCache { get; }
	internal int ViewPortX { get; set; }
	internal int Length { get; }
	private int CharCount { get; set; }
	internal int ViewPortY { get; set; }
	internal int OffsetX { get; set; }
	internal int ViewPortWidth { get; set; }
	internal int ViewPortHeight { get; set; }
	internal int Width { get; }
	internal int Height { get; }
	internal bool Wrap { set; }

	// Methods

	// RVA: 0x21FC7F0 Offset: 0x21FB1F0 VA: 0x1821FC7F0
	internal void .ctor(TextBoxBase owner) { }

	// RVA: 0x21FC730 Offset: 0x21FB130 VA: 0x1821FC730
	private static void .cctor() { }

	// RVA: 0x21FCD90 Offset: 0x21FB790 VA: 0x1821FCD90
	internal void add_WidthChanged(EventHandler value) { }

	// RVA: 0x21FD100 Offset: 0x21FBB00 VA: 0x1821FD100
	internal void remove_WidthChanged(EventHandler value) { }

	// RVA: 0x21FCCE0 Offset: 0x21FB6E0 VA: 0x1821FCCE0
	internal void add_HeightChanged(EventHandler value) { }

	// RVA: 0x21FD050 Offset: 0x21FBA50 VA: 0x1821FD050
	internal void remove_HeightChanged(EventHandler value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Line get_Root() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Lines() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal Line get_CaretLine() { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	internal int get_CaretPosition() { }

	// RVA: 0x21FCE40 Offset: 0x21FB840 VA: 0x1821FCE40
	internal Point get_Caret() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal LineTag get_CaretTag() { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	internal void set_CaretTag(LineTag value) { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	internal bool get_EnableLinks() { }

	// RVA: 0x21FD240 Offset: 0x21FBC40 VA: 0x1821FD240
	internal void set_PasswordChar(string value) { }

	// RVA: 0x21FCF00 Offset: 0x21FB900 VA: 0x1821FCF00
	private StringBuilder get_PasswordCache() { }

	// RVA: 0x51DA20 Offset: 0x51C420 VA: 0x18051DA20
	internal int get_ViewPortX() { }

	// RVA: 0x1E57740 Offset: 0x1E56140 VA: 0x181E57740
	internal void set_ViewPortX(int value) { }

	// RVA: 0x21FCEF0 Offset: 0x21FB8F0 VA: 0x1821FCEF0
	internal int get_Length() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	private int get_CharCount() { }

	// RVA: 0x21FD1B0 Offset: 0x21FBBB0 VA: 0x1821FD1B0
	private void set_CharCount(int value) { }

	// RVA: 0x21FCF70 Offset: 0x21FB970 VA: 0x1821FCF70
	internal int get_ViewPortY() { }

	// RVA: 0x21FD300 Offset: 0x21FBD00 VA: 0x1821FD300
	internal void set_ViewPortY(int value) { }

	// RVA: 0x51DB70 Offset: 0x51C570 VA: 0x18051DB70
	internal int get_OffsetX() { }

	// RVA: 0xD00680 Offset: 0xCFF080 VA: 0x180D00680
	internal void set_OffsetX(int value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	internal int get_ViewPortWidth() { }

	// RVA: 0x9C2380 Offset: 0x9C0D80 VA: 0x1809C2380
	internal void set_ViewPortWidth(int value) { }

	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	internal int get_ViewPortHeight() { }

	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	internal void set_ViewPortHeight(int value) { }

	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	internal int get_Width() { }

	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	internal int get_Height() { }

	// RVA: 0x83DBD0 Offset: 0x83C5D0 VA: 0x18083DBD0
	internal void set_Wrap(bool value) { }

	// RVA: 0x21FBEC0 Offset: 0x21FA8C0 VA: 0x1821FBEC0
	internal void UpdateMargins() { }

	// RVA: 0x21FBAE0 Offset: 0x21FA4E0 VA: 0x1821FBAE0
	internal void SuspendRecalc() { }

	// RVA: 0x21F87A0 Offset: 0x21F71A0 VA: 0x1821F87A0
	internal void ResumeRecalc(bool immediate_update) { }

	// RVA: 0x21FBB00 Offset: 0x21FA500 VA: 0x1821FBB00
	internal void SuspendUpdate() { }

	// RVA: 0x21F8820 Offset: 0x21F7220 VA: 0x1821F8820
	internal void ResumeUpdate(bool immediate_update) { }

	// RVA: 0x21FAB60 Offset: 0x21F9560 VA: 0x1821FAB60
	private void SetSelectionVisible(bool value) { }

	// RVA: 0x21F1A80 Offset: 0x21F0480 VA: 0x1821F1A80
	private void DecrementLines(int line_no) { }

	// RVA: 0x21F4D50 Offset: 0x21F3750 VA: 0x1821F4D50
	private void IncrementLines(int line_no) { }

	// RVA: 0x21F7400 Offset: 0x21F5E00 VA: 0x1821F7400
	private void RebalanceAfterAdd(Line line1) { }

	// RVA: 0x21F75E0 Offset: 0x21F5FE0 VA: 0x1821F75E0
	private void RebalanceAfterDelete(Line line1) { }

	// RVA: 0x21F88A0 Offset: 0x21F72A0 VA: 0x1821F88A0
	private void RotateLeft(Line line1) { }

	// RVA: 0x21F89A0 Offset: 0x21F73A0 VA: 0x1821F89A0
	private void RotateRight(Line line1) { }

	// RVA: 0x21FBF40 Offset: 0x21FA940 VA: 0x1821FBF40
	internal void UpdateView(Line line, int pos) { }

	// RVA: 0x21FC390 Offset: 0x21FAD90 VA: 0x1821FC390
	internal void UpdateView(Line line, int line_count, int pos) { }

	// RVA: 0x21F8BC0 Offset: 0x21F75C0 VA: 0x1821F8BC0
	private void ScanForLinks(Line start_line, ref bool link_changed) { }

	// RVA: 0x21F4340 Offset: 0x21F2D40 VA: 0x1821F4340
	private int FirstIndexOfAny(string haystack, string[] needles, int start_index, out int term_found) { }

	// RVA: 0x21F58C0 Offset: 0x21F42C0 VA: 0x1821F58C0
	private void InvalidateLinks(Rectangle clip) { }

	// RVA: 0x21F8AA0 Offset: 0x21F74A0 VA: 0x1821F8AA0
	internal void ScanForLinks(int start, int end, ref bool link_changed) { }

	// RVA: 0x21F34F0 Offset: 0x21F1EF0 VA: 0x1821F34F0
	internal void Empty() { }

	// RVA: 0x21F6DC0 Offset: 0x21F57C0 VA: 0x1821F6DC0
	internal void PositionCaret(Line line, int pos) { }

	// RVA: 0x21F7100 Offset: 0x21F5B00 VA: 0x1821F7100
	internal void PositionCaret(int x, int y) { }

	// RVA: 0x21F0EB0 Offset: 0x21EF8B0 VA: 0x1821F0EB0
	internal void CaretHasFocus() { }

	// RVA: 0x21F1260 Offset: 0x21EFC60 VA: 0x1821F1260
	internal void CaretLostFocus() { }

	// RVA: 0x21F0BB0 Offset: 0x21EF5B0 VA: 0x1821F0BB0
	internal void AlignCaret() { }

	// RVA: 0x21F0BC0 Offset: 0x21EF5C0 VA: 0x1821F0BC0
	internal void AlignCaret(bool changeCaretTag) { }

	// RVA: 0x21FBB80 Offset: 0x21FA580 VA: 0x1821FBB80
	internal void UpdateCaret() { }

	// RVA: 0x21F2340 Offset: 0x21F0D40 VA: 0x1821F2340
	internal void DisplayCaret() { }

	// RVA: 0x21F60F0 Offset: 0x21F4AF0 VA: 0x1821F60F0
	internal void MoveCaretToTextTag() { }

	// RVA: 0x21F6180 Offset: 0x21F4B80 VA: 0x1821F6180
	internal void MoveCaret(CaretDirection direction) { }

	// RVA: 0x21F4C60 Offset: 0x21F3660 VA: 0x1821F4C60
	internal void GetVisibleLineIndexes(Rectangle clip, out int start, out int end) { }

	// RVA: 0x21F2400 Offset: 0x21F0E00 VA: 0x1821F2400
	internal void Draw(Graphics g, Rectangle clip) { }

	// RVA: 0x21F47F0 Offset: 0x21F31F0 VA: 0x1821F47F0
	private int GetLineEnding(string line, int start, out LineEnding ending) { }

	// RVA: 0x21F4910 Offset: 0x21F3310 VA: 0x1821F4910
	private int GetLineEnding(string line, int start, out LineEnding ending, LineEnding type) { }

	// RVA: 0x21F5F50 Offset: 0x21F4950 VA: 0x1821F5F50
	internal int LineEndingLength(LineEnding ending) { }

	// RVA: 0x21F5F90 Offset: 0x21F4990 VA: 0x1821F5F90
	internal string LineEndingToString(LineEnding ending) { }

	// RVA: 0x21FB880 Offset: 0x21FA280 VA: 0x1821FB880
	internal LineEnding StringToLineEnding(string ending) { }

	// RVA: 0x21F5770 Offset: 0x21F4170 VA: 0x1821F5770
	internal void Insert(Line line, int pos, bool update_caret, string s) { }

	// RVA: 0x21F5170 Offset: 0x21F3B70 VA: 0x1821F5170
	internal void Insert(Line line, int pos, bool update_caret, string s, LineTag tag) { }

	// RVA: 0x21F5110 Offset: 0x21F3B10 VA: 0x1821F5110
	internal void InsertString(Line line, int pos, string s) { }

	// RVA: 0x21F4DC0 Offset: 0x21F37C0 VA: 0x1821F4DC0
	internal void InsertCharAtCaret(char ch, bool move_caret) { }

	// RVA: 0x21F4EF0 Offset: 0x21F38F0 VA: 0x1821F4EF0
	internal void InsertPicture(Line line, int pos, Picture picture) { }

	// RVA: 0x21F1D00 Offset: 0x21F0700 VA: 0x1821F1D00
	internal void DeleteMultiline(Line start_line, int pos, int length) { }

	// RVA: 0x21F1C00 Offset: 0x21F0600 VA: 0x1821F1C00
	public void DeleteChars(Line line, int pos, int count) { }

	// RVA: 0x21F1AE0 Offset: 0x21F04E0 VA: 0x1821F1AE0
	public void DeleteChar(Line line, int pos, bool forward) { }

	// RVA: 0x21F19F0 Offset: 0x21F03F0 VA: 0x1821F19F0
	internal void Combine(int FirstLine, int SecondLine) { }

	// RVA: 0x21F1670 Offset: 0x21F0070 VA: 0x1821F1670
	internal void Combine(Line first, Line second) { }

	// RVA: 0x21FB7F0 Offset: 0x21FA1F0 VA: 0x1821FB7F0
	internal void Split(int LineNo, int pos) { }

	// RVA: 0x21FAFD0 Offset: 0x21F99D0 VA: 0x1821FAFD0
	internal void Split(Line line, int pos) { }

	// RVA: 0x21FB020 Offset: 0x21F9A20 VA: 0x1821FB020
	internal void Split(Line line, LineTag tag, int pos) { }

	// RVA: 0x21F0930 Offset: 0x21EF330 VA: 0x1821F0930
	internal void Add(int LineNo, string Text, Font font, Color color, LineEnding ending) { }

	// RVA: 0x21F0980 Offset: 0x21EF380 VA: 0x1821F0980
	internal void Add(int LineNo, string Text, HorizontalAlignment align, Font font, Color color, LineEnding ending) { }

	// RVA: 0x21F1560 Offset: 0x21EFF60 VA: 0x1821F1560 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x21F1FF0 Offset: 0x21F09F0 VA: 0x1821F1FF0
	private void Delete(int LineNo) { }

	// RVA: 0x21F20F0 Offset: 0x21F0AF0 VA: 0x1821F20F0
	private void Delete(Line line1) { }

	// RVA: 0x21F57F0 Offset: 0x21F41F0 VA: 0x1821F57F0
	internal void InvalidateLinesAfter(Line start) { }

	// RVA: 0x21F5A50 Offset: 0x21F4450 VA: 0x1821F5A50
	internal void Invalidate(Line start, int start_pos, Line end, int end_pos) { }

	// RVA: 0x21F3820 Offset: 0x21F2220 VA: 0x1821F3820
	internal void ExpandSelection(CaretSelection mode, bool to_caret) { }

	// RVA: 0x21FA790 Offset: 0x21F9190 VA: 0x1821FA790
	internal void SetSelectionToCaret(bool start) { }

	// RVA: 0x21FADB0 Offset: 0x21F97B0 VA: 0x1821FADB0
	internal void SetSelection(Line start, int start_pos, Line end, int end_pos) { }

	// RVA: 0x21FA650 Offset: 0x21F9050 VA: 0x1821FA650
	internal void SetSelectionStart(Line start, int start_pos, bool invalidate) { }

	// RVA: 0x21F9C20 Offset: 0x21F8620 VA: 0x1821F9C20
	internal void SetSelectionStart(int character_index, bool invalidate) { }

	// RVA: 0x21F9930 Offset: 0x21F8330 VA: 0x1821F9930
	internal void SetSelectionEnd(Line end, int end_pos, bool invalidate) { }

	// RVA: 0x21F9BB0 Offset: 0x21F85B0 VA: 0x1821F9BB0
	internal void SetSelectionEnd(int character_index, bool invalidate) { }

	// RVA: 0x21FACA0 Offset: 0x21F96A0 VA: 0x1821FACA0
	internal void SetSelection(Line start, int start_pos) { }

	// RVA: 0x21F5A10 Offset: 0x21F4410 VA: 0x1821F5A10
	internal void InvalidateSelectionArea() { }

	// RVA: 0x21F4A30 Offset: 0x21F3430 VA: 0x1821F4A30
	internal string GetSelection() { }

	// RVA: 0x21F8100 Offset: 0x21F6B00 VA: 0x1821F8100
	internal void ReplaceSelection(string s, bool select_new) { }

	// RVA: 0x21F12F0 Offset: 0x21EFCF0 VA: 0x1821F12F0
	internal void CharIndexToLineTag(int index, out Line line_out, out LineTag tag_out, out int pos) { }

	// RVA: 0x21F6050 Offset: 0x21F4A50 VA: 0x1821F6050
	internal int LineTagToCharIndex(Line line, int pos) { }

	// RVA: 0x21F97A0 Offset: 0x21F81A0 VA: 0x1821F97A0
	internal int SelectionLength() { }

	// RVA: 0x21F49E0 Offset: 0x21F33E0 VA: 0x1821F49E0
	internal Line GetLine(int LineNo) { }

	// RVA: 0x21F46C0 Offset: 0x21F30C0 VA: 0x1821F46C0
	internal Line GetLineByPixel(int offset, bool exact) { }

	// RVA: 0x21F4100 Offset: 0x21F2B00 VA: 0x1821F4100
	internal LineTag FindCursor(int x, int y, out int index) { }

	// RVA: 0x21F4400 Offset: 0x21F2E00 VA: 0x1821F4400
	internal void FormatText(Line start_line, int start_pos, Line end_line, int end_pos, Font font, Color color, Color back_color, FormatSpecified specified) { }

	// RVA: 0x21F78A0 Offset: 0x21F62A0 VA: 0x1821F78A0
	internal void RecalculateAlignments() { }

	// RVA: 0x21F79F0 Offset: 0x21F63F0 VA: 0x1821F79F0
	internal bool RecalculateDocument(Graphics g) { }

	// RVA: 0x21F7A20 Offset: 0x21F6420 VA: 0x1821F7A20
	internal bool RecalculateDocument(Graphics g, int start, int end, bool optimize) { }

	// RVA: 0x21FCF80 Offset: 0x21FB980 VA: 0x1821FCF80
	private void owner_HandleCreated(object sender, EventArgs e) { }

	// RVA: 0x21FCFE0 Offset: 0x21FB9E0 VA: 0x1821FCFE0
	private void owner_VisibleChanged(object sender, EventArgs e) { }

	// RVA: 0x21F5F20 Offset: 0x21F4920 VA: 0x1821F5F20
	internal static bool IsWordSeparator(char ch) { }

	// RVA: 0x21F41B0 Offset: 0x21F2BB0 VA: 0x1821F41B0
	internal int FindWordSeparator(Line line, int pos, bool forward) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x21F3710 Offset: 0x21F2110 VA: 0x1821F3710 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FBB10 Offset: 0x21FA510 VA: 0x1821FBB10 Slot: 3
	public override string ToString() { }
}
