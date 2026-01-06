public class ToolStrip : ScrollableControl, IDisposable, IComponent // TypeDefIndex: 5609
{
	// Fields
	private bool allow_merge; // 0x248
	private Color back_color; // 0x250
	private bool can_overflow; // 0x268
	private ToolStrip currently_merged_with; // 0x270
	private ToolStripDropDownDirection default_drop_down_direction; // 0x278
	internal ToolStripItemCollection displayed_items; // 0x280
	private Color fore_color; // 0x288
	private Padding grip_margin; // 0x2A0
	private ToolStripGripStyle grip_style; // 0x2B4
	private List<ToolStripItem> hidden_merged_items; // 0x2B8
	private ImageList image_list; // 0x2C0
	private Size image_scaling_size; // 0x2C8
	private bool is_currently_merged; // 0x2D0
	private ToolStripItemCollection items; // 0x2D8
	private bool keyboard_active; // 0x2E0
	private LayoutEngine layout_engine; // 0x2E8
	private LayoutSettings layout_settings; // 0x2F0
	private ToolStripLayoutStyle layout_style; // 0x2F8
	private Orientation orientation; // 0x2FC
	private ToolStripOverflowButton overflow_button; // 0x300
	private List<ToolStripItem> pre_merge_items; // 0x308
	private ToolStripRenderer renderer; // 0x310
	private ToolStripRenderMode render_mode; // 0x318
	private ToolStripTextDirection text_direction; // 0x31C
	private Timer tooltip_timer; // 0x320
	private ToolTip tooltip_window; // 0x328
	private bool show_item_tool_tips; // 0x330
	private ToolStripItem mouse_currently_over; // 0x338
	internal bool menu_selected; // 0x340
	private ToolStripItem tooltip_currently_showing; // 0x348
	private static object BeginDragEvent; // 0x0
	private static object EndDragEvent; // 0x8
	private static object ItemAddedEvent; // 0x10
	private static object ItemClickedEvent; // 0x18
	private static object ItemRemovedEvent; // 0x20
	private static object LayoutCompletedEvent; // 0x28
	private static object LayoutStyleChangedEvent; // 0x30
	private static object PaintGripEvent; // 0x38
	private static object RendererChangedEvent; // 0x40

	// Properties
	[MonoTODO("Stub, does nothing")]
	public override bool AllowDrop { get; }
	[DefaultValue(True)]
	public bool AllowMerge { get; }
	public override AnchorStyles Anchor { get; set; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	[DesignerSerializationVisibility(0)]
	public override bool AutoScroll { get; }
	[EditorBrowsable(0)]
	[Browsable(True)]
	[DefaultValue(True)]
	[DesignerSerializationVisibility(1)]
	public override bool AutoSize { get; set; }
	public Color BackColor { get; }
	public override BindingContext BindingContext { get; set; }
	[DefaultValue(True)]
	public bool CanOverflow { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override Cursor Cursor { get; set; }
	[Browsable(False)]
	public virtual ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
	public override Rectangle DisplayRectangle { get; }
	[DefaultValue(1)]
	public override DockStyle Dock { get; set; }
	public override Font Font { get; set; }
	[Browsable(False)]
	public Color ForeColor { get; }
	[Browsable(False)]
	public ToolStripGripDisplayStyle GripDisplayStyle { get; }
	public Padding GripMargin { get; }
	[Browsable(False)]
	public Rectangle GripRectangle { get; }
	[DefaultValue(1)]
	public ToolStripGripStyle GripStyle { set; }
	[Browsable(False)]
	[DefaultValue(null)]
	public ImageList ImageList { get; }
	[DefaultValue("{Width=16, Height=16}")]
	public Size ImageScalingSize { get; }
	[DesignerSerializationVisibility(2)]
	[MergableProperty(False)]
	public virtual ToolStripItemCollection Items { get; }
	public override LayoutEngine LayoutEngine { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[DefaultValue(null)]
	public LayoutSettings LayoutSettings { get; }
	[AmbientValue(0)]
	public ToolStripLayoutStyle LayoutStyle { get; set; }
	[Browsable(False)]
	public Orientation Orientation { get; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	public ToolStripOverflowButton OverflowButton { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public ToolStripRenderer Renderer { get; set; }
	public ToolStripRenderMode RenderMode { get; }
	[DefaultValue(1)]
	public virtual ToolStripTextDirection TextDirection { get; }
	protected virtual DockStyle DefaultDock { get; }
	protected virtual Padding DefaultGripMargin { get; }
	protected override Padding DefaultMargin { get; }
	protected override Padding DefaultPadding { get; }
	protected virtual bool DefaultShowItemToolTips { get; }
	protected override Size DefaultSize { get; }
	protected internal virtual ToolStripItemCollection DisplayedItems { get; }
	internal virtual bool KeyboardActive { get; set; }
	private Timer ToolTipTimer { get; }
	private ToolTip ToolTipWindow { get; }
	internal ToolStrip CurrentlyMergedWith { get; set; }
	internal List<ToolStripItem> HiddenMergedItems { get; }
	internal bool IsCurrentlyMerged { get; set; }

	// Methods

	// RVA: 0x2245B00 Offset: 0x2244500 VA: 0x182245B00
	public void .ctor() { }

	// RVA: 0x2245B10 Offset: 0x2244510 VA: 0x182245B10
	public void .ctor(ToolStripItem[] items) { }

	// RVA: 0x2245860 Offset: 0x2244260 VA: 0x182245860
	private static void .cctor() { }

	// RVA: 0x2245F10 Offset: 0x2244910 VA: 0x182245F10
	public void add_ItemAdded(ToolStripItemEventHandler value) { }

	// RVA: 0x2246AF0 Offset: 0x22454F0 VA: 0x182246AF0
	public void remove_ItemAdded(ToolStripItemEventHandler value) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0 Slot: 34
	public override bool get_AllowDrop() { }

	// RVA: 0x640EC0 Offset: 0x63F8C0 VA: 0x180640EC0
	public bool get_AllowMerge() { }

	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0 Slot: 35
	public override AnchorStyles get_Anchor() { }

	// RVA: 0x2233C30 Offset: 0x2232630 VA: 0x182233C30 Slot: 36
	public override void set_Anchor(AnchorStyles value) { }

	// RVA: 0x21E3640 Offset: 0x21E2040 VA: 0x1821E3640 Slot: 193
	public override bool get_AutoScroll() { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x21C7C30 Offset: 0x21C6630 VA: 0x1821C7C30 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x2245FA0 Offset: 0x22449A0 VA: 0x182245FA0
	public Color get_BackColor() { }

	// RVA: 0x2245FC0 Offset: 0x22449C0 VA: 0x182245FC0 Slot: 47
	public override BindingContext get_BindingContext() { }

	// RVA: 0x2246B80 Offset: 0x2245580 VA: 0x182246B80 Slot: 48
	public override void set_BindingContext(BindingContext value) { }

	// RVA: 0x595640 Offset: 0x594040 VA: 0x180595640
	public bool get_CanOverflow() { }

	// RVA: 0x2245FD0 Offset: 0x22449D0 VA: 0x182245FD0 Slot: 56
	public override Cursor get_Cursor() { }

	// RVA: 0x2246B90 Offset: 0x2245590 VA: 0x182246B90 Slot: 57
	public override void set_Cursor(Cursor value) { }

	// RVA: 0x2233AD0 Offset: 0x22324D0 VA: 0x182233AD0 Slot: 197
	public virtual ToolStripDropDownDirection get_DefaultDropDownDirection() { }

	// RVA: 0x2233C40 Offset: 0x2232640 VA: 0x182233C40 Slot: 198
	public virtual void set_DefaultDropDownDirection(ToolStripDropDownDirection value) { }

	// RVA: 0x22460E0 Offset: 0x2244AE0 VA: 0x1822460E0 Slot: 58
	public override Rectangle get_DisplayRectangle() { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340 Slot: 59
	public override DockStyle get_Dock() { }

	// RVA: 0x2233DA0 Offset: 0x22327A0 VA: 0x182233DA0 Slot: 60
	public override void set_Dock(DockStyle value) { }

	// RVA: 0x21E0540 Offset: 0x21DEF40 VA: 0x1821E0540 Slot: 63
	public override Font get_Font() { }

	// RVA: 0x2246BA0 Offset: 0x22455A0 VA: 0x182246BA0 Slot: 64
	public override void set_Font(Font value) { }

	// RVA: 0x2246620 Offset: 0x2245020 VA: 0x182246620
	public Color get_ForeColor() { }

	// RVA: 0x2246640 Offset: 0x2245040 VA: 0x182246640
	public ToolStripGripDisplayStyle get_GripDisplayStyle() { }

	// RVA: 0x2246650 Offset: 0x2245050 VA: 0x182246650
	public Padding get_GripMargin() { }

	// RVA: 0x2246670 Offset: 0x2245070 VA: 0x182246670
	public Rectangle get_GripRectangle() { }

	// RVA: 0x2233E10 Offset: 0x2232810 VA: 0x182233E10
	public void set_GripStyle(ToolStripGripStyle value) { }

	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public ImageList get_ImageList() { }

	// RVA: 0x640C40 Offset: 0x63F640 VA: 0x180640C40
	public Size get_ImageScalingSize() { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 199
	public virtual ToolStripItemCollection get_Items() { }

	// RVA: 0x2230FE0 Offset: 0x222F9E0 VA: 0x182230FE0 Slot: 67
	public override LayoutEngine get_LayoutEngine() { }

	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40
	public LayoutSettings get_LayoutSettings() { }

	// RVA: 0x7447D0 Offset: 0x7431D0 VA: 0x1807447D0
	public ToolStripLayoutStyle get_LayoutStyle() { }

	// RVA: 0x2247210 Offset: 0x2245C10 VA: 0x182247210
	public void set_LayoutStyle(ToolStripLayoutStyle value) { }

	// RVA: 0x7447E0 Offset: 0x7431E0 VA: 0x1807447E0
	public Orientation get_Orientation() { }

	// RVA: 0x6DFA80 Offset: 0x6DE480 VA: 0x1806DFA80
	public ToolStripOverflowButton get_OverflowButton() { }

	// RVA: 0x22468B0 Offset: 0x22452B0 VA: 0x1822468B0
	public ToolStripRenderer get_Renderer() { }

	// RVA: 0x2247500 Offset: 0x2245F00 VA: 0x182247500
	public void set_Renderer(ToolStripRenderer value) { }

	// RVA: 0x22468A0 Offset: 0x22452A0 VA: 0x1822468A0
	public ToolStripRenderMode get_RenderMode() { }

	// RVA: 0x2233B50 Offset: 0x2232550 VA: 0x182233B50 Slot: 200
	public virtual ToolStripTextDirection get_TextDirection() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 201
	protected virtual DockStyle get_DefaultDock() { }

	// RVA: 0x2245FE0 Offset: 0x22449E0 VA: 0x182245FE0 Slot: 202
	protected virtual Padding get_DefaultGripMargin() { }

	// RVA: 0x2246010 Offset: 0x2244A10 VA: 0x182246010 Slot: 74
	protected override Padding get_DefaultMargin() { }

	// RVA: 0x2246070 Offset: 0x2244A70 VA: 0x182246070 Slot: 75
	protected override Padding get_DefaultPadding() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 203
	protected virtual bool get_DefaultShowItemToolTips() { }

	// RVA: 0x22460B0 Offset: 0x2244AB0 VA: 0x1822460B0 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 204
	protected internal virtual ToolStripItemCollection get_DisplayedItems() { }

	// RVA: 0x223F480 Offset: 0x223DE80 VA: 0x18223F480
	public ToolStripItem GetItemAt(Point point) { }

	// RVA: 0x223F440 Offset: 0x223DE40 VA: 0x18223F440
	public ToolStripItem GetItemAt(int x, int y) { }

	// RVA: 0x223F6B0 Offset: 0x223E0B0 VA: 0x18223F6B0 Slot: 205
	public virtual ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction) { }

	// RVA: 0x2245690 Offset: 0x2244090 VA: 0x182245690 Slot: 3
	public override string ToString() { }

	// RVA: 0x223EB90 Offset: 0x223D590 VA: 0x18223EB90 Slot: 88
	protected override Control.ControlCollection CreateControlsInstance() { }

	// RVA: 0x223EBA0 Offset: 0x223D5A0 VA: 0x18223EBA0 Slot: 206
	protected internal virtual ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick) { }

	// RVA: 0x22315F0 Offset: 0x222FFF0 VA: 0x1822315F0 Slot: 207
	protected virtual LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle layoutStyle) { }

	// RVA: 0x22316A0 Offset: 0x22300A0 VA: 0x1822316A0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2242100 Offset: 0x2240B00 VA: 0x182242100 Slot: 128
	protected override void OnDockChanged(EventArgs e) { }

	// RVA: 0x22417A0 Offset: 0x22401A0 VA: 0x1822417A0 Slot: 94
	protected override bool IsInputChar(char charCode) { }

	// RVA: 0x22417B0 Offset: 0x22401B0 VA: 0x1822417B0 Slot: 96
	protected override bool IsInputKey(Keys keyData) { }

	// RVA: 0x2242110 Offset: 0x2240B10 VA: 0x182242110 Slot: 134
	protected override void OnEnabledChanged(EventArgs e) { }

	// RVA: 0x21C88C0 Offset: 0x21C72C0 VA: 0x1821C88C0 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x21C98D0 Offset: 0x21C82D0 VA: 0x1821C98D0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x21CDD00 Offset: 0x21CC700 VA: 0x1821CDD00 Slot: 141
	protected override void OnHandleDestroyed(EventArgs e) { }

	// RVA: 0x2242380 Offset: 0x2240D80 VA: 0x182242380 Slot: 144
	protected override void OnInvalidated(InvalidateEventArgs e) { }

	// RVA: 0x2242390 Offset: 0x2240D90 VA: 0x182242390 Slot: 208
	protected internal virtual void OnItemAdded(ToolStripItemEventArgs e) { }

	// RVA: 0x2231AF0 Offset: 0x22304F0 VA: 0x182231AF0 Slot: 209
	protected virtual void OnItemClicked(ToolStripItemClickedEventArgs e) { }

	// RVA: 0x2242590 Offset: 0x2240F90 VA: 0x182242590 Slot: 210
	protected internal virtual void OnItemRemoved(ToolStripItemEventArgs e) { }

	// RVA: 0x2242830 Offset: 0x2241230 VA: 0x182242830 Slot: 148
	protected override void OnLayout(LayoutEventArgs e) { }

	// RVA: 0x2242670 Offset: 0x2241070 VA: 0x182242670 Slot: 211
	protected virtual void OnLayoutCompleted(EventArgs e) { }

	// RVA: 0x2242750 Offset: 0x2241150 VA: 0x182242750 Slot: 212
	protected virtual void OnLayoutStyleChanged(EventArgs e) { }

	// RVA: 0x22428E0 Offset: 0x22412E0 VA: 0x1822428E0 Slot: 149
	protected override void OnLeave(EventArgs e) { }

	// RVA: 0x22428F0 Offset: 0x22412F0 VA: 0x1822428F0 Slot: 151
	protected override void OnLostFocus(EventArgs e) { }

	// RVA: 0x2242900 Offset: 0x2241300 VA: 0x182242900 Slot: 152
	protected override void OnMouseCaptureChanged(EventArgs e) { }

	// RVA: 0x2242910 Offset: 0x2241310 VA: 0x182242910 Slot: 155
	protected override void OnMouseDown(MouseEventArgs mea) { }

	// RVA: 0x2242C00 Offset: 0x2241600 VA: 0x182242C00 Slot: 158
	protected override void OnMouseLeave(EventArgs e) { }

	// RVA: 0x2242CD0 Offset: 0x22416D0 VA: 0x182242CD0 Slot: 159
	protected override void OnMouseMove(MouseEventArgs mea) { }

	// RVA: 0x2232440 Offset: 0x2230E40 VA: 0x182232440 Slot: 160
	protected override void OnMouseUp(MouseEventArgs mea) { }

	// RVA: 0x2243490 Offset: 0x2241E90 VA: 0x182243490 Slot: 165
	protected override void OnPaint(PaintEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22430C0 Offset: 0x2241AC0 VA: 0x1822430C0 Slot: 168
	protected override void OnPaintBackground(PaintEventArgs e) { }

	// RVA: 0x2243220 Offset: 0x2241C20 VA: 0x182243220 Slot: 213
	protected internal virtual void OnPaintGrip(PaintEventArgs e) { }

	// RVA: 0x2243980 Offset: 0x2242380 VA: 0x182243980 Slot: 214
	protected virtual void OnRendererChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2243A60 Offset: 0x2242460 VA: 0x182243A60 Slot: 183
	protected override void OnRightToLeftChanged(EventArgs e) { }

	// RVA: 0x2243CA0 Offset: 0x22426A0 VA: 0x182243CA0 Slot: 196
	protected override void OnScroll(ScrollEventArgs se) { }

	// RVA: 0x2243CB0 Offset: 0x22426B0 VA: 0x182243CB0 Slot: 188
	protected override void OnTabStopChanged(EventArgs e) { }

	// RVA: 0x2243CC0 Offset: 0x22426C0 VA: 0x182243CC0 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	// RVA: 0x21E8F60 Offset: 0x21E7960 VA: 0x1821E8F60 Slot: 98
	protected override bool ProcessCmdKey(ref Message m, Keys keyData) { }

	// RVA: 0x2243EB0 Offset: 0x22428B0 VA: 0x182243EB0 Slot: 100
	protected override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x22445A0 Offset: 0x2242FA0 VA: 0x1822445A0 Slot: 104
	protected override bool ProcessMnemonic(char charCode) { }

	// RVA: 0x2245020 Offset: 0x2243A20 VA: 0x182245020 Slot: 107
	protected override void Select(bool directed, bool forward) { }

	// RVA: 0x2232D80 Offset: 0x2231780 VA: 0x182232D80 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x22451E0 Offset: 0x2243BE0 VA: 0x1822451E0 Slot: 215
	protected virtual void SetDisplayedItems() { }

	// RVA: 0x22454C0 Offset: 0x2243EC0 VA: 0x1822454C0
	protected internal static void SetItemParent(ToolStripItem item, ToolStrip parent) { }

	// RVA: 0x2232D90 Offset: 0x2231790 VA: 0x182232D90 Slot: 111
	protected override void SetVisibleCore(bool visible) { }

	// RVA: 0x2245850 Offset: 0x2244250 VA: 0x182245850 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x81F190 Offset: 0x81DB90 VA: 0x18081F190 Slot: 216
	internal virtual bool get_KeyboardActive() { }

	// RVA: 0x22470B0 Offset: 0x2245AB0 VA: 0x1822470B0 Slot: 217
	internal virtual void set_KeyboardActive(bool value) { }

	// RVA: 0x223E5E0 Offset: 0x223CFE0 VA: 0x18223E5E0 Slot: 218
	internal virtual Rectangle CalculateConnectedArea() { }

	// RVA: 0x223E630 Offset: 0x223D030 VA: 0x18223E630
	internal void ChangeSelection(ToolStripItem nextItem) { }

	// RVA: 0x223ED90 Offset: 0x223D790 VA: 0x18223ED90 Slot: 219
	internal virtual void Dismiss(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x223F270 Offset: 0x223DC70 VA: 0x18223F270
	internal ToolStripItem GetCurrentlySelectedItem() { }

	// RVA: 0x223F000 Offset: 0x223DA00 VA: 0x18223F000
	internal ToolStripItem GetCurrentlyFocusedItem() { }

	// RVA: 0x2240840 Offset: 0x223F240 VA: 0x182240840 Slot: 33
	internal override Size GetPreferredSizeCore(Size proposedSize) { }

	// RVA: 0x2240860 Offset: 0x223F260 VA: 0x182240860 Slot: 220
	internal virtual Size GetToolStripPreferredSize(Size proposedSize) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 221
	internal virtual ToolStrip GetTopLevelToolStrip() { }

	// RVA: 0x2241670 Offset: 0x2240070 VA: 0x182241670 Slot: 222
	internal virtual void HandleItemClick(ToolStripItem dismissingItem) { }

	// RVA: 0x22416C0 Offset: 0x22400C0 VA: 0x1822416C0
	internal void HideMenus(bool release, ToolStripDropDownCloseReason reason) { }

	// RVA: 0x22418D0 Offset: 0x22402D0 VA: 0x1822418D0
	internal void NotifySelectedChanged(ToolStripItem tsi) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 223
	internal virtual bool OnMenuKey() { }

	// RVA: 0x2243CD0 Offset: 0x22426D0 VA: 0x182243CD0 Slot: 224
	internal virtual bool ProcessArrowKey(Keys keyData) { }

	// RVA: 0x2244F00 Offset: 0x2243900 VA: 0x182244F00 Slot: 225
	internal virtual ToolStripItem SelectNextToolStripItem(ToolStripItem start, bool forward) { }

	// RVA: 0x22417C0 Offset: 0x22401C0 VA: 0x1822417C0
	private void MouseEnteredItem(ToolStripItem item) { }

	// RVA: 0x2241870 Offset: 0x2240270 VA: 0x182241870
	private void MouseLeftItem(ToolStripItem item) { }

	// RVA: 0x2246950 Offset: 0x2245350 VA: 0x182246950
	private Timer get_ToolTipTimer() { }

	// RVA: 0x2246A70 Offset: 0x2245470 VA: 0x182246A70
	private ToolTip get_ToolTipWindow() { }

	// RVA: 0x2245740 Offset: 0x2244140 VA: 0x182245740
	private void ToolTipTimer_Tick(object o, EventArgs args) { }

	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0
	internal ToolStrip get_CurrentlyMergedWith() { }

	// RVA: 0x718BB0 Offset: 0x7175B0 VA: 0x180718BB0
	internal void set_CurrentlyMergedWith(ToolStrip value) { }

	// RVA: 0x2246800 Offset: 0x2245200 VA: 0x182246800
	internal List<ToolStripItem> get_HiddenMergedItems() { }

	// RVA: 0x2246890 Offset: 0x2245290 VA: 0x182246890
	internal bool get_IsCurrentlyMerged() { }

	// RVA: 0x2246E20 Offset: 0x2245820 VA: 0x182246E20
	internal void set_IsCurrentlyMerged(bool value) { }

	// RVA: 0x223E2D0 Offset: 0x223CCD0 VA: 0x18223E2D0
	internal void BeginMerge() { }

	// RVA: 0x2244BC0 Offset: 0x22435C0 VA: 0x182244BC0
	internal void RevertMergeItem(ToolStripItem item) { }
}
