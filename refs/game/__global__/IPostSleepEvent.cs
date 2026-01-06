public interface IPostSleepEvent // TypeDefIndex: 2672
{
	// Properties
	public abstract bool IsRunning { get; }
	public abstract int Order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsRunning();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Order();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void StartEvent();
}
