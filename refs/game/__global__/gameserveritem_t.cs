public class gameserveritem_t // TypeDefIndex: 14753
{
	// Fields
	public servernetadr_t m_NetAdr; // 0x10
	public int m_nPing; // 0x18
	public bool m_bHadSuccessfulResponse; // 0x1C
	public bool m_bDoNotRefresh; // 0x1D
	private byte[] m_szGameDir; // 0x20
	private byte[] m_szMap; // 0x28
	private byte[] m_szGameDescription; // 0x30
	public uint m_nAppID; // 0x38
	public int m_nPlayers; // 0x3C
	public int m_nMaxPlayers; // 0x40
	public int m_nBotPlayers; // 0x44
	public bool m_bPassword; // 0x48
	public bool m_bSecure; // 0x49
	public uint m_ulTimeLastPlayed; // 0x4C
	public int m_nServerVersion; // 0x50
	private byte[] m_szServerName; // 0x58
	private byte[] m_szGameTags; // 0x60
	public CSteamID m_steamID; // 0x68

	// Methods

	// RVA: 0xCBD850 Offset: 0xCBC250 VA: 0x180CBD850
	public string GetGameDir() { }

	// RVA: 0xCBDB70 Offset: 0xCBC570 VA: 0x180CBDB70
	public void SetGameDir(string dir) { }

	// RVA: 0xCBD970 Offset: 0xCBC370 VA: 0x180CBD970
	public string GetMap() { }

	// RVA: 0xCBDCB0 Offset: 0xCBC6B0 VA: 0x180CBDCB0
	public void SetMap(string map) { }

	// RVA: 0xCBD7C0 Offset: 0xCBC1C0 VA: 0x180CBD7C0
	public string GetGameDescription() { }

	// RVA: 0xCBDAD0 Offset: 0xCBC4D0 VA: 0x180CBDAD0
	public void SetGameDescription(string desc) { }

	// RVA: 0xCBDA00 Offset: 0xCBC400 VA: 0x180CBDA00
	public string GetServerName() { }

	// RVA: 0xCBDD50 Offset: 0xCBC750 VA: 0x180CBDD50
	public void SetServerName(string name) { }

	// RVA: 0xCBD8E0 Offset: 0xCBC2E0 VA: 0x180CBD8E0
	public string GetGameTags() { }

	// RVA: 0xCBDC10 Offset: 0xCBC610 VA: 0x180CBDC10
	public void SetGameTags(string tags) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
