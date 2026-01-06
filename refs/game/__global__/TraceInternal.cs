internal static class TraceInternal // TypeDefIndex: 9583
{
	// Fields
	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	[ThreadStatic]
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }

	// Methods

	// RVA: 0x263DD30 Offset: 0x263C730 VA: 0x18263DD30
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x263DC20 Offset: 0x263C620 VA: 0x18263DC20
	public static bool get_AutoFlush() { }

	// RVA: 0x263DC80 Offset: 0x263C680 VA: 0x18263DC80
	public static int get_IndentLevel() { }

	// RVA: 0x263DCD0 Offset: 0x263C6D0 VA: 0x18263DCD0
	public static int get_IndentSize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void InitializeSettings() { }

	// RVA: 0x263DB70 Offset: 0x263C570 VA: 0x18263DB70
	private static void .cctor() { }
}
