public static class TemporalAA // TypeDefIndex: 9025
{
	// Fields
	private static readonly Vector2[] taaFilterOffsets; // 0x0
	private static readonly float[] taaFilterWeights; // 0x8

	// Methods

	// RVA: 0x2B2C3C0 Offset: 0x2B2ADC0 VA: 0x182B2C3C0
	internal static Matrix4x4 CalculateJitterMatrix(ref CameraData cameraData) { }

	// RVA: 0x2B2C5E0 Offset: 0x2B2AFE0 VA: 0x182B2C5E0
	internal static Vector2 CalculateJitter(int frameIndex) { }

	// RVA: 0x2B2C180 Offset: 0x2B2AB80 VA: 0x182B2C180
	internal static float[] CalculateFilterWeights(float jitterScale) { }

	// RVA: 0x2B2D240 Offset: 0x2B2BC40 VA: 0x182B2D240
	internal static string ValidateAndWarn(ref CameraData cameraData) { }

	// RVA: 0x2B2C640 Offset: 0x2B2B040 VA: 0x182B2C640
	internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors) { }

	// RVA: 0x2B2CAB0 Offset: 0x2B2B4B0 VA: 0x182B2CAB0
	internal static void Render(RenderGraph renderGraph, Material taaMaterial, ref CameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor) { }

	// RVA: 0x2B2D410 Offset: 0x2B2BE10 VA: 0x182B2D410
	private static void .cctor() { }
}
