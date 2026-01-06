internal class PostProcessPass : ScriptableRenderPass // TypeDefIndex: 8960
{
	// Fields
	private RenderTextureDescriptor m_Descriptor; // 0xE0
	private RTHandle m_Source; // 0x118
	private RTHandle m_Destination; // 0x120
	private RTHandle m_Depth; // 0x128
	private RTHandle m_InternalLut; // 0x130
	private RTHandle m_MotionVectors; // 0x138
	private RTHandle m_FullCoCTexture; // 0x140
	private RTHandle m_HalfCoCTexture; // 0x148
	private RTHandle m_PingTexture; // 0x150
	private RTHandle m_PongTexture; // 0x158
	private RTHandle[] m_BloomMipDown; // 0x160
	private RTHandle[] m_BloomMipUp; // 0x168
	private RTHandle m_BlendTexture; // 0x170
	private RTHandle m_EdgeColorTexture; // 0x178
	private RTHandle m_EdgeStencilTexture; // 0x180
	private RTHandle m_TempTarget; // 0x188
	private RTHandle m_TempTarget2; // 0x190
	private const string k_RenderPostProcessingTag = "Render PostProcessing Effects";
	private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";
	private static readonly ProfilingSampler m_ProfilingRenderPostProcessing; // 0x0
	private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing; // 0x8
	private PostProcessPass.MaterialLibrary m_Materials; // 0x198
	private PostProcessData m_Data; // 0x1A0
	private DepthOfField m_DepthOfField; // 0x1A8
	private MotionBlur m_MotionBlur; // 0x1B0
	private PaniniProjection m_PaniniProjection; // 0x1B8
	private Bloom m_Bloom; // 0x1C0
	private LensDistortion m_LensDistortion; // 0x1C8
	private ChromaticAberration m_ChromaticAberration; // 0x1D0
	private Vignette m_Vignette; // 0x1D8
	private ColorLookup m_ColorLookup; // 0x1E0
	private ColorAdjustments m_ColorAdjustments; // 0x1E8
	private Tonemapping m_Tonemapping; // 0x1F0
	private FilmGrain m_FilmGrain; // 0x1F8
	private const int k_MaxPyramidSize = 16;
	private readonly GraphicsFormat m_DefaultHDRFormat; // 0x200
	private bool m_UseRGBM; // 0x204
	private readonly GraphicsFormat m_SMAAEdgeFormat; // 0x208
	private readonly GraphicsFormat m_GaussianCoCFormat; // 0x20C
	private int m_DitheringTextureIndex; // 0x210
	private RenderTargetIdentifier[] m_MRT2; // 0x218
	private Vector4[] m_BokehKernel; // 0x220
	private int m_BokehHash; // 0x228
	private float m_BokehMaxRadius; // 0x22C
	private float m_BokehRCPAspect; // 0x230
	private bool m_IsFinalPass; // 0x234
	private bool m_HasFinalPass; // 0x235
	private bool m_EnableColorEncodingIfNeeded; // 0x236
	private bool m_UseFastSRGBLinearConversion; // 0x237
	private bool m_SupportDataDrivenLensFlare; // 0x238
	private bool m_ResolveToScreen; // 0x239
	private bool m_UseSwapBuffer; // 0x23A
	private RTHandle m_ScalingSetupTarget; // 0x240
	private RTHandle m_UpscaledTarget; // 0x248
	private Material m_BlitMaterial; // 0x250
	internal static readonly int k_ShaderPropertyId_ViewProjM; // 0x10
	internal static readonly int k_ShaderPropertyId_PrevViewProjM; // 0x14
	internal static readonly int k_ShaderPropertyId_ViewProjMStereo; // 0x18
	internal static readonly int k_ShaderPropertyId_PrevViewProjMStereo; // 0x1C

	// Methods

	// RVA: 0x2B11640 Offset: 0x2B10040 VA: 0x182B11640
	public void .ctor(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams) { }

	// RVA: 0x2B08AD0 Offset: 0x2B074D0 VA: 0x182B08AD0
	public void Cleanup() { }

	// RVA: 0x2B08B00 Offset: 0x2B07500 VA: 0x182B08B00
	public void Dispose() { }

	// RVA: 0x2B10C60 Offset: 0x2B0F660 VA: 0x182B10C60
	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, bool resolveToScreen, in RTHandle depth, in RTHandle internalLut, in RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding) { }

	// RVA: 0x2B10DD0 Offset: 0x2B0F7D0 VA: 0x182B10DD0
	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, RTHandle destination, in RTHandle depth, in RTHandle internalLut, bool hasFinalPass, bool enableColorEncoding) { }

	// RVA: 0x2B10140 Offset: 0x2B0EB40 VA: 0x182B10140
	public void SetupFinalPass(in RTHandle source, bool useSwapBuffer = False, bool enableColorEncoding = True) { }

	// RVA: 0xBCA100 Offset: 0xBC8B00 VA: 0x180BCA100 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool CanRunOnTile() { }

	// RVA: 0x2B0AD00 Offset: 0x2B09700 VA: 0x182B0AD00 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B0B110 Offset: 0x2B09B10 VA: 0x182B0B110
	private RenderTextureDescriptor GetCompatibleDescriptor() { }

	// RVA: 0x2B0B230 Offset: 0x2B09C30 VA: 0x182B0B230
	private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, DepthBits depthBufferBits = 0) { }

	// RVA: 0x2B0B1B0 Offset: 0x2B09BB0 VA: 0x182B0B1B0
	internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, DepthBits depthBufferBits = 0) { }

	// RVA: 0x2B0EB80 Offset: 0x2B0D580 VA: 0x182B0EB80
	private bool RequireSRGBConversionBlitToBackBuffer(ref CameraData cameraData) { }

	// RVA: 0x2B0EB50 Offset: 0x2B0D550 VA: 0x182B0EB50
	private bool RequireHDROutput(ref CameraData cameraData) { }

	// RVA: 0x2B0CCA0 Offset: 0x2B0B6A0 VA: 0x182B0CCA0
	private void Render(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B0A4F0 Offset: 0x2B08EF0 VA: 0x182B0A4F0
	private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	// RVA: 0x2B094B0 Offset: 0x2B07EB0 VA: 0x182B094B0
	private void DoDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	// RVA: 0x2B095E0 Offset: 0x2B07FE0 VA: 0x182B095E0
	private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	// RVA: 0x2B0BE80 Offset: 0x2B0A880 VA: 0x182B0BE80
	private void PrepareBokehKernel(float maxRadius, float rcpAspect) { }

	// RVA: 0x2B0B570 Offset: 0x2B09F70 VA: 0x182B0B570
	private static float GetMaxBokehRadiusInPixels(float viewportHeight) { }

	// RVA: 0x2B08CA0 Offset: 0x2B076A0 VA: 0x182B08CA0
	private void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	// RVA: 0x2B0B350 Offset: 0x2B09D50 VA: 0x182B0B350
	private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo) { }

	// RVA: 0x2B0B590 Offset: 0x2B09F90 VA: 0x182B0B590
	private void LensFlareDataDrivenComputeOcclusion(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	// RVA: 0x2B0B990 Offset: 0x2B0A390 VA: 0x182B0B990
	private void LensFlareDataDriven(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	// RVA: 0x2B11250 Offset: 0x2B0FC50 VA: 0x182B11250
	internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr) { }

	// RVA: 0x2B09F60 Offset: 0x2B08960 VA: 0x182B09F60
	private void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, ref CameraData cameraData) { }

	// RVA: 0x2B0A1A0 Offset: 0x2B08BA0 VA: 0x182B0A1A0
	private void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	// RVA: 0x2B08A60 Offset: 0x2B07460 VA: 0x182B08A60
	private Vector2 CalcViewExtents(Camera camera) { }

	// RVA: 0x2B08970 Offset: 0x2B07370 VA: 0x182B08970
	private Vector2 CalcCropExtents(Camera camera, float d) { }

	// RVA: 0x2B0EBB0 Offset: 0x2B0D5B0 VA: 0x182B0EBB0
	private void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial) { }

	// RVA: 0x2B10480 Offset: 0x2B0EE80 VA: 0x182B10480
	private void SetupLensDistortion(Material material, bool isSceneView) { }

	// RVA: 0x2B0FAB0 Offset: 0x2B0E4B0 VA: 0x182B0FAB0
	private void SetupChromaticAberration(Material material) { }

	// RVA: 0x2B108F0 Offset: 0x2B0F2F0 VA: 0x182B108F0
	private void SetupVignette(Material material, XRPass xrPass) { }

	// RVA: 0x2B0FBC0 Offset: 0x2B0E5C0 VA: 0x182B0FBC0
	private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material) { }

	// RVA: 0x2B10200 Offset: 0x2B0EC00 VA: 0x182B10200
	private void SetupGrain(ref CameraData cameraData, Material material) { }

	// RVA: 0x2B10090 Offset: 0x2B0EA90 VA: 0x182B10090
	private void SetupDithering(ref CameraData cameraData, Material material) { }

	// RVA: 0x2B10370 Offset: 0x2B0ED70 VA: 0x182B10370
	private void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations) { }

	// RVA: 0x2B0C280 Offset: 0x2B0AC80 VA: 0x182B0C280
	private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B114B0 Offset: 0x2B0FEB0 VA: 0x182B114B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x448650 Offset: 0x447050 VA: 0x180448650
	private RTHandle <Render>g__GetSource|69_0(ref PostProcessPass.<>c__DisplayClass69_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2B10ED0 Offset: 0x2B0F8D0 VA: 0x182B10ED0
	private RTHandle <Render>g__GetDestination|69_1(ref PostProcessPass.<>c__DisplayClass69_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2B11110 Offset: 0x2B0FB10 VA: 0x182B11110
	private void <Render>g__Swap|69_2(ref ScriptableRenderer r, ref PostProcessPass.<>c__DisplayClass69_0 ) { }
}
