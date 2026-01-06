internal struct XGraphicsExposeEvent // TypeDefIndex: 5736
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr drawable; // 0x20
	internal int x; // 0x28
	internal int y; // 0x2C
	internal int width; // 0x30
	internal int height; // 0x34
	internal int count; // 0x38
	internal int major_code; // 0x3C
	internal int minor_code; // 0x40
}
