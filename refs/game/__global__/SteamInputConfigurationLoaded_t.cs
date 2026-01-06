public struct SteamInputConfigurationLoaded_t // TypeDefIndex: 14429
{
	// Fields
	public const int k_iCallback = 2803;
	public AppId_t m_unAppID; // 0x0
	public InputHandle_t m_ulDeviceHandle; // 0x8
	public CSteamID m_ulMappingCreator; // 0x10
	public uint m_unMajorRevision; // 0x18
	public uint m_unMinorRevision; // 0x1C
	public bool m_bUsesSteamInputAPI; // 0x20
	public bool m_bUsesGamepadAPI; // 0x21
}
