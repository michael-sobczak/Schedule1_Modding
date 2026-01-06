public sealed class PostProcessLayer : MonoBehaviour // TypeDefIndex: 17047
{
	// Fields
	public Transform volumeTrigger; // 0x20
	public LayerMask volumeLayer; // 0x28
	public bool stopNaNPropagation; // 0x2C
	public bool finalBlitToCameraTarget; // 0x2D
	public PostProcessLayer.Antialiasing antialiasingMode; // 0x30
	public TemporalAntialiasing temporalAntialiasing; // 0x38
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0x40
	public FastApproximateAntialiasing fastApproximateAntialiasing; // 0x48
	public Fog fog; // 0x50
	private Dithering dithering; // 0x58
	public PostProcessDebugLayer debugLayer; // 0x60
	[SerializeField]
	private PostProcessResources m_Resources; // 0x68
	private PostProcessResources m_OldResources; // 0x70
	[SerializeField]
	[Preserve]
	private bool m_ShowToolkit; // 0x78
	[SerializeField]
	[Preserve]
	private bool m_ShowCustomSorter; // 0x79
	public bool breakBeforeColorGrading; // 0x7A
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles; // 0x80
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles; // 0x88
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles; // 0x90
	[CompilerGenerated]
	private Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField; // 0x98
	[CompilerGenerated]
	private DepthTextureMode <cameraDepthFlags>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <haveBundlesBeenInited>k__BackingField; // 0xA4
	private Dictionary<Type, PostProcessBundle> m_Bundles; // 0xA8
	private PropertySheetFactory m_PropertySheetFactory; // 0xB0
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; // 0xB8
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; // 0xC0
	private CommandBuffer m_LegacyCmdBufferOpaque; // 0xC8
	private CommandBuffer m_LegacyCmdBuffer; // 0xD0
	private Camera m_Camera; // 0xD8
	private PostProcessRenderContext m_CurrentContext; // 0xE0
	private LogHistogram m_LogHistogram; // 0xE8
	private bool m_SettingsUpdateNeeded; // 0xF0
	private bool m_IsRenderingInSceneView; // 0xF1
	private TargetPool m_TargetPool; // 0xF8
	private bool m_NaNKilled; // 0x100
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; // 0x108
	private readonly List<RenderTargetIdentifier> m_Targets; // 0x110

	// Properties
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles { get; set; }
	public DepthTextureMode cameraDepthFlags { get; set; }
	public bool haveBundlesBeenInited { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGenerated]
	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGenerated]
	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public DepthTextureMode get_cameraDepthFlags() { }

	[CompilerGenerated]
	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	private void set_cameraDepthFlags(DepthTextureMode value) { }

	[CompilerGenerated]
	// RVA: 0x8B3440 Offset: 0x8B1E40 VA: 0x1808B3440
	public bool get_haveBundlesBeenInited() { }

	[CompilerGenerated]
	// RVA: 0x8B3530 Offset: 0x8B1F30 VA: 0x1808B3530
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x29B1640 Offset: 0x29B0040 VA: 0x1829B1640
	private void OnEnable() { }

	// RVA: 0x29B0F30 Offset: 0x29AF930 VA: 0x1829B0F30
	private void InitLegacy() { }

	// RVA: 0x29B07A0 Offset: 0x29AF1A0 VA: 0x1829B07A0
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget() { }

	[ImageEffectUsesCommandBuffer]
	// RVA: 0x29B2290 Offset: 0x29B0C90 VA: 0x1829B2290
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x29B11B0 Offset: 0x29AFBB0 VA: 0x1829B11B0
	public void Init(PostProcessResources resources) { }

	// RVA: 0x29B0AA0 Offset: 0x29AF4A0 VA: 0x1829B0AA0
	public void InitBundles() { }

	// RVA: 0x29B5C50 Offset: 0x29B4650 VA: 0x1829B5C50
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x29B12F0 Offset: 0x29AFCF0 VA: 0x1829B12F0
	private void OnDisable() { }

	// RVA: 0x29B5490 Offset: 0x29B3E90 VA: 0x1829B5490
	private void Reset() { }

	// RVA: 0x29B1B80 Offset: 0x29B0580 VA: 0x1829B1B80
	private void OnPreCull() { }

	// RVA: 0x29B21D0 Offset: 0x29B0BD0 VA: 0x1829B21D0
	private void OnPreRender() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x29B6290 Offset: 0x29B4C90 VA: 0x1829B6290
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x29AF7B0 Offset: 0x29AE1B0 VA: 0x1829AF7B0
	private void BuildCommandBuffers() { }

	// RVA: 0x29B1940 Offset: 0x29B0340 VA: 0x1829B1940
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25C90 Offset: 0xF24690 VA: 0x180F25C90
	|-PostProcessLayer.GetBundle<object>
	*/

	// RVA: 0x29B0830 Offset: 0x29AF230 VA: 0x1829B0830
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25D00 Offset: 0xF24700 VA: 0x180F25D00
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x29AF650 Offset: 0x29AE050 VA: 0x1829AF650
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x29B2340 Offset: 0x29B0D40 VA: 0x1829B2340
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x29B54C0 Offset: 0x29B3EC0 VA: 0x1829B54C0
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x29B5320 Offset: 0x29B3D20 VA: 0x1829B5320
	public void ResetHistory() { }

	// RVA: 0x29B0A90 Offset: 0x29AF490 VA: 0x1829B0A90
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x29B0890 Offset: 0x29AF290 VA: 0x1829B0890
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x29B57A0 Offset: 0x29B41A0 VA: 0x1829B57A0
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x29B6420 Offset: 0x29B4E20 VA: 0x1829B6420
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x29B45A0 Offset: 0x29B2FA0 VA: 0x1829B45A0
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x29B46E0 Offset: 0x29B30E0 VA: 0x1829B46E0
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x29B3D60 Offset: 0x29B2760 VA: 0x1829B3D60
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x29B3F80 Offset: 0x29B2980 VA: 0x1829B3F80
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x29AF510 Offset: 0x29ADF10 VA: 0x1829AF510
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x29AF470 Offset: 0x29ADE70 VA: 0x1829AF470
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x29B2590 Offset: 0x29B0F90 VA: 0x1829B2590
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x29B31C0 Offset: 0x29B1BC0 VA: 0x1829B31C0
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25DB0 Offset: 0xF247B0 VA: 0x180F25DB0
	|-PostProcessLayer.RenderEffect<object>
	*/

	// RVA: 0x29B5BB0 Offset: 0x29B45B0 VA: 0x1829B5BB0
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x29B65A0 Offset: 0x29B4FA0 VA: 0x1829B65A0
	public void .ctor() { }
}
