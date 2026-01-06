public class DrawSkyboxPass : ScriptableRenderPass // TypeDefIndex: 8944
{
	// Fields
	public bool m_IsActiveTargetBackBuffer; // 0xE0

	// Methods

	// RVA: 0x2B00D90 Offset: 0x2AFF790 VA: 0x182B00D90
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2B00790 Offset: 0x2AFF190 VA: 0x182B00790 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B00290 Offset: 0x2AFEC90 VA: 0x182B00290
	private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, CameraData cameraData) { }

	// RVA: 0x2B009E0 Offset: 0x2AFF3E0 VA: 0x182B009E0
	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData) { }
}
