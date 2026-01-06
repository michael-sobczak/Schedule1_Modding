public class ThreadPoolWorker<T> : IDisposable // TypeDefIndex: 10447
{
	// Fields
	private readonly SimplePool<QueuedCallback> queuedCallbackPool; // 0x0
	private readonly SimplePool<LoopState<T>> loopStatePool; // 0x0
	private int _remainingWorkItems; // 0x0
	private ManualResetEvent _done; // 0x0
	private readonly WaitCallback handleWorkItemCallBack; // 0x0
	private readonly WaitCallback handleLoopCallBack; // 0x0

	// Properties
	private static int ThreadsToUseCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126FCA0 Offset: 0x126E6A0 VA: 0x18126FCA0
	|-ThreadPoolWorker<CGSpot>..ctor
	|
	|-RVA: 0x1270000 Offset: 0x126EA00 VA: 0x181270000
	|-ThreadPoolWorker<object>..ctor
	|
	|-RVA: 0x126FE50 Offset: 0x126E850 VA: 0x18126FE50
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>..ctor
	*/

	[Obsolete("Use ParallelFor(Action<T,int,int> action, IEnumerable<T> list) instead")]
	[UsedImplicitly]
	// RVA: -1 Offset: -1
	public void ParralelFor(Action<T> action, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126EA90 Offset: 0x126D490 VA: 0x18126EA90
	|-ThreadPoolWorker<CGSpot>.ParralelFor
	|
	|-RVA: 0x126EBD0 Offset: 0x126D5D0 VA: 0x18126EBD0
	|-ThreadPoolWorker<object>.ParralelFor
	|
	|-RVA: 0x126ED10 Offset: 0x126D710 VA: 0x18126ED10
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.ParralelFor
	*/

	// RVA: -1 Offset: -1
	public void ParallelFor(Action<T, int, int> action, IEnumerable<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126E870 Offset: 0x126D270 VA: 0x18126E870
	|-ThreadPoolWorker<CGSpot>.ParallelFor
	|
	|-RVA: 0x126EA10 Offset: 0x126D410 VA: 0x18126EA10
	|-ThreadPoolWorker<object>.ParallelFor
	|
	|-RVA: 0x126E990 Offset: 0x126D390 VA: 0x18126E990
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.ParallelFor
	*/

	// RVA: -1 Offset: -1
	public void ParallelFor(Action<T, int, int> action, IEnumerable<T> list, int elementsCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126E850 Offset: 0x126D250 VA: 0x18126E850
	|-ThreadPoolWorker<CGSpot>.ParallelFor
	|
	|-RVA: 0x126E8F0 Offset: 0x126D2F0 VA: 0x18126E8F0
	|-ThreadPoolWorker<object>.ParallelFor
	|
	|-RVA: 0x126E910 Offset: 0x126D310 VA: 0x18126E910
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.ParallelFor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D770 Offset: 0x126C170 VA: 0x18126D770
	|-ThreadPoolWorker<CGSpot>.Dispose
	|
	|-RVA: 0x126D710 Offset: 0x126C110 VA: 0x18126D710
	|-ThreadPoolWorker<object>.Dispose
	|
	|-RVA: 0x126D7D0 Offset: 0x126C1D0 VA: 0x18126D7D0
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.Dispose
	*/

	[Conditional("THREADING_SUPPORTED")]
	// RVA: -1 Offset: -1
	private void DoParallelFor(Action<T, int, int> action, IEnumerable<T> list, int elementsCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126DD90 Offset: 0x126C790 VA: 0x18126DD90
	|-ThreadPoolWorker<CGSpot>.DoParallelFor
	|
	|-RVA: 0x126E2C0 Offset: 0x126CCC0 VA: 0x18126E2C0
	|-ThreadPoolWorker<object>.DoParallelFor
	|
	|-RVA: 0x126D830 Offset: 0x126C230 VA: 0x18126D830
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.DoParallelFor
	*/

	// RVA: -1 Offset: -1
	private static int get_ThreadsToUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12701B0 Offset: 0x126EBB0 VA: 0x1812701B0
	|-ThreadPoolWorker<CGSpot>.get_ThreadsToUseCount
	|
	|-RVA: 0x12702B0 Offset: 0x126ECB0 VA: 0x1812702B0
	|-ThreadPoolWorker<object>.get_ThreadsToUseCount
	|
	|-RVA: 0x1270230 Offset: 0x126EC30 VA: 0x181270230
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.get_ThreadsToUseCount
	*/

	// RVA: -1 Offset: -1
	private bool WaitAll(int millisecondsTimeout, bool exitContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126FB50 Offset: 0x126E550 VA: 0x18126FB50
	|-ThreadPoolWorker<CGSpot>.WaitAll
	|-ThreadPoolWorker<object>.WaitAll
	|
	|-RVA: 0x126FA00 Offset: 0x126E400 VA: 0x18126FA00
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.WaitAll
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126EE40 Offset: 0x126D840 VA: 0x18126EE40
	|-ThreadPoolWorker<CGSpot>.ThrowIfDisposed
	|-ThreadPoolWorker<object>.ThrowIfDisposed
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1
	private void DoneWorkItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126E7A0 Offset: 0x126D1A0 VA: 0x18126E7A0
	|-ThreadPoolWorker<CGSpot>.DoneWorkItem
	|-ThreadPoolWorker<object>.DoneWorkItem
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.DoneWorkItem
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__0_0(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126EED0 Offset: 0x126D8D0 VA: 0x18126EED0
	|-ThreadPoolWorker<CGSpot>.<.ctor>b__0_0
	|
	|-RVA: 0x126F040 Offset: 0x126DA40 VA: 0x18126F040
	|-ThreadPoolWorker<object>.<.ctor>b__0_0
	|
	|-RVA: 0x126F1B0 Offset: 0x126DBB0 VA: 0x18126F1B0
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.<.ctor>b__0_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__0_1(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126F7F0 Offset: 0x126E1F0 VA: 0x18126F7F0
	|-ThreadPoolWorker<CGSpot>.<.ctor>b__0_1
	|
	|-RVA: 0x126F640 Offset: 0x126E040 VA: 0x18126F640
	|-ThreadPoolWorker<object>.<.ctor>b__0_1
	|
	|-RVA: 0x126F320 Offset: 0x126DD20 VA: 0x18126F320
	|-ThreadPoolWorker<__Il2CppFullySharedGenericType>.<.ctor>b__0_1
	*/
}
