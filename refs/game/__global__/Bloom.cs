public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 16959
{
	// Fields
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	[Min(0)]
	public FloatParameter intensity; // 0x30
	[Min(0)]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public FloatParameter threshold; // 0x38
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	[Range(0, 1)]
	public FloatParameter softKnee; // 0x40
	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	public FloatParameter clamp; // 0x48
	[Range(1, 10)]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	public FloatParameter diffusion; // 0x50
	[Range(-1, 1)]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	public FloatParameter anamorphicRatio; // 0x58
	[ColorUsage(False, True)]
	[Tooltip("Global tint of the bloom filter.")]
	public ColorParameter color; // 0x60
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; // 0x68
	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	[DisplayName("Texture")]
	public TextureParameter dirtTexture; // 0x70
	[Min(0)]
	[Tooltip("The intensity of the lens dirtiness.")]
	[DisplayName("Intensity")]
	public FloatParameter dirtIntensity; // 0x78

	// Methods

	// RVA: 0x29975D0 Offset: 0x2995FD0 VA: 0x1829975D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2997610 Offset: 0x2996010 VA: 0x182997610
	public void .ctor() { }
}
