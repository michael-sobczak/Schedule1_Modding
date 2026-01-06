internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 4072
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x1CF6290 Offset: 0x1CF4C90 VA: 0x181CF6290
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	// RVA: 0x1CF8020 Offset: 0x1CF6A20 VA: 0x181CF8020 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}
