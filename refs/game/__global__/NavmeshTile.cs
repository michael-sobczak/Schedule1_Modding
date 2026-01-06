public class NavmeshTile : INavmeshHolder, ITransformedGraph, INavmesh // TypeDefIndex: 13269
{
	// Fields
	public int[] tris; // 0x10
	public Int3[] verts; // 0x18
	public Int3[] vertsInGraphSpace; // 0x20
	public int x; // 0x28
	public int z; // 0x2C
	public int w; // 0x30
	public int d; // 0x34
	public TriangleMeshNode[] nodes; // 0x38
	public BBTree bbTree; // 0x40
	public bool flag; // 0x48
	public NavmeshBase graph; // 0x50

	// Properties
	public GraphTransform transform { get; }

	// Methods

	// RVA: 0xB6C190 Offset: 0xB6AB90 VA: 0x180B6C190 Slot: 7
	public void GetTileCoordinates(int tileIndex, out int x, out int z) { }

	// RVA: 0xB43D60 Offset: 0xB42760 VA: 0x180B43D60 Slot: 6
	public int GetVertexArrayIndex(int index) { }

	// RVA: 0xB6C1F0 Offset: 0xB6ABF0 VA: 0x180B6C1F0 Slot: 4
	public Int3 GetVertex(int index) { }

	// RVA: 0xB6C1A0 Offset: 0xB6ABA0 VA: 0x180B6C1A0 Slot: 5
	public Int3 GetVertexInGraphSpace(int index) { }

	// RVA: 0xB6C240 Offset: 0xB6AC40 VA: 0x180B6C240 Slot: 8
	public GraphTransform get_transform() { }

	// RVA: 0xB6C0F0 Offset: 0xB6AAF0 VA: 0x180B6C0F0 Slot: 9
	public void GetNodes(Action<GraphNode> action) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
