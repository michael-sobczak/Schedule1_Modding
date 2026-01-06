internal class ThemeVisualStyles : ThemeWin32Classic // TypeDefIndex: 5596
{
	// Fields
	private static bool render_client_areas; // 0x0
	private static bool render_non_client_areas; // 0x1
	private static bool ScrollBarHasHoverArrowButtonStyleVisualStyles; // 0x2
	private static Control control; // 0x8

	// Properties
	public static bool RenderClientAreas { get; }
	public override bool ListViewHasHotHeaderStyle { get; }
	public override bool ScrollBarHasHotElementStyles { get; }
	public override bool ScrollBarHasPressedThumbStyle { get; }
	public override bool ScrollBarHasHoverArrowButtonStyle { get; }
	private static bool ScrollBarAreElementsDefined { get; }
	public override bool ToolBarHasHotCheckedElementStyles { get; }
	public override bool ToolTipTransparentBackground { get; }

	// Methods

	// RVA: 0x22212E0 Offset: 0x221FCE0 VA: 0x1822212E0
	public void .ctor() { }

	// RVA: 0x2221280 Offset: 0x221FC80 VA: 0x182221280
	private static void .cctor() { }

	// RVA: 0x221FEB0 Offset: 0x221E8B0 VA: 0x18221FEB0 Slot: 56
	public override void ResetDefaults() { }

	// RVA: 0x22210A0 Offset: 0x221FAA0 VA: 0x1822210A0
	private static void Update() { }

	// RVA: 0x2221410 Offset: 0x221FE10 VA: 0x182221410
	public static bool get_RenderClientAreas() { }

	// RVA: 0x221BED0 Offset: 0x221A8D0 VA: 0x18221BED0 Slot: 63
	public override void DrawButtonBase(Graphics dc, Rectangle clip_area, ButtonBase button) { }

	// RVA: 0x221DA10 Offset: 0x221C410 VA: 0x18221DA10
	private static PushButtonState GetPushButtonState(ButtonBase button) { }

	// RVA: 0x221BD40 Offset: 0x221A740 VA: 0x18221BD40 Slot: 149
	public override void DrawButtonBackground(Graphics g, Button button, Rectangle clipArea) { }

	// RVA: 0x221B2C0 Offset: 0x2219CC0 VA: 0x18221B2C0 Slot: 169
	protected override void CheckBox_DrawCheckBox(Graphics dc, CheckBox checkbox, ButtonState state, Rectangle checkbox_rectangle) { }

	// RVA: 0x221D830 Offset: 0x221C230 VA: 0x18221D830
	private static CheckBoxState GetCheckBoxState(CheckBox checkBox) { }

	// RVA: 0x221BB10 Offset: 0x221A510 VA: 0x18221BB10
	private static VisualStyleElement ComboBoxGetVisualStyleElement(ComboBox comboBox, ButtonState state) { }

	// RVA: 0x221B7F0 Offset: 0x221A1F0 VA: 0x18221B7F0 Slot: 71
	public override void ComboBoxDrawNormalDropDownButton(ComboBox comboBox, Graphics g, Rectangle clippingArea, Rectangle area, ButtonState state) { }

	// RVA: 0x221BB70 Offset: 0x221A570 VA: 0x18221BB70 Slot: 72
	public override bool ComboBoxNormalDropDownButtonHasTransparentBackground(ComboBox comboBox, ButtonState state) { }

	// RVA: 0x221BA40 Offset: 0x221A440 VA: 0x18221BA40 Slot: 73
	public override bool ComboBoxDropDownButtonHasHotElementStyle(ComboBox comboBox) { }

	// RVA: 0x221BD00 Offset: 0x221A700 VA: 0x18221BD00
	private static bool ComboBoxShouldPaintBackground(ComboBox comboBox) { }

	// RVA: 0x221B570 Offset: 0x2219F70 VA: 0x18221B570 Slot: 74
	public override void ComboBoxDrawBackground(ComboBox comboBox, Graphics g, Rectangle clippingArea, FlatStyle style) { }

	// RVA: 0x221B460 Offset: 0x2219E60 VA: 0x18221B460 Slot: 75
	public override bool CombBoxBackgroundHasHotElementStyle(ComboBox comboBox) { }

	// RVA: 0x221A7E0 Offset: 0x22191E0 VA: 0x18221A7E0 Slot: 138
	public override void CPDrawButton(Graphics dc, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x221A980 Offset: 0x2219380 VA: 0x18221A980 Slot: 139
	public override void CPDrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state) { }

	// RVA: 0x221D780 Offset: 0x221C180 VA: 0x18221D780
	private static VisualStyleElement GetCaptionButtonVisualStyleElement(CaptionButton button, ButtonState state) { }

	// RVA: 0x221ABF0 Offset: 0x22195F0 VA: 0x18221ABF0 Slot: 140
	public override void CPDrawCheckBox(Graphics dc, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x221ADB0 Offset: 0x22197B0 VA: 0x18221ADB0 Slot: 141
	public override void CPDrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x221AF50 Offset: 0x2219950 VA: 0x18221AF50 Slot: 145
	public override void CPDrawMixedCheckBox(Graphics dc, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x221B110 Offset: 0x2219B10 VA: 0x18221B110 Slot: 146
	public override void CPDrawScrollButton(Graphics dc, Rectangle area, ScrollButton type, ButtonState state) { }

	// RVA: 0x221DAB0 Offset: 0x221C4B0 VA: 0x18221DAB0
	private static VisualStyleElement GetScrollButtonVisualStyleElement(ScrollButton type, ButtonState state) { }

	// RVA: 0x221DCA0 Offset: 0x221C6A0 VA: 0x18221DCA0
	private static bool IsDisabled(ButtonState state) { }

	// RVA: 0x221DCB0 Offset: 0x221C6B0 VA: 0x18221DCB0
	private static bool IsPressed(ButtonState state) { }

	// RVA: 0x221DCC0 Offset: 0x221C6C0 VA: 0x18221DCC0 Slot: 173
	protected override void ListViewDrawColumnHeaderBackground(ListView listView, ColumnHeader columnHeader, Graphics g, Rectangle area, Rectangle clippingArea) { }

	// RVA: 0x221DF00 Offset: 0x221C900 VA: 0x18221DF00 Slot: 174
	protected override void ListViewDrawUnusedHeaderBackground(ListView listView, Graphics g, Rectangle area, Rectangle clippingArea) { }

	// RVA: 0x2221360 Offset: 0x221FD60 VA: 0x182221360 Slot: 82
	public override bool get_ListViewHasHotHeaderStyle() { }

	// RVA: 0x221E0D0 Offset: 0x221CAD0 VA: 0x18221E0D0 Slot: 83
	public override int ListViewGetHeaderHeight(ListView listView, Font font) { }

	// RVA: 0x221C120 Offset: 0x221AB20 VA: 0x18221C120 Slot: 76
	public override void DrawGroupBox(Graphics dc, Rectangle area, GroupBox box) { }

	// RVA: 0x221EFA0 Offset: 0x221D9A0 VA: 0x18221EFA0
	private Rectangle ManagedWindowGetTitleBarRectangle(InternalWindowManager wm) { }

	// RVA: 0x221F7A0 Offset: 0x221E1A0 VA: 0x18221F7A0
	private Region ManagedWindowGetWindowRegion(Form form) { }

	// RVA: 0x221FB50 Offset: 0x221E550 VA: 0x18221FB50 Slot: 134
	public override void ManagedWindowOnSizeInitializedOrChanged(Form form) { }

	// RVA: 0x221E5E0 Offset: 0x221CFE0 VA: 0x18221E5E0 Slot: 190
	protected override Rectangle ManagedWindowDrawTitleBarAndBorders(Graphics dc, Rectangle clip, InternalWindowManager wm) { }

	// RVA: 0x221F9F0 Offset: 0x221E3F0 VA: 0x18221F9F0
	private static FormWindowState ManagedWindowGetWindowState(InternalWindowManager wm) { }

	// RVA: 0x221FA50 Offset: 0x221E450 VA: 0x18221FA50
	private static bool ManagedWindowIsDisabled(InternalWindowManager wm) { }

	// RVA: 0x221FA20 Offset: 0x221E420 VA: 0x18221FA20
	private static bool ManagedWindowIsActive(InternalWindowManager wm) { }

	// RVA: 0x221F080 Offset: 0x221DA80 VA: 0x18221F080
	private static VisualStyleElement ManagedWindowGetTitleBarVisualStyleElement(InternalWindowManager wm) { }

	// RVA: 0x221EBC0 Offset: 0x221D5C0 VA: 0x18221EBC0
	private static void ManagedWindowGetBorderVisualStyleElements(InternalWindowManager wm, out VisualStyleElement left, out VisualStyleElement right, out VisualStyleElement bottom) { }

	// RVA: 0x221FBF0 Offset: 0x221E5F0 VA: 0x18221FBF0 Slot: 132
	public override bool ManagedWindowTitleButtonHasHotElementStyle(TitleButton button, Form form) { }

	// RVA: 0x221FA80 Offset: 0x221E480 VA: 0x18221FA80
	private static bool ManagedWindowIsMaximizedMdiChild(Form form) { }

	// RVA: 0x221FE20 Offset: 0x221E820 VA: 0x18221FE20
	private static bool ManagedWindowTitleButtonIsDisabled(TitleButton button, InternalWindowManager wm) { }

	// RVA: 0x221FE40 Offset: 0x221E840 VA: 0x18221FE40
	private static bool ManagedWindowTitleButtonIsPressed(TitleButton button) { }

	// RVA: 0x221F400 Offset: 0x221DE00 VA: 0x18221F400
	private static VisualStyleElement ManagedWindowGetTitleButtonVisualStyleElement(TitleButton button, Form form) { }

	// RVA: 0x221EA20 Offset: 0x221D420 VA: 0x18221EA20 Slot: 191
	protected override void ManagedWindowDrawTitleButton(Graphics dc, TitleButton button, Rectangle clip, Form form) { }

	// RVA: 0x221E2A0 Offset: 0x221CCA0 VA: 0x18221E2A0 Slot: 128
	public override Size ManagedWindowButtonSize(InternalWindowManager wm) { }

	// RVA: 0x221E440 Offset: 0x221CE40 VA: 0x18221E440 Slot: 133
	public override void ManagedWindowDrawMenuButton(Graphics dc, TitleButton button, Rectangle clip, InternalWindowManager wm) { }

	// RVA: 0x221ED90 Offset: 0x221D790 VA: 0x18221ED90
	private static VisualStyleElement ManagedWindowGetMenuButtonVisualStyleElement(TitleButton button, InternalWindowManager wm) { }

	// RVA: 0x221C340 Offset: 0x221AD40 VA: 0x18221C340 Slot: 102
	public override void DrawScrollBar(Graphics dc, Rectangle clip, ScrollBar bar) { }

	// RVA: 0x2221500 Offset: 0x221FF00 VA: 0x182221500 Slot: 104
	public override bool get_ScrollBarHasHotElementStyles() { }

	// RVA: 0x2221680 Offset: 0x2220080 VA: 0x182221680 Slot: 105
	public override bool get_ScrollBarHasPressedThumbStyle() { }

	// RVA: 0x22215B0 Offset: 0x221FFB0 VA: 0x1822215B0 Slot: 106
	public override bool get_ScrollBarHasHoverArrowButtonStyle() { }

	// RVA: 0x2221460 Offset: 0x221FE60 VA: 0x182221460
	private static bool get_ScrollBarAreElementsDefined() { }

	// RVA: 0x22206F0 Offset: 0x221F0F0 VA: 0x1822206F0
	private static bool TextBoxBaseShouldPaint(TextBoxBase textBoxBase) { }

	// RVA: 0x2220170 Offset: 0x221EB70 VA: 0x182220170
	private static VisualStyleElement TextBoxBaseGetVisualStyleElement(TextBoxBase textBoxBase) { }

	// RVA: 0x221FF00 Offset: 0x221E900 VA: 0x18221FF00 Slot: 107
	public override void TextBoxBaseFillBackground(TextBoxBase textBoxBase, Graphics g, Rectangle clippingArea) { }

	// RVA: 0x2220200 Offset: 0x221EC00 VA: 0x182220200 Slot: 108
	public override bool TextBoxBaseHandleWmNcPaint(TextBoxBase textBoxBase, ref Message m) { }

	// RVA: 0x2220540 Offset: 0x221EF40 VA: 0x182220540 Slot: 109
	public override bool TextBoxBaseShouldPaintBackground(TextBoxBase textBoxBase) { }

	// RVA: 0x2220CD0 Offset: 0x221F6D0 VA: 0x182220CD0
	private static bool ToolBarIsDisabled(ToolBarItem item) { }

	// RVA: 0x2220D20 Offset: 0x221F720 VA: 0x182220D20
	private static bool ToolBarIsPressed(ToolBarItem item) { }

	// RVA: 0x2220CA0 Offset: 0x221F6A0 VA: 0x182220CA0
	private static bool ToolBarIsChecked(ToolBarItem item) { }

	// RVA: 0x2220D00 Offset: 0x221F700 VA: 0x182220D00
	private static bool ToolBarIsHot(ToolBarItem item) { }

	// RVA: 0x221D010 Offset: 0x221BA10 VA: 0x18221D010 Slot: 184
	protected override void DrawToolBarButtonBorder(Graphics dc, ToolBarItem item, bool is_flat) { }

	// RVA: 0x2220950 Offset: 0x221F350 VA: 0x182220950
	private static VisualStyleElement ToolBarGetDropDownButtonVisualStyleElement(ToolBarItem item) { }

	// RVA: 0x2220710 Offset: 0x221F110 VA: 0x182220710
	private static VisualStyleElement ToolBarGetButtonVisualStyleElement(ToolBarItem item) { }

	// RVA: 0x221D4F0 Offset: 0x221BEF0 VA: 0x18221D4F0 Slot: 185
	protected override void DrawToolBarSeparator(Graphics dc, ToolBarItem item) { }

	// RVA: 0x2220B70 Offset: 0x221F570 VA: 0x182220B70
	private static VisualStyleElement ToolBarGetSeparatorVisualStyleElement(ToolBarItem toolBarItem) { }

	// RVA: 0x221D6A0 Offset: 0x221C0A0 VA: 0x18221D6A0 Slot: 186
	protected override void DrawToolBarToggleButtonBackground(Graphics dc, ToolBarItem item) { }

	// RVA: 0x221D220 Offset: 0x221BC20 VA: 0x18221D220 Slot: 187
	protected override void DrawToolBarDropDownArrow(Graphics dc, ToolBarItem item, bool is_flat) { }

	// RVA: 0x2220830 Offset: 0x221F230 VA: 0x182220830
	private static VisualStyleElement ToolBarGetDropDownArrowVisualStyleElement(ToolBarItem item) { }

	// RVA: 0x2220BF0 Offset: 0x221F5F0 VA: 0x182220BF0 Slot: 118
	public override bool ToolBarHasHotElementStyles(ToolBar toolBar) { }

	// RVA: 0x2221730 Offset: 0x2220130 VA: 0x182221730 Slot: 119
	public override bool get_ToolBarHasHotCheckedElementStyles() { }

	// RVA: 0x2220D50 Offset: 0x221F750 VA: 0x182220D50 Slot: 189
	protected override void ToolTipDrawBackground(Graphics dc, Rectangle clip_rectangle, ToolTip.ToolTipWindow control) { }

	// RVA: 0x22217D0 Offset: 0x22201D0 VA: 0x1822217D0 Slot: 122
	public override bool get_ToolTipTransparentBackground() { }

	[MonoInternalNote("Use the sizing information provided by the VisualStyles API.")]
	// RVA: 0x2220EE0 Offset: 0x221F8E0 VA: 0x182220EE0 Slot: 124
	public override void TreeViewDrawNodePlusMinus(TreeView treeView, TreeNode node, Graphics dc, int x, int middle) { }

	// RVA: 0x221D910 Offset: 0x221C310 VA: 0x18221D910
	private static IDeviceContext GetMeasurementDeviceContext() { }

	// RVA: 0x221FE60 Offset: 0x221E860 VA: 0x18221FE60
	private static void ReleaseMeasurementDeviceContext(IDeviceContext dc) { }
}
