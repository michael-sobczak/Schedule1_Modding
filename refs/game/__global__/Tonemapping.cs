public sealed class Tonemapping : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8932
{
	// Fields
	[Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
	public TonemappingModeParameter mode; // 0x38
	[Tooltip("Specifies the range reduction mode used when HDR output is enabled and Neutral tonemapping is enabled.")]
	[AdditionalProperty]
	public NeutralRangeReductionModeParameter neutralHDRRangeReductionMode; // 0x40
	[Tooltip("Use the ACES preset for HDR displays.")]
	public HDRACESPresetParameter acesPreset; // 0x48
	[Tooltip("Specify how much hue to preserve. Values closer to 0 are likely to preserve hue. As values get closer to 1, Unity doesn't correct hue shifts.")]
	public ClampedFloatParameter hueShiftAmount; // 0x50
	[Tooltip("Enable to use values detected from the output device as paper white. When enabled, output images might differ between SDR and HDR. For best accuracy, set this value manually.")]
	public BoolParameter detectPaperWhite; // 0x58
	[Tooltip("The reference brightness of a paper white surface. This property determines the maximum brightness of UI. The brightness of the scene is scaled relative to this value. The value is in nits.")]
	public ClampedFloatParameter paperWhite; // 0x60
	[Tooltip("Enable to use the minimum and maximum brightness values detected from the output device. For best accuracy, considering calibrating these values manually.")]
	public BoolParameter detectBrightnessLimits; // 0x68
	[Tooltip("The minimum brightness of the screen (in nits). This value is assumed to be 0.005f with ACES Tonemap.")]
	public ClampedFloatParameter minNits; // 0x70
	[Tooltip("The maximum brightness of the screen (in nits). This value is defined by the preset when using ACES Tonemap.")]
	public ClampedFloatParameter maxNits; // 0x78

	// Methods

	// RVA: 0x2B137F0 Offset: 0x2B121F0 VA: 0x182B137F0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B13820 Offset: 0x2B12220 VA: 0x182B13820
	public void .ctor() { }
}
