internal class X11Keyboard : IDisposable // TypeDefIndex: 5727
{
	// Fields
	internal static object XlibLock; // 0x0
	private IntPtr display; // 0x10
	private IntPtr client_window; // 0x18
	private IntPtr xim; // 0x20
	private Hashtable xic_table; // 0x28
	private X11Keyboard.XIMPositionContext positionContext; // 0x30
	private X11Keyboard.XIMCallbackContext callbackContext; // 0x38
	private XIMProperties ximStyle; // 0x40
	private EventMask xic_event_mask; // 0x44
	private StringBuilder lookup_buffer; // 0x48
	private byte[] utf8_buffer; // 0x50
	private int min_keycode; // 0x58
	private int max_keycode; // 0x5C
	private int keysyms_per_keycode; // 0x60
	private int syms; // 0x64
	private int[] keyc2vkey; // 0x68
	private int[] keyc2scan; // 0x70
	private byte[] key_state_table; // 0x78
	private int lcid; // 0x80
	private bool num_state; // 0x84
	private bool cap_state; // 0x85
	private bool initialized; // 0x86
	private bool menu_state; // 0x87
	private int NumLockMask; // 0x88
	private int AltGrMask; // 0x8C
	private string stored_keyevent_string; // 0x90
	private static readonly int[] nonchar_key_vkey; // 0x8
	private static readonly int[] nonchar_key_scan; // 0x10
	private static readonly int[] nonchar_vkey_key; // 0x18
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$mapD; // 0x20

	// Properties
	public IntPtr ClientWindow { get; }
	public EventMask KeyEventMask { get; }
	public Keys ModifierKeys { get; }

	// Methods

	// RVA: 0x227C770 Offset: 0x227B170 VA: 0x18227C770
	public void .ctor(IntPtr display, IntPtr clientWindow) { }

	// RVA: 0x227C480 Offset: 0x227AE80 VA: 0x18227C480
	private static void .cctor() { }

	// RVA: 0x227A150 Offset: 0x2278B50 VA: 0x18227A150 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IntPtr get_ClientWindow() { }

	// RVA: 0x22768D0 Offset: 0x22752D0 VA: 0x1822768D0
	public void DestroyICForWindow(IntPtr window) { }

	// RVA: 0x22772A0 Offset: 0x2275CA0 VA: 0x1822772A0
	public void EnsureLayoutInitialized() { }

	// RVA: 0x2279D50 Offset: 0x2278750 VA: 0x182279D50
	private void SetupXIM() { }

	// RVA: 0x2276120 Offset: 0x2274B20 VA: 0x182276120
	private void CreateXicForWindow(IntPtr window) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public EventMask get_KeyEventMask() { }

	// RVA: 0x227C8B0 Offset: 0x227B2B0 VA: 0x18227C8B0
	public Keys get_ModifierKeys() { }

	// RVA: 0x2278400 Offset: 0x2276E00 VA: 0x182278400
	private IntPtr GetXic(IntPtr window) { }

	// RVA: 0x2277440 Offset: 0x2275E40 VA: 0x182277440
	private bool FilterKey(XEvent e, int vkey) { }

	// RVA: 0x2277620 Offset: 0x2276020 VA: 0x182277620
	public void FocusIn(IntPtr window) { }

	// RVA: 0x2277790 Offset: 0x2276190 VA: 0x182277790
	public void FocusOut(IntPtr window) { }

	// RVA: 0x2279940 Offset: 0x2278340 VA: 0x182279940
	public bool ResetKeyState(IntPtr hwnd, ref MSG msg) { }

	// RVA: 0x2279890 Offset: 0x2278290 VA: 0x182279890
	public void PreFilter(XEvent xevent) { }

	// RVA: 0x2278540 Offset: 0x2276F40 VA: 0x182278540
	public void KeyEvent(IntPtr hwnd, XEvent xevent, ref MSG msg) { }

	// RVA: 0x227AC10 Offset: 0x2279610 VA: 0x18227AC10
	public bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x227A4C0 Offset: 0x2278EC0 VA: 0x18227A4C0
	public int ToUnicode(int vkey, int scan, out string buffer) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal string GetCompositionString() { }

	// RVA: 0x22799B0 Offset: 0x22783B0 VA: 0x1822799B0
	private MSG SendImeComposition(string s) { }

	// RVA: 0x2279A20 Offset: 0x2278420 VA: 0x182279A20
	private MSG SendKeyboardInput(VirtualKeys vkey, int scan, int keycode, KeybdEventFlags dw_flags, int time) { }

	// RVA: 0x2277910 Offset: 0x2276310 VA: 0x182277910
	private IntPtr GenerateLParam(MSG m, int keyCode) { }

	// RVA: 0x2277A00 Offset: 0x2276400 VA: 0x182277A00
	private void GenerateMessage(VirtualKeys vkey, int scan, int key_code, XEventName type, int event_time) { }

	// RVA: 0x227AE90 Offset: 0x2279890 VA: 0x18227AE90
	private void UpdateKeyState(XEvent xevent) { }

	// RVA: 0x2279D30 Offset: 0x2278730 VA: 0x182279D30
	private void SetState(VirtualKeys key, bool state) { }

	// RVA: 0x2277340 Offset: 0x2275D40 VA: 0x182277340
	public int EventToVkey(XEvent e) { }

	// RVA: 0x2275640 Offset: 0x2274040 VA: 0x182275640
	private void CreateConversionArray(KeyboardLayouts layouts, KeyboardLayout layout) { }

	// RVA: 0x22769B0 Offset: 0x22753B0 VA: 0x1822769B0
	private KeyboardLayout DetectLayout(KeyboardLayouts layouts) { }

	// RVA: 0x22792A0 Offset: 0x2277CA0 VA: 0x1822792A0
	private int MapDeadKeySym(int val) { }

	// RVA: 0x2277FC0 Offset: 0x22769C0 VA: 0x182277FC0
	private XIMProperties[] GetSupportedInputStyles(IntPtr xim) { }

	// RVA: 0x2277C80 Offset: 0x2276680 VA: 0x182277C80
	private XIMProperties[] GetPreferredStyles() { }

	[DebuggerHidden]
	// RVA: 0x2277BF0 Offset: 0x22765F0 VA: 0x182277BF0
	private IEnumerable GetMatchingStylesInPreferredOrder(IntPtr xim) { }

	// RVA: 0x2276500 Offset: 0x2274F00 VA: 0x182276500
	private IntPtr CreateXic(IntPtr window, IntPtr xim) { }

	// RVA: 0x2275D30 Offset: 0x2274730 VA: 0x182275D30
	private IntPtr CreateOverTheSpotXic(IntPtr window, IntPtr xim) { }

	// RVA: 0x2275A90 Offset: 0x2274490 VA: 0x182275A90
	private IntPtr CreateOnTheSpotXic(IntPtr window, IntPtr xim) { }

	// RVA: 0x2279C40 Offset: 0x2278640 VA: 0x182279C40
	internal void SetCaretPos(CaretStruct caret, IntPtr handle, int x, int y) { }

	// RVA: 0x2279380 Offset: 0x2277D80 VA: 0x182279380
	internal void MoveCurrentCaretPos() { }

	// RVA: 0x2278DF0 Offset: 0x22777F0 VA: 0x182278DF0
	private int LookupString(ref XEvent xevent, int len, out XKeySym keysym, out IntPtr status) { }

	// RVA: 0x227BC30 Offset: 0x227A630 VA: 0x18227BC30
	private static extern IntPtr XOpenIM(IntPtr display, IntPtr rdb, IntPtr res_name, IntPtr res_class) { }

	// RVA: 0x227B130 Offset: 0x2279B30 VA: 0x18227B130
	private static extern IntPtr XCreateIC(IntPtr xim, string name, XIMProperties im_style, string name2, IntPtr value2, IntPtr terminator) { }

	// RVA: 0x227B230 Offset: 0x2279C30 VA: 0x18227B230
	private static extern IntPtr XCreateIC(IntPtr xim, string name, XIMProperties im_style, string name2, IntPtr value2, string name3, IntPtr value3, IntPtr terminator) { }

	// RVA: 0x227BFB0 Offset: 0x227A9B0 VA: 0x18227BFB0
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, XPoint value0, IntPtr terminator) { }

	// RVA: 0x227C060 Offset: 0x227AA60 VA: 0x18227C060
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, XPoint value0, IntPtr name1, IntPtr value1, IntPtr terminator) { }

	// RVA: 0x227C130 Offset: 0x227AB30 VA: 0x18227C130
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, IntPtr value0, IntPtr name1, IntPtr value1, IntPtr name2, IntPtr value2, IntPtr name3, IntPtr value3, IntPtr terminator) { }

	// RVA: 0x227B050 Offset: 0x2279A50 VA: 0x18227B050
	private static extern IntPtr XCreateFontSet(IntPtr display, string name, out IntPtr list, out int count, IntPtr terminator) { }

	// RVA: 0x227B500 Offset: 0x2279F00 VA: 0x18227B500
	private static extern void XFreeStringList(IntPtr ptr) { }

	// RVA: 0x227AFD0 Offset: 0x22799D0 VA: 0x18227AFD0
	private static extern void XCloseIM(IntPtr xim) { }

	// RVA: 0x227B360 Offset: 0x2279D60 VA: 0x18227B360
	private static extern void XDestroyIC(IntPtr xic) { }

	// RVA: 0x227B660 Offset: 0x227A060 VA: 0x18227B660
	private static extern string XGetIMValues(IntPtr xim, string name, out IntPtr value, IntPtr terminator) { }

	// RVA: 0x227B580 Offset: 0x2279F80 VA: 0x18227B580
	private static extern string XGetICValues(IntPtr xic, string name, out EventMask value, IntPtr terminator) { }

	// RVA: 0x227BD60 Offset: 0x227A760 VA: 0x18227BD60
	private static extern void XSetICValues(IntPtr xic, string name, IntPtr value, IntPtr terminator) { }

	// RVA: 0x227BCE0 Offset: 0x227A6E0 VA: 0x18227BCE0
	private static extern void XSetICFocus(IntPtr xic) { }

	// RVA: 0x227BF30 Offset: 0x227A930 VA: 0x18227BF30
	private static extern void XUnsetICFocus(IntPtr xic) { }

	// RVA: 0x227C3E0 Offset: 0x227ADE0 VA: 0x18227C3E0
	private static extern string Xutf8ResetIC(IntPtr xic) { }

	// RVA: 0x227BEC0 Offset: 0x227A8C0 VA: 0x18227BEC0
	private static extern bool XSupportsLocale() { }

	// RVA: 0x227BE20 Offset: 0x227A820 VA: 0x18227BE20
	private static extern bool XSetLocaleModifiers(string mods) { }

	// RVA: 0x227BA70 Offset: 0x227A470 VA: 0x18227BA70
	internal static extern int XLookupString(ref XEvent xevent, StringBuilder buffer, int num_bytes, out IntPtr keysym, IntPtr status) { }

	// RVA: 0x227C230 Offset: 0x227AC30 VA: 0x18227C230
	internal static extern int Xutf8LookupString(IntPtr xic, ref XEvent xevent, byte[] buffer, int num_bytes, out IntPtr keysym, out IntPtr status) { }

	// RVA: 0x227B740 Offset: 0x227A140 VA: 0x18227B740
	private static extern IntPtr XGetKeyboardMapping(IntPtr display, byte first_keycode, int keycode_count, out int keysyms_per_keycode_return) { }

	// RVA: 0x227B3E0 Offset: 0x2279DE0 VA: 0x18227B3E0
	private static extern void XDisplayKeycodes(IntPtr display, out int min, out int max) { }

	// RVA: 0x227B870 Offset: 0x227A270 VA: 0x18227B870
	private static extern uint XKeycodeToKeysym(IntPtr display, int keycode, int index) { }

	// RVA: 0x227B9E0 Offset: 0x227A3E0 VA: 0x18227B9E0
	private static extern int XKeysymToKeycode(IntPtr display, IntPtr keysym) { }

	// RVA: 0x227B910 Offset: 0x227A310 VA: 0x18227B910
	private static int XKeysymToKeycode(IntPtr display, int keysym) { }

	// RVA: 0x227B7F0 Offset: 0x227A1F0 VA: 0x18227B7F0
	internal static extern IntPtr XGetModifierMapping(IntPtr display) { }

	// RVA: 0x227B480 Offset: 0x2279E80 VA: 0x18227B480
	internal static extern int XFreeModifiermap(IntPtr modmap) { }
}
