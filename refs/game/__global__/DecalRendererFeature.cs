internal class DecalRendererFeature : ScriptableRendererFeature // TypeDefIndex: 8985
{
	// Fields
	[CompilerGenerated]
	private static readonly SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField; // 0x0
	[SerializeField]
	private DecalSettings m_Settings; // 0x20
	[HideInInspector]
	[Reload("Shaders/Utils/CopyDepth.shader", 1)]
	[SerializeField]
	private Shader m_CopyDepthPS; // 0x28
	[SerializeField]
	[HideInInspector]
	[Reload("Runtime/Decal/DBuffer/DBufferClear.shader", 1)]
	private Shader m_DBufferClear; // 0x30
	private DecalTechnique m_Technique; // 0x38
	private DBufferSettings m_DBufferSettings; // 0x40
	private DecalScreenSpaceSettings m_ScreenSpaceSettings; // 0x48
	private bool m_RecreateSystems; // 0x50
	private CopyDepthPass m_CopyDepthPass; // 0x58
	private DecalPreviewPass m_DecalPreviewPass; // 0x60
	private Material m_CopyDepthMaterial; // 0x68
	private DecalEntityManager m_DecalEntityManager; // 0x70
	private DecalUpdateCachedSystem m_DecalUpdateCachedSystem; // 0x78
	private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem; // 0x80
	private DecalUpdateCulledSystem m_DecalUpdateCulledSystem; // 0x88
	private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem; // 0x90
	private DecalDrawErrorSystem m_DrawErrorSystem; // 0x98
	private DBufferRenderPass m_DBufferRenderPass; // 0xA0
	private DecalForwardEmissivePass m_ForwardEmissivePass; // 0xA8
	private DecalDrawDBufferSystem m_DecalDrawDBufferSystem; // 0xB0
	private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem; // 0xB8
	private Material m_DBufferClearMaterial; // 0xC0
	private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass; // 0xC8
	private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem; // 0xD0
	private DecalSkipCulledSystem m_DecalSkipCulledSystem; // 0xD8
	private DecalGBufferRenderPass m_GBufferRenderPass; // 0xE0
	private DecalDrawGBufferSystem m_DrawGBufferSystem; // 0xE8
	private DeferredLights m_DeferredLights; // 0xF0

	// Properties
	private static SharedDecalEntityManager sharedDecalEntityManager { get; }
	internal DecalSettings settings { get; }
	internal bool intermediateRendering { get; }
	internal bool requiresDecalLayers { get; }
	internal static bool isGLDevice { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B165B0 Offset: 0x2B14FB0 VA: 0x182B165B0
	private static SharedDecalEntityManager get_sharedDecalEntityManager() { }

	// RVA: 0x2B165A0 Offset: 0x2B14FA0 VA: 0x182B165A0
	internal ref DecalSettings get_settings() { }

	// RVA: 0xAEE2C0 Offset: 0xAECCC0 VA: 0x180AEE2C0
	internal bool get_intermediateRendering() { }

	// RVA: 0x29AEAF0 Offset: 0x29AD4F0 VA: 0x1829AEAF0
	internal bool get_requiresDecalLayers() { }

	// RVA: 0x2B16560 Offset: 0x2B14F60 VA: 0x182B16560
	internal static bool get_isGLDevice() { }

	// RVA: 0x2B14FA0 Offset: 0x2B139A0 VA: 0x182B14FA0 Slot: 5
	public override void Create() { }

	// RVA: 0x2B16160 Offset: 0x2B14B60 VA: 0x182B16160 Slot: 10
	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x2B152B0 Offset: 0x2B13CB0 VA: 0x182B152B0
	internal DBufferSettings GetDBufferSettings() { }

	// RVA: 0x2B15330 Offset: 0x2B13D30 VA: 0x182B15330
	internal DecalScreenSpaceSettings GetScreenSpaceSettings() { }

	// RVA: 0x2B156C0 Offset: 0x2B140C0 VA: 0x182B156C0
	internal DecalTechnique GetTechnique(ScriptableRendererData renderer) { }

	// RVA: 0x2B155E0 Offset: 0x2B13FE0 VA: 0x182B155E0
	internal DecalTechnique GetTechnique(ScriptableRenderer renderer) { }

	// RVA: 0x2B153B0 Offset: 0x2B13DB0 VA: 0x182B153B0
	internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = True) { }

	// RVA: 0x2B15800 Offset: 0x2B14200 VA: 0x182B15800
	private bool IsAutomaticDBuffer() { }

	// RVA: 0x2B15980 Offset: 0x2B14380 VA: 0x182B15980
	private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData) { }

	// RVA: 0x2B15860 Offset: 0x2B14260 VA: 0x182B15860 Slot: 6
	public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	// RVA: 0x2B14E20 Offset: 0x2B13820 VA: 0x182B14E20 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2B16440 Offset: 0x2B14E40 VA: 0x182B16440 Slot: 9
	internal override bool SupportsNativeRenderPass() { }

	// RVA: 0x2B16220 Offset: 0x2B14C20 VA: 0x182B16220 Slot: 8
	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

	// RVA: 0x2B15010 Offset: 0x2B13A10 VA: 0x182B15010 Slot: 11
	protected override void Dispose(bool disposing) { }

	[Conditional("ADAPTIVE_PERFORMANCE_4_0_0_OR_NEWER")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ChangeAdaptivePerformanceDrawDistances() { }

	// RVA: 0x2B164E0 Offset: 0x2B14EE0 VA: 0x182B164E0
	public void .ctor() { }

	// RVA: 0x2B16460 Offset: 0x2B14E60 VA: 0x182B16460
	private static void .cctor() { }
}
