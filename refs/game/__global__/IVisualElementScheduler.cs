public interface IVisualElementScheduler // TypeDefIndex: 7043
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IVisualElementScheduledItem Execute(Action updateEvent);
}
