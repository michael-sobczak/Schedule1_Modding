public class ISteamMatchmakingRulesResponse // TypeDefIndex: 14745
{
	// Fields
	private ISteamMatchmakingRulesResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded; // 0x28
	private ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond; // 0x30
	private ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete; // 0x38

	// Methods

	// RVA: 0xC83DC0 Offset: 0xC827C0 VA: 0x180C83DC0
	public void .ctor(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete) { }

	// RVA: 0xC83C90 Offset: 0xC82690 VA: 0x180C83C90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xC83D60 Offset: 0xC82760 VA: 0x180C83D60
	private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	// RVA: 0xC833F0 Offset: 0xC81DF0 VA: 0x180C833F0
	private void InternalOnRulesFailedToRespond(IntPtr thisptr) { }

	// RVA: 0xC838A0 Offset: 0xC822A0 VA: 0x180C838A0
	private void InternalOnRulesRefreshComplete(IntPtr thisptr) { }

	// RVA: 0xC83760 Offset: 0xC82160 VA: 0x180C83760
	public static IntPtr op_Explicit(ISteamMatchmakingRulesResponse that) { }
}
