public class ToolStripArrowRenderEventArgs : EventArgs // TypeDefIndex: 5610
{
	// Fields
	private Color arrow_color; // 0x10
	private Rectangle arrow_rectangle; // 0x28
	private ArrowDirection arrow_direction; // 0x38
	private Graphics graphics; // 0x40
	private ToolStripItem tool_strip_item; // 0x48

	// Properties
	public Color ArrowColor { get; }
	public Rectangle ArrowRectangle { get; }
	public ArrowDirection Direction { get; }
	public Graphics Graphics { get; }

	// Methods

	// RVA: 0x222CCC0 Offset: 0x222B6C0 VA: 0x18222CCC0
	public void .ctor(Graphics g, ToolStripItem toolStripItem, Rectangle arrowRectangle, Color arrowColor, ArrowDirection arrowDirection) { }

	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Color get_ArrowColor() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Rectangle get_ArrowRectangle() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public ArrowDirection get_Direction() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Graphics get_Graphics() { }
}
