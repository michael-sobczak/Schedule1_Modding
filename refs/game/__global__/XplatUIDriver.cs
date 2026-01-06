internal abstract class XplatUIDriver // TypeDefIndex: 5815
{
	// Properties
	internal virtual Size Border3DSize { get; }
	internal virtual Size BorderSize { get; }
	internal virtual Size CaptionButtonSize { get; }
	internal virtual int DoubleClickTime { get; }
	public virtual Size MenuButtonSize { get; }
	internal virtual Keys ModifierKeys { get; }
	internal virtual Point MousePosition { get; }
	internal virtual int MenuHeight { get; }
	internal virtual int HorizontalScrollBarHeight { get; }
	internal virtual bool UserClipWontExposeParent { get; }
	internal virtual int VerticalScrollBarWidth { get; }
	internal abstract int CaptionHeight { get; }
	internal abstract Size DragSize { get; }
	internal abstract Size FrameBorderSize { get; }
	internal abstract bool MenuAccessKeysUnderlined { get; }
	internal virtual Size MinimizedWindowSize { get; }
	internal abstract Size MinimumWindowSize { get; }
	internal virtual Size MinimumFixedToolWindowSize { get; }
	internal virtual Size MinimumSizeableToolWindowSize { get; }
	internal virtual Size MinimumNoBorderWindowSize { get; }
	internal virtual Size MinWindowTrackSize { get; }
	internal abstract Rectangle VirtualScreen { get; }
	internal abstract Rectangle WorkingArea { get; }
	internal abstract bool ThemesEnabled { get; }
	internal virtual bool RequiresPositiveClientAreaSize { get; }
	public virtual int ToolWindowCaptionHeight { get; }
	public virtual Size ToolWindowCaptionButtonSize { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract IntPtr InitializeDriver();

	// RVA: 0x228C8B0 Offset: 0x228B2B0 VA: 0x18228C8B0 Slot: 5
	internal virtual Size get_Border3DSize() { }

	// RVA: 0x2222480 Offset: 0x2220E80 VA: 0x182222480 Slot: 6
	internal virtual Size get_BorderSize() { }

	// RVA: 0x22BC7B0 Offset: 0x22BB1B0 VA: 0x1822BC7B0 Slot: 7
	internal virtual Size get_CaptionButtonSize() { }

	// RVA: 0x22BC7E0 Offset: 0x22BB1E0 VA: 0x1822BC7E0 Slot: 8
	internal virtual int get_DoubleClickTime() { }

	// RVA: 0x22BC7B0 Offset: 0x22BB1B0 VA: 0x1822BC7B0 Slot: 9
	public virtual Size get_MenuButtonSize() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	internal virtual Keys get_ModifierKeys() { }

	// RVA: 0x22BC920 Offset: 0x22BB320 VA: 0x1822BC920 Slot: 11
	internal virtual Point get_MousePosition() { }

	// RVA: 0x228C8A0 Offset: 0x228B2A0 VA: 0x18228C8A0 Slot: 12
	internal virtual int get_MenuHeight() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 13
	internal virtual int get_HorizontalScrollBarHeight() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	internal virtual bool get_UserClipWontExposeParent() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 15
	internal virtual int get_VerticalScrollBarWidth() { }

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract int get_CaptionHeight();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Size get_DragSize();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract Size get_FrameBorderSize();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract bool get_MenuAccessKeysUnderlined();

	// RVA: 0x22BC820 Offset: 0x22BB220 VA: 0x1822BC820 Slot: 20
	internal virtual Size get_MinimizedWindowSize() { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract Size get_MinimumWindowSize();

	// RVA: 0x22BC860 Offset: 0x22BB260 VA: 0x1822BC860 Slot: 22
	internal virtual Size get_MinimumFixedToolWindowSize() { }

	// RVA: 0x22BC8E0 Offset: 0x22BB2E0 VA: 0x1822BC8E0 Slot: 23
	internal virtual Size get_MinimumSizeableToolWindowSize() { }

	// RVA: 0x22BC8A0 Offset: 0x22BB2A0 VA: 0x1822BC8A0 Slot: 24
	internal virtual Size get_MinimumNoBorderWindowSize() { }

	// RVA: 0x22BC7F0 Offset: 0x22BB1F0 VA: 0x1822BC7F0 Slot: 25
	internal virtual Size get_MinWindowTrackSize() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Rectangle get_VirtualScreen();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract Rectangle get_WorkingArea();

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract bool get_ThemesEnabled();

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 29
	internal virtual bool get_RequiresPositiveClientAreaSize() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 30
	public virtual int get_ToolWindowCaptionHeight() { }

	// RVA: 0x22BC960 Offset: 0x22BB360 VA: 0x1822BC960 Slot: 31
	public virtual Size get_ToolWindowCaptionButtonSize() { }

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void AudibleAlert(AlertType alert);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract void GetDisplaySize(out Size size);

	// RVA: -1 Offset: -1 Slot: 34
	internal abstract IntPtr CreateWindow(CreateParams cp);

	// RVA: -1 Offset: -1 Slot: 35
	internal abstract void DestroyWindow(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 36
	internal abstract FormWindowState GetWindowState(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 37
	internal abstract void SetWindowState(IntPtr handle, FormWindowState state);

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max);

	// RVA: -1 Offset: -1 Slot: 39
	internal abstract void SetWindowStyle(IntPtr handle, CreateParams cp);

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void SetWindowTransparency(IntPtr handle, double transparency, Color key);

	// RVA: -1 Offset: -1 Slot: 41
	internal abstract TransparencySupport SupportsTransparency();

	// RVA: 0x22BC700 Offset: 0x22BB100 VA: 0x1822BC700 Slot: 42
	internal virtual void SetAllowDrop(IntPtr handle, bool value) { }

	// RVA: -1 Offset: -1 Slot: 43
	internal abstract void SetBorderStyle(IntPtr handle, FormBorderStyle border_style);

	// RVA: -1 Offset: -1 Slot: 44
	internal abstract void SetMenu(IntPtr handle, Menu menu);

	// RVA: -1 Offset: -1 Slot: 45
	internal abstract bool Text(IntPtr handle, string text);

	// RVA: -1 Offset: -1 Slot: 46
	internal abstract bool SetVisible(IntPtr handle, bool visible, bool activate);

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract bool IsEnabled(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract IntPtr SetParent(IntPtr handle, IntPtr parent);

	// RVA: -1 Offset: -1 Slot: 49
	internal abstract IntPtr GetParent(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 50
	internal abstract void UpdateWindow(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 51
	internal abstract PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client);

	// RVA: -1 Offset: -1 Slot: 52
	internal abstract void PaintEventEnd(ref Message msg, IntPtr handle, bool client);

	// RVA: -1 Offset: -1 Slot: 53
	internal abstract void SetWindowPos(IntPtr handle, int x, int y, int width, int height);

	// RVA: -1 Offset: -1 Slot: 54
	internal abstract void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height);

	// RVA: -1 Offset: -1 Slot: 55
	internal abstract void Activate(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 56
	internal abstract void EnableWindow(IntPtr handle, bool Enable);

	// RVA: -1 Offset: -1 Slot: 57
	internal abstract void SetModal(IntPtr handle, bool Modal);

	// RVA: -1 Offset: -1 Slot: 58
	internal abstract void Invalidate(IntPtr handle, Rectangle rc, bool clear);

	// RVA: -1 Offset: -1 Slot: 59
	internal abstract void InvalidateNC(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 60
	internal abstract IntPtr DefWndProc(ref Message msg);

	// RVA: -1 Offset: -1 Slot: 61
	internal abstract void DoEvents();

	// RVA: -1 Offset: -1 Slot: 62
	internal abstract bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags);

	// RVA: -1 Offset: -1 Slot: 63
	internal abstract void PostQuitMessage(int exitCode);

	// RVA: -1 Offset: -1 Slot: 64
	internal abstract bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax);

	// RVA: -1 Offset: -1 Slot: 65
	internal abstract bool TranslateMessage(ref MSG msg);

	// RVA: -1 Offset: -1 Slot: 66
	internal abstract IntPtr DispatchMessage(ref MSG msg);

	// RVA: -1 Offset: -1 Slot: 67
	internal abstract bool SetZOrder(IntPtr hWnd, IntPtr AfterhWnd, bool Top, bool Bottom);

	// RVA: -1 Offset: -1 Slot: 68
	internal abstract bool SetTopmost(IntPtr hWnd, bool Enabled);

	// RVA: -1 Offset: -1 Slot: 69
	internal abstract bool SetOwner(IntPtr hWnd, IntPtr hWndOwner);

	// RVA: -1 Offset: -1 Slot: 70
	internal abstract bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect);

	// RVA: -1 Offset: -1 Slot: 71
	internal abstract void SetClipRegion(IntPtr hwnd, Region region);

	// RVA: -1 Offset: -1 Slot: 72
	internal abstract void SetCursor(IntPtr hwnd, IntPtr cursor);

	// RVA: -1 Offset: -1 Slot: 73
	internal abstract IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot);

	// RVA: -1 Offset: -1 Slot: 74
	internal abstract IntPtr DefineStdCursor(StdCursor id);

	// RVA: -1 Offset: -1 Slot: 75
	internal abstract void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y);

	// RVA: -1 Offset: -1 Slot: 76
	internal abstract void GetCursorPos(IntPtr hwnd, out int x, out int y);

	// RVA: -1 Offset: -1 Slot: 77
	internal abstract void SetCursorPos(IntPtr hwnd, int x, int y);

	// RVA: -1 Offset: -1 Slot: 78
	internal abstract void ScreenToClient(IntPtr hwnd, ref int x, ref int y);

	// RVA: -1 Offset: -1 Slot: 79
	internal abstract void ClientToScreen(IntPtr hwnd, ref int x, ref int y);

	// RVA: -1 Offset: -1 Slot: 80
	internal abstract void GrabWindow(IntPtr hwnd, IntPtr ConfineToHwnd);

	// RVA: -1 Offset: -1 Slot: 81
	internal abstract void GrabInfo(out IntPtr hwnd, out bool GrabConfined, out Rectangle GrabArea);

	// RVA: -1 Offset: -1 Slot: 82
	internal abstract void UngrabWindow(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 83
	internal abstract void SendAsyncMethod(AsyncMethodData method);

	// RVA: -1 Offset: -1 Slot: 84
	internal abstract void SetTimer(Timer timer);

	// RVA: -1 Offset: -1 Slot: 85
	internal abstract void KillTimer(Timer timer);

	// RVA: -1 Offset: -1 Slot: 86
	internal abstract void CreateCaret(IntPtr hwnd, int width, int height);

	// RVA: -1 Offset: -1 Slot: 87
	internal abstract void DestroyCaret(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 88
	internal abstract void SetCaretPos(IntPtr hwnd, int x, int y);

	// RVA: -1 Offset: -1 Slot: 89
	internal abstract void CaretVisible(IntPtr hwnd, bool visible);

	// RVA: -1 Offset: -1 Slot: 90
	internal abstract IntPtr GetFocus();

	// RVA: -1 Offset: -1 Slot: 91
	internal abstract void SetFocus(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 92
	internal abstract IntPtr GetActive();

	// RVA: -1 Offset: -1 Slot: 93
	internal abstract IntPtr GetPreviousWindow(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 94
	internal abstract void ScrollWindow(IntPtr hwnd, Rectangle rectangle, int XAmount, int YAmount, bool with_children);

	// RVA: -1 Offset: -1 Slot: 95
	internal abstract void ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, bool with_children);

	// RVA: -1 Offset: -1 Slot: 96
	internal abstract bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent);

	// RVA: -1 Offset: -1 Slot: 97
	internal abstract Point GetMenuOrigin(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 98
	internal abstract void MenuToScreen(IntPtr hwnd, ref int x, ref int y);

	// RVA: -1 Offset: -1 Slot: 99
	internal abstract void ScreenToMenu(IntPtr hwnd, ref int x, ref int y);

	// RVA: -1 Offset: -1 Slot: 100
	internal abstract void SetIcon(IntPtr handle, Icon icon);

	// RVA: -1 Offset: -1 Slot: 101
	internal abstract void ClipboardClose(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 102
	internal abstract IntPtr ClipboardOpen(bool primary_selection);

	// RVA: -1 Offset: -1 Slot: 103
	internal abstract int ClipboardGetID(IntPtr handle, string format);

	// RVA: -1 Offset: -1 Slot: 104
	internal abstract void ClipboardStore(IntPtr handle, object obj, int id, XplatUI.ObjectToClipboard converter);

	// RVA: -1 Offset: -1 Slot: 105
	internal abstract int[] ClipboardAvailableFormats(IntPtr handle);

	// RVA: -1 Offset: -1 Slot: 106
	internal abstract object ClipboardRetrieve(IntPtr handle, int id, XplatUI.ClipboardToObject converter);

	// RVA: -1 Offset: -1 Slot: 107
	internal abstract void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width);

	// RVA: -1 Offset: -1 Slot: 108
	internal abstract SizeF GetAutoScaleSize(Font font);

	// RVA: -1 Offset: -1 Slot: 109
	internal abstract IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

	// RVA: -1 Offset: -1 Slot: 110
	internal abstract bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

	// RVA: -1 Offset: -1 Slot: 111
	internal abstract object StartLoop(Thread thread);

	// RVA: -1 Offset: -1 Slot: 112
	internal abstract void EndLoop(Thread thread);

	// RVA: -1 Offset: -1 Slot: 113
	internal abstract void RequestNCRecalc(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 114
	internal abstract void ResetMouseHover(IntPtr hwnd);

	// RVA: -1 Offset: -1 Slot: 115
	internal abstract void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave);

	// RVA: 0x22BC5C0 Offset: 0x22BAFC0 VA: 0x1822BC5C0 Slot: 116
	internal virtual void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable) { }

	// RVA: 0x22BC640 Offset: 0x22BB040 VA: 0x1822BC640 Slot: 117
	internal virtual void DestroyOffscreenDrawable(object offscreen_drawable) { }

	// RVA: 0x22BC6A0 Offset: 0x22BB0A0 VA: 0x1822BC6A0 Slot: 118
	internal virtual Graphics GetOffscreenGraphics(object offscreen_drawable) { }

	// RVA: 0x22BC520 Offset: 0x22BAF20 VA: 0x1822BC520 Slot: 119
	internal virtual void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r) { }
}
