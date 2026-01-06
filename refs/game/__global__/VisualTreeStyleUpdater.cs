internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater // TypeDefIndex: 7055
{
	// Fields
	private HashSet<VisualElement> m_ApplyStyleUpdateList; // 0x20
	private HashSet<VisualElement> m_TransitionPropertyUpdateList; // 0x28
	private bool m_IsApplyingStyles; // 0x30
	private uint m_Version; // 0x34
	private uint m_LastVersion; // 0x38
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2E11B70 Offset: 0x2E10570 VA: 0x182E11B70 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2E11540 Offset: 0x2E0FF40 VA: 0x182E11540 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2E11600 Offset: 0x2E10000 VA: 0x182E11600 Slot: 12
	public override void Update() { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_disposed(bool value) { }

	// RVA: 0x2E11500 Offset: 0x2E0FF00 VA: 0x182E11500 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2E11400 Offset: 0x2E0FE00 VA: 0x182E11400
	private void ApplyStyles() { }

	// RVA: 0x2E11A80 Offset: 0x2E10480 VA: 0x182E11A80
	public void .ctor() { }

	// RVA: 0x2E119E0 Offset: 0x2E103E0 VA: 0x182E119E0
	private static void .cctor() { }
}
