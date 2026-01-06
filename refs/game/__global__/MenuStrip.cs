public class MenuStrip : ToolStrip // TypeDefIndex: 5495
{
	// Fields
	private ToolStripMenuItem mdi_window_list_item; // 0x350
	private static object MenuActivateEvent; // 0x0
	private static object MenuDeactivateEvent; // 0x8

	// Properties
	internal bool MenuDroppedDown { get; set; }

	// Methods

	// RVA: 0x238C440 Offset: 0x238AE40 VA: 0x18238C440
	private static void .cctor() { }

	// RVA: 0x238B760 Offset: 0x238A160 VA: 0x18238B760 Slot: 226
	protected virtual void OnMenuActivate(EventArgs e) { }

	// RVA: 0x238B830 Offset: 0x238A230 VA: 0x18238B830 Slot: 227
	protected virtual void OnMenuDeactivate(EventArgs e) { }

	// RVA: 0x238C500 Offset: 0x238AF00 VA: 0x18238C500
	internal bool get_MenuDroppedDown() { }

	// RVA: 0x238C510 Offset: 0x238AF10 VA: 0x18238C510
	internal void set_MenuDroppedDown(bool value) { }

	// RVA: 0x238B2C0 Offset: 0x2389CC0 VA: 0x18238B2C0
	internal void FireMenuActivate() { }

	// RVA: 0x238B3E0 Offset: 0x2389DE0 VA: 0x18238B3E0
	internal void FireMenuDeactivate() { }

	// RVA: 0x238B910 Offset: 0x238A310 VA: 0x18238B910 Slot: 223
	internal override bool OnMenuKey() { }

	// RVA: 0x2233600 Offset: 0x2232000 VA: 0x182233600
	private void ToolStripMenuTracker_AppFocusChange(object sender, EventArgs e) { }

	// RVA: 0x22335B0 Offset: 0x2231FB0 VA: 0x1822335B0
	private void ToolStripMenuTracker_AppClicked(object sender, EventArgs e) { }

	// RVA: 0x238B9E0 Offset: 0x238A3E0 VA: 0x18238B9E0
	internal void RefreshMdiItems() { }

	// RVA: 0x238B040 Offset: 0x2389A40 VA: 0x18238B040
	private ToolStripMenuItem FindMdiMenuItemOfForm(Form f) { }

	// RVA: 0x238AD80 Offset: 0x2389780 VA: 0x18238AD80
	private int CountMdiMenuItems() { }

	// RVA: 0x238B500 Offset: 0x2389F00 VA: 0x18238B500
	private bool NeedToReorderMdi() { }

	// RVA: 0x238C060 Offset: 0x238AA60 VA: 0x18238C060
	private void ReorderMdiMenu() { }
}
