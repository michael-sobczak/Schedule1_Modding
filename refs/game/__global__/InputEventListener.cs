public struct InputEventListener : IObservable<InputEventPtr> // TypeDefIndex: 7677
{
	// Fields
	internal static InputEventListener.ObserverState s_ObserverState; // 0x0

	// Methods

	// RVA: 0x2860BD0 Offset: 0x285F5D0 VA: 0x182860BD0
	public static InputEventListener op_Addition(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	// RVA: 0x2860D30 Offset: 0x285F730 VA: 0x182860D30
	public static InputEventListener op_Subtraction(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	// RVA: 0x28609D0 Offset: 0x285F3D0 VA: 0x1828609D0 Slot: 4
	public IDisposable Subscribe(IObserver<InputEventPtr> observer) { }
}
