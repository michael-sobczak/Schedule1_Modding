internal class UIRLayoutUpdater : BaseVisualTreeUpdater // TypeDefIndex: 6745
{
	// Fields
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private List<KeyValuePair<Rect, VisualElement>> changeEventsList; // 0x20

	// Properties
	public override ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: 0x2EE53E0 Offset: 0x2EE3DE0 VA: 0x182EE53E0 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2EE4840 Offset: 0x2EE3240 VA: 0x182EE4840 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2EE5070 Offset: 0x2EE3A70 VA: 0x182EE5070 Slot: 12
	public override void Update() { }

	// RVA: 0x2EE48A0 Offset: 0x2EE32A0 VA: 0x182EE48A0
	private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents) { }

	// RVA: 0x2EE4590 Offset: 0x2EE2F90 VA: 0x182EE4590
	private void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass) { }

	// RVA: 0x2EE5360 Offset: 0x2EE3D60 VA: 0x182EE5360
	public void .ctor() { }

	// RVA: 0x2EE52C0 Offset: 0x2EE3CC0 VA: 0x182EE52C0
	private static void .cctor() { }
}
