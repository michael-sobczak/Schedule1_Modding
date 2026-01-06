internal sealed class SynchronizationContextTaskScheduler : TaskScheduler // TypeDefIndex: 4080
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x18
	private static readonly SendOrPostCallback s_postCallback; // 0x0

	// Properties
	public override int MaximumConcurrencyLevel { get; }

	// Methods

	// RVA: 0x1CF64D0 Offset: 0x1CF4ED0 VA: 0x181CF64D0
	internal void .ctor() { }

	// RVA: 0x1CF62D0 Offset: 0x1CF4CD0 VA: 0x181CF62D0 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x1CF6360 Offset: 0x1CF4D60 VA: 0x181CF6360 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override int get_MaximumConcurrencyLevel() { }

	// RVA: 0x1CF6400 Offset: 0x1CF4E00 VA: 0x181CF6400
	private static void .cctor() { }
}
