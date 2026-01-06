internal struct AttitudeState : IInputStateTypeInfo // TypeDefIndex: 7653
{
	// Fields
	[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = True)]
	public Quaternion attitude; // 0x0

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2853F60 Offset: 0x2852960 VA: 0x182853F60
	public static FourCC get_kFormat() { }

	// RVA: 0x2853F20 Offset: 0x2852920 VA: 0x182853F20 Slot: 4
	public FourCC get_format() { }
}
