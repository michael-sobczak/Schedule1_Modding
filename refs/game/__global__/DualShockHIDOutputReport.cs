internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo // TypeDefIndex: 7601
{
	// Fields
	internal const int kSize = 40;
	internal const int kReportId = 5;
	public InputDeviceCommand baseCommand; // 0x0
	public byte reportId; // 0x8
	public byte flags; // 0x9
	[FixedBuffer(typeof(byte), 2)]
	public DualShockHIDOutputReport.<unknown1>e__FixedBuffer unknown1; // 0xA
	public byte highFrequencyMotorSpeed; // 0xC
	public byte lowFrequencyMotorSpeed; // 0xD
	public byte redColor; // 0xE
	public byte greenColor; // 0xF
	public byte blueColor; // 0x10
	[FixedBuffer(typeof(byte), 23)]
	public DualShockHIDOutputReport.<unknown2>e__FixedBuffer unknown2; // 0x11

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x284ECB0 Offset: 0x284D6B0 VA: 0x18284ECB0
	public static FourCC get_Type() { }

	// RVA: 0x284ECF0 Offset: 0x284D6F0 VA: 0x18284ECF0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2857980 Offset: 0x2856380 VA: 0x182857980
	public void SetMotorSpeeds(float lowFreq, float highFreq) { }

	// RVA: 0x2857900 Offset: 0x2856300 VA: 0x182857900
	public void SetColor(Color color) { }

	// RVA: 0x2857880 Offset: 0x2856280 VA: 0x182857880
	public static DualShockHIDOutputReport Create(int outputReportSize) { }
}
