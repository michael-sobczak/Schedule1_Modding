public static class SteamRemotePlay // TypeDefIndex: 14349
{
	// Methods

	// RVA: 0xC72FA0 Offset: 0xC719A0 VA: 0x180C72FA0
	public static uint GetSessionCount() { }

	// RVA: 0xC72FF0 Offset: 0xC719F0 VA: 0x180C72FF0
	public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) { }

	// RVA: 0xC73050 Offset: 0xC71A50 VA: 0x180C73050
	public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0xC72F40 Offset: 0xC71940 VA: 0x180C72F40
	public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0xC72EF0 Offset: 0xC718F0 VA: 0x180C72EF0
	public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0xC72DB0 Offset: 0xC717B0 VA: 0x180C72DB0
	public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	// RVA: 0xC72E90 Offset: 0xC71890 VA: 0x180C72E90
	public static bool BStartRemotePlayTogether(bool bShowOverlay = True) { }

	// RVA: 0xC72E30 Offset: 0xC71830 VA: 0x180C72E30
	public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) { }
}
