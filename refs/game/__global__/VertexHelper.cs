public class VertexHelper : IDisposable // TypeDefIndex: 16494
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2F441B0 Offset: 0x2F42BB0 VA: 0x182F441B0
	public void .ctor(Mesh m) { }

	// RVA: 0x2F43A30 Offset: 0x2F42430 VA: 0x182F43A30
	private void InitializeListIfRequired() { }

	// RVA: 0x2F43640 Offset: 0x2F42040 VA: 0x182F43640 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F43550 Offset: 0x2F41F50 VA: 0x182F43550
	public void Clear() { }

	// RVA: 0x2F44440 Offset: 0x2F42E40 VA: 0x182F44440
	public int get_currentVertCount() { }

	// RVA: 0x2F443F0 Offset: 0x2F42DF0 VA: 0x182F443F0
	public int get_currentIndexCount() { }

	// RVA: 0x2F43C10 Offset: 0x2F42610 VA: 0x182F43C10
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x2F43DD0 Offset: 0x2F427D0 VA: 0x182F43DD0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x2F43850 Offset: 0x2F42250 VA: 0x182F43850
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x2F43110 Offset: 0x2F41B10 VA: 0x182F43110
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2F42EF0 Offset: 0x2F418F0 VA: 0x182F42EF0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x2F42D00 Offset: 0x2F41700 VA: 0x182F42D00
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x2F43060 Offset: 0x2F41A60 VA: 0x182F43060
	public void AddVert(UIVertex v) { }

	// RVA: 0x2F427C0 Offset: 0x2F411C0 VA: 0x182F427C0
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x2F42930 Offset: 0x2F41330 VA: 0x182F42930
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x2F42BC0 Offset: 0x2F415C0 VA: 0x182F42BC0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x2F42C80 Offset: 0x2F41680 VA: 0x182F42C80
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x2F439B0 Offset: 0x2F423B0 VA: 0x182F439B0
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x2F44120 Offset: 0x2F42B20 VA: 0x182F44120
	private static void .cctor() { }
}
