public struct EnableDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 7607
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x0

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2857ED0 Offset: 0x28568D0 VA: 0x182857ED0
	public static FourCC get_Type() { }

	// RVA: 0x2857F10 Offset: 0x2856910 VA: 0x182857F10 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2857E80 Offset: 0x2856880 VA: 0x182857E80
	public static EnableDeviceCommand Create() { }
}
