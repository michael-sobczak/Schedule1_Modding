public static class SteamVideo // TypeDefIndex: 14357
{
	// Methods

	// RVA: 0xCBD150 Offset: 0xCBBB50 VA: 0x180CBD150
	public static void GetVideoURL(AppId_t unVideoAppID) { }

	// RVA: 0xCBD210 Offset: 0xCBBC10 VA: 0x180CBD210
	public static bool IsBroadcasting(out int pnNumViewers) { }

	// RVA: 0xCBCF20 Offset: 0xCBB920 VA: 0x180CBCF20
	public static void GetOPFSettings(AppId_t unVideoAppID) { }

	// RVA: 0xCBCFE0 Offset: 0xCBB9E0 VA: 0x180CBCFE0
	public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize) { }
}
