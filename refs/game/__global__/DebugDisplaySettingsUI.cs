public class DebugDisplaySettingsUI : IDebugData // TypeDefIndex: 13613
{
	// Fields
	private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels; // 0x10
	private IDebugDisplaySettings m_Settings; // 0x18

	// Methods

	// RVA: 0x29E82E0 Offset: 0x29E6CE0 VA: 0x1829E82E0
	private void Reset() { }

	// RVA: 0x29E8020 Offset: 0x29E6A20 VA: 0x1829E8020
	public void RegisterDebug(IDebugDisplaySettings settings) { }

	// RVA: 0x29E8380 Offset: 0x29E6D80 VA: 0x1829E8380
	public void UnregisterDebug() { }

	// RVA: 0x29E7FB0 Offset: 0x29E69B0 VA: 0x1829E7FB0 Slot: 4
	public Action GetReset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
