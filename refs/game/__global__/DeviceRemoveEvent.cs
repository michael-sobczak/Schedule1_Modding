public struct DeviceRemoveEvent : IInputEventTypeInfo // TypeDefIndex: 7665
{
	// Fields
	public const int Type = 1146242381;
	public InputEvent baseEvent; // 0x0

	// Properties
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28545E0 Offset: 0x2852FE0 VA: 0x1828545E0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x2854520 Offset: 0x2852F20 VA: 0x182854520
	public static DeviceRemoveEvent Create(int deviceId, double time = -1) { }
}
