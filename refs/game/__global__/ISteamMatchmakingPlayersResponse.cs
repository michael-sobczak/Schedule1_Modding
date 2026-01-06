public class ISteamMatchmakingPlayersResponse // TypeDefIndex: 14737
{
	// Fields
	private ISteamMatchmakingPlayersResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList; // 0x28
	private ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond; // 0x30
	private ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete; // 0x38

	// Methods

	// RVA: 0xC838D0 Offset: 0xC822D0 VA: 0x180C838D0
	public void .ctor(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete) { }

	// RVA: 0xC83780 Offset: 0xC82180 VA: 0x180C83780 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xC83850 Offset: 0xC82250 VA: 0x180C83850
	private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	// RVA: 0xC833F0 Offset: 0xC81DF0 VA: 0x180C833F0
	private void InternalOnPlayersFailedToRespond(IntPtr thisptr) { }

	// RVA: 0xC838A0 Offset: 0xC822A0 VA: 0x180C838A0
	private void InternalOnPlayersRefreshComplete(IntPtr thisptr) { }

	// RVA: 0xC83760 Offset: 0xC82160 VA: 0x180C83760
	public static IntPtr op_Explicit(ISteamMatchmakingPlayersResponse that) { }
}
