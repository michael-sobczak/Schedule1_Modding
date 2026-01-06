internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 3987
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x1CF3240 Offset: 0x1CF1C40 VA: 0x181CF3240
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CF3040 Offset: 0x1CF1A40 VA: 0x181CF3040 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1CF3130 Offset: 0x1CF1B30 VA: 0x181CF3130
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x1CF31B0 Offset: 0x1CF1BB0 VA: 0x181CF31B0
	private static void .cctor() { }
}
