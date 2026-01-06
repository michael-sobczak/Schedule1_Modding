internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 4073
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x1CEE740 Offset: 0x1CED140 VA: 0x181CEE740
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x1CEE100 Offset: 0x1CECB00 VA: 0x181CEE100
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x1CEE500 Offset: 0x1CECF00 VA: 0x181CEE500 Slot: 4
	internal override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x1CEE7D0 Offset: 0x1CED1D0 VA: 0x181CEE7D0
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x1CEE5C0 Offset: 0x1CECFC0 VA: 0x181CEE5C0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1CEE290 Offset: 0x1CECC90 VA: 0x181CEE290
	private static void InvokeAction(object state) { }

	// RVA: 0x1CEE1E0 Offset: 0x1CECBE0 VA: 0x181CEE1E0
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x1CEE300 Offset: 0x1CECD00 VA: 0x181CEE300
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x1CEE3F0 Offset: 0x1CECDF0 VA: 0x181CEE3F0
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x1CEE6B0 Offset: 0x1CED0B0 VA: 0x181CEE6B0
	internal static void UnsafeScheduleAction(Action action) { }

	// RVA: 0x1CEE660 Offset: 0x1CED060 VA: 0x181CEE660
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public void MarkAborted(ThreadAbortException e) { }
}
