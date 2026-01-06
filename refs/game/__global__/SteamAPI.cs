public static class SteamAPI // TypeDefIndex: 14748
{
	// Methods

	// RVA: 0xCB1BD0 Offset: 0xCB05D0 VA: 0x180CB1BD0
	public static ESteamAPIInitResult InitEx(out string OutSteamErrMsg) { }

	// RVA: 0xCB2410 Offset: 0xCB0E10 VA: 0x180CB2410
	public static bool Init() { }

	// RVA: 0xCB2490 Offset: 0xCB0E90 VA: 0x180CB2490
	public static void Shutdown() { }

	// RVA: 0xCAD710 Offset: 0xCAC110 VA: 0x180CAD710
	public static bool RestartAppIfNecessary(AppId_t unOwnAppID) { }

	// RVA: 0xCAD6A0 Offset: 0xCAC0A0 VA: 0x180CAD6A0
	public static void ReleaseCurrentThreadMemory() { }

	// RVA: 0xCB2440 Offset: 0xCB0E40 VA: 0x180CB2440
	public static void RunCallbacks() { }

	// RVA: 0xCAD230 Offset: 0xCABC30 VA: 0x180CAD230
	public static bool IsSteamRunning() { }

	// RVA: 0xCB1B40 Offset: 0xCB0540 VA: 0x180CB1B40
	public static HSteamPipe GetHSteamPipe() { }

	// RVA: 0xCB1B60 Offset: 0xCB0560 VA: 0x180CB1B60
	public static HSteamUser GetHSteamUser() { }
}
