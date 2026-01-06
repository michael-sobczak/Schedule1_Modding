public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 3752
{
	// Fields
	private object _exception; // 0x10
	private bool _isTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x1C94510 Offset: 0x1C92F10 VA: 0x181C94510
	public void .ctor(object exception, bool isTerminating) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public object get_ExceptionObject() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsTerminating() { }
}
