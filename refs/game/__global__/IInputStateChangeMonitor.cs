public interface IInputStateChangeMonitor // TypeDefIndex: 7704
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex);
}
