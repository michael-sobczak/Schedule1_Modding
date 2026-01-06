internal static class RenderingLayerUtils // TypeDefIndex: 9003
{
	// Methods

	// RVA: 0x2B1CCD0 Offset: 0x2B1B6D0 VA: 0x182B1CCD0
	public static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, RenderingLayerUtils.Event rendererEvent, ref RenderingLayerUtils.Event combinedEvent) { }

	// RVA: 0x2B1CE50 Offset: 0x2B1B850 VA: 0x182B1CE50
	public static bool RequireRenderingLayers(UniversalRendererData universalRendererData, int msaaSampleCount, out RenderingLayerUtils.Event combinedEvent, out RenderingLayerUtils.MaskSize combinedMaskSize) { }

	// RVA: 0x2B1D130 Offset: 0x2B1BB30 VA: 0x182B1D130
	public static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out RenderingLayerUtils.Event combinedEvent, out RenderingLayerUtils.MaskSize combinedMaskSize) { }

	// RVA: 0x2B1D420 Offset: 0x2B1BE20 VA: 0x182B1D420
	public static void SetupProperties(CommandBuffer cmd, RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x2B1CD90 Offset: 0x2B1B790 VA: 0x182B1CD90
	public static GraphicsFormat GetFormat(RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x2B1D550 Offset: 0x2B1BF50 VA: 0x182B1D550
	public static uint ToValidRenderingLayers(uint renderingLayers) { }

	// RVA: 0x2B1CE10 Offset: 0x2B1B810 VA: 0x182B1CE10
	private static RenderingLayerUtils.MaskSize GetMaskSize(int bits) { }

	// RVA: 0x2B1CD00 Offset: 0x2B1B700 VA: 0x182B1CD00
	private static int GetBits(RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x4A0E20 Offset: 0x49F820 VA: 0x1804A0E20
	private static RenderingLayerUtils.Event Combine(RenderingLayerUtils.Event a, RenderingLayerUtils.Event b) { }

	// RVA: 0x2B1CCF0 Offset: 0x2B1B6F0 VA: 0x182B1CCF0
	private static RenderingLayerUtils.MaskSize Combine(RenderingLayerUtils.MaskSize a, RenderingLayerUtils.MaskSize b) { }
}
