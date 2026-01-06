public static class SteamEncryptedAppTicket // TypeDefIndex: 14750
{
	// Methods

	// RVA: 0xCAFAC0 Offset: 0xCAE4C0 VA: 0x180CAFAC0
	public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey) { }

	// RVA: 0xCAFCF0 Offset: 0xCAE6F0 VA: 0x180CAFCF0
	public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0xCB0020 Offset: 0xCAEA20 VA: 0x180CB0020
	public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0xCB00B0 Offset: 0xCAEAB0 VA: 0x180CB00B0
	public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	// RVA: 0xCAFF90 Offset: 0xCAE990 VA: 0x180CAFF90
	public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0xCAFEF0 Offset: 0xCAE8F0 VA: 0x180CAFEF0
	public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0xCAFE50 Offset: 0xCAE850 VA: 0x180CAFE50
	public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0xCB27E0 Offset: 0xCB11E0 VA: 0x180CB27E0
	public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

	// RVA: 0xCAFD90 Offset: 0xCAE790 VA: 0x180CAFD90
	public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey) { }
}
