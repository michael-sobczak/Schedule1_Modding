public static class GameServer // TypeDefIndex: 14749
{
	// Methods

	// RVA: 0xC81FB0 Offset: 0xC809B0 VA: 0x180C81FB0
	public static ESteamAPIInitResult InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString, out string OutSteamErrMsg) { }

	// RVA: 0xC82580 Offset: 0xC80F80 VA: 0x180C82580
	public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString) { }

	// RVA: 0xC82680 Offset: 0xC81080 VA: 0x180C82680
	public static void Shutdown() { }

	// RVA: 0xC82630 Offset: 0xC81030 VA: 0x180C82630
	public static void RunCallbacks() { }

	// RVA: 0xC825C0 Offset: 0xC80FC0 VA: 0x180C825C0
	public static void ReleaseCurrentThreadMemory() { }

	// RVA: 0xC81E00 Offset: 0xC80800 VA: 0x180C81E00
	public static bool BSecure() { }

	// RVA: 0xC81F00 Offset: 0xC80900 VA: 0x180C81F00
	public static CSteamID GetSteamID() { }

	// RVA: 0xC81E70 Offset: 0xC80870 VA: 0x180C81E70
	public static HSteamPipe GetHSteamPipe() { }

	// RVA: 0xC81E90 Offset: 0xC80890 VA: 0x180C81E90
	public static HSteamUser GetHSteamUser() { }
}
