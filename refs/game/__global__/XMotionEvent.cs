internal struct XMotionEvent // TypeDefIndex: 5731
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr window; // 0x20
	internal IntPtr root; // 0x28
	internal IntPtr subwindow; // 0x30
	internal IntPtr time; // 0x38
	internal int x; // 0x40
	internal int y; // 0x44
	internal int x_root; // 0x48
	internal int y_root; // 0x4C
	internal int state; // 0x50
	internal byte is_hint; // 0x54
	internal bool same_screen; // 0x55
}
