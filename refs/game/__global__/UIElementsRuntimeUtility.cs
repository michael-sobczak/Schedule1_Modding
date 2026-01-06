internal static class UIElementsRuntimeUtility // TypeDefIndex: 6928
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<BaseRuntimePanel> onCreatePanel; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static List<Panel> s_SortedRuntimePanels; // 0x10
	private static bool s_PanelOrderingDirty; // 0x18
	internal static int s_ResolvedSortingIndexMax; // 0x1C
	internal static readonly string s_RepaintProfilerMarkerName; // 0x20
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
	private static int currentOverlayIndex; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Object <activeEventSystem>k__BackingField; // 0x38
	private static DefaultEventSystem s_DefaultEventSystem; // 0x40
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48

	// Properties
	internal static Object activeEventSystem { get; set; }
	internal static bool useDefaultEventSystem { get; }
	internal static DefaultEventSystem defaultEventSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DE7ED0 Offset: 0x2DE68D0 VA: 0x182DE7ED0
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[CompilerGenerated]
	// RVA: 0x2DE81B0 Offset: 0x2DE6BB0 VA: 0x182DE81B0
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	// RVA: 0x2DE7A80 Offset: 0x2DE6480 VA: 0x182DE7A80
	private static void .cctor() { }

	// RVA: 0x2DE58B0 Offset: 0x2DE42B0 VA: 0x182DE58B0
	public static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x2DE5AB0 Offset: 0x2DE44B0 VA: 0x182DE5AB0
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate) { }

	// RVA: 0x2DE5920 Offset: 0x2DE4320 VA: 0x182DE5920
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	// RVA: 0x2DE6300 Offset: 0x2DE4D00 VA: 0x182DE6300
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	// RVA: 0x2DE6810 Offset: 0x2DE5210 VA: 0x182DE6810
	private static void RemoveCachedPanelInternal(int instanceID) { }

	// RVA: 0x2DE6DA0 Offset: 0x2DE57A0 VA: 0x182DE6DA0
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x2DE6FA0 Offset: 0x2DE59A0 VA: 0x182DE6FA0
	public static void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	// RVA: 0x2DE5850 Offset: 0x2DE4250 VA: 0x182DE5850
	internal static void BeginRenderOverlays(int displayIndex) { }

	// RVA: 0x2DE6BD0 Offset: 0x2DE55D0 VA: 0x182DE6BD0
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	// RVA: 0x2DE5A40 Offset: 0x2DE4440 VA: 0x182DE5A40
	internal static void EndRenderOverlays(int displayIndex) { }

	[CompilerGenerated]
	// RVA: 0x2DE7FE0 Offset: 0x2DE69E0 VA: 0x182DE7FE0
	internal static Object get_activeEventSystem() { }

	[CompilerGenerated]
	// RVA: 0x2DE82C0 Offset: 0x2DE6CC0 VA: 0x182DE82C0
	private static void set_activeEventSystem(Object value) { }

	// RVA: 0x2DE8100 Offset: 0x2DE6B00 VA: 0x182DE8100
	internal static bool get_useDefaultEventSystem() { }

	// RVA: 0x2DE6520 Offset: 0x2DE4F20 VA: 0x182DE6520
	public static void RegisterEventSystem(Object eventSystem) { }

	// RVA: 0x2DE7550 Offset: 0x2DE5F50 VA: 0x182DE7550
	public static void UnregisterEventSystem(Object eventSystem) { }

	// RVA: 0x2DE8030 Offset: 0x2DE6A30 VA: 0x182DE8030
	internal static DefaultEventSystem get_defaultEventSystem() { }

	// RVA: 0x2DE76F0 Offset: 0x2DE60F0 VA: 0x182DE76F0
	public static void UpdateRuntimePanels() { }

	// RVA: 0x2DE5D70 Offset: 0x2DE4770 VA: 0x182DE5D70
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	// RVA: 0x2DE6A00 Offset: 0x2DE5400 VA: 0x182DE6A00
	internal static void RemoveUnusedPanels() { }

	// RVA: 0x2DE6770 Offset: 0x2DE5170 VA: 0x182DE6770
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x2DE7690 Offset: 0x2DE6090 VA: 0x182DE7690
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x2DE7200 Offset: 0x2DE5C00 VA: 0x182DE7200
	internal static void SetPanelOrderingDirty() { }

	// RVA: 0x2DE5CD0 Offset: 0x2DE46D0 VA: 0x182DE5CD0
	internal static List<Panel> GetSortedPlayerPanels() { }

	// RVA: 0x2DE7250 Offset: 0x2DE5C50 VA: 0x182DE7250
	private static void SortPanels() { }

	// RVA: 0x2DE5EA0 Offset: 0x2DE48A0 VA: 0x182DE5EA0
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x2DE6150 Offset: 0x2DE4B50 VA: 0x182DE6150
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x2DE7120 Offset: 0x2DE5B20 VA: 0x182DE7120
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x2DE7100 Offset: 0x2DE5B00 VA: 0x182DE7100
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }
}
