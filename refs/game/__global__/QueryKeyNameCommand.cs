public struct QueryKeyNameCommand : IInputDeviceCommandInfo // TypeDefIndex: 7621
{
	// Fields
	internal const int kMaxNameLength = 256;
	internal const int kSize = 268;
	public InputDeviceCommand baseCommand; // 0x0
	public int scanOrKeyCode; // 0x8
	[FixedBuffer(typeof(byte), 256)]
	public QueryKeyNameCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0xC

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28655E0 Offset: 0x2863FE0 VA: 0x1828655E0
	public static FourCC get_Type() { }

	// RVA: 0x28655C0 Offset: 0x2863FC0 VA: 0x1828655C0
	public string ReadKeyName() { }

	// RVA: 0x2865620 Offset: 0x2864020 VA: 0x182865620 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865540 Offset: 0x2863F40 VA: 0x182865540
	public static QueryKeyNameCommand Create(Key key) { }
}
