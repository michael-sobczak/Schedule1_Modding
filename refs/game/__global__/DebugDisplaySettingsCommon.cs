internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 8769
{
	// Properties
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool TryGetScreenClearColor(ref Color _) { }

	// RVA: 0x2AC6940 Offset: 0x2AC5340 VA: 0x182AC6940 Slot: 4
	public IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
