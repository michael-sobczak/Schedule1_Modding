internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 3984
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x1D03330 Offset: 0x1D01D30 VA: 0x181D03330
	public void .ctor() { }

	// RVA: 0x1D02F20 Offset: 0x1D01920 VA: 0x181D02F20
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x1D03150 Offset: 0x1D01B50 VA: 0x181D03150
	internal void EnsureThreadRequested() { }

	// RVA: 0x1D03250 Offset: 0x1D01C50 VA: 0x181D03250
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x1D02D00 Offset: 0x1D01700 VA: 0x181D02D00
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x1D031F0 Offset: 0x1D01BF0 VA: 0x181D031F0
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x1D02570 Offset: 0x1D00F70 VA: 0x181D02570
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x1D028D0 Offset: 0x1D012D0 VA: 0x181D028D0
	internal static bool Dispatch() { }

	// RVA: 0x1D032A0 Offset: 0x1D01CA0 VA: 0x181D032A0
	private static void .cctor() { }
}
