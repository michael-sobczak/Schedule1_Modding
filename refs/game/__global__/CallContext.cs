public sealed class CallContext // TypeDefIndex: 4360
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	// RVA: 0x1B28BB0 Offset: 0x1B275B0 VA: 0x181B28BB0
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

	// RVA: 0x1B28920 Offset: 0x1B27320 VA: 0x181B28920
	public static object LogicalGetData(string name) { }

	// RVA: 0x1B28A00 Offset: 0x1B27400 VA: 0x181B28A00
	public static void LogicalSetData(string name, object data) { }
}
