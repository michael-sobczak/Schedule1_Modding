internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater // TypeDefIndex: 7064
{
	// Fields
	private HashSet<VisualElement> m_UpdateList; // 0x20
	private HashSet<VisualElement> m_ParentList; // 0x28
	private uint m_Version; // 0x30
	private uint m_LastVersion; // 0x34
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Properties
	public override ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: 0x2E12880 Offset: 0x2E11280 VA: 0x182E12880 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2E122C0 Offset: 0x2E10CC0 VA: 0x182E122C0 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2E12470 Offset: 0x2E10E70 VA: 0x182E12470 Slot: 12
	public override void Update() { }

	// RVA: 0x2E125D0 Offset: 0x2E10FD0 VA: 0x182E125D0
	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

	// RVA: 0x2E123C0 Offset: 0x2E10DC0 VA: 0x182E123C0
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x2E127D0 Offset: 0x2E111D0 VA: 0x182E127D0
	public void .ctor() { }

	// RVA: 0x2E12730 Offset: 0x2E11130 VA: 0x182E12730
	private static void .cctor() { }
}
