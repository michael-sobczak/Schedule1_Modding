internal abstract class Theme // TypeDefIndex: 5594
{
	// Fields
	protected Array syscolors; // 0x10
	private readonly Font default_font; // 0x18
	protected Font window_border_font; // 0x20
	protected Color defaultWindowBackColor; // 0x28
	protected Color defaultWindowForeColor; // 0x40
	internal SystemResPool ResPool; // 0x58
	private MethodInfo update; // 0x60

	// Properties
	public virtual Color ColorScrollBar { get; }
	public virtual Color ColorMenu { get; set; }
	public virtual Color ColorWindow { get; }
	public virtual Color ColorMenuText { get; set; }
	public virtual Color ColorWindowText { get; }
	public virtual Color ColorHighlight { get; set; }
	public virtual Color ColorHighlightText { get; set; }
	public virtual Color ColorControl { get; set; }
	public virtual Color ColorControlDark { get; set; }
	public virtual Color ColorGrayText { get; }
	public virtual Color ColorControlText { get; set; }
	public virtual Color ColorInactiveCaptionText { get; }
	public virtual Color ColorControlLight { get; set; }
	public virtual Color ColorControlDarkDark { get; set; }
	public virtual Color ColorControlLightLight { get; set; }
	public virtual Color ColorInfoText { get; }
	public virtual Color ColorInfo { get; }
	public virtual Color DefaultControlBackColor { get; }
	public virtual Color DefaultControlForeColor { get; }
	public virtual Font DefaultFont { get; }
	public virtual Size BorderSizableSize { get; }
	public virtual Size Border3DSize { get; }
	public virtual Size BorderStaticSize { get; }
	public virtual Size BorderSize { get; }
	public virtual Size CaptionButtonSize { get; }
	public virtual int CaptionHeight { get; }
	public virtual Size DoubleClickSize { get; }
	public virtual int DoubleClickTime { get; }
	public virtual Size FrameBorderSize { get; }
	public virtual int HorizontalScrollBarHeight { get; }
	public virtual bool MenuAccessKeysUnderlined { get; }
	public virtual Size MenuButtonSize { get; }
	public virtual Size MenuCheckSize { get; }
	public virtual Font MenuFont { get; }
	public virtual int MenuHeight { get; }
	public virtual int MouseWheelScrollLines { get; }
	public virtual Size ToolWindowCaptionButtonSize { get; }
	public virtual int ToolWindowCaptionHeight { get; }
	public virtual int VerticalScrollBarWidth { get; }
	public virtual Font WindowBorderFont { get; }
	public abstract bool DoubleBufferingSupported { get; }
	public abstract Size ButtonBaseDefaultSize { get; }
	public abstract Size GroupBoxDefaultSize { get; }
	public abstract Size HScrollBarDefaultSize { get; }
	public abstract bool ListViewHasHotHeaderStyle { get; }
	public abstract Size ListViewCheckBoxSize { get; }
	public abstract int ListViewDefaultColumnWidth { get; }
	public abstract int ListViewVerticalSpacing { get; }
	public abstract int ListViewEmptyColumnWidth { get; }
	public abstract int ListViewHorizontalSpacing { get; }
	public abstract Size ListViewDefaultSize { get; }
	public abstract int ListViewItemPaddingWidth { get; }
	public abstract int ListViewTileWidthFactor { get; }
	public abstract int ListViewTileHeightFactor { get; }
	public abstract Size PanelDefaultSize { get; }
	public abstract Size PictureBoxDefaultSize { get; }
	public abstract int ScrollBarButtonSize { get; }
	public abstract bool ScrollBarHasHotElementStyles { get; }
	public abstract bool ScrollBarHasPressedThumbStyle { get; }
	public abstract bool ScrollBarHasHoverArrowButtonStyle { get; }
	public abstract int ToolBarGripWidth { get; }
	public abstract int ToolBarImageGripWidth { get; }
	public abstract int ToolBarSeparatorWidth { get; }
	public abstract int ToolBarDropDownWidth { get; }
	public abstract int ToolBarDropDownArrowWidth { get; }
	public abstract int ToolBarDropDownArrowHeight { get; }
	public abstract Size ToolBarDefaultSize { get; }
	public abstract bool ToolBarHasHotCheckedElementStyles { get; }
	public abstract bool ToolTipTransparentBackground { get; }
	public abstract Size VScrollBarDefaultSize { get; }

	// Methods

	// RVA: 0x22221F0 Offset: 0x2220BF0 VA: 0x1822221F0
	protected void .ctor() { }

	// RVA: 0x2221FF0 Offset: 0x22209F0 VA: 0x182221FF0
	private void SetSystemColors(KnownColor kc, Color value) { }

	// RVA: 0x22227D0 Offset: 0x22211D0 VA: 0x1822227D0 Slot: 4
	public virtual Color get_ColorScrollBar() { }

	// RVA: 0x22227A0 Offset: 0x22211A0 VA: 0x1822227A0 Slot: 5
	public virtual Color get_ColorMenu() { }

	// RVA: 0x2222CB0 Offset: 0x22216B0 VA: 0x182222CB0 Slot: 6
	public virtual void set_ColorMenu(Color value) { }

	// RVA: 0x2222830 Offset: 0x2221230 VA: 0x182222830 Slot: 7
	public virtual Color get_ColorWindow() { }

	// RVA: 0x2222770 Offset: 0x2221170 VA: 0x182222770 Slot: 8
	public virtual Color get_ColorMenuText() { }

	// RVA: 0x2222C80 Offset: 0x2221680 VA: 0x182222C80 Slot: 9
	public virtual void set_ColorMenuText(Color value) { }

	// RVA: 0x2222800 Offset: 0x2221200 VA: 0x182222800 Slot: 10
	public virtual Color get_ColorWindowText() { }

	// RVA: 0x22226B0 Offset: 0x22210B0 VA: 0x1822226B0 Slot: 11
	public virtual Color get_ColorHighlight() { }

	// RVA: 0x2222C50 Offset: 0x2221650 VA: 0x182222C50 Slot: 12
	public virtual void set_ColorHighlight(Color value) { }

	// RVA: 0x2222680 Offset: 0x2221080 VA: 0x182222680 Slot: 13
	public virtual Color get_ColorHighlightText() { }

	// RVA: 0x2222C20 Offset: 0x2221620 VA: 0x182222C20 Slot: 14
	public virtual void set_ColorHighlightText(Color value) { }

	// RVA: 0x2222620 Offset: 0x2221020 VA: 0x182222620 Slot: 15
	public virtual Color get_ColorControl() { }

	// RVA: 0x2222BF0 Offset: 0x22215F0 VA: 0x182222BF0 Slot: 16
	public virtual void set_ColorControl(Color value) { }

	// RVA: 0x2222560 Offset: 0x2220F60 VA: 0x182222560 Slot: 17
	public virtual Color get_ColorControlDark() { }

	// RVA: 0x2222B30 Offset: 0x2221530 VA: 0x182222B30 Slot: 18
	public virtual void set_ColorControlDark(Color value) { }

	// RVA: 0x2222650 Offset: 0x2221050 VA: 0x182222650 Slot: 19
	public virtual Color get_ColorGrayText() { }

	// RVA: 0x22225F0 Offset: 0x2220FF0 VA: 0x1822225F0 Slot: 20
	public virtual Color get_ColorControlText() { }

	// RVA: 0x2222BC0 Offset: 0x22215C0 VA: 0x182222BC0 Slot: 21
	public virtual void set_ColorControlText(Color value) { }

	// RVA: 0x22226E0 Offset: 0x22210E0 VA: 0x1822226E0 Slot: 22
	public virtual Color get_ColorInactiveCaptionText() { }

	// RVA: 0x22225C0 Offset: 0x2220FC0 VA: 0x1822225C0 Slot: 23
	public virtual Color get_ColorControlLight() { }

	// RVA: 0x2222B90 Offset: 0x2221590 VA: 0x182222B90 Slot: 24
	public virtual void set_ColorControlLight(Color value) { }

	// RVA: 0x2222530 Offset: 0x2220F30 VA: 0x182222530 Slot: 25
	public virtual Color get_ColorControlDarkDark() { }

	// RVA: 0x2222B00 Offset: 0x2221500 VA: 0x182222B00 Slot: 26
	public virtual void set_ColorControlDarkDark(Color value) { }

	// RVA: 0x2222590 Offset: 0x2220F90 VA: 0x182222590 Slot: 27
	public virtual Color get_ColorControlLightLight() { }

	// RVA: 0x2222B60 Offset: 0x2221560 VA: 0x182222B60 Slot: 28
	public virtual void set_ColorControlLightLight(Color value) { }

	// RVA: 0x2222710 Offset: 0x2221110 VA: 0x182222710 Slot: 29
	public virtual Color get_ColorInfoText() { }

	// RVA: 0x2222740 Offset: 0x2221140 VA: 0x182222740 Slot: 30
	public virtual Color get_ColorInfo() { }

	// RVA: 0x2222860 Offset: 0x2221260 VA: 0x182222860 Slot: 31
	public virtual Color get_DefaultControlBackColor() { }

	// RVA: 0x22228A0 Offset: 0x22212A0 VA: 0x1822228A0 Slot: 32
	public virtual Color get_DefaultControlForeColor() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 33
	public virtual Font get_DefaultFont() { }

	// RVA: 0x2222410 Offset: 0x2220E10 VA: 0x182222410 Slot: 34
	public virtual Size get_BorderSizableSize() { }

	// RVA: 0x22223D0 Offset: 0x2220DD0 VA: 0x1822223D0 Slot: 35
	public virtual Size get_Border3DSize() { }

	// RVA: 0x2222480 Offset: 0x2220E80 VA: 0x182222480 Slot: 36
	public virtual Size get_BorderStaticSize() { }

	// RVA: 0x2222440 Offset: 0x2220E40 VA: 0x182222440 Slot: 37
	public virtual Size get_BorderSize() { }

	// RVA: 0x22224B0 Offset: 0x2220EB0 VA: 0x1822224B0 Slot: 38
	public virtual Size get_CaptionButtonSize() { }

	// RVA: 0x22224F0 Offset: 0x2220EF0 VA: 0x1822224F0 Slot: 39
	public virtual int get_CaptionHeight() { }

	// RVA: 0x22228E0 Offset: 0x22212E0 VA: 0x1822228E0 Slot: 40
	public virtual Size get_DoubleClickSize() { }

	// RVA: 0x2222910 Offset: 0x2221310 VA: 0x182222910 Slot: 41
	public virtual int get_DoubleClickTime() { }

	// RVA: 0x2222950 Offset: 0x2221350 VA: 0x182222950 Slot: 42
	public virtual Size get_FrameBorderSize() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 43
	public virtual int get_HorizontalScrollBarHeight() { }

	// RVA: 0x2222990 Offset: 0x2221390 VA: 0x182222990 Slot: 44
	public virtual bool get_MenuAccessKeysUnderlined() { }

	// RVA: 0x22229D0 Offset: 0x22213D0 VA: 0x1822229D0 Slot: 45
	public virtual Size get_MenuButtonSize() { }

	// RVA: 0x2222A10 Offset: 0x2221410 VA: 0x182222A10 Slot: 46
	public virtual Size get_MenuCheckSize() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 47
	public virtual Font get_MenuFont() { }

	// RVA: 0x2222A40 Offset: 0x2221440 VA: 0x182222A40 Slot: 48
	public virtual int get_MenuHeight() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 49
	public virtual int get_MouseWheelScrollLines() { }

	// RVA: 0x2222A80 Offset: 0x2221480 VA: 0x182222A80 Slot: 50
	public virtual Size get_ToolWindowCaptionButtonSize() { }

	// RVA: 0x2222AC0 Offset: 0x22214C0 VA: 0x182222AC0 Slot: 51
	public virtual int get_ToolWindowCaptionHeight() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 52
	public virtual int get_VerticalScrollBarWidth() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 53
	public virtual Font get_WindowBorderFont() { }

	// RVA: 0x22218E0 Offset: 0x22202E0 VA: 0x1822218E0
	public int Clamp(int value, int lower, int upper) { }

	[MonoInternalNote("Figure out where to point for My Network Places")]
	// RVA: 0x2221EC0 Offset: 0x22208C0 VA: 0x182221EC0 Slot: 54
	public virtual string Places(UIIcon index) { }

	// RVA: 0x2221900 Offset: 0x2220300 VA: 0x182221900
	private Image GetSizedResourceImage(string name, int width) { }

	// RVA: 0x2221CD0 Offset: 0x22206D0 VA: 0x182221CD0 Slot: 55
	public virtual Image Images(UIIcon index, int size) { }

	// RVA: -1 Offset: -1 Slot: 56
	public abstract void ResetDefaults();

	// RVA: -1 Offset: -1 Slot: 57
	public abstract bool get_DoubleBufferingSupported();

	// RVA: -1 Offset: -1 Slot: 58
	public abstract Size CalculateButtonAutoSize(Button button);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract void CalculateButtonTextAndImageLayout(ButtonBase b, out Rectangle textRectangle, out Rectangle imageRectangle);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract void DrawButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract void DrawFlatButton(Graphics g, ButtonBase b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract void DrawPopupButton(Graphics g, Button b, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	// RVA: -1 Offset: -1 Slot: 63
	public abstract void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract Size get_ButtonBaseDefaultSize();

	// RVA: -1 Offset: -1 Slot: 65
	public abstract Size CalculateCheckBoxAutoSize(CheckBox checkBox);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void CalculateCheckBoxTextAndImageLayout(ButtonBase b, Point offset, out Rectangle glyphArea, out Rectangle textRectangle, out Rectangle imageRectangle);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract void DrawCheckBox(Graphics g, CheckBox cb, Rectangle glyphArea, Rectangle textBounds, Rectangle imageBounds, Rectangle clipRectangle);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract void DrawCheckBox(Graphics dc, Rectangle clip_area, CheckBox checkbox);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract void DrawComboBoxItem(ComboBox ctrl, DrawItemEventArgs e);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract void DrawFlatStyleComboButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract void ComboBoxDrawNormalDropDownButton(ComboBox comboBox, Graphics g, Rectangle clippingArea, Rectangle area, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 72
	public abstract bool ComboBoxNormalDropDownButtonHasTransparentBackground(ComboBox comboBox, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 73
	public abstract bool ComboBoxDropDownButtonHasHotElementStyle(ComboBox comboBox);

	// RVA: -1 Offset: -1 Slot: 74
	public abstract void ComboBoxDrawBackground(ComboBox comboBox, Graphics g, Rectangle clippingArea, FlatStyle style);

	// RVA: -1 Offset: -1 Slot: 75
	public abstract bool CombBoxBackgroundHasHotElementStyle(ComboBox comboBox);

	// RVA: -1 Offset: -1 Slot: 76
	public abstract void DrawGroupBox(Graphics dc, Rectangle clip_area, GroupBox box);

	// RVA: -1 Offset: -1 Slot: 77
	public abstract Size get_GroupBoxDefaultSize();

	// RVA: -1 Offset: -1 Slot: 78
	public abstract Size get_HScrollBarDefaultSize();

	// RVA: -1 Offset: -1 Slot: 79
	public abstract void DrawListViewItems(Graphics dc, Rectangle clip_rectangle, ListView control);

	// RVA: -1 Offset: -1 Slot: 80
	public abstract void DrawListViewHeader(Graphics dc, Rectangle clip_rectangle, ListView control);

	// RVA: -1 Offset: -1 Slot: 81
	public abstract void DrawListViewHeaderDragDetails(Graphics dc, ListView control, ColumnHeader drag_column, int target_x);

	// RVA: -1 Offset: -1 Slot: 82
	public abstract bool get_ListViewHasHotHeaderStyle();

	// RVA: -1 Offset: -1 Slot: 83
	public abstract int ListViewGetHeaderHeight(ListView listView, Font font);

	// RVA: -1 Offset: -1 Slot: 84
	public abstract Size get_ListViewCheckBoxSize();

	// RVA: -1 Offset: -1 Slot: 85
	public abstract int get_ListViewDefaultColumnWidth();

	// RVA: -1 Offset: -1 Slot: 86
	public abstract int get_ListViewVerticalSpacing();

	// RVA: -1 Offset: -1 Slot: 87
	public abstract int get_ListViewEmptyColumnWidth();

	// RVA: -1 Offset: -1 Slot: 88
	public abstract int get_ListViewHorizontalSpacing();

	// RVA: -1 Offset: -1 Slot: 89
	public abstract Size get_ListViewDefaultSize();

	// RVA: -1 Offset: -1 Slot: 90
	public abstract int get_ListViewItemPaddingWidth();

	// RVA: -1 Offset: -1 Slot: 91
	public abstract int get_ListViewTileWidthFactor();

	// RVA: -1 Offset: -1 Slot: 92
	public abstract int get_ListViewTileHeightFactor();

	// RVA: -1 Offset: -1 Slot: 93
	public abstract void CalcItemSize(Graphics dc, MenuItem item, int y, int x, bool menuBar);

	// RVA: -1 Offset: -1 Slot: 94
	public abstract void CalcPopupMenuSize(Graphics dc, Menu menu);

	// RVA: -1 Offset: -1 Slot: 95
	public abstract int CalcMenuBarSize(Graphics dc, Menu menu, int width);

	// RVA: -1 Offset: -1 Slot: 96
	public abstract void DrawMenuBar(Graphics dc, Menu menu, Rectangle rect);

	// RVA: -1 Offset: -1 Slot: 97
	public abstract void DrawMenuItem(MenuItem item, DrawItemEventArgs e);

	// RVA: -1 Offset: -1 Slot: 98
	public abstract void DrawPopupMenu(Graphics dc, Menu menu, Rectangle cliparea, Rectangle rect);

	// RVA: -1 Offset: -1 Slot: 99
	public abstract Size get_PanelDefaultSize();

	// RVA: -1 Offset: -1 Slot: 100
	public abstract void DrawPictureBox(Graphics dc, Rectangle clip, PictureBox pb);

	// RVA: -1 Offset: -1 Slot: 101
	public abstract Size get_PictureBoxDefaultSize();

	// RVA: -1 Offset: -1 Slot: 102
	public abstract void DrawScrollBar(Graphics dc, Rectangle clip_rectangle, ScrollBar bar);

	// RVA: -1 Offset: -1 Slot: 103
	public abstract int get_ScrollBarButtonSize();

	// RVA: -1 Offset: -1 Slot: 104
	public abstract bool get_ScrollBarHasHotElementStyles();

	// RVA: -1 Offset: -1 Slot: 105
	public abstract bool get_ScrollBarHasPressedThumbStyle();

	// RVA: -1 Offset: -1 Slot: 106
	public abstract bool get_ScrollBarHasHoverArrowButtonStyle();

	// RVA: -1 Offset: -1 Slot: 107
	public abstract void TextBoxBaseFillBackground(TextBoxBase textBoxBase, Graphics g, Rectangle clippingArea);

	// RVA: -1 Offset: -1 Slot: 108
	public abstract bool TextBoxBaseHandleWmNcPaint(TextBoxBase textBoxBase, ref Message m);

	// RVA: -1 Offset: -1 Slot: 109
	public abstract bool TextBoxBaseShouldPaintBackground(TextBoxBase textBoxBase);

	// RVA: -1 Offset: -1 Slot: 110
	public abstract void DrawToolBar(Graphics dc, Rectangle clip_rectangle, ToolBar control);

	// RVA: -1 Offset: -1 Slot: 111
	public abstract int get_ToolBarGripWidth();

	// RVA: -1 Offset: -1 Slot: 112
	public abstract int get_ToolBarImageGripWidth();

	// RVA: -1 Offset: -1 Slot: 113
	public abstract int get_ToolBarSeparatorWidth();

	// RVA: -1 Offset: -1 Slot: 114
	public abstract int get_ToolBarDropDownWidth();

	// RVA: -1 Offset: -1 Slot: 115
	public abstract int get_ToolBarDropDownArrowWidth();

	// RVA: -1 Offset: -1 Slot: 116
	public abstract int get_ToolBarDropDownArrowHeight();

	// RVA: -1 Offset: -1 Slot: 117
	public abstract Size get_ToolBarDefaultSize();

	// RVA: -1 Offset: -1 Slot: 118
	public abstract bool ToolBarHasHotElementStyles(ToolBar toolBar);

	// RVA: -1 Offset: -1 Slot: 119
	public abstract bool get_ToolBarHasHotCheckedElementStyles();

	// RVA: -1 Offset: -1 Slot: 120
	public abstract void DrawToolTip(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control);

	// RVA: -1 Offset: -1 Slot: 121
	public abstract Size ToolTipSize(ToolTip.ToolTipWindow tt, string text);

	// RVA: -1 Offset: -1 Slot: 122
	public abstract bool get_ToolTipTransparentBackground();

	// RVA: -1 Offset: -1 Slot: 123
	public abstract Size get_VScrollBarDefaultSize();

	// RVA: -1 Offset: -1 Slot: 124
	public abstract void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle);

	// RVA: -1 Offset: -1 Slot: 125
	public abstract void DrawManagedWindowDecorations(Graphics dc, Rectangle clip, InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 126
	public abstract int ManagedWindowTitleBarHeight(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 127
	public abstract int ManagedWindowBorderWidth(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 128
	public abstract Size ManagedWindowButtonSize(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 129
	public abstract void ManagedWindowSetButtonLocations(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 130
	public abstract Rectangle ManagedWindowGetTitleBarIconArea(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 131
	public abstract Size ManagedWindowGetMenuButtonSize(InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 132
	public abstract bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form);

	// RVA: -1 Offset: -1 Slot: 133
	public abstract void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm);

	// RVA: -1 Offset: -1 Slot: 134
	public abstract void ManagedWindowOnSizeInitializedOrChanged(Form form);

	// RVA: -1 Offset: -1 Slot: 135
	public abstract void CPDrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle);

	// RVA: -1 Offset: -1 Slot: 136
	public abstract void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides);

	// RVA: -1 Offset: -1 Slot: 137
	public abstract void CPDrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides, Color control_color);

	// RVA: -1 Offset: -1 Slot: 138
	public abstract void CPDrawButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 139
	public abstract void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 140
	public abstract void CPDrawCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 141
	public abstract void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 142
	public abstract void CPDrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor);

	// RVA: -1 Offset: -1 Slot: 143
	public abstract void CPDrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background);

	// RVA: -1 Offset: -1 Slot: 144
	public abstract void CPDrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph, Color color, Color backColor);

	// RVA: -1 Offset: -1 Slot: 145
	public abstract void CPDrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 146
	public abstract void CPDrawScrollButton(Graphics graphics, Rectangle rectangle, ScrollButton button, ButtonState state);

	// RVA: -1 Offset: -1 Slot: 147
	public abstract void CPDrawSizeGrip(Graphics graphics, Color backColor, Rectangle bounds);

	// RVA: -1 Offset: -1 Slot: 148
	public abstract void CPDrawStringDisabled(Graphics graphics, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format);
}
