public struct QueryCanRunInBackground : IInputDeviceCommandInfo // TypeDefIndex: 7615
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x0
	public bool canRunInBackground; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865300 Offset: 0x2863D00 VA: 0x182865300
	public static FourCC get_Type() { }

	// RVA: 0x2865340 Offset: 0x2863D40 VA: 0x182865340 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865290 Offset: 0x2863C90 VA: 0x182865290
	public static QueryCanRunInBackground Create() { }
}
