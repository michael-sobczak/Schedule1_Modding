public class DepthOnlyPass : ScriptableRenderPass // TypeDefIndex: 9145
{
	// Fields
	private static readonly ShaderTagId k_ShaderTagId; // 0x0
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; // 0xE0
	private GraphicsFormat depthStencilFormat; // 0xE8
	[CompilerGenerated]
	private ShaderTagId <shaderTagId>k__BackingField; // 0xEC
	private DepthOnlyPass.PassData m_PassData; // 0xF0
	private FilteringSettings m_FilteringSettings; // 0xF8

	// Properties
	private RTHandle destination { get; set; }
	internal ShaderTagId shaderTagId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	private RTHandle get_destination() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x523390 Offset: 0x521D90 VA: 0x180523390
	internal ShaderTagId get_shaderTagId() { }

	[CompilerGenerated]
	// RVA: 0x1A3AEA0 Offset: 0x1A398A0 VA: 0x181A3AEA0
	internal void set_shaderTagId(ShaderTagId value) { }

	// RVA: 0x2B70CF0 Offset: 0x2B6F6F0 VA: 0x182B70CF0
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x2B70C40 Offset: 0x2B6F640 VA: 0x182B70C40
	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle) { }

	// RVA: 0x2B70670 Offset: 0x2B6F070 VA: 0x182B70670 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B70330 Offset: 0x2B6ED30 VA: 0x182B70330
	private static void ExecutePass(ScriptableRenderContext context, DepthOnlyPass.PassData passData, ref RenderingData renderingData) { }

	// RVA: 0x2B705B0 Offset: 0x2B6EFB0 VA: 0x182B705B0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B70730 Offset: 0x2B6F130 VA: 0x182B70730
	internal void Render(RenderGraph renderGraph, out TextureHandle cameraDepthTexture, ref RenderingData renderingData) { }

	// RVA: 0x2B70C80 Offset: 0x2B6F680 VA: 0x182B70C80
	private static void .cctor() { }
}
