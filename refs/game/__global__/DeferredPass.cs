internal class DeferredPass : ScriptableRenderPass // TypeDefIndex: 9139
{
	// Fields
	private DeferredLights m_DeferredLights; // 0xE0

	// Methods

	// RVA: 0x2B6EDD0 Offset: 0x2B6D7D0 VA: 0x182B6EDD0
	public void .ctor(RenderPassEvent evt, DeferredLights deferredLights) { }

	// RVA: 0x2B6E8B0 Offset: 0x2B6D2B0 VA: 0x182B6E8B0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor) { }

	// RVA: 0x2B6E950 Offset: 0x2B6D350 VA: 0x182B6E950 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B6E9B0 Offset: 0x2B6D3B0 VA: 0x182B6E9B0
	internal void Render(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer, ref RenderingData renderingData) { }

	// RVA: 0x2B6E980 Offset: 0x2B6D380 VA: 0x182B6E980 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}
