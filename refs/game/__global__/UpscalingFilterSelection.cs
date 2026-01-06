public enum UpscalingFilterSelection // TypeDefIndex: 8755
{
	// Fields
	public int value__; // 0x0
	[Tooltip("Unity selects a filtering option automatically based on the Render Scale value and the current screen resolution.")]
	[InspectorName("Automatic")]
	public const UpscalingFilterSelection Auto = 0;
	[InspectorName("Bilinear")]
	public const UpscalingFilterSelection Linear = 1;
	[InspectorName("Nearest-Neighbor")]
	public const UpscalingFilterSelection Point = 2;
	[Tooltip("If the target device does not support Unity shader model 4.5, Unity falls back to the Automatic option.")]
	[InspectorName("FidelityFX Super Resolution 1.0")]
	public const UpscalingFilterSelection FSR = 3;
}
