internal class EventHandler // TypeDefIndex: 5874
{
	// Fields
	internal static EventDelegate EventHandlerDelegate; // 0x0
	internal static XplatUICarbon Driver; // 0x8
	internal static EventTypeSpec[] HIObjectEvents; // 0x10
	internal static EventTypeSpec[] ControlEvents; // 0x18
	internal static EventTypeSpec[] ApplicationEvents; // 0x20
	private static EventTypeSpec[] WindowEvents; // 0x28

	// Methods

	// RVA: 0x22B4F60 Offset: 0x22B3960 VA: 0x1822B4F60
	private static void .cctor() { }

	// RVA: 0x22B42D0 Offset: 0x22B2CD0 VA: 0x1822B42D0
	internal static int EventCallback(IntPtr callref, IntPtr eventref, IntPtr handle) { }

	// RVA: 0x22B4EA0 Offset: 0x22B38A0 VA: 0x1822B4EA0
	internal static bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x22B4940 Offset: 0x22B3340 VA: 0x1822B4940
	internal static void InstallApplicationHandler() { }

	// RVA: 0x22B4AC0 Offset: 0x22B34C0 VA: 0x1822B4AC0
	internal static void InstallControlHandler(IntPtr control) { }

	// RVA: 0x22B4D10 Offset: 0x22B3710 VA: 0x1822B4D10
	internal static void InstallWindowHandler(IntPtr window) { }

	// RVA: 0x22B46D0 Offset: 0x22B30D0 VA: 0x1822B46D0
	private static extern IntPtr GetApplicationEventTarget() { }

	// RVA: 0x22B4740 Offset: 0x22B3140 VA: 0x1822B4740
	internal static extern IntPtr GetControlEventTarget(IntPtr control) { }

	// RVA: 0x22B48C0 Offset: 0x22B32C0 VA: 0x1822B48C0
	internal static extern IntPtr GetWindowEventTarget(IntPtr window) { }

	// RVA: 0x22B47C0 Offset: 0x22B31C0 VA: 0x1822B47C0
	internal static extern uint GetEventClass(IntPtr eventref) { }

	// RVA: 0x22B4840 Offset: 0x22B3240 VA: 0x1822B4840
	private static extern uint GetEventKind(IntPtr eventref) { }

	// RVA: 0x22B4C50 Offset: 0x22B3650 VA: 0x1822B4C50
	private static extern int InstallEventHandler(IntPtr window, EventDelegate event_handler, uint count, EventTypeSpec[] types, IntPtr user_data, IntPtr handlerref) { }
}
