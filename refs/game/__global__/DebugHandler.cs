internal class DebugHandler : IDebugDisplaySettingsQuery // TypeDefIndex: 8823
{
	// Fields
	private static readonly int k_DebugColorInvalidModePropertyId; // 0x0
	private static readonly int k_DebugColorPropertyId; // 0x4
	private static readonly int k_DebugTexturePropertyId; // 0x8
	private static readonly int k_DebugTextureNoStereoPropertyId; // 0xC
	private static readonly int k_DebugTextureDisplayRect; // 0x10
	private static readonly int k_DebugRenderTargetSupportsStereo; // 0x14
	private static readonly int k_DebugMaterialModeId; // 0x18
	private static readonly int k_DebugVertexAttributeModeId; // 0x1C
	private static readonly int k_DebugMaterialValidationModeId; // 0x20
	private static readonly int k_DebugMipInfoModeId; // 0x24
	private static readonly int k_DebugSceneOverrideModeId; // 0x28
	private static readonly int k_DebugFullScreenModeId; // 0x2C
	private static readonly int k_DebugValidationModeId; // 0x30
	private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId; // 0x34
	private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId; // 0x38
	private static readonly int k_DebugMaxPixelCost; // 0x3C
	private static readonly int k_DebugLightingModeId; // 0x40
	private static readonly int k_DebugLightingFeatureFlagsId; // 0x44
	private static readonly int k_DebugValidateAlbedoMinLuminanceId; // 0x48
	private static readonly int k_DebugValidateAlbedoMaxLuminanceId; // 0x4C
	private static readonly int k_DebugValidateAlbedoSaturationToleranceId; // 0x50
	private static readonly int k_DebugValidateAlbedoHueToleranceId; // 0x54
	private static readonly int k_DebugValidateAlbedoCompareColorId; // 0x58
	private static readonly int k_DebugValidateMetallicMinValueId; // 0x5C
	private static readonly int k_DebugValidateMetallicMaxValueId; // 0x60
	private static readonly int k_ValidationChannelsId; // 0x64
	private static readonly int k_RangeMinimumId; // 0x68
	private static readonly int k_RangeMaximumId; // 0x6C
	private readonly Material m_ReplacementMaterial; // 0x10
	private readonly Material m_HDRDebugViewMaterial; // 0x18
	private HDRDebugViewPass m_HDRDebugViewPass; // 0x20
	private RTHandle m_DebugScreenColorHandle; // 0x28
	private RTHandle m_DebugScreenDepthHandle; // 0x30
	private bool m_HasDebugRenderTarget; // 0x38
	private bool m_DebugRenderTargetSupportsStereo; // 0x39
	private Vector4 m_DebugRenderTargetPixelRect; // 0x3C
	private RenderTargetIdentifier m_DebugRenderTargetIdentifier; // 0x50
	private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings; // 0x78

	// Properties
	private DebugDisplaySettingsLighting LightingSettings { get; }
	private DebugDisplaySettingsMaterial MaterialSettings { get; }
	private DebugDisplaySettingsRendering RenderingSettings { get; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }
	internal bool IsActiveModeUnsupportedForDeferred { get; }
	internal Material ReplacementMaterial { get; }
	internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings { get; }
	internal RTHandle DebugScreenColorHandle { get; }
	internal RTHandle DebugScreenDepthHandle { get; }
	internal HDRDebugViewPass hdrDebugViewPass { get; }
	internal bool IsScreenClearNeeded { get; }
	internal bool IsRenderPassSupported { get; }

	// Methods

	// RVA: 0x2AC9850 Offset: 0x2AC8250 VA: 0x182AC9850
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	// RVA: 0x2AC9870 Offset: 0x2AC8270 VA: 0x182AC9870
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	// RVA: 0x2AC9890 Offset: 0x2AC8290 VA: 0x182AC9890
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	// RVA: 0x2AC96B0 Offset: 0x2AC80B0 VA: 0x182AC96B0 Slot: 4
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x2AC97A0 Offset: 0x2AC81A0 VA: 0x182AC97A0 Slot: 5
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x2AC9770 Offset: 0x2AC8170 VA: 0x182AC9770 Slot: 6
	public bool get_IsLightingActive() { }

	// RVA: 0x2AC9700 Offset: 0x2AC8100 VA: 0x182AC9700
	internal bool get_IsActiveModeUnsupportedForDeferred() { }

	// RVA: 0x2AC8D50 Offset: 0x2AC7750 VA: 0x182AC8D50 Slot: 7
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Material get_ReplacementMaterial() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings() { }

	// RVA: 0x2AC96E0 Offset: 0x2AC80E0 VA: 0x182AC96E0
	internal ref RTHandle get_DebugScreenColorHandle() { }

	// RVA: 0x2AC96F0 Offset: 0x2AC80F0 VA: 0x182AC96F0
	internal ref RTHandle get_DebugScreenDepthHandle() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal HDRDebugViewPass get_hdrDebugViewPass() { }

	// RVA: 0x2AC8280 Offset: 0x2AC6C80 VA: 0x182AC8280
	internal bool HDRDebugViewIsActive(ref CameraData cameraData) { }

	// RVA: 0x2AC8280 Offset: 0x2AC6C80 VA: 0x182AC8280
	internal bool WriteToDebugScreenTexture(ref CameraData cameraData) { }

	// RVA: 0x2AC9810 Offset: 0x2AC8210 VA: 0x182AC9810
	internal bool get_IsScreenClearNeeded() { }

	// RVA: 0x2AC97D0 Offset: 0x2AC81D0 VA: 0x182AC97D0
	internal bool get_IsRenderPassSupported() { }

	// RVA: 0x2AC94F0 Offset: 0x2AC7EF0 VA: 0x182AC94F0
	internal void .ctor(ScriptableRendererData scriptableRendererData) { }

	// RVA: 0x2AC7AD0 Offset: 0x2AC64D0 VA: 0x182AC7AD0
	public void Dispose() { }

	// RVA: 0x2AC82C0 Offset: 0x2AC6CC0 VA: 0x182AC82C0
	internal bool IsActiveForCamera(ref CameraData cameraData) { }

	// RVA: 0x2AC8CC0 Offset: 0x2AC76C0 VA: 0x182AC8CC0
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode) { }

	// RVA: 0x2AC8D00 Offset: 0x2AC7700 VA: 0x182AC8D00
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent) { }

	// RVA: 0x2AC7970 Offset: 0x2AC6370 VA: 0x182AC7970
	internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	// RVA: 0x2AC79C0 Offset: 0x2AC63C0 VA: 0x182AC79C0
	internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight) { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2AC8350 Offset: 0x2AC6D50 VA: 0x182AC8350
	internal void SetupShaderProperties(CommandBuffer cmd, int passIndex = 0) { }

	// RVA: 0x2AC8310 Offset: 0x2AC6D10 VA: 0x182AC8310
	internal void SetDebugRenderTarget(RenderTargetIdentifier renderTargetIdentifier, Rect displayRect, bool supportsStereo) { }

	// RVA: 0x99F8D0 Offset: 0x99E2D0 VA: 0x18099F8D0
	internal void ResetDebugRenderTarget() { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2AC8D80 Offset: 0x2AC7780 VA: 0x182AC8D80
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, ref CameraData cameraData, bool isFinalPass) { }

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2AC8850 Offset: 0x2AC7250 VA: 0x182AC8850
	internal void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AC7A20 Offset: 0x2AC6420 VA: 0x182AC7A20
	internal IEnumerable<DebugRenderSetup> CreateDebugRenderSetupEnumerable(ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings) { }

	// RVA: 0x2AC7B70 Offset: 0x2AC6570 VA: 0x182AC7B70
	internal void DrawWithDebugRenderState(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, DebugHandler.DrawFunction func) { }

	// RVA: 0x2AC9010 Offset: 0x2AC7A10 VA: 0x182AC9010
	private static void .cctor() { }
}
