public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 7632
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x0
	public float frequency; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x28660C0 Offset: 0x2864AC0 VA: 0x1828660C0
	public static FourCC get_Type() { }

	// RVA: 0x2866100 Offset: 0x2864B00 VA: 0x182866100 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2866050 Offset: 0x2864A50 VA: 0x182866050
	public static SetSamplingFrequencyCommand Create(float frequency) { }
}
