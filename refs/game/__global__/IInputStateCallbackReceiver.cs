public interface IInputStateCallbackReceiver // TypeDefIndex: 7703
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNextUpdate();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnStateEvent(InputEventPtr eventPtr);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset);
}
