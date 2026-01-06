public struct SteamInputGamepadSlotChange_t // TypeDefIndex: 14430
{
	// Fields
	public const int k_iCallback = 2804;
	public AppId_t m_unAppID; // 0x0
	public InputHandle_t m_ulDeviceHandle; // 0x8
	public ESteamInputType m_eDeviceType; // 0x10
	public int m_nOldGamepadSlot; // 0x14
	public int m_nNewGamepadSlot; // 0x18
}
