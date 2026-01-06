public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 17007
{
	// Fields
	[Tooltip("Use the "Classic" mode for parametric controls. Use the "Masked" mode to use your own texture mask.")]
	public VignetteModeParameter mode; // 0x30
	[Tooltip("Vignette color.")]
	public ColorParameter color; // 0x38
	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center; // 0x40
	[Range(0, 1)]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity; // 0x48
	[Range(0.01, 1)]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness; // 0x50
	[Tooltip("Lower values will make a square-ish vignette.")]
	[Range(0, 1)]
	public FloatParameter roundness; // 0x58
	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded; // 0x60
	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask; // 0x68
	[Tooltip("Mask opacity.")]
	[Range(0, 1)]
	public FloatParameter opacity; // 0x70

	// Methods

	// RVA: 0x29A97C0 Offset: 0x29A81C0 VA: 0x1829A97C0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x29A9890 Offset: 0x29A8290 VA: 0x1829A9890
	public void .ctor() { }
}
