public abstract class ScriptableRenderer : IDisposable // TypeDefIndex: 8880
{
	// Fields
	private const int kRenderPassMapSize = 10;
	private const int kRenderPassMaxCount = 20;
	private int m_LastBeginSubpassPassIndex; // 0x10
	private Dictionary<Hash128, int[]> m_MergeableRenderPassesMap; // 0x18
	private int[][] m_MergeableRenderPassesMapArrays; // 0x20
	private Hash128[] m_PassIndexToPassHash; // 0x28
	private Dictionary<Hash128, int> m_RenderPassesAttachmentCount; // 0x30
	private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors; // 0x38
	private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor; // 0x40
	private bool[] m_IsActiveColorAttachmentTransient; // 0xB8
	internal RenderBufferStoreAction[] m_FinalColorStoreAction; // 0xC0
	internal RenderBufferStoreAction m_FinalDepthStoreAction; // 0xC8
	[CompilerGenerated]
	private ProfilingSampler <profilingExecute>k__BackingField; // 0xD0
	internal bool hasReleasedRTs; // 0xD8
	[CompilerGenerated]
	private readonly DebugHandler <DebugHandler>k__BackingField; // 0xE0
	internal static ScriptableRenderer current; // 0x0
	[CompilerGenerated]
	private ScriptableRenderer.RenderingFeatures <supportedRenderingFeatures>k__BackingField; // 0xE8
	[CompilerGenerated]
	private GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField; // 0xF0
	private StoreActionsOptimization m_StoreActionsOptimizationSetting; // 0xF8
	private static bool m_UseOptimizedStoreActions; // 0x8
	private const int k_RenderPassBlockCount = 4;
	protected static readonly RTHandle k_CameraTarget; // 0x10
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; // 0x100
	private List<ScriptableRendererFeature> m_RendererFeatures; // 0x108
	private ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraColorTarget; // 0x110
	private ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget; // 0x140
	private ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget; // 0x170
	private bool m_FirstTimeCameraColorTargetIsBound; // 0x1A0
	private bool m_FirstTimeCameraDepthTargetIsBound; // 0x1A1
	private bool m_IsPipelineExecuting; // 0x1A2
	internal bool disableNativeRenderPassInFeatures; // 0x1A3
	internal bool useRenderPassEnabled; // 0x1A4
	private static RenderTargetIdentifier[] m_ActiveColorAttachments; // 0x18
	private static RenderTargetIdentifier m_ActiveDepthAttachment; // 0x20
	private static RenderBufferStoreAction[] m_ActiveColorStoreActions; // 0x48
	private static RenderBufferStoreAction m_ActiveDepthStoreAction; // 0x50
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies; // 0x58
	private static Plane[] s_Planes; // 0x60
	private static Vector4[] s_VectorPlanes; // 0x68
	[CompilerGenerated]
	private bool <useDepthPriming>k__BackingField; // 0x1A5
	[CompilerGenerated]
	private bool <stripShadowsOffVariants>k__BackingField; // 0x1A6
	[CompilerGenerated]
	private bool <stripAdditionalLightOffVariants>k__BackingField; // 0x1A7

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget")]
	public RenderTargetIdentifier cameraDepth { get; }
	protected ProfilingSampler profilingExecute { get; set; }
	internal DebugHandler DebugHandler { get; }
	[Obsolete("Use cameraColorTargetHandle")]
	public RenderTargetIdentifier cameraColorTarget { get; }
	public RTHandle cameraColorTargetHandle { get; }
	[Obsolete("Use cameraDepthTargetHandle")]
	public RenderTargetIdentifier cameraDepthTarget { get; }
	public RTHandle cameraDepthTargetHandle { get; }
	protected List<ScriptableRendererFeature> rendererFeatures { get; }
	protected List<ScriptableRenderPass> activeRenderPassQueue { get; }
	public ScriptableRenderer.RenderingFeatures supportedRenderingFeatures { get; set; }
	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }
	internal bool useDepthPriming { get; set; }
	internal bool stripShadowsOffVariants { get; set; }
	internal bool stripAdditionalLightOffVariants { get; set; }

	// Methods

	// RVA: 0x2AFB5B0 Offset: 0x2AF9FB0 VA: 0x182AFB5B0
	public RenderTargetIdentifier get_cameraDepth() { }

	// RVA: 0x2AF1940 Offset: 0x2AF0340 VA: 0x182AF1940
	internal void ResetNativeRenderPassFrameData() { }

	// RVA: 0x2AF8590 Offset: 0x2AF6F90 VA: 0x182AF8590
	internal void SetupNativeRenderPassFrameData(ref CameraData cameraData, bool isRenderPassEnabled) { }

	// RVA: 0x2AF9680 Offset: 0x2AF8080 VA: 0x182AF9680
	internal void UpdateFinalStoreActions(int[] currentMergeablePasses, ref CameraData cameraData) { }

	// RVA: 0x2AF2F70 Offset: 0x2AF1970 VA: 0x182AF2F70
	internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag) { }

	// RVA: 0x2AF1110 Offset: 0x2AEFB10 VA: 0x182AF1110
	private bool IsDepthOnlyRenderTexture(RenderTexture t) { }

	// RVA: 0x2AF20C0 Offset: 0x2AF0AC0 VA: 0x182AF20C0
	internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor) { }

	// RVA: 0x2AED390 Offset: 0x2AEBD90 VA: 0x182AED390
	internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref CameraData cameraData, ref RenderingData renderingData) { }

	// RVA: 0x2AF82E0 Offset: 0x2AF6CE0 VA: 0x182AF82E0
	internal void SetupInputAttachmentIndices(ScriptableRenderPass pass) { }

	// RVA: 0x2AF93A0 Offset: 0x2AF7DA0 VA: 0x182AF93A0
	internal void SetupTransientInputAttachments(int attachmentCount) { }

	// RVA: 0x2AF0040 Offset: 0x2AEEA40 VA: 0x182AF0040
	internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass) { }

	// RVA: 0x2AEADF0 Offset: 0x2AE97F0 VA: 0x182AEADF0
	internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass) { }

	// RVA: 0x2AF0190 Offset: 0x2AEEB90 VA: 0x182AF0190
	internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments) { }

	// RVA: 0x2AF03C0 Offset: 0x2AEEDC0 VA: 0x182AF03C0
	internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass) { }

	// RVA: 0x2AEF770 Offset: 0x2AEE170 VA: 0x182AEF770
	internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors) { }

	// RVA: 0x2AEF930 Offset: 0x2AEE330 VA: 0x182AEF930
	internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors) { }

	// RVA: 0x2AF0430 Offset: 0x2AEEE30 VA: 0x182AF0430
	internal static int GetValidPassIndexCount(int[] array) { }

	// RVA: 0x2AEFD30 Offset: 0x2AEE730 VA: 0x182AEFD30
	internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass) { }

	// RVA: 0x2AF1250 Offset: 0x2AEFC50 VA: 0x182AF1250
	internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass) { }

	// RVA: 0x2AEC590 Offset: 0x2AEAF90 VA: 0x182AEC590
	internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex) { }

	// RVA: 0x2AEC4F0 Offset: 0x2AEAEF0 VA: 0x182AEC4F0
	internal static Hash128 CreateRenderPassHash(ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex) { }

	// RVA: 0x2AEFE20 Offset: 0x2AEE820 VA: 0x182AEFE20
	internal static void GetRenderTextureDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT) { }

	// RVA: 0x2AF07E0 Offset: 0x2AEF1E0 VA: 0x182AF07E0
	private ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual int SupportedCameraStackingTypes() { }

	// RVA: 0x2AF9640 Offset: 0x2AF8040 VA: 0x182AF9640
	public bool SupportsCameraStackingType(CameraRenderType cameraRenderType) { }

	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	protected ProfilingSampler get_profilingExecute() { }

	[CompilerGenerated]
	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	protected void set_profilingExecute(ProfilingSampler value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal DebugHandler get_DebugHandler() { }

	// RVA: 0x2AF2030 Offset: 0x2AF0A30 VA: 0x182AF2030
	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices) { }

	// RVA: 0x2AF1A70 Offset: 0x2AF0470 VA: 0x182AF1A70
	internal static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped) { }

	// RVA: 0x2AF4C30 Offset: 0x2AF3630 VA: 0x182AF4C30
	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData) { }

	// RVA: 0x2AF4490 Offset: 0x2AF2E90 VA: 0x182AF4490
	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData, bool isTargetFlipped) { }

	// RVA: 0x2AF3B60 Offset: 0x2AF2560 VA: 0x182AF3B60
	private void SetPerCameraBillboardProperties(CommandBuffer cmd, ref CameraData cameraData) { }

	// RVA: 0x2AEB4F0 Offset: 0x2AE9EF0 VA: 0x182AEB4F0
	private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle) { }

	// RVA: 0x2AF4130 Offset: 0x2AF2B30 VA: 0x182AF4130
	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, ref CameraData cameraData) { }

	// RVA: 0x2AF3DA0 Offset: 0x2AF27A0 VA: 0x182AF3DA0
	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, in CameraData cameraData, bool isTargetFlipped) { }

	// RVA: 0x2AF7F40 Offset: 0x2AF6940 VA: 0x182AF7F40
	private static void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime) { }

	// RVA: 0x2AFB3D0 Offset: 0x2AF9DD0 VA: 0x182AFB3D0
	public RenderTargetIdentifier get_cameraColorTarget() { }

	// RVA: 0x2AFB350 Offset: 0x2AF9D50 VA: 0x182AFB350
	public RTHandle get_cameraColorTargetHandle() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	// RVA: 0x2AFB500 Offset: 0x2AF9F00 VA: 0x182AFB500
	public RenderTargetIdentifier get_cameraDepthTarget() { }

	// RVA: 0x2AFB480 Offset: 0x2AF9E80 VA: 0x182AFB480
	public RTHandle get_cameraDepthTargetHandle() { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	protected List<ScriptableRendererFeature> get_rendererFeatures() { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	protected List<ScriptableRenderPass> get_activeRenderPassQueue() { }

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	public void set_supportedRenderingFeatures(ScriptableRenderer.RenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_unsupportedGraphicsDeviceTypes(GraphicsDeviceType[] value) { }

	// RVA: 0x2AEBE40 Offset: 0x2AEA840 VA: 0x182AEBE40
	internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	[CompilerGenerated]
	// RVA: 0x2AFB610 Offset: 0x2AFA010 VA: 0x182AFB610
	internal bool get_useDepthPriming() { }

	[CompilerGenerated]
	// RVA: 0x2AFB640 Offset: 0x2AFA040 VA: 0x182AFB640
	internal void set_useDepthPriming(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2AFB600 Offset: 0x2AFA000 VA: 0x182AFB600
	internal bool get_stripShadowsOffVariants() { }

	[CompilerGenerated]
	// RVA: 0x2AFB630 Offset: 0x2AFA030 VA: 0x182AFB630
	internal void set_stripShadowsOffVariants(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2AFB5F0 Offset: 0x2AF9FF0 VA: 0x182AFB5F0
	internal bool get_stripAdditionalLightOffVariants() { }

	[CompilerGenerated]
	// RVA: 0x2AFB620 Offset: 0x2AFA020 VA: 0x182AFB620
	internal void set_stripAdditionalLightOffVariants(bool value) { }

	// RVA: 0x2AFA810 Offset: 0x2AF9210 VA: 0x182AFA810
	public void .ctor(ScriptableRendererData data) { }

	// RVA: 0x2AEC5D0 Offset: 0x2AEAFD0 VA: 0x182AEC5D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2AEC720 Offset: 0x2AEB120 VA: 0x182AEC720 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	internal virtual void ReleaseRenderTargets() { }

	[Obsolete("Use RTHandles for colorTarget and depthTarget")]
	// RVA: 0x2AEC1A0 Offset: 0x2AEABA0 VA: 0x182AEC1A0
	public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget) { }

	// RVA: 0x2AEC0C0 Offset: 0x2AEAAC0 VA: 0x182AEC0C0
	public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget) { }

	[Obsolete("Use RTHandles for colorTarget, depthTarget and resolveTarget")]
	// RVA: 0x2AEC3B0 Offset: 0x2AEADB0 VA: 0x182AEC3B0
	internal void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget, RenderTargetIdentifier resolveTarget) { }

	// RVA: 0x2AEC270 Offset: 0x2AEAC70 VA: 0x182AEC270
	internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget) { }

	[Obsolete("Use RTHandle for colorTarget")]
	// RVA: 0x2AEC050 Offset: 0x2AEAA50 VA: 0x182AEC050
	internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget) { }

	// RVA: 0x2AEBFE0 Offset: 0x2AEA9E0 VA: 0x182AEBFE0
	internal void ConfigureCameraColorTarget(RTHandle colorTarget) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AF0470 Offset: 0x2AEEE70 VA: 0x182AF0470
	private void InitRenderGraphFrame(RenderGraph renderGraph, ref RenderingData renderingData) { }

	// RVA: 0x2AF1290 Offset: 0x2AEFC90 VA: 0x182AF1290
	internal void ProcessVFXCameraCommand(RenderGraph renderGraph, ref RenderingData renderingData) { }

	// RVA: 0x2AF8D90 Offset: 0x2AF7790 VA: 0x182AF8D90
	internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, ref RenderingData renderingData, bool isTargetBackbuffer) { }

	// RVA: 0x2AEC740 Offset: 0x2AEB140 VA: 0x182AEC740
	internal void DrawRenderGraphGizmos(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset, ref RenderingData renderingData) { }

	// RVA: 0x2AEAEF0 Offset: 0x2AE98F0 VA: 0x182AEAEF0
	private void BeginRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData) { }

	// RVA: 0x2AECB70 Offset: 0x2AEB570 VA: 0x182AECB70
	private void EndRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData) { }

	// RVA: 0x2AF17C0 Offset: 0x2AF01C0 VA: 0x182AF17C0
	internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AEFA90 Offset: 0x2AEE490 VA: 0x182AEFA90
	internal void FinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	internal virtual void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AF14F0 Offset: 0x2AEFEF0 VA: 0x182AF14F0
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData, RenderPassEvent injectionPoint) { }

	// RVA: 0x2AF4180 Offset: 0x2AF2B80 VA: 0x182AF4180
	internal void SetPerCameraProperties(ScriptableRenderContext context, ref CameraData cameraData, Camera camera, CommandBuffer cmd) { }

	// RVA: 0x2AEE5A0 Offset: 0x2AECFA0 VA: 0x182AEE5A0
	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AED150 Offset: 0x2AEBB50 VA: 0x182AED150
	public void EnqueuePass(ScriptableRenderPass pass) { }

	// RVA: 0x2AEFB70 Offset: 0x2AEE570 VA: 0x182AEFB70
	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData) { }

	// RVA: 0x2AF1170 Offset: 0x2AEFB70 VA: 0x182AF1170
	internal void OnPreCullRenderPasses(in CameraData cameraData) { }

	// RVA: 0x2AEAB40 Offset: 0x2AE9540 VA: 0x182AEAB40
	internal void AddRenderPasses(ref RenderingData renderingData) { }

	// RVA: 0x2AF9230 Offset: 0x2AF7C30 VA: 0x182AF9230
	protected void SetupRenderPasses(in RenderingData renderingData) { }

	// RVA: 0x2AEB800 Offset: 0x2AEA200 VA: 0x182AEB800
	private static void ClearRenderingState(CommandBuffer cmd) { }

	// RVA: 0x2AEBB40 Offset: 0x2AEA540 VA: 0x182AEBB40
	internal void Clear(CameraRenderType cameraType) { }

	// RVA: 0x2AED210 Offset: 0x2AEBC10 VA: 0x182AED210
	private void ExecuteBlock(int blockIndex, in ScriptableRenderer.RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = False) { }

	// RVA: 0x2AF1140 Offset: 0x2AEFB40 VA: 0x182AF1140
	private bool IsRenderPassEnabled(ScriptableRenderPass renderPass) { }

	// RVA: 0x2AEE210 Offset: 0x2AECC10 VA: 0x182AEE210
	private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData) { }

	// RVA: 0x2AF4C80 Offset: 0x2AF3680 VA: 0x182AF4C80
	private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData) { }

	// RVA: 0x2AEB330 Offset: 0x2AE9D30 VA: 0x182AEB330
	private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	// RVA: 0x2AECFB0 Offset: 0x2AEB9B0 VA: 0x182AECFB0
	private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	// RVA: 0x2AF6560 Offset: 0x2AF4F60 VA: 0x182AF6560
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2AF7940 Offset: 0x2AF6340 VA: 0x182AF7940
	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	// RVA: 0x2AF68C0 Offset: 0x2AF52C0 VA: 0x182AF68C0
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2AF73C0 Offset: 0x2AF5DC0 VA: 0x182AF73C0
	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction) { }

	[Obsolete("Use RTHandle for colorAttachment")]
	// RVA: 0x2AF72F0 Offset: 0x2AF5CF0 VA: 0x182AF72F0
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor) { }

	// RVA: 0x2AF7750 Offset: 0x2AF6150 VA: 0x182AF7750
	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	// RVA: 0x2AF6C70 Offset: 0x2AF5670 VA: 0x182AF6C70
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	// RVA: 0x2AF70D0 Offset: 0x2AF5AD0 VA: 0x182AF70D0
	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	// RVA: 0x2AF7810 Offset: 0x2AF6210 VA: 0x182AF7810
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[Obsolete("Use RTHandle for colorAttachments")]
	// RVA: 0x2AF7E10 Offset: 0x2AF6810 VA: 0x182AF7E10
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2AF6E40 Offset: 0x2AF5840 VA: 0x182AF6E40
	private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	internal virtual void SwapColorBuffer(CommandBuffer cmd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	internal virtual void EnableSwapBufferMSAA(bool enable) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2AECB10 Offset: 0x2AEB510 VA: 0x182AECB10
	private void DrawWireOverlay(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2AF0F80 Offset: 0x2AEF980 VA: 0x182AF0F80
	private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AF0BB0 Offset: 0x2AEF5B0 VA: 0x182AF0BB0
	private void InternalFinishRendering(bool resolveFinalTarget, RenderingData renderingData) { }

	// RVA: 0x2AF0970 Offset: 0x2AEF370 VA: 0x182AF0970
	private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget, RenderingData renderingData) { }

	// RVA: 0x2AF94F0 Offset: 0x2AF7EF0 VA: 0x182AF94F0
	internal static void SortStable(List<ScriptableRenderPass> list) { }

	// RVA: 0x2AF9A30 Offset: 0x2AF8430 VA: 0x182AF9A30
	private static void .cctor() { }
}
