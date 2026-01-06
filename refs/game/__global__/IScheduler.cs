internal interface IScheduler // TypeDefIndex: 6761
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Unschedule(ScheduledItem item);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Schedule(ScheduledItem item);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateScheduledEvents();
}
