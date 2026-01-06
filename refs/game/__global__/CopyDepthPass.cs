public class CopyDepthPass : ScriptableRenderPass // TypeDefIndex: 9136
{
	// Fields
	[CompilerGenerated]
	private RTHandle <source>k__BackingField; // 0xE0
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; // 0xE8
	[CompilerGenerated]
	private int <MssaSamples>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <CopyToDepth>k__BackingField; // 0xF4
	private Material m_CopyDepthMaterial; // 0xF8
	internal bool m_CopyResolvedDepth; // 0x100
	internal bool m_ShouldClear; // 0x101
	private CopyDepthPass.PassData m_PassData; // 0x108

	// Properties
	private RTHandle source { get; set; }
	private RTHandle destination { get; set; }
	internal int MssaSamples { get; set; }
	internal bool CopyToDepth { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	private RTHandle get_source() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	private void set_source(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	private RTHandle get_destination() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x1A3A440 Offset: 0x1A38E40 VA: 0x181A3A440
	internal int get_MssaSamples() { }

	[CompilerGenerated]
	// RVA: 0x1A3AE90 Offset: 0x1A39890 VA: 0x181A3AE90
	internal void set_MssaSamples(int value) { }

	[CompilerGenerated]
	// RVA: 0x2B6E890 Offset: 0x2B6D290 VA: 0x182B6E890
	internal bool get_CopyToDepth() { }

	[CompilerGenerated]
	// RVA: 0x2B6E8A0 Offset: 0x2B6D2A0 VA: 0x182B6E8A0
	internal void set_CopyToDepth(bool value) { }

	// RVA: 0x2B6E750 Offset: 0x2B6D150 VA: 0x182B6E750
	public void .ctor(RenderPassEvent evt, Material copyDepthMaterial, bool shouldClear = False, bool copyToDepth = False, bool copyResolvedDepth = False) { }

	// RVA: 0x2B6E700 Offset: 0x2B6D100 VA: 0x182B6E700
	public void Setup(RTHandle source, RTHandle destination) { }

	// RVA: 0x2B6DCB0 Offset: 0x2B6C6B0 VA: 0x182B6DCB0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B6DA50 Offset: 0x2B6C450 VA: 0x182B6DA50 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B6D160 Offset: 0x2B6BB60 VA: 0x182B6D160
	private static void ExecutePass(ScriptableRenderContext context, CopyDepthPass.PassData passData, ref CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination) { }

	// RVA: 0x2B6DBF0 Offset: 0x2B6C5F0 VA: 0x182B6DBF0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2B6DDF0 Offset: 0x2B6C7F0 VA: 0x182B6DDF0
	internal void Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, ref RenderingData renderingData) { }
}
