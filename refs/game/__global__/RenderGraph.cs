public class RenderGraph // TypeDefIndex: 13516
{
	// Fields
	public static readonly int kMaxMRTCount; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x10
	private RenderGraphObjectPool m_RenderGraphPool; // 0x18
	private List<RenderGraphPass> m_RenderPasses; // 0x20
	private List<RendererListHandle> m_RendererLists; // 0x28
	private RenderGraphDebugParams m_DebugParameters; // 0x30
	private RenderGraphLogger m_FrameInformationLogger; // 0x38
	private RenderGraphDefaultResources m_DefaultResources; // 0x40
	private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers; // 0x48
	private bool m_ExecutionExceptionWasRaised; // 0x50
	private RenderGraphContext m_RenderGraphContext; // 0x58
	private CommandBuffer m_PreviousCommandBuffer; // 0x60
	private int m_CurrentImmediatePassIndex; // 0x68
	private List<int>[] m_ImmediateModeResourceList; // 0x70
	private DynamicArray<RenderGraph.CompiledResourceInfo>[] m_CompiledResourcesInfos; // 0x78
	private DynamicArray<RenderGraph.CompiledPassInfo> m_CompiledPassInfos; // 0x80
	private Stack<int> m_CullingStack; // 0x88
	private int m_ExecutionCount; // 0x90
	private int m_CurrentFrameIndex; // 0x94
	private bool m_HasRenderGraphBegun; // 0x98
	private string m_CurrentExecutionName; // 0xA0
	private bool m_RendererListCulling; // 0xA8
	private Dictionary<string, RenderGraphDebugData> m_DebugData; // 0xB0
	private static List<RenderGraph> s_RegisteredGraphs; // 0x8
	[CompilerGenerated]
	private string <name>k__BackingField; // 0xB8
	[CompilerGenerated]
	private static bool <requireDebugData>k__BackingField; // 0x10
	[CompilerGenerated]
	private static RenderGraph.OnGraphRegisteredDelegate onGraphRegistered; // 0x18
	[CompilerGenerated]
	private static RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered; // 0x20
	[CompilerGenerated]
	private static RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered; // 0x28
	[CompilerGenerated]
	private static RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered; // 0x30

	// Properties
	public string name { get; set; }
	internal static bool requireDebugData { get; set; }
	public RenderGraphDefaultResources defaultResources { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	private void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x29DA8D0 Offset: 0x29D92D0 VA: 0x1829DA8D0
	internal static bool get_requireDebugData() { }

	[CompilerGenerated]
	// RVA: 0x29DAD20 Offset: 0x29D9720 VA: 0x1829DAD20
	internal static void set_requireDebugData(bool value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public RenderGraphDefaultResources get_defaultResources() { }

	// RVA: 0x29D9D40 Offset: 0x29D8740 VA: 0x1829D9D40
	public void .ctor(string name = "RenderGraph") { }

	// RVA: 0x29D1B90 Offset: 0x29D0590 VA: 0x1829D1B90
	public void Cleanup() { }

	// RVA: 0x29D8AD0 Offset: 0x29D74D0 VA: 0x1829D8AD0
	public void RegisterDebug(DebugUI.Panel panel) { }

	// RVA: 0x29D8FD0 Offset: 0x29D79D0 VA: 0x1829D8FD0
	public void UnRegisterDebug() { }

	// RVA: 0x29D6570 Offset: 0x29D4F70 VA: 0x1829D6570
	public static List<RenderGraph> GetRegisteredRenderGraphs() { }

	// RVA: 0x29D5B00 Offset: 0x29D4500 VA: 0x1829D5B00
	internal RenderGraphDebugData GetDebugData(string executionName) { }

	// RVA: 0x29D4060 Offset: 0x29D2A60 VA: 0x1829D4060
	public void EndFrame() { }

	// RVA: 0x29D6950 Offset: 0x29D5350 VA: 0x1829D6950
	public TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x29D6640 Offset: 0x29D5040 VA: 0x1829D6640
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: 0x29D3930 Offset: 0x29D2330 VA: 0x1829D3930
	public TextureHandle CreateTexture(in TextureDesc desc) { }

	// RVA: 0x29D37F0 Offset: 0x29D21F0 VA: 0x1829D37F0
	public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = False) { }

	// RVA: 0x29D88C0 Offset: 0x29D72C0 VA: 0x1829D88C0
	public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc) { }

	// RVA: 0x29D8C90 Offset: 0x29D7690 VA: 0x1829D8C90
	public void ReleaseSharedTexture(TextureHandle texture) { }

	// RVA: 0x29D3960 Offset: 0x29D2360 VA: 0x1829D3960
	public TextureHandle CreateTexture(TextureHandle texture) { }

	// RVA: 0x29D3870 Offset: 0x29D2270 VA: 0x1829D3870
	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	// RVA: 0x29D65C0 Offset: 0x29D4FC0 VA: 0x1829D65C0
	public TextureDesc GetTextureDesc(TextureHandle texture) { }

	// RVA: 0x29D35A0 Offset: 0x29D1FA0 VA: 0x1829D35A0
	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x29D6820 Offset: 0x29D5220 VA: 0x1829D6820
	public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x29D3570 Offset: 0x29D1F70 VA: 0x1829D3570
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x29D3510 Offset: 0x29D1F10 VA: 0x1829D3510
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer) { }

	// RVA: 0x29D5AC0 Offset: 0x29D44C0 VA: 0x1829D5AC0
	public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer) { }

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32090 Offset: 0xF30A90 VA: 0x180F32090
	|-RenderGraph.AddRenderPass<object>
	*/

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32230 Offset: 0xF30C30 VA: 0x180F32230
	|-RenderGraph.AddRenderPass<object>
	*/

	// RVA: 0x29D8470 Offset: 0x29D6E70 VA: 0x1829D8470
	public RenderGraphExecution RecordAndExecute(in RenderGraphParameters parameters) { }

	// RVA: 0x29D48B0 Offset: 0x29D32B0 VA: 0x1829D48B0
	internal void Execute() { }

	// RVA: 0x29D17D0 Offset: 0x29D01D0 VA: 0x1829D17D0
	public void BeginProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x29D41F0 Offset: 0x29D2BF0 VA: 0x1829D41F0
	public void EndProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal DynamicArray<RenderGraph.CompiledPassInfo> GetCompiledPassInfos() { }

	// RVA: 0x29D1EB0 Offset: 0x29D08B0 VA: 0x1829D1EB0
	internal void ClearCompiledGraph() { }

	// RVA: 0x29D6E40 Offset: 0x29D5840 VA: 0x1829D6E40
	private void InvalidateContext() { }

	// RVA: 0x29D7900 Offset: 0x29D6300 VA: 0x1829D7900
	internal void OnPassAdded(RenderGraphPass pass) { }

	[CompilerGenerated]
	// RVA: 0x29DA6D0 Offset: 0x29D90D0 VA: 0x1829DA6D0
	internal static void add_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DAB20 Offset: 0x29D9520 VA: 0x1829DAB20
	internal static void remove_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DA7D0 Offset: 0x29D91D0 VA: 0x1829DA7D0
	internal static void add_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DAC20 Offset: 0x29D9620 VA: 0x1829DAC20
	internal static void remove_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DA4D0 Offset: 0x29D8ED0 VA: 0x1829DA4D0
	internal static void add_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DA920 Offset: 0x29D9320 VA: 0x1829DA920
	internal static void remove_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DA5D0 Offset: 0x29D8FD0 VA: 0x1829DA5D0
	internal static void add_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x29DAA20 Offset: 0x29D9420 VA: 0x1829DAA20
	internal static void remove_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	// RVA: 0x29D6A80 Offset: 0x29D5480 VA: 0x1829D6A80
	private void InitResourceInfosData(DynamicArray<RenderGraph.CompiledResourceInfo> resourceInfos, int count) { }

	// RVA: 0x29D6C10 Offset: 0x29D5610 VA: 0x1829D6C10
	private void InitializeCompilationData() { }

	// RVA: 0x29D2E90 Offset: 0x29D1890 VA: 0x1829D2E90
	private void CountReferences() { }

	// RVA: 0x29D3B20 Offset: 0x29D2520 VA: 0x1829D3B20
	private void CullUnusedPasses() { }

	// RVA: 0x29D91E0 Offset: 0x29D7BE0 VA: 0x1829D91E0
	private void UpdatePassSynchronization(ref RenderGraph.CompiledPassInfo currentPassInfo, ref RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	// RVA: 0x29D9B60 Offset: 0x29D8560 VA: 0x1829D9B60
	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in RenderGraph.CompiledResourceInfo resource) { }

	// RVA: 0x29D5C80 Offset: 0x29D4680 VA: 0x1829D5C80
	private int GetFirstValidConsumerIndex(int passIndex, in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x29D4A50 Offset: 0x29D3450 VA: 0x1829D4A50
	private int FindTextureProducer(int consumerPass, in RenderGraph.CompiledResourceInfo info, out int index) { }

	// RVA: 0x29D6210 Offset: 0x29D4C10 VA: 0x1829D6210
	private int GetLatestProducerIndex(int passIndex, in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x29D63B0 Offset: 0x29D4DB0 VA: 0x1829D63B0
	private int GetLatestValidReadIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x29D5DE0 Offset: 0x29D47E0 VA: 0x1829D5DE0
	private int GetFirstValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x29D6490 Offset: 0x29D4E90 VA: 0x1829D6490
	private int GetLatestValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x29D36F0 Offset: 0x29D20F0 VA: 0x1829D36F0
	private void CreateRendererLists() { }

	// RVA: 0x29D5EC0 Offset: 0x29D48C0 VA: 0x1829D5EC0
	internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback) { }

	// RVA: 0x29D1160 Offset: 0x29CFB60 VA: 0x1829D1160
	private void AllocateCulledPassResources(ref RenderGraph.CompiledPassInfo passInfo, int passIndex) { }

	// RVA: 0x29D9200 Offset: 0x29D7C00 VA: 0x1829D9200
	private void UpdateResourceAllocationAndSynchronization() { }

	// RVA: 0x29D1550 Offset: 0x29CFF50 VA: 0x1829D1550
	private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) { }

	// RVA: 0x29D8EB0 Offset: 0x29D78B0 VA: 0x1829D8EB0
	private void TryCullPassAtIndex(int passIndex) { }

	// RVA: 0x29D3A10 Offset: 0x29D2410 VA: 0x1829D3A10
	private void CullRendererLists() { }

	// RVA: 0x29D2A90 Offset: 0x29D1490 VA: 0x1829D2A90
	internal void CompileRenderGraph() { }

	// RVA: 0x29D2230 Offset: 0x29D0C30 VA: 0x1829D2230
	private ref RenderGraph.CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	// RVA: 0x29D4770 Offset: 0x29D3170 VA: 0x1829D4770
	private void ExecutePassImmediately(RenderGraphPass pass) { }

	// RVA: 0x29D4400 Offset: 0x29D2E00 VA: 0x1829D4400
	private void ExecuteCompiledPass(ref RenderGraph.CompiledPassInfo passInfo, int passIndex) { }

	// RVA: 0x29D47A0 Offset: 0x29D31A0 VA: 0x1829D47A0
	private void ExecuteRenderGraph() { }

	// RVA: 0x29D7F30 Offset: 0x29D6930 VA: 0x1829D7F30
	private void PreRenderPassSetRenderTargets(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x29D7BD0 Offset: 0x29D65D0 VA: 0x1829D7BD0
	private void PreRenderPassExecute(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x29D7950 Offset: 0x29D6350 VA: 0x1829D7950
	private void PostRenderPassExecute(ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x29D20C0 Offset: 0x29D0AC0 VA: 0x1829D20C0
	private void ClearRenderPasses() { }

	// RVA: 0x29D8B00 Offset: 0x29D7500 VA: 0x1829D8B00
	private void ReleaseImmediateModeResources() { }

	// RVA: 0x29D7280 Offset: 0x29D5C80 VA: 0x1829D7280
	private void LogFrameInformation() { }

	// RVA: 0x29D77D0 Offset: 0x29D61D0 VA: 0x1829D77D0
	private void LogRendererListsCreation() { }

	// RVA: 0x29D7430 Offset: 0x29D5E30 VA: 0x1829D7430
	private void LogRenderPassBegin(in RenderGraph.CompiledPassInfo passInfo) { }

	// RVA: 0x29D6EB0 Offset: 0x29D58B0 VA: 0x1829D6EB0
	private void LogCulledPasses() { }

	// RVA: 0x29D5B80 Offset: 0x29D4580 VA: 0x1829D5B80
	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	// RVA: 0x29D9050 Offset: 0x29D7A50 VA: 0x1829D9050
	private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList) { }

	// RVA: 0x29D4B30 Offset: 0x29D3530 VA: 0x1829D4B30
	private void GenerateDebugData() { }

	// RVA: 0x29D19E0 Offset: 0x29D03E0 VA: 0x1829D19E0
	private void CleanupDebugData() { }

	// RVA: 0x29D9C90 Offset: 0x29D8690 VA: 0x1829D9C90
	private static void .cctor() { }
}
