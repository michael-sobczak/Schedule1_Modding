internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass // TypeDefIndex: 9146
{
	// Fields
	private RTHandle[] m_ColorTargetIndentifiers; // 0x198
	private RTHandle m_DepthTargetIndentifiers; // 0x1A0

	// Methods

	// RVA: 0x2B72A90 Offset: 0x2B71490 VA: 0x182B72A90
	public void .ctor(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x2B72850 Offset: 0x2B71250 VA: 0x182B72850
	public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment) { }

	// RVA: 0x2B727D0 Offset: 0x2B711D0 VA: 0x182B727D0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2B727F0 Offset: 0x2B711F0 VA: 0x182B727F0 Slot: 11
	protected override void OnExecute(CommandBuffer cmd) { }
}
