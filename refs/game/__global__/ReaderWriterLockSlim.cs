public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 15669
{
	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private const int LockSpinCycles = 20;
	private const int LockSpinCount = 10;
	private const int LockSleep0Count = 5;
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStatic]
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private const int MaxSpinCount = 20;
	private uint owners; // 0x64
	private const uint WRITER_HELD = 2147483648;
	private const uint WAITING_WRITERS = 1073741824;
	private const uint WAITING_UPGRADER = 536870912;
	private const uint MAX_READER = 268435454;
	private const uint READER_MASK = 268435455;
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x2005F40 Offset: 0x2004940 VA: 0x182005F40
	private void InitializeThreadCounts() { }

	// RVA: 0x2007190 Offset: 0x2005B90 VA: 0x182007190
	public void .ctor() { }

	// RVA: 0x2007120 Offset: 0x2005B20 VA: 0x182007120
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x2005F50 Offset: 0x2004950 VA: 0x182005F50
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x2005F90 Offset: 0x2004990 VA: 0x182005F90
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x2005E00 Offset: 0x2004800 VA: 0x182005E00
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x20054C0 Offset: 0x2003EC0 VA: 0x1820054C0
	public void EnterReadLock() { }

	// RVA: 0x2006500 Offset: 0x2004F00 VA: 0x182006500
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	// RVA: 0x2006590 Offset: 0x2004F90 VA: 0x182006590
	private bool TryEnterReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2006180 Offset: 0x2004B80 VA: 0x182006180
	private bool TryEnterReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2005500 Offset: 0x2003F00 VA: 0x182005500
	public void EnterWriteLock() { }

	// RVA: 0x2006F60 Offset: 0x2005960 VA: 0x182006F60
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x2006F50 Offset: 0x2005950 VA: 0x182006F50
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2006AA0 Offset: 0x20054A0 VA: 0x182006AA0
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x20054E0 Offset: 0x2003EE0 VA: 0x1820054E0
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x2006A10 Offset: 0x2005410 VA: 0x182006A10
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x2006A00 Offset: 0x2005400 VA: 0x182006A00
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x20065A0 Offset: 0x2004FA0 VA: 0x1820065A0
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x2005710 Offset: 0x2004110 VA: 0x182005710
	public void ExitReadLock() { }

	// RVA: 0x2005BF0 Offset: 0x20045F0 VA: 0x182005BF0
	public void ExitWriteLock() { }

	// RVA: 0x20058F0 Offset: 0x20042F0 VA: 0x1820058F0
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x2005FC0 Offset: 0x20049C0 VA: 0x182005FC0
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x2006FF0 Offset: 0x20059F0 VA: 0x182006FF0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x2005650 Offset: 0x2004050 VA: 0x182005650
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x20055C0 Offset: 0x2003FC0 VA: 0x1820055C0
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x2005520 Offset: 0x2003F20 VA: 0x182005520
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x2005FB0 Offset: 0x20049B0 VA: 0x182005FB0
	private bool IsWriterAcquired() { }

	// RVA: 0x20060E0 Offset: 0x2004AE0 VA: 0x1820060E0
	private void SetWriterAcquired() { }

	// RVA: 0x2005060 Offset: 0x2003A60 VA: 0x182005060
	private void ClearWriterAcquired() { }

	// RVA: 0x20060F0 Offset: 0x2004AF0 VA: 0x1820060F0
	private void SetWritersWaiting() { }

	// RVA: 0x2005070 Offset: 0x2003A70 VA: 0x182005070
	private void ClearWritersWaiting() { }

	// RVA: 0x20060D0 Offset: 0x2004AD0 VA: 0x1820060D0
	private void SetUpgraderWaiting() { }

	// RVA: 0x2005050 Offset: 0x2003A50 VA: 0x182005050
	private void ClearUpgraderWaiting() { }

	// RVA: 0x2005DF0 Offset: 0x20047F0 VA: 0x182005DF0
	private uint GetNumReaders() { }

	// RVA: 0x2005480 Offset: 0x2003E80 VA: 0x182005480
	private void EnterMyLock() { }

	// RVA: 0x20053C0 Offset: 0x2003DC0 VA: 0x1820053C0
	private void EnterMyLockSpin() { }

	// RVA: 0x20056F0 Offset: 0x20040F0 VA: 0x1820056F0
	private void ExitMyLock() { }

	// RVA: 0x2006100 Offset: 0x2004B00 VA: 0x182006100
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x20053B0 Offset: 0x2003DB0 VA: 0x1820053B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2005080 Offset: 0x2003A80 VA: 0x182005080
	private void Dispose(bool disposing) { }

	// RVA: 0x20071F0 Offset: 0x2005BF0 VA: 0x1820071F0
	public bool get_IsReadLockHeld() { }

	// RVA: 0x2007270 Offset: 0x2005C70 VA: 0x182007270
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x2007310 Offset: 0x2005D10 VA: 0x182007310
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x20073B0 Offset: 0x2005DB0 VA: 0x1820073B0
	public int get_RecursiveReadCount() { }

	// RVA: 0x2007420 Offset: 0x2005E20 VA: 0x182007420
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x20074E0 Offset: 0x2005EE0 VA: 0x1820074E0
	public int get_RecursiveWriteCount() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_WaitingReadCount() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_WaitingWriteCount() { }
}
