public class DrawListViewSubItemEventArgs : EventArgs // TypeDefIndex: 5322
{
	// Fields
	private Rectangle bounds; // 0x10
	private int columnIndex; // 0x20
	private bool drawDefault; // 0x24
	private Graphics graphics; // 0x28
	private ColumnHeader header; // 0x30
	private ListViewItem item; // 0x38
	private int itemIndex; // 0x40
	private ListViewItemStates itemState; // 0x44
	private ListViewItem.ListViewSubItem subItem; // 0x48

	// Properties
	public bool DrawDefault { get; }

	// Methods

	// RVA: 0x23160C0 Offset: 0x2314AC0 VA: 0x1823160C0
	public void .ctor(Graphics graphics, Rectangle bounds, ListViewItem item, ListViewItem.ListViewSubItem subItem, int itemIndex, int columnIndex, ColumnHeader header, ListViewItemStates itemState) { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_DrawDefault() { }
}
