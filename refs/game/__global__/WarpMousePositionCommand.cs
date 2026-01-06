internal struct WarpMousePositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 7633
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x0
	public Vector2 warpPositionInPlayerDisplaySpace; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x286A370 Offset: 0x2868D70 VA: 0x18286A370
	public static FourCC get_Type() { }

	// RVA: 0x286A3B0 Offset: 0x2868DB0 VA: 0x18286A3B0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x286A2F0 Offset: 0x2868CF0 VA: 0x18286A2F0
	public static WarpMousePositionCommand Create(Vector2 position) { }
}
