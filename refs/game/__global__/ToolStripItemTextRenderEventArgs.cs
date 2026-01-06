public class ToolStripItemTextRenderEventArgs : ToolStripItemRenderEventArgs // TypeDefIndex: 5639
{
	// Fields
	private string text; // 0x20
	private Color text_color; // 0x28
	private ToolStripTextDirection text_direction; // 0x40
	private Font text_font; // 0x48
	private TextFormatFlags text_format; // 0x50
	private Rectangle text_rectangle; // 0x54

	// Properties
	public string Text { get; }
	public Color TextColor { get; }
	public ToolStripTextDirection TextDirection { get; }
	public Font TextFont { get; }
	public TextFormatFlags TextFormat { get; }
	public Rectangle TextRectangle { get; }

	// Methods

	// RVA: 0x2235120 Offset: 0x2233B20 VA: 0x182235120
	public void .ctor(Graphics g, ToolStripItem item, string text, Rectangle textRectangle, Color textColor, Font textFont, ContentAlignment textAlign) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Text() { }

	// RVA: 0xCCDAD0 Offset: 0xCCC4D0 VA: 0x180CCDAD0
	public Color get_TextColor() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public ToolStripTextDirection get_TextDirection() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Font get_TextFont() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public TextFormatFlags get_TextFormat() { }

	// RVA: 0x84CBF0 Offset: 0x84B5F0 VA: 0x18084CBF0
	public Rectangle get_TextRectangle() { }
}
