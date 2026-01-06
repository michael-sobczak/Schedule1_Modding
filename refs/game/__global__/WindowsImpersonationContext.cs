public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 4263
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x1B20A00 Offset: 0x1B1F400 VA: 0x181B20A00
	internal void .ctor(IntPtr token) { }

	[ComVisible(False)]
	// RVA: 0x1B20860 Offset: 0x1B1F260 VA: 0x181B20860 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B20950 Offset: 0x1B1F350 VA: 0x181B20950
	public void Undo() { }

	// RVA: 0x1B20850 Offset: 0x1B1F250 VA: 0x181B20850
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x1B20920 Offset: 0x1B1F320 VA: 0x181B20920
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x1B20940 Offset: 0x1B1F340 VA: 0x181B20940
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x1B20930 Offset: 0x1B1F330 VA: 0x181B20930
	private static bool RevertToSelf() { }
}
