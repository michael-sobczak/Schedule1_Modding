public enum AntialiasingMode // TypeDefIndex: 9038
{
	// Fields
	public int value__; // 0x0
	[InspectorName("No Anti-aliasing")]
	public const AntialiasingMode None = 0;
	[InspectorName("Fast Approximate Anti-aliasing (FXAA)")]
	public const AntialiasingMode FastApproximateAntialiasing = 1;
	[InspectorName("Subpixel Morphological Anti-aliasing (SMAA)")]
	public const AntialiasingMode SubpixelMorphologicalAntiAliasing = 2;
	[InspectorName("Temporal Anti-aliasing (TAA)")]
	public const AntialiasingMode TemporalAntiAliasing = 3;
}
