internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater // TypeDefIndex: 6176
{
	// Fields
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; // 0x0
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x4
	private static readonly string s_Description; // 0x8
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x10
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
	private static ProfilerMarker s_MarkerUpdate; // 0x20
	private static ProfilerMarker s_MarkerPoll; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <disableBindingsThrottling>k__BackingField; // 0x30
	private readonly HashSet<VisualElement> m_ElementsWithBindings; // 0x38
	private readonly HashSet<VisualElement> m_ElementsToAdd; // 0x40
	private readonly HashSet<VisualElement> m_ElementsToRemove; // 0x48
	private long m_LastUpdateTime; // 0x50
	private HashSet<VisualElement> m_ElementsToBind; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Dictionary<object, object> <temporaryObjectCache>k__BackingField; // 0x60
	private List<IBinding> updatedBindings; // 0x68

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	public static bool disableBindingsThrottling { get; }
	public Dictionary<object, object> temporaryObjectCache { get; }

	// Methods

	// RVA: 0x2DBE930 Offset: 0x2DBD330 VA: 0x182DBE930 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	[CompilerGenerated]
	// RVA: 0x2DBE8E0 Offset: 0x2DBD2E0 VA: 0x182DBE8E0
	public static bool get_disableBindingsThrottling() { }

	// RVA: 0x2DBD320 Offset: 0x2DBBD20 VA: 0x182DBD320
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	// RVA: 0x2DBD900 Offset: 0x2DBC300 VA: 0x182DBD900
	private void StartTracking(VisualElement ve) { }

	// RVA: 0x2DBDAA0 Offset: 0x2DBC4A0 VA: 0x182DBDAA0
	private void StopTracking(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Dictionary<object, object> get_temporaryObjectCache() { }

	// RVA: 0x2DBD290 Offset: 0x2DBBC90 VA: 0x182DBD290
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	// RVA: 0x2DBD7D0 Offset: 0x2DBC1D0 VA: 0x182DBD7D0
	private void StartTrackingRecursive(VisualElement ve) { }

	// RVA: 0x2DBD980 Offset: 0x2DBC380 VA: 0x182DBD980
	private void StopTrackingRecursive(VisualElement ve) { }

	// RVA: 0x2DBD460 Offset: 0x2DBBE60 VA: 0x182DBD460 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2DBD430 Offset: 0x2DBBE30 VA: 0x182DBD430 Slot: 14
	protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x2DBD250 Offset: 0x2DBBC50 VA: 0x182DBD250
	private static long CurrentTime() { }

	// RVA: 0x2DBD550 Offset: 0x2DBBF50 VA: 0x182DBD550
	public void PerformTrackingOperations() { }

	// RVA: 0x2DBDFF0 Offset: 0x2DBC9F0 VA: 0x182DBDFF0 Slot: 12
	public override void Update() { }

	// RVA: 0x2DBDB20 Offset: 0x2DBC520 VA: 0x182DBDB20
	private void UpdateBindings() { }

	// RVA: 0x2DBE740 Offset: 0x2DBD140 VA: 0x182DBE740
	public void .ctor() { }

	// RVA: 0x2DBE580 Offset: 0x2DBCF80 VA: 0x182DBE580
	private static void .cctor() { }
}
