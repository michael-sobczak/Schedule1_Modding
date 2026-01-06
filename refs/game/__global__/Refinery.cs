internal struct Refinery // TypeDefIndex: 9169
{
	// Fields
	private static readonly float kMinAreaFactor; // 0x0
	private static readonly float kMaxAreaFactor; // 0x4
	private static readonly int kMaxSteinerCount; // 0x8

	// Methods

	// RVA: 0x2B7BBA0 Offset: 0x2B7A5A0 VA: 0x182B7BBA0
	private static bool RequiresRefining(UTriangle tri, float maxArea) { }

	// RVA: 0x2B7B860 Offset: 0x2B7A260 VA: 0x182B7B860
	private static void FetchEncroachedSegments(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<UEncroachingSegment> encroach, ref int encroachCount, UCircle c) { }

	// RVA: 0x2B7BB80 Offset: 0x2B7A580 VA: 0x182B7BB80
	private static void InsertVertex(ref NativeArray<float2> pgPoints, ref int pgPointCount, float2 newVertex, ref int nid) { }

	// RVA: 0x2B7BAA0 Offset: 0x2B7A4A0 VA: 0x182B7BAA0
	private static int FindSegment(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, UEncroachingSegment es) { }

	// RVA: 0x2B7BBB0 Offset: 0x2B7A5B0 VA: 0x182B7BBB0
	private static void SplitSegments(ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, UEncroachingSegment es) { }

	// RVA: 0x2B7B280 Offset: 0x2B79C80 VA: 0x182B7B280
	internal static bool Condition(Allocator allocator, float factorArea, float targetArea, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount, ref float maxArea) { }

	// RVA: 0x2B7BEA0 Offset: 0x2B7A8A0 VA: 0x182B7BEA0
	private static void .cctor() { }
}
