internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 16991
{
	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x29A58A0 Offset: 0x29A42A0 VA: 0x1829A58A0
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x29A4C00 Offset: 0x29A3600 VA: 0x1829A4C00
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x29A5180 Offset: 0x29A3B80 VA: 0x1829A5180
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x29A4E80 Offset: 0x29A3880 VA: 0x1829A4E80 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x29A50E0 Offset: 0x29A3AE0 VA: 0x1829A50E0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x29A49B0 Offset: 0x29A33B0 VA: 0x1829A49B0 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x29A4E10 Offset: 0x29A3810 VA: 0x1829A4E10 Slot: 8
	public void Release() { }
}
