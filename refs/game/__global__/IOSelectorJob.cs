internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 9523
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x165BA70 Offset: 0x165A470 VA: 0x18165BA70
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x26166D0 Offset: 0x26150D0 VA: 0x1826166D0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x26166A0 Offset: 0x26150A0 VA: 0x1826166A0
	public void MarkDisposed() { }
}
