public static class NetDebug // TypeDefIndex: 12403
{
	// Fields
	public static INetLogger Logger; // 0x0
	private static readonly object DebugLogLock; // 0x8

	// Methods

	// RVA: 0xCF73F0 Offset: 0xCF5DF0 VA: 0x180CF73F0
	private static void WriteLogic(NetLogLevel logLevel, string str, object[] args) { }

	[Conditional("DEBUG_MESSAGES")]
	// RVA: 0xCF7690 Offset: 0xCF6090 VA: 0x180CF7690
	internal static void Write(string str, object[] args) { }

	[Conditional("DEBUG_MESSAGES")]
	// RVA: 0xCF7620 Offset: 0xCF6020 VA: 0x180CF7620
	internal static void Write(NetLogLevel level, string str, object[] args) { }

	[Conditional("DEBUG")]
	[Conditional("DEBUG_MESSAGES")]
	// RVA: 0xCF7390 Offset: 0xCF5D90 VA: 0x180CF7390
	internal static void WriteForce(string str, object[] args) { }

	[Conditional("DEBUG")]
	[Conditional("DEBUG_MESSAGES")]
	// RVA: 0xCF7320 Offset: 0xCF5D20 VA: 0x180CF7320
	internal static void WriteForce(NetLogLevel level, string str, object[] args) { }

	// RVA: 0xCF72C0 Offset: 0xCF5CC0 VA: 0x180CF72C0
	internal static void WriteError(string str, object[] args) { }

	// RVA: 0xCF76F0 Offset: 0xCF60F0 VA: 0x180CF76F0
	private static void .cctor() { }
}
