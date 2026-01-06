public class ToolBar : Control // TypeDefIndex: 5602
{
	// Fields
	private bool size_specified; // 0x1D8
	private ToolBarItem current_item; // 0x1E0
	internal ToolBarItem[] items; // 0x1E8
	internal Size default_size; // 0x1F0
	private static object ButtonClickEvent; // 0x0
	private static object ButtonDropDownEvent; // 0x8
	private ToolBarAppearance appearance; // 0x1F8
	private bool autosize; // 0x1FC
	private ToolBar.ToolBarButtonCollection buttons; // 0x200
	private Size button_size; // 0x208
	private bool divider; // 0x210
	private bool drop_down_arrows; // 0x211
	private ImageList image_list; // 0x218
	private ImeMode ime_mode; // 0x220
	private bool show_tooltips; // 0x224
	private ToolBarTextAlign text_alignment; // 0x228
	private bool wrappable; // 0x22C
	private ToolBarButton button_for_focus; // 0x230
	private int requested_size; // 0x238
	private ToolTip tip_window; // 0x240
	private Timer tipdown_timer; // 0x248

	// Properties
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }
	[EditorBrowsable(1)]
	protected override bool DoubleBuffered { get; }
	[DefaultValue(0)]
	[Localizable(True)]
	public ToolBarAppearance Appearance { get; set; }
	[EditorBrowsable(0)]
	[DesignerSerializationVisibility(1)]
	[Browsable(True)]
	[Localizable(True)]
	[DefaultValue(True)]
	public override bool AutoSize { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Color BackColor { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Image BackgroundImage { get; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override ImageLayout BackgroundImageLayout { get; set; }
	[Localizable(True)]
	[MergableProperty(False)]
	[DesignerSerializationVisibility(2)]
	public ToolBar.ToolBarButtonCollection Buttons { get; }
	[RefreshProperties(1)]
	[Localizable(True)]
	public Size ButtonSize { get; set; }
	[DefaultValue(True)]
	public bool Divider { get; set; }
	[DefaultValue(1)]
	[Localizable(True)]
	public override DockStyle Dock { get; set; }
	[DefaultValue(False)]
	[Localizable(True)]
	public bool DropDownArrows { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Color ForeColor { get; set; }
	[DefaultValue(null)]
	public ImageList ImageList { get; set; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	[Browsable(False)]
	public Size ImageSize { get; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override RightToLeft RightToLeft { get; }
	[Localizable(True)]
	[DefaultValue(False)]
	public bool ShowToolTips { set; }
	[DefaultValue(False)]
	public bool TabStop { set; }
	[Bindable(False)]
	[EditorBrowsable(1)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override string Text { get; set; }
	[DefaultValue(0)]
	[Localizable(True)]
	public ToolBarTextAlign TextAlign { get; set; }
	[DefaultValue(True)]
	[Localizable(True)]
	public bool Wrappable { get; }
	private Timer TipDownTimer { get; }
	internal bool SizeSpecified { get; }
	internal bool Vertical { get; }
	private Size AdjustedButtonSize { get; }

	// Methods

	// RVA: 0x222A610 Offset: 0x2229010 VA: 0x18222A610
	public void .ctor() { }

	// RVA: 0x222A550 Offset: 0x2228F50 VA: 0x18222A550
	private static void .cctor() { }

	// RVA: 0x222AAD0 Offset: 0x22294D0 VA: 0x18222AAD0
	public void add_BackgroundImageChanged(EventHandler value) { }

	// RVA: 0x222B280 Offset: 0x2229C80 VA: 0x18222B280
	public void remove_BackgroundImageChanged(EventHandler value) { }

	// RVA: 0x222AAE0 Offset: 0x22294E0 VA: 0x18222AAE0
	public void add_ButtonClick(ToolBarButtonClickEventHandler value) { }

	// RVA: 0x222B290 Offset: 0x2229C90 VA: 0x18222B290
	public void remove_ButtonClick(ToolBarButtonClickEventHandler value) { }

	// RVA: 0x222AEA0 Offset: 0x22298A0 VA: 0x18222AEA0 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x222AEE0 Offset: 0x22298E0 VA: 0x18222AEE0 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x222AF80 Offset: 0x2229980 VA: 0x18222AF80 Slot: 61
	protected override bool get_DoubleBuffered() { }

	// RVA: 0x21D9300 Offset: 0x21D7D00 VA: 0x1821D9300
	public ToolBarAppearance get_Appearance() { }

	// RVA: 0x222B320 Offset: 0x2229D20 VA: 0x18222B320
	public void set_Appearance(ToolBarAppearance value) { }

	// RVA: 0x222AD80 Offset: 0x2229780 VA: 0x18222AD80 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x222B360 Offset: 0x2229D60 VA: 0x18222B360 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x222AD90 Offset: 0x2229790 VA: 0x18222AD90 Slot: 42
	public override Color get_BackColor() { }

	// RVA: 0x222B3A0 Offset: 0x2229DA0 VA: 0x18222B3A0 Slot: 43
	public override void set_BackColor(Color value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0 Slot: 44
	public override Image get_BackgroundImage() { }

	// RVA: 0x726440 Offset: 0x724E40 VA: 0x180726440 Slot: 45
	public override ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x21D0CE0 Offset: 0x21CF6E0 VA: 0x1821D0CE0 Slot: 46
	public override void set_BackgroundImageLayout(ImageLayout value) { }

	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public ToolBar.ToolBarButtonCollection get_Buttons() { }

	// RVA: 0x222ADB0 Offset: 0x22297B0 VA: 0x18222ADB0
	public Size get_ButtonSize() { }

	// RVA: 0x222B490 Offset: 0x2229E90 VA: 0x18222B490
	public void set_ButtonSize(Size value) { }

	// RVA: 0x68F9C0 Offset: 0x68E3C0 VA: 0x18068F9C0
	public bool get_Divider() { }

	// RVA: 0x222B520 Offset: 0x2229F20 VA: 0x18222B520
	public void set_Divider(bool value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340 Slot: 59
	public override DockStyle get_Dock() { }

	// RVA: 0x222B540 Offset: 0x2229F40 VA: 0x18222B540 Slot: 60
	public override void set_Dock(DockStyle value) { }

	// RVA: 0x222AF90 Offset: 0x2229990 VA: 0x18222AF90
	public bool get_DropDownArrows() { }

	// RVA: 0x222B640 Offset: 0x222A040 VA: 0x18222B640
	public void set_DropDownArrows(bool value) { }

	// RVA: 0x222AFA0 Offset: 0x22299A0 VA: 0x18222AFA0 Slot: 65
	public override Color get_ForeColor() { }

	// RVA: 0x222B680 Offset: 0x222A080 VA: 0x18222B680 Slot: 66
	public override void set_ForeColor(Color value) { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public ImageList get_ImageList() { }

	// RVA: 0x222B770 Offset: 0x222A170 VA: 0x18222B770
	public void set_ImageList(ImageList value) { }

	// RVA: 0x222AFC0 Offset: 0x22299C0 VA: 0x18222AFC0
	public Size get_ImageSize() { }

	// RVA: 0x222B020 Offset: 0x2229A20 VA: 0x18222B020 Slot: 68
	public override RightToLeft get_RightToLeft() { }

	// RVA: 0x222B7C0 Offset: 0x222A1C0 VA: 0x18222B7C0
	public void set_ShowToolTips(bool value) { }

	// RVA: 0x222B7D0 Offset: 0x222A1D0 VA: 0x18222B7D0
	public void set_TabStop(bool value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 69
	public override string get_Text() { }

	// RVA: 0x222B820 Offset: 0x222A220 VA: 0x18222B820 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x1A3C110 Offset: 0x1A3AB10 VA: 0x181A3C110
	public ToolBarTextAlign get_TextAlign() { }

	// RVA: 0x222B7E0 Offset: 0x222A1E0 VA: 0x18222B7E0
	public void set_TextAlign(ToolBarTextAlign value) { }

	// RVA: 0x222B270 Offset: 0x2229C70 VA: 0x18222B270
	public bool get_Wrappable() { }

	// RVA: 0x2229400 Offset: 0x2227E00 VA: 0x182229400 Slot: 3
	public override string ToString() { }

	// RVA: 0x22278E0 Offset: 0x22262E0 VA: 0x1822278E0 Slot: 89
	protected override void CreateHandle() { }

	// RVA: 0x2227930 Offset: 0x2226330 VA: 0x182227930 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2228F70 Offset: 0x2227970 VA: 0x182228F70
	private void PerformButtonClick(ToolBarButtonClickEventArgs e) { }

	// RVA: 0x2228AF0 Offset: 0x22274F0 VA: 0x182228AF0 Slot: 193
	protected virtual void OnButtonClick(ToolBarButtonClickEventArgs e) { }

	// RVA: 0x2228BC0 Offset: 0x22275C0 VA: 0x182228BC0 Slot: 194
	protected virtual void OnButtonDropDown(ToolBarButtonClickEventArgs e) { }

	// RVA: 0x2229270 Offset: 0x2227C70 VA: 0x182229270
	internal void ShowDropDownMenu(ToolBarItem item) { }

	// RVA: 0x2228E30 Offset: 0x2227830 VA: 0x182228E30 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x21C98D0 Offset: 0x21C82D0 VA: 0x1821C98D0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x2228F50 Offset: 0x2227950 VA: 0x182228F50 Slot: 181
	protected override void OnResize(EventArgs e) { }

	// RVA: 0x2229130 Offset: 0x2227B30 VA: 0x182229130 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	[EditorBrowsable(1)]
	// RVA: 0x2229140 Offset: 0x2227B40 VA: 0x182229140 Slot: 106
	protected override void ScaleCore(float dx, float dy) { }

	// RVA: 0x2229150 Offset: 0x2227B50 VA: 0x182229150 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x21DFEF0 Offset: 0x21DE8F0 VA: 0x1821DFEF0 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x22281B0 Offset: 0x2226BB0 VA: 0x1822281B0 Slot: 85
	internal override bool InternalPreProcessMessage(ref Message msg) { }

	// RVA: 0x22279A0 Offset: 0x22263A0 VA: 0x1822279A0
	private void FocusChanged(object sender, EventArgs args) { }

	// RVA: 0x2227B30 Offset: 0x2226530 VA: 0x182227B30
	private bool HandleKeyDown(ref Message msg, Keys key_data) { }

	// RVA: 0x2227DB0 Offset: 0x22267B0 VA: 0x182227DB0
	private bool HandleKeyOnDropDown(ref Message msg, Keys key_data) { }

	// RVA: 0x2227F10 Offset: 0x2226910 VA: 0x182227F10
	private void HighlightButton(int offset) { }

	// RVA: 0x2229530 Offset: 0x2227F30 VA: 0x182229530
	private void ToolBar_BackgroundImageChanged(object sender, EventArgs args) { }

	// RVA: 0x2229540 Offset: 0x2227F40 VA: 0x182229540
	private void ToolBar_MouseDown(object sender, MouseEventArgs me) { }

	// RVA: 0x222A020 Offset: 0x2228A20 VA: 0x18222A020
	private void ToolBar_MouseUp(object sender, MouseEventArgs me) { }

	// RVA: 0x2228230 Offset: 0x2226C30 VA: 0x182228230
	private ToolBarItem ItemAtPoint(Point pt) { }

	// RVA: 0x2229090 Offset: 0x2227A90 VA: 0x182229090
	private void PopDownTip(object o, EventArgs args) { }

	// RVA: 0x222B040 Offset: 0x2229A40 VA: 0x18222B040
	private Timer get_TipDownTimer() { }

	// RVA: 0x2229810 Offset: 0x2228210 VA: 0x182229810
	private void ToolBar_MouseHover(object sender, EventArgs e) { }

	// RVA: 0x2229950 Offset: 0x2228350 VA: 0x182229950
	private void ToolBar_MouseLeave(object sender, EventArgs e) { }

	// RVA: 0x2229A50 Offset: 0x2228450 VA: 0x182229A50
	private void ToolBar_MouseMove(object sender, MouseEventArgs me) { }

	// RVA: 0x2228E60 Offset: 0x2227860 VA: 0x182228E60 Slot: 167
	internal override void OnPaintInternal(PaintEventArgs pevent) { }

	// RVA: 0x22290C0 Offset: 0x2227AC0 VA: 0x1822290C0
	internal void Redraw(bool recalculate) { }

	// RVA: 0x22290F0 Offset: 0x2227AF0 VA: 0x1822290F0
	internal void Redraw(bool recalculate, bool force) { }

	// RVA: 0x222B030 Offset: 0x2229A30 VA: 0x18222B030
	internal bool get_SizeSpecified() { }

	// RVA: 0x222B220 Offset: 0x2229C20 VA: 0x18222B220
	internal bool get_Vertical() { }

	// RVA: 0x2227460 Offset: 0x2225E60 VA: 0x182227460
	private Size CalcButtonSize() { }

	// RVA: 0x222AB70 Offset: 0x2229570 VA: 0x18222AB70
	private Size get_AdjustedButtonSize() { }

	// RVA: 0x22282F0 Offset: 0x2226CF0 VA: 0x1822282F0
	private bool LayoutToolBar() { }
}
