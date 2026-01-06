internal struct TilingJob : IJobFor // TypeDefIndex: 9034
{
	// Fields
	[ReadOnly]
	public NativeArray<VisibleLight> lights; // 0x0
	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; // 0x10
	[NativeDisableParallelForRestriction]
	public NativeArray<InclusiveRange> tileRanges; // 0x20
	public int itemsPerTile; // 0x30
	public int rangesPerItem; // 0x34
	public Fixed2<float4x4> worldToViews; // 0x38
	public float2 tileScale; // 0xB8
	public float2 tileScaleInv; // 0xC0
	public Fixed2<float> viewPlaneBottoms; // 0xC8
	public Fixed2<float> viewPlaneTops; // 0xD0
	public Fixed2<float4> viewToViewportScaleBiases; // 0xD8
	public int2 tileCount; // 0xF8
	public float near; // 0x100
	public bool isOrthographic; // 0x104
	private InclusiveRange m_TileYRange; // 0x106
	private int m_Offset; // 0x10C
	private int m_ViewIndex; // 0x110
	private float2 m_CenterOffset; // 0x114
	private static readonly float3[] k_CubePoints; // 0x0
	private static readonly int4[] k_CubeLineIndices; // 0x8

	// Methods

	// RVA: 0x2B2F4B0 Offset: 0x2B2DEB0 VA: 0x182B2F4B0 Slot: 4
	public void Execute(int jobIndex) { }

	// RVA: 0x2B32AE0 Offset: 0x2B314E0 VA: 0x182B32AE0
	private void TileLight(int lightIndex) { }

	// RVA: 0x2B31AD0 Offset: 0x2B304D0 VA: 0x182B31AD0
	private void TileLightOrthographic(int lightIndex) { }

	// RVA: 0x2B350E0 Offset: 0x2B33AE0 VA: 0x182B350E0
	private void TileReflectionProbe(int index) { }

	// RVA: 0x2B35EE0 Offset: 0x2B348E0 VA: 0x182B35EE0
	private float2 ViewToTileSpace(float3 positionVS) { }

	// RVA: 0x2B35E30 Offset: 0x2B34830 VA: 0x182B35E30
	private float2 ViewToTileSpaceOrthographic(float3 positionVS) { }

	// RVA: 0x2B2F7E0 Offset: 0x2B2E1E0 VA: 0x182B2F7E0
	private void ExpandY(float3 positionVS) { }

	// RVA: 0x2B2F5F0 Offset: 0x2B2DFF0 VA: 0x182B2F5F0
	private void ExpandOrthographic(float3 positionVS) { }

	// RVA: 0x2B2F700 Offset: 0x2B2E100 VA: 0x182B2F700
	private void ExpandRangeOrthographic(ref InclusiveRange range, float xVS) { }

	// RVA: 0xBBA170 Offset: 0xBB8B70 VA: 0x180BBA170
	private static float square(float x) { }

	// RVA: 0x2B30E40 Offset: 0x2B2F840 VA: 0x182B30E40
	private static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1) { }

	// RVA: 0x2B31130 Offset: 0x2B2FB30 VA: 0x182B31130
	private static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right) { }

	// RVA: 0x2B30330 Offset: 0x2B2ED30 VA: 0x182B30330
	private static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1) { }

	// RVA: 0x2B31940 Offset: 0x2B30340 VA: 0x182B31940
	private static ValueTuple<float, float> IntersectEllipseLine(float a, float b, float3 line) { }

	// RVA: 0x2B30B90 Offset: 0x2B2F590 VA: 0x182B30B90
	private static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2) { }

	// RVA: 0x2B31550 Offset: 0x2B2FF50 VA: 0x182B31550
	private static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2) { }

	// RVA: 0x2B305B0 Offset: 0x2B2EFB0 VA: 0x182B305B0
	private static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2) { }

	// RVA: 0x2B2F240 Offset: 0x2B2DC40 VA: 0x182B2F240
	private static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta) { }

	// RVA: 0x2B2F8F0 Offset: 0x2B2E2F0 VA: 0x182B2F8F0
	private static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v) { }

	// RVA: 0x2B2FBE0 Offset: 0x2B2E5E0 VA: 0x182B2FBE0
	private static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y) { }

	// RVA: 0x2B35FA0 Offset: 0x2B349A0 VA: 0x182B35FA0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2B35BF0 Offset: 0x2B345F0 VA: 0x182B35BF0
	internal static bool <TileLight>g__SpherePointIsValid|19_0(float3 p, ref TilingJob.<>c__DisplayClass19_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2B35CF0 Offset: 0x2B346F0 VA: 0x182B35CF0
	internal static bool <TileLight>g__ConicPointIsValid|19_1(float3 p, ref TilingJob.<>c__DisplayClass19_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2B35BF0 Offset: 0x2B345F0 VA: 0x182B35BF0
	internal static bool <TileLightOrthographic>g__SpherePointIsValid|20_0(float3 p, ref TilingJob.<>c__DisplayClass20_0 ) { }
}
