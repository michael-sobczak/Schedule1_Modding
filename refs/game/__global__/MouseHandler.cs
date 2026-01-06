internal class MouseHandler : EventHandlerBase, IEventHandler // TypeDefIndex: 5882
{
	// Fields
	internal static ClickStruct ClickPending; // 0x0

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XplatUICarbon driver) { }

	// RVA: 0x22DDFC0 Offset: 0x22DC9C0 VA: 0x1822DDFC0 Slot: 4
	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22DEBA0 Offset: 0x22DD5A0 VA: 0x1822DEBA0
	internal bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x22DEE10 Offset: 0x22DD810 VA: 0x1822DEE10
	private void UpdateMouseState(int button, bool down) { }

	// RVA: 0x22DDA40 Offset: 0x22DC440 VA: 0x1822DDA40
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref QDPoint data) { }

	// RVA: 0x22DDBE0 Offset: 0x22DC5E0 VA: 0x1822DDBE0
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref int data) { }

	// RVA: 0x22DDB10 Offset: 0x22DC510 VA: 0x1822DDB10
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref ushort data) { }

	// RVA: 0x22DD9B0 Offset: 0x22DC3B0 VA: 0x1822DD9B0
	internal static extern short FindWindow(QDPoint point, ref IntPtr handle) { }

	// RVA: 0x22DDCB0 Offset: 0x22DC6B0 VA: 0x1822DDCB0
	internal static extern int GetWindowBounds(IntPtr handle, uint region, ref Rect bounds) { }

	// RVA: 0x22DDD50 Offset: 0x22DC750 VA: 0x1822DDD50
	internal static extern int HIViewConvertPoint(ref CGPoint point, IntPtr source_view, IntPtr target_view) { }

	// RVA: 0x22DDE90 Offset: 0x22DC890 VA: 0x1822DDE90
	internal static extern IntPtr HIViewGetRoot(IntPtr handle) { }

	// RVA: 0x22DDF10 Offset: 0x22DC910 VA: 0x1822DDF10
	internal static extern int HIViewGetSubviewHit(IntPtr content_view, ref CGPoint point, bool tval, ref IntPtr hit_view) { }

	// RVA: 0x22DDDF0 Offset: 0x22DC7F0 VA: 0x1822DDDF0
	internal static extern int HIViewFindByID(IntPtr root_window, HIViewID id, ref IntPtr view_handle) { }
}
