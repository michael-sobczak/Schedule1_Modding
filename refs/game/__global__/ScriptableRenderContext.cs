public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 12266
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	[FreeFunction("ScriptableRenderContext::BeginRenderPass")]
	// RVA: 0x2CF9480 Offset: 0x2CF7E80 VA: 0x182CF9480
	private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex) { }

	[FreeFunction("ScriptableRenderContext::BeginSubPass")]
	// RVA: 0x2CF95E0 Offset: 0x2CF7FE0 VA: 0x182CF95E0
	private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly) { }

	[FreeFunction("ScriptableRenderContext::EndSubPass")]
	// RVA: 0x2CFB100 Offset: 0x2CF9B00 VA: 0x182CFB100
	private static void EndSubPass_Internal(IntPtr self) { }

	[FreeFunction("ScriptableRenderContext::EndRenderPass")]
	// RVA: 0x2CFB050 Offset: 0x2CF9A50 VA: 0x182CFB050
	private static void EndRenderPass_Internal(IntPtr self) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
	// RVA: 0x2CFB8F0 Offset: 0x2CFA2F0 VA: 0x182CFB8F0
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	[FreeFunction("InitializeSortSettings")]
	// RVA: 0x2CFB840 Offset: 0x2CFA240 VA: 0x182CFB840
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	// RVA: 0x2CFC130 Offset: 0x2CFAB30 VA: 0x182CFC130
	private void Submit_Internal() { }

	// RVA: 0x2CFBFE0 Offset: 0x2CFA9E0 VA: 0x182CFBFE0
	private bool SubmitForRenderPassValidation_Internal() { }

	// RVA: 0x2CFB700 Offset: 0x2CFA100 VA: 0x182CFB700
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x2CFA6A0 Offset: 0x2CF90A0 VA: 0x182CFA6A0
	private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x2CFACC0 Offset: 0x2CF96C0 VA: 0x182CFACC0
	private void DrawShadows_Internal(IntPtr shadowDrawingSettings) { }

	[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
	// RVA: 0x2CFB010 Offset: 0x2CF9A10 VA: 0x182CFB010
	public static void EmitGeometryForCamera(Camera camera) { }

	[NativeThrows]
	// RVA: 0x2CFB510 Offset: 0x2CF9F10 VA: 0x182CFB510
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	[NativeThrows]
	// RVA: 0x2CFB310 Offset: 0x2CF9D10 VA: 0x182CFB310
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x2CFBDF0 Offset: 0x2CFA7F0 VA: 0x182CFBDF0
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x2CFB9B0 Offset: 0x2CFA3B0 VA: 0x182CFB9B0
	private void InvokeOnRenderObjectCallback_Internal() { }

	// RVA: 0x2CFAF30 Offset: 0x2CF9930 VA: 0x182CFAF30
	private void DrawWireOverlay_Impl(Camera camera) { }

	// RVA: 0x2CFAE00 Offset: 0x2CF9800 VA: 0x182CFAE00
	private void DrawUIOverlay_Internal(Camera camera) { }

	// RVA: 0x2CF98D0 Offset: 0x2CF82D0 VA: 0x182CF98D0
	private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x2CF9D20 Offset: 0x2CF8720 VA: 0x182CF9D20
	private RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR) { }

	// RVA: 0x2CFBB10 Offset: 0x2CFA510 VA: 0x182CFBB10
	private void PrepareRendererListsAsync_Internal(object rendererLists) { }

	// RVA: 0x2CFBC40 Offset: 0x2CFA640 VA: 0x182CFBC40
	private RendererListStatus QueryRendererListStatus_Internal(RendererList handle) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x2CF94E0 Offset: 0x2CF7EE0 VA: 0x182CF94E0
	public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1) { }

	// RVA: 0x2CF9660 Offset: 0x2CF8060 VA: 0x182CF9660
	public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = False) { }

	// RVA: 0x2CF9770 Offset: 0x2CF8170 VA: 0x182CF9770
	public void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = False) { }

	// RVA: 0x2CFB140 Offset: 0x2CF9B40 VA: 0x182CFB140
	public void EndSubPass() { }

	// RVA: 0x2CFB090 Offset: 0x2CF9A90 VA: 0x182CFB090
	public void EndRenderPass() { }

	// RVA: 0x2CFC1A0 Offset: 0x2CFABA0 VA: 0x182CFC1A0
	public void Submit() { }

	// RVA: 0x2CFC050 Offset: 0x2CFAA50 VA: 0x182CFC050
	public bool SubmitForRenderPassValidation() { }

	// RVA: 0x2CFB790 Offset: 0x2CFA190 VA: 0x182CFB790
	internal void GetCameras(List<Camera> results) { }

	// RVA: 0x2CFA780 Offset: 0x2CF9180 VA: 0x182CFA780
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings) { }

	// RVA: 0x2CFA840 Offset: 0x2CF9240 VA: 0x182CFA840
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock) { }

	// RVA: 0x2CFA930 Offset: 0x2CF9330 VA: 0x182CFA930
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks) { }

	// RVA: 0x2CFAD40 Offset: 0x2CF9740 VA: 0x182CFAD40
	public void DrawShadows(ref ShadowDrawingSettings settings) { }

	// RVA: 0x2CFB590 Offset: 0x2CF9F90 VA: 0x182CFB590
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x2CFB3A0 Offset: 0x2CF9DA0 VA: 0x182CFB3A0
	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x2CFBF20 Offset: 0x2CFA920 VA: 0x182CFBF20
	public void SetupCameraProperties(Camera camera, bool stereoSetup = False) { }

	// RVA: 0x2CFBE90 Offset: 0x2CFA890 VA: 0x182CFBE90
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x2CFBA20 Offset: 0x2CFA420 VA: 0x182CFBA20
	public void InvokeOnRenderObjectCallback() { }

	// RVA: 0x2CFAFB0 Offset: 0x2CF99B0 VA: 0x182CFAFB0
	public void DrawWireOverlay(Camera camera) { }

	// RVA: 0x2CFAE80 Offset: 0x2CF9880 VA: 0x182CFAE80
	public void DrawUIOverlay(Camera camera) { }

	// RVA: 0x2CFA530 Offset: 0x2CF8F30 VA: 0x182CFA530
	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	// RVA: 0x2CFB250 Offset: 0x2CF9C50 VA: 0x182CFB250 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x2CFB1B0 Offset: 0x2CF9BB0 VA: 0x182CFB1B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CD53B0 Offset: 0x2CD3DB0 VA: 0x182CD53B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CF99C0 Offset: 0x2CF83C0 VA: 0x182CF99C0
	public RendererList CreateRendererList(RendererListDesc desc) { }

	// RVA: 0x2CF9B60 Offset: 0x2CF8560 VA: 0x182CF9B60
	public RendererList CreateRendererList(ref RendererListParams param) { }

	// RVA: 0x2CFA060 Offset: 0x2CF8A60 VA: 0x182CFA060
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	// RVA: 0x2CF9DF0 Offset: 0x2CF87F0 VA: 0x182CF9DF0
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	// RVA: 0x2CFA230 Offset: 0x2CF8C30 VA: 0x182CFA230
	public RendererList CreateSkyboxRendererList(Camera camera) { }

	// RVA: 0x2CFBB90 Offset: 0x2CFA590 VA: 0x182CFBB90
	public void PrepareRendererListsAsync(List<RendererList> rendererLists) { }

	// RVA: 0x2CFBCC0 Offset: 0x2CFA6C0 VA: 0x182CFBCC0
	public RendererListStatus QueryRendererListStatus(RendererList rendererList) { }

	// RVA: 0x2CFC240 Offset: 0x2CFAC40 VA: 0x182CFC240
	private static void .cctor() { }

	// RVA: 0x2CFB890 Offset: 0x2CFA290 VA: 0x182CFB890
	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x2CFC0F0 Offset: 0x2CFAAF0 VA: 0x182CFC0F0
	private static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x2CFBFA0 Offset: 0x2CFA9A0 VA: 0x182CFBFA0
	private static bool SubmitForRenderPassValidation_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x2CFB6A0 Offset: 0x2CFA0A0 VA: 0x182CFB6A0
	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	// RVA: 0x2CFA620 Offset: 0x2CF9020 VA: 0x182CFA620
	private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x2CFAC70 Offset: 0x2CF9670 VA: 0x182CFAC70
	private static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings) { }

	// RVA: 0x2CFB4C0 Offset: 0x2CF9EC0 VA: 0x182CFB4C0
	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	// RVA: 0x2CFB2B0 Offset: 0x2CF9CB0 VA: 0x182CFB2B0
	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x2CFBD80 Offset: 0x2CFA780 VA: 0x182CFBD80
	private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x2CFB970 Offset: 0x2CFA370 VA: 0x182CFB970
	private static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x2CFAEE0 Offset: 0x2CF98E0 VA: 0x182CFAEE0
	private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }

	// RVA: 0x2CFADB0 Offset: 0x2CF97B0 VA: 0x182CFADB0
	private static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }

	// RVA: 0x2CF9850 Offset: 0x2CF8250 VA: 0x182CF9850
	private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret) { }

	// RVA: 0x2CF9CB0 Offset: 0x2CF86B0 VA: 0x182CF9CB0
	private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int mode, ref Matrix4x4 proj, ref Matrix4x4 view, ref Matrix4x4 projR, ref Matrix4x4 viewR, out RendererList ret) { }

	// RVA: 0x2CFBAC0 Offset: 0x2CFA4C0 VA: 0x182CFBAC0
	private static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, object rendererLists) { }

	// RVA: 0x2CFBBF0 Offset: 0x2CFA5F0 VA: 0x182CFBBF0
	private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref RendererList handle) { }
}
