internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 11612
{
	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x2C85240 Offset: 0x2C83C40 VA: 0x182C85240
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2C851F0 Offset: 0x2C83BF0 VA: 0x182C851F0
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x2C85330 Offset: 0x2C83D30 VA: 0x182C85330 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x2C853A0 Offset: 0x2C83DA0 VA: 0x182C853A0
	public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

	// RVA: 0x2C852A0 Offset: 0x2C83CA0 VA: 0x182C852A0 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
