internal struct XSelectionRequestEvent // TypeDefIndex: 5753
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr owner; // 0x20
	internal IntPtr requestor; // 0x28
	internal IntPtr selection; // 0x30
	internal IntPtr target; // 0x38
	internal IntPtr property; // 0x40
	internal IntPtr time; // 0x48
}
