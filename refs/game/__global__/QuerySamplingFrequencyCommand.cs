internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo // TypeDefIndex: 7626
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x0
	public float frequency; // 0x8

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865B70 Offset: 0x2864570 VA: 0x182865B70
	public static FourCC get_Type() { }

	// RVA: 0x2865BB0 Offset: 0x28645B0 VA: 0x182865BB0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2865B10 Offset: 0x2864510 VA: 0x182865B10
	public static QuerySamplingFrequencyCommand Create() { }
}
