public class MeshPool // TypeDefIndex: 10828
{
	// Fields
	private Queue<Mesh> freeMeshes; // 0x10
	private List<Mesh> allMeshes; // 0x18

	// Methods

	// RVA: 0x5416C0 Offset: 0x5400C0 VA: 0x1805416C0
	public Mesh AllocateMesh() { }

	// RVA: 0x5418A0 Offset: 0x5402A0 VA: 0x1805418A0
	public void ReleaseAllMeshes() { }

	// RVA: 0x5419F0 Offset: 0x5403F0 VA: 0x1805419F0
	public void .ctor() { }
}
