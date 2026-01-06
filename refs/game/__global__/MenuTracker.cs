internal class MenuTracker // TypeDefIndex: 5490
{
	// Fields
	internal bool active; // 0x10
	internal bool popup_active; // 0x11
	internal bool popdown_menu; // 0x12
	internal bool hotkey_active; // 0x13
	private bool mouse_down; // 0x14
	public Menu CurrentMenu; // 0x18
	public Menu TopMenu; // 0x20
	public Control GrabControl; // 0x28
	private Point last_motion; // 0x30
	private MenuTracker.KeyNavState keynav_state; // 0x38
	private Hashtable shortcuts; // 0x40

	// Properties
	public bool Navigating { get; }

	// Methods

	// RVA: 0x2390230 Offset: 0x238EC30 VA: 0x182390230
	public void .ctor(Menu top_menu) { }

	// RVA: 0x23904D0 Offset: 0x238EED0 VA: 0x1823904D0
	public bool get_Navigating() { }

	// RVA: 0x238F7C0 Offset: 0x238E1C0 VA: 0x18238F7C0
	internal static Point ScreenToMenu(Menu menu, Point pnt) { }

	// RVA: 0x2390130 Offset: 0x238EB30 VA: 0x182390130
	private void UpdateCursor() { }

	// RVA: 0x238C830 Offset: 0x238B230 VA: 0x18238C830
	internal void Deactivate() { }

	// RVA: 0x238CE70 Offset: 0x238B870 VA: 0x18238CE70
	private MenuItem FindItemByCoords(Menu menu, Point pt) { }

	// RVA: 0x238D820 Offset: 0x238C220 VA: 0x18238D820
	private MenuItem GetItemAtXY(int x, int y) { }

	// RVA: 0x238E340 Offset: 0x238CD40 VA: 0x18238E340
	public bool OnMouseDown(MouseEventArgs args) { }

	// RVA: 0x238E0A0 Offset: 0x238CAA0 VA: 0x18238E0A0
	public void OnMotion(MouseEventArgs args) { }

	// RVA: 0x238E4E0 Offset: 0x238CEE0 VA: 0x18238E4E0
	public void OnMouseUp(MouseEventArgs args) { }

	// RVA: 0x238FC90 Offset: 0x238E690 VA: 0x18238FC90
	public static bool TrackPopupMenu(Menu menu, Point pnt) { }

	// RVA: 0x238CB10 Offset: 0x238B510 VA: 0x18238CB10
	private void DeselectItem(MenuItem item) { }

	// RVA: 0x238F880 Offset: 0x238E280 VA: 0x18238F880
	private void SelectItem(Menu menu, MenuItem item, bool execute) { }

	// RVA: 0x238CDD0 Offset: 0x238B7D0 VA: 0x18238CDD0
	private void ExecFocusedItem(Menu menu, MenuItem item) { }

	// RVA: 0x238FA80 Offset: 0x238E480 VA: 0x18238FA80
	private void ShowSubPopup(Menu menu, MenuItem item) { }

	// RVA: 0x238DCD0 Offset: 0x238C6D0 VA: 0x18238DCD0
	public static void HideSubPopups(Menu menu, Menu topmenu) { }

	// RVA: 0x238D520 Offset: 0x238BF20 VA: 0x18238D520
	private MenuItem FindSubItemByCoord(Menu menu, Point pnt) { }

	// RVA: 0x238D160 Offset: 0x238BB60 VA: 0x18238D160
	private static MenuItem FindItemByKey(Menu menu, IntPtr key) { }

	// RVA: 0x238D900 Offset: 0x238C300 VA: 0x18238D900
	private static MenuItem GetNextItem(Menu menu, MenuTracker.ItemNavigation navigation) { }

	// RVA: 0x238F0F0 Offset: 0x238DAF0 VA: 0x18238F0F0
	private void ProcessMenuKey(Msg msg_type) { }

	// RVA: 0x238F2B0 Offset: 0x238DCB0 VA: 0x18238F2B0
	private bool ProcessMnemonic(Message msg, Keys key_data) { }

	// RVA: 0x238C520 Offset: 0x238AF20 VA: 0x18238C520
	public void AddShortcuts(MenuItem item) { }

	// RVA: 0x238F4C0 Offset: 0x238DEC0 VA: 0x18238F4C0
	public void RemoveShortcuts(MenuItem item) { }

	// RVA: 0x238F3C0 Offset: 0x238DDC0 VA: 0x18238F3C0
	private bool ProcessShortcut(Keys keyData) { }

	// RVA: 0x238E680 Offset: 0x238D080 VA: 0x18238E680
	public bool ProcessKeys(ref Message msg, Keys keyData) { }
}
