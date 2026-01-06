public struct DisableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 7606
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x0

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2854730 Offset: 0x2853130 VA: 0x182854730
	public static FourCC get_Type() { }

	// RVA: 0x2854770 Offset: 0x2853170 VA: 0x182854770 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x28546E0 Offset: 0x28530E0 VA: 0x1828546E0
	public static DisableDeviceCommand Create() { }
}
