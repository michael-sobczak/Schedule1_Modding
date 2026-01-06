public class Input // TypeDefIndex: 19018
{
	// Properties
	[NativeThrows]
	public static bool anyKey { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x2D28EA0 Offset: 0x2D278A0 VA: 0x182D28EA0
	public static float GetAxis(string axisName) { }

	// RVA: 0x2D28E20 Offset: 0x2D27820 VA: 0x182D28E20
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x2D28FE0 Offset: 0x2D279E0 VA: 0x182D28FE0
	public static bool GetButton(string buttonName) { }

	// RVA: 0x2D28F20 Offset: 0x2D27920 VA: 0x182D28F20
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x2D291C0 Offset: 0x2D27BC0 VA: 0x182D291C0
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x2D29200 Offset: 0x2D27C00 VA: 0x182D29200
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x2D29180 Offset: 0x2D27B80 VA: 0x182D29180
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x2D29350 Offset: 0x2D27D50 VA: 0x182D29350
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x2D292D0 Offset: 0x2D27CD0 VA: 0x182D292D0
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x2D29310 Offset: 0x2D27D10 VA: 0x182D29310
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x2D293D0 Offset: 0x2D27DD0 VA: 0x182D293D0
	public static Touch GetTouch(int index) { }

	[NativeThrows]
	// RVA: 0x2D29280 Offset: 0x2D27C80 VA: 0x182D29280
	public static PenData GetLastPenContactEvent() { }

	[NativeThrows]
	// RVA: 0x2D29150 Offset: 0x2D27B50 VA: 0x182D29150
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x2D291C0 Offset: 0x2D27BC0 VA: 0x182D291C0
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x2D29200 Offset: 0x2D27C00 VA: 0x182D29200
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x2D29180 Offset: 0x2D27B80 VA: 0x182D29180
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2D29060 Offset: 0x2D27A60 VA: 0x182D29060
	public static bool GetKeyDown(string name) { }

	// RVA: 0x2D29430 Offset: 0x2D27E30 VA: 0x182D29430
	public static bool get_anyKey() { }

	// RVA: 0x2D29580 Offset: 0x2D27F80 VA: 0x182D29580
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2D29630 Offset: 0x2D28030 VA: 0x182D29630
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2D29510 Offset: 0x2D27F10 VA: 0x182D29510
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x2D298A0 Offset: 0x2D282A0 VA: 0x182D298A0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2D294E0 Offset: 0x2D27EE0 VA: 0x182D294E0
	public static string get_compositionString() { }

	// RVA: 0x2D294A0 Offset: 0x2D27EA0 VA: 0x182D294A0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2D29860 Offset: 0x2D28260 VA: 0x182D29860
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x2D295C0 Offset: 0x2D27FC0 VA: 0x182D295C0
	public static bool get_mousePresent() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x2D29670 Offset: 0x2D28070 VA: 0x182D29670
	public static int get_touchCount() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x2D296A0 Offset: 0x2D280A0 VA: 0x182D296A0
	public static bool get_touchSupported() { }

	// RVA: 0x2D296D0 Offset: 0x2D280D0 VA: 0x182D296D0
	public static Touch[] get_touches() { }

	// RVA: 0x2D29120 Offset: 0x2D27B20 VA: 0x182D29120
	internal static bool CheckDisabled() { }

	// RVA: 0x2D29390 Offset: 0x2D27D90 VA: 0x182D29390
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2D29240 Offset: 0x2D27C40 VA: 0x182D29240
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x2D29540 Offset: 0x2D27F40 VA: 0x182D29540
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2D295F0 Offset: 0x2D27FF0 VA: 0x182D295F0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2D29460 Offset: 0x2D27E60 VA: 0x182D29460
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2D29820 Offset: 0x2D28220 VA: 0x182D29820
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }
}
