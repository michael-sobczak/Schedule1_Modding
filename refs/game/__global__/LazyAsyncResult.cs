internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 10003
{
	// Fields
	[ThreadStatic]
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal bool EndCalled { get; set; }

	// Methods

	// RVA: 0x26C76B0 Offset: 0x26C60B0 VA: 0x1826C76B0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x26C7520 Offset: 0x26C5F20 VA: 0x1826C7520
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal object get_AsyncObject() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x26C75E0 Offset: 0x26C5FE0 VA: 0x1826C75E0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x26C6FB0 Offset: 0x26C59B0 VA: 0x1826C6FB0
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x26C7680 Offset: 0x26C6080 VA: 0x1826C7680 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x26C7760 Offset: 0x26C6160 VA: 0x1826C7760 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x26C7750 Offset: 0x26C6150 VA: 0x1826C7750
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	internal bool get_EndCalled() { }

	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	internal void set_EndCalled(bool value) { }

	// RVA: 0x26C7130 Offset: 0x26C5B30 VA: 0x1826C7130
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x26C6FA0 Offset: 0x26C59A0 VA: 0x1826C6FA0
	internal void InvokeCallback(object result) { }

	// RVA: 0x26C6F90 Offset: 0x26C5990 VA: 0x1826C6F90
	internal void InvokeCallback() { }

	// RVA: 0x26C6D90 Offset: 0x26C5790 VA: 0x1826C6D90 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x26C7490 Offset: 0x26C5E90 VA: 0x1826C7490
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x26C6F80 Offset: 0x26C5980 VA: 0x1826C6F80
	internal object InternalWaitForCompletion() { }

	// RVA: 0x26C72C0 Offset: 0x26C5CC0 VA: 0x1826C72C0
	private object WaitForCompletion(bool snap) { }
}
