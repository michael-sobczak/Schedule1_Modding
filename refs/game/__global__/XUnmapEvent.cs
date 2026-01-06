internal struct XUnmapEvent // TypeDefIndex: 5741
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr xevent; // 0x20
	internal IntPtr window; // 0x28
	internal bool from_configure; // 0x30
}
