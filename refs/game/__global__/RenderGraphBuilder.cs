public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 13518
{
	// Fields
	private RenderGraphPass m_RenderPass; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x8
	private RenderGraph m_RenderGraph; // 0x10
	private bool m_Disposed; // 0x18

	// Methods

	// RVA: 0x29CA170 Offset: 0x29C8B70 VA: 0x1829CA170
	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	// RVA: 0x29CA240 Offset: 0x29C8C40 VA: 0x1829CA240
	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	// RVA: 0x29C9F90 Offset: 0x29C8990 VA: 0x1829C9F90
	public TextureHandle ReadTexture(in TextureHandle input) { }

	// RVA: 0x29CA390 Offset: 0x29C8D90 VA: 0x1829CA390
	public TextureHandle WriteTexture(in TextureHandle input) { }

	// RVA: 0x29CA110 Offset: 0x29C8B10 VA: 0x1829CA110
	public TextureHandle ReadWriteTexture(in TextureHandle input) { }

	// RVA: 0x29C9D40 Offset: 0x29C8740 VA: 0x1829C9D40
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	// RVA: 0x29C9DA0 Offset: 0x29C87A0 VA: 0x1829C9DA0
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	// RVA: 0x29C9E80 Offset: 0x29C8880 VA: 0x1829C9E80
	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	// RVA: 0x29C9F60 Offset: 0x29C8960 VA: 0x1829C9F60
	public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x29CA340 Offset: 0x29C8D40 VA: 0x1829CA340
	public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x29C9CE0 Offset: 0x29C86E0 VA: 0x1829C9CE0
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x29C9C50 Offset: 0x29C8650 VA: 0x1829C9C50
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer) { }

	// RVA: -1 Offset: -1
	public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31850 Offset: 0xF30250 VA: 0x180F31850
	|-RenderGraphBuilder.SetRenderFunc<object>
	*/

	// RVA: 0x29C9F20 Offset: 0x29C8920 VA: 0x1829C9F20
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x29C9C10 Offset: 0x29C8610 VA: 0x1829C9C10
	public void AllowPassCulling(bool value) { }

	// RVA: 0x29C9EB0 Offset: 0x29C88B0 VA: 0x1829C9EB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x29C9C30 Offset: 0x29C8630 VA: 0x1829C9C30
	public void AllowRendererListCulling(bool value) { }

	// RVA: 0x29C9E80 Offset: 0x29C8880 VA: 0x1829C9E80
	public RendererListHandle DependsOn(in RendererListHandle input) { }

	// RVA: 0x29CA3E0 Offset: 0x29C8DE0 VA: 0x1829CA3E0
	internal void .ctor(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	// RVA: 0x29C9EB0 Offset: 0x29C88B0 VA: 0x1829C9EB0
	private void Dispose(bool disposing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckResource(in ResourceHandle res, bool dontCheckTransientReadWrite = False) { }

	// RVA: 0x29C9F40 Offset: 0x29C8940 VA: 0x1829C9F40
	internal void GenerateDebugData(bool value) { }
}
