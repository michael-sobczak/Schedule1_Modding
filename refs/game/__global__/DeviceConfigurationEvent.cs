public struct DeviceConfigurationEvent : IInputEventTypeInfo // TypeDefIndex: 7664
{
	// Fields
	public const int Type = 1145259591;
	public InputEvent baseEvent; // 0x0

	// Properties
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2854510 Offset: 0x2852F10 VA: 0x182854510 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x2854450 Offset: 0x2852E50 VA: 0x182854450
	public static DeviceConfigurationEvent Create(int deviceId, double time) { }
}
