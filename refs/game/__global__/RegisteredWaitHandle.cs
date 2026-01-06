public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 3996
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x1CF4490 Offset: 0x1CF2E90 VA: 0x181CF4490
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1CF3F00 Offset: 0x1CF2900 VA: 0x181CF3F00
	internal void Wait(object state) { }

	// RVA: 0x1CF3D20 Offset: 0x1CF2720 VA: 0x181CF3D20
	private void DoCallBack(object timedOut) { }

	[ComVisible(True)]
	// RVA: 0x1CF3E10 Offset: 0x1CF2810 VA: 0x181CF3E10
	public bool Unregister(WaitHandle waitObject) { }
}
