internal struct VirtualOffsetSettings // TypeDefIndex: 13754
{
	// Fields
	public bool useVirtualOffset; // 0x0
	[Range(0, 1)]
	public float outOfGeoOffset; // 0x4
	[Range(0, 2)]
	public float searchMultiplier; // 0x8
	[Range(-0.05, 0)]
	public float rayOriginBias; // 0xC
	[Range(4, 24)]
	public int maxHitsPerRay; // 0x10
	public LayerMask collisionMask; // 0x14

	// Methods

	// RVA: 0x2A2DD20 Offset: 0x2A2C720 VA: 0x182A2DD20
	internal void SetDefaults() { }

	// RVA: 0x2A2DD60 Offset: 0x2A2C760 VA: 0x182A2DD60
	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to) { }
}
