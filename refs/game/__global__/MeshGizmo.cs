internal class MeshGizmo : IDisposable // TypeDefIndex: 13873
{
	// Fields
	public static readonly int vertexCountPerCube; // 0x0
	public Mesh mesh; // 0x10
	private List<Vector3> vertices; // 0x18
	private List<int> indices; // 0x20
	private List<Color> colors; // 0x28
	private Material wireMaterial; // 0x30
	private Material dottedWireMaterial; // 0x38
	private Material solidMaterial; // 0x40

	// Methods

	// RVA: 0x2A573D0 Offset: 0x2A55DD0 VA: 0x182A573D0
	public void .ctor(int capacity = 0) { }

	// RVA: 0x2A56C00 Offset: 0x2A55600 VA: 0x182A56C00
	public void Clear() { }

	// RVA: 0x2A563F0 Offset: 0x2A54DF0 VA: 0x182A563F0
	public void AddWireCube(Vector3 center, Vector3 size, Color color) { }

	// RVA: 0x2A56CD0 Offset: 0x2A556D0 VA: 0x182A56CD0
	private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName) { }

	// RVA: 0x2A56EB0 Offset: 0x2A558B0 VA: 0x182A56EB0
	public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = 4, string gizmoName) { }

	// RVA: 0x2A56C80 Offset: 0x2A55680 VA: 0x182A56C80 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A57390 Offset: 0x2A55D90 VA: 0x182A57390
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2A57080 Offset: 0x2A55A80 VA: 0x182A57080
	private void <AddWireCube>g__AddEdge|10_0(Vector3 p1, Vector3 p2, ref MeshGizmo.<>c__DisplayClass10_0 ) { }
}
