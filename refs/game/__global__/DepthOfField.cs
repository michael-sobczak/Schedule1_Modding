public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 16974
{
	// Fields
	[Min(0.1)]
	[Tooltip("Distance to the point of focus.")]
	public FloatParameter focusDistance; // 0x30
	[Range(0.05, 32)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public FloatParameter aperture; // 0x38
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	[Range(1, 300)]
	public FloatParameter focalLength; // 0x40
	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	public KernelSizeParameter kernelSize; // 0x48

	// Methods

	// RVA: 0x299DC10 Offset: 0x299C610 VA: 0x18299DC10 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x299DC50 Offset: 0x299C650 VA: 0x18299DC50
	public void .ctor() { }
}
