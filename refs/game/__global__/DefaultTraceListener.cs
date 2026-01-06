public class DefaultTraceListener : TraceListener // TypeDefIndex: 9597
{
	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	// Properties
	[MonoTODO]
	public string LogFileName { get; }

	// Methods

	// RVA: 0x262C360 Offset: 0x262AD60 VA: 0x18262C360
	private static void .cctor() { }

	// RVA: 0x262BC40 Offset: 0x262A640 VA: 0x18262BC40
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x262C540 Offset: 0x262AF40 VA: 0x18262C540
	public void .ctor() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_LogFileName() { }

	// RVA: 0x262C340 Offset: 0x262AD40 VA: 0x18262C340
	private static void WriteWindowsDebugString(char* message) { }

	// RVA: 0x262BCB0 Offset: 0x262A6B0 VA: 0x18262BCB0
	private void WriteDebugString(string message) { }

	// RVA: 0x262C0D0 Offset: 0x262AAD0 VA: 0x18262C0D0
	private void WriteMonoTrace(string message) { }

	// RVA: 0x262C2B0 Offset: 0x262ACB0 VA: 0x18262C2B0
	private void WritePrefix() { }

	// RVA: 0x262BD60 Offset: 0x262A760 VA: 0x18262BD60
	private void WriteImpl(string message) { }

	// RVA: 0x262BF70 Offset: 0x262A970 VA: 0x18262BF70
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x262C350 Offset: 0x262AD50 VA: 0x18262C350 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x262BF20 Offset: 0x262A920 VA: 0x18262BF20 Slot: 12
	public override void WriteLine(string message) { }
}
