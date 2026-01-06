internal class ThemeWin32Classic : Theme // TypeDefIndex: 5598
{
	// Fields
	protected static readonly Color arrow_color; // 0x0
	protected static readonly Color pen_ticks_color; // 0x18
	protected static StringFormat string_format_menu_text; // 0x30
	protected static StringFormat string_format_menu_shortcut; // 0x38
	protected static StringFormat string_format_menu_menubar_text; // 0x40
	private static ImageAttributes imagedisabled_attributes; // 0x48

	// Properties
	public override bool DoubleBufferingSupported { get; }
	public override int HorizontalScrollBarHeight { get; }
	public override int VerticalScrollBarWidth { get; }
	public override Size ButtonBaseDefaultSize { get; }
	public override Size GroupBoxDefaultSize { get; }
	public override Size HScrollBarDefaultSize { get; }
	public override bool ListViewHasHotHeaderStyle { get; }
	public override Size ListViewCheckBoxSize { get; }
	public override int ListViewDefaultColumnWidth { get; }
	public override int ListViewVerticalSpacing { get; }
	public override int ListViewEmptyColumnWidth { get; }
	public override int ListViewHorizontalSpacing { get; }
	public override int ListViewItemPaddingWidth { get; }
	public override Size ListViewDefaultSize { get; }
	public int ListViewGroupLineWidth { get; }
	public override int ListViewTileWidthFactor { get; }
	public override int ListViewTileHeightFactor { get; }
	public override Size PanelDefaultSize { get; }
	public override Size PictureBoxDefaultSize { get; }
	public override int ScrollBarButtonSize { get; }
	public override bool ScrollBarHasHotElementStyles { get; }
	public override bool ScrollBarHasPressedThumbStyle { get; }
	public override bool ScrollBarHasHoverArrowButtonStyle { get; }
	public override int ToolBarGripWidth { get; }
	public override int ToolBarImageGripWidth { get; }
	public override int ToolBarSeparatorWidth { get; }
	public override int ToolBarDropDownWidth { get; }
	public override int ToolBarDropDownArrowWidth { get; }
	public override int ToolBarDropDownArrowHeight { get; }
	public override Size ToolBarDefaultSize { get; }
	public override bool ToolBarHasHotCheckedElementStyles { get; }
	public override bool ToolTipTransparentBackground { get; }
	public override Size VScrollBarDefaultSize { get; }

	// Methods

	// RVA: 0x22170C0 Offset: 0x2215AC0 VA: 0x1822170C0
	public void .ctor() { }

	// RVA: 0x2216FE0 Offset: 0x22159E0 VA: 0x182216FE0
	private static void .cctor() { }

	// RVA: 0x2216600 Offset: 0x2215000 VA: 0x182216600 Slot: 56
	public override void ResetDefaults() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 57
	public override bool get_DoubleBufferingSupported() { }

	// RVA: 0x2217540 Offset: 0x2215F40 VA: 0x182217540 Slot: 43
	public override int get_HorizontalScrollBarHeight() { }

	// RVA: 0x22176A0 Offset: 0x22160A0 VA: 0x1822176A0 Slot: 52
	public override int get_VerticalScrollBarWidth() { }

	// RVA: 0x22143D0 Offset: 0x2212DD0 VA: 0x1822143D0
	protected Brush GetControlBackBrush(Color c) { }

	// RVA: 0x22144D0 Offset: 0x2212ED0 VA: 0x1822144D0
	protected Brush GetControlForeBrush(Color c) { }

	// RVA: 0x22082A0 Offset: 0x2206CA0 VA: 0x1822082A0 Slot: 60
	public override void DrawButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle) { }

	// RVA: 0x22078A0 Offset: 0x22062A0 VA: 0x1822078A0 Slot: 149
	public virtual void DrawButtonBackground(Graphics g, Button button, Rectangle clipArea) { }

	// RVA: 0x2207E80 Offset: 0x2206880 VA: 0x182207E80 Slot: 150
	public virtual void DrawButtonFocus(Graphics g, Button button) { }

	// RVA: 0x2207F40 Offset: 0x2206940 VA: 0x182207F40 Slot: 151
	public virtual void DrawButtonImage(Graphics g, ButtonBase button, Rectangle imageBounds) { }

	// RVA: 0x2208070 Offset: 0x2206A70 VA: 0x182208070 Slot: 152
	public virtual void DrawButtonText(Graphics g, ButtonBase button, Rectangle textBounds) { }

	// RVA: 0x220B4E0 Offset: 0x2209EE0 VA: 0x18220B4E0 Slot: 61
	public override void DrawFlatButton(Graphics g, ButtonBase b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle) { }

	// RVA: 0x220AD30 Offset: 0x2209730 VA: 0x18220AD30 Slot: 153
	public virtual void DrawFlatButtonBackground(Graphics g, ButtonBase button, Rectangle clipArea) { }

	// RVA: 0x220B260 Offset: 0x2209C60 VA: 0x18220B260 Slot: 154
	public virtual void DrawFlatButtonFocus(Graphics g, ButtonBase button) { }

	// RVA: 0x220B480 Offset: 0x2209E80 VA: 0x18220B480 Slot: 155
	public virtual void DrawFlatButtonImage(Graphics g, ButtonBase button, Rectangle imageBounds) { }

	// RVA: 0x220B4B0 Offset: 0x2209EB0 VA: 0x18220B4B0 Slot: 156
	public virtual void DrawFlatButtonText(Graphics g, ButtonBase button, Rectangle textBounds) { }

	// RVA: 0x2211E10 Offset: 0x2210810 VA: 0x182211E10 Slot: 62
	public override void DrawPopupButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle) { }

	// RVA: 0x22119B0 Offset: 0x22103B0 VA: 0x1822119B0 Slot: 157
	public virtual void DrawPopupButtonBackground(Graphics g, Button button, Rectangle clipArea) { }

	// RVA: 0x2211DF0 Offset: 0x22107F0 VA: 0x182211DF0 Slot: 158
	public virtual void DrawPopupButtonFocus(Graphics g, Button button) { }

	// RVA: 0x220B480 Offset: 0x2209E80 VA: 0x18220B480 Slot: 159
	public virtual void DrawPopupButtonImage(Graphics g, Button button, Rectangle imageBounds) { }

	// RVA: 0x220B4B0 Offset: 0x2209EB0 VA: 0x18220B4B0 Slot: 160
	public virtual void DrawPopupButtonText(Graphics g, Button button, Rectangle textBounds) { }

	// RVA: 0x2204A60 Offset: 0x2203460 VA: 0x182204A60 Slot: 58
	public override Size CalculateButtonAutoSize(Button button) { }

	// RVA: 0x2204D70 Offset: 0x2203770 VA: 0x182204D70 Slot: 59
	public override void CalculateButtonTextAndImageLayout(ButtonBase button, out Rectangle textRectangle, out Rectangle imageRectangle) { }

	// RVA: 0x2214F30 Offset: 0x2213930 VA: 0x182214F30
	private void LayoutTextBeforeOrAfterImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect) { }

	// RVA: 0x2214BA0 Offset: 0x22135A0 VA: 0x182214BA0
	private void LayoutTextAboveOrBelowImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect) { }

	// RVA: 0x22145D0 Offset: 0x2212FD0 VA: 0x1822145D0
	private HorizontalAlignment GetHorizontalAlignment(ContentAlignment align) { }

	// RVA: 0x2214620 Offset: 0x2213020 VA: 0x182214620
	private ThemeWin32Classic.VerticalAlignment GetVerticalAlignment(ContentAlignment align) { }

	// RVA: 0x21FE160 Offset: 0x21FCB60 VA: 0x1821FE160
	internal Rectangle AlignInRectangle(Rectangle outer, Size inner, ContentAlignment align) { }

	// RVA: 0x2207CE0 Offset: 0x22066E0 VA: 0x182207CE0 Slot: 63
	public override void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button) { }

	// RVA: 0x2216700 Offset: 0x2215100 VA: 0x182216700
	protected static bool ShouldPaintFocusRectagle(ButtonBase button) { }

	// RVA: 0x21FE320 Offset: 0x21FCD20 VA: 0x1821FE320 Slot: 161
	protected virtual void ButtonBase_DrawButton(ButtonBase button, Graphics dc) { }

	// RVA: 0x2214670 Offset: 0x2213070 VA: 0x182214670
	private void Internal_DrawButton(Graphics dc, Rectangle rect, int state, CPColor cpcolor, bool is_ColorControl, Color backcolor) { }

	// RVA: 0x21FF0B0 Offset: 0x21FDAB0 VA: 0x1821FF0B0 Slot: 162
	protected virtual void ButtonBase_DrawImage(ButtonBase button, Graphics dc) { }

	// RVA: 0x21FEDD0 Offset: 0x21FD7D0 VA: 0x1821FEDD0 Slot: 163
	protected virtual void ButtonBase_DrawFocus(ButtonBase button, Graphics dc) { }

	// RVA: 0x21FF3A0 Offset: 0x21FDDA0 VA: 0x1821FF3A0 Slot: 164
	protected virtual void ButtonBase_DrawText(ButtonBase button, Graphics dc) { }

	// RVA: 0x22174A0 Offset: 0x2215EA0 VA: 0x1822174A0 Slot: 64
	public override Size get_ButtonBaseDefaultSize() { }

	// RVA: 0x220A040 Offset: 0x2208A40 VA: 0x18220A040 Slot: 67
	public override void DrawCheckBox(Graphics g, CheckBox cb, Rectangle glyphArea, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle) { }

	// RVA: 0x2209510 Offset: 0x2207F10 VA: 0x182209510 Slot: 165
	public virtual void DrawCheckBoxGlyph(Graphics g, CheckBox cb, Rectangle glyphArea) { }

	// RVA: 0x22094A0 Offset: 0x2207EA0 VA: 0x1822094A0 Slot: 166
	public virtual void DrawCheckBoxFocus(Graphics g, CheckBox cb, Rectangle focusArea) { }

	// RVA: 0x2207F40 Offset: 0x2206940 VA: 0x182207F40 Slot: 167
	public virtual void DrawCheckBoxImage(Graphics g, CheckBox cb, Rectangle imageBounds) { }

	// RVA: 0x2209AB0 Offset: 0x22084B0 VA: 0x182209AB0 Slot: 168
	public virtual void DrawCheckBoxText(Graphics g, CheckBox cb, Rectangle textBounds) { }

	// RVA: 0x22055D0 Offset: 0x2203FD0 VA: 0x1822055D0 Slot: 66
	public override void CalculateCheckBoxTextAndImageLayout(ButtonBase button, Point p, out Rectangle glyphArea, out Rectangle textRectangle, out Rectangle imageRectangle) { }

	// RVA: 0x2205280 Offset: 0x2203C80 VA: 0x182205280 Slot: 65
	public override Size CalculateCheckBoxAutoSize(CheckBox checkBox) { }

	// RVA: 0x220A310 Offset: 0x2208D10 VA: 0x18220A310 Slot: 68
	public override void DrawCheckBox(Graphics dc, Rectangle clip_area, CheckBox checkbox) { }

	// RVA: 0x2205E20 Offset: 0x2204820 VA: 0x182205E20 Slot: 169
	protected virtual void CheckBox_DrawCheckBox(Graphics dc, CheckBox checkbox, ButtonState state, Rectangle checkbox_rectangle) { }

	// RVA: 0x2206170 Offset: 0x2204B70 VA: 0x182206170 Slot: 170
	protected virtual void CheckBox_DrawText(CheckBox checkbox, Rectangle text_rectangle, Graphics dc, StringFormat text_format) { }

	// RVA: 0x22060D0 Offset: 0x2204AD0 VA: 0x1822060D0 Slot: 171
	protected virtual void CheckBox_DrawFocus(CheckBox checkbox, Graphics dc, Rectangle text_rectangle) { }

	// RVA: 0x220B6D0 Offset: 0x220A0D0 VA: 0x18220B6D0 Slot: 172
	protected virtual void DrawFlatStyleCheckBox(Graphics graphics, Rectangle rectangle, CheckBox checkbox) { }

	// RVA: 0x2209C70 Offset: 0x2208670 VA: 0x182209C70
	private void DrawCheckBox_and_RadioButtonText(ButtonBase button_base, Rectangle text_rectangle, Graphics dc, StringFormat text_format, Appearance appearance, bool ischecked) { }

	// RVA: 0x220AA10 Offset: 0x2209410 VA: 0x18220AA10 Slot: 69
	public override void DrawComboBoxItem(ComboBox ctrl, DrawItemEventArgs e) { }

	// RVA: 0x220BE80 Offset: 0x220A880 VA: 0x18220BE80 Slot: 70
	public override void DrawFlatStyleComboButton(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x2206580 Offset: 0x2204F80 VA: 0x182206580 Slot: 71
	public override void ComboBoxDrawNormalDropDownButton(ComboBox comboBox, Graphics g, Rectangle clippingArea, Rectangle area, ButtonState state) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 72
	public override bool ComboBoxNormalDropDownButtonHasTransparentBackground(ComboBox comboBox, ButtonState state) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 73
	public override bool ComboBoxDropDownButtonHasHotElementStyle(ComboBox comboBox) { }

	// RVA: 0x2206210 Offset: 0x2204C10 VA: 0x182206210 Slot: 74
	public override void ComboBoxDrawBackground(ComboBox comboBox, Graphics g, Rectangle clippingArea, FlatStyle style) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 75
	public override bool CombBoxBackgroundHasHotElementStyle(ComboBox comboBox) { }

	// RVA: 0x220C1A0 Offset: 0x220ABA0 VA: 0x18220C1A0 Slot: 76
	public override void DrawGroupBox(Graphics dc, Rectangle area, GroupBox box) { }

	// RVA: 0x22174D0 Offset: 0x2215ED0 VA: 0x1822174D0 Slot: 77
	public override Size get_GroupBoxDefaultSize() { }

	// RVA: 0x2217500 Offset: 0x2215F00 VA: 0x182217500 Slot: 78
	public override Size get_HScrollBarDefaultSize() { }

	// RVA: 0x220EE40 Offset: 0x220D840 VA: 0x18220EE40 Slot: 79
	public override void DrawListViewItems(Graphics dc, Rectangle clip, ListView control) { }

	// RVA: 0x220D3C0 Offset: 0x220BDC0 VA: 0x18220D3C0 Slot: 80
	public override void DrawListViewHeader(Graphics dc, Rectangle clip, ListView control) { }

	// RVA: 0x2215280 Offset: 0x2213C80 VA: 0x182215280 Slot: 173
	protected virtual void ListViewDrawColumnHeaderBackground(ListView listView, ColumnHeader columnHeader, Graphics g, Rectangle area, Rectangle clippingArea) { }

	// RVA: 0x2215300 Offset: 0x2213D00 VA: 0x182215300 Slot: 174
	protected virtual void ListViewDrawUnusedHeaderBackground(ListView listView, Graphics g, Rectangle area, Rectangle clippingArea) { }

	// RVA: 0x220CFC0 Offset: 0x220B9C0 VA: 0x18220CFC0 Slot: 81
	public override void DrawListViewHeaderDragDetails(Graphics dc, ListView view, ColumnHeader col, int target_x) { }

	// RVA: 0x220C8F0 Offset: 0x220B2F0 VA: 0x18220C8F0 Slot: 175
	protected virtual bool DrawListViewColumnHeaderOwnerDraw(Graphics dc, ListView control, ColumnHeader column, Rectangle bounds) { }

	// RVA: 0x220DAC0 Offset: 0x220C4C0 VA: 0x18220DAC0 Slot: 176
	protected virtual bool DrawListViewItemOwnerDraw(Graphics dc, ListViewItem item, int index) { }

	// RVA: 0x220DD00 Offset: 0x220C700 VA: 0x18220DD00 Slot: 177
	protected virtual void DrawListViewItem(Graphics dc, ListView control, ListViewItem item) { }

	// RVA: 0x220FE80 Offset: 0x220E880 VA: 0x18220FE80 Slot: 178
	protected virtual void DrawListViewSubItems(Graphics dc, ListView control, ListViewItem item) { }

	// RVA: 0x220FA40 Offset: 0x220E440 VA: 0x18220FA40 Slot: 179
	protected virtual void DrawListViewSubItem(Graphics dc, ListView control, ListViewItem item, int index) { }

	// RVA: 0x220F890 Offset: 0x220E290 VA: 0x18220F890 Slot: 180
	protected virtual bool DrawListViewSubItemOwnerDraw(Graphics dc, ListViewItem item, ListViewItemStates state, int index) { }

	// RVA: 0x220CB40 Offset: 0x220B540 VA: 0x18220CB40 Slot: 181
	protected virtual void DrawListViewGroupHeader(Graphics dc, ListView control, ListViewGroup group) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 82
	public override bool get_ListViewHasHotHeaderStyle() { }

	// RVA: 0x2215380 Offset: 0x2213D80 VA: 0x182215380 Slot: 83
	public override int ListViewGetHeaderHeight(ListView listView, Font font) { }

	// RVA: 0x2215360 Offset: 0x2213D60 VA: 0x182215360
	private static int ListViewGetHeaderHeight(Font font) { }

	// RVA: 0x22153E0 Offset: 0x2213DE0 VA: 0x1822153E0
	public static int ListViewGetHeaderHeight() { }

	// RVA: 0x2217580 Offset: 0x2215F80 VA: 0x182217580 Slot: 84
	public override Size get_ListViewCheckBoxSize() { }

	// RVA: 0xF72A80 Offset: 0xF71480 VA: 0x180F72A80 Slot: 85
	public override int get_ListViewDefaultColumnWidth() { }

	// RVA: 0x22175F0 Offset: 0x2215FF0 VA: 0x1822175F0 Slot: 86
	public override int get_ListViewVerticalSpacing() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 87
	public override int get_ListViewEmptyColumnWidth() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 88
	public override int get_ListViewHorizontalSpacing() { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 90
	public override int get_ListViewItemPaddingWidth() { }

	// RVA: 0x22175B0 Offset: 0x2215FB0 VA: 0x1822175B0 Slot: 89
	public override Size get_ListViewDefaultSize() { }

	// RVA: 0x22175E0 Offset: 0x2215FE0 VA: 0x1822175E0
	public int get_ListViewGroupLineWidth() { }

	// RVA: 0x22175F0 Offset: 0x2215FF0 VA: 0x1822175F0 Slot: 91
	public override int get_ListViewTileWidthFactor() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 92
	public override int get_ListViewTileHeightFactor() { }

	// RVA: 0x22041C0 Offset: 0x2202BC0 VA: 0x1822041C0 Slot: 93
	public override void CalcItemSize(Graphics dc, MenuItem item, int y, int x, bool menuBar) { }

	// RVA: 0x2204500 Offset: 0x2202F00 VA: 0x182204500 Slot: 95
	public override int CalcMenuBarSize(Graphics dc, Menu menu, int width) { }

	// RVA: 0x2204820 Offset: 0x2203220 VA: 0x182204820 Slot: 94
	public override void CalcPopupMenuSize(Graphics dc, Menu menu) { }

	// RVA: 0x22105A0 Offset: 0x220EFA0 VA: 0x1822105A0 Slot: 96
	public override void DrawMenuBar(Graphics dc, Menu menu, Rectangle rect) { }

	// RVA: 0x22065C0 Offset: 0x2204FC0 VA: 0x1822065C0
	protected Bitmap CreateGlyphBitmap(Size size, MenuGlyph glyph, Color color) { }

	// RVA: 0x22108D0 Offset: 0x220F2D0 VA: 0x1822108D0 Slot: 97
	public override void DrawMenuItem(MenuItem item, DrawItemEventArgs e) { }

	// RVA: 0x2211FF0 Offset: 0x22109F0 VA: 0x182211FF0 Slot: 98
	public override void DrawPopupMenu(Graphics dc, Menu menu, Rectangle cliparea, Rectangle rect) { }

	// RVA: 0x22174D0 Offset: 0x2215ED0 VA: 0x1822174D0 Slot: 99
	public override Size get_PanelDefaultSize() { }

	// RVA: 0x2211550 Offset: 0x220FF50 VA: 0x182211550 Slot: 100
	public override void DrawPictureBox(Graphics dc, Rectangle clip, PictureBox pb) { }

	// RVA: 0x2217600 Offset: 0x2216000 VA: 0x182217600 Slot: 101
	public override Size get_PictureBoxDefaultSize() { }

	// RVA: 0x2212260 Offset: 0x2210C60 VA: 0x182212260 Slot: 102
	public override void DrawScrollBar(Graphics dc, Rectangle clip, ScrollBar bar) { }

	// RVA: 0x2216660 Offset: 0x2215060 VA: 0x182216660 Slot: 182
	protected virtual void ScrollBar_DrawThumb(ScrollBar bar, Rectangle thumb_pos, Rectangle clip, Graphics dc) { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 103
	public override int get_ScrollBarButtonSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 104
	public override bool get_ScrollBarHasHotElementStyles() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 105
	public override bool get_ScrollBarHasPressedThumbStyle() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 106
	public override bool get_ScrollBarHasHoverArrowButtonStyle() { }

	// RVA: 0x2216780 Offset: 0x2215180 VA: 0x182216780 Slot: 107
	public override void TextBoxBaseFillBackground(TextBoxBase textBoxBase, Graphics g, Rectangle clippingArea) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 108
	public override bool TextBoxBaseHandleWmNcPaint(TextBoxBase textBoxBase, ref Message m) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 109
	public override bool TextBoxBaseShouldPaintBackground(TextBoxBase textBoxBase) { }

	// RVA: 0x2213E80 Offset: 0x2212880 VA: 0x182213E80 Slot: 110
	public override void DrawToolBar(Graphics dc, Rectangle clip_rectangle, ToolBar control) { }

	// RVA: 0x2213620 Offset: 0x2212020 VA: 0x182213620 Slot: 183
	protected virtual void DrawToolBarButton(Graphics dc, ToolBar control, ToolBarItem item, StringFormat format) { }

	// RVA: 0x22130C0 Offset: 0x2211AC0 VA: 0x1822130C0 Slot: 184
	protected virtual void DrawToolBarButtonBorder(Graphics dc, ToolBarItem item, bool is_flat) { }

	// RVA: 0x2213B40 Offset: 0x2212540 VA: 0x182213B40 Slot: 185
	protected virtual void DrawToolBarSeparator(Graphics dc, ToolBarItem item) { }

	// RVA: 0x2213C60 Offset: 0x2212660 VA: 0x182213C60 Slot: 186
	protected virtual void DrawToolBarToggleButtonBackground(Graphics dc, ToolBarItem item) { }

	// RVA: 0x2213770 Offset: 0x2212170 VA: 0x182213770 Slot: 187
	protected virtual void DrawToolBarDropDownArrow(Graphics dc, ToolBarItem item, bool is_flat) { }

	// RVA: 0x2213220 Offset: 0x2211C20 VA: 0x182213220 Slot: 188
	protected virtual void DrawToolBarButtonContents(Graphics dc, ToolBar control, ToolBarItem item, StringFormat format) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 111
	public override int get_ToolBarGripWidth() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 112
	public override int get_ToolBarImageGripWidth() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 113
	public override int get_ToolBarSeparatorWidth() { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 114
	public override int get_ToolBarDropDownWidth() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 115
	public override int get_ToolBarDropDownArrowWidth() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 116
	public override int get_ToolBarDropDownArrowHeight() { }

	// RVA: 0x2217630 Offset: 0x2216030 VA: 0x182217630 Slot: 117
	public override Size get_ToolBarDefaultSize() { }

	// RVA: 0x2216890 Offset: 0x2215290 VA: 0x182216890 Slot: 118
	public override bool ToolBarHasHotElementStyles(ToolBar toolBar) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 119
	public override bool get_ToolBarHasHotCheckedElementStyles() { }

	// RVA: 0x2214160 Offset: 0x2212B60 VA: 0x182214160 Slot: 120
	public override void DrawToolTip(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control) { }

	// RVA: 0x22168B0 Offset: 0x22152B0 VA: 0x1822168B0 Slot: 189
	protected virtual void ToolTipDrawBackground(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control) { }

	// RVA: 0x22169D0 Offset: 0x22153D0 VA: 0x1822169D0 Slot: 121
	public override Size ToolTipSize(ToolTip.ToolTipWindow tt, string text) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 122
	public override bool get_ToolTipTransparentBackground() { }

	// RVA: 0x2216DE0 Offset: 0x22157E0 VA: 0x182216DE0
	public static Size TrackBarGetThumbSize() { }

	// RVA: 0x2217660 Offset: 0x2216060 VA: 0x182217660 Slot: 123
	public override Size get_VScrollBarDefaultSize() { }

	// RVA: 0x2216E10 Offset: 0x2215810 VA: 0x182216E10 Slot: 124
	public override void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle) { }

	// RVA: 0x2216590 Offset: 0x2214F90 VA: 0x182216590 Slot: 126
	public override int ManagedWindowTitleBarHeight(InternalWindowManager wm) { }

	// RVA: 0x22154C0 Offset: 0x2213EC0 VA: 0x1822154C0 Slot: 127
	public override int ManagedWindowBorderWidth(InternalWindowManager wm) { }

	// RVA: 0x2215F50 Offset: 0x2214950 VA: 0x182215F50 Slot: 129
	public override void ManagedWindowSetButtonLocations(InternalWindowManager wm) { }

	// RVA: 0x2215710 Offset: 0x2214110 VA: 0x182215710 Slot: 190
	protected virtual Rectangle ManagedWindowDrawTitleBarAndBorders(Graphics dc, Rectangle clip, InternalWindowManager wm) { }

	// RVA: 0x22100E0 Offset: 0x220EAE0 VA: 0x1822100E0 Slot: 125
	public override void DrawManagedWindowDecorations(Graphics dc, Rectangle clip, InternalWindowManager wm) { }

	// RVA: 0x2215520 Offset: 0x2213F20 VA: 0x182215520 Slot: 128
	public override Size ManagedWindowButtonSize(InternalWindowManager wm) { }

	// RVA: 0x2213000 Offset: 0x2211A00 VA: 0x182213000
	private int DrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form) { }

	// RVA: 0x2215D90 Offset: 0x2214790 VA: 0x182215D90 Slot: 191
	protected virtual void ManagedWindowDrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form) { }

	// RVA: 0x2215EB0 Offset: 0x22148B0 VA: 0x182215EB0 Slot: 130
	public override Rectangle ManagedWindowGetTitleBarIconArea(InternalWindowManager wm) { }

	// RVA: 0x2215E80 Offset: 0x2214880 VA: 0x182215E80 Slot: 131
	public override Size ManagedWindowGetMenuButtonSize(InternalWindowManager wm) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 132
	public override bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form) { }

	// RVA: 0x2215620 Offset: 0x2214020 VA: 0x182215620 Slot: 133
	public override void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 134
	public override void ManagedWindowOnSizeInitializedOrChanged(Form form) { }

	// RVA: 0x22002F0 Offset: 0x21FECF0 VA: 0x1822002F0 Slot: 135
	public override void CPDrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle) { }

	// RVA: 0x21FF700 Offset: 0x21FE100 VA: 0x1821FF700 Slot: 136
	public override void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides) { }

	// RVA: 0x21FF7B0 Offset: 0x21FE1B0 VA: 0x1821FF7B0 Slot: 137
	public override void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides, Color control_color) { }

	// RVA: 0x2200E20 Offset: 0x21FF820 VA: 0x182200E20 Slot: 138
	public override void CPDrawButton(Graphics dc, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x22006D0 Offset: 0x21FF0D0 VA: 0x1822006D0
	private void CPDrawButtonInternal(Graphics dc, Rectangle rectangle, ButtonState state, Pen DarkPen, Pen NormalPen, Pen LightPen) { }

	// RVA: 0x2200EB0 Offset: 0x21FF8B0 VA: 0x182200EB0 Slot: 139
	public override void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state) { }

	// RVA: 0x2201360 Offset: 0x21FFD60 VA: 0x182201360 Slot: 140
	public override void CPDrawCheckBox(Graphics dc, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x2202120 Offset: 0x2200B20 VA: 0x182202120 Slot: 141
	public override void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x220C7A0 Offset: 0x220B1A0 VA: 0x18220C7A0 Slot: 192
	public virtual void DrawInnerFocusRectangle(Graphics graphics, Rectangle rectangle, Color backColor) { }

	// RVA: 0x22026A0 Offset: 0x22010A0 VA: 0x1822026A0 Slot: 142
	public override void CPDrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor) { }

	// RVA: 0x22028E0 Offset: 0x22012E0 VA: 0x1822028E0 Slot: 143
	public override void CPDrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background) { }

	// RVA: 0x2202D70 Offset: 0x2201770 VA: 0x182202D70 Slot: 144
	public override void CPDrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph, Color color, Color backColor) { }

	[MonoInternalNote("Does not respect Mixed")]
	// RVA: 0x2203290 Offset: 0x2201C90 VA: 0x182203290 Slot: 145
	public override void CPDrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x22032C0 Offset: 0x2201CC0 VA: 0x1822032C0 Slot: 146
	public override void CPDrawScrollButton(Graphics dc, Rectangle area, ScrollButton type, ButtonState state) { }

	// RVA: 0x2203D90 Offset: 0x2202790 VA: 0x182203D90 Slot: 147
	public override void CPDrawSizeGrip(Graphics dc, Color backColor, Rectangle bounds) { }

	// RVA: 0x2212E60 Offset: 0x2211860 VA: 0x182212E60
	private void DrawStringDisabled20(Graphics g, string s, Font font, Rectangle layoutRectangle, Color color, TextFormatFlags flags, bool useDrawString) { }

	// RVA: 0x2203FE0 Offset: 0x22029E0 VA: 0x182203FE0 Slot: 148
	public override void CPDrawStringDisabled(Graphics dc, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format) { }

	// RVA: 0x2206820 Offset: 0x2205220 VA: 0x182206820
	private static void DrawBorderInternal(Graphics graphics, int startX, int startY, int endX, int endY, int width, Color color, ButtonBorderStyle style, Border3DSide side) { }

	// RVA: 0x2206910 Offset: 0x2205310 VA: 0x182206910
	private static void DrawBorderInternal(Graphics graphics, float startX, float startY, float endX, float endY, int width, Color color, ButtonBorderStyle style, Border3DSide side) { }

	// RVA: 0x2208480 Offset: 0x2206E80 VA: 0x182208480
	private void DrawCaptionHelper(Graphics graphics, Color color, Pen pen, int lineWidth, int shift, Rectangle captionRect, CaptionButton button) { }

	// RVA: 0x2212B80 Offset: 0x2211580 VA: 0x182212B80
	public void DrawScrollButtonPrimitive(Graphics dc, Rectangle area, ButtonState state) { }
}
