public class GUIUtility // TypeDefIndex: 17610
{
	// Fields
	internal static int s_ControlCount; // 0x0
	internal static int s_SkinMode; // 0x4
	internal static int s_OriginalID; // 0x8
	internal static Action takeCapture; // 0x10
	internal static Action releaseCapture; // 0x18
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	internal static Action cleanupRoots; // 0x28
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x30
	internal static Action guiChanged; // 0x38
	internal static Action<EventType, KeyCode> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Properties
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, 1)]
	internal static bool mouseUsed { set; }
	[StaticAccessor("GetInputManager()", 0)]
	internal static bool textFieldInput { get; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static string compositionString { get; }
	[StaticAccessor("InputBindings", 2)]
	internal static IMECompositionMode imeCompositionMode { set; }
	[StaticAccessor("InputBindings", 2)]
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { get; set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	// RVA: 0x2D130C0 Offset: 0x2D11AC0 VA: 0x182D130C0
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x2D12F80 Offset: 0x2D11980 VA: 0x182D12F80
	internal static int get_guiDepth() { }

	// RVA: 0x2D13380 Offset: 0x2D11D80 VA: 0x182D13380
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x2D13120 Offset: 0x2D11B20 VA: 0x182D13120
	internal static bool get_textFieldInput() { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x2D130F0 Offset: 0x2D11AF0 VA: 0x182D130F0
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x2D133C0 Offset: 0x2D11DC0 VA: 0x182D133C0
	public static void set_systemCopyBuffer(string value) { }

	[FreeFunction("GetGUIState().GetControlID")]
	// RVA: 0x2D125A0 Offset: 0x2D10FA0 VA: 0x182D125A0
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x2D11DE0 Offset: 0x2D107E0 VA: 0x182D11DE0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x2D11340 Offset: 0x2D0FD40 VA: 0x182D11340
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x2D11380 Offset: 0x2D0FD80 VA: 0x182D11380
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethod("EndContainer")]
	// RVA: 0x2D124F0 Offset: 0x2D10EF0 VA: 0x182D124F0
	internal static void Internal_EndContainer() { }

	// RVA: 0x2D115F0 Offset: 0x2D0FFF0 VA: 0x182D115F0
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x2D12D10 Offset: 0x2D11710 VA: 0x182D12D10
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x2D12D40 Offset: 0x2D11740 VA: 0x182D12D40
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x2D120E0 Offset: 0x2D10AE0 VA: 0x182D120E0
	internal static bool HasFocusableControls() { }

	// RVA: 0x2D12830 Offset: 0x2D11230 VA: 0x182D12830
	internal static bool OwnsId(int id) { }

	// RVA: 0x2D111C0 Offset: 0x2D0FBC0 VA: 0x182D111C0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	// RVA: 0x2D12F50 Offset: 0x2D11950 VA: 0x182D12F50
	internal static string get_compositionString() { }

	// RVA: 0x2D132D0 Offset: 0x2D11CD0 VA: 0x182D132D0
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2D13190 Offset: 0x2D11B90 VA: 0x182D13190
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x2D12660 Offset: 0x2D11060 VA: 0x182D12660
	private static int Internal_GetHotControl() { }

	// RVA: 0x2D12690 Offset: 0x2D11090 VA: 0x182D12690
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x2D126C0 Offset: 0x2D110C0 VA: 0x182D126C0
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x2D12700 Offset: 0x2D11100 VA: 0x182D12700
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x2D12620 Offset: 0x2D11020 VA: 0x182D12620
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x2D12520 Offset: 0x2D10F20 VA: 0x182D12520
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCode]
	// RVA: 0x2D127C0 Offset: 0x2D111C0 VA: 0x182D127C0
	private static void MarkGUIChanged() { }

	// RVA: 0x2D11D60 Offset: 0x2D10760 VA: 0x182D11D60
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x2D11F50 Offset: 0x2D10950 VA: 0x182D11F50
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGenerated]
	// RVA: 0x2D12FB0 Offset: 0x2D119B0 VA: 0x182D12FB0
	internal static bool get_guiIsExiting() { }

	[CompilerGenerated]
	// RVA: 0x2D13200 Offset: 0x2D11C00 VA: 0x182D13200
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x2D13000 Offset: 0x2D11A00 VA: 0x182D13000
	public static int get_hotControl() { }

	// RVA: 0x2D13260 Offset: 0x2D11C60 VA: 0x182D13260
	public static void set_hotControl(int value) { }

	[RequiredByNativeCode]
	// RVA: 0x2D12E20 Offset: 0x2D11820 VA: 0x182D12E20
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x2D12A60 Offset: 0x2D11460 VA: 0x182D12A60
	internal static void RemoveCapture() { }

	// RVA: 0x2D13060 Offset: 0x2D11A60 VA: 0x182D13060
	public static int get_keyboardControl() { }

	// RVA: 0x2D13310 Offset: 0x2D11D10 VA: 0x182D13310
	public static void set_keyboardControl(int value) { }

	// RVA: 0x2D12110 Offset: 0x2D10B10 VA: 0x182D12110
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x2D11D20 Offset: 0x2D10720 VA: 0x182D11D20
	public static void ExitGUI() { }

	// RVA: 0x2D11EB0 Offset: 0x2D108B0 VA: 0x182D11EB0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCode]
	// RVA: 0x2D12870 Offset: 0x2D11270 VA: 0x182D12870
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	// RVA: 0x2D11870 Offset: 0x2D10270 VA: 0x182D11870
	internal static void EndContainer() { }

	[RequiredByNativeCode]
	// RVA: 0x2D113C0 Offset: 0x2D0FDC0 VA: 0x182D113C0
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x2D116F0 Offset: 0x2D100F0 VA: 0x182D116F0
	internal static void DestroyGUI(int instanceID) { }

	[RequiredByNativeCode]
	// RVA: 0x2D119F0 Offset: 0x2D103F0 VA: 0x182D119F0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x2D118F0 Offset: 0x2D102F0 VA: 0x182D118F0
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x2D117D0 Offset: 0x2D101D0 VA: 0x182D117D0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x2D12AD0 Offset: 0x2D114D0 VA: 0x182D12AD0
	internal static void ResetGlobalState() { }

	// RVA: 0x2D12740 Offset: 0x2D11140 VA: 0x182D12740
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x2D12D70 Offset: 0x2D11770 VA: 0x182D12D70
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x2D11630 Offset: 0x2D10030 VA: 0x182D11630
	internal static void CheckOnGUI() { }

	// RVA: 0x2D12C60 Offset: 0x2D11660 VA: 0x182D12C60
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x2D11260 Offset: 0x2D0FC60 VA: 0x182D11260
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x2D123B0 Offset: 0x2D10DB0 VA: 0x182D123B0
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x2D12430 Offset: 0x2D10E30 VA: 0x182D12430
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x2D12230 Offset: 0x2D10C30 VA: 0x182D12230
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x2D12E90 Offset: 0x2D11890 VA: 0x182D12E90
	private static void .cctor() { }

	// RVA: 0x2D12550 Offset: 0x2D10F50 VA: 0x182D12550
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x2D11150 Offset: 0x2D0FB50 VA: 0x182D11150
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x2D13150 Offset: 0x2D11B50 VA: 0x182D13150
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }
}
