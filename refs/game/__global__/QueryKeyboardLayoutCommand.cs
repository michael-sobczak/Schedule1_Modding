public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo // TypeDefIndex: 7619
{
	// Fields
	internal const int kMaxNameLength = 256;
	public InputDeviceCommand baseCommand; // 0x0
	[FixedBuffer(typeof(byte), 256)]
	public QueryKeyboardLayoutCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865720 Offset: 0x2864120 VA: 0x182865720
	public static FourCC get_Type() { }

	// RVA: 0x28656D0 Offset: 0x28640D0 VA: 0x1828656D0
	public string ReadLayoutName() { }

	// RVA: 0x28656F0 Offset: 0x28640F0 VA: 0x1828656F0
	public void WriteLayoutName(string name) { }

	// RVA: 0x2865760 Offset: 0x2864160 VA: 0x182865760 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865660 Offset: 0x2864060 VA: 0x182865660
	public static QueryKeyboardLayoutCommand Create() { }
}
