public static class InputState // TypeDefIndex: 7707
{
	// Properties
	public static InputUpdateType currentUpdateType { get; }
	public static uint updateCount { get; }
	public static double currentTime { get; }

	// Methods

	// RVA: 0x287AC40 Offset: 0x2879640 VA: 0x18287AC40
	public static InputUpdateType get_currentUpdateType() { }

	// RVA: 0x287AC80 Offset: 0x2879680 VA: 0x18287AC80
	public static uint get_updateCount() { }

	// RVA: 0x287ABC0 Offset: 0x28795C0 VA: 0x18287ABC0
	public static double get_currentTime() { }

	// RVA: 0x287AB50 Offset: 0x2879550 VA: 0x18287AB50
	public static void add_onChange(Action<InputDevice, InputEventPtr> value) { }

	// RVA: 0x287ACC0 Offset: 0x28796C0 VA: 0x18287ACC0
	public static void remove_onChange(Action<InputDevice, InputEventPtr> value) { }

	// RVA: 0x287A4B0 Offset: 0x2878EB0 VA: 0x18287A4B0
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = 0) { }

	// RVA: -1 Offset: -1
	public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE0A10 Offset: 0xEDF410 VA: 0x180EE0A10
	|-InputState.Change<byte>
	|
	|-RVA: 0xEE1130 Offset: 0xEDFB30 VA: 0x180EE1130
	|-InputState.Change<Int32Enum>
	|
	|-RVA: 0xEE14A0 Offset: 0xEDFEA0 VA: 0x180EE14A0
	|-InputState.Change<MouseState>
	|
	|-RVA: 0xEE1B20 Offset: 0xEE0520 VA: 0x180EE1B20
	|-InputState.Change<Vector2>
	|
	|-RVA: 0xEE0D80 Offset: 0xEDF780 VA: 0x180EE0D80
	|-InputState.Change<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Change<TState>(InputControl control, ref TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE0A80 Offset: 0xEDF480 VA: 0x180EE0A80
	|-InputState.Change<byte>
	|
	|-RVA: 0xEE11A0 Offset: 0xEDFBA0 VA: 0x180EE11A0
	|-InputState.Change<Int32Enum>
	|
	|-RVA: 0xEE1520 Offset: 0xEDFF20 VA: 0x180EE1520
	|-InputState.Change<MouseState>
	|
	|-RVA: 0xEE1820 Offset: 0xEE0220 VA: 0x180EE1820
	|-InputState.Change<TouchState>
	|
	|-RVA: 0xEE1B90 Offset: 0xEE0590 VA: 0x180EE1B90
	|-InputState.Change<Vector2>
	|
	|-RVA: 0xEE0E00 Offset: 0xEDF800 VA: 0x180EE0E00
	|-InputState.Change<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x287A7C0 Offset: 0x28791C0 VA: 0x18287A7C0
	public static bool IsIntegerFormat(FourCC format) { }

	// RVA: 0x287A1E0 Offset: 0x2878BE0 VA: 0x18287A1E0
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1, uint groupIndex = 0) { }

	// RVA: 0x287A3A0 Offset: 0x2878DA0 VA: 0x18287A3A0
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1, Action<InputControl, double, long, int> timerExpiredCallback) { }

	// RVA: 0x287AA20 Offset: 0x2879420 VA: 0x18287AA20
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1) { }

	// RVA: 0x287A0E0 Offset: 0x2878AE0 VA: 0x18287A0E0
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1, int timerIndex = -1) { }

	// RVA: 0x287A940 Offset: 0x2879340 VA: 0x18287A940
	public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1, int timerIndex = -1) { }
}
