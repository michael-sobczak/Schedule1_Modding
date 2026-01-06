public abstract class TextBoxBase : Control // TypeDefIndex: 5575
{
	// Fields
	internal HorizontalAlignment alignment; // 0x1D8
	internal bool accepts_tab; // 0x1DC
	internal bool accepts_return; // 0x1DD
	internal bool auto_size; // 0x1DE
	internal bool backcolor_set; // 0x1DF
	internal CharacterCasing character_casing; // 0x1E0
	internal bool hide_selection; // 0x1E4
	private int max_length; // 0x1E8
	internal bool modified; // 0x1EC
	internal char password_char; // 0x1EE
	internal bool read_only; // 0x1F0
	internal bool word_wrap; // 0x1F1
	internal Document document; // 0x1F8
	internal ImplicitHScrollBar hscroll; // 0x200
	internal ImplicitVScrollBar vscroll; // 0x208
	internal RichTextBoxScrollBars scrollbars; // 0x210
	internal Timer scroll_timer; // 0x218
	internal bool richtext; // 0x220
	internal bool show_selection; // 0x221
	internal ArrayList list_links; // 0x228
	private TextBoxBase.LinkRectangle current_link; // 0x230
	private bool enable_links; // 0x238
	internal bool has_been_focused; // 0x239
	internal int selection_length; // 0x23C
	internal bool show_caret_w_selection; // 0x240
	internal int canvas_width; // 0x244
	internal int canvas_height; // 0x248
	internal static int track_width; // 0x0
	internal static int track_border; // 0x4
	internal DateTime click_last; // 0x250
	internal int click_point_x; // 0x258
	internal int click_point_y; // 0x25C
	internal CaretSelection click_mode; // 0x260
	internal BorderStyle actual_border_style; // 0x264
	internal bool shortcuts_enabled; // 0x268
	private static object AcceptsTabChangedEvent; // 0x8
	private static object AutoSizeChangedEvent; // 0x10
	private static object BorderStyleChangedEvent; // 0x18
	private static object HideSelectionChangedEvent; // 0x20
	private static object ModifiedChangedEvent; // 0x28
	private static object MultilineChangedEvent; // 0x30
	private static object ReadOnlyChangedEvent; // 0x38
	private static object HScrolledEvent; // 0x40
	private static object VScrolledEvent; // 0x48

	// Properties
	[Localizable(True)]
	[MWFCategory("Behavior")]
	[Browsable(False)]
	[EditorBrowsable(1)]
	[DefaultValue(True)]
	[RefreshProperties(2)]
	public override bool AutoSize { get; set; }
	[DispId(-501)]
	public override Color BackColor { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Image BackgroundImage { get; }
	[DefaultValue(2)]
	[DispId(-504)]
	[MWFCategory("Appearance")]
	public BorderStyle BorderStyle { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool CanUndo { get; }
	[DispId(-513)]
	public override Color ForeColor { get; set; }
	[MWFCategory("Behavior")]
	[DefaultValue(True)]
	public bool HideSelection { set; }
	[DesignerSerializationVisibility(0)]
	[MergableProperty(False)]
	[Localizable(True)]
	[MWFCategory("Appearance")]
	[Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string[] Lines { get; }
	[Localizable(True)]
	[MWFCategory("Behavior")]
	[DefaultValue(32767)]
	public virtual int MaxLength { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool Modified { set; }
	[DefaultValue(False)]
	[Localizable(True)]
	[MWFCategory("Behavior")]
	[RefreshProperties(1)]
	public virtual bool Multiline { get; set; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	[Browsable(False)]
	public int PreferredHeight { get; }
	[RefreshProperties(2)]
	[DefaultValue(False)]
	[MWFCategory("Behavior")]
	public bool ReadOnly { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual string SelectedText { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual int SelectionLength { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public int SelectionStart { set; }
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Localizable(True)]
	public override string Text { get; set; }
	[Browsable(False)]
	public virtual int TextLength { get; }
	[Localizable(True)]
	[MWFCategory("Behavior")]
	[DefaultValue(True)]
	public bool WordWrap { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override ImageLayout BackgroundImageLayout { get; set; }
	protected override Cursor DefaultCursor { get; }
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }
	[EditorBrowsable(1)]
	protected override bool DoubleBuffered { get; }
	internal override bool ScaleChildrenInternal { get; }
	internal bool ShowSelection { get; set; }
	internal int TopMargin { get; set; }

	// Methods

	// RVA: 0x21EBA60 Offset: 0x21EA460 VA: 0x1821EBA60
	internal void .ctor() { }

	// RVA: 0x21EB790 Offset: 0x21EA190 VA: 0x1821EB790
	private static void .cctor() { }

	// RVA: 0x21EC200 Offset: 0x21EAC00 VA: 0x1821EC200
	public void add_Click(EventHandler value) { }

	// RVA: 0x21ECC10 Offset: 0x21EB610 VA: 0x1821ECC10
	public void remove_Click(EventHandler value) { }

	// RVA: 0x21E65C0 Offset: 0x21E4FC0 VA: 0x1821E65C0
	internal string CaseAdjust(string s) { }

	// RVA: 0x21E6CE0 Offset: 0x21E56E0 VA: 0x1821E6CE0 Slot: 33
	internal override Size GetPreferredSizeCore(Size proposedSize) { }

	// RVA: 0x21E7330 Offset: 0x21E5D30 VA: 0x1821E7330 Slot: 32
	internal override void HandleClick(int clicks, MouseEventArgs me) { }

	// RVA: 0x21E8090 Offset: 0x21E6A90 VA: 0x1821E8090 Slot: 20
	internal override void PaintControlBackground(PaintEventArgs pevent) { }

	// RVA: 0x21EC220 Offset: 0x21EAC20 VA: 0x1821EC220 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x21ECC20 Offset: 0x21EB620 VA: 0x1821ECC20 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x21C7A10 Offset: 0x21C6410 VA: 0x1821C7A10 Slot: 42
	public override Color get_BackColor() { }

	// RVA: 0x21ECD00 Offset: 0x21EB700 VA: 0x1821ECD00 Slot: 43
	public override void set_BackColor(Color value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0 Slot: 44
	public override Image get_BackgroundImage() { }

	// RVA: 0x21EC230 Offset: 0x21EAC30 VA: 0x1821EC230
	public BorderStyle get_BorderStyle() { }

	// RVA: 0x21ECD70 Offset: 0x21EB770 VA: 0x1821ECD70
	public void set_BorderStyle(BorderStyle value) { }

	// RVA: 0x21EC240 Offset: 0x21EAC40 VA: 0x1821EC240
	public bool get_CanUndo() { }

	// RVA: 0x21D0940 Offset: 0x21CF340 VA: 0x1821D0940 Slot: 65
	public override Color get_ForeColor() { }

	// RVA: 0x21ECE40 Offset: 0x21EB840 VA: 0x1821ECE40 Slot: 66
	public override void set_ForeColor(Color value) { }

	// RVA: 0x21ECE70 Offset: 0x21EB870 VA: 0x1821ECE70
	public void set_HideSelection(bool value) { }

	// RVA: 0x21EC2B0 Offset: 0x21EACB0 VA: 0x1821EC2B0
	public string[] get_Lines() { }

	// RVA: 0x21EC4E0 Offset: 0x21EAEE0 VA: 0x1821EC4E0 Slot: 193
	public virtual int get_MaxLength() { }

	// RVA: 0x21ECF30 Offset: 0x21EB930 VA: 0x1821ECF30 Slot: 194
	public virtual void set_MaxLength(int value) { }

	// RVA: 0x21ECF50 Offset: 0x21EB950 VA: 0x1821ECF50
	public void set_Modified(bool value) { }

	// RVA: 0x21EC500 Offset: 0x21EAF00 VA: 0x1821EC500 Slot: 195
	public virtual bool get_Multiline() { }

	// RVA: 0x21ECFE0 Offset: 0x21EB9E0 VA: 0x1821ECFE0 Slot: 196
	public virtual void set_Multiline(bool value) { }

	// RVA: 0x21EC520 Offset: 0x21EAF20 VA: 0x1821EC520
	public int get_PreferredHeight() { }

	// RVA: 0x21EC590 Offset: 0x21EAF90 VA: 0x1821EC590
	public bool get_ReadOnly() { }

	// RVA: 0x21ED2A0 Offset: 0x21EBCA0 VA: 0x1821ED2A0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x21EC5A0 Offset: 0x21EAFA0 VA: 0x1821EC5A0 Slot: 197
	public virtual string get_SelectedText() { }

	// RVA: 0x21ED390 Offset: 0x21EBD90 VA: 0x1821ED390 Slot: 198
	public virtual void set_SelectedText(string value) { }

	// RVA: 0x21EC5D0 Offset: 0x21EAFD0 VA: 0x1821EC5D0 Slot: 199
	public virtual int get_SelectionLength() { }

	// RVA: 0x21ED470 Offset: 0x21EBE70 VA: 0x1821ED470 Slot: 200
	public virtual void set_SelectionLength(int value) { }

	// RVA: 0x21ED670 Offset: 0x21EC070 VA: 0x1821ED670
	public void set_SelectionStart(int value) { }

	// RVA: 0x21EC680 Offset: 0x21EB080 VA: 0x1821EC680 Slot: 69
	public override string get_Text() { }

	// RVA: 0x21ED800 Offset: 0x21EC200 VA: 0x1821ED800 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x21EC620 Offset: 0x21EB020 VA: 0x1821EC620 Slot: 201
	public virtual int get_TextLength() { }

	// RVA: 0x21EC7E0 Offset: 0x21EB1E0 VA: 0x1821EC7E0
	public bool get_WordWrap() { }

	// RVA: 0x21EDA00 Offset: 0x21EC400 VA: 0x1821EDA00
	public void set_WordWrap(bool value) { }

	// RVA: 0x726440 Offset: 0x724E40 VA: 0x180726440 Slot: 45
	public override ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x21D0CE0 Offset: 0x21CF6E0 VA: 0x1821D0CE0 Slot: 46
	public override void set_BackgroundImageLayout(ImageLayout value) { }

	// RVA: 0x21EC270 Offset: 0x21EAC70 VA: 0x1821EC270 Slot: 73
	protected override Cursor get_DefaultCursor() { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21EC280 Offset: 0x21EAC80 VA: 0x1821EC280 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 61
	protected override bool get_DoubleBuffered() { }

	// RVA: 0x21E6620 Offset: 0x21E5020 VA: 0x1821E6620
	public void Copy() { }

	// RVA: 0x21E6840 Offset: 0x21E5240 VA: 0x1821E6840
	public void Cut() { }

	// RVA: 0x21E8A10 Offset: 0x21E7410 VA: 0x1821E8A10
	public void Paste() { }

	// RVA: 0x21E9D30 Offset: 0x21E8730 VA: 0x1821E9D30
	public void ScrollToCaret() { }

	// RVA: 0x21E9EC0 Offset: 0x21E88C0 VA: 0x1821E9EC0
	public void SelectAll() { }

	// RVA: 0x21E9DB0 Offset: 0x21E87B0 VA: 0x1821E9DB0
	internal void SelectAllNoScroll() { }

	// RVA: 0x21EB210 Offset: 0x21E9C10 VA: 0x1821EB210 Slot: 3
	public override string ToString() { }

	[MonoInternalNote("Deleting is classed as Typing, instead of its own Undo event")]
	// RVA: 0x21EB280 Offset: 0x21E9C80 VA: 0x1821EB280
	public void Undo() { }

	// RVA: 0x21E67F0 Offset: 0x21E51F0 VA: 0x1821E67F0 Slot: 89
	protected override void CreateHandle() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 202
	internal virtual void HandleLinkClicked(TextBoxBase.LinkRectangle link_clicked) { }

	// RVA: 0x21E7910 Offset: 0x21E6310 VA: 0x1821E7910 Slot: 96
	protected override bool IsInputKey(Keys keyData) { }

	// RVA: 0x21E7A00 Offset: 0x21E6400 VA: 0x1821E7A00 Slot: 203
	protected virtual void OnBorderStyleChanged(EventArgs e) { }

	// RVA: 0x21E7AE0 Offset: 0x21E64E0 VA: 0x1821E7AE0 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x21E7B50 Offset: 0x21E6550 VA: 0x1821E7B50 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x21CDD00 Offset: 0x21CC700 VA: 0x1821CDD00 Slot: 141
	protected override void OnHandleDestroyed(EventArgs e) { }

	// RVA: 0x21E7BF0 Offset: 0x21E65F0 VA: 0x1821E7BF0 Slot: 204
	protected virtual void OnHideSelectionChanged(EventArgs e) { }

	// RVA: 0x21E7CD0 Offset: 0x21E66D0 VA: 0x1821E7CD0 Slot: 205
	protected virtual void OnModifiedChanged(EventArgs e) { }

	// RVA: 0x21E7DC0 Offset: 0x21E67C0 VA: 0x1821E7DC0 Slot: 206
	protected virtual void OnMultilineChanged(EventArgs e) { }

	// RVA: 0x21E2040 Offset: 0x21E0A40 VA: 0x1821E2040 Slot: 164
	protected override void OnPaddingChanged(EventArgs e) { }

	// RVA: 0x21E7FB0 Offset: 0x21E69B0 VA: 0x1821E7FB0 Slot: 207
	protected virtual void OnReadOnlyChanged(EventArgs e) { }

	// RVA: 0x21E8F60 Offset: 0x21E7960 VA: 0x1821E8F60 Slot: 98
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData) { }

	// RVA: 0x21E8F70 Offset: 0x21E7970 VA: 0x1821E8F70 Slot: 100
	protected override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x21E8FA0 Offset: 0x21E79A0 VA: 0x1821E8FA0
	private bool ProcessKey(Keys keyData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 208
	internal virtual void RaiseSelectionChanged() { }

	// RVA: 0x21E6D30 Offset: 0x21E5730 VA: 0x1821E6D30
	private void HandleBackspace(bool control) { }

	// RVA: 0x21E73F0 Offset: 0x21E5DF0 VA: 0x1821E73F0
	private void HandleEnter() { }

	// RVA: 0x21EA230 Offset: 0x21E8C30 VA: 0x1821EA230 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x21EB330 Offset: 0x21E9D30 VA: 0x1821EB330 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 78
	internal override bool get_ScaleChildrenInternal() { }

	// RVA: 0x21EC600 Offset: 0x21EB000 VA: 0x1821EC600
	internal bool get_ShowSelection() { }

	// RVA: 0x21ED7C0 Offset: 0x21EC1C0 VA: 0x1821ED7C0
	internal void set_ShowSelection(bool value) { }

	// RVA: 0x21EC7B0 Offset: 0x21EB1B0 VA: 0x1821EC7B0
	internal int get_TopMargin() { }

	// RVA: 0x21ED9D0 Offset: 0x21EC3D0 VA: 0x1821ED9D0
	internal void set_TopMargin(int value) { }

	// RVA: 0x21E67C0 Offset: 0x21E51C0 VA: 0x1821E67C0
	internal Graphics CreateGraphicsInternal() { }

	// RVA: 0x21E7EA0 Offset: 0x21E68A0 VA: 0x1821E7EA0 Slot: 167
	internal override void OnPaintInternal(PaintEventArgs pevent) { }

	// RVA: 0x21E6AF0 Offset: 0x21E54F0 VA: 0x1821E6AF0
	internal void Draw(Graphics g, Rectangle clippingArea) { }

	// RVA: 0x21E6BF0 Offset: 0x21E55F0 VA: 0x1821E6BF0
	private void FixupHeight() { }

	// RVA: 0x21E76C0 Offset: 0x21E60C0 VA: 0x1821E76C0
	private bool IsDoubleClick(MouseEventArgs e) { }

	// RVA: 0x21EA6F0 Offset: 0x21E90F0 VA: 0x1821EA6F0
	private void TextBoxBase_MouseDown(object sender, MouseEventArgs e) { }

	// RVA: 0x21EAFC0 Offset: 0x21E99C0 VA: 0x1821EAFC0
	private void TextBoxBase_MouseUp(object sender, MouseEventArgs e) { }

	// RVA: 0x21EA320 Offset: 0x21E8D20 VA: 0x1821EA320
	private void SizeControls() { }

	// RVA: 0x21E8A40 Offset: 0x21E7440 VA: 0x1821E8A40
	private void PositionControls() { }

	// RVA: 0x21E6C80 Offset: 0x21E5680 VA: 0x1821E6C80
	internal RightToLeft GetInheritedRtoL() { }

	// RVA: 0x21EB1E0 Offset: 0x21E9BE0 VA: 0x1821EB1E0
	private void TextBoxBase_SizeChanged(object sender, EventArgs e) { }

	// RVA: 0x21EB1E0 Offset: 0x21E9BE0 VA: 0x1821EB1E0
	private void TextBoxBase_RightToLeftChanged(object o, EventArgs e) { }

	// RVA: 0x21EB090 Offset: 0x21E9A90 VA: 0x1821EB090
	private void TextBoxBase_MouseWheel(object sender, MouseEventArgs e) { }

	// RVA: 0x21E9FF0 Offset: 0x21E89F0 VA: 0x1821E9FF0 Slot: 209
	internal virtual void SelectWord() { }

	// RVA: 0x21E5D80 Offset: 0x21E4780 VA: 0x1821E5D80
	internal void CalculateDocument() { }

	// RVA: 0x21E5E40 Offset: 0x21E4840 VA: 0x1821E5E40
	internal void CalculateScrollBars() { }

	// RVA: 0x21EC210 Offset: 0x21EAC10 VA: 0x1821EC210
	private void document_WidthChanged(object sender, EventArgs e) { }

	// RVA: 0x21EC210 Offset: 0x21EAC10 VA: 0x1821EC210
	private void document_HeightChanged(object sender, EventArgs e) { }

	// RVA: 0x21E9970 Offset: 0x21E8370 VA: 0x1821E9970
	private void ScrollLinks(int xChange, int yChange) { }

	// RVA: 0x21EC7F0 Offset: 0x21EB1F0 VA: 0x1821EC7F0
	private void hscroll_ValueChanged(object sender, EventArgs e) { }

	// RVA: 0x21EDA50 Offset: 0x21EC450 VA: 0x1821EDA50
	private void vscroll_ValueChanged(object sender, EventArgs e) { }

	// RVA: 0x21EAAB0 Offset: 0x21E94B0 VA: 0x1821EAAB0
	private void TextBoxBase_MouseMove(object sender, MouseEventArgs e) { }

	// RVA: 0x21EA4B0 Offset: 0x21E8EB0 VA: 0x1821EA4B0
	private void TextBoxBase_FontOrColorChanged(object sender, EventArgs e) { }

	// RVA: 0x21E9BA0 Offset: 0x21E85A0 VA: 0x1821E9BA0
	private void ScrollTimerTickHandler(object sender, EventArgs e) { }

	// RVA: 0x21E6210 Offset: 0x21E4C10 VA: 0x1821E6210
	internal void CaretMoved(object sender, EventArgs e) { }

	// RVA: 0x21E8160 Offset: 0x21E6B60 VA: 0x1821E8160
	internal bool Paste(IDataObject clip, DataFormats.Format format, bool obey_length) { }

	// RVA: 0x21E6600 Offset: 0x21E5000 VA: 0x1821E6600 Slot: 210
	internal virtual Color ChangeBackColor(Color backColor) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 95
	internal override bool IsInputCharInternal(char charCode) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 211
	internal virtual void OnTextUpdate() { }

	// RVA: 0x21CF480 Offset: 0x21CDE80 VA: 0x1821CF480 Slot: 189
	protected override void OnTextChanged(EventArgs e) { }

	// RVA: 0x21E7DB0 Offset: 0x21E67B0 VA: 0x1821E7DB0 Slot: 160
	protected override void OnMouseUp(MouseEventArgs mevent) { }
}
