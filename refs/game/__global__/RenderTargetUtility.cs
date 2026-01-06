public static class RenderTargetUtility // TypeDefIndex: 10842
{
	// Fields
	private static Nullable<RenderTextureFormat> hdrFormat; // 0x0

	// Methods

	// RVA: 0x486600 Offset: 0x485000 VA: 0x180486600
	public static int GetDepthSliceForEye(StereoTargetEyeMask mask) { }

	// RVA: 0x486510 Offset: 0x484F10 VA: 0x180486510
	public static RenderTargetIdentifier ComposeTarget(OutlineParameters parameters, RenderTargetIdentifier target) { }

	// RVA: 0x486CB0 Offset: 0x4856B0 VA: 0x180486CB0
	public static bool IsUsingVR(OutlineParameters parameters) { }

	// RVA: 0x4867B0 Offset: 0x4851B0 VA: 0x1804867B0
	public static RenderTargetUtility.RenderTextureInfo GetTargetInfo(OutlineParameters parameters, int width, int height, int depthBuffer, bool forceNoAA, bool noFiltering) { }

	// RVA: 0x486A90 Offset: 0x485490 VA: 0x180486A90
	public static void GetTemporaryRT(OutlineParameters parameters, int id, int width, int height, int depthBuffer, bool clear, bool forceNoAA, bool noFiltering) { }

	// RVA: 0x486690 Offset: 0x485090 VA: 0x180486690
	private static RenderTextureFormat GetHDRFormat() { }
}
