internal struct XCreateWindowEvent // TypeDefIndex: 5739
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr parent; // 0x20
	internal IntPtr window; // 0x28
	internal int x; // 0x30
	internal int y; // 0x34
	internal int width; // 0x38
	internal int height; // 0x3C
	internal int border_width; // 0x40
	internal bool override_redirect; // 0x44
}
