internal class UIElementsUtility : IUIElementsUtility // TypeDefIndex: 6932
{
	// Fields
	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static float singleLineHeight; // 0x28
	private static UIElementsUtility s_Instance; // 0x30
	internal static List<Panel> s_PanelsIterationList; // 0x38
	internal static readonly string s_RepaintProfilerMarkerName; // 0x40
	internal static readonly string s_EventProfilerMarkerName; // 0x48
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x50
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x58
	internal static char[] s_Modifiers; // 0x60

	// Methods

	// RVA: 0x2DEA060 Offset: 0x2DE8A60 VA: 0x182DEA060
	private void .ctor() { }

	// RVA: 0x2DE9970 Offset: 0x2DE8370 VA: 0x182DE9970 Slot: 9
	private bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x2DE9B80 Offset: 0x2DE8580 VA: 0x182DE9B80 Slot: 4
	private bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

	// RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510 Slot: 5
	private bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	// RVA: 0x2DE9A30 Offset: 0x2DE8430 VA: 0x182DE9A30 Slot: 6
	private bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	// RVA: 0x2DE97C0 Offset: 0x2DE81C0 VA: 0x182DE97C0 Slot: 7
	private bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	// RVA: 0x2DE9890 Offset: 0x2DE8290 VA: 0x182DE9890 Slot: 8
	private bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x2DE9620 Offset: 0x2DE8020 VA: 0x182DE9620
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	// RVA: 0x2DE96B0 Offset: 0x2DE80B0 VA: 0x182DE96B0
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x2DE9730 Offset: 0x2DE8130 VA: 0x182DE9730
	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	// RVA: 0x2DE8330 Offset: 0x2DE6D30 VA: 0x182DE8330
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x2DE8F90 Offset: 0x2DE7990 VA: 0x182DE8F90
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x2DE8590 Offset: 0x2DE6F90 VA: 0x182DE8590
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x2DE8600 Offset: 0x2DE7000 VA: 0x182DE8600
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x2DE89B0 Offset: 0x2DE73B0 VA: 0x182DE89B0
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x2DE91D0 Offset: 0x2DE7BD0 VA: 0x182DE91D0
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0x2DE9350 Offset: 0x2DE7D50 VA: 0x182DE9350
	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }

	// RVA: 0x2DE9550 Offset: 0x2DE7F50 VA: 0x182DE9550
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	// RVA: 0x2DE9400 Offset: 0x2DE7E00 VA: 0x182DE9400
	internal static string ParseMenuName(string menuName) { }

	// RVA: 0x2DE9C40 Offset: 0x2DE8640 VA: 0x182DE9C40
	private static void .cctor() { }
}
