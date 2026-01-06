internal class WindowHandler : EventHandlerBase, IEventHandler // TypeDefIndex: 5894
{
	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XplatUICarbon driver) { }

	// RVA: 0x22E88B0 Offset: 0x22E72B0 VA: 0x1822E88B0 Slot: 4
	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22E8780 Offset: 0x22E7180 VA: 0x1822E8780
	private static extern int GetWindowBounds(IntPtr handle, uint region, ref Rect bounds) { }

	// RVA: 0x22E8820 Offset: 0x22E7220 VA: 0x1822E8820
	private static extern int HIViewSetFrame(IntPtr handle, ref HIRect bounds) { }
}
