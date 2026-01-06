public sealed class Trace // TypeDefIndex: 9579
{
	// Fields
	private static CorrelationManager correlationManager; // 0x0

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static CorrelationManager CorrelationManager { get; }

	// Methods

	// RVA: 0x263F9B0 Offset: 0x263E3B0 VA: 0x18263F9B0
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x263F870 Offset: 0x263E270 VA: 0x18263F870
	public static bool get_AutoFlush() { }

	// RVA: 0x263F900 Offset: 0x263E300 VA: 0x18263F900
	public static CorrelationManager get_CorrelationManager() { }
}
