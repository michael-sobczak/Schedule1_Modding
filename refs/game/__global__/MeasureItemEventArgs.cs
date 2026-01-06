public class MeasureItemEventArgs : EventArgs // TypeDefIndex: 5485
{
	// Fields
	private Graphics graphics; // 0x10
	private int index; // 0x18
	private int itemHeight; // 0x1C
	private int itemWidth; // 0x20

	// Properties
	public int ItemHeight { get; set; }
	public int ItemWidth { get; set; }

	// Methods

	// RVA: 0x23848C0 Offset: 0x23832C0 VA: 0x1823848C0
	public void .ctor(Graphics graphics, int index) { }

	// RVA: 0x2384830 Offset: 0x2383230 VA: 0x182384830
	public void .ctor(Graphics graphics, int index, int itemHeight) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_ItemHeight() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_ItemHeight(int value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_ItemWidth() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_ItemWidth(int value) { }
}
