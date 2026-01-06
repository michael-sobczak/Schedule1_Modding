internal struct XReparentEvent // TypeDefIndex: 5744
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr xevent; // 0x20
	internal IntPtr window; // 0x28
	internal IntPtr parent; // 0x30
	internal int x; // 0x38
	internal int y; // 0x3C
	internal bool override_redirect; // 0x40
}
