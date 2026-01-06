internal struct XSetWindowAttributes // TypeDefIndex: 5761
{
	// Fields
	internal IntPtr background_pixmap; // 0x0
	internal IntPtr background_pixel; // 0x8
	internal IntPtr border_pixmap; // 0x10
	internal IntPtr border_pixel; // 0x18
	internal Gravity bit_gravity; // 0x20
	internal Gravity win_gravity; // 0x24
	internal int backing_store; // 0x28
	internal IntPtr backing_planes; // 0x30
	internal IntPtr backing_pixel; // 0x38
	internal bool save_under; // 0x40
	internal IntPtr event_mask; // 0x48
	internal IntPtr do_not_propagate_mask; // 0x50
	internal bool override_redirect; // 0x58
	internal IntPtr colormap; // 0x60
	internal IntPtr cursor; // 0x68
}
