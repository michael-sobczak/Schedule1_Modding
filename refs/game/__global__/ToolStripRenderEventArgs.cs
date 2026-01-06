public class ToolStripRenderEventArgs : EventArgs // TypeDefIndex: 5650
{
	// Fields
	private Rectangle affected_bounds; // 0x10
	private Color back_color; // 0x20
	private Rectangle connected_area; // 0x38
	private Graphics graphics; // 0x48
	private ToolStrip tool_strip; // 0x50

	// Properties
	public Rectangle AffectedBounds { get; }
	public Rectangle ConnectedArea { get; }
	public Graphics Graphics { get; }
	public ToolStrip ToolStrip { get; }
	internal Rectangle InternalConnectedArea { set; }

	// Methods

	// RVA: 0x2250710 Offset: 0x224F110 VA: 0x182250710
	public void .ctor(Graphics g, ToolStrip toolStrip) { }

	// RVA: 0x2250650 Offset: 0x224F050 VA: 0x182250650
	public void .ctor(Graphics g, ToolStrip toolStrip, Rectangle affectedBounds, Color backColor) { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Rectangle get_AffectedBounds() { }

	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	public Rectangle get_ConnectedArea() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Graphics get_Graphics() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public ToolStrip get_ToolStrip() { }

	// RVA: 0x1440050 Offset: 0x143EA50 VA: 0x181440050
	internal void set_InternalConnectedArea(Rectangle value) { }
}
