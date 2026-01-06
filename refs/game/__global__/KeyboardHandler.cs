internal class KeyboardHandler : EventHandlerBase, IEventHandler // TypeDefIndex: 5881
{
	// Fields
	internal static byte[] key_filter_table; // 0x0
	internal static byte[] key_modifier_table; // 0x8
	internal static byte[] key_translation_table; // 0x10
	internal static byte[] char_translation_table; // 0x18
	internal static bool translate_modifier; // 0x20
	internal string ComposedString; // 0x18

	// Properties
	internal Keys ModifierKeys { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XplatUICarbon driver) { }

	// RVA: 0x22DC230 Offset: 0x22DAC30 VA: 0x1822DC230
	private static void .cctor() { }

	// RVA: 0x22DB440 Offset: 0x22D9E40 VA: 0x1822DB440
	private void ModifierToVirtualKey(int i, ref MSG msg, bool down) { }

	// RVA: 0x22DB9C0 Offset: 0x22DA3C0 VA: 0x1822DB9C0
	public void ProcessModifiers(IntPtr eventref, ref MSG msg) { }

	// RVA: 0x22DBCC0 Offset: 0x22DA6C0 VA: 0x1822DBCC0
	public void ProcessText(IntPtr eventref, ref MSG msg) { }

	// RVA: 0x22DB6E0 Offset: 0x22DA0E0 VA: 0x1822DB6E0
	public void ProcessKeyPress(IntPtr eventref, ref MSG msg) { }

	// RVA: 0x22DB550 Offset: 0x22D9F50 VA: 0x1822DB550 Slot: 4
	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg) { }

	// RVA: 0x22DBFA0 Offset: 0x22DA9A0 VA: 0x1822DBFA0
	public bool TranslateMessage(ref MSG msg) { }

	// RVA: 0x22DC400 Offset: 0x22DAE00 VA: 0x1822DC400
	internal Keys get_ModifierKeys() { }

	// RVA: 0x22DB370 Offset: 0x22D9D70 VA: 0x1822DB370
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, ref uint outsize, IntPtr data) { }

	// RVA: 0x22DB1D0 Offset: 0x22D9BD0 VA: 0x1822DB1D0
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, IntPtr data) { }

	// RVA: 0x22DB2A0 Offset: 0x22D9CA0 VA: 0x1822DB2A0
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref byte data) { }

	// RVA: 0x22DB100 Offset: 0x22D9B00 VA: 0x1822DB100
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref uint data) { }
}
