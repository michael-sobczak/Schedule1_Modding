internal class DebugDisplayStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 8819
{
	// Fields
	private DebugFrameTiming m_DebugFrameTiming; // 0x10

	// Properties
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	// RVA: 0x2AC78E0 Offset: 0x2AC62E0 VA: 0x182AC78E0
	public void UpdateFrameTiming() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool TryGetScreenClearColor(ref Color _) { }

	// RVA: 0x2AC7880 Offset: 0x2AC6280 VA: 0x182AC7880 Slot: 4
	public IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	// RVA: 0x2AC7900 Offset: 0x2AC6300 VA: 0x182AC7900
	public void .ctor() { }
}
