public sealed class GraphicsSettings : Object // TypeDefIndex: 12208
{
	// Properties
	public static bool lightsUseLinearIntensity { get; set; }
	public static bool lightsUseColorTemperature { set; }
	public static uint defaultRenderingLayerMask { set; }
	public static bool useScriptableRenderPipelineBatching { set; }
	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline { get; }
	public static RenderPipelineAsset currentRenderPipeline { get; }
	public static RenderPipelineAsset renderPipelineAsset { get; set; }
	[NativeName("DefaultRenderPipeline")]
	private static ScriptableObject INTERNAL_defaultRenderPipeline { get; set; }
	public static RenderPipelineAsset defaultRenderPipeline { get; set; }
	public static RenderPipelineAsset[] allConfiguredRenderPipelines { get; }

	// Methods

	// RVA: 0x2CE05A0 Offset: 0x2CDEFA0 VA: 0x182CE05A0
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x2CE0690 Offset: 0x2CDF090 VA: 0x182CE0690
	public static void set_lightsUseLinearIntensity(bool value) { }

	// RVA: 0x2CE0650 Offset: 0x2CDF050 VA: 0x182CE0650
	public static void set_lightsUseColorTemperature(bool value) { }

	// RVA: 0x2CE0610 Offset: 0x2CDF010 VA: 0x182CE0610
	public static void set_defaultRenderingLayerMask(uint value) { }

	// RVA: 0x2CE06D0 Offset: 0x2CDF0D0 VA: 0x182CE06D0
	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	// RVA: 0x2CE0260 Offset: 0x2CDEC60 VA: 0x182CE0260
	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	// RVA: 0x2CE02A0 Offset: 0x2CDECA0 VA: 0x182CE02A0
	public static bool HasShaderDefine(BuiltinShaderDefine defineHash) { }

	// RVA: 0x2CE03B0 Offset: 0x2CDEDB0 VA: 0x182CE03B0
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x2CE0480 Offset: 0x2CDEE80 VA: 0x182CE0480
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x2CE0510 Offset: 0x2CDEF10 VA: 0x182CE0510
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x2CE05D0 Offset: 0x2CDEFD0 VA: 0x182CE05D0
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x2CE03E0 Offset: 0x2CDEDE0 VA: 0x182CE03E0
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x2CE05D0 Offset: 0x2CDEFD0 VA: 0x182CE05D0
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x2CE0510 Offset: 0x2CDEF10 VA: 0x182CE0510
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x2CE05D0 Offset: 0x2CDEFD0 VA: 0x182CE05D0
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

	[NativeName("GetAllConfiguredRenderPipelinesForScript")]
	// RVA: 0x2CE01B0 Offset: 0x2CDEBB0 VA: 0x182CE01B0
	private static ScriptableObject[] GetAllConfiguredRenderPipelines() { }

	// RVA: 0x2CE0410 Offset: 0x2CDEE10 VA: 0x182CE0410
	public static RenderPipelineAsset[] get_allConfiguredRenderPipelines() { }

	[NativeName("GetShaderModeScript")]
	// RVA: 0x2CE0220 Offset: 0x2CDEC20 VA: 0x182CE0220
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type) { }

	// RVA: -1 Offset: -1
	public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBDFC0 Offset: 0xEBC9C0 VA: 0x180EBDFC0
	|-GraphicsSettings.RegisterRenderPipelineSettings<object>
	*/

	[NativeName("RegisterRenderPipelineSettings")]
	// RVA: 0x2CE0320 Offset: 0x2CDED20 VA: 0x182CE0320
	private static void RegisterRenderPipeline(string renderpipelineName, Object settings) { }

	// RVA: -1 Offset: -1
	public static void UnregisterRenderPipelineSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBE060 Offset: 0xEBCA60 VA: 0x180EBE060
	|-GraphicsSettings.UnregisterRenderPipelineSettings<object>
	*/

	[NativeName("UnregisterRenderPipelineSettings")]
	// RVA: 0x2CE0370 Offset: 0x2CDED70 VA: 0x182CE0370
	private static void UnregisterRenderPipeline(string renderpipelineName) { }

	// RVA: -1 Offset: -1
	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBDEE0 Offset: 0xEBC8E0 VA: 0x180EBDEE0
	|-GraphicsSettings.GetSettingsForRenderPipeline<object>
	*/

	[NativeName("GetSettingsForRenderPipeline")]
	// RVA: 0x2CE01E0 Offset: 0x2CDEBE0 VA: 0x182CE01E0
	private static Object GetSettingsForRenderPipeline(string renderpipelineName) { }
}
