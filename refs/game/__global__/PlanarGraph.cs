internal struct PlanarGraph // TypeDefIndex: 9168
{
	// Fields
	private static readonly double kEpsilon; // 0x0
	private static readonly int kMaxIntersectionTolerance; // 0x8

	// Methods

	// RVA: 0x2B7A5E0 Offset: 0x2B78FE0 VA: 0x182B7A5E0
	internal static void RemoveDuplicateEdges(ref NativeArray<int2> edges, ref int edgeCount, NativeArray<int> duplicates, int duplicateCount) { }

	// RVA: 0x2B79A70 Offset: 0x2B78470 VA: 0x182B79A70
	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1) { }

	// RVA: 0x2B79ED0 Offset: 0x2B788D0 VA: 0x182B79ED0
	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1) { }

	// RVA: 0x2B7A400 Offset: 0x2B78E00 VA: 0x182B7A400
	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result) { }

	// RVA: 0x2B79370 Offset: 0x2B77D70 VA: 0x182B79370
	internal static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2> results, ref NativeArray<double2> intersects, ref int resultCount) { }

	// RVA: 0x2B797D0 Offset: 0x2B781D0 VA: 0x182B797D0
	internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount) { }

	// RVA: 0x2B79BF0 Offset: 0x2B785F0 VA: 0x182B79BF0
	internal static bool CutEdges(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int2> edges, ref int edgeCount, ref NativeArray<int2> tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount) { }

	// RVA: 0x2B7A7C0 Offset: 0x2B791C0 VA: 0x182B7A7C0
	internal static void RemoveDuplicatePoints(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int> duplicates, ref int duplicateCount, Allocator allocator) { }

	// RVA: 0x2B7AAD0 Offset: 0x2B794D0 VA: 0x182B7AAD0
	internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, ref int outputPointCount, ref NativeArray<int2> outputEdges, ref int outputEdgeCount) { }

	// RVA: 0x2B7B220 Offset: 0x2B79C20 VA: 0x182B7B220
	private static void .cctor() { }
}
