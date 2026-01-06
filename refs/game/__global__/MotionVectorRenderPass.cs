internal sealed class MotionVectorRenderPass : ScriptableRenderPass // TypeDefIndex: 8954
{
	// Fields
	private const string kPreviousViewProjectionNoJitter = "_PrevViewProjMatrix";
	private const string kViewProjectionNoJitter = "_NonJitteredViewProjMatrix";
	private const string kPreviousViewProjectionNoJitterStereo = "_PrevViewProjMatrixStereo";
	private const string kViewProjectionNoJitterStereo = "_NonJitteredViewProjMatrixStereo";
	internal const GraphicsFormat k_TargetFormat = 46;
	private static readonly string[] s_ShaderTags; // 0x0
	private RTHandle m_Color; // 0xE0
	private RTHandle m_Depth; // 0xE8
	private readonly Material m_CameraMaterial; // 0xF0
	private readonly Material m_ObjectMaterial; // 0xF8
	private MotionVectorRenderPass.PassData m_PassData; // 0x100

	// Methods

	// RVA: 0x2B07C50 Offset: 0x2B06650 VA: 0x182B07C50
	internal void .ctor(RenderPassEvent evt, Material cameraMaterial, Material objectMaterial) { }

	// RVA: 0x2B07B50 Offset: 0x2B06550 VA: 0x182B07B50
	internal void Setup(RTHandle color, RTHandle depth) { }

	// RVA: 0x2B068D0 Offset: 0x2B052D0 VA: 0x182B068D0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2B06EF0 Offset: 0x2B058F0 VA: 0x182B06EF0
	private static void ExecutePass(ScriptableRenderContext context, MotionVectorRenderPass.PassData passData, ref RenderingData renderingData) { }

	// RVA: 0x2B07320 Offset: 0x2B05D20 VA: 0x182B07320 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B073F0 Offset: 0x2B05DF0 VA: 0x182B073F0
	private static DrawingSettings GetDrawingSettings(ref RenderingData renderingData, Material objectMaterial) { }

	// RVA: 0x2B069D0 Offset: 0x2B053D0 VA: 0x182B069D0
	private static void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, Camera camera, Material cameraMaterial) { }

	// RVA: 0x2B06BB0 Offset: 0x2B055B0 VA: 0x182B06BB0
	private static void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera, Material objectMaterial, CommandBuffer cmd) { }

	// RVA: 0x2B07730 Offset: 0x2B06130 VA: 0x182B07730
	internal void Render(RenderGraph renderGraph, ref TextureHandle cameraDepthTexture, in TextureHandle motionVectorColor, in TextureHandle motionVectorDepth, ref RenderingData renderingData) { }

	// RVA: 0x2B07BA0 Offset: 0x2B065A0 VA: 0x182B07BA0
	private static void .cctor() { }
}
