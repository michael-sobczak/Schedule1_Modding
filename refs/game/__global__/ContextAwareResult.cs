internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 9924
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private ContextAwareResult.StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void SafeCaptureIdentity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CleanupInternal() { }

	// RVA: 0x269D1F0 Offset: 0x269BBF0 VA: 0x18269D1F0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x269D190 Offset: 0x269BB90 VA: 0x18269D190
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x269D120 Offset: 0x269BB20 VA: 0x18269D120
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x269D050 Offset: 0x269BA50 VA: 0x18269D050
	internal object StartPostingAsyncOp() { }

	// RVA: 0x269CF70 Offset: 0x269B970 VA: 0x18269CF70
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x269CF30 Offset: 0x269B930 VA: 0x18269CF30
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x269C9E0 Offset: 0x269B3E0 VA: 0x18269C9E0 Slot: 9
	protected override void Cleanup() { }

	// RVA: 0x269C4F0 Offset: 0x269AEF0 VA: 0x18269C4F0
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x269CBB0 Offset: 0x269B5B0 VA: 0x18269CBB0 Slot: 8
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x269CAC0 Offset: 0x269B4C0 VA: 0x18269CAC0
	private void CompleteCallback() { }
}
