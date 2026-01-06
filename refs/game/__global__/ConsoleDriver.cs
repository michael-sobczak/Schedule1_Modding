internal static class ConsoleDriver // TypeDefIndex: 3842
{
	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x1CBA560 Offset: 0x1CB8F60 VA: 0x181CBA560
	private static void .cctor() { }

	// RVA: 0x1CBA350 Offset: 0x1CB8D50 VA: 0x181CBA350
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x1CBA3E0 Offset: 0x1CB8DE0 VA: 0x181CBA3E0
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x1CBA380 Offset: 0x1CB8D80 VA: 0x181CBA380
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x1CBA440 Offset: 0x1CB8E40 VA: 0x181CBA440
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1CBA640 Offset: 0x1CB9040 VA: 0x181CBA640
	public static bool get_IsConsole() { }

	// RVA: 0x1CBA430 Offset: 0x1CB8E30 VA: 0x181CBA430
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x1CA89D0 Offset: 0x1CA73D0 VA: 0x181CA89D0
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x1CBA550 Offset: 0x1CB8F50 VA: 0x181CBA550
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x1AF9690 Offset: 0x1AF8090 VA: 0x181AF9690
	internal static bool SetEcho(bool wantEcho) { }
}
