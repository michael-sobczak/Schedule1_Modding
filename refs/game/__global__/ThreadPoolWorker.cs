public class ThreadPoolWorker : IDisposable // TypeDefIndex: 10450
{
	// Fields
	private int _remainingWorkItems; // 0x10
	private ManualResetEvent _done; // 0x18

	// Methods

	// RVA: 0x49DE30 Offset: 0x49C830 VA: 0x18049DE30
	public void QueueWorkItem(WaitCallback callback) { }

	// RVA: 0x49DAC0 Offset: 0x49C4C0 VA: 0x18049DAC0
	public void QueueWorkItem(Action act) { }

	// RVA: -1 Offset: -1
	public void ParralelFor<T>(Action<T> action, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF60970 Offset: 0xF5F370 VA: 0x180F60970
	|-ThreadPoolWorker.ParralelFor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x49DD10 Offset: 0x49C710 VA: 0x18049DD10
	private void QueueWorkItem(QueuedCallback callback) { }

	// RVA: 0x49DA20 Offset: 0x49C420 VA: 0x18049DA20
	public void QueueWorkItem(WaitCallback callback, object state) { }

	// RVA: 0x49DBE0 Offset: 0x49C5E0 VA: 0x18049DBE0
	public void QueueWorkItem(Action act, object state) { }

	// RVA: 0x49E100 Offset: 0x49CB00 VA: 0x18049E100
	public bool WaitAll() { }

	// RVA: 0x49E080 Offset: 0x49CA80 VA: 0x18049E080
	public bool WaitAll(TimeSpan timeout, bool exitContext) { }

	// RVA: 0x49DF60 Offset: 0x49C960 VA: 0x18049DF60
	public bool WaitAll(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x49D940 Offset: 0x49C340 VA: 0x18049D940
	private void HandleWorkItem(object state) { }

	// RVA: 0x49D890 Offset: 0x49C290 VA: 0x18049D890
	private void DoneWorkItem() { }

	// RVA: 0x49DED0 Offset: 0x49C8D0 VA: 0x18049DED0
	private void ThrowIfDisposed() { }

	// RVA: 0x49D830 Offset: 0x49C230 VA: 0x18049D830 Slot: 4
	public void Dispose() { }

	// RVA: 0x49E110 Offset: 0x49CB10 VA: 0x18049E110
	public void .ctor() { }
}
