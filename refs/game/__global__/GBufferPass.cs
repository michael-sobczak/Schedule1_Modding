internal class GBufferPass : ScriptableRenderPass // TypeDefIndex: 9158
{
	// Fields
	private static readonly int s_CameraNormalsTextureID; // 0x0
	private static ShaderTagId s_ShaderTagLit; // 0x4
	private static ShaderTagId s_ShaderTagSimpleLit; // 0x8
	private static ShaderTagId s_ShaderTagUnlit; // 0xC
	private static ShaderTagId s_ShaderTagComplexLit; // 0x10
	private static ShaderTagId s_ShaderTagUniversalGBuffer; // 0x14
	private static ShaderTagId s_ShaderTagUniversalMaterialType; // 0x18
	private ProfilingSampler m_ProfilingSampler; // 0xE0
	private DeferredLights m_DeferredLights; // 0xE8
	private static ShaderTagId[] s_ShaderTagValues; // 0x20
	private static RenderStateBlock[] s_RenderStateBlocks; // 0x28
	private FilteringSettings m_FilteringSettings; // 0xF0
	private RenderStateBlock m_RenderStateBlock; // 0x108
	private GBufferPass.PassData m_PassData; // 0x178

	// Methods

	// RVA: 0x2B75E70 Offset: 0x2B74870 VA: 0x182B75E70
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights) { }

	// RVA: 0x2B74730 Offset: 0x2B73130 VA: 0x182B74730
	public void Dispose() { }

	// RVA: 0x2B74380 Offset: 0x2B72D80 VA: 0x182B74380 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2B74BD0 Offset: 0x2B735D0 VA: 0x182B74BD0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B74760 Offset: 0x2B73160 VA: 0x182B74760
	private static void ExecutePass(ScriptableRenderContext context, GBufferPass.PassData data, ref RenderingData renderingData, bool useRenderGraph = False) { }

	// RVA: 0x2B74F70 Offset: 0x2B73970 VA: 0x182B74F70
	internal void Render(RenderGraph renderGraph, TextureHandle cameraColor, TextureHandle cameraDepth, ref RenderingData renderingData, ref UniversalRenderer.RenderGraphFrameResources frameResources) { }

	// RVA: 0x2B75CC0 Offset: 0x2B746C0 VA: 0x182B75CC0
	private static void .cctor() { }
}
