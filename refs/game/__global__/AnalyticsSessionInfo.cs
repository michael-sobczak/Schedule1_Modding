public static class AnalyticsSessionInfo // TypeDefIndex: 19195
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F56E30 Offset: 0x2F55830 VA: 0x182F56E30
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x2F56DD0 Offset: 0x2F557D0 VA: 0x182F56DD0
	internal static void CallIdentityTokenChanged(string token) { }
}
