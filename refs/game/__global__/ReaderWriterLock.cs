public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 3995
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x1CF3C40 Offset: 0x1CF2640 VA: 0x181CF3C40
	public void .ctor() { }

	// RVA: 0x1CE5D20 Offset: 0x1CE4720 VA: 0x181CE5D20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CF3A70 Offset: 0x1CF2470 VA: 0x181CF3A70
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x1CF38E0 Offset: 0x1CF22E0 VA: 0x181CF38E0
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF3AB0 Offset: 0x1CF24B0 VA: 0x181CF3AB0
	public void ReleaseWriterLock() { }

	// RVA: 0x1CF3BE0 Offset: 0x1CF25E0 VA: 0x181CF3BE0
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x1CF3A80 Offset: 0x1CF2480 VA: 0x181CF3A80
	private bool HasWriterLock() { }
}
