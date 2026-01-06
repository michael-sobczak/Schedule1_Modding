public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 16963
{
	// Fields
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	public TextureParameter spectralLut; // 0x30
	[Range(0, 1)]
	[Tooltip("Amount of tangential distortion.")]
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; // 0x40

	// Methods

	// RVA: 0x2997CC0 Offset: 0x29966C0 VA: 0x182997CC0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2997D00 Offset: 0x2996700 VA: 0x182997D00
	public void .ctor() { }
}
