public class ToolStripItemRenderEventArgs : EventArgs // TypeDefIndex: 5638
{
	// Fields
	private Graphics graphics; // 0x10
	private ToolStripItem item; // 0x18

	// Properties
	public Graphics Graphics { get; }
	public ToolStripItem Item { get; }
	public ToolStrip ToolStrip { get; }

	// Methods

	// RVA: 0x2235070 Offset: 0x2233A70 VA: 0x182235070
	public void .ctor(Graphics g, ToolStripItem item) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Graphics get_Graphics() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ToolStripItem get_Item() { }

	// RVA: 0x2235100 Offset: 0x2233B00 VA: 0x182235100
	public ToolStrip get_ToolStrip() { }
}
