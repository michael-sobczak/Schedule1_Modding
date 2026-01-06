internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 11856
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x2CD16F0 Offset: 0x2CD00F0 VA: 0x182CD16F0
	private void .ctor(int mainThreadID) { }

	// RVA: 0x2CD1630 Offset: 0x2CD0030 VA: 0x182CD1630
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2CD1350 Offset: 0x2CCFD50 VA: 0x182CD1350 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x2CD1150 Offset: 0x2CCFB50 VA: 0x182CD1150 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x2CD1140 Offset: 0x2CCFB40 VA: 0x182CD1140 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x2CD1160 Offset: 0x2CCFB60 VA: 0x182CD1160 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x2CD0B30 Offset: 0x2CCF530 VA: 0x182CD0B30 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2CD0C10 Offset: 0x2CCF610 VA: 0x182CD0C10
	public void Exec() { }

	// RVA: 0x2CD0FC0 Offset: 0x2CCF9C0 VA: 0x182CD0FC0
	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x2CD1020 Offset: 0x2CCFA20 VA: 0x182CD1020
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCode]
	// RVA: 0x2CD0F60 Offset: 0x2CCF960 VA: 0x182CD0F60
	private static void ExecuteTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x2CD0E00 Offset: 0x2CCF800 VA: 0x182CD0E00
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}
