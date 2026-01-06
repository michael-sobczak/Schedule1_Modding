internal static class NativeEventCalls // TypeDefIndex: 3994
{
	// Methods

	// RVA: 0x1CF1960 Offset: 0x1CF0360 VA: 0x181CF1960
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1CF1950 Offset: 0x1CF0350 VA: 0x181CF1950
	private static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode) { }

	// RVA: 0x1CF1AC0 Offset: 0x1CF04C0 VA: 0x181CF1AC0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1CF1AB0 Offset: 0x1CF04B0 VA: 0x181CF1AB0
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x1CF19E0 Offset: 0x1CF03E0 VA: 0x181CF19E0
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1CF19D0 Offset: 0x1CF03D0 VA: 0x181CF19D0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1CF1940 Offset: 0x1CF0340 VA: 0x181CF1940
	public static void CloseEvent_internal(IntPtr handle) { }
}
