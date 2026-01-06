public class ToolStripGripRenderEventArgs : ToolStripRenderEventArgs // TypeDefIndex: 5624
{
	// Fields
	private Rectangle grip_bounds; // 0x58
	private ToolStripGripDisplayStyle grip_display_style; // 0x68
	private ToolStripGripStyle grip_style; // 0x6C

	// Properties
	public Rectangle GripBounds { get; }
	public ToolStripGripDisplayStyle GripDisplayStyle { get; }
	public ToolStripGripStyle GripStyle { get; }

	// Methods

	// RVA: 0x2234060 Offset: 0x2232A60 VA: 0x182234060
	internal void .ctor(Graphics g, ToolStrip toolStrip, Rectangle gripBounds, ToolStripGripDisplayStyle displayStyle, ToolStripGripStyle gripStyle) { }

	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10
	public Rectangle get_GripBounds() { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public ToolStripGripDisplayStyle get_GripDisplayStyle() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public ToolStripGripStyle get_GripStyle() { }
}
