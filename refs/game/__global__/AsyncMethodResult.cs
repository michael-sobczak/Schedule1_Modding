internal class AsyncMethodResult : IAsyncResult // TypeDefIndex: 5230
{
	// Fields
	private ManualResetEvent handle; // 0x10
	private object state; // 0x18
	private bool completed; // 0x20
	private object return_value; // 0x28
	private Exception exception; // 0x30

	// Properties
	public virtual WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x21C2B80 Offset: 0x21C1580 VA: 0x1821C2B80
	public void .ctor() { }

	// RVA: 0x21C2BF0 Offset: 0x21C15F0 VA: 0x1821C2BF0 Slot: 8
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x21C2C50 Offset: 0x21C1650 VA: 0x1821C2C50 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x21C2A90 Offset: 0x21C1490 VA: 0x1821C2A90
	public object EndInvoke() { }

	// RVA: 0x21C2A00 Offset: 0x21C1400 VA: 0x1821C2A00
	public void Complete(object result) { }

	// RVA: 0x21C2970 Offset: 0x21C1370 VA: 0x1821C2970
	public void CompleteWithException(Exception ex) { }
}
