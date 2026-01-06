public enum DynamicResUpscaleFilter // TypeDefIndex: 13582
{
	// Fields
	public byte value__; // 0x0
	[Obsolete("Bilinear upscale filter is considered obsolete and is not supported anymore, please use CatmullRom for a very cheap, but blurry filter.", False)]
	public const DynamicResUpscaleFilter Bilinear = 0;
	public const DynamicResUpscaleFilter CatmullRom = 1;
	[Obsolete("Lanczos upscale filter is considered obsolete and is not supported anymore, please use Contrast Adaptive Sharpening for very sharp filter or FidelityFX Super Resolution 1.0.", False)]
	public const DynamicResUpscaleFilter Lanczos = 2;
	public const DynamicResUpscaleFilter ContrastAdaptiveSharpen = 3;
	[InspectorName("FidelityFX Super Resolution 1.0")]
	public const DynamicResUpscaleFilter EdgeAdaptiveScalingUpres = 4;
	[InspectorName("TAA Upscale")]
	public const DynamicResUpscaleFilter TAAU = 5;
}
