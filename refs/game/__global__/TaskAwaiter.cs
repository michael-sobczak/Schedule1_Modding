public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4619
{
	// Fields
	internal readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	internal void .ctor(Task task) { }

	// RVA: 0x12113A0 Offset: 0x120FDA0 VA: 0x1812113A0
	public bool get_IsCompleted() { }

	// RVA: 0x1B76200 Offset: 0x1B74C00 VA: 0x181B76200 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x1B5FF10 Offset: 0x1B5E910 VA: 0x181B5FF10
	public void GetResult() { }

	[StackTraceHidden]
	// RVA: 0x1B762B0 Offset: 0x1B74CB0 VA: 0x181B762B0
	internal static void ValidateEnd(Task task) { }

	[StackTraceHidden]
	// RVA: 0x1B75C50 Offset: 0x1B74650 VA: 0x181B75C50
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[StackTraceHidden]
	// RVA: 0x1B760A0 Offset: 0x1B74AA0 VA: 0x181B760A0
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x1B75DE0 Offset: 0x1B747E0 VA: 0x181B75DE0
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x1B75EB0 Offset: 0x1B748B0 VA: 0x181B75EB0
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }
}
