public class ScrollableControl : Control // TypeDefIndex: 5562
{
	// Fields
	private bool force_hscroll_visible; // 0x1D8
	private bool force_vscroll_visible; // 0x1D9
	private bool auto_scroll; // 0x1DA
	private Size auto_scroll_margin; // 0x1DC
	private Size auto_scroll_min_size; // 0x1E4
	private Point scroll_position; // 0x1EC
	private ScrollableControl.DockPaddingEdges dock_padding; // 0x1F8
	private SizeGrip sizegrip; // 0x200
	internal ImplicitHScrollBar hscrollbar; // 0x208
	internal ImplicitVScrollBar vscrollbar; // 0x210
	internal Size canvas_size; // 0x218
	private Rectangle display_rectangle; // 0x220
	private Control old_parent; // 0x230
	private HScrollProperties horizontalScroll; // 0x238
	private VScrollProperties verticalScroll; // 0x240
	private static object OnScrollEvent; // 0x0

	// Properties
	[MWFCategory("Layout")]
	[Localizable(True)]
	[DefaultValue(False)]
	public virtual bool AutoScroll { get; }
	public override Rectangle DisplayRectangle { get; }
	protected override CreateParams CreateParams { get; }

	// Methods

	// RVA: 0x21E3330 Offset: 0x21E1D30 VA: 0x1821E3330
	public void .ctor() { }

	// RVA: 0x21E32B0 Offset: 0x21E1CB0 VA: 0x1821E32B0
	private static void .cctor() { }

	// RVA: 0x21E1590 Offset: 0x21DFF90 VA: 0x1821E1590
	private void VisibleChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x21E1DD0 Offset: 0x21E07D0 VA: 0x1821E1DD0
	private void LocationChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x21E21B0 Offset: 0x21E0BB0 VA: 0x1821E21B0
	private void ParentChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x21E1DD0 Offset: 0x21E07D0 VA: 0x1821E1DD0
	private void Parent_PaddingChanged(object sender, EventArgs e) { }

	// RVA: 0x21E1DD0 Offset: 0x21E07D0 VA: 0x1821E1DD0
	private void Parent_SizeChanged(object sender, EventArgs e) { }

	// RVA: 0x21E3640 Offset: 0x21E2040 VA: 0x1821E3640 Slot: 193
	public virtual bool get_AutoScroll() { }

	// RVA: 0x21E3650 Offset: 0x21E2050 VA: 0x1821E3650 Slot: 58
	public override Rectangle get_DisplayRectangle() { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21E2B00 Offset: 0x21E1500 VA: 0x1821E2B00
	public void ScrollControlIntoView(Control activeControl) { }

	[EditorBrowsable(2)]
	// RVA: 0x21E1590 Offset: 0x21DFF90 VA: 0x1821E1590 Slot: 194
	protected virtual void AdjustFormScrollbars(bool displayScrollbars) { }

	[EditorBrowsable(2)]
	// RVA: 0x21E1DE0 Offset: 0x21E07E0 VA: 0x1821E1DE0 Slot: 148
	protected override void OnLayout(LayoutEventArgs levent) { }

	[EditorBrowsable(2)]
	// RVA: 0x21E1EF0 Offset: 0x21E08F0 VA: 0x1821E1EF0 Slot: 161
	protected override void OnMouseWheel(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21E2130 Offset: 0x21E0B30 VA: 0x1821E2130 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	[EditorBrowsable(1)]
	// RVA: 0x21E2AA0 Offset: 0x21E14A0 VA: 0x1821E2AA0 Slot: 106
	protected override void ScaleCore(float dx, float dy) { }

	// RVA: 0x21CF6E0 Offset: 0x21CE0E0 VA: 0x1821CF6E0 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	[EditorBrowsable(2)]
	// RVA: 0x21DFEF0 Offset: 0x21DE8F0 VA: 0x1821DFEF0 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x21E15A0 Offset: 0x21DFFA0 VA: 0x1821E15A0 Slot: 113
	internal override IntPtr AfterTopMostControl() { }

	// RVA: 0x21E1610 Offset: 0x21E0010 VA: 0x1821E1610 Slot: 195
	internal virtual void CalculateCanvasSize(bool canOverride) { }

	// RVA: 0x21E2A90 Offset: 0x21E1490 VA: 0x1821E2A90
	private void Recalculate(object sender, EventArgs e) { }

	// RVA: 0x21E2350 Offset: 0x21E0D50 VA: 0x1821E2350
	private void Recalculate(bool doLayout) { }

	// RVA: 0x21E3020 Offset: 0x21E1A20 VA: 0x1821E3020
	internal void UpdateSizeGripVisible() { }

	// RVA: 0x21E1D00 Offset: 0x21E0700 VA: 0x1821E1D00
	private void HandleScrollBar(object sender, EventArgs e) { }

	// RVA: 0x21E1DB0 Offset: 0x21E07B0 VA: 0x1821E1DB0
	private void HandleScrollEvent(object sender, ScrollEventArgs args) { }

	// RVA: 0x21E13C0 Offset: 0x21DFDC0 VA: 0x1821E13C0
	private void AddScrollbars(object o, EventArgs e) { }

	// RVA: 0x21E1970 Offset: 0x21E0370 VA: 0x1821E1970
	private void CreateScrollbars() { }

	// RVA: 0x21E2DE0 Offset: 0x21E17E0 VA: 0x1821E2DE0
	private void ScrollWindow(int XOffset, int YOffset) { }

	// RVA: 0x21E2060 Offset: 0x21E0A60 VA: 0x1821E2060 Slot: 196
	protected virtual void OnScroll(ScrollEventArgs se) { }

	// RVA: 0x21E2040 Offset: 0x21E0A40 VA: 0x1821E2040 Slot: 164
	protected override void OnPaddingChanged(EventArgs e) { }

	// RVA: 0x21C76A0 Offset: 0x21C60A0 VA: 0x1821C76A0 Slot: 168
	protected override void OnPaintBackground(PaintEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21E2050 Offset: 0x21E0A50 VA: 0x1821E2050 Slot: 183
	protected override void OnRightToLeftChanged(EventArgs e) { }
}
