internal class MdiWindowManager : InternalWindowManager // TypeDefIndex: 5484
{
	// Fields
	private MainMenu merged_menu; // 0x68
	private MainMenu maximized_menu; // 0x70
	private MenuItem icon_menu; // 0x78
	private ContextMenu icon_popup_menu; // 0x80
	internal bool was_minimized; // 0x88
	private PaintEventHandler draw_maximized_buttons; // 0x90
	internal EventHandler form_closed_handler; // 0x98
	private MdiClient mdi_container; // 0xA0
	private Rectangle prev_virtual_position; // 0xA8
	private Point icon_clicked; // 0xB8
	private DateTime icon_clicked_time; // 0xC0
	private bool icon_dont_show_popup; // 0xC8
	private TitleButtons maximized_title_buttons; // 0xD0
	private bool is_visible_pending; // 0xD8
	private byte last_activation_event; // 0xD9

	// Properties
	public override int MenuHeight { get; }
	internal bool IsVisiblePending { get; set; }
	private TitleButtons MaximizedTitleButtons { get; }
	internal override Rectangle MaximizedBounds { get; }
	public MainMenu MergedMenu { get; }
	public MainMenu MaximizedMenu { get; }
	public override bool IsActive { get; }

	// Methods

	// RVA: 0x237FAD0 Offset: 0x237E4D0 VA: 0x18237FAD0
	public void .ctor(Form form, MdiClient mdi_container) { }

	// RVA: 0x237F2F0 Offset: 0x237DCF0 VA: 0x18237F2F0
	public void RaiseActivated() { }

	// RVA: 0x237F340 Offset: 0x237DD40 VA: 0x18237F340
	public void RaiseDeactivate() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 33
	public override int get_MenuHeight() { }

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	internal bool get_IsVisiblePending() { }

	// RVA: 0xAEB920 Offset: 0xAEA320 VA: 0x180AEB920
	internal void set_IsVisiblePending(bool value) { }

	// RVA: 0x237FEE0 Offset: 0x237E8E0 VA: 0x18237FEE0
	private TitleButtons get_MaximizedTitleButtons() { }

	// RVA: 0x237FD40 Offset: 0x237E740 VA: 0x18237FD40 Slot: 4
	internal override Rectangle get_MaximizedBounds() { }

	// RVA: 0x237E240 Offset: 0x237CC40 VA: 0x18237E240
	private void FormVisibleChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x237E1D0 Offset: 0x237CBD0 VA: 0x18237E1D0
	private void FormTextChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x237E070 Offset: 0x237CA70 VA: 0x18237E070
	private void FormLocationChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x237E0E0 Offset: 0x237CAE0 VA: 0x18237E0E0
	private void FormSizeChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x237FFC0 Offset: 0x237E9C0 VA: 0x18237FFC0
	public MainMenu get_MergedMenu() { }

	// RVA: 0x237D820 Offset: 0x237C220 VA: 0x18237D820
	private MainMenu CreateMergedMenu() { }

	// RVA: 0x237FEA0 Offset: 0x237E8A0 VA: 0x18237FEA0
	public MainMenu get_MaximizedMenu() { }

	// RVA: 0x237D5A0 Offset: 0x237BFA0 VA: 0x18237D5A0
	private MainMenu CreateMaximizedMenu() { }

	// RVA: 0x237CC60 Offset: 0x237B660 VA: 0x18237CC60
	private void CreateIconMenus() { }

	// RVA: 0x237CAF0 Offset: 0x237B4F0 VA: 0x18237CAF0
	private void ClickIconMenuItem(object sender, EventArgs e) { }

	// RVA: 0x237F3F0 Offset: 0x237DDF0 VA: 0x18237F3F0
	internal void ShowPopup(Point pnt) { }

	// RVA: 0x237F380 Offset: 0x237DD80 VA: 0x18237F380
	private void RestoreItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237F0C0 Offset: 0x237DAC0 VA: 0x18237F0C0
	private void MoveItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237F830 Offset: 0x237E230 VA: 0x18237F830
	private void SizeItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237F090 Offset: 0x237DA90 VA: 0x18237F090
	private void MinimizeItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237F000 Offset: 0x237DA00 VA: 0x18237F000
	private void MaximizeItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237CC40 Offset: 0x237B640 VA: 0x18237CC40
	private void CloseItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237F170 Offset: 0x237DB70 VA: 0x18237F170
	private void NextItemHandler(object sender, EventArgs e) { }

	// RVA: 0x237DA00 Offset: 0x237C400 VA: 0x18237DA00
	private void DrawIconMenuItem(object sender, DrawItemEventArgs de) { }

	// RVA: 0x237F050 Offset: 0x237DA50 VA: 0x18237F050
	private void MeasureIconMenuItem(object sender, MeasureItemEventArgs me) { }

	// RVA: 0x237F080 Offset: 0x237DA80 VA: 0x18237F080
	private void MenuChangedHandler(object sender, EventArgs e) { }

	// RVA: 0x237F1D0 Offset: 0x237DBD0 VA: 0x18237F1D0 Slot: 15
	public override void PointToClient(ref int x, ref int y) { }

	// RVA: 0x237F260 Offset: 0x237DC60 VA: 0x18237F260 Slot: 16
	public override void PointToScreen(ref int x, ref int y) { }

	// RVA: 0x237F8E0 Offset: 0x237E2E0 VA: 0x18237F8E0 Slot: 6
	public override void UpdateWindowDecorations(FormWindowState window_state) { }

	// RVA: 0x237F3B0 Offset: 0x237DDB0 VA: 0x18237F3B0 Slot: 13
	public override void SetWindowState(FormWindowState old_state, FormWindowState window_state) { }

	// RVA: 0x237DFF0 Offset: 0x237C9F0 VA: 0x18237DFF0
	private void FormClosed(object sender, EventArgs e) { }

	// RVA: 0x237DAB0 Offset: 0x237C4B0 VA: 0x18237DAB0 Slot: 35
	public override void DrawMaximizedButtons(object sender, PaintEventArgs pe) { }

	// RVA: 0x237E5B0 Offset: 0x237CFB0 VA: 0x18237E5B0
	public bool HandleMenuMouseDown(MainMenu menu, int x, int y) { }

	// RVA: 0x237E720 Offset: 0x237D120 VA: 0x18237E720
	public void HandleMenuMouseUp(MainMenu menu, int x, int y) { }

	// RVA: 0x237E640 Offset: 0x237D040 VA: 0x18237E640
	public void HandleMenuMouseLeave(MainMenu menu, int x, int y) { }

	// RVA: 0x237E6B0 Offset: 0x237D0B0 VA: 0x18237E6B0
	public void HandleMenuMouseMove(MainMenu menu, int x, int y) { }

	// RVA: 0x237EA80 Offset: 0x237D480 VA: 0x18237EA80 Slot: 28
	protected override void HandleTitleBarLeave(int x, int y) { }

	// RVA: 0x237EC10 Offset: 0x237D610 VA: 0x18237EC10 Slot: 30
	protected override void HandleTitleBarUp(int x, int y) { }

	// RVA: 0x237E820 Offset: 0x237D220 VA: 0x18237E820 Slot: 27
	protected override void HandleTitleBarDoubleClick(int x, int y) { }

	// RVA: 0x237E890 Offset: 0x237D290 VA: 0x18237E890 Slot: 31
	protected override void HandleTitleBarDown(int x, int y) { }

	// RVA: 0x237EB50 Offset: 0x237D550 VA: 0x18237EB50 Slot: 29
	protected override void HandleTitleBarMouseMove(int x, int y) { }

	// RVA: 0x237E2D0 Offset: 0x237CCD0 VA: 0x18237E2D0 Slot: 22
	protected override bool HandleLButtonDblClick(ref Message m) { }

	// RVA: 0x237E3E0 Offset: 0x237CDE0 VA: 0x18237E3E0 Slot: 21
	protected override bool HandleLButtonDown(ref Message m) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 17
	protected override bool ShouldRemoveWindowManager(FormBorderStyle style) { }

	// RVA: 0x237EEC0 Offset: 0x237D8C0 VA: 0x18237EEC0 Slot: 32
	protected override void HandleWindowMove(Message m) { }

	// RVA: 0x237E790 Offset: 0x237D190 VA: 0x18237E790 Slot: 24
	protected override bool HandleNCMouseMove(ref Message m) { }

	// RVA: 0x237DF30 Offset: 0x237C930 VA: 0x18237DF30 Slot: 36
	protected override void DrawVirtualPosition(Rectangle virtual_position) { }

	// RVA: 0x237C9E0 Offset: 0x237B3E0 VA: 0x18237C9E0 Slot: 37
	protected override void ClearVirtualPosition() { }

	// RVA: 0x237F1A0 Offset: 0x237DBA0 VA: 0x18237F1A0 Slot: 38
	protected override void OnWindowFinishedMoving() { }

	// RVA: 0x237FD00 Offset: 0x237E700 VA: 0x18237FD00 Slot: 19
	public override bool get_IsActive() { }

	// RVA: 0x237C990 Offset: 0x237B390 VA: 0x18237C990 Slot: 18
	protected override void Activate() { }
}
