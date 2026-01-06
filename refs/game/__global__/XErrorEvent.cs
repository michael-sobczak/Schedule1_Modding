internal struct XErrorEvent // TypeDefIndex: 5758
{
	// Fields
	internal XEventName type; // 0x0
	internal IntPtr display; // 0x8
	internal IntPtr resourceid; // 0x10
	internal IntPtr serial; // 0x18
	internal byte error_code; // 0x20
	internal XRequest request_code; // 0x21
	internal byte minor_code; // 0x22
}
