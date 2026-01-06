public interface IVisualElementScheduledItem // TypeDefIndex: 7042
{
	// Properties
	public abstract bool isActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Resume();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Pause();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ExecuteLater(long delayMs);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IVisualElementScheduledItem StartingIn(long delayMs);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IVisualElementScheduledItem Every(long intervalMs);
}
