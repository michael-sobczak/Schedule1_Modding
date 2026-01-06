public struct CombineInstance // TypeDefIndex: 11723
{
	// Fields
	private int m_MeshInstanceID; // 0x0
	private int m_SubMeshIndex; // 0x4
	private Matrix4x4 m_Transform; // 0x8
	private Vector4 m_LightmapScaleOffset; // 0x48
	private Vector4 m_RealtimeLightmapScaleOffset; // 0x58

	// Properties
	public Mesh mesh { get; set; }
	public int subMeshIndex { set; }
	public Matrix4x4 transform { set; }

	// Methods

	// RVA: 0x2CA3940 Offset: 0x2CA2340 VA: 0x182CA3940
	public Mesh get_mesh() { }

	// RVA: 0x2CA3950 Offset: 0x2CA2350 VA: 0x182CA3950
	public void set_mesh(Mesh value) { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_subMeshIndex(int value) { }

	// RVA: 0x2CA39E0 Offset: 0x2CA23E0 VA: 0x182CA39E0
	public void set_transform(Matrix4x4 value) { }
}
