internal struct XSelectionClearEvent // TypeDefIndex: 5752
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr serial; // 0x8
	internal bool send_event; // 0x10
	internal IntPtr display; // 0x18
	internal IntPtr window; // 0x20
	internal IntPtr selection; // 0x28
	internal IntPtr time; // 0x30
}
