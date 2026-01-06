public static class VectorMath // TypeDefIndex: 13150
{
	// Methods

	// RVA: 0xB13570 Offset: 0xB11F70 VA: 0x180B13570
	public static Vector2 ComplexMultiply(Vector2 a, Vector2 b) { }

	// RVA: 0xB13520 Offset: 0xB11F20 VA: 0x180B13520
	public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b) { }

	// RVA: 0xB12FE0 Offset: 0xB119E0 VA: 0x180B12FE0
	public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point) { }

	// RVA: 0xB12F10 Offset: 0xB11910 VA: 0x180B12F10
	public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point) { }

	// RVA: 0xB12E00 Offset: 0xB11800 VA: 0x180B12E00
	public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point) { }

	// RVA: 0xB12D70 Offset: 0xB11770 VA: 0x180B12D70
	public static float ClosestPointOnLineFactor(Int2 lineStart, Int2 lineEnd, Int2 point) { }

	// RVA: 0xB133E0 Offset: 0xB11DE0 VA: 0x180B133E0
	public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point) { }

	// RVA: 0xB131B0 Offset: 0xB11BB0 VA: 0x180B131B0
	public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point) { }

	// RVA: 0xB15720 Offset: 0xB14120 VA: 0x180B15720
	public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz) { }

	// RVA: 0xB15640 Offset: 0xB14040 VA: 0x180B15640
	public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p) { }

	// RVA: 0xB15800 Offset: 0xB14200 VA: 0x180B15800
	public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p) { }

	// RVA: 0xB15980 Offset: 0xB14380 VA: 0x180B15980
	public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2) { }

	// RVA: 0xB15DB0 Offset: 0xB147B0 VA: 0x180B15DB0
	public static float SqrDistanceXZ(Vector3 a, Vector3 b) { }

	// RVA: 0xB15600 Offset: 0xB14000 VA: 0x180B15600
	public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c) { }

	// RVA: 0xB155C0 Offset: 0xB13FC0 VA: 0x180B155C0
	public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xB14C50 Offset: 0xB13650 VA: 0x180B14C50
	public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p) { }

	// RVA: 0xB14CA0 Offset: 0xB136A0 VA: 0x180B14CA0
	public static bool RightXZ(Int3 a, Int3 b, Int3 p) { }

	// RVA: 0xB15570 Offset: 0xB13F70 VA: 0x180B15570
	public static Side SideXZ(Int3 a, Int3 b, Int3 p) { }

	// RVA: 0xB14BB0 Offset: 0xB135B0 VA: 0x180B14BB0
	public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p) { }

	// RVA: 0xB14C10 Offset: 0xB13610 VA: 0x180B14C10
	public static bool RightOrColinear(Int2 a, Int2 b, Int2 p) { }

	// RVA: 0xB14B70 Offset: 0xB13570 VA: 0x180B14B70
	public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p) { }

	// RVA: 0xB14B30 Offset: 0xB13530 VA: 0x180B14B30
	public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p) { }

	// RVA: 0xB135C0 Offset: 0xB11FC0 VA: 0x180B135C0
	public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xB136E0 Offset: 0xB120E0 VA: 0x180B136E0
	public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xB13720 Offset: 0xB12120 VA: 0x180B13720
	public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c) { }

	// RVA: 0xB13610 Offset: 0xB12010 VA: 0x180B13610
	public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c) { }

	// RVA: 0xB136A0 Offset: 0xB120A0 VA: 0x180B136A0
	public static bool IsClockwiseOrColinear(Int2 a, Int2 b, Int2 c) { }

	// RVA: 0xB138E0 Offset: 0xB122E0 VA: 0x180B138E0
	public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xB13870 Offset: 0xB12270 VA: 0x180B13870
	public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c) { }

	// RVA: 0xB13840 Offset: 0xB12240 VA: 0x180B13840
	public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c) { }

	// RVA: 0xB137F0 Offset: 0xB121F0 VA: 0x180B137F0
	public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0xB137B0 Offset: 0xB121B0 VA: 0x180B137B0
	public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c) { }

	// RVA: 0xB15450 Offset: 0xB13E50 VA: 0x180B15450
	public static bool SegmentsIntersect(Int2 start1, Int2 end1, Int2 start2, Int2 end2) { }

	// RVA: 0xB15250 Offset: 0xB13C50 VA: 0x180B15250
	public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) { }

	// RVA: 0xB15170 Offset: 0xB13B70 VA: 0x180B15170
	public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) { }

	// RVA: 0xB143F0 Offset: 0xB12DF0 VA: 0x180B143F0
	public static bool LineLineIntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float t) { }

	// RVA: 0xB13C60 Offset: 0xB12660 VA: 0x180B13C60
	public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2) { }

	// RVA: 0xB13B90 Offset: 0xB12590 VA: 0x180B13B90
	public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects) { }

	// RVA: 0xB147C0 Offset: 0xB131C0 VA: 0x180B147C0
	public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) { }

	// RVA: 0xB13DA0 Offset: 0xB127A0 VA: 0x180B13DA0
	public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2) { }

	// RVA: 0xB13F10 Offset: 0xB12910 VA: 0x180B13F10
	public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2) { }

	// RVA: 0xB14490 Offset: 0xB12E90 VA: 0x180B14490
	public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) { }

	// RVA: 0xB13D20 Offset: 0xB12720 VA: 0x180B13D20
	public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) { }

	// RVA: 0xB14110 Offset: 0xB12B10 VA: 0x180B14110
	public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) { }

	// RVA: 0xB14000 Offset: 0xB12A00 VA: 0x180B14000
	public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) { }

	// RVA: 0xB14220 Offset: 0xB12C20 VA: 0x180B14220
	public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2) { }

	// RVA: 0xB14300 Offset: 0xB12D00 VA: 0x180B14300
	public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects) { }

	// RVA: 0xB14CF0 Offset: 0xB136F0 VA: 0x180B14CF0
	public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) { }

	// RVA: 0xB14E40 Offset: 0xB13840 VA: 0x180B14E40
	public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b) { }

	// RVA: 0xB139B0 Offset: 0xB123B0 VA: 0x180B139B0
	public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius) { }

	// RVA: 0xB149D0 Offset: 0xB133D0 VA: 0x180B149D0
	public static bool ReversesFaceOrientations(Matrix4x4 matrix) { }

	// RVA: 0xB14910 Offset: 0xB13310 VA: 0x180B14910
	public static bool ReversesFaceOrientationsXZ(Matrix4x4 matrix) { }

	// RVA: 0xB14700 Offset: 0xB13100 VA: 0x180B14700
	public static Vector3 Normalize(Vector3 v, out float magnitude) { }

	// RVA: 0xB14600 Offset: 0xB13000 VA: 0x180B14600
	public static Vector2 Normalize(Vector2 v, out float magnitude) { }

	// RVA: 0xB12CD0 Offset: 0xB116D0 VA: 0x180B12CD0
	public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude) { }

	// RVA: 0xB145D0 Offset: 0xB12FD0 VA: 0x180B145D0
	public static float MagnitudeXZ(Vector3 v) { }
}
