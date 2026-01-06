public static class MeshGenerator // TypeDefIndex: 308
{
	// Fields
	private const float kMinTruncatedRadius = 0.001;

	// Methods

	// RVA: 0x69C460 Offset: 0x69AE60 VA: 0x18069C460
	private static float GetAngleOffset(int numSides) { }

	// RVA: 0x69C540 Offset: 0x69AF40 VA: 0x18069C540
	private static float GetRadiiScale(int numSides) { }

	// RVA: 0x69C3E0 Offset: 0x69ADE0 VA: 0x18069C3E0
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided) { }

	// RVA: 0x69B1A0 Offset: 0x699BA0 VA: 0x18069B1A0
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided) { }

	// RVA: 0x69B9B0 Offset: 0x69A3B0 VA: 0x18069B9B0
	public static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided) { }

	// RVA: 0x69B220 Offset: 0x699C20 VA: 0x18069B220
	public static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted) { }

	// RVA: 0x69B140 Offset: 0x699B40 VA: 0x18069B140
	public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd) { }

	// RVA: 0x69C4B0 Offset: 0x69AEB0 VA: 0x18069C4B0
	private static int GetCapAdditionalVerticesCount(MeshGenerator.CapMode capMode, int numSides) { }

	// RVA: 0x69C480 Offset: 0x69AE80 VA: 0x18069C480
	private static int GetCapAdditionalIndicesCount(MeshGenerator.CapMode capMode, int numSides) { }

	// RVA: 0x69C720 Offset: 0x69B120 VA: 0x18069C720
	public static int GetVertexCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided) { }

	// RVA: 0x69C4F0 Offset: 0x69AEF0 VA: 0x18069C4F0
	public static int GetIndicesCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided) { }

	// RVA: 0x69C670 Offset: 0x69B070 VA: 0x18069C670
	public static int GetSharedMeshVertexCount() { }

	// RVA: 0x69C5D0 Offset: 0x69AFD0 VA: 0x18069C5D0
	public static int GetSharedMeshIndicesCount() { }

	// RVA: 0x69C5A0 Offset: 0x69AFA0 VA: 0x18069C5A0
	public static int GetSharedMeshHDVertexCount() { }

	// RVA: 0x69C570 Offset: 0x69AF70 VA: 0x18069C570
	public static int GetSharedMeshHDIndicesCount() { }
}
