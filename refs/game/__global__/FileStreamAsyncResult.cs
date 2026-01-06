internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 5107
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1C29C40 Offset: 0x1C28640 VA: 0x181C29C40
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x1C29BB0 Offset: 0x1C285B0 VA: 0x181C29BB0
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0 Slot: 4
	public bool get_IsCompleted() { }
}
