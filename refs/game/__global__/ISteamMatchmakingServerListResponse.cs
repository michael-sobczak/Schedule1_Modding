public class ISteamMatchmakingServerListResponse // TypeDefIndex: 14723
{
	// Fields
	private ISteamMatchmakingServerListResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded; // 0x28
	private ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond; // 0x30
	private ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete; // 0x38

	// Methods

	// RVA: 0xC843A0 Offset: 0xC82DA0 VA: 0x180C843A0
	public void .ctor(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete) { }

	// RVA: 0xC84180 Offset: 0xC82B80 VA: 0x180C84180 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xC84330 Offset: 0xC82D30 VA: 0x180C84330
	private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0xC842C0 Offset: 0xC82CC0 VA: 0x180C842C0
	private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0xC84250 Offset: 0xC82C50 VA: 0x180C84250
	private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	// RVA: 0xC83760 Offset: 0xC82160 VA: 0x180C83760
	public static IntPtr op_Explicit(ISteamMatchmakingServerListResponse that) { }
}
