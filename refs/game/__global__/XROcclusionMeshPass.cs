public class XROcclusionMeshPass : ScriptableRenderPass // TypeDefIndex: 8967
{
	// Fields
	private XROcclusionMeshPass.PassData m_PassData; // 0xE0
	public bool m_IsActiveTargetBackBuffer; // 0xE8

	// Methods

	// RVA: 0x2B2E760 Offset: 0x2B2D160 VA: 0x182B2E760
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2B2E130 Offset: 0x2B2CB30 VA: 0x182B2E130
	private static void ExecutePass(ScriptableRenderContext context, XROcclusionMeshPass.PassData data) { }

	// RVA: 0x2B2E230 Offset: 0x2B2CC30 VA: 0x182B2E230 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B2E3B0 Offset: 0x2B2CDB0 VA: 0x182B2E3B0
	internal void Render(RenderGraph renderGraph, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment, ref RenderingData renderingData) { }
}
