internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater // TypeDefIndex: 7050
{
	// Fields
	private uint m_Version; // 0x20
	private uint m_LastVersion; // 0x24
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Properties
	public override ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: 0x2E0F240 Offset: 0x2E0DC40 VA: 0x182E0F240 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2E0EFD0 Offset: 0x2E0D9D0 VA: 0x182E0EFD0 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2E0EEE0 Offset: 0x2E0D8E0 VA: 0x182E0EEE0
	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	// RVA: 0x2E0EE70 Offset: 0x2E0D870 VA: 0x182E0EE70
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	// RVA: 0x2E0F120 Offset: 0x2E0DB20 VA: 0x182E0F120 Slot: 12
	public override void Update() { }

	// RVA: 0x2E0F230 Offset: 0x2E0DC30 VA: 0x182E0F230
	public void .ctor() { }

	// RVA: 0x2E0F190 Offset: 0x2E0DB90 VA: 0x182E0F190
	private static void .cctor() { }
}
