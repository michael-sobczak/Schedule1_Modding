public class DepthNormalOnlyPass : ScriptableRenderPass // TypeDefIndex: 9142
{
	// Fields
	[CompilerGenerated]
	private List<ShaderTagId> <shaderTagIds>k__BackingField; // 0xE0
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; // 0xE8
	[CompilerGenerated]
	private RTHandle <normalHandle>k__BackingField; // 0xF0
	[CompilerGenerated]
	private RTHandle <renderingLayersHandle>k__BackingField; // 0xF8
	[CompilerGenerated]
	private bool <enableRenderingLayers>k__BackingField; // 0x100
	private FilteringSettings m_FilteringSettings; // 0x104
	private DepthNormalOnlyPass.PassData m_PassData; // 0x120
	private static readonly List<ShaderTagId> k_DepthNormals; // 0x0
	private static readonly RTHandle[] k_ColorAttachment1; // 0x8
	private static readonly RTHandle[] k_ColorAttachment2; // 0x10

	// Properties
	internal List<ShaderTagId> shaderTagIds { get; set; }
	private RTHandle depthHandle { get; set; }
	private RTHandle normalHandle { get; set; }
	private RTHandle renderingLayersHandle { get; set; }
	internal bool enableRenderingLayers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal List<ShaderTagId> get_shaderTagIds() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	internal void set_shaderTagIds(List<ShaderTagId> value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	private RTHandle get_depthHandle() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	private void set_depthHandle(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	private RTHandle get_normalHandle() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	private void set_normalHandle(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	private RTHandle get_renderingLayersHandle() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	private void set_renderingLayersHandle(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	internal bool get_enableRenderingLayers() { }

	[CompilerGenerated]
	// RVA: 0x6051F0 Offset: 0x603BF0 VA: 0x1806051F0
	internal void set_enableRenderingLayers(bool value) { }

	// RVA: 0x2B70140 Offset: 0x2B6EB40 VA: 0x182B70140
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x2B6F320 Offset: 0x2B6DD20 VA: 0x182B6F320
	public static GraphicsFormat GetGraphicsFormat() { }

	// RVA: 0x2B6FE40 Offset: 0x2B6E840 VA: 0x182B6FE40
	public void Setup(RTHandle depthHandle, RTHandle normalHandle) { }

	// RVA: 0x2B6FE90 Offset: 0x2B6E890 VA: 0x182B6FE90
	public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle) { }

	// RVA: 0x2B6F4D0 Offset: 0x2B6DED0 VA: 0x182B6F4D0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B6EEA0 Offset: 0x2B6D8A0 VA: 0x182B6EEA0
	private static void ExecutePass(ScriptableRenderContext context, DepthNormalOnlyPass.PassData passData, ref RenderingData renderingData) { }

	// RVA: 0x2B6F230 Offset: 0x2B6DC30 VA: 0x182B6F230 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B6F3C0 Offset: 0x2B6DDC0 VA: 0x182B6F3C0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2B6F730 Offset: 0x2B6E130 VA: 0x182B6F730
	internal void Render(RenderGraph renderGraph, out TextureHandle cameraNormalsTexture, out TextureHandle cameraDepthTexture, ref RenderingData renderingData) { }

	// RVA: 0x2B6FF10 Offset: 0x2B6E910 VA: 0x182B6FF10
	private static void .cctor() { }
}
