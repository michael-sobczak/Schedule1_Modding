public static class SRPHelper // TypeDefIndex: 338
{
	// Fields
	private static bool m_IsRenderPipelineCached; // 0x0
	private static RenderPipeline m_RenderPipelineCached; // 0x4

	// Properties
	public static string renderPipelineScriptingDefineSymbolAsString { get; }
	public static RenderPipeline projectRenderPipeline { get; }

	// Methods

	// RVA: 0x7B5C50 Offset: 0x7B4650 VA: 0x1807B5C50
	public static string get_renderPipelineScriptingDefineSymbolAsString() { }

	// RVA: 0x7B5AC0 Offset: 0x7B44C0 VA: 0x1807B5AC0
	public static RenderPipeline get_projectRenderPipeline() { }

	// RVA: 0x7B5800 Offset: 0x7B4200 VA: 0x1807B5800
	private static RenderPipeline ComputeRenderPipeline() { }

	// RVA: 0x7B5920 Offset: 0x7B4320 VA: 0x1807B5920
	public static bool IsUsingCustomRenderPipeline() { }

	// RVA: 0x7B59F0 Offset: 0x7B43F0 VA: 0x1807B59F0
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) { }

	// RVA: 0x7B5A60 Offset: 0x7B4460 VA: 0x1807B5A60
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) { }
}
