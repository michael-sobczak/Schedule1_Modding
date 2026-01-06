public interface IActionScheduler : IServiceComponent // TypeDefIndex: 17797
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long ScheduleAction(Action action, double delaySeconds = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CancelAction(long actionId);
}
