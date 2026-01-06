internal class LockQueue // TypeDefIndex: 3992
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x1CF1770 Offset: 0x1CF0170 VA: 0x181CF1770
	public bool Wait(int timeout) { }

	// RVA: 0x1CF18A0 Offset: 0x1CF02A0 VA: 0x181CF18A0
	public bool get_IsEmpty() { }

	// RVA: 0x1CF16E0 Offset: 0x1CF00E0 VA: 0x181CF16E0
	public void Pulse() { }
}
