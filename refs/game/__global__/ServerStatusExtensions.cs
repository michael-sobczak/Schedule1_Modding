public static class ServerStatusExtensions // TypeDefIndex: 16863
{
	// Methods

	[Extension]
	// RVA: 0xCD2920 Offset: 0xCD1320 VA: 0x180CD2920
	private static string GetServerStatusLabel(Status serverStatusResponse) { }

	[Extension]
	// RVA: 0xCD29F0 Offset: 0xCD13F0 VA: 0x180CD29F0
	public static ServerStatus GetServerStatus(Status serverStatusResponse) { }

	[Extension]
	// RVA: 0xCD2C20 Offset: 0xCD1620 VA: 0x180CD2C20
	public static string GetStatusBgClass(ServerStatus serverStatus) { }

	[Extension]
	// RVA: 0xCD2840 Offset: 0xCD1240 VA: 0x180CD2840
	public static string GetLabelText(ServerStatus serverStatus) { }

	[Extension]
	// RVA: 0xCD2CB0 Offset: 0xCD16B0 VA: 0x180CD2CB0
	public static bool IsOneOf(ServerStatus serverStatus, ServerStatus[] serverStatusOptions) { }
}
