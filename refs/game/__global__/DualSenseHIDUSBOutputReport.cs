internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 7592
{
	// Fields
	internal const int kSize = 56;
	public InputDeviceCommand baseCommand; // 0x0
	public byte reportId; // 0x8
	public DualSenseHIDOutputReportPayload payload; // 0x9

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x284ECB0 Offset: 0x284D6B0 VA: 0x18284ECB0
	public static FourCC get_Type() { }

	// RVA: 0x284ECF0 Offset: 0x284D6F0 VA: 0x18284ECF0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2856110 Offset: 0x2854B10 VA: 0x182856110
	public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize) { }
}
