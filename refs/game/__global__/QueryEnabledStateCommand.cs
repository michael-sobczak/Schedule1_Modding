public struct QueryEnabledStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 7617
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x0
	public bool isEnabled; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28654C0 Offset: 0x2863EC0 VA: 0x1828654C0
	public static FourCC get_Type() { }

	// RVA: 0x2865500 Offset: 0x2863F00 VA: 0x182865500 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865460 Offset: 0x2863E60 VA: 0x182865460
	public static QueryEnabledStateCommand Create() { }
}
