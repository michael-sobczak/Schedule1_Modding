public class PopupEventArgs : CancelEventArgs // TypeDefIndex: 5533
{
	// Fields
	private Control associated_control; // 0x18
	private IWin32Window associated_window; // 0x20
	private bool is_balloon; // 0x28
	private Size tool_tip_size; // 0x2C

	// Properties
	public Size ToolTipSize { get; set; }

	// Methods

	// RVA: 0x239E580 Offset: 0x239CF80 VA: 0x18239E580
	public void .ctor(IWin32Window associatedWindow, Control associatedControl, bool isBalloon, Size size) { }

	// RVA: 0xCC4E90 Offset: 0xCC3890 VA: 0x180CC4E90
	public Size get_ToolTipSize() { }

	// RVA: 0x4944B0 Offset: 0x492EB0 VA: 0x1804944B0
	public void set_ToolTipSize(Size value) { }
}
