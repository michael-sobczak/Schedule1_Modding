internal struct ProbeVolumeBakingProcessSettings // TypeDefIndex: 13756
{
	// Fields
	[SerializeField]
	private ProbeVolumeBakingProcessSettings.SettingsVersion m_Version; // 0x0
	public ProbeDilationSettings dilationSettings; // 0x4
	public VirtualOffsetSettings virtualOffsetSettings; // 0x18

	// Properties
	internal static ProbeVolumeBakingProcessSettings Default { get; }

	// Methods

	// RVA: 0x2A22130 Offset: 0x2A20B30 VA: 0x182A22130
	internal static ProbeVolumeBakingProcessSettings get_Default() { }

	// RVA: 0x2A22100 Offset: 0x2A20B00 VA: 0x182A22100
	internal void .ctor(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings) { }

	// RVA: 0x2A22050 Offset: 0x2A20A50 VA: 0x182A22050
	internal void SetDefaults() { }

	// RVA: 0x2A220C0 Offset: 0x2A20AC0 VA: 0x182A220C0
	internal void Upgrade() { }
}
