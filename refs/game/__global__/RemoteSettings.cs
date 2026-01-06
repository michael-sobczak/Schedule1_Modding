public static class RemoteSettings // TypeDefIndex: 19187
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F56FC0 Offset: 0x2F559C0 VA: 0x182F56FC0
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x2F56EF0 Offset: 0x2F558F0 VA: 0x182F56EF0
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x2F56F40 Offset: 0x2F55940 VA: 0x182F56F40
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}
