public class FinalBlitPass : ScriptableRenderPass // TypeDefIndex: 9155
{
	// Fields
	private RTHandle m_Source; // 0xE0
	private FinalBlitPass.PassData m_PassData; // 0xE8
	private FinalBlitPass.BlitMaterialData[] m_BlitMaterialData; // 0xF0

	// Methods

	// RVA: 0x2B74130 Offset: 0x2B72B30 VA: 0x182B74130
	public void .ctor(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Dispose() { }

	[Obsolete("Use RTHandles for colorHandle")]
	// RVA: 0x2B73F10 Offset: 0x2B72910 VA: 0x182B73F10
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle) { }

	// RVA: 0x2B74110 Offset: 0x2B72B10 VA: 0x182B74110
	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle) { }

	// RVA: 0x2B73E60 Offset: 0x2B72860 VA: 0x182B73E60
	private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters) { }

	// RVA: 0x2B73960 Offset: 0x2B72360 VA: 0x182B73960 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B72EF0 Offset: 0x2B718F0 VA: 0x182B72EF0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B72D40 Offset: 0x2B71740 VA: 0x182B72D40
	private static void ExecutePass(ref RenderingData renderingData, in FinalBlitPass.BlitMaterialData blitMaterialData, RTHandle cameraTarget, RTHandle source) { }

	// RVA: 0x2B737A0 Offset: 0x2B721A0 VA: 0x182B737A0
	private void InitPassData(ref RenderingData renderingData, ref FinalBlitPass.PassData passData, FinalBlitPass.BlitType blitType) { }

	// RVA: 0x2B73A10 Offset: 0x2B72410 VA: 0x182B73A10
	internal void Render(RenderGraph renderGraph, ref RenderingData renderingData, TextureHandle src, TextureHandle dest, TextureHandle overlayUITexture) { }
}
