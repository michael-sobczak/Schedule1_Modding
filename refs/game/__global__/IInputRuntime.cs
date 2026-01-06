internal interface IInputRuntime // TypeDefIndex: 7691
{
	// Properties
	public abstract InputUpdateDelegate onUpdate { get; set; }
	public abstract Action<InputUpdateType> onBeforeUpdate { get; set; }
	public abstract Func<InputUpdateType, bool> onShouldRunUpdate { get; set; }
	public abstract Action<int, string> onDeviceDiscovered { get; set; }
	public abstract Action<bool> onPlayerFocusChanged { get; set; }
	public abstract bool isPlayerFocused { get; }
	public abstract Action onShutdown { get; set; }
	public abstract float pollingFrequency { get; set; }
	public abstract double currentTime { get; }
	public abstract double currentTimeForFixedUpdate { get; }
	public abstract float unscaledGameTime { get; }
	public abstract double currentTimeOffsetToRealtimeSinceStartup { get; }
	public abstract bool runInBackground { get; set; }
	public abstract Vector2 screenSize { get; }
	public abstract ScreenOrientation screenOrientation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int AllocateDeviceId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Update(InputUpdateType type);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void QueueEvent(InputEvent* ptr);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract InputUpdateDelegate get_onUpdate();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_onUpdate(InputUpdateDelegate value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Action<InputUpdateType> get_onBeforeUpdate();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_onBeforeUpdate(Action<InputUpdateType> value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<InputUpdateType, bool> get_onShouldRunUpdate();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_onShouldRunUpdate(Func<InputUpdateType, bool> value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<int, string> get_onDeviceDiscovered();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_onDeviceDiscovered(Action<int, string> value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Action<bool> get_onPlayerFocusChanged();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_onPlayerFocusChanged(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_isPlayerFocused();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Action get_onShutdown();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_onShutdown(Action value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract float get_pollingFrequency();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void set_pollingFrequency(float value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract double get_currentTime();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract double get_currentTimeForFixedUpdate();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract float get_unscaledGameTime();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract double get_currentTimeOffsetToRealtimeSinceStartup();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool get_runInBackground();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_runInBackground(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Vector2 get_screenSize();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract ScreenOrientation get_screenOrientation();
}
