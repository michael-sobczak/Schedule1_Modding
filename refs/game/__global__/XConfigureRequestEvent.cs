internal struct XConfigureRequestEvent // TypeDefIndex: 5748
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
	internal IntPtr above; // 0x48
	internal int detail; // 0x50
	internal IntPtr value_mask; // 0x58
}
