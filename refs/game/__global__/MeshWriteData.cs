public class MeshWriteData // TypeDefIndex: 6747
{
	// Fields
	internal NativeSlice<Vertex> m_Vertices; // 0x10
	internal NativeSlice<ushort> m_Indices; // 0x20
	internal Rect m_UVRegion; // 0x30
	internal int currentIndex; // 0x40
	internal int currentVertex; // 0x44

	// Properties
	public int vertexCount { get; }
	public int indexCount { get; }
	public Rect uvRegion { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2EDD380 Offset: 0x2EDBD80 VA: 0x182EDD380
	public int get_vertexCount() { }

	// RVA: 0x2EDD340 Offset: 0x2EDBD40 VA: 0x182EDD340
	public int get_indexCount() { }

	// RVA: 0x2CEF790 Offset: 0x2CEE190 VA: 0x182CEF790
	public Rect get_uvRegion() { }

	// RVA: 0x2EDD2C0 Offset: 0x2EDBCC0 VA: 0x182EDD2C0
	public void SetNextVertex(Vertex vertex) { }

	// RVA: 0x2EDD260 Offset: 0x2EDBC60 VA: 0x182EDD260
	public void SetNextIndex(ushort index) { }

	// RVA: 0x2EDD1A0 Offset: 0x2EDBBA0 VA: 0x182EDD1A0
	public void SetAllVertices(Vertex[] vertices) { }

	// RVA: 0x2EDD0E0 Offset: 0x2EDBAE0 VA: 0x182EDD0E0
	public void SetAllIndices(ushort[] indices) { }

	// RVA: 0x2EDD090 Offset: 0x2EDBA90 VA: 0x182EDD090
	internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices) { }

	// RVA: 0x2EDD0C0 Offset: 0x2EDBAC0 VA: 0x182EDD0C0
	internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion) { }
}
