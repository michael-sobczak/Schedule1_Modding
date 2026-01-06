public class ISteamMatchmakingPingResponse // TypeDefIndex: 14729
{
	// Fields
	private ISteamMatchmakingPingResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded; // 0x28
	private ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond; // 0x30

	// Methods

	// RVA: 0xC83450 Offset: 0xC81E50 VA: 0x180C83450
	public void .ctor(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond) { }

	// RVA: 0xC83320 Offset: 0xC81D20 VA: 0x180C83320 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xC83420 Offset: 0xC81E20 VA: 0x180C83420
	private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server) { }

	// RVA: 0xC833F0 Offset: 0xC81DF0 VA: 0x180C833F0
	private void InternalOnServerFailedToRespond(IntPtr thisptr) { }

	// RVA: 0xC83760 Offset: 0xC82160 VA: 0x180C83760
	public static IntPtr op_Explicit(ISteamMatchmakingPingResponse that) { }
}
