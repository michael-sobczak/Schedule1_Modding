public enum DebugValidationMode // TypeDefIndex: 19312
{
	// Fields
	public int value__; // 0x0
	public const DebugValidationMode None = 0;
	[InspectorName("Highlight NaN, Inf and Negative Values")]
	public const DebugValidationMode HighlightNanInfNegative = 1;
	[InspectorName("Highlight Values Outside Range")]
	public const DebugValidationMode HighlightOutsideOfRange = 2;
}
