internal class RenderGraphResourceRegistry // TypeDefIndex: 13539
{
	// Fields
	private const int kSharedResourceLifetime = 30;
	private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x0
	private RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources; // 0x10
	private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
	private RenderGraphDebugParams m_RenderGraphDebug; // 0x20
	private RenderGraphLogger m_ResourceLogger; // 0x28
	private RenderGraphLogger m_FrameInformationLogger; // 0x30
	private int m_CurrentFrameIndex; // 0x38
	private int m_ExecutionCount; // 0x3C
	private RTHandle m_CurrentBackbuffer; // 0x40
	private const int kInitialRendererListCount = 256;
	private List<RendererList> m_ActiveRendererLists; // 0x48

	// Properties
	internal static RenderGraphResourceRegistry current { get; set; }

	// Methods

	// RVA: 0x29D0EE0 Offset: 0x29CF8E0 VA: 0x1829D0EE0
	internal static RenderGraphResourceRegistry get_current() { }

	// RVA: 0x29D0F20 Offset: 0x29CF920 VA: 0x1829D0F20
	internal static void set_current(RenderGraphResourceRegistry value) { }

	// RVA: 0x29CF0A0 Offset: 0x29CDAA0 VA: 0x1829CF0A0
	internal RTHandle GetTexture(in TextureHandle handle) { }

	// RVA: 0x29D06B0 Offset: 0x29CF0B0 VA: 0x1829D06B0
	internal bool TextureNeedsFallback(in TextureHandle handle) { }

	// RVA: 0x29CEBF0 Offset: 0x29CD5F0 VA: 0x1829CEBF0
	internal RendererList GetRendererList(in RendererListHandle handle) { }

	// RVA: 0x29CE6F0 Offset: 0x29CD0F0 VA: 0x1829CE6F0
	internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle) { }

	// RVA: 0x29D0DB0 Offset: 0x29CF7B0 VA: 0x1829D0DB0
	private void .ctor() { }

	// RVA: 0x29D0820 Offset: 0x29CF220 VA: 0x1829D0820
	internal void .ctor(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) { }

	// RVA: 0x29CCE20 Offset: 0x29CB820 VA: 0x1829CCE20
	internal void BeginRenderGraph(int executionCount) { }

	// RVA: 0x29CCC50 Offset: 0x29CB650 VA: 0x1829CCC50
	internal void BeginExecute(int currentFrameIndex) { }

	// RVA: 0x29CE320 Offset: 0x29CCD20 VA: 0x1829CE320
	internal void EndExecute() { }

	// RVA: 0x29CCF90 Offset: 0x29CB990 VA: 0x1829CCF90
	private void CheckHandleValidity(in ResourceHandle res) { }

	// RVA: 0x29CCFF0 Offset: 0x29CB9F0 VA: 0x1829CCFF0
	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	// RVA: 0x29CF600 Offset: 0x29CE000 VA: 0x1829CF600
	internal void IncrementWriteCount(in ResourceHandle res) { }

	// RVA: 0x29CE8F0 Offset: 0x29CD2F0 VA: 0x1829CE8F0
	internal string GetRenderGraphResourceName(in ResourceHandle res) { }

	// RVA: 0x29CEA20 Offset: 0x29CD420 VA: 0x1829CEA20
	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) { }

	// RVA: 0x29CF900 Offset: 0x29CE300 VA: 0x1829CF900
	internal bool IsRenderGraphResourceImported(in ResourceHandle res) { }

	// RVA: 0x29CFA30 Offset: 0x29CE430 VA: 0x1829CFA30
	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) { }

	// RVA: 0x29CF730 Offset: 0x29CE130 VA: 0x1829CF730
	internal bool IsGraphicsResourceCreated(in ResourceHandle res) { }

	// RVA: 0x29CFA90 Offset: 0x29CE490 VA: 0x1829CFA90
	internal bool IsRendererListCreated(in RendererListHandle res) { }

	// RVA: 0x29CF860 Offset: 0x29CE260 VA: 0x1829CF860
	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) { }

	// RVA: 0x29CEAD0 Offset: 0x29CD4D0 VA: 0x1829CEAD0
	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res) { }

	// RVA: 0x29CF4E0 Offset: 0x29CDEE0 VA: 0x1829CF4E0
	internal TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x29CDC10 Offset: 0x29CC610 VA: 0x1829CDC10
	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease) { }

	// RVA: 0x29CFF30 Offset: 0x29CE930 VA: 0x1829CFF30
	internal void RefreshSharedTextureDesc(TextureHandle texture, in TextureDesc desc) { }

	// RVA: 0x29D0310 Offset: 0x29CED10 VA: 0x1829D0310
	internal void ReleaseSharedTexture(TextureHandle texture) { }

	// RVA: 0x29CF1F0 Offset: 0x29CDBF0 VA: 0x1829CF1F0
	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: 0x29CE180 Offset: 0x29CCB80 VA: 0x1829CE180
	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x29CECD0 Offset: 0x29CD6D0 VA: 0x1829CECD0
	internal int GetResourceCount(RenderGraphResourceType type) { }

	// RVA: 0x29CED40 Offset: 0x29CD740 VA: 0x1829CED40
	internal int GetTextureResourceCount() { }

	// RVA: 0x29CEF60 Offset: 0x29CD960 VA: 0x1829CEF60
	internal TextureResource GetTextureResource(in ResourceHandle handle) { }

	// RVA: 0x29CEDA0 Offset: 0x29CD7A0 VA: 0x1829CEDA0
	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x29CD720 Offset: 0x29CC120 VA: 0x1829CD720
	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x29CF3C0 Offset: 0x29CDDC0 VA: 0x1829CF3C0
	internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x29CD3B0 Offset: 0x29CBDB0 VA: 0x1829CD3B0
	internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x29CE440 Offset: 0x29CCE40 VA: 0x1829CE440
	internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x29CE3E0 Offset: 0x29CCDE0 VA: 0x1829CE3E0
	internal int GetComputeBufferResourceCount() { }

	// RVA: 0x29CE5B0 Offset: 0x29CCFB0 VA: 0x1829CE5B0
	private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle) { }

	// RVA: 0x29D0790 Offset: 0x29CF190 VA: 0x1829D0790
	internal void UpdateSharedResourceLastFrameIndex(int type, int index) { }

	// RVA: 0x29CFD20 Offset: 0x29CE720 VA: 0x1829CFD20
	private void ManageSharedRenderGraphResources() { }

	// RVA: 0x29CD4E0 Offset: 0x29CBEE0 VA: 0x1829CD4E0
	internal bool CreatePooledResource(RenderGraphContext rgContext, int type, int index) { }

	// RVA: 0x29CD670 Offset: 0x29CC070 VA: 0x1829CD670
	internal bool CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	// RVA: 0x29CDF00 Offset: 0x29CC900 VA: 0x1829CDF00
	private bool CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x29D01E0 Offset: 0x29CEBE0 VA: 0x1829D01E0
	internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index) { }

	// RVA: 0x29D0130 Offset: 0x29CEB30 VA: 0x1829D0130
	internal void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	// RVA: 0x29D04C0 Offset: 0x29CEEC0 VA: 0x1829D04C0
	private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ValidateTextureDesc(in TextureDesc desc) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ValidateComputeBufferDesc(in ComputeBufferDesc desc) { }

	// RVA: 0x29CD860 Offset: 0x29CC260 VA: 0x1829CD860
	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = False) { }

	// RVA: 0x29CD260 Offset: 0x29CBC60 VA: 0x1829CD260
	internal void Clear(bool onException) { }

	// RVA: 0x29CFEB0 Offset: 0x29CE8B0 VA: 0x1829CFEB0
	internal void PurgeUnusedGraphicsResources() { }

	// RVA: 0x29CD110 Offset: 0x29CBB10 VA: 0x1829CD110
	internal void Cleanup() { }

	// RVA: 0x29CE370 Offset: 0x29CCD70 VA: 0x1829CE370
	internal void FlushLogs() { }

	// RVA: 0x29CFB20 Offset: 0x29CE520 VA: 0x1829CFB20
	private void LogResources() { }
}
