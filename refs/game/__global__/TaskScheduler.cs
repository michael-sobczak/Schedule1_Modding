public abstract class TaskScheduler // TypeDefIndex: 4078
{
	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly Lock _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	public virtual int MaximumConcurrencyLevel { get; }
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0xCC3240 Offset: 0xCC1C40 VA: 0x180CC3240 Slot: 6
	public virtual int get_MaximumConcurrencyLevel() { }

	// RVA: 0x1CF8760 Offset: 0x1CF7160 VA: 0x181CF8760
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1CF8BC0 Offset: 0x1CF75C0 VA: 0x181CF8BC0
	public static TaskScheduler get_Default() { }

	// RVA: 0x1CF8B20 Offset: 0x1CF7520 VA: 0x181CF8B20
	public static TaskScheduler get_Current() { }

	// RVA: 0x1CF8CB0 Offset: 0x1CF76B0 VA: 0x181CF8CB0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x1CF84C0 Offset: 0x1CF6EC0 VA: 0x181CF84C0
	public static TaskScheduler FromCurrentSynchronizationContext() { }

	// RVA: 0x1CF8C10 Offset: 0x1CF7610 VA: 0x181CF8C10
	public int get_Id() { }

	// RVA: 0x1CF86E0 Offset: 0x1CF70E0 VA: 0x181CF86E0
	protected bool TryExecuteTask(Task task) { }

	// RVA: 0x1CF85A0 Offset: 0x1CF6FA0 VA: 0x181CF85A0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1CF8A20 Offset: 0x1CF7420 VA: 0x181CF8A20
	private static void .cctor() { }
}
