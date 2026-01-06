public struct RequestResetCommand : IInputDeviceCommandInfo // TypeDefIndex: 7629
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x0

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865D30 Offset: 0x2864730 VA: 0x182865D30
	public static FourCC get_Type() { }

	// RVA: 0x2865D70 Offset: 0x2864770 VA: 0x182865D70 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865CE0 Offset: 0x28646E0 VA: 0x182865CE0
	public static RequestResetCommand Create() { }
}
