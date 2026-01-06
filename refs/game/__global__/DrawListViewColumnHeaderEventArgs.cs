public class DrawListViewColumnHeaderEventArgs : EventArgs // TypeDefIndex: 5320
{
	// Fields
	private Color backColor; // 0x10
	private Rectangle bounds; // 0x28
	private int columnIndex; // 0x38
	private bool drawDefault; // 0x3C
	private Font font; // 0x40
	private Color foreColor; // 0x48
	private Graphics graphics; // 0x60
	private ColumnHeader header; // 0x68
	private ListViewItemStates state; // 0x70

	// Properties
	public bool DrawDefault { get; }

	// Methods

	// RVA: 0x2315F10 Offset: 0x2314910 VA: 0x182315F10
	public void .ctor(Graphics graphics, Rectangle bounds, int columnIndex, ColumnHeader header, ListViewItemStates state, Color foreColor, Color backColor, Font font) { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_DrawDefault() { }
}
