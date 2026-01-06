internal class Panel : BaseVisualElementPanel // TypeDefIndex: 6730
{
	// Fields
	private VisualElement m_RootContainer; // 0xA8
	private VisualTreeUpdater m_VisualTreeUpdater; // 0xB0
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB8
	private string m_PanelName; // 0xC0
	private uint m_Version; // 0xC8
	private uint m_RepaintVersion; // 0xCC
	private uint m_HierarchyVersion; // 0xD0
	private ProfilerMarker m_MarkerBeforeUpdate; // 0xD8
	private ProfilerMarker m_MarkerUpdate; // 0xE0
	private ProfilerMarker m_MarkerLayout; // 0xE8
	private ProfilerMarker m_MarkerBindings; // 0xF0
	private ProfilerMarker m_MarkerAnimations; // 0xF8
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventDispatcher <dispatcher>k__BackingField; // 0x100
	private TimerEventScheduler m_Scheduler; // 0x108
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ScriptableObject <ownerObject>k__BackingField; // 0x110
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ContextType <contextType>k__BackingField; // 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SavePersistentViewData <saveViewData>k__BackingField; // 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; // 0x128
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private FocusController <focusController>k__BackingField; // 0x130
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; // 0x8
	private bool m_JustReceivedFocus; // 0x13B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <IMGUIContainersCount>k__BackingField; // 0x13C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x140
	private Shader m_StandardShader; // 0x148
	private AtlasBase m_Atlas; // 0x150
	private bool m_ValidatingLayout; // 0x158
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Panel> beforeAnyRepaint; // 0x18

	// Properties
	public sealed override VisualElement visualTree { get; }
	public sealed override EventDispatcher dispatcher { get; set; }
	public TimerEventScheduler timerEventScheduler { get; }
	internal override IScheduler scheduler { get; }
	internal override IStylePropertyAnimationSystem styleAnimationSystem { get; set; }
	public override ScriptableObject ownerObject { get; set; }
	public override ContextType contextType { get; set; }
	public override SavePersistentViewData saveViewData { get; }
	public override GetViewDataDictionary getViewDataDictionary { get; }
	public sealed override FocusController focusController { get; set; }
	public override EventInterests IMGUIEventInterests { get; set; }
	private static LoadResourceFunction loadResourceFunc { get; }
	internal string name { get; set; }
	private static TimeMsFunction TimeSinceStartup { get; }
	public override int IMGUIContainersCount { get; set; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }
	internal override uint hierarchyVersion { get; }
	internal override Shader standardShader { get; }
	public override AtlasBase atlas { get; set; }

	// Methods

	// RVA: 0x2D0E150 Offset: 0x2D0CB50 VA: 0x182D0E150 Slot: 38
	public sealed override VisualElement get_visualTree() { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250 Slot: 39
	public sealed override EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20 Slot: 40
	public sealed override void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x2EB0840 Offset: 0x2EAF240 VA: 0x182EB0840
	public TimerEventScheduler get_timerEventScheduler() { }

	// RVA: 0x2EB0840 Offset: 0x2EAF240 VA: 0x182EB0840 Slot: 41
	internal override IScheduler get_scheduler() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160 Slot: 42
	internal override IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: 0x2EB09B0 Offset: 0x2EAF3B0 VA: 0x182EB09B0 Slot: 43
	internal override void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0 Slot: 14
	public override ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0 Slot: 15
	protected override void set_ownerObject(ScriptableObject value) { }

	[CompilerGenerated]
	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0 Slot: 44
	public override ContextType get_contextType() { }

	[CompilerGenerated]
	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60 Slot: 45
	protected override void set_contextType(ContextType value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 16
	public override SavePersistentViewData get_saveViewData() { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 17
	public override GetViewDataDictionary get_getViewDataDictionary() { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840 Slot: 20
	public sealed override FocusController get_focusController() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0 Slot: 21
	public sealed override void set_focusController(FocusController value) { }

	[CompilerGenerated]
	// RVA: 0x2EB0770 Offset: 0x2EAF170 VA: 0x182EB0770 Slot: 12
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGenerated]
	// RVA: 0x2EB08D0 Offset: 0x2EAF2D0 VA: 0x182EB08D0 Slot: 13
	public override void set_IMGUIEventInterests(EventInterests value) { }

	[CompilerGenerated]
	// RVA: 0x2EB07F0 Offset: 0x2EAF1F0 VA: 0x182EB07F0
	private static LoadResourceFunction get_loadResourceFunc() { }

	// RVA: 0x2EAF3D0 Offset: 0x2EADDD0 VA: 0x182EAF3D0
	internal static Object LoadResource(string pathName, Type type, float dpiScaling) { }

	// RVA: 0x2EAF390 Offset: 0x2EADD90 VA: 0x182EAF390
	internal void Focus() { }

	// RVA: 0x2EAEE70 Offset: 0x2EAD870 VA: 0x182EAEE70
	internal void Blur() { }

	// RVA: 0x2EB0060 Offset: 0x2EAEA60 VA: 0x182EB0060 Slot: 25
	public override void ValidateFocus() { }

	// RVA: 0x2D0E220 Offset: 0x2D0CC20 VA: 0x182D0E220
	internal string get_name() { }

	// RVA: 0x2EB0980 Offset: 0x2EAF380 VA: 0x182EB0980
	internal void set_name(string value) { }

	// RVA: 0x2EAEF90 Offset: 0x2EAD990 VA: 0x182EAEF90
	private void CreateMarkers() { }

	[CompilerGenerated]
	// RVA: 0x2EB0790 Offset: 0x2EAF190 VA: 0x182EB0790
	private static TimeMsFunction get_TimeSinceStartup() { }

	[CompilerGenerated]
	// RVA: 0x6BFD80 Offset: 0x6BE780 VA: 0x1806BFD80 Slot: 18
	public override int get_IMGUIContainersCount() { }

	[CompilerGenerated]
	// RVA: 0x6BFF80 Offset: 0x6BE980 VA: 0x1806BFF80 Slot: 19
	public override void set_IMGUIContainersCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 22
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350 Slot: 30
	internal override uint get_version() { }

	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30 Slot: 31
	internal override uint get_hierarchyVersion() { }

	// RVA: 0x2EB08C0 Offset: 0x2EAF2C0 VA: 0x182EB08C0 Slot: 49
	internal override Shader get_standardShader() { }

	// RVA: 0x2EB07E0 Offset: 0x2EAF1E0 VA: 0x182EB07E0 Slot: 51
	public override AtlasBase get_atlas() { }

	// RVA: 0x2EB08F0 Offset: 0x2EAF2F0 VA: 0x182EB08F0 Slot: 52
	public override void set_atlas(AtlasBase value) { }

	// RVA: 0x2EB0210 Offset: 0x2EAEC10 VA: 0x182EB0210
	public void .ctor(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	// RVA: 0x2EAF210 Offset: 0x2EADC10 VA: 0x182EAF210 Slot: 23
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EAFEB0 Offset: 0x2EAE8B0 VA: 0x182EAFEB0
	public static long TimeSinceStartupMs() { }

	// RVA: 0x2EAF1F0 Offset: 0x2EADBF0 VA: 0x182EAF1F0
	internal static long DefaultTimeSinceStartupMs() { }

	// RVA: 0x2EAF8F0 Offset: 0x2EAE2F0 VA: 0x182EAF8F0
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked, bool includeIgnoredElement = False) { }

	// RVA: 0x2EAF560 Offset: 0x2EADF60 VA: 0x182EAF560
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked, bool includeIgnoredElement = False) { }

	// RVA: 0x2EAF810 Offset: 0x2EAE210 VA: 0x182EAF810 Slot: 47
	public override VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	// RVA: 0x2EAF980 Offset: 0x2EAE380 VA: 0x182EAF980 Slot: 46
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0x2EB0130 Offset: 0x2EAEB30 VA: 0x182EB0130 Slot: 26
	public override void ValidateLayout() { }

	// RVA: 0x2EAFF70 Offset: 0x2EAE970 VA: 0x182EAFF70 Slot: 27
	public override void UpdateAnimations() { }

	// RVA: 0x2EAFFA0 Offset: 0x2EAE9A0 VA: 0x182EAFFA0 Slot: 28
	public override void UpdateBindings() { }

	// RVA: 0x2EAEE40 Offset: 0x2EAD840 VA: 0x182EAEE40 Slot: 29
	public override void ApplyStyles() { }

	// RVA: 0x2EAFFD0 Offset: 0x2EAE9D0 VA: 0x182EAFFD0
	private void UpdateForRepaint() { }

	// RVA: 0x2EAFB00 Offset: 0x2EAE500 VA: 0x182EAFB00 Slot: 24
	public override void Repaint(Event e) { }

	// RVA: 0x2EAF510 Offset: 0x2EADF10 VA: 0x182EAF510 Slot: 32
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2EAF3A0 Offset: 0x2EADDA0 VA: 0x182EAF3A0 Slot: 48
	internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x2EB01B0 Offset: 0x2EAEBB0 VA: 0x182EB01B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2CD1890 Offset: 0x2CD0290 VA: 0x182CD1890
	internal static Vector2Int <Pick>g__PixelOf|101_0(Vector2 p) { }
}
