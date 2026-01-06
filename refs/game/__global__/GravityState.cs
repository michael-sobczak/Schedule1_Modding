internal struct GravityState : IInputStateTypeInfo // TypeDefIndex: 7652
{
	// Fields
	[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = True)]
	public Vector3 gravity; // 0x0

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x285ACF0 Offset: 0x28596F0 VA: 0x18285ACF0
	public static FourCC get_kFormat() { }

	// RVA: 0x285ACB0 Offset: 0x28596B0 VA: 0x18285ACB0 Slot: 4
	public FourCC get_format() { }
}
