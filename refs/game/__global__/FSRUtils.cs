public static class FSRUtils // TypeDefIndex: 13858
{
	// Fields
	internal const float kMaxSharpnessStops = 2.5;
	public const float kDefaultSharpnessStops = 0.2;
	public const float kDefaultSharpnessLinear = 0.92;

	// Methods

	// RVA: 0x2A40290 Offset: 0x2A3EC90 VA: 0x182A40290
	public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	// RVA: 0x2A40670 Offset: 0x2A3F070 VA: 0x182A40670
	public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2) { }

	// RVA: 0x2A40590 Offset: 0x2A3EF90 VA: 0x182A40590
	public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92) { }

	// RVA: 0x2A40270 Offset: 0x2A3EC70 VA: 0x182A40270
	public static bool IsSupported() { }
}
