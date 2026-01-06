public sealed class UniversalRenderer : ScriptableRenderer // TypeDefIndex: 9054
{
	// Fields
	private const GraphicsFormat k_DepthStencilFormat = 94;
	private const int k_DepthBufferBits = 32;
	private const int k_FinalBlitPassQueueOffset = 1;
	private const int k_AfterFinalBlitPassQueueOffset = 2;
	private static readonly List<ShaderTagId> k_DepthNormalsOnly; // 0x0
	private bool m_Clustering; // 0x1A8
	private DepthOnlyPass m_DepthPrepass; // 0x1B0
	private DepthNormalOnlyPass m_DepthNormalPrepass; // 0x1B8
	private CopyDepthPass m_PrimedDepthCopyPass; // 0x1C0
	private MotionVectorRenderPass m_MotionVectorPass; // 0x1C8
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; // 0x1D0
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; // 0x1D8
	private GBufferPass m_GBufferPass; // 0x1E0
	private CopyDepthPass m_GBufferCopyDepthPass; // 0x1E8
	private DeferredPass m_DeferredPass; // 0x1F0
	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass; // 0x1F8
	private DrawObjectsPass m_RenderOpaqueForwardPass; // 0x200
	private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass; // 0x208
	private DrawSkyboxPass m_DrawSkyboxPass; // 0x210
	private CopyDepthPass m_CopyDepthPass; // 0x218
	private CopyColorPass m_CopyColorPass; // 0x220
	private TransparentSettingsPass m_TransparentSettingsPass; // 0x228
	private DrawObjectsPass m_RenderTransparentForwardPass; // 0x230
	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass; // 0x238
	private FinalBlitPass m_FinalBlitPass; // 0x240
	private CapturePass m_CapturePass; // 0x248
	private XROcclusionMeshPass m_XROcclusionMeshPass; // 0x250
	private CopyDepthPass m_XRCopyDepthPass; // 0x258
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; // 0x260
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; // 0x268
	internal RenderTargetBufferSystem m_ColorBufferSystem; // 0x270
	internal RTHandle m_ActiveCameraColorAttachment; // 0x278
	private RTHandle m_ColorFrontBuffer; // 0x280
	internal RTHandle m_ActiveCameraDepthAttachment; // 0x288
	internal RTHandle m_CameraDepthAttachment; // 0x290
	private RTHandle m_XRTargetHandleAlias; // 0x298
	internal RTHandle m_DepthTexture; // 0x2A0
	private RTHandle m_NormalsTexture; // 0x2A8
	private RTHandle m_DecalLayersTexture; // 0x2B0
	private RTHandle m_OpaqueColor; // 0x2B8
	private RTHandle m_MotionVectorColor; // 0x2C0
	private RTHandle m_MotionVectorDepth; // 0x2C8
	private ForwardLights m_ForwardLights; // 0x2D0
	private DeferredLights m_DeferredLights; // 0x2D8
	private RenderingMode m_RenderingMode; // 0x2E0
	private DepthPrimingMode m_DepthPrimingMode; // 0x2E4
	private CopyDepthMode m_CopyDepthMode; // 0x2E8
	private bool m_DepthPrimingRecommended; // 0x2EC
	private StencilState m_DefaultStencilState; // 0x2ED
	private LightCookieManager m_LightCookieManager; // 0x300
	private IntermediateTextureMode m_IntermediateTextureMode; // 0x308
	private bool m_VulkanEnablePreTransform; // 0x30C
	private Material m_BlitMaterial; // 0x310
	private Material m_BlitHDRMaterial; // 0x318
	private Material m_CopyDepthMaterial; // 0x320
	private Material m_SamplingMaterial; // 0x328
	private Material m_StencilDeferredMaterial; // 0x330
	private Material m_CameraMotionVecMaterial; // 0x338
	private Material m_ObjectMotionVecMaterial; // 0x340
	private PostProcessPasses m_PostProcessPasses; // 0x348
	private static RTHandle m_RenderGraphCameraColorHandle; // 0x8
	private static RTHandle m_RenderGraphCameraDepthHandle; // 0x10
	internal static TextureHandle m_ActiveRenderGraphColor; // 0x18
	internal static TextureHandle m_ActiveRenderGraphDepth; // 0x20
	internal bool m_TargetIsBackbuffer; // 0x388
	internal UniversalRenderer.RenderGraphFrameResources frameResources; // 0x390
	private static bool m_UseIntermediateTexture; // 0x28

	// Properties
	internal RenderingMode renderingModeRequested { get; }
	internal RenderingMode renderingModeActual { get; }
	internal bool accurateGbufferNormals { get; }
	public DepthPrimingMode depthPrimingMode { get; set; }
	internal ColorGradingLutPass colorGradingLutPass { get; }
	internal PostProcessPass postProcessPass { get; }
	internal PostProcessPass finalPostProcessPass { get; }
	internal RTHandle colorGradingLut { get; }
	internal DeferredLights deferredLights { get; }

	// Methods

	// RVA: 0x2B3E460 Offset: 0x2B3CE60 VA: 0x182B3E460 Slot: 5
	public override int SupportedCameraStackingTypes() { }

	// RVA: 0x2B3FC20 Offset: 0x2B3E620 VA: 0x182B3FC20
	internal RenderingMode get_renderingModeRequested() { }

	// RVA: 0x2B3FB90 Offset: 0x2B3E590 VA: 0x182B3FB90
	internal RenderingMode get_renderingModeActual() { }

	// RVA: 0x2B3FB60 Offset: 0x2B3E560 VA: 0x182B3FB60
	internal bool get_accurateGbufferNormals() { }

	// RVA: 0x2B3FB80 Offset: 0x2B3E580 VA: 0x182B3FB80
	public DepthPrimingMode get_depthPrimingMode() { }

	// RVA: 0x2B3FC30 Offset: 0x2B3E630 VA: 0x182B3FC30
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	// RVA: 0xA026B0 Offset: 0xA010B0 VA: 0x180A026B0
	internal ColorGradingLutPass get_colorGradingLutPass() { }

	// RVA: 0xA02670 Offset: 0xA01070 VA: 0x180A02670
	internal PostProcessPass get_postProcessPass() { }

	// RVA: 0xA026A0 Offset: 0xA010A0 VA: 0x180A026A0
	internal PostProcessPass get_finalPostProcessPass() { }

	// RVA: 0xA02650 Offset: 0xA01050 VA: 0x180A02650
	internal RTHandle get_colorGradingLut() { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0
	internal DeferredLights get_deferredLights() { }

	// RVA: 0x2B3E7E0 Offset: 0x2B3D1E0 VA: 0x182B3E7E0
	public void .ctor(UniversalRendererData data) { }

	// RVA: 0x2B38E20 Offset: 0x2B37820 VA: 0x182B38E20 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2B3A420 Offset: 0x2B38E20 VA: 0x182B3A420 Slot: 9
	internal override void ReleaseRenderTargets() { }

	// RVA: 0x2B3ACE0 Offset: 0x2B396E0 VA: 0x182B3ACE0
	private void SetupFinalPassDebug(ref CameraData cameraData) { }

	// RVA: 0x2B39660 Offset: 0x2B38060 VA: 0x182B39660
	public static bool IsOffscreenDepthTexture(in CameraData cameraData) { }

	// RVA: 0x2B39520 Offset: 0x2B37F20 VA: 0x182B39520
	private bool IsDepthPrimingEnabled(ref CameraData cameraData) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private bool IsWebGL() { }

	// RVA: 0x2B39630 Offset: 0x2B38030 VA: 0x182B39630
	private bool IsGLESDevice() { }

	// RVA: 0x2B16560 Offset: 0x2B14F60 VA: 0x182B16560
	private bool IsGLDevice() { }

	// RVA: 0x2B3B140 Offset: 0x2B39B40 VA: 0x182B3B140 Slot: 10
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B3B0D0 Offset: 0x2B39AD0 VA: 0x182B3B0D0 Slot: 11
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B3A9E0 Offset: 0x2B393E0 VA: 0x182B3A9E0 Slot: 12
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x2B39260 Offset: 0x2B37C60 VA: 0x182B39260 Slot: 13
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x2B39060 Offset: 0x2B37A60 VA: 0x182B39060
	private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow) { }

	// RVA: 0x2B39320 Offset: 0x2B37D20 VA: 0x182B39320
	private UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData) { }

	// RVA: 0x2B37CB0 Offset: 0x2B366B0 VA: 0x182B37CB0
	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth, CommandBuffer cmd, ref CameraData cameraData) { }

	// RVA: 0x2B3A3B0 Offset: 0x2B38DB0 VA: 0x182B3A3B0
	private bool PlatformRequiresExplicitMsaaResolve() { }

	// RVA: 0x2B3A770 Offset: 0x2B39170 VA: 0x182B3A770
	private bool RequiresIntermediateColorTexture(ref CameraData cameraData) { }

	// RVA: 0x2B37B30 Offset: 0x2B36530 VA: 0x182B37B30
	private bool CanCopyDepth(ref CameraData cameraData) { }

	// RVA: 0x2B3E490 Offset: 0x2B3CE90 VA: 0x182B3E490 Slot: 16
	internal override void SwapColorBuffer(CommandBuffer cmd) { }

	// RVA: 0x2B392F0 Offset: 0x2B37CF0 VA: 0x182B392F0 Slot: 6
	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	// RVA: 0x2B392C0 Offset: 0x2B37CC0 VA: 0x182B392C0 Slot: 7
	internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	// RVA: 0x2B39030 Offset: 0x2B37A30 VA: 0x182B39030 Slot: 17
	internal override void EnableSwapBufferMSAA(bool enable) { }

	// RVA: 0x2B37C10 Offset: 0x2B36610 VA: 0x182B37C10
	private void CleanupRenderGraphResources() { }

	// RVA: 0x2B38D00 Offset: 0x2B37700 VA: 0x182B38D00
	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1) { }

	// RVA: 0x2B3A540 Offset: 0x2B38F40 VA: 0x182B3A540
	private bool RequiresColorAndDepthTextures(out bool createColorTexture, out bool createDepthTexture, ref RenderingData renderingData, UniversalRenderer.RenderPassInputSummary renderPassInputs) { }

	// RVA: 0x2B382B0 Offset: 0x2B36CB0 VA: 0x182B382B0
	private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B3A0F0 Offset: 0x2B38AF0 VA: 0x182B3A0F0 Slot: 14
	internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B399B0 Offset: 0x2B383B0 VA: 0x182B399B0 Slot: 15
	internal override void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B398A0 Offset: 0x2B382A0 VA: 0x182B398A0
	private void OnBeforeRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B39A50 Offset: 0x2B38450 VA: 0x182B39A50
	private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B396F0 Offset: 0x2B380F0 VA: 0x182B396F0
	private void OnAfterRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B3E6B0 Offset: 0x2B3D0B0 VA: 0x182B3E6B0
	private static void .cctor() { }
}
