internal class XplatUI // TypeDefIndex: 5812
{
	// Fields
	private static XplatUIDriver driver; // 0x0
	private static string default_class_name; // 0x8
	internal static ArrayList key_filters; // 0x10

	// Properties
	public static bool RunningOnUnix { get; }
	internal static string DefaultClassName { get; }
	public static Size Border3DSize { get; }
	public static Size BorderSize { get; }
	public static Size CaptionButtonSize { get; }
	public static int CaptionHeight { get; }
	public static int DoubleClickTime { get; }
	public static Size DragSize { get; }
	public static Size FrameBorderSize { get; }
	public static int HorizontalScrollBarHeight { get; }
	public static bool MenuAccessKeysUnderlined { get; }
	public static Size MenuButtonSize { get; }
	public static Size MinimizedWindowSize { get; }
	public static Size MinimumWindowSize { get; }
	public static Size MinimumFixedToolWindowSize { get; }
	public static Size MinimumSizeableToolWindowSize { get; }
	public static Size MinimumNoBorderWindowSize { get; }
	public static Size MinWindowTrackSize { get; }
	public static int MenuHeight { get; }
	public static bool RequiresPositiveClientAreaSize { get; }
	public static bool UserClipWontExposeParent { get; }
	public static int VerticalScrollBarWidth { get; }
	public static Rectangle VirtualScreen { get; }
	public static Rectangle WorkingArea { get; }
	public static bool ThemesEnabled { get; }
	public static int ToolWindowCaptionHeight { get; }
	public static Size ToolWindowCaptionButtonSize { get; }

	// Methods

	// RVA: 0x228FFB0 Offset: 0x228E9B0 VA: 0x18228FFB0
	private static void .cctor() { }

	// RVA: 0x2290B70 Offset: 0x228F570 VA: 0x182290B70
	public static bool get_RunningOnUnix() { }

	// RVA: 0x2290500 Offset: 0x228EF00 VA: 0x182290500
	internal static string get_DefaultClassName() { }

	// RVA: 0x2290340 Offset: 0x228ED40 VA: 0x182290340
	public static Size get_Border3DSize() { }

	// RVA: 0x22903B0 Offset: 0x228EDB0 VA: 0x1822903B0
	public static Size get_BorderSize() { }

	// RVA: 0x2290420 Offset: 0x228EE20 VA: 0x182290420
	public static Size get_CaptionButtonSize() { }

	// RVA: 0x2290490 Offset: 0x228EE90 VA: 0x182290490
	public static int get_CaptionHeight() { }

	// RVA: 0x2290550 Offset: 0x228EF50 VA: 0x182290550
	public static int get_DoubleClickTime() { }

	// RVA: 0x22905C0 Offset: 0x228EFC0 VA: 0x1822905C0
	public static Size get_DragSize() { }

	// RVA: 0x2290630 Offset: 0x228F030 VA: 0x182290630
	public static Size get_FrameBorderSize() { }

	// RVA: 0x22906A0 Offset: 0x228F0A0 VA: 0x1822906A0
	public static int get_HorizontalScrollBarHeight() { }

	// RVA: 0x2290710 Offset: 0x228F110 VA: 0x182290710
	public static bool get_MenuAccessKeysUnderlined() { }

	// RVA: 0x2290780 Offset: 0x228F180 VA: 0x182290780
	public static Size get_MenuButtonSize() { }

	// RVA: 0x22908D0 Offset: 0x228F2D0 VA: 0x1822908D0
	public static Size get_MinimizedWindowSize() { }

	// RVA: 0x2290A90 Offset: 0x228F490 VA: 0x182290A90
	public static Size get_MinimumWindowSize() { }

	// RVA: 0x2290940 Offset: 0x228F340 VA: 0x182290940
	public static Size get_MinimumFixedToolWindowSize() { }

	// RVA: 0x2290A20 Offset: 0x228F420 VA: 0x182290A20
	public static Size get_MinimumSizeableToolWindowSize() { }

	// RVA: 0x22909B0 Offset: 0x228F3B0 VA: 0x1822909B0
	public static Size get_MinimumNoBorderWindowSize() { }

	// RVA: 0x2290860 Offset: 0x228F260 VA: 0x182290860
	public static Size get_MinWindowTrackSize() { }

	// RVA: 0x22907F0 Offset: 0x228F1F0 VA: 0x1822907F0
	public static int get_MenuHeight() { }

	// RVA: 0x2290B00 Offset: 0x228F500 VA: 0x182290B00
	public static bool get_RequiresPositiveClientAreaSize() { }

	// RVA: 0x2290D00 Offset: 0x228F700 VA: 0x182290D00
	public static bool get_UserClipWontExposeParent() { }

	// RVA: 0x2290D70 Offset: 0x228F770 VA: 0x182290D70
	public static int get_VerticalScrollBarWidth() { }

	// RVA: 0x2290DE0 Offset: 0x228F7E0 VA: 0x182290DE0
	public static Rectangle get_VirtualScreen() { }

	// RVA: 0x2290E60 Offset: 0x228F860 VA: 0x182290E60
	public static Rectangle get_WorkingArea() { }

	// RVA: 0x2290BB0 Offset: 0x228F5B0 VA: 0x182290BB0
	public static bool get_ThemesEnabled() { }

	// RVA: 0x2290C90 Offset: 0x228F690 VA: 0x182290C90
	public static int get_ToolWindowCaptionHeight() { }

	// RVA: 0x2290C20 Offset: 0x228F620 VA: 0x182290C20
	public static Size get_ToolWindowCaptionButtonSize() { }

	// RVA: 0x228CB20 Offset: 0x228B520 VA: 0x18228CB20
	internal static void Activate(IntPtr handle) { }

	// RVA: 0x228CBA0 Offset: 0x228B5A0 VA: 0x18228CBA0
	internal static void AudibleAlert(AlertType alert) { }

	// RVA: 0x228CCF0 Offset: 0x228B6F0 VA: 0x18228CCF0
	internal static bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect) { }

	// RVA: 0x228CDA0 Offset: 0x228B7A0 VA: 0x18228CDA0
	internal static void CaretVisible(IntPtr handle, bool visible) { }

	// RVA: 0x228D230 Offset: 0x228BC30 VA: 0x18228D230
	internal static void CreateCaret(IntPtr handle, int width, int height) { }

	// RVA: 0x228D380 Offset: 0x228BD80 VA: 0x18228D380
	internal static IntPtr CreateWindow(CreateParams cp) { }

	// RVA: 0x228CE30 Offset: 0x228B830 VA: 0x18228CE30
	internal static void ClientToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x228CED0 Offset: 0x228B8D0 VA: 0x18228CED0
	internal static int[] ClipboardAvailableFormats(IntPtr handle) { }

	// RVA: 0x228CF50 Offset: 0x228B950 VA: 0x18228CF50
	internal static void ClipboardClose(IntPtr handle) { }

	// RVA: 0x228CFD0 Offset: 0x228B9D0 VA: 0x18228CFD0
	internal static int ClipboardGetID(IntPtr handle, string format) { }

	// RVA: 0x228D060 Offset: 0x228BA60 VA: 0x18228D060
	internal static IntPtr ClipboardOpen(bool primary_selection) { }

	// RVA: 0x228D180 Offset: 0x228BB80 VA: 0x18228D180
	internal static void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter) { }

	// RVA: 0x228D0E0 Offset: 0x228BAE0 VA: 0x18228D0E0
	internal static object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter) { }

	// RVA: 0x228D480 Offset: 0x228BE80 VA: 0x18228D480
	internal static IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot) { }

	// RVA: 0x228D580 Offset: 0x228BF80 VA: 0x18228D580
	internal static IntPtr DefineStdCursor(StdCursor id) { }

	// RVA: 0x228D400 Offset: 0x228BE00 VA: 0x18228D400
	internal static IntPtr DefWndProc(ref Message msg) { }

	// RVA: 0x228D600 Offset: 0x228C000 VA: 0x18228D600
	internal static void DestroyCaret(IntPtr handle) { }

	// RVA: 0x228D700 Offset: 0x228C100 VA: 0x18228D700
	internal static void DestroyWindow(IntPtr handle) { }

	// RVA: 0x228D780 Offset: 0x228C180 VA: 0x18228D780
	internal static IntPtr DispatchMessage(ref MSG msg) { }

	// RVA: 0x228D800 Offset: 0x228C200 VA: 0x18228D800
	internal static void DoEvents() { }

	// RVA: 0x228D870 Offset: 0x228C270 VA: 0x18228D870
	internal static void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width) { }

	// RVA: 0x228D920 Offset: 0x228C320 VA: 0x18228D920
	internal static void EnableWindow(IntPtr handle, bool Enable) { }

	// RVA: 0x228D9B0 Offset: 0x228C3B0 VA: 0x18228D9B0
	internal static void EndLoop(Thread thread) { }

	// RVA: 0x228DCB0 Offset: 0x228C6B0 VA: 0x18228DCB0
	internal static IntPtr GetActive() { }

	// RVA: 0x228DD20 Offset: 0x228C720 VA: 0x18228DD20
	internal static SizeF GetAutoScaleSize(Font font) { }

	// RVA: 0x228DDA0 Offset: 0x228C7A0 VA: 0x18228DDA0
	internal static void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y) { }

	// RVA: 0x228DE60 Offset: 0x228C860 VA: 0x18228DE60
	internal static void GetCursorPos(IntPtr handle, out int x, out int y) { }

	// RVA: 0x228DF00 Offset: 0x228C900 VA: 0x18228DF00
	internal static void GetDisplaySize(out Size size) { }

	// RVA: 0x228DF80 Offset: 0x228C980 VA: 0x18228DF80
	internal static IntPtr GetFocus() { }

	// RVA: 0x228DFF0 Offset: 0x228C9F0 VA: 0x18228DFF0
	internal static bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent) { }

	// RVA: 0x228E0A0 Offset: 0x228CAA0 VA: 0x18228E0A0
	internal static Point GetMenuOrigin(IntPtr handle) { }

	// RVA: 0x228E120 Offset: 0x228CB20 VA: 0x18228E120
	internal static bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax) { }

	// RVA: 0x228E260 Offset: 0x228CC60 VA: 0x18228E260
	internal static IntPtr GetParent(IntPtr handle) { }

	// RVA: 0x228E2E0 Offset: 0x228CCE0 VA: 0x18228E2E0
	internal static IntPtr GetPreviousWindow(IntPtr handle) { }

	// RVA: 0x228E360 Offset: 0x228CD60 VA: 0x18228E360
	internal static void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height) { }

	// RVA: 0x228E450 Offset: 0x228CE50 VA: 0x18228E450
	internal static FormWindowState GetWindowState(IntPtr handle) { }

	// RVA: 0x228E4D0 Offset: 0x228CED0 VA: 0x18228E4D0
	internal static void GrabInfo(out IntPtr handle, out bool GrabConfined, out Rectangle GrabArea) { }

	// RVA: 0x228E570 Offset: 0x228CF70 VA: 0x18228E570
	internal static void GrabWindow(IntPtr handle, IntPtr ConfineToHwnd) { }

	// RVA: 0x228E680 Offset: 0x228D080 VA: 0x18228E680
	internal static void Invalidate(IntPtr handle, Rectangle rc, bool clear) { }

	// RVA: 0x228E600 Offset: 0x228D000 VA: 0x18228E600
	internal static void InvalidateNC(IntPtr handle) { }

	// RVA: 0x228E730 Offset: 0x228D130 VA: 0x18228E730
	internal static bool IsEnabled(IntPtr handle) { }

	// RVA: 0x228E7B0 Offset: 0x228D1B0 VA: 0x18228E7B0
	internal static void KillTimer(Timer timer) { }

	// RVA: 0x228E830 Offset: 0x228D230 VA: 0x18228E830
	internal static void PaintEventEnd(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x228E8D0 Offset: 0x228D2D0 VA: 0x18228E8D0
	internal static PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x228E970 Offset: 0x228D370 VA: 0x18228E970
	internal static bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x228EA20 Offset: 0x228D420 VA: 0x18228EA20
	internal static void PostQuitMessage(int exitCode) { }

	// RVA: 0x228EAA0 Offset: 0x228D4A0 VA: 0x18228EAA0
	internal static void RequestAdditionalWM_NCMessages(IntPtr handle, bool hover, bool leave) { }

	// RVA: 0x228EB40 Offset: 0x228D540 VA: 0x18228EB40
	internal static void RequestNCRecalc(IntPtr handle) { }

	// RVA: 0x228EBC0 Offset: 0x228D5C0 VA: 0x18228EBC0
	internal static void ResetMouseHover(IntPtr handle) { }

	// RVA: 0x228EC40 Offset: 0x228D640 VA: 0x18228EC40
	internal static void ScreenToClient(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x228ECE0 Offset: 0x228D6E0 VA: 0x18228ECE0
	internal static void ScreenToMenu(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x228ED80 Offset: 0x228D780 VA: 0x18228ED80
	internal static void ScrollWindow(IntPtr handle, Rectangle rectangle, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x228EE50 Offset: 0x228D850 VA: 0x18228EE50
	internal static void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x228EF00 Offset: 0x228D900 VA: 0x18228EF00
	internal static void SendAsyncMethod(AsyncMethodData data) { }

	// RVA: 0x228EF80 Offset: 0x228D980 VA: 0x18228EF80
	internal static IntPtr SendMessage(IntPtr handle, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x228F030 Offset: 0x228DA30 VA: 0x18228F030
	internal static void SetAllowDrop(IntPtr handle, bool value) { }

	// RVA: 0x228F0C0 Offset: 0x228DAC0 VA: 0x18228F0C0
	internal static void SetBorderStyle(IntPtr handle, FormBorderStyle border_style) { }

	// RVA: 0x228F150 Offset: 0x228DB50 VA: 0x18228F150
	internal static void SetCaretPos(IntPtr handle, int x, int y) { }

	// RVA: 0x228F1F0 Offset: 0x228DBF0 VA: 0x18228F1F0
	internal static void SetClipRegion(IntPtr handle, Region region) { }

	// RVA: 0x228F320 Offset: 0x228DD20 VA: 0x18228F320
	internal static void SetCursor(IntPtr handle, IntPtr cursor) { }

	// RVA: 0x228F280 Offset: 0x228DC80 VA: 0x18228F280
	internal static void SetCursorPos(IntPtr handle, int x, int y) { }

	// RVA: 0x228F3B0 Offset: 0x228DDB0 VA: 0x18228F3B0
	internal static void SetFocus(IntPtr handle) { }

	// RVA: 0x228F430 Offset: 0x228DE30 VA: 0x18228F430
	internal static void SetIcon(IntPtr handle, Icon icon) { }

	// RVA: 0x228F4C0 Offset: 0x228DEC0 VA: 0x18228F4C0
	internal static void SetMenu(IntPtr handle, Menu menu) { }

	// RVA: 0x228F550 Offset: 0x228DF50 VA: 0x18228F550
	internal static void SetModal(IntPtr handle, bool Modal) { }

	// RVA: 0x228F670 Offset: 0x228E070 VA: 0x18228F670
	internal static IntPtr SetParent(IntPtr handle, IntPtr hParent) { }

	// RVA: 0x228F700 Offset: 0x228E100 VA: 0x18228F700
	internal static void SetTimer(Timer timer) { }

	// RVA: 0x228F780 Offset: 0x228E180 VA: 0x18228F780
	internal static bool SetTopmost(IntPtr handle, bool Enabled) { }

	// RVA: 0x228F5E0 Offset: 0x228DFE0 VA: 0x18228F5E0
	internal static bool SetOwner(IntPtr handle, IntPtr hWndOwner) { }

	// RVA: 0x228F810 Offset: 0x228E210 VA: 0x18228F810
	internal static bool SetVisible(IntPtr handle, bool visible, bool activate) { }

	// RVA: 0x228F8B0 Offset: 0x228E2B0 VA: 0x18228F8B0
	internal static void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max) { }

	// RVA: 0x228F970 Offset: 0x228E370 VA: 0x18228F970
	internal static void SetWindowPos(IntPtr handle, int x, int y, int width, int height) { }

	// RVA: 0x228FA30 Offset: 0x228E430 VA: 0x18228FA30
	internal static void SetWindowState(IntPtr handle, FormWindowState state) { }

	// RVA: 0x228FAC0 Offset: 0x228E4C0 VA: 0x18228FAC0
	internal static void SetWindowStyle(IntPtr handle, CreateParams cp) { }

	// RVA: 0x228FB50 Offset: 0x228E550 VA: 0x18228FB50
	internal static void SetWindowTransparency(IntPtr handle, double transparency, Color key) { }

	// RVA: 0x228FC00 Offset: 0x228E600 VA: 0x18228FC00
	internal static bool SetZOrder(IntPtr handle, IntPtr AfterhWnd, bool Top, bool Bottom) { }

	// RVA: 0x228FCB0 Offset: 0x228E6B0 VA: 0x18228FCB0
	internal static object StartLoop(Thread thread) { }

	// RVA: 0x228FD30 Offset: 0x228E730 VA: 0x18228FD30
	internal static TransparencySupport SupportsTransparency() { }

	// RVA: 0x228FDA0 Offset: 0x228E7A0 VA: 0x18228FDA0
	internal static bool Text(IntPtr handle, string text) { }

	// RVA: 0x228FE30 Offset: 0x228E830 VA: 0x18228FE30
	internal static bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x228FEB0 Offset: 0x228E8B0 VA: 0x18228FEB0
	internal static void UngrabWindow(IntPtr handle) { }

	// RVA: 0x228FF30 Offset: 0x228E930 VA: 0x18228FF30
	internal static void UpdateWindow(IntPtr handle) { }

	// RVA: 0x228D2D0 Offset: 0x228BCD0 VA: 0x18228D2D0
	internal static void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable) { }

	// RVA: 0x228D680 Offset: 0x228C080 VA: 0x18228D680
	internal static void DestroyOffscreenDrawable(object offscreen_drawable) { }

	// RVA: 0x228E1E0 Offset: 0x228CBE0 VA: 0x18228E1E0
	internal static Graphics GetOffscreenGraphics(object offscreen_drawable) { }

	// RVA: 0x228CC20 Offset: 0x228B620 VA: 0x18228CC20
	internal static void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r) { }

	// RVA: 0x228DA30 Offset: 0x228C430 VA: 0x18228DA30
	internal static bool FilterKey(KeyFilterData key) { }

	// RVA: 0x2290EE0 Offset: 0x228F8E0 VA: 0x182290EE0
	private static extern int uname(IntPtr buf) { }
}
