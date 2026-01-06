internal class ControlHandler : EventHandlerBase, IEventHandler // TypeDefIndex: 5869
{
	// Methods

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(XplatUICarbon driver) { }

	// RVA: 0x22B1910 Offset: 0x22B0310 VA: 0x1822B1910 Slot: 4
	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22B1430 Offset: 0x22AFE30 VA: 0x1822B1430
	private void DrawBorders(Hwnd hwnd) { }

	// RVA: 0x22B16E0 Offset: 0x22B00E0 VA: 0x1822B16E0
	private static extern int GetRegionBounds(IntPtr rgnhandle, ref Rect region) { }

	// RVA: 0x22B1610 Offset: 0x22B0010 VA: 0x1822B1610
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data) { }

	// RVA: 0x22B1FA0 Offset: 0x22B09A0 VA: 0x1822B1FA0
	private static extern int SetEventParameter(IntPtr eventref, uint name, uint type, uint size, ref short data) { }

	// RVA: 0x22B1770 Offset: 0x22B0170 VA: 0x1822B1770
	private static extern int HIViewGetBounds(IntPtr handle, ref HIRect rect) { }

	// RVA: 0x22B1800 Offset: 0x22B0200 VA: 0x1822B1800
	private static extern int HIViewGetFrame(IntPtr handle, ref HIRect rect) { }

	// RVA: 0x22B1890 Offset: 0x22B0290 VA: 0x1822B1890
	private static extern bool HIViewIsVisible(IntPtr vHnd) { }
}
