public class DrawObjectsPass : ScriptableRenderPass // TypeDefIndex: 9149
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0xE0
	private RenderStateBlock m_RenderStateBlock; // 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x168
	private string m_ProfilerTag; // 0x170
	private ProfilingSampler m_ProfilingSampler; // 0x178
	private bool m_IsOpaque; // 0x180
	public bool m_IsActiveTargetBackBuffer; // 0x181
	public bool m_ShouldTransparentsReceiveShadows; // 0x182
	private DrawObjectsPass.PassData m_PassData; // 0x188
	private bool m_UseDepthPriming; // 0x190
	private static readonly int s_DrawObjectPassDataPropID; // 0x0

	// Methods

	// RVA: 0x2B72190 Offset: 0x2B70B90 VA: 0x182B72190
	public void .ctor(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x2B71FF0 Offset: 0x2B709F0 VA: 0x182B71FF0
	public void .ctor(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x2B72590 Offset: 0x2B70F90 VA: 0x182B72590
	internal void .ctor(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x2B71660 Offset: 0x2B70060 VA: 0x182B71660 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B70EE0 Offset: 0x2B6F8E0 VA: 0x182B70EE0
	private static void CameraSetup(CommandBuffer cmd, DrawObjectsPass.PassData data, ref RenderingData renderingData) { }

	// RVA: 0x2B70FC0 Offset: 0x2B6F9C0 VA: 0x182B70FC0
	private static void ExecutePass(ScriptableRenderContext context, DrawObjectsPass.PassData data, ref RenderingData renderingData, bool yFlip) { }

	// RVA: 0x2B719E0 Offset: 0x2B703E0 VA: 0x182B719E0
	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, ref RenderingData renderingData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void OnExecute(CommandBuffer cmd) { }

	// RVA: 0x2B71FA0 Offset: 0x2B709A0 VA: 0x182B71FA0
	private static void .cctor() { }
}
