internal class HIObjectHandler : EventHandlerBase, IEventHandler // TypeDefIndex: 5879
{
	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XplatUICarbon driver) { }

	// RVA: 0x22DAA60 Offset: 0x22D9460 VA: 0x1822DAA60 Slot: 4
	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22DA900 Offset: 0x22D9300 VA: 0x1822DA900
	private static extern int CallNextEventHandler(IntPtr callref, IntPtr eventref) { }

	// RVA: 0x22DA990 Offset: 0x22D9390 VA: 0x1822DA990
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data) { }
}
