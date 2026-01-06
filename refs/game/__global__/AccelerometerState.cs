internal struct AccelerometerState : IInputStateTypeInfo // TypeDefIndex: 7650
{
	// Fields
	[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = True)]
	public Vector3 acceleration; // 0x0

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2853AD0 Offset: 0x28524D0 VA: 0x182853AD0
	public static FourCC get_kFormat() { }

	// RVA: 0x2853A90 Offset: 0x2852490 VA: 0x182853A90 Slot: 4
	public FourCC get_format() { }
}
