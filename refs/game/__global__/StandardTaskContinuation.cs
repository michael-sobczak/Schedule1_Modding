internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 4068
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x1CF5DB0 Offset: 0x1CF47B0 VA: 0x181CF5DB0
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x1CF5C70 Offset: 0x1CF4670 VA: 0x181CF5C70 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}
