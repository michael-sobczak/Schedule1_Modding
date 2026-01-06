internal class VisualElementAnimationSystem : BaseVisualTreeUpdater // TypeDefIndex: 7049
{
	// Fields
	private HashSet<IValueAnimationUpdate> m_Animations; // 0x20
	private List<IValueAnimationUpdate> m_IterationList; // 0x28
	private bool m_HasNewAnimations; // 0x30
	private bool m_IterationListDirty; // 0x31
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private static readonly string s_StylePropertyAnimationDescription; // 0x10
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
	private long lastUpdate; // 0x38

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	private static ProfilerMarker stylePropertyAnimationProfilerMarker { get; }

	// Methods

	// RVA: 0x2E0E200 Offset: 0x2E0CC00 VA: 0x182E0E200 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2E0E250 Offset: 0x2E0CC50 VA: 0x182E0E250
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	// RVA: 0x2E0DAD0 Offset: 0x2E0C4D0 VA: 0x182E0DAD0
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x2E0DB30 Offset: 0x2E0C530 VA: 0x182E0DB30
	public void UnregisterAnimations(List<IValueAnimationUpdate> anims) { }

	// RVA: 0x2E0D930 Offset: 0x2E0C330 VA: 0x182E0D930
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x2E0D990 Offset: 0x2E0C390 VA: 0x182E0D990
	public void RegisterAnimations(List<IValueAnimationUpdate> anims) { }

	// RVA: 0x2E0DC70 Offset: 0x2E0C670 VA: 0x182E0DC70 Slot: 12
	public override void Update() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2E0E130 Offset: 0x2E0CB30 VA: 0x182E0E130
	public void .ctor() { }

	// RVA: 0x2E0E010 Offset: 0x2E0CA10 VA: 0x182E0E010
	private static void .cctor() { }
}
