public sealed class MeshFilter : Component // TypeDefIndex: 11678
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void DontStripMeshFilter() { }

	// RVA: 0x2C94F30 Offset: 0x2C93930 VA: 0x182C94F30
	public Mesh get_sharedMesh() { }

	// RVA: 0x2C94FC0 Offset: 0x2C939C0 VA: 0x182C94FC0
	public void set_sharedMesh(Mesh value) { }

	[NativeName("SetInstantiatedMesh")]
	// RVA: 0x2C94F70 Offset: 0x2C93970 VA: 0x182C94F70
	public void set_mesh(Mesh value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
