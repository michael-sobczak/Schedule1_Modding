public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8920
{
	// Fields
	[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
	public Vector4Parameter lift; // 0x38
	[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
	public Vector4Parameter gamma; // 0x40
	[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
	public Vector4Parameter gain; // 0x48

	// Methods

	// RVA: 0x2B02D70 Offset: 0x2B01770 VA: 0x182B02D70 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B02E20 Offset: 0x2B01820 VA: 0x182B02E20
	public void .ctor() { }
}
