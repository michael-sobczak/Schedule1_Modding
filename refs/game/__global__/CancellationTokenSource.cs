public class CancellationTokenSource : IDisposable // TypeDefIndex: 3944
{
	// Fields
	internal static readonly CancellationTokenSource s_canceledSource; // 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent _kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
	private const int CannotBeCanceled = 0;
	private const int NotCanceledState = 1;
	private const int NotifyingState = 2;
	private const int NotifyingCompleteState = 3;
	private int _state; // 0x20
	private int _threadIDExecutingCallbacks; // 0x24
	private bool _disposed; // 0x28
	private CancellationCallbackInfo _executingCallback; // 0x30
	private Timer _timer; // 0x38
	private static readonly TimerCallback s_timerCallback; // 0x18

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x1CD4F20 Offset: 0x1CD3920 VA: 0x181CD4F20
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1CD4F00 Offset: 0x1CD3900 VA: 0x181CD4F00
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	internal bool get_IsDisposed() { }

	// RVA: 0x1CD4F40 Offset: 0x1CD3940 VA: 0x181CD4F40
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1CD4FC0 Offset: 0x1CD39C0 VA: 0x181CD4FC0
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x1CD4F60 Offset: 0x1CD3960 VA: 0x181CD4F60
	public CancellationToken get_Token() { }

	// RVA: 0x1BDA0F0 Offset: 0x1BD8AF0 VA: 0x181BDA0F0
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1CD4D30 Offset: 0x1CD3730 VA: 0x181CD4D30
	public void .ctor() { }

	// RVA: 0x1CD4D70 Offset: 0x1CD3770 VA: 0x181CD4D70
	public void .ctor(TimeSpan delay) { }

	// RVA: 0x1CD4420 Offset: 0x1CD2E20 VA: 0x181CD4420
	private void InitializeWithTimer(int millisecondsDelay) { }

	// RVA: 0x1CD3770 Offset: 0x1CD2170 VA: 0x181CD3770
	public void Cancel() { }

	// RVA: 0x1CD3710 Offset: 0x1CD2110 VA: 0x181CD3710
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1CD3490 Offset: 0x1CD1E90 VA: 0x181CD3490
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x1CD3550 Offset: 0x1CD1F50 VA: 0x181CD3550
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x1CD49B0 Offset: 0x1CD33B0 VA: 0x181CD49B0
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1CD3E90 Offset: 0x1CD2890 VA: 0x181CD3E90 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CD3F00 Offset: 0x1CD2900 VA: 0x181CD3F00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CD4900 Offset: 0x1CD3300 VA: 0x181CD4900
	internal void ThrowIfDisposed() { }

	// RVA: 0x1CD4950 Offset: 0x1CD3350 VA: 0x181CD4950
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1CD4500 Offset: 0x1CD2F00 VA: 0x181CD4500
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1CD4850 Offset: 0x1CD3250 VA: 0x181CD4850
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x1CD3FB0 Offset: 0x1CD29B0 VA: 0x181CD3FB0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x1CD37D0 Offset: 0x1CD21D0 VA: 0x181CD37D0
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1CD3850 Offset: 0x1CD2250 VA: 0x181CD3850
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x1CD3A50 Offset: 0x1CD2450 VA: 0x181CD3A50
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1CD3DC0 Offset: 0x1CD27C0 VA: 0x181CD3DC0
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	// RVA: 0x1CD4AA0 Offset: 0x1CD34A0 VA: 0x181CD4AA0
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1CD4B70 Offset: 0x1CD3570 VA: 0x181CD4B70
	private static void .cctor() { }
}
