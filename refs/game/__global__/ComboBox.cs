public class ComboBox : ListControl // TypeDefIndex: 5277
{
	// Fields
	private DrawMode draw_mode; // 0x228
	private ComboBoxStyle dropdown_style; // 0x22C
	private int dropdown_width; // 0x230
	private int selected_index; // 0x234
	private ComboBox.ObjectCollection items; // 0x238
	private bool suspend_ctrlupdate; // 0x240
	private int maxdrop_items; // 0x244
	private bool integral_height; // 0x248
	private bool sorted; // 0x249
	private ComboBox.ComboListBox listbox_ctrl; // 0x250
	private ComboBox.ComboTextBox textbox_ctrl; // 0x258
	private bool process_textchanged_event; // 0x260
	private bool process_texchanged_autoscroll; // 0x261
	private bool item_height_specified; // 0x262
	private int item_height; // 0x264
	private int requested_height; // 0x268
	private Hashtable item_heights; // 0x270
	private bool show_dropdown_button; // 0x278
	private ButtonState button_state; // 0x27C
	private bool dropped_down; // 0x280
	private Rectangle text_area; // 0x284
	private Rectangle button_area; // 0x294
	private Rectangle listbox_area; // 0x2A4
	private bool drop_down_button_entered; // 0x2B4
	private AutoCompleteStringCollection auto_complete_custom_source; // 0x2B8
	private AutoCompleteMode auto_complete_mode; // 0x2C0
	private AutoCompleteSource auto_complete_source; // 0x2C4
	private FlatStyle flat_style; // 0x2C8
	private int drop_down_height; // 0x2CC
	private static object DrawItemEvent; // 0x0
	private static object DropDownEvent; // 0x8
	private static object DropDownStyleChangedEvent; // 0x10
	private static object MeasureItemEvent; // 0x18
	private static object SelectedIndexChangedEvent; // 0x20
	private static object SelectionChangeCommittedEvent; // 0x28
	private static object DropDownClosedEvent; // 0x30
	private static object TextUpdateEvent; // 0x38

	// Properties
	public override Color BackColor { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Image BackgroundImage { get; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override ImageLayout BackgroundImageLayout { get; set; }
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }
	[RefreshProperties(2)]
	[MWFCategory("Behavior")]
	[DefaultValue(0)]
	public DrawMode DrawMode { get; set; }
	[DefaultValue(106)]
	[MWFCategory("Behavior")]
	[EditorBrowsable(0)]
	[Browsable(True)]
	public int DropDownHeight { get; }
	[RefreshProperties(2)]
	[DefaultValue(1)]
	[MWFCategory("Appearance")]
	public ComboBoxStyle DropDownStyle { get; set; }
	[MWFCategory("Behavior")]
	public int DropDownWidth { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool DroppedDown { get; }
	[DefaultValue(2)]
	[Localizable(True)]
	[MWFCategory("Appearance")]
	public FlatStyle FlatStyle { get; }
	public override bool Focused { get; }
	public override Color ForeColor { get; set; }
	[Localizable(True)]
	[DefaultValue(True)]
	[MWFCategory("Behavior")]
	public bool IntegralHeight { get; }
	[Localizable(True)]
	[MWFCategory("Behavior")]
	public int ItemHeight { get; }
	[DesignerSerializationVisibility(2)]
	[MergableProperty(False)]
	[MWFCategory("Data")]
	[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(True)]
	public ComboBox.ObjectCollection Items { get; }
	[Localizable(True)]
	[DefaultValue(8)]
	[MWFCategory("Behavior")]
	public int MaxDropDownItems { get; set; }
	public override Size MaximumSize { get; }
	public override Size MinimumSize { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int PreferredHeight { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override int SelectedIndex { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[Bindable(True)]
	public object SelectedItem { get; set; }
	[MWFCategory("Behavior")]
	[DefaultValue(False)]
	public bool Sorted { get; }
	[Bindable(True)]
	[Localizable(True)]
	public override string Text { get; set; }
	internal Rectangle ButtonArea { get; }
	internal Rectangle TextArea { get; }
	internal override bool InternalCapture { get; set; }
	internal bool DropDownButtonEntered { get; set; }
	internal override ContextMenu ContextMenuInternal { get; set; }

	// Methods

	// RVA: 0x21D0460 Offset: 0x21CEE60 VA: 0x1821D0460
	public void .ctor() { }

	// RVA: 0x21D0200 Offset: 0x21CEC00 VA: 0x1821D0200
	private static void .cctor() { }

	// RVA: 0x21D0800 Offset: 0x21CF200 VA: 0x1821D0800
	public void add_SelectedIndexChanged(EventHandler value) { }

	// RVA: 0x21D0BA0 Offset: 0x21CF5A0 VA: 0x1821D0BA0
	public void remove_SelectedIndexChanged(EventHandler value) { }

	// RVA: 0x21CFBE0 Offset: 0x21CE5E0 VA: 0x1821CFBE0
	private void SetTextBoxAutoCompleteData() { }

	// RVA: 0x21C7A10 Offset: 0x21C6410 VA: 0x1821C7A10 Slot: 42
	public override Color get_BackColor() { }

	// RVA: 0x21D0C30 Offset: 0x21CF630 VA: 0x1821D0C30 Slot: 43
	public override void set_BackColor(Color value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0 Slot: 44
	public override Image get_BackgroundImage() { }

	// RVA: 0x726440 Offset: 0x724E40 VA: 0x180726440 Slot: 45
	public override ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x21D0CE0 Offset: 0x21CF6E0 VA: 0x1821D0CE0 Slot: 46
	public override void set_BackgroundImageLayout(ImageLayout value) { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21D08A0 Offset: 0x21CF2A0 VA: 0x1821D08A0 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x1A3C110 Offset: 0x1A3AB10 VA: 0x181A3C110
	public DrawMode get_DrawMode() { }

	// RVA: 0x21D0D40 Offset: 0x21CF740 VA: 0x1821D0D40
	public void set_DrawMode(DrawMode value) { }

	// RVA: 0x21D08E0 Offset: 0x21CF2E0 VA: 0x1821D08E0
	public int get_DropDownHeight() { }

	// RVA: 0x1A3C120 Offset: 0x1A3AB20 VA: 0x181A3C120
	public ComboBoxStyle get_DropDownStyle() { }

	// RVA: 0x21D1010 Offset: 0x21CFA10 VA: 0x1821D1010
	public void set_DropDownStyle(ComboBoxStyle value) { }

	// RVA: 0x21D08F0 Offset: 0x21CF2F0 VA: 0x1821D08F0
	public int get_DropDownWidth() { }

	// RVA: 0x21D0910 Offset: 0x21CF310 VA: 0x1821D0910
	public bool get_DroppedDown() { }

	// RVA: 0x21D0930 Offset: 0x21CF330 VA: 0x1821D0930
	public FlatStyle get_FlatStyle() { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90 Slot: 62
	public override bool get_Focused() { }

	// RVA: 0x21D0940 Offset: 0x21CF340 VA: 0x1821D0940 Slot: 65
	public override Color get_ForeColor() { }

	// RVA: 0x21D16E0 Offset: 0x21D00E0 VA: 0x1821D16E0 Slot: 66
	public override void set_ForeColor(Color value) { }

	// RVA: 0x640EC0 Offset: 0x63F8C0 VA: 0x180640EC0
	public bool get_IntegralHeight() { }

	// RVA: 0x21D0970 Offset: 0x21CF370 VA: 0x1821D0970
	public int get_ItemHeight() { }

	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	public ComboBox.ObjectCollection get_Items() { }

	// RVA: 0x21D09F0 Offset: 0x21CF3F0 VA: 0x1821D09F0
	public int get_MaxDropDownItems() { }

	// RVA: 0x21D1790 Offset: 0x21D0190 VA: 0x1821D1790
	public void set_MaxDropDownItems(int value) { }

	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380 Slot: 39
	public override Size get_MaximumSize() { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290 Slot: 40
	public override Size get_MinimumSize() { }

	// RVA: 0x21D17A0 Offset: 0x21D01A0 VA: 0x1821D17A0 Slot: 41
	public override void set_MinimumSize(Size value) { }

	// RVA: 0x21D0A00 Offset: 0x21CF400 VA: 0x1821D0A00
	public int get_PreferredHeight() { }

	// RVA: 0x21D0A40 Offset: 0x21CF440 VA: 0x1821D0A40 Slot: 193
	public override int get_SelectedIndex() { }

	// RVA: 0x21D17E0 Offset: 0x21D01E0 VA: 0x1821D17E0 Slot: 194
	public override void set_SelectedIndex(int value) { }

	// RVA: 0x21D0A50 Offset: 0x21CF450 VA: 0x1821D0A50
	public object get_SelectedItem() { }

	// RVA: 0x21D17F0 Offset: 0x21D01F0 VA: 0x1821D17F0
	public void set_SelectedItem(object value) { }

	// RVA: 0x640ED0 Offset: 0x63F8D0 VA: 0x180640ED0
	public bool get_Sorted() { }

	// RVA: 0x21D0AB0 Offset: 0x21CF4B0 VA: 0x1821D0AB0 Slot: 69
	public override string get_Text() { }

	// RVA: 0x21D18B0 Offset: 0x21D02B0 VA: 0x1821D18B0 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x21D0890 Offset: 0x21CF290 VA: 0x1821D0890
	internal Rectangle get_ButtonArea() { }

	// RVA: 0x21D0AA0 Offset: 0x21CF4A0 VA: 0x1821D0AA0
	internal Rectangle get_TextArea() { }

	// RVA: 0x21CC080 Offset: 0x21CAA80 VA: 0x1821CC080
	public void BeginUpdate() { }

	// RVA: 0x21CC130 Offset: 0x21CAB30 VA: 0x1821CC130 Slot: 89
	protected override void CreateHandle() { }

	// RVA: 0x21CC140 Offset: 0x21CAB40 VA: 0x1821CC140 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21CC970 Offset: 0x21CB370 VA: 0x1821CC970
	public void EndUpdate() { }

	// RVA: 0x21CCD20 Offset: 0x21CB720 VA: 0x1821CCD20
	private int FindStringExact(string s, int startIndex, bool ignoreCase) { }

	// RVA: 0x21CCEF0 Offset: 0x21CB8F0 VA: 0x1821CCEF0
	public int GetItemHeight(int index) { }

	// RVA: 0x21CD260 Offset: 0x21CBC60 VA: 0x1821CD260 Slot: 96
	protected override bool IsInputKey(Keys keyData) { }

	// RVA: 0x21CD640 Offset: 0x21CC040 VA: 0x1821CD640 Slot: 116
	protected override void OnBackColorChanged(EventArgs e) { }

	// RVA: 0x21CD6C0 Offset: 0x21CC0C0 VA: 0x1821CD6C0 Slot: 201
	protected virtual void OnDrawItem(DrawItemEventArgs e) { }

	// RVA: 0x21CD170 Offset: 0x21CBB70 VA: 0x1821CD170
	internal void HandleDrawItem(DrawItemEventArgs e) { }

	// RVA: 0x21CD950 Offset: 0x21CC350 VA: 0x1821CD950 Slot: 202
	protected virtual void OnDropDown(EventArgs e) { }

	// RVA: 0x21CD790 Offset: 0x21CC190 VA: 0x1821CD790 Slot: 203
	protected virtual void OnDropDownClosed(EventArgs e) { }

	// RVA: 0x21CD870 Offset: 0x21CC270 VA: 0x1821CD870 Slot: 204
	protected virtual void OnDropDownStyleChanged(EventArgs e) { }

	// RVA: 0x21CDA30 Offset: 0x21CC430 VA: 0x1821CDA30 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x21CDAF0 Offset: 0x21CC4F0 VA: 0x1821CDAF0 Slot: 137
	protected override void OnForeColorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CDB70 Offset: 0x21CC570 VA: 0x1821CDB70 Slot: 139
	protected override void OnGotFocus(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CE790 Offset: 0x21CD190 VA: 0x1821CE790 Slot: 151
	protected override void OnLostFocus(EventArgs e) { }

	// RVA: 0x21CDC10 Offset: 0x21CC610 VA: 0x1821CDC10 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x21CDD00 Offset: 0x21CC700 VA: 0x1821CDD00 Slot: 141
	protected override void OnHandleDestroyed(EventArgs e) { }

	// RVA: 0x21CE440 Offset: 0x21CCE40 VA: 0x1821CE440 Slot: 146
	protected override void OnKeyPress(KeyPressEventArgs e) { }

	// RVA: 0x21CE870 Offset: 0x21CD270 VA: 0x1821CE870 Slot: 205
	protected virtual void OnMeasureItem(MeasureItemEventArgs e) { }

	// RVA: 0x21CF130 Offset: 0x21CDB30 VA: 0x1821CF130 Slot: 169
	protected override void OnParentBackColorChanged(EventArgs e) { }

	// RVA: 0x21CF140 Offset: 0x21CDB40 VA: 0x1821CF140 Slot: 181
	protected override void OnResize(EventArgs e) { }

	// RVA: 0x21CF180 Offset: 0x21CDB80 VA: 0x1821CF180 Slot: 197
	protected override void OnSelectedIndexChanged(EventArgs e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 206
	protected virtual void OnSelectedItemChanged(EventArgs e) { }

	// RVA: 0x21CF260 Offset: 0x21CDC60 VA: 0x1821CF260 Slot: 198
	protected override void OnSelectedValueChanged(EventArgs e) { }

	// RVA: 0x21CF270 Offset: 0x21CDC70 VA: 0x1821CF270 Slot: 207
	protected virtual void OnSelectionChangeCommitted(EventArgs e) { }

	// RVA: 0x21CF5C0 Offset: 0x21CDFC0 VA: 0x1821CF5C0 Slot: 199
	protected override void RefreshItem(int index) { }

	// RVA: 0x21CF5B0 Offset: 0x21CDFB0 VA: 0x1821CF5B0 Slot: 101
	protected override bool ProcessKeyEventArgs(ref Message m) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CE430 Offset: 0x21CCE30 VA: 0x1821CE430 Slot: 145
	protected override void OnKeyDown(KeyEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CF5A0 Offset: 0x21CDFA0 VA: 0x1821CF5A0 Slot: 191
	protected override void OnValidating(CancelEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CF480 Offset: 0x21CDE80 VA: 0x1821CF480 Slot: 189
	protected override void OnTextChanged(EventArgs e) { }

	// RVA: 0x21CF4C0 Offset: 0x21CDEC0 VA: 0x1821CF4C0 Slot: 208
	protected virtual void OnTextUpdate(EventArgs e) { }

	// RVA: 0x21CED30 Offset: 0x21CD730 VA: 0x1821CED30 Slot: 158
	protected override void OnMouseLeave(EventArgs e) { }

	// RVA: 0x21CEB50 Offset: 0x21CD550 VA: 0x1821CEB50 Slot: 156
	protected override void OnMouseEnter(EventArgs e) { }

	// RVA: 0x21CF6E0 Offset: 0x21CE0E0 VA: 0x1821CF6E0 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x21CF6F0 Offset: 0x21CE0F0 VA: 0x1821CF6F0 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x21CF900 Offset: 0x21CE300 VA: 0x1821CF900 Slot: 200
	protected override void SetItemsCore(IList value) { }

	// RVA: 0x21CFE60 Offset: 0x21CE860 VA: 0x1821CFE60 Slot: 3
	public override string ToString() { }

	// RVA: 0x21CFFF0 Offset: 0x21CE9F0 VA: 0x1821CFFF0 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0xC0DCB0 Offset: 0xC0C6B0 VA: 0x180C0DCB0 Slot: 50
	internal override bool get_InternalCapture() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 51
	internal override void set_InternalCapture(bool value) { }

	// RVA: 0x21CD2B0 Offset: 0x21CBCB0 VA: 0x1821CD2B0
	private void LayoutComboBox() { }

	// RVA: 0x21CC090 Offset: 0x21CAA90 VA: 0x1821CC090
	private void CreateComboListBox() { }

	// RVA: 0x21CC230 Offset: 0x21CAC30 VA: 0x1821CC230
	internal void Draw(Rectangle clip, Graphics dc) { }

	// RVA: 0x21D08D0 Offset: 0x21CF2D0 VA: 0x1821D08D0
	internal bool get_DropDownButtonEntered() { }

	// RVA: 0x21D0F20 Offset: 0x21CF920 VA: 0x1821D0F20
	private void set_DropDownButtonEntered(bool value) { }

	// RVA: 0x21CC840 Offset: 0x21CB240 VA: 0x1821CC840
	internal void DropDownListBox() { }

	// RVA: 0x21CC720 Offset: 0x21CB120 VA: 0x1821CC720
	internal void DropDownListBoxFinished() { }

	// RVA: 0x21CCC20 Offset: 0x21CB620 VA: 0x1821CCC20
	private int FindStringCaseInsensitive(string search) { }

	// RVA: 0x21CCA90 Offset: 0x21CB490 VA: 0x1821CCA90
	internal int FindStringCaseInsensitive(string search, int start_index) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 95
	internal override bool IsInputCharInternal(char charCode) { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 54
	internal override ContextMenu get_ContextMenuInternal() { }

	// RVA: 0x21D0CF0 Offset: 0x21CF6F0 VA: 0x1821D0CF0 Slot: 55
	internal override void set_ContextMenuInternal(ContextMenu value) { }

	// RVA: 0x21CF6B0 Offset: 0x21CE0B0 VA: 0x1821CF6B0
	internal void RestoreContextMenu() { }

	// RVA: 0x21CDD10 Offset: 0x21CC710 VA: 0x1821CDD10
	private void OnKeyDownCB(object sender, KeyEventArgs e) { }

	// RVA: 0x21CF9A0 Offset: 0x21CE3A0 VA: 0x1821CF9A0
	private void SetSelectedIndex(int value, bool supressAutoScroll) { }

	// RVA: 0x21CC9F0 Offset: 0x21CB3F0 VA: 0x1821CC9F0
	private void FindMatchOrSetIndex(int index) { }

	// RVA: 0x21CE950 Offset: 0x21CD350 VA: 0x1821CE950
	private void OnMouseDownCB(object sender, MouseEventArgs e) { }

	// RVA: 0x21CEA90 Offset: 0x21CD490 VA: 0x1821CEA90
	private void OnMouseEnter(object sender, EventArgs e) { }

	// RVA: 0x21CEB90 Offset: 0x21CD590 VA: 0x1821CEB90
	private void OnMouseLeave(object sender, EventArgs e) { }

	// RVA: 0x21CED70 Offset: 0x21CD770 VA: 0x1821CED70
	private void OnMouseMoveCB(object sender, MouseEventArgs e) { }

	// RVA: 0x21CEEB0 Offset: 0x21CD8B0 VA: 0x1821CEEB0
	private void OnMouseUpCB(object sender, MouseEventArgs e) { }

	// RVA: 0x21CEF80 Offset: 0x21CD980 VA: 0x1821CEF80
	private void OnMouseWheelCB(object sender, MouseEventArgs me) { }

	// RVA: 0x21CF0D0 Offset: 0x21CDAD0 VA: 0x1821CF0D0 Slot: 167
	internal override void OnPaintInternal(PaintEventArgs pevent) { }

	// RVA: 0x21CF350 Offset: 0x21CDD50 VA: 0x1821CF350
	private void OnTextBoxClick(object sender, EventArgs e) { }

	// RVA: 0x21CF370 Offset: 0x21CDD70 VA: 0x1821CF370
	private void OnTextChangedEdit(object sender, EventArgs e) { }

	// RVA: 0x21CF490 Offset: 0x21CDE90 VA: 0x1821CF490
	private void OnTextKeyPress(object sender, KeyPressEventArgs e) { }

	// RVA: 0x21CF830 Offset: 0x21CE230 VA: 0x1821CF830
	internal void SetControlText(string s, bool suppressTextChanged) { }

	// RVA: 0x21CF890 Offset: 0x21CE290 VA: 0x1821CF890
	internal void SetControlText(string s, bool suppressTextChanged, bool supressAutoScroll) { }

	// RVA: 0x21CFEF0 Offset: 0x21CE8F0 VA: 0x1821CFEF0
	private void UpdateComboBoxBounds() { }

	// RVA: 0x21CFCE0 Offset: 0x21CE6E0 VA: 0x1821CFCE0
	private int SnapHeight(int height) { }

	// RVA: 0x21CFF80 Offset: 0x21CE980 VA: 0x1821CFF80
	private void UpdatedItems() { }
}
