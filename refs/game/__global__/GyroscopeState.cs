internal struct GyroscopeState : IInputStateTypeInfo // TypeDefIndex: 7651
{
	// Fields
	[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = True)]
	public Vector3 angularVelocity; // 0x0

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x285AD70 Offset: 0x2859770 VA: 0x18285AD70
	public static FourCC get_kFormat() { }

	// RVA: 0x285AD30 Offset: 0x2859730 VA: 0x18285AD30 Slot: 4
	public FourCC get_format() { }
}
