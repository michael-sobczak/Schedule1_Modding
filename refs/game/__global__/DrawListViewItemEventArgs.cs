public class DrawListViewItemEventArgs : EventArgs // TypeDefIndex: 5321
{
	// Fields
	private Rectangle bounds; // 0x10
	private bool drawDefault; // 0x20
	private Graphics graphics; // 0x28
	private ListViewItem item; // 0x30
	private int itemIndex; // 0x38
	private ListViewItemStates state; // 0x3C

	// Properties
	public bool DrawDefault { get; }

	// Methods

	// RVA: 0x2316010 Offset: 0x2314A10 VA: 0x182316010
	public void .ctor(Graphics graphics, ListViewItem item, Rectangle bounds, int itemIndex, ListViewItemStates state) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_DrawDefault() { }
}
