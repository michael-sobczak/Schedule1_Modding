internal interface IAmbientOcclusionMethod // TypeDefIndex: 16953
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DepthTextureMode GetCameraFlags();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RenderAfterOpaque(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RenderAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CompositeAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();
}
