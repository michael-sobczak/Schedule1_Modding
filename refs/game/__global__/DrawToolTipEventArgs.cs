public class DrawToolTipEventArgs : EventArgs // TypeDefIndex: 5324
{
	// Fields
	private Control associated_control; // 0x10
	private IWin32Window associated_window; // 0x18
	private Color back_color; // 0x20
	private Font font; // 0x38
	private Rectangle bounds; // 0x40
	private Color fore_color; // 0x50
	private Graphics graphics; // 0x68
	private string tooltip_text; // 0x70

	// Properties
	public Rectangle Bounds { get; }
	public Graphics Graphics { get; }

	// Methods

	// RVA: 0x2316190 Offset: 0x2314B90 VA: 0x182316190
	public void .ctor(Graphics graphics, IWin32Window associatedWindow, Control associatedControl, Rectangle bounds, string toolTipText, Color backColor, Color foreColor, Font font) { }

	// RVA: 0xAB8F60 Offset: 0xAB7960 VA: 0x180AB8F60
	public Rectangle get_Bounds() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Graphics get_Graphics() { }
}
