internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, ISerializationCallbackReceiver, IShaderVariantSettings // TypeDefIndex: 9084
{
	// Fields
	[SerializeField]
	private int k_AssetVersion; // 0x18
	private static UniversalRenderPipelineGlobalSettings cachedInstance; // 0x0
	public static readonly string defaultAssetName; // 0x8
	[SerializeField]
	private string[] m_RenderingLayerNames; // 0x20
	private string[] m_PrefixedRenderingLayerNames; // 0x28
	[SerializeField]
	private uint m_ValidRenderingLayers; // 0x30
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName0; // 0x38
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName1; // 0x40
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName2; // 0x48
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName3; // 0x50
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName4; // 0x58
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName5; // 0x60
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string lightLayerName6; // 0x68
	[Obsolete("This is obsolete, please use renderingLayerNames instead.", False)]
	public string lightLayerName7; // 0x70
	[SerializeField]
	private bool m_StripDebugVariants; // 0x78
	[SerializeField]
	private bool m_StripUnusedPostProcessingVariants; // 0x79
	[SerializeField]
	private bool m_StripUnusedVariants; // 0x7A
	[SerializeField]
	private bool m_StripUnusedLODCrossFadeVariants; // 0x7B
	[SerializeField]
	private bool m_StripScreenCoordOverrideVariants; // 0x7C
	[Obsolete("Please use stripRuntimeDebugShaders instead.", False)]
	public bool supportRuntimeDebugDisplay; // 0x7D
	[SerializeField]
	internal ShaderVariantLogLevel m_ShaderVariantLogLevel; // 0x80
	[SerializeField]
	internal bool m_ExportShaderVariants; // 0x84

	// Properties
	public static UniversalRenderPipelineGlobalSettings instance { get; }
	private string[] renderingLayerNames { get; }
	private string[] prefixedRenderingLayerNames { get; }
	public string[] renderingLayerMaskNames { get; }
	public string[] prefixedRenderingLayerMaskNames { get; }
	public uint validRenderingLayers { get; }
	[Obsolete("This is obsolete, please use prefixedRenderingLayerMaskNames instead.", False)]
	public string[] prefixedLightLayerNames { get; }
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", False)]
	public string[] lightLayerNames { get; }
	public bool stripDebugVariants { get; set; }
	public bool stripUnusedPostProcessingVariants { get; set; }
	public bool stripUnusedVariants { get; set; }
	[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used.", False)]
	public bool stripUnusedLODCrossFadeVariants { get; set; }
	public bool stripScreenCoordOverrideVariants { get; set; }
	public ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
	public bool exportShaderVariants { get; set; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2B4D810 Offset: 0x2B4C210 VA: 0x182B4D810
	public static UniversalRenderPipelineGlobalSettings get_instance() { }

	// RVA: 0x2B4D410 Offset: 0x2B4BE10 VA: 0x182B4D410
	internal static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings) { }

	// RVA: 0x2B4D400 Offset: 0x2B4BE00 VA: 0x182B4D400
	private void Reset() { }

	// RVA: 0x2B4DA50 Offset: 0x2B4C450 VA: 0x182B4DA50
	private string[] get_renderingLayerNames() { }

	// RVA: 0x2B4DA20 Offset: 0x2B4C420 VA: 0x182B4DA20
	private string[] get_prefixedRenderingLayerNames() { }

	// RVA: 0x2B4DA50 Offset: 0x2B4C450 VA: 0x182B4DA50
	public string[] get_renderingLayerMaskNames() { }

	// RVA: 0x2B4DA20 Offset: 0x2B4C420 VA: 0x182B4DA20
	public string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x2B4DA80 Offset: 0x2B4C480 VA: 0x182B4DA80
	public uint get_validRenderingLayers() { }

	// RVA: 0x2B4D540 Offset: 0x2B4BF40 VA: 0x182B4D540
	internal void UpdateRenderingLayerNames() { }

	// RVA: 0x2B4D9E0 Offset: 0x2B4C3E0 VA: 0x182B4D9E0
	public string[] get_prefixedLightLayerNames() { }

	// RVA: 0x2B4D9A0 Offset: 0x2B4C3A0 VA: 0x182B4D9A0
	public string[] get_lightLayerNames() { }

	// RVA: 0x2B4D370 Offset: 0x2B4BD70 VA: 0x182B4D370
	internal void ResetRenderingLayerNames() { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_stripDebugVariants() { }

	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	public void set_stripDebugVariants(bool value) { }

	// RVA: 0x1E01A60 Offset: 0x1E00460 VA: 0x181E01A60
	public bool get_stripUnusedPostProcessingVariants() { }

	// RVA: 0x1E01DB0 Offset: 0x1E007B0 VA: 0x181E01DB0
	public void set_stripUnusedPostProcessingVariants(bool value) { }

	// RVA: 0x1E019E0 Offset: 0x1E003E0 VA: 0x181E019E0
	public bool get_stripUnusedVariants() { }

	// RVA: 0x1E01CF0 Offset: 0x1E006F0 VA: 0x181E01CF0
	public void set_stripUnusedVariants(bool value) { }

	// RVA: 0x244A810 Offset: 0x2449210 VA: 0x18244A810
	public bool get_stripUnusedLODCrossFadeVariants() { }

	// RVA: 0x244DBE0 Offset: 0x244C5E0 VA: 0x18244DBE0
	public void set_stripUnusedLODCrossFadeVariants(bool value) { }

	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	public bool get_stripScreenCoordOverrideVariants() { }

	// RVA: 0x83DBD0 Offset: 0x83C5D0 VA: 0x18083DBD0
	public void set_stripScreenCoordOverrideVariants(bool value) { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280 Slot: 6
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540 Slot: 7
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060 Slot: 8
	public bool get_exportShaderVariants() { }

	// RVA: 0x2B4DAB0 Offset: 0x2B4C4B0 VA: 0x182B4DAB0 Slot: 9
	public void set_exportShaderVariants(bool value) { }

	// RVA: 0x2B4D750 Offset: 0x2B4C150 VA: 0x182B4D750
	public void .ctor() { }

	// RVA: 0x2B4D6B0 Offset: 0x2B4C0B0 VA: 0x182B4D6B0
	private static void .cctor() { }
}
