internal class NativeInputRuntime : IInputRuntime // TypeDefIndex: 7702
{
	// Fields
	public static readonly NativeInputRuntime instance; // 0x0
	private bool m_RunInBackground; // 0x10
	private Action m_ShutdownMethod; // 0x18
	private InputUpdateDelegate m_OnUpdate; // 0x20
	private Action<InputUpdateType> m_OnBeforeUpdate; // 0x28
	private Func<InputUpdateType, bool> m_OnShouldRunUpdate; // 0x30
	private float m_PollingFrequency; // 0x38
	private bool m_DidCallOnShutdown; // 0x3C
	private Action<bool> m_FocusChangedMethod; // 0x40

	// Properties
	public InputUpdateDelegate onUpdate { get; set; }
	public Action<InputUpdateType> onBeforeUpdate { get; set; }
	public Func<InputUpdateType, bool> onShouldRunUpdate { get; set; }
	public Action<int, string> onDeviceDiscovered { get; set; }
	public Action onShutdown { get; set; }
	public Action<bool> onPlayerFocusChanged { get; set; }
	public bool isPlayerFocused { get; }
	public float pollingFrequency { get; set; }
	public double currentTime { get; }
	public double currentTimeForFixedUpdate { get; }
	public double currentTimeOffsetToRealtimeSinceStartup { get; }
	public float unscaledGameTime { get; }
	public bool runInBackground { get; set; }
	public Vector2 screenSize { get; }
	public ScreenOrientation screenOrientation { get; }

	// Methods

	// RVA: 0x287C1E0 Offset: 0x287ABE0 VA: 0x18287C1E0 Slot: 4
	public int AllocateDeviceId() { }

	// RVA: 0x287C3D0 Offset: 0x287ADD0 VA: 0x18287C3D0 Slot: 5
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x287C370 Offset: 0x287AD70 VA: 0x18287C370 Slot: 6
	public void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x287C220 Offset: 0x287AC20 VA: 0x18287C220 Slot: 7
	public long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x287CB90 Offset: 0x287B590 VA: 0x18287CB90 Slot: 9
	public void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 10
	public Action<InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x287C6C0 Offset: 0x287B0C0 VA: 0x18287C6C0 Slot: 11
	public void set_onBeforeUpdate(Action<InputUpdateType> value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 12
	public Func<InputUpdateType, bool> get_onShouldRunUpdate() { }

	// RVA: 0x287C950 Offset: 0x287B350 VA: 0x18287C950 Slot: 13
	public void set_onShouldRunUpdate(Func<InputUpdateType, bool> value) { }

	// RVA: 0x287C5C0 Offset: 0x287AFC0 VA: 0x18287C5C0 Slot: 14
	public Action<int, string> get_onDeviceDiscovered() { }

	// RVA: 0x287C800 Offset: 0x287B200 VA: 0x18287C800 Slot: 15
	public void set_onDeviceDiscovered(Action<int, string> value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 19
	public Action get_onShutdown() { }

	// RVA: 0x287CA90 Offset: 0x287B490 VA: 0x18287CA90 Slot: 20
	public void set_onShutdown(Action value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 16
	public Action<bool> get_onPlayerFocusChanged() { }

	// RVA: 0x287C850 Offset: 0x287B250 VA: 0x18287C850 Slot: 17
	public void set_onPlayerFocusChanged(Action<bool> value) { }

	// RVA: 0x287C580 Offset: 0x287AF80 VA: 0x18287C580 Slot: 18
	public bool get_isPlayerFocused() { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0 Slot: 21
	public float get_pollingFrequency() { }

	// RVA: 0x287CCD0 Offset: 0x287B6D0 VA: 0x18287CCD0 Slot: 22
	public void set_pollingFrequency(float value) { }

	// RVA: 0x287C540 Offset: 0x287AF40 VA: 0x18287C540 Slot: 23
	public double get_currentTime() { }

	// RVA: 0x287C4A0 Offset: 0x287AEA0 VA: 0x18287C4A0 Slot: 24
	public double get_currentTimeForFixedUpdate() { }

	// RVA: 0x287C500 Offset: 0x287AF00 VA: 0x18287C500 Slot: 26
	public double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x287C6B0 Offset: 0x287B0B0 VA: 0x18287C6B0 Slot: 25
	public float get_unscaledGameTime() { }

	// RVA: 0x287C600 Offset: 0x287B000 VA: 0x18287C600 Slot: 27
	public bool get_runInBackground() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80 Slot: 28
	public void set_runInBackground(bool value) { }

	// RVA: 0x1B60410 Offset: 0x1B5EE10 VA: 0x181B60410
	private void OnShutdown() { }

	// RVA: 0x287C330 Offset: 0x287AD30 VA: 0x18287C330
	private bool OnWantsToShutdown() { }

	// RVA: 0x287C300 Offset: 0x287AD00 VA: 0x18287C300
	private void OnFocusChanged(bool focus) { }

	// RVA: 0x287C670 Offset: 0x287B070 VA: 0x18287C670 Slot: 29
	public Vector2 get_screenSize() { }

	// RVA: 0x287C660 Offset: 0x287B060 VA: 0x18287C660 Slot: 30
	public ScreenOrientation get_screenOrientation() { }

	// RVA: 0x287C490 Offset: 0x287AE90 VA: 0x18287C490
	public void .ctor() { }

	// RVA: 0x287C420 Offset: 0x287AE20 VA: 0x18287C420
	private static void .cctor() { }
}
