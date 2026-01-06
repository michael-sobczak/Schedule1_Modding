public static class ThreadPool // TypeDefIndex: 3989
{
	// Properties
	internal static bool IsThreadPoolThread { get; }

	// Methods

	// RVA: 0x1D03490 Offset: 0x1D01E90 VA: 0x181D03490
	public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x1D03810 Offset: 0x1D02210 VA: 0x181D03810
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1D03690 Offset: 0x1D02090 VA: 0x181D03690
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1D03660 Offset: 0x1D02060 VA: 0x181D03660
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1D03630 Offset: 0x1D02030 VA: 0x181D03630
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x1D03C30 Offset: 0x1D02630 VA: 0x181D03C30
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: -1 Offset: -1
	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF60EF0 Offset: 0xF5F8F0 VA: 0x180F60EF0
	|-ThreadPool.QueueUserWorkItem<object>
	|
	|-RVA: 0xF60D40 Offset: 0xF5F740 VA: 0x180F60D40
	|-ThreadPool.QueueUserWorkItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D034D0 Offset: 0x1D01ED0 VA: 0x181D034D0
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = True) { }

	// RVA: 0x1D03BB0 Offset: 0x1D025B0 VA: 0x181D03BB0
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x1D03AC0 Offset: 0x1D024C0 VA: 0x181D03AC0
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x1D03AB0 Offset: 0x1D024B0 VA: 0x181D03AB0
	internal static bool RequestWorkerThread() { }

	// RVA: 0x1D033F0 Offset: 0x1D01DF0 VA: 0x181D033F0
	private static void EnsureVMInitialized() { }

	// RVA: 0x1D03490 Offset: 0x1D01E90 VA: 0x181D03490
	private static void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x1D034B0 Offset: 0x1D01EB0 VA: 0x181D034B0
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x1B936D0 Offset: 0x1B920D0 VA: 0x181B936D0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x1D01D70 Offset: 0x1D00770 VA: 0x181D01D70
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x1D034C0 Offset: 0x1D01EC0 VA: 0x181D034C0
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x1B963C0 Offset: 0x1B94DC0 VA: 0x181B963C0
	internal static void NotifyWorkItemQueued() { }

	// RVA: 0x1D034A0 Offset: 0x1D01EA0 VA: 0x181D034A0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	// RVA: 0x1D03C60 Offset: 0x1D02660 VA: 0x181D03C60
	internal static bool get_IsThreadPoolThread() { }
}
