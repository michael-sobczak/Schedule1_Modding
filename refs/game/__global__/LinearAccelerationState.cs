internal struct LinearAccelerationState : IInputStateTypeInfo // TypeDefIndex: 7654
{
	// Fields
	[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = True)]
	public Vector3 acceleration; // 0x0

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2864E80 Offset: 0x2863880 VA: 0x182864E80
	public static FourCC get_kFormat() { }

	// RVA: 0x2864E40 Offset: 0x2863840 VA: 0x182864E40 Slot: 4
	public FourCC get_format() { }
}
