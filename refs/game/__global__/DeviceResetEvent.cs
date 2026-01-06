public struct DeviceResetEvent : IInputEventTypeInfo // TypeDefIndex: 7666
{
	// Fields
	public const int Type = 1146245972;
	public InputEvent baseEvent; // 0x0
	public bool hardReset; // 0x8

	// Properties
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28546D0 Offset: 0x28530D0 VA: 0x1828546D0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x28545F0 Offset: 0x2852FF0 VA: 0x1828545F0
	public static DeviceResetEvent Create(int deviceId, bool hardReset = False, double time = -1) { }
}
