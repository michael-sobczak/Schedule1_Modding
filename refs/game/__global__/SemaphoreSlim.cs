public class SemaphoreSlim : IDisposable // TypeDefIndex: 3955
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static readonly Task<bool> s_falseTask; // 0x8
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x10

	// Methods

	// RVA: 0x1CE3CB0 Offset: 0x1CE26B0 VA: 0x181CE3CB0
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x1CE3B30 Offset: 0x1CE2530 VA: 0x181CE3B30
	public void Wait() { }

	// RVA: 0x1CE3450 Offset: 0x1CE1E50 VA: 0x181CE3450
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CE3330 Offset: 0x1CE1D30 VA: 0x181CE3330
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x1CE2C10 Offset: 0x1CE1610 VA: 0x181CE2C10
	public Task WaitAsync() { }

	// RVA: 0x1CE2C20 Offset: 0x1CE1620 VA: 0x181CE2C20
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CE2530 Offset: 0x1CE0F30 VA: 0x181CE2530
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1CE2B20 Offset: 0x1CE1520 VA: 0x181CE2B20
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachine(typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32))]
	// RVA: 0x1CE31E0 Offset: 0x1CE1BE0 VA: 0x181CE31E0
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CE2B10 Offset: 0x1CE1510 VA: 0x181CE2B10
	public int Release() { }

	// RVA: 0x1CE2740 Offset: 0x1CE1140 VA: 0x181CE2740
	public int Release(int releaseCount) { }

	// RVA: 0x1CE2730 Offset: 0x1CE1130 VA: 0x181CE2730
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1CE2600 Offset: 0x1CE1000 VA: 0x181CE2600 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CE2670 Offset: 0x1CE1070 VA: 0x181CE2670 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CE22A0 Offset: 0x1CE0CA0 VA: 0x181CE22A0
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1CE24A0 Offset: 0x1CE0EA0 VA: 0x181CE24A0
	private void CheckDispose() { }

	// RVA: 0x1CE2720 Offset: 0x1CE1120 VA: 0x181CE2720
	private static string GetResourceString(string str) { }

	// RVA: 0x1CE3B40 Offset: 0x1CE2540 VA: 0x181CE3B40
	private static void .cctor() { }
}
