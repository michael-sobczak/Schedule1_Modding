internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 7594
{
	// Fields
	internal const int kSize = 86;
	public InputDeviceCommand baseCommand; // 0x0
	public byte reportId; // 0x8
	public byte tag1; // 0x9
	public byte tag2; // 0xA
	public DualSenseHIDOutputReportPayload payload; // 0xB
	public uint crc32; // 0x52
	[FixedBuffer(typeof(byte), 74)]
	public DualSenseHIDBluetoothOutputReport.<rawData>e__FixedBuffer rawData; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x284ECB0 Offset: 0x284D6B0 VA: 0x18284ECB0
	public static FourCC get_Type() { }

	// RVA: 0x284ECF0 Offset: 0x284D6F0 VA: 0x18284ECF0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2855E80 Offset: 0x2854880 VA: 0x182855E80
	public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize) { }
}
