public class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 8776
{
	// Fields
	[CompilerGenerated]
	private DebugLightingMode <lightingDebugMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField; // 0x14
	[CompilerGenerated]
	private HDRDebugMode <hdrDebugMode>k__BackingField; // 0x18

	// Properties
	public DebugLightingMode lightingDebugMode { get; set; }
	public DebugLightingFeatureFlags lightingFeatureFlags { get; set; }
	public HDRDebugMode hdrDebugMode { get; set; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public DebugLightingMode get_lightingDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_lightingDebugMode(DebugLightingMode value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public DebugLightingFeatureFlags get_lightingFeatureFlags() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_lightingFeatureFlags(DebugLightingFeatureFlags value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public HDRDebugMode get_hdrDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_hdrDebugMode(HDRDebugMode value) { }

	// RVA: 0x2AC6B10 Offset: 0x2AC5510 VA: 0x182AC6B10 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x2AC6B30 Offset: 0x2AC5530 VA: 0x182AC6B30 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x2AC6990 Offset: 0x2AC5390 VA: 0x182AC6990 Slot: 4
	private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
