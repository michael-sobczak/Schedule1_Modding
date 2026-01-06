internal class DeferredLights // TypeDefIndex: 9117
{
	// Fields
	internal static readonly string[] k_GBufferNames; // 0x0
	private static readonly string[] k_StencilDeferredPassNames; // 0x8
	private static readonly ushort k_InvalidLightOffset; // 0x10
	private static readonly string k_SetupLights; // 0x18
	private static readonly string k_DeferredPass; // 0x20
	private static readonly string k_DeferredStencilPass; // 0x28
	private static readonly string k_DeferredFogPass; // 0x30
	private static readonly string k_ClearStencilPartial; // 0x38
	private static readonly string k_SetupLightConstants; // 0x40
	private static readonly float kStencilShapeGuard; // 0x48
	private static readonly ProfilingSampler m_ProfilingSetupLights; // 0x50
	private static readonly ProfilingSampler m_ProfilingDeferredPass; // 0x58
	private static readonly ProfilingSampler m_ProfilingSetupLightConstants; // 0x60
	[CompilerGenerated]
	private RenderingLayerUtils.MaskSize <RenderingLayerMaskSize>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <UseDecalLayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <UseRenderPass>k__BackingField; // 0x15
	[CompilerGenerated]
	private bool <HasDepthPrepass>k__BackingField; // 0x16
	[CompilerGenerated]
	private bool <HasNormalPrepass>k__BackingField; // 0x17
	[CompilerGenerated]
	private bool <HasRenderingLayerPrepass>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsOverlay>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <AccurateGbufferNormals>k__BackingField; // 0x1A
	[CompilerGenerated]
	private MixedLightingSetup <MixedLightingSetup>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <UseJobSystem>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RenderWidth>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <RenderHeight>k__BackingField; // 0x28
	[CompilerGenerated]
	private RTHandle[] <GbufferAttachments>k__BackingField; // 0x30
	private RTHandle[] GbufferRTHandles; // 0x38
	[CompilerGenerated]
	private TextureHandle[] <GbufferTextureHandles>k__BackingField; // 0x40
	[CompilerGenerated]
	private RTHandle[] <DeferredInputAttachments>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool[] <DeferredInputIsTransient>k__BackingField; // 0x50
	[CompilerGenerated]
	private RTHandle <DepthAttachment>k__BackingField; // 0x58
	[CompilerGenerated]
	private RTHandle <DepthCopyTexture>k__BackingField; // 0x60
	[CompilerGenerated]
	private GraphicsFormat[] <GbufferFormats>k__BackingField; // 0x68
	[CompilerGenerated]
	private RTHandle <DepthAttachmentHandle>k__BackingField; // 0x70
	private NativeArray<ushort> m_stencilVisLights; // 0x78
	private NativeArray<ushort> m_stencilVisLightOffsets; // 0x88
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; // 0x98
	private Mesh m_SphereMesh; // 0xA0
	private Mesh m_HemisphereMesh; // 0xA8
	private Mesh m_FullscreenMesh; // 0xB0
	private Material m_StencilDeferredMaterial; // 0xB8
	private int[] m_StencilDeferredPasses; // 0xC0
	private Matrix4x4[] m_ScreenToWorld; // 0xC8
	private ProfilingSampler m_ProfilingSamplerDeferredStencilPass; // 0xD0
	private ProfilingSampler m_ProfilingSamplerDeferredFogPass; // 0xD8
	private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass; // 0xE0
	private LightCookieManager m_LightCookieManager; // 0xE8

	// Properties
	internal int GBufferAlbedoIndex { get; }
	internal int GBufferSpecularMetallicIndex { get; }
	internal int GBufferNormalSmoothnessIndex { get; }
	internal int GBufferLightingIndex { get; }
	internal int GbufferDepthIndex { get; }
	internal int GBufferRenderingLayers { get; }
	internal int GBufferShadowMask { get; }
	internal int GBufferSliceCount { get; }
	internal bool UseShadowMask { get; }
	internal bool UseRenderingLayers { get; }
	internal RenderingLayerUtils.MaskSize RenderingLayerMaskSize { get; set; }
	internal bool UseDecalLayers { get; set; }
	internal bool UseLightLayers { get; }
	internal bool UseRenderPass { get; set; }
	internal bool HasDepthPrepass { get; set; }
	internal bool HasNormalPrepass { get; set; }
	internal bool HasRenderingLayerPrepass { get; set; }
	internal bool IsOverlay { get; set; }
	internal bool AccurateGbufferNormals { get; set; }
	internal MixedLightingSetup MixedLightingSetup { get; set; }
	internal bool UseJobSystem { get; set; }
	internal int RenderWidth { get; set; }
	internal int RenderHeight { get; set; }
	internal RTHandle[] GbufferAttachments { get; set; }
	internal TextureHandle[] GbufferTextureHandles { get; set; }
	internal RTHandle[] DeferredInputAttachments { get; set; }
	internal bool[] DeferredInputIsTransient { get; set; }
	internal RTHandle DepthAttachment { get; set; }
	internal RTHandle DepthCopyTexture { get; set; }
	internal GraphicsFormat[] GbufferFormats { get; set; }
	internal RTHandle DepthAttachmentHandle { get; set; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal int get_GBufferAlbedoIndex() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	internal int get_GBufferSpecularMetallicIndex() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0
	internal int get_GBufferNormalSmoothnessIndex() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670
	internal int get_GBufferLightingIndex() { }

	// RVA: 0x2B67AF0 Offset: 0x2B664F0 VA: 0x182B67AF0
	internal int get_GbufferDepthIndex() { }

	// RVA: 0x2B67930 Offset: 0x2B66330 VA: 0x182B67930
	internal int get_GBufferRenderingLayers() { }

	// RVA: 0x2B679B0 Offset: 0x2B663B0 VA: 0x182B679B0
	internal int get_GBufferShadowMask() { }

	// RVA: 0x2B67A50 Offset: 0x2B66450 VA: 0x182B67A50
	internal int get_GBufferSliceCount() { }

	// RVA: 0x2B628D0 Offset: 0x2B612D0 VA: 0x182B628D0
	internal GraphicsFormat GetGBufferFormat(int index) { }

	// RVA: 0x2B67BE0 Offset: 0x2B665E0 VA: 0x182B67BE0
	internal bool get_UseShadowMask() { }

	// RVA: 0x2B67B70 Offset: 0x2B66570 VA: 0x182B67B70
	internal bool get_UseRenderingLayers() { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal RenderingLayerUtils.MaskSize get_RenderingLayerMaskSize() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	internal void set_RenderingLayerMaskSize(RenderingLayerUtils.MaskSize value) { }

	[CompilerGenerated]
	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	internal bool get_UseDecalLayers() { }

	[CompilerGenerated]
	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	internal void set_UseDecalLayers(bool value) { }

	// RVA: 0x2B67B10 Offset: 0x2B66510 VA: 0x182B67B10
	internal bool get_UseLightLayers() { }

	[CompilerGenerated]
	// RVA: 0x1BBB9B0 Offset: 0x1BBA3B0 VA: 0x181BBB9B0
	internal bool get_UseRenderPass() { }

	[CompilerGenerated]
	// RVA: 0x1BBB9C0 Offset: 0x1BBA3C0 VA: 0x181BBB9C0
	internal void set_UseRenderPass(bool value) { }

	[CompilerGenerated]
	// RVA: 0x26D9060 Offset: 0x26D7A60 VA: 0x1826D9060
	internal bool get_HasDepthPrepass() { }

	[CompilerGenerated]
	// RVA: 0x2B67BF0 Offset: 0x2B665F0 VA: 0x182B67BF0
	internal void set_HasDepthPrepass(bool value) { }

	[CompilerGenerated]
	// RVA: 0xB17560 Offset: 0xB15F60 VA: 0x180B17560
	internal bool get_HasNormalPrepass() { }

	[CompilerGenerated]
	// RVA: 0x2B67C00 Offset: 0x2B66600 VA: 0x182B67C00
	internal void set_HasNormalPrepass(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	internal bool get_HasRenderingLayerPrepass() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	internal void set_HasRenderingLayerPrepass(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	internal bool get_IsOverlay() { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	internal void set_IsOverlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1DFCED0 Offset: 0x1DFB8D0 VA: 0x181DFCED0
	internal bool get_AccurateGbufferNormals() { }

	[CompilerGenerated]
	// RVA: 0x1DFCEE0 Offset: 0x1DFB8E0 VA: 0x181DFCEE0
	internal void set_AccurateGbufferNormals(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal MixedLightingSetup get_MixedLightingSetup() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	internal void set_MixedLightingSetup(MixedLightingSetup value) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	internal bool get_UseJobSystem() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	internal void set_UseJobSystem(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	internal int get_RenderWidth() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	internal void set_RenderWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal int get_RenderHeight() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void set_RenderHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal RTHandle[] get_GbufferAttachments() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_GbufferAttachments(RTHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal TextureHandle[] get_GbufferTextureHandles() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_GbufferTextureHandles(TextureHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal RTHandle[] get_DeferredInputAttachments() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	internal void set_DeferredInputAttachments(RTHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal bool[] get_DeferredInputIsTransient() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void set_DeferredInputIsTransient(bool[] value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal RTHandle get_DepthAttachment() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void set_DepthAttachment(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal RTHandle get_DepthCopyTexture() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_DepthCopyTexture(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal GraphicsFormat[] get_GbufferFormats() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void set_GbufferFormats(GraphicsFormat[] value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal RTHandle get_DepthAttachmentHandle() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void set_DepthAttachmentHandle(RTHandle value) { }

	// RVA: 0x2B67650 Offset: 0x2B66050 VA: 0x182B67650
	internal void .ctor(DeferredLights.InitParams initParams, bool useNativeRenderPass = False) { }

	// RVA: 0x2B65D10 Offset: 0x2B64710 VA: 0x182B65D10
	internal void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B65AD0 Offset: 0x2B644D0 VA: 0x182B65AD0
	internal void ResolveMixedLightingMode(ref RenderingData renderingData) { }

	// RVA: 0x2B62470 Offset: 0x2B60E70 VA: 0x182B62470
	internal void DisableFramebufferFetchInput() { }

	// RVA: 0x2B63B70 Offset: 0x2B62570 VA: 0x182B63B70
	internal void ReleaseGbufferResources() { }

	// RVA: 0x2B63960 Offset: 0x2B62360 VA: 0x182B63960
	internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex) { }

	// RVA: 0x2B61170 Offset: 0x2B5FB70 VA: 0x182B61170
	internal void CreateGbufferResources() { }

	// RVA: 0x2B66D50 Offset: 0x2B65750 VA: 0x182B66D50
	internal void UpdateDeferredInputAttachments() { }

	// RVA: 0x2B62FB0 Offset: 0x2B619B0 VA: 0x182B62FB0
	internal bool IsRuntimeSupportedThisFrame() { }

	// RVA: 0x2B66AA0 Offset: 0x2B654A0 VA: 0x182B66AA0
	public void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment) { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass) { }

	// RVA: 0x2B63040 Offset: 0x2B61A40 VA: 0x182B63040
	public void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2B633F0 Offset: 0x2B61DF0 VA: 0x182B633F0
	internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask) { }

	// RVA: 0x2B63100 Offset: 0x2B61B00 VA: 0x182B63100
	internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef) { }

	// RVA: 0x2B60E20 Offset: 0x2B5F820 VA: 0x182B60E20
	internal void ClearStencilPartial(CommandBuffer cmd) { }

	// RVA: 0x2B62480 Offset: 0x2B60E80 VA: 0x182B62480
	internal void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B66A90 Offset: 0x2B65490 VA: 0x182B66A90
	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B66280 Offset: 0x2B64C80 VA: 0x182B66280
	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x2B664C0 Offset: 0x2B64EC0 VA: 0x182B664C0
	private void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B635F0 Offset: 0x2B61FF0 VA: 0x182B635F0
	private void PrecomputeLights(out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear) { }

	// RVA: 0x2B62A60 Offset: 0x2B61460 VA: 0x182B62A60
	private bool HasStencilLightsOfType(LightType type) { }

	// RVA: 0x2B64640 Offset: 0x2B63040 VA: 0x182B64640
	private void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B65C60 Offset: 0x2B64660 VA: 0x182B65C60
	private void SetAdditionalLightsShadowsKeyword(ref CommandBuffer cmd, ref RenderingData renderingData, bool hasDeferredShadows) { }

	// RVA: 0x2B63FA0 Offset: 0x2B629A0 VA: 0x182B63FA0
	private void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex) { }

	// RVA: 0x2B64920 Offset: 0x2B63320 VA: 0x182B64920
	private void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2B65160 Offset: 0x2B63B60 VA: 0x182B65160
	private void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2B63E40 Offset: 0x2B62840 VA: 0x182B63E40
	private void RenderSSAOBeforeShading(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B63C30 Offset: 0x2B62630 VA: 0x182B63C30
	private void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B62AD0 Offset: 0x2B614D0 VA: 0x182B62AD0
	private void InitStencilDeferredMaterial() { }

	// RVA: 0x2B61C90 Offset: 0x2B60690 VA: 0x182B61C90
	private static Mesh CreateSphereMesh() { }

	// RVA: 0x2B61590 Offset: 0x2B5FF90 VA: 0x182B61590
	private static Mesh CreateHemisphereMesh() { }

	// RVA: 0x2B61000 Offset: 0x2B5FA00 VA: 0x182B61000
	private static Mesh CreateFullscreenMesh() { }

	// RVA: 0x2B67020 Offset: 0x2B65A20 VA: 0x182B67020
	private static void .cctor() { }
}
