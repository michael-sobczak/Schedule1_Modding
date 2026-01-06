public class ToolStripDropDown : ToolStrip // TypeDefIndex: 5615
{
	// Fields
	private bool allow_transparency; // 0x350
	private bool auto_close; // 0x351
	private bool drop_shadow_enabled; // 0x352
	private double opacity; // 0x358
	private ToolStripItem owner_item; // 0x360
	private static object ClosedEvent; // 0x0
	private static object ClosingEvent; // 0x8
	private static object OpenedEvent; // 0x10
	private static object OpeningEvent; // 0x18
	private static object ScrollEvent; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override AnchorStyles Anchor { get; set; }
	[DefaultValue(True)]
	public override bool AutoSize { get; set; }
	public override ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
	[Browsable(False)]
	[DefaultValue(0)]
	[EditorBrowsable(0)]
	public override DockStyle Dock { get; set; }
	public override Font Font { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	[DefaultValue(0)]
	public ToolStripGripStyle GripStyle { set; }
	[EditorBrowsable(1)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public Point Location { get; set; }
	[DefaultValue(1)]
	[Browsable(False)]
	[EditorBrowsable(2)]
	[TypeConverter(typeof(OpacityConverter))]
	public double Opacity { get; }
	[DefaultValue(null)]
	[Browsable(False)]
	public ToolStripItem OwnerItem { get; set; }
	[Localizable(True)]
	[AmbientValue(2)]
	public override RightToLeft RightToLeft { get; }
	[Browsable(False)]
	[DefaultValue(1)]
	public override ToolStripTextDirection TextDirection { get; }
	[Localizable(True)]
	[DefaultValue(False)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public bool Visible { get; }
	protected override CreateParams CreateParams { get; }
	protected override DockStyle DefaultDock { get; }
	protected override Padding DefaultPadding { get; }
	protected override bool DefaultShowItemToolTips { get; }
	protected virtual bool TopMost { get; }
	internal override bool ActivateOnShow { get; }
	internal ToolStripItem TopLevelOwnerItem { get; }

	// Methods

	// RVA: 0x2233810 Offset: 0x2232210 VA: 0x182233810
	public void .ctor() { }

	// RVA: 0x2233680 Offset: 0x2232080 VA: 0x182233680
	private static void .cctor() { }

	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0 Slot: 35
	public override AnchorStyles get_Anchor() { }

	// RVA: 0x2233C30 Offset: 0x2232630 VA: 0x182233C30 Slot: 36
	public override void set_Anchor(AnchorStyles value) { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x21C7C30 Offset: 0x21C6630 VA: 0x1821C7C30 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x2233AD0 Offset: 0x22324D0 VA: 0x182233AD0 Slot: 197
	public override ToolStripDropDownDirection get_DefaultDropDownDirection() { }

	// RVA: 0x2233C40 Offset: 0x2232640 VA: 0x182233C40 Slot: 198
	public override void set_DefaultDropDownDirection(ToolStripDropDownDirection value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340 Slot: 59
	public override DockStyle get_Dock() { }

	// RVA: 0x2233DA0 Offset: 0x22327A0 VA: 0x182233DA0 Slot: 60
	public override void set_Dock(DockStyle value) { }

	// RVA: 0x21E0540 Offset: 0x21DEF40 VA: 0x1821E0540 Slot: 63
	public override Font get_Font() { }

	// RVA: 0x2233E00 Offset: 0x2232800 VA: 0x182233E00 Slot: 64
	public override void set_Font(Font value) { }

	// RVA: 0x2233E10 Offset: 0x2232810 VA: 0x182233E10
	public void set_GripStyle(ToolStripGripStyle value) { }

	// RVA: 0x2233B20 Offset: 0x2232520 VA: 0x182233B20
	public Point get_Location() { }

	// RVA: 0x2233FA0 Offset: 0x22329A0 VA: 0x182233FA0
	public void set_Location(Point value) { }

	// RVA: 0x2233B30 Offset: 0x2232530 VA: 0x182233B30
	public double get_Opacity() { }

	// RVA: 0x2233B40 Offset: 0x2232540 VA: 0x182233B40
	public ToolStripItem get_OwnerItem() { }

	// RVA: 0x2233FB0 Offset: 0x22329B0 VA: 0x182233FB0
	public void set_OwnerItem(ToolStripItem value) { }

	// RVA: 0x222B020 Offset: 0x2229A20 VA: 0x18222B020 Slot: 68
	public override RightToLeft get_RightToLeft() { }

	// RVA: 0x2233B50 Offset: 0x2232550 VA: 0x182233B50 Slot: 200
	public override ToolStripTextDirection get_TextDirection() { }

	// RVA: 0x2233C20 Offset: 0x2232620 VA: 0x182233C20
	public bool get_Visible() { }

	// RVA: 0x2233A40 Offset: 0x2232440 VA: 0x182233A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 201
	protected override DockStyle get_DefaultDock() { }

	// RVA: 0x2233AE0 Offset: 0x22324E0 VA: 0x182233AE0 Slot: 75
	protected override Padding get_DefaultPadding() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 203
	protected override bool get_DefaultShowItemToolTips() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 226
	protected virtual bool get_TopMost() { }

	// RVA: 0x2231080 Offset: 0x222FA80 VA: 0x182231080
	public void Close(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x2232DA0 Offset: 0x22317A0 VA: 0x182232DA0
	public void Show(Point screenLocation) { }

	// RVA: 0x2233490 Offset: 0x2231E90 VA: 0x182233490
	public void Show(Control control, Point position) { }

	// RVA: 0x2232DE0 Offset: 0x22317E0 VA: 0x182232DE0
	public void Show(Point position, ToolStripDropDownDirection direction) { }

	// RVA: 0x21CC130 Offset: 0x21CAB30 VA: 0x1821CC130 Slot: 89
	protected override void CreateHandle() { }

	// RVA: 0x22315F0 Offset: 0x222FFF0 VA: 0x1822315F0 Slot: 207
	protected override LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle style) { }

	// RVA: 0x22316A0 Offset: 0x22300A0 VA: 0x1822316A0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2231810 Offset: 0x2230210 VA: 0x182231810 Slot: 227
	protected virtual void OnClosed(ToolStripDropDownClosedEventArgs e) { }

	// RVA: 0x22318E0 Offset: 0x22302E0 VA: 0x1822318E0 Slot: 228
	protected virtual void OnClosing(ToolStripDropDownClosingEventArgs e) { }

	// RVA: 0x22319C0 Offset: 0x22303C0 VA: 0x1822319C0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x2231AF0 Offset: 0x22304F0 VA: 0x182231AF0 Slot: 209
	protected override void OnItemClicked(ToolStripItemClickedEventArgs e) { }

	// RVA: 0x2231C10 Offset: 0x2230610 VA: 0x182231C10 Slot: 148
	protected override void OnLayout(LayoutEventArgs e) { }

	// RVA: 0x2232440 Offset: 0x2230E40 VA: 0x182232440 Slot: 160
	protected override void OnMouseUp(MouseEventArgs mea) { }

	// RVA: 0x22325C0 Offset: 0x2230FC0 VA: 0x1822325C0 Slot: 229
	protected virtual void OnOpened(EventArgs e) { }

	// RVA: 0x22326A0 Offset: 0x22310A0 VA: 0x1822326A0 Slot: 230
	protected virtual void OnOpening(CancelEventArgs e) { }

	// RVA: 0x2232780 Offset: 0x2231180 VA: 0x182232780 Slot: 171
	protected override void OnParentChanged(EventArgs e) { }

	// RVA: 0x2232860 Offset: 0x2231260 VA: 0x182232860 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2232CC0 Offset: 0x22316C0 VA: 0x182232CC0 Slot: 99
	protected override bool ProcessDialogChar(char charCode) { }

	// RVA: 0x2232CD0 Offset: 0x22316D0 VA: 0x182232CD0 Slot: 100
	protected override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x2232CF0 Offset: 0x22316F0 VA: 0x182232CF0 Slot: 104
	protected override bool ProcessMnemonic(char charCode) { }

	// RVA: 0x2232D00 Offset: 0x2231700 VA: 0x182232D00 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	[EditorBrowsable(1)]
	// RVA: 0x2232D10 Offset: 0x2231710 VA: 0x182232D10 Slot: 106
	protected override void ScaleCore(float dx, float dy) { }

	// RVA: 0x2232D80 Offset: 0x2231780 VA: 0x182232D80 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x2232D90 Offset: 0x2231790 VA: 0x182232D90 Slot: 111
	protected override void SetVisibleCore(bool visible) { }

	// RVA: 0x2233640 Offset: 0x2232040 VA: 0x182233640 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x2231670 Offset: 0x2230070 VA: 0x182231670 Slot: 219
	internal override void Dismiss(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x22317E0 Offset: 0x22301E0 VA: 0x1822317E0 Slot: 221
	internal override ToolStrip GetTopLevelToolStrip() { }

	// RVA: 0x22329D0 Offset: 0x22313D0 VA: 0x1822329D0 Slot: 224
	internal override bool ProcessArrowKey(Keys keyData) { }

	// RVA: 0x2232D20 Offset: 0x2231720 VA: 0x182232D20 Slot: 225
	internal override ToolStripItem SelectNextToolStripItem(ToolStripItem start, bool forward) { }

	// RVA: 0x2233600 Offset: 0x2232000 VA: 0x182233600
	private void ToolStripMenuTracker_AppFocusChange(object sender, EventArgs e) { }

	// RVA: 0x22335B0 Offset: 0x2231FB0 VA: 0x1822335B0
	private void ToolStripMenuTracker_AppClicked(object sender, EventArgs e) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	internal override bool get_ActivateOnShow() { }

	// RVA: 0x2233B60 Offset: 0x2232560 VA: 0x182233B60
	internal ToolStripItem get_TopLevelOwnerItem() { }
}
