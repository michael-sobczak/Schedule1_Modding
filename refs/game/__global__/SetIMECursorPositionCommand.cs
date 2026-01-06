public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo // TypeDefIndex: 7631
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x0
	private Vector2 m_Position; // 0x8

	// Properties
	public static FourCC Type { get; }
	public Vector2 position { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865FD0 Offset: 0x28649D0 VA: 0x182865FD0
	public static FourCC get_Type() { }

	// RVA: 0x18CCE00 Offset: 0x18CB800 VA: 0x1818CCE00
	public Vector2 get_position() { }

	// RVA: 0x2866010 Offset: 0x2864A10 VA: 0x182866010 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865F50 Offset: 0x2864950 VA: 0x182865F50
	public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) { }
}
