public class GUILayoutUtility // TypeDefIndex: 17601
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <unbalancedgroupscount>k__BackingField; // 0x28
	private static GUIStyle s_SpaceStyle; // 0x30

	// Properties
	internal static int unbalancedgroupscount { get; set; }
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x2D08A30 Offset: 0x2D07430 VA: 0x182D08A30
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x2D08AF0 Offset: 0x2D074F0 VA: 0x182D08AF0
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[CompilerGenerated]
	// RVA: 0x2D09C60 Offset: 0x2D08660 VA: 0x182D09C60
	internal static int get_unbalancedgroupscount() { }

	[CompilerGenerated]
	// RVA: 0x2D09CB0 Offset: 0x2D086B0 VA: 0x182D09CB0
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x2D087E0 Offset: 0x2D071E0 VA: 0x182D087E0
	internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x2D097A0 Offset: 0x2D081A0 VA: 0x182D097A0
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x2D096C0 Offset: 0x2D080C0 VA: 0x182D096C0
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x2D07800 Offset: 0x2D06200 VA: 0x182D07800
	internal static void Begin(int instanceID) { }

	// RVA: 0x2D06AE0 Offset: 0x2D054E0 VA: 0x182D06AE0
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x2D07440 Offset: 0x2D05E40 VA: 0x182D07440
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D09400 Offset: 0x2D07E00 VA: 0x182D09400
	internal static void Layout() { }

	// RVA: 0x2D08F10 Offset: 0x2D07910 VA: 0x182D08F10
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x2D08D20 Offset: 0x2D07720 VA: 0x182D08D20
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x2D08B70 Offset: 0x2D07570 VA: 0x182D08B70
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x2D09180 Offset: 0x2D07B80 VA: 0x182D09180
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x2D07AB0 Offset: 0x2D064B0 VA: 0x182D07AB0
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x2D07060 Offset: 0x2D05A60 VA: 0x182D07060
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x2D08480 Offset: 0x2D06E80 VA: 0x182D08480
	internal static void EndLayoutGroup() { }

	// RVA: 0x2D06CC0 Offset: 0x2D056C0 VA: 0x182D06CC0
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x2D082A0 Offset: 0x2D06CA0 VA: 0x182D082A0
	internal static void EndLayoutArea() { }

	// RVA: 0x2D08950 Offset: 0x2D07350 VA: 0x182D08950
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D07E30 Offset: 0x2D06830 VA: 0x182D07E30
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D088A0 Offset: 0x2D072A0 VA: 0x182D088A0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D07BF0 Offset: 0x2D065F0 VA: 0x182D07BF0
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D09B30 Offset: 0x2D08530 VA: 0x182D09B30
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x2D099F0 Offset: 0x2D083F0 VA: 0x182D099F0
	private static void .cctor() { }

	// RVA: 0x2D089F0 Offset: 0x2D073F0 VA: 0x182D089F0
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x2D08AB0 Offset: 0x2D074B0 VA: 0x182D08AB0
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}
