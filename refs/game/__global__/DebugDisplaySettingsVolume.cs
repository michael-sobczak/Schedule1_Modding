public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 13625
{
	// Fields
	[CompilerGenerated]
	private readonly IVolumeDebugSettings2 <volumeDebugSettings>k__BackingField; // 0x10
	internal int volumeComponentEnumIndex; // 0x18

	// Properties
	public IVolumeDebugSettings2 volumeDebugSettings { get; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IVolumeDebugSettings2 get_volumeDebugSettings() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IVolumeDebugSettings2 volumeDebugSettings) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x29E8840 Offset: 0x29E7240 VA: 0x1829E8840 Slot: 4
	public IDebugDisplaySettingsPanelDisposable CreatePanel() { }
}
