public struct CullingResults : IEquatable<CullingResults> // TypeDefIndex: 12242
{
	// Fields
	internal IntPtr ptr; // 0x0
	private CullingAllocationInfo* m_AllocationInfo; // 0x8

	// Properties
	public NativeArray<VisibleLight> visibleLights { get; }
	public NativeArray<VisibleReflectionProbe> visibleReflectionProbes { get; }
	public int lightAndReflectionProbeIndexCount { get; }

	// Methods

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetLightIndexCount")]
	// RVA: 0x2CDE7A0 Offset: 0x2CDD1A0 VA: 0x182CDE7A0
	private static int GetLightIndexCount(IntPtr cullingResultsPtr) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetReflectionProbeIndexCount")]
	// RVA: 0x2CDE930 Offset: 0x2CDD330 VA: 0x182CDE930
	private static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr) { }

	[FreeFunction("FillLightAndReflectionProbeIndices")]
	// RVA: 0x2CDE6D0 Offset: 0x2CDD0D0 VA: 0x182CDE6D0
	private static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer) { }

	[FreeFunction("GetLightIndexMapSize")]
	// RVA: 0x2CDE7E0 Offset: 0x2CDD1E0 VA: 0x182CDE7E0
	private static int GetLightIndexMapSize(IntPtr cullingResultsPtr) { }

	[FreeFunction("FillLightIndexMapScriptable")]
	// RVA: 0x2CDE720 Offset: 0x2CDD120 VA: 0x182CDE720
	private static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[FreeFunction("SetLightIndexMapScriptable")]
	// RVA: 0x2CDEAB0 Offset: 0x2CDD4B0 VA: 0x182CDEAB0
	private static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetShadowCasterBounds")]
	// RVA: 0x2CDE9C0 Offset: 0x2CDD3C0 VA: 0x182CDE9C0
	private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeSpotShadowMatricesAndCullingPrimitives")]
	// RVA: 0x2CDE430 Offset: 0x2CDCE30 VA: 0x182CDE430
	private static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputePointShadowMatricesAndCullingPrimitives")]
	// RVA: 0x2CDE3D0 Offset: 0x2CDCDD0 VA: 0x182CDE3D0
	private static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeDirectionalShadowMatricesAndCullingPrimitives")]
	// RVA: 0x2CDE2B0 Offset: 0x2CDCCB0 VA: 0x182CDE2B0
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2CDEB80 Offset: 0x2CDD580 VA: 0x182CDEB80
	public NativeArray<VisibleLight> get_visibleLights() { }

	// RVA: 0x2CDEC00 Offset: 0x2CDD600 VA: 0x182CDEC00
	public NativeArray<VisibleReflectionProbe> get_visibleReflectionProbes() { }

	// RVA: -1 Offset: -1
	private NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E3C0 Offset: 0xE6CDC0 VA: 0x180E6E3C0
	|-CullingResults.GetNativeArray<VisibleLight>
	|-CullingResults.GetNativeArray<VisibleReflectionProbe>
	|
	|-RVA: 0xE6E340 Offset: 0xE6CD40 VA: 0x180E6E340
	|-CullingResults.GetNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CDEB10 Offset: 0x2CDD510 VA: 0x182CDEB10
	public int get_lightAndReflectionProbeIndexCount() { }

	// RVA: 0x2CDE680 Offset: 0x2CDD080 VA: 0x182CDE680
	public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer) { }

	// RVA: 0x2CDE820 Offset: 0x2CDD220 VA: 0x182CDE820
	public NativeArray<int> GetLightIndexMap(Allocator allocator) { }

	// RVA: 0x2CDEA10 Offset: 0x2CDD410 VA: 0x182CDEA10
	public void SetLightIndexMap(NativeArray<int> lightIndexMap) { }

	// RVA: 0x2CDE970 Offset: 0x2CDD370 VA: 0x182CDE970
	public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) { }

	// RVA: 0x2CDE490 Offset: 0x2CDCE90 VA: 0x182CDE490
	public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2CDE370 Offset: 0x2CDCD70 VA: 0x182CDE370
	public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2CDE1E0 Offset: 0x2CDCBE0 VA: 0x182CDE1E0
	public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2CDE600 Offset: 0x2CDD000 VA: 0x182CDE600 Slot: 4
	public bool Equals(CullingResults other) { }

	// RVA: 0x2CDE4F0 Offset: 0x2CDCEF0 VA: 0x182CDE4F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CDE780 Offset: 0x2CDD180 VA: 0x182CDE780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CDEC80 Offset: 0x2CDD680 VA: 0x182CDEC80
	public static bool op_Equality(CullingResults left, CullingResults right) { }

	// RVA: 0x2CDE170 Offset: 0x2CDCB70 VA: 0x182CDE170
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }
}
