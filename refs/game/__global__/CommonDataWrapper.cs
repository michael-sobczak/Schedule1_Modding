internal class CommonDataWrapper : ICommonData // TypeDefIndex: 17926
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <GameBundleId>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <ProjectId>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Platform>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <BuildGUID>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <Idfv>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly string <GameStoreId>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly bool <HasVolume>k__BackingField; // 0x48

	// Properties
	public string Version { get; }
	public string GameBundleId { get; }
	public string ProjectId { get; }
	public string Platform { get; }
	public string BuildGUID { get; }
	public string Idfv { get; }
	public string GameStoreId { get; }
	public bool HasVolume { get; }
	public float Volume { get; }
	public double BatteryLevel { get; }
	public string AnalyticsRegionLanguageCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public string get_GameBundleId() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 6
	public string get_ProjectId() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public string get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 8
	public string get_BuildGUID() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 9
	public string get_Idfv() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 10
	public string get_GameStoreId() { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0 Slot: 11
	public bool get_HasVolume() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 12
	public float get_Volume() { }

	// RVA: 0x2B8D980 Offset: 0x2B8C380 VA: 0x182B8D980 Slot: 13
	public double get_BatteryLevel() { }

	// RVA: 0x2B8D8F0 Offset: 0x2B8C2F0 VA: 0x182B8D8F0 Slot: 14
	public string get_AnalyticsRegionLanguageCode() { }

	// RVA: 0x2B8D640 Offset: 0x2B8C040 VA: 0x182B8D640
	public void .ctor(string cloudProjectId) { }

	// RVA: 0x2B8D460 Offset: 0x2B8BE60 VA: 0x182B8D460
	private static string GetPlatform() { }
}
