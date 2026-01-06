internal struct ProbeDilationSettings // TypeDefIndex: 13753
{
	// Fields
	public bool enableDilation; // 0x0
	public float dilationDistance; // 0x4
	public float dilationValidityThreshold; // 0x8
	public int dilationIterations; // 0xC
	public bool squaredDistWeighting; // 0x10

	// Methods

	// RVA: 0x2A20F50 Offset: 0x2A1F950 VA: 0x182A20F50
	internal void SetDefaults() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to) { }
}
