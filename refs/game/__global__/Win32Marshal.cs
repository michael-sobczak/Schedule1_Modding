internal static class Win32Marshal // TypeDefIndex: 5076
{
	// Methods

	// RVA: 0x1C405A0 Offset: 0x1C3EFA0 VA: 0x181C405A0
	internal static Exception GetExceptionForLastWin32Error(string path = "") { }

	// RVA: 0x1C40600 Offset: 0x1C3F000 VA: 0x181C40600
	internal static Exception GetExceptionForWin32Error(int errorCode, string path = "") { }

	// RVA: 0x1C40AE0 Offset: 0x1C3F4E0 VA: 0x181C40AE0
	internal static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x1C40B00 Offset: 0x1C3F500 VA: 0x181C40B00
	internal static int TryMakeWin32ErrorCodeFromHR(int hr) { }

	// RVA: 0x1C40AD0 Offset: 0x1C3F4D0 VA: 0x181C40AD0
	internal static string GetMessage(int errorCode) { }
}
