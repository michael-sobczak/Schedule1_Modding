public class AdditionalLightsShadowCasterPass : ScriptableRenderPass // TypeDefIndex: 9122
{
	// Fields
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", False)]
	public static int m_AdditionalShadowsBufferId; // 0x0
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", False)]
	public static int m_AdditionalShadowsIndicesId; // 0x4
	private static readonly Vector4 c_DefaultShadowParams; // 0x8
	private static int m_AdditionalLightsWorldToShadow_SSBO; // 0x18
	private static int m_AdditionalShadowParams_SSBO; // 0x1C
	private bool m_UseStructuredBuffer; // 0xE0
	private const int k_ShadowmapBufferBits = 16;
	private int m_AdditionalLightsShadowmapID; // 0xE4
	internal RTHandle m_AdditionalLightsShadowmapHandle; // 0xE8
	private bool m_CreateEmptyShadowmap; // 0xF0
	private RTHandle m_EmptyAdditionalLightShadowmapTexture; // 0xF8
	private const int k_EmptyShadowMapDimensions = 1;
	private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture";
	private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture";
	internal static Vector4[] s_EmptyAdditionalLightIndexToShadowParams; // 0x20
	private float m_MaxShadowDistanceSq; // 0x100
	private float m_CascadeBorder; // 0x104
	private ShadowSliceData[] m_AdditionalLightsShadowSlices; // 0x108
	private int[] m_VisibleLightIndexToAdditionalLightIndex; // 0x110
	private int[] m_AdditionalLightIndexToVisibleLightIndex; // 0x118
	private List<int> m_ShadowSliceToAdditionalLightIndex; // 0x120
	private List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex; // 0x128
	private Vector4[] m_AdditionalLightIndexToShadowParams; // 0x130
	private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix; // 0x138
	private List<AdditionalLightsShadowCasterPass.ShadowResolutionRequest> m_ShadowResolutionRequests; // 0x140
	private float[] m_VisibleLightIndexToCameraSquareDistance; // 0x148
	private AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] m_SortedShadowResolutionRequests; // 0x150
	private int[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex; // 0x158
	private List<RectInt> m_UnusedAtlasSquareAreas; // 0x160
	private int renderTargetWidth; // 0x168
	private int renderTargetHeight; // 0x16C
	private ProfilingSampler m_ProfilingSetupSampler; // 0x170
	private const float LightTypeIdentifierInShadowParams_Spot = 0;
	private const float LightTypeIdentifierInShadowParams_Point = 1;
	private const int kMinimumPunctualLightHardShadowResolution = 8;
	private const int kMinimumPunctualLightSoftShadowResolution = 16;
	private Dictionary<int, ulong> m_ShadowRequestsHashes; // 0x178

	// Methods

	// RVA: 0x2B5CEE0 Offset: 0x2B5B8E0 VA: 0x182B5CEE0
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x55E850 Offset: 0x55D250 VA: 0x18055E850
	public void Dispose() { }

	// RVA: 0x2B58F50 Offset: 0x2B57950 VA: 0x182B58F50
	private int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	// RVA: 0x2B58880 Offset: 0x2B57280 VA: 0x182B58880
	internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels) { }

	// RVA: 0x2B59660 Offset: 0x2B58060 VA: 0x182B59660
	private int MinimalPunctualLightShadowResolution(bool softShadow) { }

	// RVA: 0x2B58E60 Offset: 0x2B57860 VA: 0x182B58E60
	internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering) { }

	// RVA: 0x2B59180 Offset: 0x2B57B80 VA: 0x182B59180
	internal void InsertionSort(AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] array, int startIndex, int lastIndex) { }

	// RVA: 0x2B58CD0 Offset: 0x2B576D0 VA: 0x182B58CD0
	private int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth) { }

	// RVA: 0x2B584A0 Offset: 0x2B56EA0 VA: 0x182B584A0
	private void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor) { }

	// RVA: 0x2B5A8E0 Offset: 0x2B592E0 VA: 0x182B5A8E0
	private ulong ResolutionLog2ForHash(int resolution) { }

	// RVA: 0x2B58970 Offset: 0x2B57370 VA: 0x182B58970
	private ulong ComputeShadowRequestHash(ref RenderingData renderingData) { }

	// RVA: 0x2B5B1D0 Offset: 0x2B59BD0 VA: 0x182B5B1D0
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x2B5B060 Offset: 0x2B59A60 VA: 0x182B5B060
	private bool SetupForEmptyRendering(ref RenderingData renderingData) { }

	// RVA: 0x2B58C70 Offset: 0x2B57670 VA: 0x182B58C70 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2B58D60 Offset: 0x2B57760 VA: 0x182B58D60 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B58F70 Offset: 0x2B57970 VA: 0x182B58F70
	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	// RVA: 0x2B58910 Offset: 0x2B57310 VA: 0x182B58910
	private void Clear() { }

	// RVA: 0x2B5AA60 Offset: 0x2B59460 VA: 0x182B5AA60
	private void SetEmptyAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B5A930 Offset: 0x2B59330 VA: 0x182B5A930
	internal static void SetEmptyAdditionalLightShadowParams(CommandBuffer cmd, Vector4[] lightIndexToShadowParams) { }

	// RVA: 0x2B59670 Offset: 0x2B58070 VA: 0x182B59670
	private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B5AC50 Offset: 0x2B59650 VA: 0x182B5AC50
	private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, bool softShadows) { }

	// RVA: 0x2B59570 Offset: 0x2B57F70 VA: 0x182B59570
	private bool IsValidShadowCastingLight(ref LightData lightData, int i) { }

	// RVA: 0x2B59FA0 Offset: 0x2B589A0 VA: 0x182B59FA0
	internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData) { }

	// RVA: 0x2B58FB0 Offset: 0x2B579B0 VA: 0x182B58FB0
	private void InitPassData(ref AdditionalLightsShadowCasterPass.PassData passData, ref RenderingData renderingData, ref RenderGraph graph) { }

	// RVA: 0x2B5CE70 Offset: 0x2B5B870 VA: 0x182B5CE70
	private static void .cctor() { }
}
