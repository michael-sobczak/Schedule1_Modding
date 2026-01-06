internal class XplatUICarbon : XplatUIDriver // TypeDefIndex: 5813
{
	// Fields
	private static XplatUICarbon Instance; // 0x0
	private static int RefCount; // 0x8
	private static bool themes_enabled; // 0xC
	internal static IntPtr FocusWindow; // 0x10
	internal static IntPtr ActiveWindow; // 0x18
	internal static IntPtr ReverseWindow; // 0x20
	internal static IntPtr CaretWindow; // 0x28
	internal static Hwnd MouseHwnd; // 0x30
	internal static MouseButtons MouseState; // 0x38
	internal static Hover Hover; // 0x40
	internal static HwndDelegate HwndDelegate; // 0x60
	internal Point mouse_position; // 0x10
	internal ApplicationHandler ApplicationHandler; // 0x18
	internal ControlHandler ControlHandler; // 0x20
	internal HIObjectHandler HIObjectHandler; // 0x28
	internal KeyboardHandler KeyboardHandler; // 0x30
	internal MouseHandler MouseHandler; // 0x38
	internal WindowHandler WindowHandler; // 0x40
	internal static GrabStruct Grab; // 0x68
	internal static Caret Caret; // 0x88
	private static Dnd Dnd; // 0xB0
	private static Hashtable WindowMapping; // 0xB8
	private static Hashtable HandleMapping; // 0xC0
	private static IntPtr FosterParent; // 0xC8
	private static IntPtr Subclass; // 0xD0
	private static int MenuBarHeight; // 0xD8
	internal static ArrayList UtilityWindows; // 0xE0
	private static Queue MessageQueue; // 0xE8
	private static bool GetMessageResult; // 0xF0
	private static bool ReverseWindowMapped; // 0xF1
	private ArrayList TimerList; // 0x48
	private static bool in_doevents; // 0xF2
	private static readonly object instancelock; // 0xF8
	private static readonly object queuelock; // 0x100
	private EventHandler Idle; // 0x50

	// Properties
	internal override Point MousePosition { get; }
	internal override int CaptionHeight { get; }
	internal override Size DragSize { get; }
	internal override Size FrameBorderSize { get; }
	internal override bool MenuAccessKeysUnderlined { get; }
	internal override Size MinimumWindowSize { get; }
	internal override Keys ModifierKeys { get; }
	internal override Rectangle VirtualScreen { get; }
	internal override Rectangle WorkingArea { get; }
	internal override bool ThemesEnabled { get; }

	// Methods

	// RVA: 0x228C780 Offset: 0x228B180 VA: 0x18228C780
	private void .ctor() { }

	// RVA: 0x228C650 Offset: 0x228B050 VA: 0x18228C650
	private static void .cctor() { }

	// RVA: 0x1B60510 Offset: 0x1B5EF10 VA: 0x181B60510 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2283FA0 Offset: 0x22829A0 VA: 0x182283FA0
	public static XplatUICarbon GetInstance() { }

	// RVA: 0x227F0C0 Offset: 0x227DAC0 VA: 0x18227F0C0
	internal void AddExpose(Hwnd hwnd, bool client, HIRect rect) { }

	// RVA: 0x22835F0 Offset: 0x2281FF0 VA: 0x1822835F0
	internal void FlushQueue() { }

	// RVA: 0x22839D0 Offset: 0x22823D0 VA: 0x1822839D0
	internal static Rectangle[] GetClippingRectangles(IntPtr handle) { }

	// RVA: 0x2284930 Offset: 0x2283330 VA: 0x182284930
	internal IntPtr GetMousewParam(int Delta) { }

	// RVA: 0x2285AC0 Offset: 0x22844C0 VA: 0x182285AC0
	internal IntPtr HandleToWindow(IntPtr handle) { }

	// RVA: 0x2285FA0 Offset: 0x22849A0 VA: 0x182285FA0
	internal void Initialize() { }

	// RVA: 0x2287D50 Offset: 0x2286750 VA: 0x182287D50
	internal void PerformNCCalc(Hwnd hwnd) { }

	// RVA: 0x2288580 Offset: 0x2286F80 VA: 0x182288580
	internal void ScreenToClient(IntPtr handle, ref QDPoint point) { }

	// RVA: 0x228BC10 Offset: 0x228A610 VA: 0x18228BC10
	internal static Rectangle TranslateClientRectangleToQuartzClientRectangle(Hwnd hwnd) { }

	// RVA: 0x228BCD0 Offset: 0x228A6D0 VA: 0x18228BCD0
	internal static Rectangle TranslateClientRectangleToQuartzClientRectangle(Hwnd hwnd, Control ctrl) { }

	// RVA: 0x228C000 Offset: 0x228AA00 VA: 0x18228C000
	internal static Size TranslateWindowSizeToQuartzWindowSize(CreateParams cp) { }

	// RVA: 0x228C080 Offset: 0x228AA80 VA: 0x18228C080
	internal static Size TranslateWindowSizeToQuartzWindowSize(CreateParams cp, Size size) { }

	// RVA: 0x228BEB0 Offset: 0x228A8B0 VA: 0x18228BEB0
	internal static Size TranslateQuartzWindowSizeToWindowSize(CreateParams cp, int width, int height) { }

	// RVA: 0x227F9A0 Offset: 0x227E3A0 VA: 0x18227F9A0
	private void CaretCallback(object sender, EventArgs e) { }

	// RVA: 0x2285D40 Offset: 0x2284740 VA: 0x182285D40
	private void HoverCallback(object sender, EventArgs e) { }

	// RVA: 0x2280950 Offset: 0x227F350 VA: 0x182280950
	private Point ConvertScreenPointToClient(IntPtr handle, Point point) { }

	// RVA: 0x22807C0 Offset: 0x227F1C0 VA: 0x1822807C0
	private Point ConvertClientPointToScreen(IntPtr handle, Point point) { }

	// RVA: 0x2286FC0 Offset: 0x22859C0 VA: 0x182286FC0
	private double NextTimeout() { }

	// RVA: 0x227FD40 Offset: 0x227E740 VA: 0x18227FD40
	private void CheckTimers(DateTime now) { }

	// RVA: 0x228C3C0 Offset: 0x228ADC0 VA: 0x18228C3C0
	private void WaitForHwndMessage(Hwnd hwnd, Msg message) { }

	// RVA: 0x2288B20 Offset: 0x2287520 VA: 0x182288B20
	private void SendParentNotify(IntPtr child, Msg cause, int x, int y) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool StyleSet(int s, WindowStyles ws) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool ExStyleSet(int ex, WindowExStyles exws) { }

	// RVA: 0x2282640 Offset: 0x2281040 VA: 0x182282640
	private void DeriveStyles(int Style, int ExStyle, out FormBorderStyle border_style, out bool border_static, out TitleStyle title_style, out int caption_height, out int tool_caption_height) { }

	// RVA: 0x22895A0 Offset: 0x2287FA0 VA: 0x1822895A0
	private void SetHwndStyles(Hwnd hwnd, CreateParams cp) { }

	// RVA: 0x228B4F0 Offset: 0x2289EF0 VA: 0x18228B4F0
	private void ShowCaret() { }

	// RVA: 0x2285C20 Offset: 0x2284620 VA: 0x182285C20
	private void HideCaret() { }

	// RVA: 0x227EE20 Offset: 0x227D820 VA: 0x18227EE20
	private void AccumulateDestroyedHandles(Control c, ArrayList list) { }

	// RVA: 0x2280060 Offset: 0x227EA60 VA: 0x182280060
	private void CleanupCachedWindows(Hwnd hwnd) { }

	// RVA: 0x227F100 Offset: 0x227DB00 VA: 0x18227F100
	private void AddExpose(Hwnd hwnd, bool client, int x, int y, int width, int height) { }

	// RVA: 0x2283440 Offset: 0x2281E40 VA: 0x182283440
	internal void EnqueueMessage(MSG msg) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	internal override IntPtr InitializeDriver() { }

	// RVA: 0x227EFE0 Offset: 0x227D9E0 VA: 0x18227EFE0 Slot: 55
	internal override void Activate(IntPtr handle) { }

	// RVA: 0x227F410 Offset: 0x227DE10 VA: 0x18227F410 Slot: 32
	internal override void AudibleAlert(AlertType alert) { }

	// RVA: 0x227FAC0 Offset: 0x227E4C0 VA: 0x18227FAC0 Slot: 89
	internal override void CaretVisible(IntPtr hwnd, bool visible) { }

	// RVA: 0x227F900 Offset: 0x227E300 VA: 0x18227F900 Slot: 70
	internal override bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect) { }

	// RVA: 0x22802B0 Offset: 0x227ECB0 VA: 0x1822802B0 Slot: 79
	internal override void ClientToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x2286F00 Offset: 0x2285900 VA: 0x182286F00 Slot: 98
	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x2280370 Offset: 0x227ED70 VA: 0x182280370 Slot: 105
	internal override int[] ClipboardAvailableFormats(IntPtr handle) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 101
	internal override void ClipboardClose(IntPtr handle) { }

	// RVA: 0x2280520 Offset: 0x227EF20 VA: 0x182280520 Slot: 103
	internal override int ClipboardGetID(IntPtr handle, string format) { }

	// RVA: 0x2280580 Offset: 0x227EF80 VA: 0x182280580 Slot: 102
	internal override IntPtr ClipboardOpen(bool primary_selection) { }

	// RVA: 0x2280660 Offset: 0x227F060 VA: 0x182280660 Slot: 106
	internal override object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter) { }

	// RVA: 0x22806C0 Offset: 0x227F0C0 VA: 0x1822806C0 Slot: 104
	internal override void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter) { }

	// RVA: 0x2280AD0 Offset: 0x227F4D0 VA: 0x182280AD0 Slot: 86
	internal override void CreateCaret(IntPtr hwnd, int width, int height) { }

	// RVA: 0x2280CC0 Offset: 0x227F6C0 VA: 0x182280CC0 Slot: 34
	internal override IntPtr CreateWindow(CreateParams cp) { }

	// RVA: 0x2282520 Offset: 0x2280F20 VA: 0x182282520 Slot: 73
	internal override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot) { }

	// RVA: 0x22825F0 Offset: 0x2280FF0 VA: 0x1822825F0 Slot: 74
	internal override IntPtr DefineStdCursor(StdCursor id) { }

	// RVA: 0x2281ED0 Offset: 0x22808D0 VA: 0x182281ED0 Slot: 60
	internal override IntPtr DefWndProc(ref Message msg) { }

	// RVA: 0x22827C0 Offset: 0x22811C0 VA: 0x1822827C0 Slot: 87
	internal override void DestroyCaret(IntPtr hwnd) { }

	// RVA: 0x2282900 Offset: 0x2281300 VA: 0x182282900 Slot: 35
	internal override void DestroyWindow(IntPtr handle) { }

	// RVA: 0x2282E30 Offset: 0x2281830 VA: 0x182282E30 Slot: 66
	internal override IntPtr DispatchMessage(ref MSG msg) { }

	// RVA: 0x2282F40 Offset: 0x2281940 VA: 0x182282F40 Slot: 61
	internal override void DoEvents() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 56
	internal override void EnableWindow(IntPtr handle, bool Enable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 112
	internal override void EndLoop(Thread thread) { }

	// RVA: 0x2283590 Offset: 0x2281F90 VA: 0x182283590
	internal void Exit() { }

	// RVA: 0x2283890 Offset: 0x2282290 VA: 0x182283890 Slot: 92
	internal override IntPtr GetActive() { }

	[MonoTODO]
	// RVA: 0x2283BD0 Offset: 0x22825D0 VA: 0x182283BD0 Slot: 75
	internal override void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y) { }

	// RVA: 0x2283CC0 Offset: 0x22826C0 VA: 0x182283CC0 Slot: 33
	internal override void GetDisplaySize(out Size size) { }

	// RVA: 0x2284A50 Offset: 0x2283450 VA: 0x182284A50 Slot: 49
	internal override IntPtr GetParent(IntPtr handle) { }

	// RVA: 0x2284AC0 Offset: 0x22834C0 VA: 0x182284AC0 Slot: 93
	internal override IntPtr GetPreviousWindow(IntPtr handle) { }

	// RVA: 0x2283BF0 Offset: 0x22825F0 VA: 0x182283BF0 Slot: 76
	internal override void GetCursorPos(IntPtr handle, out int x, out int y) { }

	// RVA: 0x2283E70 Offset: 0x2282870 VA: 0x182283E70 Slot: 90
	internal override IntPtr GetFocus() { }

	// RVA: 0x2283EC0 Offset: 0x22828C0 VA: 0x182283EC0 Slot: 96
	internal override bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent) { }

	// RVA: 0x2284280 Offset: 0x2282C80 VA: 0x182284280 Slot: 97
	internal override Point GetMenuOrigin(IntPtr handle) { }

	// RVA: 0x2284300 Offset: 0x2282D00 VA: 0x182284300 Slot: 64
	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax) { }

	// RVA: 0x2284CA0 Offset: 0x22836A0 VA: 0x182284CA0 Slot: 54
	internal override void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height) { }

	// RVA: 0x2284DB0 Offset: 0x22837B0 VA: 0x182284DB0 Slot: 36
	internal override FormWindowState GetWindowState(IntPtr hwnd) { }

	// RVA: 0x2284F10 Offset: 0x2283910 VA: 0x182284F10 Slot: 81
	internal override void GrabInfo(out IntPtr handle, out bool GrabConfined, out Rectangle GrabArea) { }

	// RVA: 0x2284FB0 Offset: 0x22839B0 VA: 0x182284FB0 Slot: 80
	internal override void GrabWindow(IntPtr handle, IntPtr confine_to_handle) { }

	// RVA: 0x228C1D0 Offset: 0x228ABD0 VA: 0x18228C1D0 Slot: 82
	internal override void UngrabWindow(IntPtr hwnd) { }

	// RVA: 0x2286B90 Offset: 0x2285590 VA: 0x182286B90 Slot: 58
	internal override void Invalidate(IntPtr handle, Rectangle rc, bool clear) { }

	// RVA: 0x2286B00 Offset: 0x2285500 VA: 0x182286B00 Slot: 59
	internal override void InvalidateNC(IntPtr handle) { }

	// RVA: 0x2286C70 Offset: 0x2285670 VA: 0x182286C70 Slot: 47
	internal override bool IsEnabled(IntPtr handle) { }

	// RVA: 0x2286E70 Offset: 0x2285870 VA: 0x182286E70 Slot: 85
	internal override void KillTimer(Timer timer) { }

	// RVA: 0x2287520 Offset: 0x2285F20 VA: 0x182287520 Slot: 51
	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x2287310 Offset: 0x2285D10 VA: 0x182287310 Slot: 52
	internal override void PaintEventEnd(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x2287900 Offset: 0x2286300 VA: 0x182287900 Slot: 62
	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags) { }

	// RVA: 0x22881D0 Offset: 0x2286BD0 VA: 0x1822881D0 Slot: 110
	internal override bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x2288240 Offset: 0x2286C40 VA: 0x182288240 Slot: 63
	internal override void PostQuitMessage(int exitCode) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 115
	internal override void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave) { }

	// RVA: 0x2288410 Offset: 0x2286E10 VA: 0x182288410 Slot: 113
	internal override void RequestNCRecalc(IntPtr handle) { }

	[MonoTODO]
	// RVA: 0x22884D0 Offset: 0x2286ED0 VA: 0x1822884D0 Slot: 114
	internal override void ResetMouseHover(IntPtr handle) { }

	// RVA: 0x22885E0 Offset: 0x2286FE0 VA: 0x1822885E0 Slot: 78
	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x22886A0 Offset: 0x22870A0 VA: 0x1822886A0 Slot: 99
	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x2288820 Offset: 0x2287220 VA: 0x182288820 Slot: 94
	internal override void ScrollWindow(IntPtr handle, Rectangle area, int XAmount, int YAmount, bool clear) { }

	// RVA: 0x2288760 Offset: 0x2287160 VA: 0x182288760 Slot: 95
	internal override void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool clear) { }

	[MonoTODO]
	// RVA: 0x22888E0 Offset: 0x22872E0 VA: 0x1822888E0 Slot: 83
	internal override void SendAsyncMethod(AsyncMethodData method) { }

	[MonoTODO]
	// RVA: 0x2288AA0 Offset: 0x22874A0 VA: 0x182288AA0 Slot: 109
	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x2288F40 Offset: 0x2287940 VA: 0x182288F40 Slot: 88
	internal override void SetCaretPos(IntPtr hwnd, int x, int y) { }

	// RVA: 0x2289150 Offset: 0x2287B50 VA: 0x182289150 Slot: 71
	internal override void SetClipRegion(IntPtr hwnd, Region region) { }

	// RVA: 0x2289380 Offset: 0x2287D80 VA: 0x182289380 Slot: 72
	internal override void SetCursor(IntPtr window, IntPtr cursor) { }

	// RVA: 0x2289220 Offset: 0x2287C20 VA: 0x182289220 Slot: 77
	internal override void SetCursorPos(IntPtr handle, int x, int y) { }

	// RVA: 0x22893F0 Offset: 0x2287DF0 VA: 0x1822893F0 Slot: 91
	internal override void SetFocus(IntPtr handle) { }

	// RVA: 0x2289610 Offset: 0x2288010 VA: 0x182289610 Slot: 100
	internal override void SetIcon(IntPtr handle, Icon icon) { }

	// RVA: 0x2289CC0 Offset: 0x22886C0 VA: 0x182289CC0 Slot: 57
	internal override void SetModal(IntPtr handle, bool Modal) { }

	// RVA: 0x2289E70 Offset: 0x2288870 VA: 0x182289E70 Slot: 48
	internal override IntPtr SetParent(IntPtr handle, IntPtr parent) { }

	// RVA: 0x228A250 Offset: 0x2288C50 VA: 0x18228A250 Slot: 84
	internal override void SetTimer(Timer timer) { }

	// RVA: 0x228A2E0 Offset: 0x2288CE0 VA: 0x18228A2E0 Slot: 68
	internal override bool SetTopmost(IntPtr hWnd, bool Enabled) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 69
	internal override bool SetOwner(IntPtr hWnd, IntPtr hWndOwner) { }

	// RVA: 0x228A340 Offset: 0x2288D40 VA: 0x18228A340 Slot: 46
	internal override bool SetVisible(IntPtr handle, bool visible, bool activate) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 42
	internal override void SetAllowDrop(IntPtr handle, bool value) { }

	// RVA: 0x2288E20 Offset: 0x2287820 VA: 0x182288E20 Slot: 43
	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style) { }

	// RVA: 0x2289C20 Offset: 0x2288620 VA: 0x182289C20 Slot: 44
	internal override void SetMenu(IntPtr handle, Menu menu) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 38
	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max) { }

	// RVA: 0x228A600 Offset: 0x2289000 VA: 0x18228A600 Slot: 53
	internal override void SetWindowPos(IntPtr handle, int x, int y, int width, int height) { }

	// RVA: 0x228ABE0 Offset: 0x22895E0 VA: 0x18228ABE0 Slot: 37
	internal override void SetWindowState(IntPtr handle, FormWindowState state) { }

	// RVA: 0x228AF40 Offset: 0x2289940 VA: 0x18228AF40 Slot: 39
	internal override void SetWindowStyle(IntPtr handle, CreateParams cp) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 40
	internal override void SetWindowTransparency(IntPtr handle, double transparency, Color key) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 41
	internal override TransparencySupport SupportsTransparency() { }

	// RVA: 0x228B380 Offset: 0x2289D80 VA: 0x18228B380 Slot: 67
	internal override bool SetZOrder(IntPtr handle, IntPtr after_handle, bool Top, bool Bottom) { }

	// RVA: 0x228B8A0 Offset: 0x228A2A0 VA: 0x18228B8A0 Slot: 111
	internal override object StartLoop(Thread thread) { }

	// RVA: 0x228B8F0 Offset: 0x228A2F0 VA: 0x18228B8F0 Slot: 45
	internal override bool Text(IntPtr handle, string text) { }

	// RVA: 0x228C290 Offset: 0x228AC90 VA: 0x18228C290 Slot: 50
	internal override void UpdateWindow(IntPtr handle) { }

	// RVA: 0x228BE60 Offset: 0x228A860 VA: 0x18228BE60 Slot: 65
	internal override bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x228B720 Offset: 0x228A120 VA: 0x18228B720
	internal void SizeWindow(Rectangle rect, IntPtr window) { }

	// RVA: 0x22830A0 Offset: 0x2281AA0 VA: 0x1822830A0 Slot: 107
	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width) { }

	// RVA: 0x22838E0 Offset: 0x22822E0 VA: 0x1822838E0 Slot: 108
	internal override SizeF GetAutoScaleSize(Font font) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 11
	internal override Point get_MousePosition() { }

	// RVA: 0x228C8A0 Offset: 0x228B2A0 VA: 0x18228C8A0 Slot: 16
	internal override int get_CaptionHeight() { }

	// RVA: 0x22228E0 Offset: 0x22212E0 VA: 0x1822228E0 Slot: 17
	internal override Size get_DragSize() { }

	// RVA: 0x228C8B0 Offset: 0x228B2B0 VA: 0x18228C8B0 Slot: 18
	internal override Size get_FrameBorderSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 19
	internal override bool get_MenuAccessKeysUnderlined() { }

	// RVA: 0x228C8E0 Offset: 0x228B2E0 VA: 0x18228C8E0 Slot: 21
	internal override Size get_MinimumWindowSize() { }

	// RVA: 0x228C910 Offset: 0x228B310 VA: 0x18228C910 Slot: 10
	internal override Keys get_ModifierKeys() { }

	// RVA: 0x228C980 Offset: 0x228B380 VA: 0x18228C980 Slot: 26
	internal override Rectangle get_VirtualScreen() { }

	// RVA: 0x228C9B0 Offset: 0x228B3B0 VA: 0x18228C9B0 Slot: 27
	internal override Rectangle get_WorkingArea() { }

	// RVA: 0x228C930 Offset: 0x228B330 VA: 0x18228C930 Slot: 28
	internal override bool get_ThemesEnabled() { }

	// RVA: 0x2285370 Offset: 0x2283D70 VA: 0x182285370
	private static extern int HIViewConvertPoint(ref CGPoint point, IntPtr pView, IntPtr cView) { }

	// RVA: 0x22852D0 Offset: 0x2283CD0 VA: 0x1822852D0
	private static extern int HIViewChangeFeatures(IntPtr aView, ulong bitsin, ulong bitsout) { }

	// RVA: 0x2285410 Offset: 0x2283E10 VA: 0x182285410
	private static extern int HIViewFindByID(IntPtr rootWnd, HIViewID id, ref IntPtr outPtr) { }

	// RVA: 0x2285030 Offset: 0x2283A30 VA: 0x182285030
	private static extern int HIGrowBoxViewSetTransparent(IntPtr GrowBox, bool transparency) { }

	// RVA: 0x2285530 Offset: 0x2283F30 VA: 0x182285530
	private static extern IntPtr HIViewGetRoot(IntPtr hWnd) { }

	// RVA: 0x22850C0 Offset: 0x2283AC0 VA: 0x1822850C0
	private static extern int HIObjectCreate(IntPtr cfStr, uint what, ref IntPtr hwnd) { }

	// RVA: 0x2285160 Offset: 0x2283B60 VA: 0x182285160
	private static extern int HIObjectRegisterSubclass(IntPtr classid, IntPtr superclassid, uint options, EventDelegate upp, uint count, EventTypeSpec[] list, IntPtr state, ref IntPtr cls) { }

	// RVA: 0x22857E0 Offset: 0x22841E0 VA: 0x1822857E0
	private static extern int HIViewPlaceInSuperviewAt(IntPtr view, float x, float y) { }

	// RVA: 0x2285240 Offset: 0x2283C40 VA: 0x182285240
	private static extern int HIViewAddSubview(IntPtr parentHnd, IntPtr childHnd) { }

	// RVA: 0x22854B0 Offset: 0x2283EB0 VA: 0x1822854B0
	private static extern IntPtr HIViewGetPreviousView(IntPtr aView) { }

	// RVA: 0x22855B0 Offset: 0x2283FB0 VA: 0x1822855B0
	private static extern IntPtr HIViewGetSuperview(IntPtr aView) { }

	// RVA: 0x2285880 Offset: 0x2284280 VA: 0x182285880
	private static extern int HIViewRemoveFromSuperview(IntPtr aView) { }

	// RVA: 0x2285990 Offset: 0x2284390 VA: 0x182285990
	private static extern int HIViewSetVisible(IntPtr vHnd, bool visible) { }

	// RVA: 0x22856B0 Offset: 0x22840B0 VA: 0x1822856B0
	private static extern bool HIViewIsVisible(IntPtr vHnd) { }

	// RVA: 0x2285A20 Offset: 0x2284420 VA: 0x182285A20
	private static extern int HIViewSetZOrder(IntPtr hWnd, int cmd, IntPtr oHnd) { }

	// RVA: 0x2285730 Offset: 0x2284130 VA: 0x182285730
	private static extern int HIViewNewTrackingArea(IntPtr inView, IntPtr inShape, ulong inID, ref IntPtr outRef) { }

	// RVA: 0x2285630 Offset: 0x2284030 VA: 0x182285630
	private static extern IntPtr HIViewGetWindow(IntPtr aView) { }

	// RVA: 0x2285900 Offset: 0x2284300 VA: 0x182285900
	private static extern int HIViewSetFrame(IntPtr view_handle, ref HIRect bounds) { }

	// RVA: 0x228A190 Offset: 0x2288B90 VA: 0x18228A190
	private static extern void SetRect(ref Rect r, short left, short top, short right, short bottom) { }

	// RVA: 0x227EF50 Offset: 0x227D950 VA: 0x18227EF50
	private static extern int ActivateWindow(IntPtr windowHnd, bool inActivate) { }

	// RVA: 0x2288D90 Offset: 0x2287790 VA: 0x182288D90
	private static extern int SetAutomaticControlDragTrackingEnabledForWindow(IntPtr window, bool enabled) { }

	// RVA: 0x2283E00 Offset: 0x2282800 VA: 0x182283E00
	private static extern IntPtr GetEventDispatcherTarget() { }

	// RVA: 0x2288A10 Offset: 0x2287410 VA: 0x182288A10
	private static extern int SendEventToEventTarget(IntPtr evt, IntPtr target) { }

	// RVA: 0x2288390 Offset: 0x2286D90 VA: 0x182288390
	private static extern int ReleaseEvent(IntPtr evt) { }

	// RVA: 0x22882D0 Offset: 0x2286CD0 VA: 0x1822882D0
	private static extern int ReceiveNextEvent(uint evtCount, IntPtr evtTypes, double timeout, bool processEvt, ref IntPtr evt) { }

	// RVA: 0x2286CD0 Offset: 0x22856D0 VA: 0x182286CD0
	private static extern bool IsWindowCollapsed(IntPtr hWnd) { }

	// RVA: 0x2286D50 Offset: 0x2285750 VA: 0x182286D50
	private static extern bool IsWindowInStandardState(IntPtr hWnd, IntPtr a, IntPtr b) { }

	// RVA: 0x2280730 Offset: 0x227F130 VA: 0x182280730
	private static extern void CollapseWindow(IntPtr hWnd, bool collapse) { }

	// RVA: 0x228C510 Offset: 0x228AF10 VA: 0x18228C510
	private static extern void ZoomWindow(IntPtr hWnd, short partCode, bool front) { }

	// RVA: 0x2284B70 Offset: 0x2283570 VA: 0x182284B70
	private static extern int GetWindowAttributes(IntPtr hWnd, ref WindowAttributes outAttributes) { }

	// RVA: 0x227FCA0 Offset: 0x227E6A0 VA: 0x18227FCA0
	private static extern int ChangeWindowAttributes(IntPtr hWnd, WindowAttributes inAttributes, WindowAttributes outAttributes) { }

	// RVA: 0x2283F20 Offset: 0x2282920 VA: 0x182283F20
	internal static extern int GetGlobalMouse(ref QDPoint outData) { }

	// RVA: 0x227F4B0 Offset: 0x227DEB0 VA: 0x18227F4B0
	private static extern int BeginAppModalStateForWindow(IntPtr window) { }

	// RVA: 0x22833C0 Offset: 0x2281DC0 VA: 0x1822833C0
	private static extern int EndAppModalStateForWindow(IntPtr window) { }

	// RVA: 0x2280C20 Offset: 0x227F620 VA: 0x182280C20
	private static extern int CreateNewWindow(WindowClass klass, WindowAttributes attributes, ref Rect r, ref IntPtr window) { }

	// RVA: 0x2282EC0 Offset: 0x22818C0 VA: 0x182282EC0
	private static extern int DisposeWindow(IntPtr wHnd) { }

	// RVA: 0x228B6A0 Offset: 0x228A0A0 VA: 0x18228B6A0
	internal static extern int ShowWindow(IntPtr wHnd) { }

	// RVA: 0x2285CC0 Offset: 0x22846C0 VA: 0x182285CC0
	internal static extern int HideWindow(IntPtr wHnd) { }

	// RVA: 0x2286DF0 Offset: 0x22857F0 VA: 0x182286DF0
	internal static extern bool IsWindowVisible(IntPtr wHnd) { }

	// RVA: 0x228A560 Offset: 0x2288F60 VA: 0x18228A560
	private static extern int SetWindowBounds(IntPtr wHnd, uint reg, ref Rect rect) { }

	// RVA: 0x2284C00 Offset: 0x2283600 VA: 0x182284C00
	private static extern int GetWindowBounds(IntPtr wHnd, uint reg, ref Rect rect) { }

	// RVA: 0x2289190 Offset: 0x2287B90 VA: 0x182289190
	private static extern int SetControlTitleWithCFString(IntPtr hWnd, IntPtr titleCFStr) { }

	// RVA: 0x228B2F0 Offset: 0x2289CF0 VA: 0x18228B2F0
	private static extern int SetWindowTitleWithCFString(IntPtr hWnd, IntPtr titleCFStr) { }

	// RVA: 0x228C5B0 Offset: 0x228AFB0 VA: 0x18228C5B0
	internal static extern IntPtr __CFStringMakeConstantString(string cString) { }

	// RVA: 0x2284210 Offset: 0x2282C10 VA: 0x182284210
	private static extern short GetMBarHeight() { }

	// RVA: 0x227F3A0 Offset: 0x227DDA0 VA: 0x18227F3A0
	private static extern void AlertSoundPlay() { }

	// RVA: 0x227F660 Offset: 0x227E060 VA: 0x18227F660
	private static extern HIRect CGDisplayBounds(IntPtr displayID) { }

	// RVA: 0x227F890 Offset: 0x227E290 VA: 0x18227F890
	private static extern IntPtr CGMainDisplayID() { }

	// RVA: 0x227F700 Offset: 0x227E100 VA: 0x18227F700
	private static extern void CGDisplayMoveCursorToPoint(IntPtr display, CGPoint point) { }

	// RVA: 0x2283B50 Offset: 0x2282550 VA: 0x182283B50
	private static extern int GetCurrentProcess(ref ProcessSerialNumber psn) { }

	// RVA: 0x228BB80 Offset: 0x228A580 VA: 0x18228BB80
	private static extern int TransformProcessType(ref ProcessSerialNumber psn, uint type) { }

	// RVA: 0x2289520 Offset: 0x2287F20 VA: 0x182289520
	private static extern int SetFrontProcess(ref ProcessSerialNumber psn) { }

	// RVA: 0x227F530 Offset: 0x227DF30 VA: 0x18227F530
	private static extern IntPtr CGColorSpaceCreateDeviceRGB() { }

	// RVA: 0x227F5A0 Offset: 0x227DFA0 VA: 0x18227F5A0
	private static extern IntPtr CGDataProviderCreateWithData(IntPtr info, IntPtr[] data, int size, IntPtr releasefunc) { }

	// RVA: 0x227F790 Offset: 0x227E190 VA: 0x18227F790
	private static extern IntPtr CGImageCreate(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, IntPtr colorspace, uint bitmapInfo, IntPtr provider, IntPtr decode, int shouldInterpolate, int intent) { }

	// RVA: 0x2288D10 Offset: 0x2287710 VA: 0x182288D10
	private static extern void SetApplicationDockTileImage(IntPtr imageRef) { }

	// RVA: 0x2288510 Offset: 0x2286F10 VA: 0x182288510
	private static extern void RestoreApplicationDockTileImage() { }
}
