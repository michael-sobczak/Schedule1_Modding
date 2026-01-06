public static class ShadowUtils // TypeDefIndex: 9016
{
	// Fields
	internal static readonly bool m_ForceShadowPointSampling; // 0x0
	private static int _ShadowBias; // 0x4
	private static int _LightDirection; // 0x8
	private static int _LightPosition; // 0xC
	internal const int kMinimumPunctualLightHardShadowResolution = 8;
	internal const int kMinimumPunctualLightSoftShadowResolution = 16;

	// Methods

	// RVA: 0x2B2AF20 Offset: 0x2B29920 VA: 0x182B2AF20
	private static void .cctor() { }

	// RVA: 0x2B28620 Offset: 0x2B27020 VA: 0x182B28620
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	// RVA: 0x2B28750 Offset: 0x2B27150 VA: 0x182B28750
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	// RVA: 0x2B28D00 Offset: 0x2B27700 VA: 0x182B28D00
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	// RVA: 0x2B28B10 Offset: 0x2B27510 VA: 0x182B28B10
	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	// RVA: 0x2B29C90 Offset: 0x2B28690 VA: 0x182B29C90
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view) { }

	// RVA: 0x2B29A50 Offset: 0x2B28450 VA: 0x182B29A50
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings) { }

	// RVA: 0x2B28ED0 Offset: 0x2B278D0 VA: 0x182B28ED0
	public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount) { }

	// RVA: 0x2B28450 Offset: 0x2B26E50 VA: 0x182B28450
	public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight) { }

	// RVA: 0x2B28FA0 Offset: 0x2B279A0 VA: 0x182B28FA0
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	// RVA: 0x2B28F30 Offset: 0x2B27930 VA: 0x182B28F30
	internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias) { }

	// RVA: 0x2B2A420 Offset: 0x2B28E20 VA: 0x182B2A420
	public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	// RVA: 0x2B2A0F0 Offset: 0x2B28AF0 VA: 0x182B2A0F0
	internal static void SetShadowBias(CommandBuffer cmd, Vector4 shadowBias) { }

	// RVA: 0x2B29F00 Offset: 0x2B28900 VA: 0x182B29F00
	internal static void SetLightDirection(CommandBuffer cmd, Vector3 lightDirection) { }

	// RVA: 0x2B29FB0 Offset: 0x2B289B0 VA: 0x182B29FB0
	internal static void SetLightPosition(CommandBuffer cmd, Vector3 lightPosition) { }

	// RVA: 0x2B29E50 Offset: 0x2B28850 VA: 0x182B29E50
	internal static void SetCameraPosition(CommandBuffer cmd, Vector3 worldSpaceCameraPos) { }

	// RVA: 0x2B2A2A0 Offset: 0x2B28CA0 VA: 0x182B2A2A0
	internal static void SetWorldToCameraMatrix(CommandBuffer cmd, Matrix4x4 viewMatrix) { }

	// RVA: 0x2B29610 Offset: 0x2B28010 VA: 0x182B29610
	private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits) { }

	[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded")]
	// RVA: 0x2B297E0 Offset: 0x2B281E0 VA: 0x182B297E0
	public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits) { }

	// RVA: 0x2B2A6E0 Offset: 0x2B290E0 VA: 0x182B2A6E0
	public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	// RVA: 0x2B28320 Offset: 0x2B26D20 VA: 0x182B28320
	public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	// RVA: 0x2B2A9A0 Offset: 0x2B293A0 VA: 0x182B2A9A0
	public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2B29390 Offset: 0x2B27D90 VA: 0x182B29390
	private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) { }

	// RVA: 0x2B2ADB0 Offset: 0x2B297B0 VA: 0x182B2ADB0
	internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	internal static bool SupportsPerLightSoftShadowQuality() { }

	// RVA: 0x2B2A060 Offset: 0x2B28A60 VA: 0x182B2A060
	internal static void SetPerLightSoftShadowKeyword(CommandBuffer cmd, bool hasSoftShadows) { }

	// RVA: 0x2B2A180 Offset: 0x2B28B80 VA: 0x182B2A180
	internal static void SetSoftShadowQualityShaderKeywords(CommandBuffer cmd, ref ShadowData shadowData) { }

	// RVA: 0x2B298E0 Offset: 0x2B282E0 VA: 0x182B298E0
	internal static bool IsValidShadowCastingLight(ref LightData lightData, int i) { }

	// RVA: 0x2B28F10 Offset: 0x2B27910 VA: 0x182B28F10
	internal static int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	// RVA: 0x2B29A40 Offset: 0x2B28440 VA: 0x182B29A40
	internal static int MinimalPunctualLightShadowResolution(bool softShadow) { }
}
