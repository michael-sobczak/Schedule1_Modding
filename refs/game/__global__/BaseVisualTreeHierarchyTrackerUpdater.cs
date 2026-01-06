internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater // TypeDefIndex: 7053
{
	// Fields
	private BaseVisualTreeHierarchyTrackerUpdater.State m_State; // 0x20
	private VisualElement m_CurrentChangeElement; // 0x28
	private VisualElement m_CurrentChangeParent; // 0x30

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);

	// RVA: 0x2DF94B0 Offset: 0x2DF7EB0 VA: 0x182DF94B0 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2DF98E0 Offset: 0x2DF82E0 VA: 0x182DF98E0 Slot: 12
	public override void Update() { }

	// RVA: 0x2DF9790 Offset: 0x2DF8190 VA: 0x182DF9790
	private void ProcessNewChange(VisualElement ve) { }

	// RVA: 0x2DF96D0 Offset: 0x2DF80D0 VA: 0x182DF96D0
	private void ProcessAddOrMove(VisualElement ve) { }

	// RVA: 0x2DF9840 Offset: 0x2DF8240 VA: 0x182DF9840
	private void ProcessRemove(VisualElement ve) { }

	// RVA: 0x2DF99A0 Offset: 0x2DF83A0 VA: 0x182DF99A0
	protected void .ctor() { }
}
