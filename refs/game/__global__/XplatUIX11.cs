internal class XplatUIX11 : XplatUIDriver // TypeDefIndex: 5864
{
	// Fields
	private static XplatUIX11 Instance; // 0x0
	private static int RefCount; // 0x8
	private static object XlibLock; // 0x10
	private static bool themes_enabled; // 0x18
	private static IntPtr DisplayHandle; // 0x20
	private static int ScreenNo; // 0x28
	private static IntPtr DefaultColormap; // 0x30
	private static IntPtr CustomVisual; // 0x38
	private static IntPtr CustomColormap; // 0x40
	private static IntPtr RootWindow; // 0x48
	private static IntPtr FosterParent; // 0x50
	private static XErrorHandler ErrorHandler; // 0x58
	private static bool ErrorExceptions; // 0x60
	private int render_major_opcode; // 0x10
	private int render_first_event; // 0x14
	private int render_first_error; // 0x18
	private static IntPtr ClipMagic; // 0x68
	private static ClipboardData Clipboard; // 0x70
	private static IntPtr PostAtom; // 0x78
	private static IntPtr AsyncAtom; // 0x80
	private static Hashtable MessageQueues; // 0x88
	private static ArrayList unattached_timer_list; // 0x90
	private static Pollfd[] pollfds; // 0x98
	private static bool wake_waiting; // 0xA0
	private static object wake_waiting_lock; // 0xA8
	private static X11Keyboard Keyboard; // 0xB0
	private static X11Dnd Dnd; // 0xB8
	private static Socket listen; // 0xC0
	private static Socket wake; // 0xC8
	private static Socket wake_receive; // 0xD0
	private static byte[] network_buffer; // 0xD8
	private static bool detectable_key_auto_repeat; // 0xE0
	private static IntPtr ActiveWindow; // 0xE8
	private static IntPtr FocusWindow; // 0xF0
	private static Stack ModalWindows; // 0xF8
	private static IntPtr LastCursorWindow; // 0x100
	private static IntPtr LastCursorHandle; // 0x108
	private static IntPtr OverrideCursorHandle; // 0x110
	private static CaretStruct Caret; // 0x118
	private static IntPtr LastPointerWindow; // 0x158
	private static IntPtr WM_PROTOCOLS; // 0x160
	private static IntPtr WM_DELETE_WINDOW; // 0x168
	private static IntPtr WM_TAKE_FOCUS; // 0x170
	private static IntPtr _NET_DESKTOP_GEOMETRY; // 0x178
	private static IntPtr _NET_CURRENT_DESKTOP; // 0x180
	private static IntPtr _NET_ACTIVE_WINDOW; // 0x188
	private static IntPtr _NET_WORKAREA; // 0x190
	private static IntPtr _NET_WM_NAME; // 0x198
	private static IntPtr _NET_WM_WINDOW_TYPE; // 0x1A0
	private static IntPtr _NET_WM_STATE; // 0x1A8
	private static IntPtr _NET_WM_ICON; // 0x1B0
	private static IntPtr _NET_WM_USER_TIME; // 0x1B8
	private static IntPtr _NET_FRAME_EXTENTS; // 0x1C0
	private static IntPtr _NET_SYSTEM_TRAY_S; // 0x1C8
	private static IntPtr _NET_SYSTEM_TRAY_OPCODE; // 0x1D0
	private static IntPtr _NET_WM_STATE_MAXIMIZED_HORZ; // 0x1D8
	private static IntPtr _NET_WM_STATE_MAXIMIZED_VERT; // 0x1E0
	private static IntPtr _XEMBED; // 0x1E8
	private static IntPtr _XEMBED_INFO; // 0x1F0
	private static IntPtr _MOTIF_WM_HINTS; // 0x1F8
	private static IntPtr _NET_WM_STATE_SKIP_TASKBAR; // 0x200
	private static IntPtr _NET_WM_STATE_ABOVE; // 0x208
	private static IntPtr _NET_WM_STATE_MODAL; // 0x210
	private static IntPtr _NET_WM_STATE_HIDDEN; // 0x218
	private static IntPtr _NET_WM_CONTEXT_HELP; // 0x220
	private static IntPtr _NET_WM_WINDOW_OPACITY; // 0x228
	private static IntPtr _NET_WM_WINDOW_TYPE_UTILITY; // 0x230
	private static IntPtr _NET_WM_WINDOW_TYPE_NORMAL; // 0x238
	private static IntPtr CLIPBOARD; // 0x240
	private static IntPtr PRIMARY; // 0x248
	private static IntPtr OEMTEXT; // 0x250
	private static IntPtr UTF8_STRING; // 0x258
	private static IntPtr UTF16_STRING; // 0x260
	private static IntPtr RICHTEXTFORMAT; // 0x268
	private static IntPtr TARGETS; // 0x270
	private static HoverStruct HoverState; // 0x278
	private static ClickStruct ClickPending; // 0x2A8
	private static GrabStruct Grab; // 0x2D8
	private Point mouse_position; // 0x1C
	internal static MouseButtons MouseState; // 0x2F8
	internal static bool in_doevents; // 0x2FC
	private static int DoubleClickInterval; // 0x300
	private static readonly object lockobj; // 0x308
	private static Hashtable messageHold; // 0x310
	private EventHandler Idle; // 0x28

	// Properties
	internal static IntPtr Display { get; }
	internal override int CaptionHeight { get; }
	internal override Size DragSize { get; }
	internal override Size FrameBorderSize { get; }
	internal override bool MenuAccessKeysUnderlined { get; }
	internal override Size MinimumWindowSize { get; }
	internal override Size MinimumFixedToolWindowSize { get; }
	internal override Size MinimumSizeableToolWindowSize { get; }
	internal override Size MinimumNoBorderWindowSize { get; }
	internal override Keys ModifierKeys { get; }
	internal override Point MousePosition { get; }
	internal override Rectangle VirtualScreen { get; }
	internal override Rectangle WorkingArea { get; }
	internal override bool ThemesEnabled { get; }

	// Methods

	// RVA: 0x22AF500 Offset: 0x22ADF00 VA: 0x1822AF500
	private void .ctor() { }

	// RVA: 0x22AF430 Offset: 0x22ADE30 VA: 0x1822AF430
	private static void .cctor() { }

	// RVA: 0x2296A40 Offset: 0x2295440 VA: 0x182296A40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22974A0 Offset: 0x2295EA0 VA: 0x1822974A0
	public static XplatUIX11 GetInstance() { }

	// RVA: 0x22AFA90 Offset: 0x22AE490 VA: 0x1822AFA90
	internal static IntPtr get_Display() { }

	// RVA: 0x22A0980 Offset: 0x229F380 VA: 0x1822A0980
	internal void SetDisplay(IntPtr display_handle) { }

	// RVA: 0x22B0650 Offset: 0x22AF050 VA: 0x1822B0650
	private int unixtime() { }

	// RVA: 0x22A5550 Offset: 0x22A3F50 VA: 0x1822A5550
	private static void SetupAtoms() { }

	// RVA: 0x229F9A0 Offset: 0x229E3A0 VA: 0x18229F9A0
	private void SendNetWMMessage(IntPtr window, IntPtr message_type, IntPtr l0, IntPtr l1, IntPtr l2) { }

	// RVA: 0x229FAB0 Offset: 0x229E4B0 VA: 0x18229FAB0
	private void SendParentNotify(IntPtr child, Msg cause, int x, int y) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool StyleSet(int s, WindowStyles ws) { }

	// RVA: 0x1B4F280 Offset: 0x1B4DC80 VA: 0x181B4F280
	private bool ExStyleSet(int ex, WindowExStyles exws) { }

	// RVA: 0x22A6AA0 Offset: 0x22A54A0 VA: 0x1822A6AA0
	internal static Rectangle TranslateClientRectangleToXClientRectangle(Hwnd hwnd) { }

	// RVA: 0x22A6B60 Offset: 0x22A5560 VA: 0x1822A6B60
	internal static Rectangle TranslateClientRectangleToXClientRectangle(Hwnd hwnd, Control ctrl) { }

	// RVA: 0x22A7660 Offset: 0x22A6060 VA: 0x1822A7660
	internal static Size TranslateWindowSizeToXWindowSize(CreateParams cp) { }

	// RVA: 0x22A7510 Offset: 0x22A5F10 VA: 0x1822A7510
	internal static Size TranslateWindowSizeToXWindowSize(CreateParams cp, Size size) { }

	// RVA: 0x22A76E0 Offset: 0x22A60E0 VA: 0x1822A76E0
	internal static Size TranslateXWindowSizeToWindowSize(CreateParams cp, int xWidth, int xHeight) { }

	// RVA: 0x229B2F0 Offset: 0x2299CF0 VA: 0x18229B2F0
	internal static Point GetTopLevelWindowLocation(Hwnd hwnd) { }

	// RVA: 0x2295990 Offset: 0x2294390 VA: 0x182295990
	private void DeriveStyles(int Style, int ExStyle, out FormBorderStyle border_style, out bool border_static, out TitleStyle title_style, out int caption_height, out int tool_caption_height) { }

	// RVA: 0x22A1CA0 Offset: 0x22A06A0 VA: 0x1822A1CA0
	private void SetHwndStyles(Hwnd hwnd, CreateParams cp) { }

	// RVA: 0x22A31D0 Offset: 0x22A1BD0 VA: 0x1822A31D0
	private void SetWMStyles(Hwnd hwnd, CreateParams cp) { }

	// RVA: 0x22A1D10 Offset: 0x22A0710 VA: 0x1822A1D10
	private void SetIcon(Hwnd hwnd, Icon icon) { }

	// RVA: 0x22AB030 Offset: 0x22A9A30 VA: 0x1822AB030
	private void WakeupMain() { }

	// RVA: 0x22A6960 Offset: 0x22A5360 VA: 0x1822A6960
	private XEventQueue ThreadQueue(Thread thread) { }

	// RVA: 0x22A6D60 Offset: 0x22A5760 VA: 0x1822A6D60
	private void TranslatePropertyToClipboard(IntPtr property) { }

	// RVA: 0x2291A00 Offset: 0x2290400 VA: 0x182291A00
	private void AddExpose(Hwnd hwnd, bool client, int x, int y, int width, int height) { }

	// RVA: 0x2296AA0 Offset: 0x22954A0 VA: 0x182296AA0
	private static Hwnd.Borders FrameExtents(IntPtr window) { }

	// RVA: 0x2291610 Offset: 0x2290010 VA: 0x182291610
	private void AddConfigureNotify(XEvent xevent) { }

	// RVA: 0x22A63C0 Offset: 0x22A4DC0 VA: 0x1822A63C0
	private void ShowCaret() { }

	// RVA: 0x229BE90 Offset: 0x229A890 VA: 0x18229BE90
	private void HideCaret() { }

	// RVA: 0x229CF10 Offset: 0x229B910 VA: 0x18229CF10
	private int NextTimeout(ArrayList timers, DateTime now) { }

	// RVA: 0x2292080 Offset: 0x2290A80 VA: 0x182292080
	private void CheckTimers(ArrayList timers, DateTime now) { }

	// RVA: 0x22AAAE0 Offset: 0x22A94E0 VA: 0x1822AAAE0
	private void WaitForHwndMessage(Hwnd hwnd, Msg message) { }

	// RVA: 0x22AAB00 Offset: 0x22A9500 VA: 0x1822AAB00
	private void WaitForHwndMessage(Hwnd hwnd, Msg message, bool process) { }

	// RVA: 0x229C590 Offset: 0x229AF90 VA: 0x18229C590
	private void MapWindow(Hwnd hwnd, WindowType windows) { }

	// RVA: 0x22A7950 Offset: 0x22A6350 VA: 0x1822A7950
	private void UnmapWindow(Hwnd hwnd, WindowType windows) { }

	// RVA: 0x22A7BF0 Offset: 0x22A65F0 VA: 0x1822A7BF0
	private void UpdateMessageQueue(XEventQueue queue) { }

	// RVA: 0x229AAF0 Offset: 0x22994F0 VA: 0x18229AAF0
	private IntPtr GetMousewParam(int Delta) { }

	// RVA: 0x22ACDE0 Offset: 0x22AB7E0 VA: 0x1822ACDE0
	private IntPtr XGetParent(IntPtr handle) { }

	// RVA: 0x229BCD0 Offset: 0x229A6D0 VA: 0x18229BCD0
	private int HandleError(IntPtr display, ref XErrorEvent error_event) { }

	// RVA: 0x2290FB0 Offset: 0x228F9B0 VA: 0x182290FB0
	private void AccumulateDestroyedHandles(Control c, ArrayList list) { }

	// RVA: 0x2292310 Offset: 0x2290D10 VA: 0x182292310
	private void CleanupCachedWindows(Hwnd hwnd) { }

	// RVA: 0x229DA20 Offset: 0x229C420 VA: 0x18229DA20
	private void PerformNCCalc(Hwnd hwnd) { }

	// RVA: 0x229C9F0 Offset: 0x229B3F0 VA: 0x18229C9F0
	private void MouseHover(object sender, EventArgs e) { }

	// RVA: 0x2291E20 Offset: 0x2290820 VA: 0x182291E20
	private void CaretCallback(object sender, EventArgs e) { }

	// RVA: 0x228C8A0 Offset: 0x228B2A0 VA: 0x18228C8A0 Slot: 16
	internal override int get_CaptionHeight() { }

	// RVA: 0x22228E0 Offset: 0x22212E0 VA: 0x1822228E0 Slot: 17
	internal override Size get_DragSize() { }

	// RVA: 0x22228E0 Offset: 0x22212E0 VA: 0x1822228E0 Slot: 18
	internal override Size get_FrameBorderSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 19
	internal override bool get_MenuAccessKeysUnderlined() { }

	// RVA: 0x228C8E0 Offset: 0x228B2E0 VA: 0x18228C8E0 Slot: 21
	internal override Size get_MinimumWindowSize() { }

	// RVA: 0x22AFAE0 Offset: 0x22AE4E0 VA: 0x1822AFAE0 Slot: 22
	internal override Size get_MinimumFixedToolWindowSize() { }

	// RVA: 0x22AFB10 Offset: 0x22AE510 VA: 0x1822AFB10 Slot: 23
	internal override Size get_MinimumSizeableToolWindowSize() { }

	// RVA: 0x228C8B0 Offset: 0x228B2B0 VA: 0x18228C8B0 Slot: 24
	internal override Size get_MinimumNoBorderWindowSize() { }

	// RVA: 0x22AFB40 Offset: 0x22AE540 VA: 0x1822AFB40 Slot: 10
	internal override Keys get_ModifierKeys() { }

	// RVA: 0x22AFBB0 Offset: 0x22AE5B0 VA: 0x1822AFBB0 Slot: 11
	internal override Point get_MousePosition() { }

	// RVA: 0x22AFC10 Offset: 0x22AE610 VA: 0x1822AFC10 Slot: 26
	internal override Rectangle get_VirtualScreen() { }

	// RVA: 0x22AFFE0 Offset: 0x22AE9E0 VA: 0x1822AFFE0 Slot: 27
	internal override Rectangle get_WorkingArea() { }

	// RVA: 0x22AFBC0 Offset: 0x22AE5C0 VA: 0x1822AFBC0 Slot: 28
	internal override bool get_ThemesEnabled() { }

	// RVA: 0x229C020 Offset: 0x229AA20 VA: 0x18229C020 Slot: 4
	internal override IntPtr InitializeDriver() { }

	// RVA: 0x22910E0 Offset: 0x228FAE0 VA: 0x1822910E0 Slot: 55
	internal override void Activate(IntPtr handle) { }

	// RVA: 0x2291B20 Offset: 0x2290520 VA: 0x182291B20 Slot: 32
	internal override void AudibleAlert(AlertType alert) { }

	// RVA: 0x2291F10 Offset: 0x2290910 VA: 0x182291F10 Slot: 89
	internal override void CaretVisible(IntPtr handle, bool visible) { }

	// RVA: 0x2291D80 Offset: 0x2290780 VA: 0x182291D80 Slot: 70
	internal override bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect) { }

	// RVA: 0x2292570 Offset: 0x2290F70 VA: 0x182292570 Slot: 79
	internal override void ClientToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x2292790 Offset: 0x2291190 VA: 0x182292790 Slot: 105
	internal override int[] ClipboardAvailableFormats(IntPtr handle) { }

	// RVA: 0x2292C50 Offset: 0x2291650 VA: 0x182292C50 Slot: 101
	internal override void ClipboardClose(IntPtr handle) { }

	// RVA: 0x2292D00 Offset: 0x2291700 VA: 0x182292D00 Slot: 103
	internal override int ClipboardGetID(IntPtr handle, string format) { }

	// RVA: 0x2293000 Offset: 0x2291A00 VA: 0x182293000 Slot: 102
	internal override IntPtr ClipboardOpen(bool primary_selection) { }

	// RVA: 0x22930C0 Offset: 0x2291AC0 VA: 0x1822930C0 Slot: 106
	internal override object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter) { }

	// RVA: 0x2293240 Offset: 0x2291C40 VA: 0x182293240 Slot: 104
	internal override void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter) { }

	// RVA: 0x22933A0 Offset: 0x2291DA0 VA: 0x1822933A0 Slot: 86
	internal override void CreateCaret(IntPtr handle, int width, int height) { }

	// RVA: 0x2293870 Offset: 0x2292270 VA: 0x182293870 Slot: 34
	internal override IntPtr CreateWindow(CreateParams cp) { }

	// RVA: 0x2294FC0 Offset: 0x22939C0 VA: 0x182294FC0 Slot: 73
	internal override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot) { }

	// RVA: 0x2295730 Offset: 0x2294130 VA: 0x182295730 Slot: 74
	internal override IntPtr DefineStdCursor(StdCursor id) { }

	// RVA: 0x22A6560 Offset: 0x22A4F60 VA: 0x1822A6560
	internal static CursorFontShape StdCursorToFontShape(StdCursor id) { }

	// RVA: 0x22948E0 Offset: 0x22932E0 VA: 0x1822948E0 Slot: 60
	internal override IntPtr DefWndProc(ref Message msg) { }

	// RVA: 0x2295B20 Offset: 0x2294520 VA: 0x182295B20 Slot: 87
	internal override void DestroyCaret(IntPtr handle) { }

	// RVA: 0x2295DA0 Offset: 0x22947A0 VA: 0x182295DA0 Slot: 35
	internal override void DestroyWindow(IntPtr handle) { }

	// RVA: 0x2296240 Offset: 0x2294C40 VA: 0x182296240 Slot: 66
	internal override IntPtr DispatchMessage(ref MSG msg) { }

	// RVA: 0x229ACF0 Offset: 0x22996F0 VA: 0x18229ACF0
	private IntPtr GetReversibleControlGC(Control control, int line_width) { }

	// RVA: 0x2296700 Offset: 0x2295100 VA: 0x182296700 Slot: 107
	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width) { }

	// RVA: 0x22962D0 Offset: 0x2294CD0 VA: 0x1822962D0 Slot: 61
	internal override void DoEvents() { }

	// RVA: 0x22969E0 Offset: 0x22953E0 VA: 0x1822969E0 Slot: 56
	internal override void EnableWindow(IntPtr handle, bool Enable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 112
	internal override void EndLoop(Thread thread) { }

	// RVA: 0x2296CF0 Offset: 0x22956F0 VA: 0x182296CF0 Slot: 92
	internal override IntPtr GetActive() { }

	// RVA: 0x2297010 Offset: 0x2295A10 VA: 0x182297010 Slot: 75
	internal override void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y) { }

	// RVA: 0x22972D0 Offset: 0x2295CD0 VA: 0x1822972D0 Slot: 33
	internal override void GetDisplaySize(out Size size) { }

	// RVA: 0x2296F30 Offset: 0x2295930 VA: 0x182296F30 Slot: 108
	internal override SizeF GetAutoScaleSize(Font font) { }

	// RVA: 0x229AC80 Offset: 0x2299680 VA: 0x18229AC80 Slot: 49
	internal override IntPtr GetParent(IntPtr handle) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 93
	internal override IntPtr GetPreviousWindow(IntPtr handle) { }

	// RVA: 0x2297030 Offset: 0x2295A30 VA: 0x182297030 Slot: 76
	internal override void GetCursorPos(IntPtr handle, out int x, out int y) { }

	// RVA: 0x2297440 Offset: 0x2295E40 VA: 0x182297440 Slot: 90
	internal override IntPtr GetFocus() { }

	// RVA: 0x2283EC0 Offset: 0x22828C0 VA: 0x182283EC0 Slot: 96
	internal override bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent) { }

	// RVA: 0x2297630 Offset: 0x2296030 VA: 0x182297630 Slot: 97
	internal override Point GetMenuOrigin(IntPtr handle) { }

	[MonoTODO("Implement filtering")]
	// RVA: 0x22976B0 Offset: 0x22960B0 VA: 0x1822976B0 Slot: 64
	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr handle, int wFilterMin, int wFilterMax) { }

	// RVA: 0x229CD60 Offset: 0x229B760 VA: 0x18229CD60
	private HitTest NCHitTest(Hwnd hwnd, int x, int y) { }

	// RVA: 0x229B640 Offset: 0x229A040 VA: 0x18229B640 Slot: 54
	internal override void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height) { }

	// RVA: 0x229B750 Offset: 0x229A150 VA: 0x18229B750 Slot: 36
	internal override FormWindowState GetWindowState(IntPtr handle) { }

	// RVA: 0x22AA5A0 Offset: 0x22A8FA0 VA: 0x1822AA5A0
	private FormWindowState UpdateWindowState(IntPtr handle) { }

	// RVA: 0x229B7F0 Offset: 0x229A1F0 VA: 0x18229B7F0 Slot: 81
	internal override void GrabInfo(out IntPtr handle, out bool GrabConfined, out Rectangle GrabArea) { }

	// RVA: 0x229B8A0 Offset: 0x229A2A0 VA: 0x18229B8A0 Slot: 80
	internal override void GrabWindow(IntPtr handle, IntPtr confine_to_handle) { }

	// RVA: 0x22A7830 Offset: 0x22A6230 VA: 0x1822A7830 Slot: 82
	internal override void UngrabWindow(IntPtr hwnd) { }

	// RVA: 0x22AB0D0 Offset: 0x22A9AD0 VA: 0x1822AB0D0
	private void WindowUngrabbed(IntPtr hwnd) { }

	// RVA: 0x229C1A0 Offset: 0x229ABA0 VA: 0x18229C1A0 Slot: 58
	internal override void Invalidate(IntPtr handle, Rectangle rc, bool clear) { }

	// RVA: 0x229C100 Offset: 0x229AB00 VA: 0x18229C100 Slot: 59
	internal override void InvalidateNC(IntPtr handle) { }

	// RVA: 0x229C310 Offset: 0x229AD10 VA: 0x18229C310 Slot: 47
	internal override bool IsEnabled(IntPtr handle) { }

	// RVA: 0x229C370 Offset: 0x229AD70 VA: 0x18229C370 Slot: 85
	internal override void KillTimer(Timer timer) { }

	// RVA: 0x229C7D0 Offset: 0x229B1D0 VA: 0x18229C7D0 Slot: 98
	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x229D3A0 Offset: 0x229BDA0 VA: 0x18229D3A0 Slot: 51
	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client) { }

	// RVA: 0x229D1B0 Offset: 0x229BBB0 VA: 0x18229D1B0 Slot: 52
	internal override void PaintEventEnd(ref Message msg, IntPtr handle, bool client) { }

	[MonoTODO("Implement filtering and PM_NOREMOVE")]
	// RVA: 0x229D780 Offset: 0x229C180 VA: 0x18229D780 Slot: 62
	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags) { }

	// RVA: 0x229DE30 Offset: 0x229C830 VA: 0x18229DE30 Slot: 110
	internal override bool PostMessage(IntPtr handle, Msg message, IntPtr wparam, IntPtr lparam) { }

	// RVA: 0x229E0E0 Offset: 0x229CAE0 VA: 0x18229E0E0 Slot: 63
	internal override void PostQuitMessage(int exitCode) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 115
	internal override void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave) { }

	// RVA: 0x229E600 Offset: 0x229D000 VA: 0x18229E600 Slot: 113
	internal override void RequestNCRecalc(IntPtr handle) { }

	// RVA: 0x229E6C0 Offset: 0x229D0C0 VA: 0x18229E6C0 Slot: 114
	internal override void ResetMouseHover(IntPtr handle) { }

	// RVA: 0x229E7C0 Offset: 0x229D1C0 VA: 0x18229E7C0 Slot: 78
	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x229E9E0 Offset: 0x229D3E0 VA: 0x18229E9E0 Slot: 99
	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y) { }

	// RVA: 0x229BCA0 Offset: 0x229A6A0 VA: 0x18229BCA0
	private bool GraphicsExposePredicate(IntPtr display, ref XEvent xevent, IntPtr arg) { }

	// RVA: 0x229E230 Offset: 0x229CC30 VA: 0x18229E230
	private void ProcessGraphicsExpose(Hwnd hwnd) { }

	// RVA: 0x229EC90 Offset: 0x229D690 VA: 0x18229EC90 Slot: 94
	internal override void ScrollWindow(IntPtr handle, Rectangle area, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x229F1C0 Offset: 0x229DBC0 VA: 0x18229F1C0 Slot: 95
	internal override void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool with_children) { }

	// RVA: 0x2297270 Offset: 0x2295C70 VA: 0x182297270
	private Rectangle GetDirtyArea(Rectangle total_area, Rectangle valid_area, int XAmount, int YAmount) { }

	// RVA: 0x229B4A0 Offset: 0x2299EA0 VA: 0x18229B4A0
	private Rectangle GetTotalVisibleArea(IntPtr handle) { }

	// RVA: 0x229F2A0 Offset: 0x229DCA0 VA: 0x18229F2A0 Slot: 83
	internal override void SendAsyncMethod(AsyncMethodData method) { }

	// RVA: 0x229F460 Offset: 0x229DE60 VA: 0x18229F460 Slot: 109
	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 42
	internal override void SetAllowDrop(IntPtr handle, bool value) { }

	// RVA: 0x229FCA0 Offset: 0x229E6A0 VA: 0x18229FCA0 Slot: 43
	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style) { }

	// RVA: 0x229FDF0 Offset: 0x229E7F0 VA: 0x18229FDF0 Slot: 88
	internal override void SetCaretPos(IntPtr handle, int x, int y) { }

	// RVA: 0x229FFC0 Offset: 0x229E9C0 VA: 0x18229FFC0 Slot: 71
	internal override void SetClipRegion(IntPtr handle, Region region) { }

	// RVA: 0x22A05A0 Offset: 0x229EFA0 VA: 0x1822A05A0 Slot: 72
	internal override void SetCursor(IntPtr handle, IntPtr cursor) { }

	// RVA: 0x229E300 Offset: 0x229CD00 VA: 0x18229E300
	private void QueryPointer(IntPtr display, IntPtr w, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int child_x, out int child_y, out int mask) { }

	// RVA: 0x22A0040 Offset: 0x229EA40 VA: 0x1822A0040 Slot: 77
	internal override void SetCursorPos(IntPtr handle, int x, int y) { }

	// RVA: 0x22A1AB0 Offset: 0x22A04B0 VA: 0x1822A1AB0 Slot: 91
	internal override void SetFocus(IntPtr handle) { }

	// RVA: 0x22A2040 Offset: 0x22A0A40 VA: 0x1822A2040 Slot: 100
	internal override void SetIcon(IntPtr handle, Icon icon) { }

	// RVA: 0x22A20C0 Offset: 0x22A0AC0 VA: 0x1822A20C0 Slot: 44
	internal override void SetMenu(IntPtr handle, Menu menu) { }

	// RVA: 0x22A2160 Offset: 0x22A0B60 VA: 0x1822A2160 Slot: 57
	internal override void SetModal(IntPtr handle, bool Modal) { }

	// RVA: 0x22A2820 Offset: 0x22A1220 VA: 0x1822A2820 Slot: 48
	internal override IntPtr SetParent(IntPtr handle, IntPtr parent) { }

	// RVA: 0x22A2A30 Offset: 0x22A1430 VA: 0x1822A2A30 Slot: 84
	internal override void SetTimer(Timer timer) { }

	// RVA: 0x22A2B90 Offset: 0x22A1590 VA: 0x1822A2B90 Slot: 68
	internal override bool SetTopmost(IntPtr handle, bool enabled) { }

	// RVA: 0x22A2440 Offset: 0x22A0E40 VA: 0x1822A2440 Slot: 69
	internal override bool SetOwner(IntPtr handle, IntPtr handle_owner) { }

	// RVA: 0x22A2F40 Offset: 0x22A1940 VA: 0x1822A2F40 Slot: 46
	internal override bool SetVisible(IntPtr handle, bool visible, bool activate) { }

	// RVA: 0x22A3E40 Offset: 0x22A2840 VA: 0x1822A3E40 Slot: 38
	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max) { }

	// RVA: 0x22A3F10 Offset: 0x22A2910 VA: 0x1822A3F10
	internal void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max, CreateParams cp) { }

	// RVA: 0x22A43F0 Offset: 0x22A2DF0 VA: 0x1822A43F0 Slot: 53
	internal override void SetWindowPos(IntPtr handle, int x, int y, int width, int height) { }

	// RVA: 0x22A47A0 Offset: 0x22A31A0 VA: 0x1822A47A0 Slot: 37
	internal override void SetWindowState(IntPtr handle, FormWindowState state) { }

	// RVA: 0x22A4CA0 Offset: 0x22A36A0 VA: 0x1822A4CA0 Slot: 39
	internal override void SetWindowStyle(IntPtr handle, CreateParams cp) { }

	// RVA: 0x22A4D70 Offset: 0x22A3770 VA: 0x1822A4D70 Slot: 40
	internal override void SetWindowTransparency(IntPtr handle, double transparency, Color key) { }

	// RVA: 0x22A4F40 Offset: 0x22A3940 VA: 0x1822A4F40 Slot: 67
	internal override bool SetZOrder(IntPtr handle, IntPtr after_handle, bool top, bool bottom) { }

	// RVA: 0x22A6550 Offset: 0x22A4F50 VA: 0x1822A6550 Slot: 111
	internal override object StartLoop(Thread thread) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 41
	internal override TransparencySupport SupportsTransparency() { }

	// RVA: 0x22A6650 Offset: 0x22A5050 VA: 0x1822A6650 Slot: 45
	internal override bool Text(IntPtr handle, string text) { }

	// RVA: 0x22A6CF0 Offset: 0x22A56F0 VA: 0x1822A6CF0 Slot: 65
	internal override bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x22AAA00 Offset: 0x22A9400 VA: 0x1822AAA00 Slot: 50
	internal override void UpdateWindow(IntPtr handle) { }

	// RVA: 0x2293680 Offset: 0x2292080 VA: 0x182293680 Slot: 116
	internal override void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable) { }

	// RVA: 0x2295CF0 Offset: 0x22946F0 VA: 0x182295CF0 Slot: 117
	internal override void DestroyOffscreenDrawable(object offscreen_drawable) { }

	// RVA: 0x229AC10 Offset: 0x2299610 VA: 0x18229AC10 Slot: 118
	internal override Graphics GetOffscreenGraphics(object offscreen_drawable) { }

	// RVA: 0x2291BE0 Offset: 0x22905E0 VA: 0x182291BE0 Slot: 119
	internal override void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r) { }

	// RVA: 0x22ADC70 Offset: 0x22AC670 VA: 0x1822ADC70
	internal static extern IntPtr XOpenDisplay(IntPtr display) { }

	// RVA: 0x22AB970 Offset: 0x22AA370 VA: 0x1822AB970
	internal static extern int XCloseDisplay(IntPtr display) { }

	// RVA: 0x22AEE80 Offset: 0x22AD880 VA: 0x1822AEE80
	internal static extern IntPtr XSynchronize(IntPtr display, bool onoff) { }

	// RVA: 0x22AC240 Offset: 0x22AAC40 VA: 0x1822AC240
	internal static extern IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, UIntPtr valuemask, ref XSetWindowAttributes attributes) { }

	// RVA: 0x22AC150 Offset: 0x22AAB50 VA: 0x1822AC150
	internal static extern IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background) { }

	// RVA: 0x22AD9B0 Offset: 0x22AC3B0 VA: 0x1822AD9B0
	internal static extern int XMapWindow(IntPtr display, IntPtr window) { }

	// RVA: 0x22AF190 Offset: 0x22ADB90 VA: 0x1822AF190
	internal static extern int XUnmapWindow(IntPtr display, IntPtr window) { }

	// RVA: 0x22AE360 Offset: 0x22ACD60 VA: 0x1822AE360
	internal static extern IntPtr XRootWindow(IntPtr display, int screen_number) { }

	// RVA: 0x22ADB00 Offset: 0x22AC500 VA: 0x1822ADB00
	internal static extern IntPtr XNextEvent(IntPtr display, ref XEvent xevent) { }

	// RVA: 0x22ABAA0 Offset: 0x22AA4A0 VA: 0x1822ABAA0
	internal static extern int XConnectionNumber(IntPtr display) { }

	// RVA: 0x22ADE60 Offset: 0x22AC860 VA: 0x1822ADE60
	internal static extern int XPending(IntPtr display) { }

	// RVA: 0x22AE3F0 Offset: 0x22ACDF0 VA: 0x1822AE3F0
	internal static extern IntPtr XSelectInput(IntPtr display, IntPtr window, IntPtr mask) { }

	// RVA: 0x22AC650 Offset: 0x22AB050 VA: 0x1822AC650
	internal static extern int XDestroyWindow(IntPtr display, IntPtr window) { }

	// RVA: 0x22AE2B0 Offset: 0x22ACCB0 VA: 0x1822AE2B0
	internal static extern int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y) { }

	// RVA: 0x22ADA40 Offset: 0x22AC440 VA: 0x1822ADA40
	private static extern int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height) { }

	// RVA: 0x229CC40 Offset: 0x229B640 VA: 0x18229CC40
	internal static int MoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height) { }

	// RVA: 0x22AD170 Offset: 0x22ABB70 VA: 0x1822AD170
	internal static extern int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes) { }

	// RVA: 0x22AC9F0 Offset: 0x22AB3F0 VA: 0x1822AC9F0
	internal static extern int XFlush(IntPtr display) { }

	// RVA: 0x22AEDC0 Offset: 0x22AD7C0 VA: 0x1822AEDC0
	internal static extern int XStoreName(IntPtr display, IntPtr window, string window_name) { }

	// RVA: 0x22AE490 Offset: 0x22ACE90 VA: 0x1822AE490
	internal static extern int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event) { }

	// RVA: 0x22AE160 Offset: 0x22ACB60 VA: 0x1822AE160
	internal static extern int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return) { }

	// RVA: 0x22ACB90 Offset: 0x22AB590 VA: 0x1822ACB90
	internal static extern int XFree(IntPtr data) { }

	// RVA: 0x22AE220 Offset: 0x22ACC20 VA: 0x1822AE220
	internal static extern int XRaiseWindow(IntPtr display, IntPtr window) { }

	// RVA: 0x22AD920 Offset: 0x22AC320 VA: 0x1822AD920
	internal static extern uint XLowerWindow(IntPtr display, IntPtr window) { }

	// RVA: 0x22AB9F0 Offset: 0x22AA3F0 VA: 0x1822AB9F0
	internal static extern uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowFlags value_mask, ref XWindowChanges values) { }

	// RVA: 0x22AD6E0 Offset: 0x22AC0E0 VA: 0x1822AD6E0
	internal static extern IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists) { }

	// RVA: 0x22AD7A0 Offset: 0x22AC1A0 VA: 0x1822AD7A0
	internal static extern int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms) { }

	// RVA: 0x22AEC60 Offset: 0x22AD660 VA: 0x1822AEC60
	internal static extern int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count) { }

	// RVA: 0x22AD400 Offset: 0x22ABE00 VA: 0x1822AD400
	internal static extern int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask, GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp) { }

	// RVA: 0x22AF080 Offset: 0x22ADA80 VA: 0x1822AF080
	internal static extern int XUngrabPointer(IntPtr display, IntPtr timestamp) { }

	// RVA: 0x22AE070 Offset: 0x22ACA70 VA: 0x1822AE070
	internal static extern bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons) { }

	// RVA: 0x22AEF10 Offset: 0x22AD910 VA: 0x1822AEF10
	internal static extern bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return) { }

	// RVA: 0x22ACCF0 Offset: 0x22AB6F0 VA: 0x1822ACCF0
	internal static extern bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y, out int width, out int height, out int border_width, out int depth) { }

	// RVA: 0x22AF220 Offset: 0x22ADC20 VA: 0x1822AF220
	internal static extern uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, uint src_width, uint src_height, int dest_x, int dest_y) { }

	// RVA: 0x22AC490 Offset: 0x22AAE90 VA: 0x1822AC490
	internal static extern int XDefaultScreen(IntPtr display) { }

	// RVA: 0x22AC400 Offset: 0x22AAE00 VA: 0x1822AC400
	internal static extern IntPtr XDefaultColormap(IntPtr display, int screen_number) { }

	// RVA: 0x22AB1A0 Offset: 0x22A9BA0 VA: 0x1822AB1A0
	internal static extern int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def) { }

	// RVA: 0x22AEA00 Offset: 0x22AD400 VA: 0x1822AEA00
	internal static extern int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window) { }

	// RVA: 0x22AB890 Offset: 0x22AA290 VA: 0x1822AB890
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref MotifWmHints data, int nelements) { }

	// RVA: 0x22AB400 Offset: 0x22A9E00 VA: 0x1822AB400
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref IntPtr value, int nelements) { }

	// RVA: 0x22AB5C0 Offset: 0x22A9FC0 VA: 0x1822AB5C0
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, int[] data, int nelements) { }

	// RVA: 0x22AB7A0 Offset: 0x22AA1A0 VA: 0x1822AB7A0
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements) { }

	// RVA: 0x22AB4E0 Offset: 0x22A9EE0 VA: 0x1822AB4E0
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements) { }

	// RVA: 0x22AB6B0 Offset: 0x22AA0B0 VA: 0x1822AB6B0
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, string text, int text_length) { }

	// RVA: 0x22AC5B0 Offset: 0x22AAFB0 VA: 0x1822AC5B0
	internal static extern int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property) { }

	// RVA: 0x22ABD60 Offset: 0x22AA760 VA: 0x1822ABD60
	internal static extern IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, ref XGCValues values) { }

	// RVA: 0x22ACA70 Offset: 0x22AB470 VA: 0x1822ACA70
	internal static extern int XFreeGC(IntPtr display, IntPtr gc) { }

	// RVA: 0x22AE810 Offset: 0x22AD210 VA: 0x1822AE810
	internal static extern int XSetFunction(IntPtr display, IntPtr gc, GXFunction function) { }

	// RVA: 0x22AC6E0 Offset: 0x22AB0E0 VA: 0x1822AC6E0
	internal static extern int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2) { }

	// RVA: 0x22AC7B0 Offset: 0x22AB1B0 VA: 0x1822AC7B0
	internal static extern int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height) { }

	// RVA: 0x22ABBE0 Offset: 0x22AA5E0 VA: 0x1822ABBE0
	internal static extern int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y, int width, int height, int dest_x, int dest_y) { }

	// RVA: 0x22AD2F0 Offset: 0x22ABCF0 VA: 0x1822AD2F0
	internal static extern int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset, IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format, out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop) { }

	// RVA: 0x22AD570 Offset: 0x22ABF70 VA: 0x1822AD570
	internal static extern int XIconifyWindow(IntPtr display, IntPtr window, int screen_number) { }

	// RVA: 0x22AC510 Offset: 0x22AAF10 VA: 0x1822AC510
	internal static extern int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor) { }

	// RVA: 0x22AEFF0 Offset: 0x22AD9F0 VA: 0x1822AEFF0
	internal static extern int XUndefineCursor(IntPtr display, IntPtr window) { }

	// RVA: 0x22ABCD0 Offset: 0x22AA6D0 VA: 0x1822ABCD0
	internal static extern IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape) { }

	// RVA: 0x22ABEE0 Offset: 0x22AA8E0 VA: 0x1822ABEE0
	internal static extern IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask, ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot) { }

	// RVA: 0x22ABFB0 Offset: 0x22AA9B0 VA: 0x1822ABFB0
	internal static extern IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width, int height, IntPtr fg, IntPtr bg, int depth) { }

	// RVA: 0x22AC0A0 Offset: 0x22AAAA0 VA: 0x1822AC0A0
	internal static extern IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth) { }

	// RVA: 0x22ACB00 Offset: 0x22AB500 VA: 0x1822ACB00
	internal static extern IntPtr XFreePixmap(IntPtr display, IntPtr pixmap) { }

	// RVA: 0x22ADEE0 Offset: 0x22AC8E0 VA: 0x1822ADEE0
	internal static extern int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height, out int best_width, out int best_height) { }

	// RVA: 0x22ADFA0 Offset: 0x22AC9A0 VA: 0x1822ADFA0
	internal static extern int XQueryExtension(IntPtr display, string extension_name, ref int major, ref int first_event, ref int first_error) { }

	// RVA: 0x22AF300 Offset: 0x22ADD00 VA: 0x1822AF300
	internal static extern IntPtr XWhitePixel(IntPtr display, int screen_no) { }

	// RVA: 0x22AB2D0 Offset: 0x22A9CD0 VA: 0x1822AB2D0
	internal static extern IntPtr XBlackPixel(IntPtr display, int screen_no) { }

	// RVA: 0x22AD4F0 Offset: 0x22ABEF0 VA: 0x1822AD4F0
	internal static extern void XGrabServer(IntPtr display) { }

	// RVA: 0x22AF110 Offset: 0x22ADB10 VA: 0x1822AF110
	internal static extern void XUngrabServer(IntPtr display) { }

	// RVA: 0x22AD0C0 Offset: 0x22ABAC0 VA: 0x1822AD0C0
	internal static extern void XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints, out IntPtr supplied_return) { }

	// RVA: 0x22AEBC0 Offset: 0x22AD5C0 VA: 0x1822AEBC0
	internal static extern void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints) { }

	// RVA: 0x22AED20 Offset: 0x22AD720 VA: 0x1822AED20
	internal static extern void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints) { }

	// RVA: 0x22AEAA0 Offset: 0x22AD4A0 VA: 0x1822AEAA0
	internal static extern void XSetWMHints(IntPtr display, IntPtr window, ref XWMHints wmhints) { }

	// RVA: 0x22AE6E0 Offset: 0x22AD0E0 VA: 0x1822AE6E0
	internal static extern IntPtr XSetErrorHandler(XErrorHandler error_handler) { }

	// RVA: 0x22ACC10 Offset: 0x22AB610 VA: 0x1822ACC10
	internal static extern IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length) { }

	// RVA: 0x22AD670 Offset: 0x22AC070 VA: 0x1822AD670
	internal static extern int XInitThreads() { }

	// RVA: 0x22ABB20 Offset: 0x22AA520 VA: 0x1822ABB20
	internal static extern int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time) { }

	// RVA: 0x22AD030 Offset: 0x22ABA30 VA: 0x1822AD030
	internal static extern IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection) { }

	// RVA: 0x22AE950 Offset: 0x22AD350 VA: 0x1822AE950
	internal static extern int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time) { }

	// RVA: 0x22AE8B0 Offset: 0x22AD2B0 VA: 0x1822AE8B0
	internal static extern int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask) { }

	// RVA: 0x22AE770 Offset: 0x22AD170 VA: 0x1822AE770
	internal static extern int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground) { }

	// RVA: 0x22AE640 Offset: 0x22AD040 VA: 0x1822AE640
	internal static extern int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background) { }

	// RVA: 0x22AB240 Offset: 0x22A9C40 VA: 0x1822AB240
	internal static extern int XBell(IntPtr display, int percent) { }

	// RVA: 0x22AB360 Offset: 0x22A9D60 VA: 0x1822AB360
	internal static extern int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor, IntPtr time) { }

	// RVA: 0x22AC880 Offset: 0x22AB280 VA: 0x1822AC880
	internal static extern bool XFilterEvent(ref XEvent xevent, IntPtr window) { }

	// RVA: 0x22AF390 Offset: 0x22ADD90 VA: 0x1822AF390
	internal static extern void XkbSetDetectableAutoRepeat(IntPtr display, bool detectable, IntPtr supported) { }

	// RVA: 0x22ADCF0 Offset: 0x22AC6F0 VA: 0x1822ADCF0
	internal static extern void XPeekEvent(IntPtr display, ref XEvent xevent) { }

	// RVA: 0x22AD610 Offset: 0x22AC010 VA: 0x1822AD610
	internal static extern void XIfEvent(IntPtr display, ref XEvent xevent, Delegate event_predicate, IntPtr arg) { }
}
