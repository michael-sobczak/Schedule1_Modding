internal abstract class TaskContinuation // TypeDefIndex: 4067
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x1CF6680 Offset: 0x1CF5080 VA: 0x181CF6680
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
