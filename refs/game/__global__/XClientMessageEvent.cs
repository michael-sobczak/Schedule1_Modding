internal struct XClientMessageEvent // TypeDefIndex: 5756
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr window; // 0x20
	internal IntPtr message_type; // 0x28
	internal int format; // 0x30
	internal IntPtr ptr1; // 0x38
	internal IntPtr ptr2; // 0x40
	internal IntPtr ptr3; // 0x48
	internal IntPtr ptr4; // 0x50
	internal IntPtr ptr5; // 0x58
}
