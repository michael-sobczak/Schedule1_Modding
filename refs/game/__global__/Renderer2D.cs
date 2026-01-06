internal class Renderer2D : ScriptableRenderer // TypeDefIndex: 8723
{
	// Fields
	internal const int k_DepthBufferBits = 32;
	private const int k_FinalBlitPassQueueOffset = 1;
	private const int k_AfterFinalBlitPassQueueOffset = 2;
	private Render2DLightingPass m_Render2DLightingPass; // 0x1A8
	private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass; // 0x1B0
	private UpscalePass m_UpscalePass; // 0x1B8
	private FinalBlitPass m_FinalBlitPass; // 0x1C0
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; // 0x1C8
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; // 0x1D0
	private Light2DCullResult m_LightCullResult; // 0x1D8
	internal RenderTargetBufferSystem m_ColorBufferSystem; // 0x1E0
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private bool m_UseDepthStencilBuffer; // 0x1E8
	private bool m_CreateColorTexture; // 0x1E9
	private bool m_CreateDepthTexture; // 0x1EA
	private RTHandle m_ColorTextureHandle; // 0x1F0
	private RTHandle m_DepthTextureHandle; // 0x1F8
	private Material m_BlitMaterial; // 0x200
	private Material m_BlitHDRMaterial; // 0x208
	private Material m_SamplingMaterial; // 0x210
	private Renderer2DData m_Renderer2DData; // 0x218
	private PostProcessPasses m_PostProcessPasses; // 0x220

	// Properties
	internal bool createColorTexture { get; }
	internal bool createDepthTexture { get; }
	internal ColorGradingLutPass colorGradingLutPass { get; }
	internal PostProcessPass postProcessPass { get; }
	internal PostProcessPass finalPostProcessPass { get; }
	internal RTHandle afterPostProcessColorHandle { get; }
	internal RTHandle colorGradingLutHandle { get; }

	// Methods

	// RVA: 0x2A88C60 Offset: 0x2A87660 VA: 0x182A88C60
	internal bool get_createColorTexture() { }

	// RVA: 0x2A88C70 Offset: 0x2A87670 VA: 0x182A88C70
	internal bool get_createDepthTexture() { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	internal ColorGradingLutPass get_colorGradingLutPass() { }

	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	internal PostProcessPass get_postProcessPass() { }

	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00
	internal PostProcessPass get_finalPostProcessPass() { }

	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	internal RTHandle get_afterPostProcessColorHandle() { }

	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70
	internal RTHandle get_colorGradingLutHandle() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 5
	public override int SupportedCameraStackingTypes() { }

	// RVA: 0x2A88430 Offset: 0x2A86E30 VA: 0x182A88430
	public void .ctor(Renderer2DData data) { }

	// RVA: 0x2A86A50 Offset: 0x2A85450 VA: 0x182A86A50 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2A86E90 Offset: 0x2A85890 VA: 0x182A86E90 Slot: 9
	internal override void ReleaseRenderTargets() { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public Renderer2DData GetRenderer2DData() { }

	// RVA: 0x2A86C60 Offset: 0x2A85660 VA: 0x182A86C60
	private Renderer2D.RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData, ref CameraData cameraData) { }

	// RVA: 0x2A86450 Offset: 0x2A84E50 VA: 0x182A86450
	private void CreateRenderTextures(ref Renderer2D.RenderPassInputSummary renderPassInputs, CommandBuffer cmd, ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, out RTHandle colorTargetHandle, out RTHandle depthTargetHandle) { }

	// RVA: 0x2A86F90 Offset: 0x2A85990 VA: 0x182A86F90 Slot: 10
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2A86ED0 Offset: 0x2A858D0 VA: 0x182A86ED0 Slot: 12
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x2A88180 Offset: 0x2A86B80 VA: 0x182A88180 Slot: 16
	internal override void SwapColorBuffer(CommandBuffer cmd) { }

	// RVA: 0x2A86C30 Offset: 0x2A85630 VA: 0x182A86C30 Slot: 6
	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	// RVA: 0x2A86C00 Offset: 0x2A85600 VA: 0x182A86C00 Slot: 7
	internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	// RVA: 0x2A86BD0 Offset: 0x2A855D0 VA: 0x182A86BD0 Slot: 17
	internal override void EnableSwapBufferMSAA(bool enable) { }

	// RVA: 0x2A883A0 Offset: 0x2A86DA0 VA: 0x182A883A0
	private static void .cctor() { }
}
