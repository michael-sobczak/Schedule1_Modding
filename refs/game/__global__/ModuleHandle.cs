internal struct ModuleHandle // TypeDefIndex: 9197
{
	// Fields
	internal static readonly int kMaxArea; // 0x0
	internal static readonly int kMaxEdgeCount; // 0x4
	internal static readonly int kMaxIndexCount; // 0x8
	internal static readonly int kMaxVertexCount; // 0xC
	internal static readonly int kMaxTriangleCount; // 0x10
	internal static readonly int kMaxRefineIterations; // 0x14
	internal static readonly int kMaxSmoothenIterations; // 0x18
	internal static readonly float kIncrementAreaFactor; // 0x1C

	// Methods

	// RVA: -1 Offset: -1
	internal static void Copy<T>(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF04A60 Offset: 0xF03460 VA: 0x180F04A60
	|-ModuleHandle.Copy<int>
	|
	|-RVA: 0xF04900 Offset: 0xF03300 VA: 0x180F04900
	|-ModuleHandle.Copy<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF04BC0 Offset: 0xF035C0 VA: 0x180F04BC0
	|-ModuleHandle.Copy<float2>
	|-ModuleHandle.Copy<int2>
	|
	|-RVA: 0xF04C60 Offset: 0xF03660 VA: 0x180F04C60
	|-ModuleHandle.Copy<int4>
	*/

	// RVA: -1 Offset: -1
	internal static void Copy<T>(NativeArray<T> src, NativeArray<T> dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF049A0 Offset: 0xF033A0 VA: 0x180F049A0
	|-ModuleHandle.Copy<int>
	|
	|-RVA: 0xF04850 Offset: 0xF03250 VA: 0x180F04850
	|-ModuleHandle.Copy<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF04B00 Offset: 0xF03500 VA: 0x180F04B00
	|-ModuleHandle.Copy<float2>
	|-ModuleHandle.Copy<int2>
	|
	|-RVA: 0xF04D00 Offset: 0xF03700 VA: 0x180F04D00
	|-ModuleHandle.Copy<int4>
	*/

	// RVA: -1 Offset: -1
	internal static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF05AA0 Offset: 0xF044A0 VA: 0x180F05AA0
	|-ModuleHandle.InsertionSort<double, XCompare>
	|
	|-RVA: 0xF05EB0 Offset: 0xF048B0 VA: 0x180F05EB0
	|-ModuleHandle.InsertionSort<UEvent, TessEventCompare>
	|
	|-RVA: 0xF05B70 Offset: 0xF04570 VA: 0x180F05B70
	|-ModuleHandle.InsertionSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF06010 Offset: 0xF04A10 VA: 0x180F06010
	|-ModuleHandle.InsertionSort<int2, IntersectionCompare>
	|
	|-RVA: 0xF060F0 Offset: 0xF04AF0 VA: 0x180F060F0
	|-ModuleHandle.InsertionSort<int2, TessEdgeCompare>
	|-ModuleHandle.InsertionSort<int2, TessJunctionCompare>
	|
	|-RVA: 0xF061B0 Offset: 0xF04BB0 VA: 0x180F061B0
	|-ModuleHandle.InsertionSort<int3, TessCellCompare>
	|
	|-RVA: 0xF06300 Offset: 0xF04D00 VA: 0x180F06300
	|-ModuleHandle.InsertionSort<int4, DelaEdgeCompare>
	*/

	// RVA: -1 Offset: -1
	internal static int GetLower<T, U, X>(NativeArray<T> values, int count, U check, X condition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF05520 Offset: 0xF03F20 VA: 0x180F05520
	|-ModuleHandle.GetLower<UHull, UEvent, Tessellator.TestHullEventLe>
	|
	|-RVA: 0xF05650 Offset: 0xF04050 VA: 0x180F05650
	|-ModuleHandle.GetLower<UHull, float2, Tessellator.TestHullPointL>
	|
	|-RVA: 0xF05310 Offset: 0xF03D10 VA: 0x180F05310
	|-ModuleHandle.GetLower<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static int GetUpper<T, U, X>(NativeArray<T> values, int count, U check, X condition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF05980 Offset: 0xF04380 VA: 0x180F05980
	|-ModuleHandle.GetUpper<UHull, float2, Tessellator.TestHullPointU>
	|
	|-RVA: 0xF05770 Offset: 0xF04170 VA: 0x180F05770
	|-ModuleHandle.GetUpper<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static int GetEqual<T, U, X>(NativeArray<T> values, int count, U check, X condition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF04FF0 Offset: 0xF039F0 VA: 0x180F04FF0
	|-ModuleHandle.GetEqual<UHull, UEvent, Tessellator.TestHullEventE>
	|
	|-RVA: 0xF04DC0 Offset: 0xF037C0 VA: 0x180F04DC0
	|-ModuleHandle.GetEqual<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF05130 Offset: 0xF03B30 VA: 0x180F05130
	|-ModuleHandle.GetEqual<int2, int2, Tessellator.TestEdgePointE>
	|
	|-RVA: 0xF05200 Offset: 0xF03C00 VA: 0x180F05200
	|-ModuleHandle.GetEqual<int3, int3, Tessellator.TestCellE>
	*/

	// RVA: 0x2A95190 Offset: 0x2A93B90 VA: 0x182A95190
	internal static float OrientFast(float2 a, float2 b, float2 c) { }

	// RVA: 0x2A95130 Offset: 0x2A93B30 VA: 0x182A95130
	internal static double OrientFastDouble(double2 a, double2 b, double2 c) { }

	// RVA: 0x2A941B0 Offset: 0x2A92BB0 VA: 0x182A941B0
	internal static UCircle CircumCircle(UTriangle tri) { }

	// RVA: 0x2A94DE0 Offset: 0x2A937E0 VA: 0x182A94DE0
	internal static bool IsInsideCircle(UCircle c, float2 v) { }

	// RVA: 0x2A96860 Offset: 0x2A95260 VA: 0x182A96860
	internal static float TriangleArea(float2 va, float2 vb, float2 vc) { }

	// RVA: 0x2A952B0 Offset: 0x2A93CB0 VA: 0x182A952B0
	internal static float Sign(float2 p1, float2 p2, float2 p3) { }

	// RVA: 0x2A94FE0 Offset: 0x2A939E0 VA: 0x182A94FE0
	internal static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3) { }

	// RVA: 0x2A94E30 Offset: 0x2A93830 VA: 0x182A94E30
	internal static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3) { }

	// RVA: 0x2A94BB0 Offset: 0x2A935B0 VA: 0x182A94BB0
	internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p) { }

	// RVA: 0x2A93E70 Offset: 0x2A92870 VA: 0x182A93E70
	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	// RVA: 0x2A939D0 Offset: 0x2A923D0 VA: 0x182A939D0
	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge) { }

	// RVA: 0x2A935D0 Offset: 0x2A91FD0 VA: 0x182A935D0
	internal static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	// RVA: 0x2A94710 Offset: 0x2A93110 VA: 0x182A94710
	private static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2> dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount) { }

	// RVA: 0x2A94610 Offset: 0x2A93010 VA: 0x182A94610
	private static void CopyGeometry(NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount) { }

	// RVA: 0x2A966F0 Offset: 0x2A950F0 VA: 0x182A966F0
	private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount, NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount) { }

	// RVA: 0x2A94820 Offset: 0x2A93220 VA: 0x182A94820
	private static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, bool resetTopology) { }

	// RVA: 0x2A95210 Offset: 0x2A93C10 VA: 0x182A95210
	private static void Reorder(int startVertexCount, int index, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount) { }

	// RVA: 0x2A968C0 Offset: 0x2A952C0 VA: 0x182A968C0
	internal static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount) { }

	// RVA: 0x2A94390 Offset: 0x2A92D90 VA: 0x182A94390
	public static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount) { }

	// RVA: 0x2A96250 Offset: 0x2A94C50 VA: 0x182A96250
	public static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount) { }

	// RVA: 0x2A95310 Offset: 0x2A93D10 VA: 0x182A95310
	public static float4 Subdivide(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations) { }

	// RVA: 0x2A969D0 Offset: 0x2A953D0 VA: 0x182A969D0
	private static void .cctor() { }
}
