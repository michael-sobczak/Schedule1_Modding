internal class XplatUIWin32 : XplatUIDriver // TypeDefIndex: 5860
{
	// Fields
	private static XplatUIWin32 instance; // 0x0
	private static int ref_count; // 0x8
	private static IntPtr FosterParent; // 0x10
	internal static MouseButtons mouse_state; // 0x18
	internal static Point mouse_position; // 0x1C
	internal static bool grab_confined; // 0x24
	internal static IntPtr grab_hwnd; // 0x28
	internal static Rectangle grab_area; // 0x30
	internal static XplatUIDriver.WndProc wnd_proc; // 0x40
	internal static IntPtr prev_mouse_hwnd; // 0x48
	internal static bool caret_visible; // 0x50
	internal static bool themes_enabled; // 0x51
	private Hashtable timer_list; // 0x10
	private static Queue message_queue; // 0x58
	private static IntPtr clip_magic; // 0x60
	private static int scroll_width; // 0x68
	private static int scroll_height; // 0x6C
	private static Hashtable wm_nc_registered; // 0x70
	private static XplatUIWin32.RECT clipped_cursor_rect; // 0x78
	private Hashtable registered_classes; // 0x18
	private Hwnd HwndCreating; // 0x20
	private TransparencySupport support; // 0x28
	private bool queried_transparency_support; // 0x2C

	// Properties
	public override Size MenuButtonSize { get; }
	internal override Keys ModifierKeys { get; }
	internal override Point MousePosition { get; }
	internal override int HorizontalScrollBarHeight { get; }
	internal override bool UserClipWontExposeParent { get; }
	internal override int VerticalScrollBarWidth { get; }
	internal override int MenuHeight { get; }
	internal override Size Border3DSize { get; }
	internal override Size BorderSize { get; }
	internal override Size CaptionButtonSize { get; }
	internal override int CaptionHeight { get; }
	internal override Size DragSize { get; }
	internal override int DoubleClickTime { get; }
	internal override Size FrameBorderSize { get; }
	internal override bool MenuAccessKeysUnderlined { get; }
	internal override Size MinimizedWindowSize { get; }
	internal override Size MinimumWindowSize { get; }
	internal override Size MinWindowTrackSize { get; }
	internal override Rectangle VirtualScreen { get; }
	internal override Rectangle WorkingArea { get; }
	internal override bool ThemesEnabled { get; }
	internal override bool RequiresPositiveClientAreaSize { get; }
	public override int ToolWindowCaptionHeight { get; }
	public override Size ToolWindowCaptionButtonSize { get; }

	// Methods

	// RVA: 0x22CA6F0 Offset: 0x22C90F0 VA: 0x1822CA6F0
	private void .ctor() { }

	// RVA: 0x22CA690 Offset: 0x22C9090 VA: 0x1822CA690
	private static void .cctor() { }

	// RVA: 0x22C3A70 Offset: 0x22C2470 VA: 0x1822C3A70
	private string RegisterWindowClass(int classStyle) { }

	// RVA: 0x22C42C0 Offset: 0x22C2CC0 VA: 0x1822C42C0
	private static bool RetrieveMessage(ref MSG msg) { }

	// RVA: 0x22C5E70 Offset: 0x22C4870 VA: 0x1822C5E70
	private static bool StoreMessage(ref MSG msg) { }

	// RVA: 0x22BCD30 Offset: 0x22BB730 VA: 0x1822BCD30
	internal static string AnsiToString(IntPtr ansi_data) { }

	// RVA: 0x22C6470 Offset: 0x22C4E70 VA: 0x1822C6470
	internal static string UnicodeToString(IntPtr unicode_data) { }

	// RVA: 0x22BF1B0 Offset: 0x22BDBB0 VA: 0x1822BF1B0
	internal static Image DIBtoImage(IntPtr dib_data) { }

	// RVA: 0x22C28C0 Offset: 0x22C12C0 VA: 0x1822C28C0
	internal static byte[] ImageToDIB(Image image) { }

	// RVA: 0x22C0B10 Offset: 0x22BF510 VA: 0x1822C0B10
	internal static IntPtr DupGlobalMem(IntPtr mem) { }

	// RVA: 0x22CB500 Offset: 0x22C9F00 VA: 0x1822CB500 Slot: 9
	public override Size get_MenuButtonSize() { }

	// RVA: 0x22CBAB0 Offset: 0x22CA4B0 VA: 0x1822CBAB0 Slot: 10
	internal override Keys get_ModifierKeys() { }

	// RVA: 0x22CBC70 Offset: 0x22CA670 VA: 0x1822CBC70 Slot: 11
	internal override Point get_MousePosition() { }

	// RVA: 0x22CB3F0 Offset: 0x22C9DF0 VA: 0x1822CB3F0 Slot: 13
	internal override int get_HorizontalScrollBarHeight() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	internal override bool get_UserClipWontExposeParent() { }

	// RVA: 0x22CBF00 Offset: 0x22CA900 VA: 0x1822CBF00 Slot: 15
	internal override int get_VerticalScrollBarWidth() { }

	// RVA: 0x22CB640 Offset: 0x22CA040 VA: 0x1822CB640 Slot: 12
	internal override int get_MenuHeight() { }

	// RVA: 0x22CAC60 Offset: 0x22C9660 VA: 0x1822CAC60 Slot: 5
	internal override Size get_Border3DSize() { }

	// RVA: 0x22CADA0 Offset: 0x22C97A0 VA: 0x1822CADA0 Slot: 6
	internal override Size get_BorderSize() { }

	// RVA: 0x22CAEE0 Offset: 0x22C98E0 VA: 0x1822CAEE0 Slot: 7
	internal override Size get_CaptionButtonSize() { }

	// RVA: 0x22CB020 Offset: 0x22C9A20 VA: 0x1822CB020 Slot: 16
	internal override int get_CaptionHeight() { }

	// RVA: 0x22CB170 Offset: 0x22C9B70 VA: 0x1822CB170 Slot: 17
	internal override Size get_DragSize() { }

	// RVA: 0x22CB0D0 Offset: 0x22C9AD0 VA: 0x1822CB0D0 Slot: 8
	internal override int get_DoubleClickTime() { }

	// RVA: 0x22CB2B0 Offset: 0x22C9CB0 VA: 0x1822CB2B0 Slot: 18
	internal override Size get_FrameBorderSize() { }

	// RVA: 0x22CB440 Offset: 0x22C9E40 VA: 0x1822CB440 Slot: 19
	internal override bool get_MenuAccessKeysUnderlined() { }

	// RVA: 0x22CB830 Offset: 0x22CA230 VA: 0x1822CB830 Slot: 20
	internal override Size get_MinimizedWindowSize() { }

	// RVA: 0x22CB970 Offset: 0x22CA370 VA: 0x1822CB970 Slot: 21
	internal override Size get_MinimumWindowSize() { }

	// RVA: 0x22CB6F0 Offset: 0x22CA0F0 VA: 0x1822CB6F0 Slot: 25
	internal override Size get_MinWindowTrackSize() { }

	// RVA: 0x22CBF50 Offset: 0x22CA950 VA: 0x1822CBF50 Slot: 26
	internal override Rectangle get_VirtualScreen() { }

	// RVA: 0x22CC150 Offset: 0x22CAB50 VA: 0x1822CC150 Slot: 27
	internal override Rectangle get_WorkingArea() { }

	// RVA: 0x22CBCC0 Offset: 0x22CA6C0 VA: 0x1822CBCC0 Slot: 28
	internal override bool get_ThemesEnabled() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	internal override bool get_RequiresPositiveClientAreaSize() { }

	// RVA: 0x22CBE50 Offset: 0x22CA850 VA: 0x1822CBE50 Slot: 30
	public override int get_ToolWindowCaptionHeight() { }

	// RVA: 0x22CBD10 Offset: 0x22CA710 VA: 0x1822CBD10 Slot: 31
	public override Size get_ToolWindowCaptionButtonSize() { }

	// RVA: 0x22C14E0 Offset: 0x22BFEE0 VA: 0x1822C14E0
	public static XplatUIWin32 GetInstance() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	internal override IntPtr InitializeDriver() { }

	// RVA: 0x22C2230 Offset: 0x22C0C30 VA: 0x1822C2230
	private string GetSoundAlias(AlertType alert) { }

	// RVA: 0x22BCD80 Offset: 0x22BB780 VA: 0x1822BCD80 Slot: 32
	internal override void AudibleAlert(AlertType alert) { }

	// RVA: 0x22C1190 Offset: 0x22BFB90 VA: 0x1822C1190 Slot: 33
	internal override void GetDisplaySize(out Size size) { }

	// RVA: 0x22BECD0 Offset: 0x22BD6D0 VA: 0x1822BECD0 Slot: 34
	internal override IntPtr CreateWindow(CreateParams cp) { }

	// RVA: 0x22C02C0 Offset: 0x22BECC0 VA: 0x1822C02C0 Slot: 35
	internal override void DestroyWindow(IntPtr handle) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 38
	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max) { }

	// RVA: 0x22C2580 Offset: 0x22C0F80 VA: 0x1822C2580 Slot: 36
	internal override FormWindowState GetWindowState(IntPtr handle) { }

	// RVA: 0x22C5A40 Offset: 0x22C4440 VA: 0x1822C5A40 Slot: 37
	internal override void SetWindowState(IntPtr hwnd, FormWindowState state) { }

	// RVA: 0x22C5AF0 Offset: 0x22C44F0 VA: 0x1822C5AF0 Slot: 39
	internal override void SetWindowStyle(IntPtr handle, CreateParams cp) { }

	// RVA: 0x22C5BF0 Offset: 0x22C45F0 VA: 0x1822C5BF0 Slot: 40
	internal override void SetWindowTransparency(IntPtr handle, double transparency, Color key) { }

	// RVA: 0x22C6070 Offset: 0x22C4A70 VA: 0x1822C6070 Slot: 41
	internal override TransparencySupport SupportsTransparency() { }

	// RVA: 0x22C64C0 Offset: 0x22C4EC0 VA: 0x1822C64C0 Slot: 50
	internal override void UpdateWindow(IntPtr handle) { }

	// RVA: 0x22C3320 Offset: 0x22C1D20 VA: 0x1822C3320 Slot: 51
	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x22C3070 Offset: 0x22C1A70 VA: 0x1822C3070 Slot: 52
	internal override void PaintEventEnd(ref Message m, IntPtr handle, bool client) { }

	// RVA: 0x22C5950 Offset: 0x22C4350 VA: 0x1822C5950 Slot: 53
	internal override void SetWindowPos(IntPtr handle, int x, int y, int width, int height) { }

	// RVA: 0x22C22E0 Offset: 0x22C0CE0 VA: 0x1822C22E0 Slot: 54
	internal override void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height) { }

	// RVA: 0x22BC990 Offset: 0x22BB390 VA: 0x1822BC990 Slot: 55
	internal override void Activate(IntPtr handle) { }

	// RVA: 0x22C2AF0 Offset: 0x22C14F0 VA: 0x1822C2AF0 Slot: 58
	internal override void Invalidate(IntPtr handle, Rectangle rc, bool clear) { }

	// RVA: 0x22C2A80 Offset: 0x22C1480 VA: 0x1822C2A80 Slot: 59
	internal override void InvalidateNC(IntPtr handle) { }

	// RVA: 0x22C29C0 Offset: 0x22C13C0 VA: 0x1822C29C0
	private IntPtr InternalWndProc(IntPtr hWnd, Msg msg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22BF820 Offset: 0x22BE220 VA: 0x1822BF820 Slot: 60
	internal override IntPtr DefWndProc(ref Message msg) { }

	// RVA: 0x22C0410 Offset: 0x22BEE10 VA: 0x1822C0410 Slot: 61
	internal override void DoEvents() { }

	// RVA: 0x22C38C0 Offset: 0x22C22C0 VA: 0x1822C38C0 Slot: 62
	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags) { }

	// RVA: 0x22C39C0 Offset: 0x22C23C0 VA: 0x1822C39C0 Slot: 63
	internal override void PostQuitMessage(int exitCode) { }

	// RVA: 0x22C3DC0 Offset: 0x22C27C0 VA: 0x1822C3DC0 Slot: 115
	internal override void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave) { }

	// RVA: 0x22C4110 Offset: 0x22C2B10 VA: 0x1822C4110 Slot: 113
	internal override void RequestNCRecalc(IntPtr handle) { }

	// RVA: 0x22C4180 Offset: 0x22C2B80 VA: 0x1822C4180 Slot: 114
	internal override void ResetMouseHover(IntPtr handle) { }

	// RVA: 0x22C20D0 Offset: 0x22C0AD0 VA: 0x1822C20D0 Slot: 64
	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax) { }

	// RVA: 0x22C17B0 Offset: 0x22C01B0 VA: 0x1822C17B0
	private bool GetMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, bool blocking) { }

	// RVA: 0x22C62A0 Offset: 0x22C4CA0 VA: 0x1822C62A0 Slot: 65
	internal override bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x22C03C0 Offset: 0x22BEDC0 VA: 0x1822C03C0 Slot: 66
	internal override IntPtr DispatchMessage(ref MSG msg) { }

	// RVA: 0x22C5D30 Offset: 0x22C4730 VA: 0x1822C5D30 Slot: 67
	internal override bool SetZOrder(IntPtr hWnd, IntPtr AfterhWnd, bool Top, bool Bottom) { }

	// RVA: 0x22C56B0 Offset: 0x22C40B0 VA: 0x1822C56B0 Slot: 68
	internal override bool SetTopmost(IntPtr hWnd, bool Enabled) { }

	// RVA: 0x22C5090 Offset: 0x22C3A90 VA: 0x1822C5090 Slot: 69
	internal override bool SetOwner(IntPtr hWnd, IntPtr hWndOwner) { }

	// RVA: 0x22C61D0 Offset: 0x22C4BD0 VA: 0x1822C61D0 Slot: 45
	internal override bool Text(IntPtr handle, string text) { }

	// RVA: 0x22C5750 Offset: 0x22C4150 VA: 0x1822C5750 Slot: 46
	internal override bool SetVisible(IntPtr handle, bool visible, bool activate) { }

	// RVA: 0x22C2C00 Offset: 0x22C1600 VA: 0x1822C2C00 Slot: 47
	internal override bool IsEnabled(IntPtr handle) { }

	// RVA: 0x22C5100 Offset: 0x22C3B00 VA: 0x1822C5100 Slot: 48
	internal override IntPtr SetParent(IntPtr handle, IntPtr parent) { }

	// RVA: 0x22C2180 Offset: 0x22C0B80 VA: 0x1822C2180 Slot: 49
	internal override IntPtr GetParent(IntPtr handle) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 93
	internal override IntPtr GetPreviousWindow(IntPtr handle) { }

	// RVA: 0x22C2690 Offset: 0x22C1090 VA: 0x1822C2690 Slot: 80
	internal override void GrabWindow(IntPtr hWnd, IntPtr ConfineToHwnd) { }

	// RVA: 0x22C25F0 Offset: 0x22C0FF0 VA: 0x1822C25F0 Slot: 81
	internal override void GrabInfo(out IntPtr hWnd, out bool GrabConfined, out Rectangle GrabArea) { }

	// RVA: 0x22C62F0 Offset: 0x22C4CF0 VA: 0x1822C62F0 Slot: 82
	internal override void UngrabWindow(IntPtr hWnd) { }

	// RVA: 0x22BD0E0 Offset: 0x22BBAE0 VA: 0x1822BD0E0 Slot: 70
	internal override bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect) { }

	// RVA: 0x22C4E20 Offset: 0x22C3820 VA: 0x1822C4E20 Slot: 72
	internal override void SetCursor(IntPtr window, IntPtr cursor) { }

	// RVA: 0x22BF910 Offset: 0x22BE310 VA: 0x1822BF910 Slot: 73
	internal override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot) { }

	[MonoTODO("Define the missing cursors")]
	// RVA: 0x22BFDD0 Offset: 0x22BE7D0 VA: 0x1822BFDD0 Slot: 74
	internal override IntPtr DefineStdCursor(StdCursor id) { }

	[MonoTODO]
	// RVA: 0x22C0ED0 Offset: 0x22BF8D0 VA: 0x1822C0ED0 Slot: 75
	internal override void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y) { }

	// RVA: 0x22C4D60 Offset: 0x22C3760 VA: 0x1822C4D60 Slot: 77
	internal override void SetCursorPos(IntPtr handle, int x, int y) { }

	// RVA: 0x22C4B10 Offset: 0x22C3510 VA: 0x1822C4B10 Slot: 71
	internal override void SetClipRegion(IntPtr hwnd, Region region) { }

	// RVA: 0x22C0C90 Offset: 0x22BF690 VA: 0x1822C0C90 Slot: 56
	internal override void EnableWindow(IntPtr handle, bool Enable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 112
	internal override void EndLoop(Thread thread) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 111
	internal override object StartLoop(Thread thread) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 57
	internal override void SetModal(IntPtr handle, bool Modal) { }

	// RVA: 0x22C1030 Offset: 0x22BFA30 VA: 0x1822C1030 Slot: 76
	internal override void GetCursorPos(IntPtr handle, out int x, out int y) { }

	// RVA: 0x22C43F0 Offset: 0x22C2DF0 VA: 0x1822C43F0 Slot: 78
	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x22BD450 Offset: 0x22BBE50 VA: 0x1822BD450 Slot: 79
	internal override void ClientToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x22C44D0 Offset: 0x22C2ED0 VA: 0x1822C44D0 Slot: 99
	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x22C2ED0 Offset: 0x22C18D0 VA: 0x1822C2ED0 Slot: 98
	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x22C48C0 Offset: 0x22C32C0 VA: 0x1822C48C0 Slot: 83
	internal override void SendAsyncMethod(AsyncMethodData method) { }

	// RVA: 0x22C54E0 Offset: 0x22C3EE0 VA: 0x1822C54E0 Slot: 84
	internal override void SetTimer(Timer timer) { }

	// RVA: 0x22C2D30 Offset: 0x22C1730 VA: 0x1822C2D30 Slot: 85
	internal override void KillTimer(Timer timer) { }

	// RVA: 0x22BEA20 Offset: 0x22BD420 VA: 0x1822BEA20 Slot: 86
	internal override void CreateCaret(IntPtr hwnd, int width, int height) { }

	// RVA: 0x22C0100 Offset: 0x22BEB00 VA: 0x1822C0100 Slot: 87
	internal override void DestroyCaret(IntPtr hwnd) { }

	// RVA: 0x22C4A50 Offset: 0x22C3450 VA: 0x1822C4A50 Slot: 88
	internal override void SetCaretPos(IntPtr hwnd, int x, int y) { }

	// RVA: 0x22BD2A0 Offset: 0x22BBCA0 VA: 0x1822BD2A0 Slot: 89
	internal override void CaretVisible(IntPtr hwnd, bool visible) { }

	// RVA: 0x22C1280 Offset: 0x22BFC80 VA: 0x1822C1280 Slot: 90
	internal override IntPtr GetFocus() { }

	// RVA: 0x22C4ED0 Offset: 0x22C38D0 VA: 0x1822C4ED0 Slot: 91
	internal override void SetFocus(IntPtr hwnd) { }

	// RVA: 0x22C0D50 Offset: 0x22BF750 VA: 0x1822C0D50 Slot: 92
	internal override IntPtr GetActive() { }

	// RVA: 0x22C1320 Offset: 0x22BFD20 VA: 0x1822C1320 Slot: 96
	internal override bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent) { }

	// RVA: 0x22C4690 Offset: 0x22C3090 VA: 0x1822C4690 Slot: 94
	internal override void ScrollWindow(IntPtr hwnd, Rectangle rectangle, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x22C47C0 Offset: 0x22C31C0 VA: 0x1822C47C0 Slot: 95
	internal override void ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 43
	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style) { }

	// RVA: 0x22C5020 Offset: 0x22C3A20 VA: 0x1822C5020 Slot: 44
	internal override void SetMenu(IntPtr handle, Menu menu) { }

	// RVA: 0x22C15D0 Offset: 0x22BFFD0 VA: 0x1822C15D0 Slot: 97
	internal override Point GetMenuOrigin(IntPtr handle) { }

	// RVA: 0x22C4F80 Offset: 0x22C3980 VA: 0x1822C4F80 Slot: 100
	internal override void SetIcon(IntPtr hwnd, Icon icon) { }

	// RVA: 0x22BD750 Offset: 0x22BC150 VA: 0x1822BD750 Slot: 101
	internal override void ClipboardClose(IntPtr handle) { }

	// RVA: 0x22BD880 Offset: 0x22BC280 VA: 0x1822BD880 Slot: 103
	internal override int ClipboardGetID(IntPtr handle, string format) { }

	// RVA: 0x22BDD30 Offset: 0x22BC730 VA: 0x1822BDD30 Slot: 102
	internal override IntPtr ClipboardOpen(bool primary_selection) { }

	// RVA: 0x22BD530 Offset: 0x22BBF30 VA: 0x1822BD530 Slot: 105
	internal override int[] ClipboardAvailableFormats(IntPtr handle) { }

	// RVA: 0x22BDE00 Offset: 0x22BC800 VA: 0x1822BDE00 Slot: 106
	internal override object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter) { }

	// RVA: 0x22BE1A0 Offset: 0x22BCBA0 VA: 0x1822BE1A0 Slot: 104
	internal override void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter) { }

	// RVA: 0x22C5FF0 Offset: 0x22C49F0 VA: 0x1822C5FF0
	internal static byte[] StringToUnicode(string text) { }

	// RVA: 0x22C5F70 Offset: 0x22C4970 VA: 0x1822C5F70
	internal static byte[] StringToAnsi(string text) { }

	// RVA: 0x22C4BB0 Offset: 0x22C35B0 VA: 0x1822C4BB0
	private void SetClipboardData(uint type, byte[] data) { }

	// RVA: 0x22BE840 Offset: 0x22BD240 VA: 0x1822BE840
	internal static IntPtr CopyToMoveableMemory(byte[] data) { }

	// RVA: 0x22C49D0 Offset: 0x22C33D0 VA: 0x1822C49D0 Slot: 42
	internal override void SetAllowDrop(IntPtr hwnd, bool allowed) { }

	// RVA: 0x22C0580 Offset: 0x22BEF80 VA: 0x1822C0580 Slot: 107
	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width) { }

	// RVA: 0x22C0DF0 Offset: 0x22BF7F0 VA: 0x1822C0DF0 Slot: 108
	internal override SizeF GetAutoScaleSize(Font font) { }

	// RVA: 0x22C4950 Offset: 0x22C3350 VA: 0x1822C4950 Slot: 109
	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22C3940 Offset: 0x22C2340 VA: 0x1822C3940 Slot: 110
	internal override bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22BEB00 Offset: 0x22BD500 VA: 0x1822BEB00 Slot: 116
	internal override void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable) { }

	// RVA: 0x22C2100 Offset: 0x22C0B00 VA: 0x1822C2100 Slot: 118
	internal override Graphics GetOffscreenGraphics(object offscreen_drawable) { }

	// RVA: 0x22BCED0 Offset: 0x22BB8D0 VA: 0x1822BCED0 Slot: 119
	internal override void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r) { }

	// RVA: 0x22C01A0 Offset: 0x22BEBA0 VA: 0x1822C01A0 Slot: 117
	internal override void DestroyOffscreenDrawable(object offscreen_drawable) { }

	// RVA: 0x22C7CD0 Offset: 0x22C66D0 VA: 0x1822C7CD0
	private static extern uint Win32GetLastError() { }

	// RVA: 0x22C6D60 Offset: 0x22C5760 VA: 0x1822C6D60
	internal static extern IntPtr Win32CreateWindow(WindowExStyles dwExStyle, string lpClassName, string lpWindowName, WindowStyles dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lParam) { }

	// RVA: 0x22C70A0 Offset: 0x22C5AA0 VA: 0x1822C70A0
	internal static extern bool Win32DestroyWindow(IntPtr hWnd) { }

	// RVA: 0x22C8B90 Offset: 0x22C7590 VA: 0x1822C8B90
	internal static extern bool Win32PeekMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags) { }

	// RVA: 0x22C7DF0 Offset: 0x22C67F0 VA: 0x1822C7DF0
	internal static extern bool Win32GetMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax) { }

	// RVA: 0x22CA370 Offset: 0x22C8D70 VA: 0x1822CA370
	internal static extern bool Win32TranslateMessage(ref MSG msg) { }

	// RVA: 0x22C7120 Offset: 0x22C5B20 VA: 0x1822C7120
	internal static extern IntPtr Win32DispatchMessage(ref MSG msg) { }

	// RVA: 0x22C8A50 Offset: 0x22C7450 VA: 0x1822C8A50
	internal static extern bool Win32MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint) { }

	// RVA: 0x22C9E70 Offset: 0x22C8870 VA: 0x1822C9E70
	internal static extern bool Win32SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, XplatUIWin32.SetWindowPosFlags Flags) { }

	// RVA: 0x22C9DA0 Offset: 0x22C87A0 VA: 0x1822C9DA0
	internal static extern bool Win32SetWindowPos(IntPtr hWnd, XplatUIWin32.SetWindowPosZOrder pos, int x, int y, int cx, int cy, XplatUIWin32.SetWindowPosFlags Flags) { }

	// RVA: 0x22C9FE0 Offset: 0x22C89E0 VA: 0x1822C9FE0
	internal static extern bool Win32SetWindowText(IntPtr hWnd, string lpString) { }

	// RVA: 0x22C9B40 Offset: 0x22C8540 VA: 0x1822C9B40
	internal static extern IntPtr Win32SetParent(IntPtr hWnd, IntPtr hParent) { }

	// RVA: 0x22C8FA0 Offset: 0x22C79A0 VA: 0x1822C8FA0
	private static extern bool Win32RegisterClass(ref XplatUIWin32.WNDCLASS wndClass) { }

	// RVA: 0x22C8850 Offset: 0x22C7250 VA: 0x1822C8850
	private static extern IntPtr Win32LoadCursor(IntPtr hInstance, XplatUIWin32.LoadCursorType type) { }

	// RVA: 0x22C9990 Offset: 0x22C8390 VA: 0x1822C9990
	private static extern IntPtr Win32SetCursor(IntPtr hCursor) { }

	// RVA: 0x22C6B40 Offset: 0x22C5540 VA: 0x1822C6B40
	private static extern IntPtr Win32CreateCursor(IntPtr hInstance, int xHotSpot, int yHotSpot, int nWidth, int nHeight, byte[] pvANDPlane, byte[] pvORPlane) { }

	// RVA: 0x22C6E80 Offset: 0x22C5880 VA: 0x1822C6E80
	private static extern IntPtr Win32DefWindowProc(IntPtr hWnd, Msg Msg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22C8F20 Offset: 0x22C7920 VA: 0x1822C8F20
	private static extern IntPtr Win32PostQuitMessage(int nExitCode) { }

	// RVA: 0x22CA580 Offset: 0x22C8F80 VA: 0x1822CA580
	private static extern IntPtr Win32UpdateWindow(IntPtr hWnd) { }

	// RVA: 0x22C81B0 Offset: 0x22C6BB0 VA: 0x1822C81B0
	private static extern bool Win32GetUpdateRect(IntPtr hWnd, ref XplatUIWin32.RECT rect, bool erase) { }

	// RVA: 0x22C65C0 Offset: 0x22C4FC0 VA: 0x1822C65C0
	private static extern IntPtr Win32BeginPaint(IntPtr hWnd, ref XplatUIWin32.PAINTSTRUCT ps) { }

	// RVA: 0x22CA600 Offset: 0x22C9000 VA: 0x1822CA600
	private static extern IntPtr Win32ValidateRect(IntPtr hWnd, ref XplatUIWin32.RECT rect) { }

	// RVA: 0x22C7430 Offset: 0x22C5E30 VA: 0x1822C7430
	private static extern bool Win32EndPaint(IntPtr hWnd, ref XplatUIWin32.PAINTSTRUCT ps) { }

	// RVA: 0x22C79A0 Offset: 0x22C63A0 VA: 0x1822C79A0
	private static extern IntPtr Win32GetDC(IntPtr hWnd) { }

	// RVA: 0x22C8250 Offset: 0x22C6C50 VA: 0x1822C8250
	private static extern IntPtr Win32GetWindowDC(IntPtr hWnd) { }

	// RVA: 0x22C92D0 Offset: 0x22C7CD0 VA: 0x1822C92D0
	private static extern IntPtr Win32ReleaseDC(IntPtr hWnd, IntPtr hDC) { }

	// RVA: 0x22C88E0 Offset: 0x22C72E0 VA: 0x1822C88E0
	private static extern IntPtr Win32MessageBox(IntPtr hParent, string pText, string pCaption, uint uType) { }

	// RVA: 0x22C8680 Offset: 0x22C7080 VA: 0x1822C8680
	private static extern IntPtr Win32InvalidateRect(IntPtr hWnd, ref XplatUIWin32.RECT lpRect, bool bErase) { }

	// RVA: 0x22C9760 Offset: 0x22C8160 VA: 0x1822C9760
	private static extern IntPtr Win32SetCapture(IntPtr hWnd) { }

	// RVA: 0x22C9260 Offset: 0x22C7C60 VA: 0x1822C9260
	private static extern IntPtr Win32ReleaseCapture() { }

	// RVA: 0x22C8360 Offset: 0x22C6D60 VA: 0x1822C8360
	private static extern IntPtr Win32GetWindowRect(IntPtr hWnd, out XplatUIWin32.RECT rect) { }

	// RVA: 0x22C7790 Offset: 0x22C6190 VA: 0x1822C7790
	private static extern IntPtr Win32GetClientRect(IntPtr hWnd, out XplatUIWin32.RECT rect) { }

	// RVA: 0x22C9360 Offset: 0x22C7D60 VA: 0x1822C9360
	private static extern bool Win32ScreenToClient(IntPtr hWnd, ref POINT pt) { }

	// RVA: 0x22C6740 Offset: 0x22C5140 VA: 0x1822C6740
	private static extern bool Win32ClientToScreen(IntPtr hWnd, ref POINT pt) { }

	// RVA: 0x22C8020 Offset: 0x22C6A20 VA: 0x1822C8020
	private static extern IntPtr Win32GetParent(IntPtr hWnd) { }

	// RVA: 0x22C7700 Offset: 0x22C6100 VA: 0x1822C7700
	private static extern IntPtr Win32GetAncestor(IntPtr hWnd, XplatUIWin32.AncestorType flags) { }

	// RVA: 0x22C96E0 Offset: 0x22C80E0 VA: 0x1822C96E0
	private static extern IntPtr Win32SetActiveWindow(IntPtr hWnd) { }

	// RVA: 0x22C6510 Offset: 0x22C4F10 VA: 0x1822C6510
	private static extern bool Win32AdjustWindowRectEx(ref XplatUIWin32.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle) { }

	// RVA: 0x22C7920 Offset: 0x22C6320 VA: 0x1822C7920
	private static extern bool Win32GetCursorPos(out POINT lpPoint) { }

	// RVA: 0x22C9900 Offset: 0x22C8300 VA: 0x1822C9900
	private static extern bool Win32SetCursorPos(int x, int y) { }

	// RVA: 0x22CA2F0 Offset: 0x22C8CF0 VA: 0x1822CA2F0
	private static extern bool Win32TrackMouseEvent(ref XplatUIWin32.TRACKMOUSEEVENT tme) { }

	// RVA: 0x22C9D00 Offset: 0x22C8700 VA: 0x1822C9D00
	private static extern uint Win32SetWindowLong(IntPtr hwnd, XplatUIWin32.WindowLong index, uint value) { }

	// RVA: 0x22C82D0 Offset: 0x22C6CD0 VA: 0x1822C82D0
	private static extern uint Win32GetWindowLong(IntPtr hwnd, XplatUIWin32.WindowLong index) { }

	// RVA: 0x22C9A90 Offset: 0x22C8490 VA: 0x1822C9A90
	private static extern uint Win32SetLayeredWindowAttributes(IntPtr hwnd, XplatUIWin32.COLORREF crKey, byte bAlpha, XplatUIWin32.LayeredWindowAttributes dwFlags) { }

	// RVA: 0x22C7D40 Offset: 0x22C6740 VA: 0x1822C7D40
	private static extern uint Win32GetLayeredWindowAttributes(IntPtr hwnd, out XplatUIWin32.COLORREF pcrKey, out byte pbAlpha, out XplatUIWin32.LayeredWindowAttributes pwdFlags) { }

	// RVA: 0x22C6FB0 Offset: 0x22C59B0 VA: 0x1822C6FB0
	public static extern bool Win32DeleteObject(IntPtr o) { }

	// RVA: 0x22C7C50 Offset: 0x22C6650 VA: 0x1822C7C50
	private static extern short Win32GetKeyState(VirtualKeys nVirtKey) { }

	// RVA: 0x22C7A20 Offset: 0x22C6420 VA: 0x1822C7A20
	private static extern IntPtr Win32GetDesktopWindow() { }

	// RVA: 0x22C9C60 Offset: 0x22C8660 VA: 0x1822C9C60
	private static extern IntPtr Win32SetTimer(IntPtr hwnd, int nIDEvent, uint uElapse, IntPtr timerProc) { }

	// RVA: 0x22C8720 Offset: 0x22C7120 VA: 0x1822C8720
	private static extern IntPtr Win32KillTimer(IntPtr hwnd, int nIDEvent) { }

	// RVA: 0x22CA100 Offset: 0x22C8B00 VA: 0x1822CA100
	private static extern IntPtr Win32ShowWindow(IntPtr hwnd, XplatUIWin32.WindowPlacementFlags nCmdShow) { }

	// RVA: 0x22C73A0 Offset: 0x22C5DA0 VA: 0x1822C73A0
	private static extern IntPtr Win32EnableWindow(IntPtr hwnd, bool Enabled) { }

	// RVA: 0x22C9A10 Offset: 0x22C8410 VA: 0x1822C9A10
	internal static extern IntPtr Win32SetFocus(IntPtr hwnd) { }

	// RVA: 0x22C7B00 Offset: 0x22C6500 VA: 0x1822C7B00
	internal static extern IntPtr Win32GetFocus() { }

	// RVA: 0x22C6960 Offset: 0x22C5360 VA: 0x1822C6960
	internal static extern bool Win32CreateCaret(IntPtr hwnd, IntPtr hBitmap, int nWidth, int nHeight) { }

	// RVA: 0x22C7030 Offset: 0x22C5A30 VA: 0x1822C7030
	private static extern bool Win32DestroyCaret() { }

	// RVA: 0x22CA080 Offset: 0x22C8A80 VA: 0x1822CA080
	private static extern bool Win32ShowCaret(IntPtr hwnd) { }

	// RVA: 0x22C8600 Offset: 0x22C7000 VA: 0x1822C8600
	private static extern bool Win32HideCaret(IntPtr hwnd) { }

	// RVA: 0x22C97E0 Offset: 0x22C81E0 VA: 0x1822C97E0
	private static extern bool Win32SetCaretPos(int X, int Y) { }

	// RVA: 0x22C8120 Offset: 0x22C6B20 VA: 0x1822C8120
	internal static extern bool Win32GetTextMetrics(IntPtr hdc, ref XplatUIWin32.TEXTMETRIC tm) { }

	// RVA: 0x22C95B0 Offset: 0x22C7FB0 VA: 0x1822C95B0
	internal static extern IntPtr Win32SelectObject(IntPtr hdc, IntPtr hgdiobject) { }

	// RVA: 0x22C93F0 Offset: 0x22C7DF0 VA: 0x1822C93F0
	private static extern bool Win32ScrollWindowEx(IntPtr hwnd, int dx, int dy, IntPtr prcScroll, ref XplatUIWin32.RECT prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, XplatUIWin32.ScrollWindowExFlags flags) { }

	// RVA: 0x22C94D0 Offset: 0x22C7ED0 VA: 0x1822C94D0
	private static extern bool Win32ScrollWindowEx(IntPtr hwnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, XplatUIWin32.ScrollWindowExFlags flags) { }

	// RVA: 0x22C7690 Offset: 0x22C6090 VA: 0x1822C7690
	private static extern IntPtr Win32GetActiveWindow() { }

	// RVA: 0x22C80A0 Offset: 0x22C6AA0 VA: 0x1822C80A0
	private static extern int Win32GetSystemMetrics(XplatUIWin32.SystemMetrics nIndex) { }

	// RVA: 0x22C6CC0 Offset: 0x22C56C0 VA: 0x1822C6CC0
	internal static extern IntPtr Win32CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect) { }

	// RVA: 0x22C2CB0 Offset: 0x22C16B0 VA: 0x1822C2CB0
	private static extern bool IsWindowEnabled(IntPtr hwnd) { }

	// RVA: 0x22C9640 Offset: 0x22C8040 VA: 0x1822C9640
	private static extern IntPtr Win32SendMessage(IntPtr hwnd, Msg msg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22C8E70 Offset: 0x22C7870 VA: 0x1822C8E70
	private static extern bool Win32PostMessage(IntPtr hwnd, Msg msg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x22CA240 Offset: 0x22C8C40 VA: 0x1822CA240
	private static extern bool Win32SystemParametersInfo(XplatUIWin32.SPIAction uiAction, uint uiParam, ref XplatUIWin32.RECT rect, uint fWinIni) { }

	// RVA: 0x22CA190 Offset: 0x22C8B90 VA: 0x1822CA190
	private static extern bool Win32SystemParametersInfo(XplatUIWin32.SPIAction uiAction, uint uiParam, ref int value, uint fWinIni) { }

	// RVA: 0x22C8B10 Offset: 0x22C7510 VA: 0x1822C8B10
	private static extern bool Win32OpenClipboard(IntPtr hwnd) { }

	// RVA: 0x22C7330 Offset: 0x22C5D30 VA: 0x1822C7330
	private static extern bool Win32EmptyClipboard() { }

	// RVA: 0x22C91D0 Offset: 0x22C7BD0 VA: 0x1822C91D0
	private static extern uint Win32RegisterClipboardFormat(string format) { }

	// RVA: 0x22C6850 Offset: 0x22C5250 VA: 0x1822C6850
	private static extern bool Win32CloseClipboard() { }

	// RVA: 0x22C74C0 Offset: 0x22C5EC0 VA: 0x1822C74C0
	private static extern uint Win32EnumClipboardFormats(uint format) { }

	// RVA: 0x22C78A0 Offset: 0x22C62A0 VA: 0x1822C78A0
	private static extern IntPtr Win32GetClipboardData(uint format) { }

	// RVA: 0x22C9870 Offset: 0x22C8270 VA: 0x1822C9870
	private static extern IntPtr Win32SetClipboardData(uint format, IntPtr handle) { }

	// RVA: 0x22C83F0 Offset: 0x22C6DF0 VA: 0x1822C83F0
	internal static extern IntPtr Win32GlobalAlloc(XplatUIWin32.GAllocFlags Flags, int dwBytes) { }

	// RVA: 0x22C68C0 Offset: 0x22C52C0 VA: 0x1822C68C0
	internal static extern void Win32CopyMemory(IntPtr Destination, IntPtr Source, int length) { }

	// RVA: 0x22C8500 Offset: 0x22C6F00 VA: 0x1822C8500
	internal static extern uint Win32GlobalSize(IntPtr hMem) { }

	// RVA: 0x22C8480 Offset: 0x22C6E80 VA: 0x1822C8480
	internal static extern IntPtr Win32GlobalLock(IntPtr hMem) { }

	// RVA: 0x22C8580 Offset: 0x22C6F80 VA: 0x1822C8580
	internal static extern IntPtr Win32GlobalUnlock(IntPtr hMem) { }

	// RVA: 0x22C9BD0 Offset: 0x22C85D0 VA: 0x1822C9BD0
	internal static extern int Win32SetROP2(IntPtr hdc, XplatUIWin32.ROP2DrawMode fnDrawMode) { }

	// RVA: 0x22C89A0 Offset: 0x22C73A0 VA: 0x1822C89A0
	internal static extern bool Win32MoveToEx(IntPtr hdc, int x, int y, IntPtr lpPoint) { }

	// RVA: 0x22C87B0 Offset: 0x22C71B0 VA: 0x1822C87B0
	internal static extern bool Win32LineTo(IntPtr hdc, int x, int y) { }

	// RVA: 0x22C6C30 Offset: 0x22C5630 VA: 0x1822C6C30
	internal static extern IntPtr Win32CreatePen(XplatUIWin32.PenStyle fnPenStyle, int nWidth, IntPtr color) { }

	// RVA: 0x22C7540 Offset: 0x22C5F40 VA: 0x1822C7540
	internal static extern int Win32ExcludeClipRect(IntPtr hdc, int left, int top, int right, int bottom) { }

	// RVA: 0x22C75F0 Offset: 0x22C5FF0 VA: 0x1822C75F0
	internal static extern int Win32ExtSelectClipRgn(IntPtr hdc, IntPtr hrgn, int mode) { }

	// RVA: 0x22C8DD0 Offset: 0x22C77D0 VA: 0x1822C8DD0
	internal static extern IntPtr Win32PlaySound(string pszSound, IntPtr hmod, XplatUIWin32.SndFlags fdwSound) { }

	// RVA: 0x22C7A90 Offset: 0x22C6490 VA: 0x1822C7A90
	private static extern int Win32GetDoubleClickTime() { }

	// RVA: 0x22C9F40 Offset: 0x22C8940 VA: 0x1822C9F40
	internal static extern int Win32SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool redraw) { }

	// RVA: 0x22C67D0 Offset: 0x22C51D0 VA: 0x1822C67D0
	internal static extern bool Win32ClipCursor(ref XplatUIWin32.RECT lpRect) { }

	// RVA: 0x22C7820 Offset: 0x22C6220 VA: 0x1822C7820
	internal static extern bool Win32GetClipCursor(out XplatUIWin32.RECT lpRect) { }

	// RVA: 0x22C6650 Offset: 0x22C5050 VA: 0x1822C6650
	internal static extern bool Win32BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, XplatUIWin32.TernaryRasterOperations dwRop) { }

	// RVA: 0x22C6AB0 Offset: 0x22C54B0 VA: 0x1822C6AB0
	internal static extern IntPtr Win32CreateCompatibleDC(IntPtr hdc) { }

	// RVA: 0x22C6F20 Offset: 0x22C5920 VA: 0x1822C6F20
	internal static extern bool Win32DeleteDC(IntPtr hdc) { }

	// RVA: 0x22C6A10 Offset: 0x22C5410 VA: 0x1822C6A10
	internal static extern IntPtr Win32CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight) { }

	// RVA: 0x22C7B70 Offset: 0x22C6570 VA: 0x1822C7B70
	internal static extern bool Win32GetIconInfo(IntPtr hIcon, out XplatUIWin32.ICONINFO piconinfo) { }
}
