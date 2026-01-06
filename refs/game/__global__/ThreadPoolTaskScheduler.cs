internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 4083
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x1D021E0 Offset: 0x1D00BE0 VA: 0x181D021E0
	internal void .ctor() { }

	// RVA: 0x1D01D90 Offset: 0x1D00790 VA: 0x181D01D90 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x1D02040 Offset: 0x1D00A40 VA: 0x181D02040 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1D02030 Offset: 0x1D00A30 VA: 0x181D02030 Slot: 7
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x1D01D70 Offset: 0x1D00770 VA: 0x181D01D70 Slot: 8
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1D02110 Offset: 0x1D00B10 VA: 0x181D02110
	private static void .cctor() { }
}
