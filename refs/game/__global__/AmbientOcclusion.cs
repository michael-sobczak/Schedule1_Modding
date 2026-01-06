public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 16952
{
	// Fields
	[Tooltip("The ambient occlusion method to use. "Multi Scale Volumetric Obscurance" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode; // 0x30
	[Range(0, 4)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity; // 0x38
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	[ColorUsage(False)]
	public ColorParameter color; // 0x40
	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly; // 0x48
	[Range(-8, 0)]
	public FloatParameter noiseFilterTolerance; // 0x50
	[Range(-8, -1)]
	public FloatParameter blurTolerance; // 0x58
	[Range(-12, -1)]
	public FloatParameter upsampleTolerance; // 0x60
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	[Range(1, 10)]
	public FloatParameter thicknessModifier; // 0x68
	[Range(0, 0.001)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias; // 0x70
	[Range(0, 1)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength; // 0x78
	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius; // 0x80
	[Tooltip("The number of sample points. This affects both quality and performance. For "Lowest", "Low", and "Medium", passes are downsampled. For "High" and "Ultra", they are not and therefore you should only "High" and "Ultra" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality; // 0x88

	// Methods

	// RVA: 0x2994D20 Offset: 0x2993720 VA: 0x182994D20 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2995090 Offset: 0x2993A90 VA: 0x182995090
	public void .ctor() { }
}
