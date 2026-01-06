internal struct QueryUserIdCommand : IInputDeviceCommandInfo // TypeDefIndex: 7628
{
	// Fields
	public const int kMaxIdLength = 256;
	internal const int kSize = 520;
	public InputDeviceCommand baseCommand; // 0x0
	[FixedBuffer(typeof(byte), 512)]
	public QueryUserIdCommand.<idBuffer>e__FixedBuffer idBuffer; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865C60 Offset: 0x2864660 VA: 0x182865C60
	public static FourCC get_Type() { }

	// RVA: 0x28656D0 Offset: 0x28640D0 VA: 0x1828656D0
	public string ReadId() { }

	// RVA: 0x2865CA0 Offset: 0x28646A0 VA: 0x182865CA0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865BF0 Offset: 0x28645F0 VA: 0x182865BF0
	public static QueryUserIdCommand Create() { }
}
