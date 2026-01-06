public class RetainedGizmos // TypeDefIndex: 13414
{
	// Fields
	private List<RetainedGizmos.MeshWithHash> meshes; // 0x10
	private HashSet<ulong> usedHashes; // 0x18
	private HashSet<ulong> existingHashes; // 0x20
	private Stack<Mesh> cachedMeshes; // 0x28
	public Material surfaceMaterial; // 0x30
	public Material lineMaterial; // 0x38

	// Methods

	// RVA: 0xBC83E0 Offset: 0xBC6DE0 VA: 0x180BC83E0
	public GraphGizmoHelper GetSingleFrameGizmoHelper(AstarPath active) { }

	// RVA: 0xBC81E0 Offset: 0xBC6BE0 VA: 0x180BC81E0
	public GraphGizmoHelper GetGizmoHelper(AstarPath active, RetainedGizmos.Hasher hasher) { }

	// RVA: 0xBC8660 Offset: 0xBC7060 VA: 0x180BC8660
	private void PoolMesh(Mesh mesh) { }

	// RVA: 0xBC8330 Offset: 0xBC6D30 VA: 0x180BC8330
	private Mesh GetMesh() { }

	// RVA: 0xBC8600 Offset: 0xBC7000 VA: 0x180BC8600
	public bool HasCachedMesh(RetainedGizmos.Hasher hasher) { }

	// RVA: 0xBC7DD0 Offset: 0xBC67D0 VA: 0x180BC7DD0
	public bool Draw(RetainedGizmos.Hasher hasher) { }

	// RVA: 0xBC7D10 Offset: 0xBC6710 VA: 0x180BC7D10
	public void DrawExisting() { }

	// RVA: 0xBC7E70 Offset: 0xBC6870 VA: 0x180BC7E70
	public void FinalizeDraw() { }

	// RVA: 0xBC7C30 Offset: 0xBC6630 VA: 0x180BC7C30
	public void ClearCache() { }

	// RVA: 0xBC86D0 Offset: 0xBC70D0 VA: 0x180BC86D0
	private void RemoveUnusedMeshes(List<RetainedGizmos.MeshWithHash> meshList) { }

	// RVA: 0xBC88D0 Offset: 0xBC72D0 VA: 0x180BC88D0
	public void .ctor() { }
}
