public class RasterizationMesh // TypeDefIndex: 13352
{
	// Fields
	public MeshFilter original; // 0x10
	public int area; // 0x18
	public Vector3[] vertices; // 0x20
	public int[] triangles; // 0x28
	public int numVertices; // 0x30
	public int numTriangles; // 0x34
	public Bounds bounds; // 0x38
	public Matrix4x4 matrix; // 0x50
	public bool pool; // 0x90

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xB8E180 Offset: 0xB8CB80 VA: 0x180B8E180
	public void .ctor(Vector3[] vertices, int[] triangles, Bounds bounds) { }

	// RVA: 0xB8E270 Offset: 0xB8CC70 VA: 0x180B8E270
	public void .ctor(Vector3[] vertices, int[] triangles, Bounds bounds, Matrix4x4 matrix) { }

	// RVA: 0xB8DEE0 Offset: 0xB8C8E0 VA: 0x180B8DEE0
	public void RecalculateBounds() { }

	// RVA: 0xB8DE30 Offset: 0xB8C830 VA: 0x180B8DE30
	public void Pool() { }
}
