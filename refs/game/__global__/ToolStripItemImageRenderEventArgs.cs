public class ToolStripItemImageRenderEventArgs : ToolStripItemRenderEventArgs // TypeDefIndex: 5634
{
	// Fields
	private Image image; // 0x20
	private Rectangle image_rectangle; // 0x28

	// Properties
	public Image Image { get; }
	public Rectangle ImageRectangle { get; }

	// Methods

	// RVA: 0x2235030 Offset: 0x2233A30 VA: 0x182235030
	public void .ctor(Graphics g, ToolStripItem item, Rectangle imageRectangle) { }

	// RVA: 0x2234FF0 Offset: 0x22339F0 VA: 0x182234FF0
	public void .ctor(Graphics g, ToolStripItem item, Image image, Rectangle imageRectangle) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Image get_Image() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Rectangle get_ImageRectangle() { }
}
