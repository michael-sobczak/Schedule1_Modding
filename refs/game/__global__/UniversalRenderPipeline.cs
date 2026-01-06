public sealed class UniversalRenderPipeline : RenderPipeline // TypeDefIndex: 9067
{
	// Fields
	public const string k_ShaderTagName = "UniversalPipeline";
	internal const int k_DefaultRenderingLayerMask = 1;
	private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI; // 0x18
	private UniversalRenderPipelineGlobalSettings m_GlobalSettings; // 0x20
	internal static bool cameraStackRequiresDepthForPostprocessing; // 0x0
	internal static RenderGraph s_RenderGraph; // 0x8
	internal static RTHandleResourcePool s_RTHandlePool; // 0x10
	private static bool useRenderGraph; // 0x18
	private readonly UniversalRenderPipelineAsset pipelineAsset; // 0x28
	internal bool enableHDROnce; // 0x30
	private static Vector4 k_DefaultLightPosition; // 0x1C
	private static Vector4 k_DefaultLightColor; // 0x2C
	private static Vector4 k_DefaultLightAttenuation; // 0x3C
	private static Vector4 k_DefaultLightSpotDirection; // 0x4C
	private static Vector4 k_DefaultLightsProbeChannel; // 0x5C
	private static List<Vector4> m_ShadowBiasData; // 0x70
	private static List<int> m_ShadowResolutionData; // 0x78
	private Comparison<Camera> cameraComparison; // 0x38
	private static Lightmapping.RequestLightsDelegate lightsDelegate; // 0x80

	// Properties
	public static float maxShadowBias { get; }
	public static float minRenderScale { get; }
	public static float maxRenderScale { get; }
	public static int maxNumIterationsEnclosingSphere { get; }
	public static int maxPerObjectLights { get; }
	public static int maxVisibleAdditionalLights { get; }
	internal static int lightsPerTile { get; }
	internal static int maxZBinWords { get; }
	internal static int maxTileWords { get; }
	internal static int maxVisibleReflectionProbes { get; }
	public override RenderPipelineGlobalSettings defaultSettings { get; }
	public static UniversalRenderPipelineAsset asset { get; }

	// Methods

	// RVA: 0x72F520 Offset: 0x72DF20 VA: 0x18072F520
	public static float get_maxShadowBias() { }

	// RVA: 0x2A2C310 Offset: 0x2A2AD10 VA: 0x182A2C310
	public static float get_minRenderScale() { }

	// RVA: 0x2B57510 Offset: 0x2B55F10 VA: 0x182B57510
	public static float get_maxRenderScale() { }

	// RVA: 0x2B574D0 Offset: 0x2B55ED0 VA: 0x182B574D0
	public static int get_maxNumIterationsEnclosingSphere() { }

	// RVA: 0x2B574E0 Offset: 0x2B55EE0 VA: 0x182B574E0
	public static int get_maxPerObjectLights() { }

	// RVA: 0x2B57580 Offset: 0x2B55F80 VA: 0x182B57580
	public static int get_maxVisibleAdditionalLights() { }

	// RVA: 0x2B57480 Offset: 0x2B55E80 VA: 0x182B57480
	internal static int get_lightsPerTile() { }

	// RVA: 0xF72A10 Offset: 0xF71410 VA: 0x180F72A10
	internal static int get_maxZBinWords() { }

	// RVA: 0x2B57520 Offset: 0x2B55F20 VA: 0x182B57520
	internal static int get_maxTileWords() { }

	// RVA: 0x2B57640 Offset: 0x2B56040 VA: 0x182B57640
	internal static int get_maxVisibleReflectionProbes() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 9
	public override RenderPipelineGlobalSettings get_defaultSettings() { }

	// RVA: 0x2B55EE0 Offset: 0x2B548E0 VA: 0x182B55EE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B56CF0 Offset: 0x2B556F0 VA: 0x182B56CF0
	public void .ctor(UniversalRenderPipelineAsset asset) { }

	// RVA: 0x2B4E2C0 Offset: 0x2B4CCC0 VA: 0x182B4E2C0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2B4E200 Offset: 0x2B4CC00 VA: 0x182B4E200
	private void DisposeAdditionalCameraData() { }

	// RVA: 0x2B548B0 Offset: 0x2B532B0 VA: 0x182B548B0 Slot: 4
	protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x2B54950 Offset: 0x2B53350 VA: 0x182B54950 Slot: 7
	protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66C80 Offset: 0xF65680 VA: 0x180F66C80
	|-UniversalRenderPipeline.IsRenderRequestSupported<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF67930 Offset: 0xF66330 VA: 0x180F67930
	|-UniversalRenderPipeline.ProcessRenderRequests<object>
	|
	|-RVA: 0xF66DE0 Offset: 0xF657E0 VA: 0x180F66DE0
	|-UniversalRenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type", False)]
	// RVA: 0x2B54850 Offset: 0x2B53250 VA: 0x182B54850
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2B539A0 Offset: 0x2B523A0 VA: 0x182B539A0
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2B53BA0 Offset: 0x2B525A0 VA: 0x182B53BA0
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData) { }

	// RVA: 0x2B55F00 Offset: 0x2B54900 VA: 0x182B55F00
	private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams) { }

	// RVA: 0x2B53D00 Offset: 0x2B52700 VA: 0x182B53D00
	private static void RenderSingleCamera(ScriptableRenderContext context, ref CameraData cameraData) { }

	// RVA: 0x2B523D0 Offset: 0x2B50DD0 VA: 0x182B523D0
	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera) { }

	// RVA: 0x2B56200 Offset: 0x2B54C00 VA: 0x182B56200
	private static void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr) { }

	// RVA: 0x2B56820 Offset: 0x2B55220 VA: 0x182B56820
	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

	// RVA: 0x2B4DE70 Offset: 0x2B4C870 VA: 0x182B4DE70
	private static bool CheckPostProcessForDepth(ref CameraData cameraData) { }

	// RVA: 0x2B4DDA0 Offset: 0x2B4C7A0 VA: 0x182B4DDA0
	private static bool CheckPostProcessForDepth() { }

	// RVA: 0x2B554E0 Offset: 0x2B53EE0 VA: 0x182B554E0
	private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset) { }

	// RVA: 0x2B4FA10 Offset: 0x2B4E410 VA: 0x182B4FA10
	private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData) { }

	// RVA: 0x2B516E0 Offset: 0x2B500E0 VA: 0x182B516E0
	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData) { }

	// RVA: 0x2B4F060 Offset: 0x2B4DA60 VA: 0x182B4F060
	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData) { }

	// RVA: 0x2B50660 Offset: 0x2B4F060 VA: 0x182B50660
	private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, CommandBuffer cmd, out RenderingData renderingData) { }

	// RVA: 0x2B50D90 Offset: 0x2B4F790 VA: 0x182B50D90
	private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, out ShadowData shadowData) { }

	// RVA: 0x2B50600 Offset: 0x2B4F000 VA: 0x182B50600
	private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, bool isHDROutputActive, out PostProcessingData postProcessingData) { }

	// RVA: 0x2B503C0 Offset: 0x2B4EDC0 VA: 0x182B503C0
	private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData) { }

	// RVA: 0x2B4DAC0 Offset: 0x2B4C4C0 VA: 0x182B4DAC0
	private static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings) { }

	// RVA: 0x2B56670 Offset: 0x2B55070 VA: 0x182B56670
	private static void UpdateTemporalAAData(ref CameraData cameraData, UniversalAdditionalCameraData additionalCameraData) { }

	// RVA: 0x2B56760 Offset: 0x2B55160 VA: 0x182B56760
	private static void UpdateTemporalAATargets(ref CameraData cameraData) { }

	// RVA: 0x2B564B0 Offset: 0x2B54EB0 VA: 0x182B564B0
	private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr) { }

	// RVA: 0x2B4EBC0 Offset: 0x2B4D5C0 VA: 0x182B4EBC0
	private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus) { }

	// RVA: 0x2B4E970 Offset: 0x2B4D370 VA: 0x182B4E970
	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2B55AF0 Offset: 0x2B544F0 VA: 0x182B55AF0
	private static void SetupPerFrameShaderConstants() { }

	// RVA: 0x2B55540 Offset: 0x2B53F40 VA: 0x182B55540
	private static void SetupPerCameraShaderConstants(CommandBuffer cmd) { }

	// RVA: 0x2B4DB70 Offset: 0x2B4C570 VA: 0x182B4DB70
	private static void CheckAndApplyDebugSettings(ref RenderingData renderingData) { }

	// RVA: 0x2B55200 Offset: 0x2B53C00 VA: 0x182B55200
	private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection) { }

	// RVA: 0x2B4EF40 Offset: 0x2B4D940 VA: 0x182B4EF40
	internal static bool HDROutputForMainDisplayIsActive() { }

	// RVA: 0x2B4EEA0 Offset: 0x2B4D8A0 VA: 0x182B4EEA0
	internal static bool HDROutputForAnyDisplayIsActive() { }

	// RVA: 0x2B55390 Offset: 0x2B53D90 VA: 0x182B55390
	private void SetHDRState(List<Camera> cameras) { }

	// RVA: 0x2B4E6E0 Offset: 0x2B4D0E0 VA: 0x182B4E6E0
	internal static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	// RVA: 0x2B4E5E0 Offset: 0x2B4CFE0 VA: 0x182B4E5E0
	internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	// RVA: 0x2B51ED0 Offset: 0x2B508D0 VA: 0x182B51ED0
	public static bool IsGameCamera(Camera camera) { }

	[Obsolete("Please use CameraData.xr.enabled instead.", True)]
	// RVA: 0x2B51FA0 Offset: 0x2B509A0 VA: 0x182B51FA0
	public static bool IsStereoEnabled(Camera camera) { }

	// RVA: 0x2B57400 Offset: 0x2B55E00 VA: 0x182B57400
	public static UniversalRenderPipelineAsset get_asset() { }

	// RVA: 0x2B55E70 Offset: 0x2B54870 VA: 0x182B55E70
	private void SortCameras(List<Camera> cameras) { }

	// RVA: 0x2B52090 Offset: 0x2B50A90 VA: 0x182B52090
	internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha) { }

	// RVA: 0x2B52190 Offset: 0x2B50B90 VA: 0x182B52190
	internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat() { }

	// RVA: 0x2B4DEF0 Offset: 0x2B4C8F0 VA: 0x182B4DEF0
	internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, ref CameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture) { }

	// RVA: 0x2B4E820 Offset: 0x2B4D220 VA: 0x182B4E820
	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<float> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir) { }

	// RVA: 0x2B4ECD0 Offset: 0x2B4D6D0 VA: 0x182B4ECD0
	internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation) { }

	// RVA: 0x2B4ED20 Offset: 0x2B4D720 VA: 0x182B4ED20
	internal static void GetSpotAngleAttenuation(float spotAngle, Nullable<float> innerSpotAngle, ref Vector4 lightAttenuation) { }

	// RVA: 0x2B4EE30 Offset: 0x2B4D830 VA: 0x182B4EE30
	internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir) { }

	// RVA: 0x2B4FE50 Offset: 0x2B4E850 VA: 0x182B4FE50
	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	// RVA: 0x2B52390 Offset: 0x2B50D90 VA: 0x182B52390
	private static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B521F0 Offset: 0x2B50BF0 VA: 0x182B521F0
	private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B56AD0 Offset: 0x2B554D0 VA: 0x182B56AD0
	private static void .cctor() { }
}
