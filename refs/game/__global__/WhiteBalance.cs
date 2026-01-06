public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8937
{
	// Fields
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public ClampedFloatParameter temperature; // 0x38
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public ClampedFloatParameter tint; // 0x40

	// Methods

	// RVA: 0x2B14B50 Offset: 0x2B13550 VA: 0x182B14B50 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B14BD0 Offset: 0x2B135D0 VA: 0x182B14BD0
	public void .ctor() { }
}
