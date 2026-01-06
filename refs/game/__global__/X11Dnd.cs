internal class X11Dnd // TypeDefIndex: 5723
{
	// Fields
	private X11Dnd.MimeHandler[] MimeHandlers; // 0x10
	private static readonly IntPtr[] XdndVersion; // 0x0
	private IntPtr display; // 0x18
	private X11Dnd.DragData drag_data; // 0x20
	private IntPtr XdndAware; // 0x28
	private IntPtr XdndSelection; // 0x30
	private IntPtr XdndEnter; // 0x38
	private IntPtr XdndLeave; // 0x40
	private IntPtr XdndPosition; // 0x48
	private IntPtr XdndDrop; // 0x50
	private IntPtr XdndFinished; // 0x58
	private IntPtr XdndStatus; // 0x60
	private IntPtr XdndTypeList; // 0x68
	private IntPtr XdndActionCopy; // 0x70
	private IntPtr XdndActionMove; // 0x78
	private IntPtr XdndActionLink; // 0x80
	private IntPtr XdndActionList; // 0x88
	private int converts_pending; // 0x90
	private bool position_recieved; // 0x94
	private bool status_sent; // 0x95
	private IntPtr target; // 0x98
	private IntPtr source; // 0xA0
	private IntPtr toplevel; // 0xA8
	private IDataObject data; // 0xB0
	private Control control; // 0xB8
	private int pos_x; // 0xC0
	private int pos_y; // 0xC4
	private DragDropEffects allowed; // 0xC8
	private DragEventArgs drag_event; // 0xD0
	private Cursor CursorNo; // 0xD8
	private Cursor CursorCopy; // 0xE0
	private Cursor CursorMove; // 0xE8
	private Cursor CursorLink; // 0xF0
	private bool tracking; // 0xF8
	private bool dropped; // 0xF9

	// Methods

	// RVA: 0x22750E0 Offset: 0x2273AE0 VA: 0x1822750E0
	public void .ctor(IntPtr display, X11Keyboard keyboard) { }

	// RVA: 0x2275030 Offset: 0x2273A30 VA: 0x182275030
	private static void .cctor() { }

	// RVA: 0x22748E0 Offset: 0x22732E0 VA: 0x1822748E0
	public void SetAllowDrop(Hwnd hwnd, bool allow) { }

	// RVA: 0x22734F0 Offset: 0x2271EF0 VA: 0x1822734F0
	public bool HandleClientMessage(ref XEvent xevent) { }

	// RVA: 0x2273870 Offset: 0x2272270 VA: 0x182273870
	public bool HandleSelectionNotifyEvent(ref XEvent xevent) { }

	// RVA: 0x2273A50 Offset: 0x2272450 VA: 0x182273A50
	public bool HandleSelectionRequestEvent(ref XEvent xevent) { }

	// RVA: 0x22740D0 Offset: 0x2272AD0 VA: 0x1822740D0
	private bool QueryContinue(bool escape, DragAction action) { }

	// RVA: 0x22744C0 Offset: 0x2272EC0 VA: 0x1822744C0
	private void RestoreDefaultCursor() { }

	// RVA: 0x2273360 Offset: 0x2271D60 VA: 0x182273360
	private void GiveFeedback(IntPtr action) { }

	// RVA: 0x2274C10 Offset: 0x2273610 VA: 0x182274C10
	private void SetProperty(ref XEvent xevent, IntPtr data, int length) { }

	// RVA: 0x2274480 Offset: 0x2272E80 VA: 0x182274480
	private void Reset() { }

	// RVA: 0x2274450 Offset: 0x2272E50 VA: 0x182274450
	private void ResetSourceData() { }

	// RVA: 0x2274470 Offset: 0x2272E70 VA: 0x182274470
	private void ResetTargetData() { }

	// RVA: 0x2271FC0 Offset: 0x22709C0 VA: 0x182271FC0
	private bool Accepting_HandleEnterEvent(ref XEvent xevent) { }

	// RVA: 0x2272090 Offset: 0x2270A90 VA: 0x182272090
	private bool Accepting_HandlePositionEvent(ref XEvent xevent) { }

	// RVA: 0x2272D10 Offset: 0x2271710 VA: 0x182272D10
	private void Finish() { }

	// RVA: 0x2271DC0 Offset: 0x22707C0 VA: 0x182271DC0
	private bool Accepting_HandleDropEvent(ref XEvent xevent) { }

	// RVA: 0x2272040 Offset: 0x2270A40 VA: 0x182272040
	private bool Accepting_HandleLeaveEvent(ref XEvent xevent) { }

	// RVA: 0x2273B00 Offset: 0x2272500 VA: 0x182273B00
	private bool HandleStatusEvent(ref XEvent xevent) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool HandleFinishedEvent(ref XEvent xevent) { }

	// RVA: 0x22729D0 Offset: 0x22713D0 VA: 0x1822729D0
	private DragDropEffects EffectsFromX11Source(IntPtr source, IntPtr action_atom) { }

	// RVA: 0x2272950 Offset: 0x2271350 VA: 0x182272950
	private DragDropEffects EffectFromAction(IntPtr action) { }

	// RVA: 0x22725E0 Offset: 0x2270FE0 VA: 0x1822725E0
	private IntPtr ActionFromEffect(DragDropEffects effect) { }

	// RVA: 0x2272610 Offset: 0x2271010 VA: 0x182272610
	private bool ConvertData(ref XEvent xevent) { }

	// RVA: 0x2274AE0 Offset: 0x22734E0 VA: 0x182274AE0
	private void SetDataWithFormats(object value) { }

	// RVA: 0x2272C70 Offset: 0x2271670 VA: 0x182272C70
	private X11Dnd.MimeHandler FindHandler(IntPtr atom) { }

	// RVA: 0x22747C0 Offset: 0x22731C0 VA: 0x1822747C0
	private void SendStatus(IntPtr source, DragDropEffects effect) { }

	// RVA: 0x2274540 Offset: 0x2272F40 VA: 0x182274540
	private void SendDrop(IntPtr handle, IntPtr from, IntPtr time) { }

	// RVA: 0x22746F0 Offset: 0x22730F0 VA: 0x1822746F0
	private void SendLeave(IntPtr handle, IntPtr from) { }

	// RVA: 0x2274620 Offset: 0x2273020 VA: 0x182274620
	private void SendFinished() { }

	// RVA: 0x2273CE0 Offset: 0x22726E0 VA: 0x182273CE0
	private void Init() { }

	// RVA: 0x2274D60 Offset: 0x2273760 VA: 0x182274D60
	private IntPtr[] SourceSupportedList(ref XEvent xevent) { }

	// RVA: 0x22730F0 Offset: 0x2271AF0 VA: 0x1822730F0
	private string GetText(ref XEvent xevent, bool unicode) { }

	// RVA: 0x2272E90 Offset: 0x2271890 VA: 0x182272E90
	private MemoryStream GetData(ref XEvent xevent) { }

	// RVA: 0x2274010 Offset: 0x2272A10 VA: 0x182274010
	private Control MwfWindow(IntPtr window) { }
}
