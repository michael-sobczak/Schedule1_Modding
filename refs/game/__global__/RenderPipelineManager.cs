public static class RenderPipelineManager // TypeDefIndex: 12261
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static List<Camera> s_Cameras; // 0x8
	private static string s_CurrentPipelineType; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ScriptableRenderContext, Camera[]> endFrameRendering; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<ScriptableRenderContext, List<Camera>> beginContextRendering; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<ScriptableRenderContext, List<Camera>> endContextRendering; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ScriptableRenderContext, Camera> endCameraRendering; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineTypeChanged; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineCreated; // 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineDisposed; // 0x68

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	// RVA: 0x2CF7550 Offset: 0x2CF5F50 VA: 0x182CF7550
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x2CF77C0 Offset: 0x2CF61C0 VA: 0x182CF77C0
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGenerated]
	// RVA: 0x2CF7330 Offset: 0x2CF5D30 VA: 0x182CF7330
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x2CF75A0 Offset: 0x2CF5FA0 VA: 0x182CF75A0
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x2CF7440 Offset: 0x2CF5E40 VA: 0x182CF7440
	public static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x2CF76B0 Offset: 0x2CF60B0 VA: 0x182CF76B0
	public static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	// RVA: 0x2CF62A0 Offset: 0x2CF4CA0 VA: 0x182CF62A0
	internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x2CF6220 Offset: 0x2CF4C20 VA: 0x182CF6220
	internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2CF6AF0 Offset: 0x2CF54F0 VA: 0x182CF6AF0
	internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x2CF6A70 Offset: 0x2CF5470 VA: 0x182CF6A70
	internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6F50 Offset: 0x2CF5950 VA: 0x182CF6F50
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6E40 Offset: 0x2CF5840 VA: 0x182CF6E40
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6C30 Offset: 0x2CF5630 VA: 0x182CF6C30
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6390 Offset: 0x2CF4D90 VA: 0x182CF6390
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6BE0 Offset: 0x2CF55E0 VA: 0x182CF6BE0
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF6690 Offset: 0x2CF5090 VA: 0x182CF6690
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest) { }

	// RVA: 0x2CF6FC0 Offset: 0x2CF59C0 VA: 0x182CF6FC0
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x2CF6CD0 Offset: 0x2CF56D0 VA: 0x182CF6CD0
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x2CF7230 Offset: 0x2CF5C30 VA: 0x182CF7230
	private static void .cctor() { }
}
