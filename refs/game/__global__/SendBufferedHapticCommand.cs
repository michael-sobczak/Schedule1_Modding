public struct SendBufferedHapticCommand : IInputDeviceCommandInfo // TypeDefIndex: 7484
{
	// Fields
	private const int kMaxHapticBufferSize = 1024;
	private const int kSize = 1040;
	private InputDeviceCommand baseCommand; // 0x0
	private int channel; // 0x8
	private int bufferSize; // 0xC
	[FixedBuffer(typeof(byte), 1024)]
	private SendBufferedHapticCommand.<buffer>e__FixedBuffer buffer; // 0x10

	// Properties
	private static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2834AF0 Offset: 0x28334F0 VA: 0x182834AF0
	private static FourCC get_Type() { }

	// RVA: 0x2834B30 Offset: 0x2833530 VA: 0x182834B30 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2834920 Offset: 0x2833320 VA: 0x182834920
	public static SendBufferedHapticCommand Create(byte[] rumbleBuffer) { }
}
