internal sealed class VisualTreeUpdater : IDisposable // TypeDefIndex: 7061
{
	// Fields
	private BaseVisualElementPanel m_Panel; // 0x10
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x18

	// Methods

	// RVA: 0x2E12110 Offset: 0x2E10B10 VA: 0x182E12110
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x2E11BC0 Offset: 0x2E105C0 VA: 0x182E11BC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E11F70 Offset: 0x2E10970 VA: 0x182E11F70
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x2E11D30 Offset: 0x2E10730 VA: 0x182E11D30
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: -1 Offset: -1
	public void SetUpdater<T>(VisualTreeUpdatePhase phase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF765C0 Offset: 0xF74FC0 VA: 0x180F765C0
	|-VisualTreeUpdater.SetUpdater<object>
	|
	|-RVA: 0xF76340 Offset: 0xF74D40 VA: 0x180F76340
	|-VisualTreeUpdater.SetUpdater<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E11CF0 Offset: 0x2E106F0 VA: 0x182E11CF0
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x2E11E70 Offset: 0x2E10870 VA: 0x182E11E70
	private void SetDefaultUpdaters() { }
}
