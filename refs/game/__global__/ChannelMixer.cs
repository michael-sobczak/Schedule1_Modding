public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8908
{
	// Fields
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter redOutRedIn; // 0x38
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter redOutGreenIn; // 0x40
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter redOutBlueIn; // 0x48
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter greenOutRedIn; // 0x50
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter greenOutGreenIn; // 0x58
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter greenOutBlueIn; // 0x60
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter blueOutRedIn; // 0x68
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter blueOutGreenIn; // 0x70
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter blueOutBlueIn; // 0x78

	// Methods

	// RVA: 0x2AFDA60 Offset: 0x2AFC460 VA: 0x182AFDA60 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2AFDC20 Offset: 0x2AFC620 VA: 0x182AFDC20
	public void .ctor() { }
}
