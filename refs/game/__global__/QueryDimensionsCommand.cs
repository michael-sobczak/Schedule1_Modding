public struct QueryDimensionsCommand : IInputDeviceCommandInfo // TypeDefIndex: 7616
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x0
	public Vector2 outDimensions; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28653E0 Offset: 0x2863DE0 VA: 0x1828653E0
	public static FourCC get_Type() { }

	// RVA: 0x2865420 Offset: 0x2863E20 VA: 0x182865420 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865380 Offset: 0x2863D80 VA: 0x182865380
	public static QueryDimensionsCommand Create() { }
}
