internal static class LightUtility // TypeDefIndex: 8707
{
	// Methods

	// RVA: 0x2A7E8D0 Offset: 0x2A7D2D0 VA: 0x182A7E8D0
	public static bool CheckForChange(Light2D.LightType a, ref Light2D.LightType b) { }

	// RVA: 0x2A7E8D0 Offset: 0x2A7D2D0 VA: 0x182A7E8D0
	public static bool CheckForChange(int a, ref int b) { }

	// RVA: 0x2A7E8F0 Offset: 0x2A7D2F0 VA: 0x182A7E8F0
	public static bool CheckForChange(float a, ref float b) { }

	// RVA: 0x2A7E8E0 Offset: 0x2A7D2E0 VA: 0x182A7E8E0
	public static bool CheckForChange(bool a, ref bool b) { }

	// RVA: 0x2A81630 Offset: 0x2A80030 VA: 0x182A81630
	private static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint) { }

	// RVA: 0x2A7E910 Offset: 0x2A7D310 VA: 0x182A7E910
	private static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart) { }

	// RVA: 0x2A81410 Offset: 0x2A7FE10 VA: 0x182A81410
	private static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath) { }

	// RVA: 0x2A7ECB0 Offset: 0x2A7D6B0 VA: 0x182A7ECB0
	private static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart) { }

	// RVA: 0x2A80F00 Offset: 0x2A7F900 VA: 0x182A80F00
	internal static List<Vector2> GetOutlinePath(Vector3[] shapePath, float offsetDistance) { }

	// RVA: 0x2A816E0 Offset: 0x2A800E0 VA: 0x182A816E0
	private static void TransferToMesh(NativeArray<LightUtility.LightMeshVertex> vertices, int vertexCount, NativeArray<ushort> indices, int indexCount, Light2D light) { }

	// RVA: 0x2A7F930 Offset: 0x2A7E330 VA: 0x182A7F930
	public static Bounds GenerateShapeMesh(Light2D light, Vector3[] shapePath, float falloffDistance) { }

	// RVA: 0x2A7EFC0 Offset: 0x2A7D9C0 VA: 0x182A7EFC0
	public static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides) { }

	// RVA: 0x2A809A0 Offset: 0x2A7F3A0 VA: 0x182A809A0
	public static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite) { }

	// RVA: 0x2A81340 Offset: 0x2A7FD40 VA: 0x182A81340
	public static int GetShapePathHash(Vector3[] path) { }
}
