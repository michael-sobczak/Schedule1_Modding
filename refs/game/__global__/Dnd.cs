internal class Dnd // TypeDefIndex: 5872
{
	// Fields
	private static DragDropEffects effects; // 0x0
	private static DragTrackingDelegate DragTrackingHandler; // 0x8

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x22B41A0 Offset: 0x22B2BA0 VA: 0x1822B41A0
	private static void .cctor() { }

	// RVA: 0x22B4140 Offset: 0x22B2B40 VA: 0x1822B4140
	internal static void TrackingCallback(short message, IntPtr window, IntPtr data, IntPtr dragref) { }

	// RVA: 0x22B3400 Offset: 0x22B1E00 VA: 0x1822B3400
	internal static DragDropEffects DragActionsToEffects(uint actions) { }

	// RVA: 0x22B3420 Offset: 0x22B1E20 VA: 0x1822B3420
	internal static DataObject DragToDataObject(IntPtr dragref) { }

	// RVA: 0x22B3990 Offset: 0x22B2390 VA: 0x1822B3990
	internal static bool HandleEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22B3F50 Offset: 0x22B2950 VA: 0x1822B3F50
	public void SetAllowDrop(Hwnd hwnd, bool allow) { }

	// RVA: 0x22B3EB0 Offset: 0x22B28B0 VA: 0x1822B3EB0
	private static extern int InstallTrackingHandler(DragTrackingDelegate callback, IntPtr window, IntPtr data) { }

	// RVA: 0x22B38C0 Offset: 0x22B22C0 VA: 0x1822B38C0
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data) { }

	// RVA: 0x22B4070 Offset: 0x22B2A70 VA: 0x1822B4070
	private static extern int SetEventParameter(IntPtr eventref, uint name, uint type, uint size, ref bool data) { }

	// RVA: 0x22B3FE0 Offset: 0x22B29E0 VA: 0x1822B3FE0
	private static extern int SetControlDragTrackingEnabled(IntPtr view, bool enabled) { }

	// RVA: 0x22B3370 Offset: 0x22B1D70 VA: 0x1822B3370
	private static extern int CountDragItems(IntPtr dragref, ref uint count) { }

	// RVA: 0x22B32D0 Offset: 0x22B1CD0 VA: 0x1822B32D0
	private static extern int CountDragItemFlavors(IntPtr dragref, IntPtr itemref, ref uint count) { }

	// RVA: 0x22B3820 Offset: 0x22B2220 VA: 0x1822B3820
	private static extern int GetDragItemReferenceNumber(IntPtr dragref, uint index, ref IntPtr itemref) { }

	// RVA: 0x22B3790 Offset: 0x22B2190 VA: 0x1822B3790
	private static extern int GetDragAllowableActions(IntPtr dragref, ref uint actions) { }
}
