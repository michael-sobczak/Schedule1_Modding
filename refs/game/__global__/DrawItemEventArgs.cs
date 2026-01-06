public class DrawItemEventArgs : EventArgs // TypeDefIndex: 5318
{
	// Fields
	private Graphics graphics; // 0x10
	private Font font; // 0x18
	private Rectangle rect; // 0x20
	private int index; // 0x30
	private DrawItemState state; // 0x34
	private Color fore_color; // 0x38
	private Color back_color; // 0x50

	// Properties
	public Graphics Graphics { get; }
	public Font Font { get; }
	public Rectangle Bounds { get; }
	public int Index { get; }
	public DrawItemState State { get; }
	public Color BackColor { get; }
	public Color ForeColor { get; }

	// Methods

	// RVA: 0x2315DB0 Offset: 0x23147B0 VA: 0x182315DB0
	public void .ctor(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state) { }

	// RVA: 0x2315CC0 Offset: 0x23146C0 VA: 0x182315CC0
	public void .ctor(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state, Color foreColor, Color backColor) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Graphics get_Graphics() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Font get_Font() { }

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Rectangle get_Bounds() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_Index() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public DrawItemState get_State() { }

	// RVA: 0xCC9F40 Offset: 0xCC8940 VA: 0x180CC9F40
	public Color get_BackColor() { }

	// RVA: 0x49CCD0 Offset: 0x49B6D0 VA: 0x18049CCD0
	public Color get_ForeColor() { }
}
