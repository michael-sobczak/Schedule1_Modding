public static class Console // TypeDefIndex: 3841
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	internal static bool IsRunningOnAndroid; // 0x18
	private static Encoding inputEncoding; // 0x20
	private static Encoding outputEncoding; // 0x28
	private static ConsoleCancelEventHandler cancel_event; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x1CBB960 Offset: 0x1CBA360 VA: 0x181CBB960
	private static void .cctor() { }

	// RVA: 0x1CBB050 Offset: 0x1CB9A50 VA: 0x181CBB050
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x1CBBBE0 Offset: 0x1CBA5E0 VA: 0x181CBBBE0
	public static TextWriter get_Error() { }

	// RVA: 0x1CBBC80 Offset: 0x1CBA680 VA: 0x181CBBC80
	public static TextWriter get_Out() { }

	// RVA: 0x1CBAAD0 Offset: 0x1CB94D0 VA: 0x181CBAAD0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x1CBA920 Offset: 0x1CB9320 VA: 0x181CBA920
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x1CBA9B0 Offset: 0x1CB93B0 VA: 0x181CBA9B0
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x1CBAA40 Offset: 0x1CB9440 VA: 0x181CBAA40
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x1CBAE70 Offset: 0x1CB9870 VA: 0x181CBAE70
	public static void SetError(TextWriter newError) { }

	// RVA: 0x1CBAF60 Offset: 0x1CB9960 VA: 0x181CBAF60
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x1CBB850 Offset: 0x1CBA250 VA: 0x181CBB850
	public static void Write(string value) { }

	// RVA: 0x1CBB8D0 Offset: 0x1CBA2D0 VA: 0x181CBB8D0
	public static void Write(string format, object arg0) { }

	// RVA: 0x1CBB490 Offset: 0x1CB9E90 VA: 0x181CBB490
	public static void WriteLine(object value) { }

	// RVA: 0x1CBB510 Offset: 0x1CB9F10 VA: 0x181CBB510
	public static void WriteLine(string value) { }

	// RVA: 0x1CBB6E0 Offset: 0x1CBA0E0 VA: 0x181CBB6E0
	public static void WriteLine(string format, object arg0) { }

	// RVA: 0x1CBB770 Offset: 0x1CBA170 VA: 0x181CBB770
	public static void WriteLine(string format, object[] arg) { }

	// RVA: 0x1CBB590 Offset: 0x1CB9F90 VA: 0x181CBB590
	public static void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1CBB630 Offset: 0x1CBA030 VA: 0x181CBB630
	public static void WriteLine(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1CBBC30 Offset: 0x1CBA630 VA: 0x181CBBC30
	public static Encoding get_InputEncoding() { }

	// RVA: 0x1CBBCD0 Offset: 0x1CBA6D0 VA: 0x181CBBCD0
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x1CBAD00 Offset: 0x1CB9700 VA: 0x181CBAD00
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x1CBABC0 Offset: 0x1CB95C0 VA: 0x181CBABC0
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1CBA7A0 Offset: 0x1CB91A0 VA: 0x181CBA7A0
	private static void DoConsoleCancelEvent() { }
}
