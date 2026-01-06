public sealed class SplitToning : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8928
{
	// Fields
	[Tooltip("The color to use for shadows.")]
	public ColorParameter shadows; // 0x38
	[Tooltip("The color to use for highlights.")]
	public ColorParameter highlights; // 0x40
	[Tooltip("Balance between the colors in the highlights and shadows.")]
	public ClampedFloatParameter balance; // 0x48

	// Methods

	// RVA: 0x2B135C0 Offset: 0x2B11FC0 VA: 0x182B135C0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B13650 Offset: 0x2B12050 VA: 0x182B13650
	public void .ctor() { }
}
