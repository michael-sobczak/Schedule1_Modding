public struct RequestSyncCommand : IInputDeviceCommandInfo // TypeDefIndex: 7630
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x0

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865E00 Offset: 0x2864800 VA: 0x182865E00
	public static FourCC get_Type() { }

	// RVA: 0x2865E40 Offset: 0x2864840 VA: 0x182865E40 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865DB0 Offset: 0x28647B0 VA: 0x182865DB0
	public static RequestSyncCommand Create() { }
}
