public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings> // TypeDefIndex: 8825
{
	// Fields
	[CompilerGenerated]
	private DebugDisplaySettingsCommon <commonSettings>k__BackingField; // 0x18
	[CompilerGenerated]
	private DebugDisplaySettingsMaterial <materialSettings>k__BackingField; // 0x20
	[CompilerGenerated]
	private DebugDisplaySettingsRendering <renderingSettings>k__BackingField; // 0x28
	[CompilerGenerated]
	private DebugDisplaySettingsLighting <lightingSettings>k__BackingField; // 0x30
	[CompilerGenerated]
	private DebugDisplaySettingsVolume <volumeSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private DebugDisplayStats <displayStats>k__BackingField; // 0x40

	// Properties
	private DebugDisplaySettingsCommon commonSettings { get; set; }
	public DebugDisplaySettingsMaterial materialSettings { get; set; }
	public DebugDisplaySettingsRendering renderingSettings { get; set; }
	public DebugDisplaySettingsLighting lightingSettings { get; set; }
	public DebugDisplaySettingsVolume volumeSettings { get; set; }
	internal DebugDisplayStats displayStats { get; set; }
	public override bool IsPostProcessingAllowed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	private DebugDisplaySettingsCommon get_commonSettings() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_commonSettings(DebugDisplaySettingsCommon value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DebugDisplaySettingsMaterial get_materialSettings() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_materialSettings(DebugDisplaySettingsMaterial value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DebugDisplaySettingsRendering get_renderingSettings() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_renderingSettings(DebugDisplaySettingsRendering value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public DebugDisplaySettingsLighting get_lightingSettings() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_lightingSettings(DebugDisplaySettingsLighting value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public DebugDisplaySettingsVolume get_volumeSettings() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_volumeSettings(DebugDisplaySettingsVolume value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal DebugDisplayStats get_displayStats() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_displayStats(DebugDisplayStats value) { }

	// RVA: 0x2ADAB80 Offset: 0x2AD9580 VA: 0x182ADAB80 Slot: 11
	public override bool get_IsPostProcessingAllowed() { }

	// RVA: 0x2ADAB00 Offset: 0x2AD9500 VA: 0x182ADAB00
	public void .ctor() { }

	// RVA: 0x2ADA7B0 Offset: 0x2AD91B0 VA: 0x182ADA7B0 Slot: 13
	public override void Reset() { }

	// RVA: 0x2ADAAD0 Offset: 0x2AD94D0 VA: 0x182ADAAD0
	internal void UpdateFrameTiming() { }
}
