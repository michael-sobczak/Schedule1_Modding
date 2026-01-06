public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 4368
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x1B24D20 Offset: 0x1B23720 VA: 0x181B24D20 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10
	public bool get_EndInvokeCalled() { }

	// RVA: 0x1B24E20 Offset: 0x1B23820 VA: 0x181B24E20
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x1B24A60 Offset: 0x1B23460 VA: 0x181B24A60 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x1B24AA0 Offset: 0x1B234A0 VA: 0x181B24AA0
	internal IMessage EndInvoke() { }

	// RVA: 0x1B24BA0 Offset: 0x1B235A0 VA: 0x181B24BA0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x1B24B90 Offset: 0x1B23590 VA: 0x181B24B90 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1B24B90 Offset: 0x1B23590 VA: 0x181B24B90
	internal object Invoke() { }
}
