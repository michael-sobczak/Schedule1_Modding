public class TraceEventCache // TypeDefIndex: 9580
{
	// Fields
	private static int processId; // 0x0
	private static string processName; // 0x8
	private long timeStamp; // 0x10
	private DateTime dateTime; // 0x18
	private string stackTrace; // 0x20

	// Properties
	public string Callstack { get; }
	public Stack LogicalOperationStack { get; }
	public DateTime DateTime { get; }
	public int ProcessId { get; }
	public string ThreadId { get; }
	public long Timestamp { get; }

	// Methods

	// RVA: 0x263D810 Offset: 0x263C210 VA: 0x18263D810
	public string get_Callstack() { }

	// RVA: 0x263D8F0 Offset: 0x263C2F0 VA: 0x18263D8F0
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x263D850 Offset: 0x263C250 VA: 0x18263D850
	public DateTime get_DateTime() { }

	// RVA: 0x263D500 Offset: 0x263BF00 VA: 0x18263D500
	public int get_ProcessId() { }

	// RVA: 0x263DA40 Offset: 0x263C440 VA: 0x18263DA40
	public string get_ThreadId() { }

	// RVA: 0x263DAC0 Offset: 0x263C4C0 VA: 0x18263DAC0
	public long get_Timestamp() { }

	// RVA: 0x263D550 Offset: 0x263BF50 VA: 0x18263D550
	private static void InitProcessInfo() { }

	// RVA: 0x263D500 Offset: 0x263BF00 VA: 0x18263D500
	internal static int GetProcessId() { }

	// RVA: 0x1CC0580 Offset: 0x1CBEF80 VA: 0x181CC0580
	internal static int GetThreadId() { }

	// RVA: 0x263D7A0 Offset: 0x263C1A0 VA: 0x18263D7A0
	public void .ctor() { }
}
