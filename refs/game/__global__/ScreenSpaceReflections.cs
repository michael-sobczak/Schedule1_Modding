public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 16996
{
	// Fields
	[Tooltip("Choose a quality preset, or use "Custom" to create your own custom preset. Don't use a preset higher than "Medium" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPresetParameter preset; // 0x30
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	[Range(0, 256)]
	public IntParameter maximumIterationCount; // 0x38
	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolutionParameter resolution; // 0x40
	[Range(1, 64)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public FloatParameter thickness; // 0x48
	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public FloatParameter maximumMarchDistance; // 0x50
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the near planes.")]
	public FloatParameter distanceFade; // 0x58
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the screen edges.")]
	public FloatParameter vignette; // 0x60

	// Methods

	// RVA: 0x29A7490 Offset: 0x29A5E90 VA: 0x1829A7490 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x29A7600 Offset: 0x29A6000 VA: 0x1829A7600
	public void .ctor() { }
}
