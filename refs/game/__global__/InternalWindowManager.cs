internal abstract class InternalWindowManager // TypeDefIndex: 5417
{
	// Fields
	private TitleButtons title_buttons; // 0x10
	internal Form form; // 0x18
	internal Point start; // 0x20
	internal InternalWindowManager.State state; // 0x28
	protected Point clicked_point; // 0x2C
	private InternalWindowManager.FormPos sizing_edge; // 0x34
	internal Rectangle virtual_position; // 0x38
	private Rectangle normal_bounds; // 0x48
	private Rectangle iconic_bounds; // 0x58

	// Properties
	public Form Form { get; }
	public int IconWidth { get; }
	public TitleButtons TitleButtons { get; }
	internal Rectangle NormalBounds { get; set; }
	internal Size IconicSize { get; }
	internal Rectangle IconicBounds { get; set; }
	internal virtual Rectangle MaximizedBounds { get; }
	public bool ShowIcon { get; }
	public virtual bool IsActive { get; }
	public bool IsMaximized { get; }
	public bool IsMinimized { get; }
	public bool IsSizable { get; }
	public bool HasBorders { get; }
	public bool IsToolWindow { get; }
	public int TitleBarHeight { get; }
	public int BorderWidth { get; }
	public virtual int MenuHeight { get; }

	// Methods

	// RVA: 0x234CE60 Offset: 0x234B860 VA: 0x18234CE60
	public void .ctor(Form form) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Form get_Form() { }

	// RVA: 0x234D0A0 Offset: 0x234BAA0 VA: 0x18234D0A0
	public int get_IconWidth() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public TitleButtons get_TitleButtons() { }

	// RVA: 0x4F9FE0 Offset: 0x4F89E0 VA: 0x1804F9FE0
	internal Rectangle get_NormalBounds() { }

	// RVA: 0x1DA0840 Offset: 0x1D9F240 VA: 0x181DA0840
	internal void set_NormalBounds(Rectangle value) { }

	// RVA: 0x234D1B0 Offset: 0x234BBB0 VA: 0x18234D1B0
	internal Size get_IconicSize() { }

	// RVA: 0x234D0C0 Offset: 0x234BAC0 VA: 0x18234D0C0
	internal Rectangle get_IconicBounds() { }

	// RVA: 0x234D500 Offset: 0x234BF00 VA: 0x18234D500
	internal void set_IconicBounds(Rectangle value) { }

	// RVA: 0x234D2D0 Offset: 0x234BCD0 VA: 0x18234D2D0 Slot: 4
	internal virtual Rectangle get_MaximizedBounds() { }

	// RVA: 0x234C6A0 Offset: 0x234B0A0 VA: 0x18234C6A0 Slot: 5
	public virtual void UpdateWindowState(FormWindowState old_window_state, FormWindowState new_window_state, bool force) { }

	// RVA: 0x234C5A0 Offset: 0x234AFA0 VA: 0x18234C5A0 Slot: 6
	public virtual void UpdateWindowDecorations(FormWindowState window_state) { }

	// RVA: 0x234C940 Offset: 0x234B340 VA: 0x18234C940 Slot: 7
	public virtual bool WndProc(ref Message m) { }

	// RVA: 0x234B500 Offset: 0x2349F00 VA: 0x18234B500 Slot: 8
	protected virtual bool HandleNCPaint(ref Message m) { }

	// RVA: 0x234A790 Offset: 0x2349190 VA: 0x18234A790 Slot: 9
	protected virtual bool HandleNCCalcSize(ref Message m) { }

	// RVA: 0x234C010 Offset: 0x234AA10 VA: 0x18234C010 Slot: 10
	protected virtual XplatUIWin32.RECT NCCalcSize(XplatUIWin32.RECT proposed_window_rect) { }

	// RVA: 0x234AA30 Offset: 0x2349430 VA: 0x18234AA30 Slot: 11
	protected virtual bool HandleNCHitTest(ref Message m) { }

	// RVA: 0x234C3C0 Offset: 0x234ADC0 VA: 0x18234C3C0 Slot: 12
	public virtual void UpdateBorderStyle(FormBorderStyle border_style) { }

	// RVA: 0x234C380 Offset: 0x234AD80 VA: 0x18234C380 Slot: 13
	public virtual void SetWindowState(FormWindowState old_state, FormWindowState window_state) { }

	// RVA: 0x234A560 Offset: 0x2348F60 VA: 0x18234A560 Slot: 14
	public virtual FormWindowState GetWindowState() { }

	// RVA: 0x234C220 Offset: 0x234AC20 VA: 0x18234C220 Slot: 15
	public virtual void PointToClient(ref int x, ref int y) { }

	// RVA: 0x234C2F0 Offset: 0x234ACF0 VA: 0x18234C2F0 Slot: 16
	public virtual void PointToScreen(ref int x, ref int y) { }

	// RVA: 0x234C3B0 Offset: 0x234ADB0 VA: 0x18234C3B0 Slot: 17
	protected virtual bool ShouldRemoveWindowManager(FormBorderStyle style) { }

	// RVA: 0x234BE60 Offset: 0x234A860 VA: 0x18234BE60
	public bool IconRectangleContains(int x, int y) { }

	// RVA: 0x234D3D0 Offset: 0x234BDD0 VA: 0x18234D3D0
	public bool get_ShowIcon() { }

	// RVA: 0x234A060 Offset: 0x2348A60 VA: 0x18234A060 Slot: 18
	protected virtual void Activate() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 19
	public virtual bool get_IsActive() { }

	// RVA: 0x234A3E0 Offset: 0x2348DE0 VA: 0x18234A3E0
	private void FormSizeChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x234A580 Offset: 0x2348F80 VA: 0x18234A580 Slot: 20
	protected virtual bool HandleRButtonDown(ref Message m) { }

	// RVA: 0x234A580 Offset: 0x2348F80 VA: 0x18234A580 Slot: 21
	protected virtual bool HandleLButtonDown(ref Message m) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	protected virtual bool HandleLButtonDblClick(ref Message m) { }

	// RVA: 0x234B1A0 Offset: 0x2349BA0 VA: 0x18234B1A0 Slot: 23
	protected virtual bool HandleNCMouseLeave(ref Message m) { }

	// RVA: 0x234B290 Offset: 0x2349C90 VA: 0x18234B290 Slot: 24
	protected virtual bool HandleNCMouseMove(ref Message m) { }

	// RVA: 0x234ACF0 Offset: 0x23496F0 VA: 0x18234ACF0 Slot: 25
	protected virtual bool HandleNCLButtonDown(ref Message m) { }

	// RVA: 0x234AC00 Offset: 0x2349600 VA: 0x18234AC00 Slot: 26
	protected virtual void HandleNCLButtonDblClick(ref Message m) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	protected virtual void HandleTitleBarDoubleClick(int x, int y) { }

	// RVA: 0x234BCF0 Offset: 0x234A6F0 VA: 0x18234BCF0 Slot: 28
	protected virtual void HandleTitleBarLeave(int x, int y) { }

	// RVA: 0x234BD10 Offset: 0x234A710 VA: 0x18234BD10 Slot: 29
	protected virtual void HandleTitleBarMouseMove(int x, int y) { }

	// RVA: 0x234BDB0 Offset: 0x234A7B0 VA: 0x18234BDB0 Slot: 30
	protected virtual void HandleTitleBarUp(int x, int y) { }

	// RVA: 0x234BB60 Offset: 0x234A560 VA: 0x18234BB60 Slot: 31
	protected virtual void HandleTitleBarDown(int x, int y) { }

	// RVA: 0x234A700 Offset: 0x2349100 VA: 0x18234A700
	private bool HandleMouseMove(Form form, ref Message m) { }

	// RVA: 0x234A6D0 Offset: 0x23490D0 VA: 0x18234A6D0
	private void HandleMouseLeave(ref Message m) { }

	// RVA: 0x234BDD0 Offset: 0x234A7D0 VA: 0x18234BDD0 Slot: 32
	protected virtual void HandleWindowMove(Message m) { }

	// RVA: 0x234B8C0 Offset: 0x234A2C0 VA: 0x18234B8C0
	private void HandleSizing(Message m) { }

	// RVA: 0x234D1C0 Offset: 0x234BBC0 VA: 0x18234D1C0
	public bool get_IsMaximized() { }

	// RVA: 0x234D1F0 Offset: 0x234BBF0 VA: 0x18234D1F0
	public bool get_IsMinimized() { }

	// RVA: 0x234D220 Offset: 0x234BC20 VA: 0x18234D220
	public bool get_IsSizable() { }

	// RVA: 0x234D070 Offset: 0x234BA70 VA: 0x18234D070
	public bool get_HasBorders() { }

	// RVA: 0x234D270 Offset: 0x234BC70 VA: 0x18234D270
	public bool get_IsToolWindow() { }

	// RVA: 0x234D450 Offset: 0x234BE50 VA: 0x18234D450
	public int get_TitleBarHeight() { }

	// RVA: 0x234CFC0 Offset: 0x234B9C0 VA: 0x18234CFC0
	public int get_BorderWidth() { }

	// RVA: 0x234D310 Offset: 0x234BD10 VA: 0x18234D310 Slot: 33
	public virtual int get_MenuHeight() { }

	// RVA: 0x234C550 Offset: 0x234AF50 VA: 0x18234C550
	protected void UpdateVP(Rectangle r) { }

	// RVA: 0x234C510 Offset: 0x234AF10 VA: 0x18234C510
	protected void UpdateVP(int x, int y, int w, int h) { }

	// RVA: 0x234A5A0 Offset: 0x2348FA0 VA: 0x18234A5A0 Slot: 34
	protected virtual void HandleLButtonUp(ref Message m) { }

	// RVA: 0x234B030 Offset: 0x2349A30 VA: 0x18234B030
	private bool HandleNCLButtonUp(ref Message m) { }

	// RVA: 0x234A0A0 Offset: 0x2348AA0 VA: 0x18234A0A0
	protected void DrawTitleButton(Graphics dc, TitleButton button, Rectangle clip) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 35
	public virtual void DrawMaximizedButtons(object sender, PaintEventArgs pe) { }

	// RVA: 0x234BFD0 Offset: 0x234A9D0 VA: 0x18234BFD0
	protected Point MouseMove(Point pos) { }

	// RVA: 0x234A1B0 Offset: 0x2348BB0 VA: 0x18234A1B0 Slot: 36
	protected virtual void DrawVirtualPosition(Rectangle virtual_position) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	protected virtual void ClearVirtualPosition() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 38
	protected virtual void OnWindowFinishedMoving() { }

	// RVA: 0x234C1C0 Offset: 0x234ABC0 VA: 0x18234C1C0 Slot: 39
	protected virtual void NCPointToClient(ref int x, ref int y) { }

	// RVA: 0x234C160 Offset: 0x234AB60 VA: 0x18234C160 Slot: 40
	protected virtual void NCClientToNC(ref int x, ref int y) { }

	// RVA: 0x234A4F0 Offset: 0x2348EF0 VA: 0x18234A4F0
	internal Point GetMenuOrigin() { }

	// RVA: 0x234A1F0 Offset: 0x2348BF0 VA: 0x18234A1F0
	protected InternalWindowManager.FormPos FormPosForCoords(int x, int y) { }
}
