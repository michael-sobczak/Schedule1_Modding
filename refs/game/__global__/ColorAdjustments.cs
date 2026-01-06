public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8910
{
	// Fields
	[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; // 0x38
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public ClampedFloatParameter contrast; // 0x40
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; // 0x48
	[Tooltip("Shift the hue of all colors.")]
	public ClampedFloatParameter hueShift; // 0x50
	[Tooltip("Pushes the intensity of all colors.")]
	public ClampedFloatParameter saturation; // 0x58

	// Methods

	// RVA: 0x2AFDF80 Offset: 0x2AFC980 VA: 0x182AFDF80 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2AFE080 Offset: 0x2AFCA80 VA: 0x182AFE080
	public void .ctor() { }
}
