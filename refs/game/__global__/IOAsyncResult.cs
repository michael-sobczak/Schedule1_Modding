internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 9522
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x26164B0 Offset: 0x2614EB0 VA: 0x1826164B0
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2616500 Offset: 0x2614F00 VA: 0x182616500 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x26165F0 Offset: 0x2614FF0 VA: 0x1826165F0
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();
}
