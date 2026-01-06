public static class EdgegapServerDataManager // TypeDefIndex: 16859
{
	// Fields
	internal static Status _serverData; // 0x0
	private static ApiEnvironment _apiEnvironment; // 0x8
	private static readonly StyleSheet _serverDataStylesheet; // 0x10
	private static readonly List<VisualElement> _serverDataContainers; // 0x18

	// Methods

	// RVA: 0xCCCA30 Offset: 0xCCB430 VA: 0x180CCCA30
	public static Status GetServerStatus() { }

	// RVA: 0xCCD270 Offset: 0xCCBC70 VA: 0x180CCD270
	private static void .cctor() { }

	// RVA: 0xCCD110 Offset: 0xCCBB10 VA: 0x180CCD110
	public static void RegisterServerDataContainer(VisualElement serverDataContainer) { }

	// RVA: 0xCCBF90 Offset: 0xCCA990 VA: 0x180CCBF90
	public static void DeregisterServerDataContainer(VisualElement serverDataContainer) { }

	// RVA: 0xCCD1E0 Offset: 0xCCBBE0 VA: 0x180CCD1E0
	public static void SetServerData(Status serverData, ApiEnvironment apiEnvironment) { }

	// RVA: 0xCCCA80 Offset: 0xCCB480 VA: 0x180CCCA80
	private static VisualElement GetStatusSection() { }

	// RVA: 0xCCC010 Offset: 0xCCAA10 VA: 0x180CCC010
	private static VisualElement GetDnsSection() { }

	// RVA: 0xCCC1E0 Offset: 0xCCABE0 VA: 0x180CCC1E0
	private static VisualElement GetPortsSection() { }

	// RVA: 0xCCC670 Offset: 0xCCB070 VA: 0x180CCC670
	public static VisualElement GetServerDataVisualTree() { }

	// RVA: 0xCCCFA0 Offset: 0xCCB9A0 VA: 0x180CCCFA0
	private static void RefreshServerDataContainers() { }
}
