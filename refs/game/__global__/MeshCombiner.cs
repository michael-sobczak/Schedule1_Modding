public class MeshCombiner : MonoBehaviour // TypeDefIndex: 59
{
	// Fields
	private const int Mesh16BitBufferVertexLimit = 65535;
	[SerializeField]
	private bool createMultiMaterialMesh; // 0x20
	[SerializeField]
	private bool combineInactiveChildren; // 0x21
	[SerializeField]
	private bool deactivateCombinedChildren; // 0x22
	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers; // 0x23
	[SerializeField]
	private bool generateUVMap; // 0x24
	[SerializeField]
	private bool destroyCombinedChildren; // 0x25
	[SerializeField]
	private string folderPath; // 0x28
	[SerializeField]
	[Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	private MeshFilter[] meshFiltersToSkip; // 0x30

	// Properties
	public bool CreateMultiMaterialMesh { get; set; }
	public bool CombineInactiveChildren { get; set; }
	public bool DeactivateCombinedChildren { get; set; }
	public bool DeactivateCombinedChildrenMeshRenderers { get; set; }
	public bool GenerateUVMap { get; set; }
	public bool DestroyCombinedChildren { get; set; }
	public string FolderPath { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_CreateMultiMaterialMesh() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_CreateMultiMaterialMesh(bool value) { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_CombineInactiveChildren() { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void set_CombineInactiveChildren(bool value) { }

	// RVA: 0x563D70 Offset: 0x562770 VA: 0x180563D70
	public bool get_DeactivateCombinedChildren() { }

	// RVA: 0x563DD0 Offset: 0x5627D0 VA: 0x180563DD0
	public void set_DeactivateCombinedChildren(bool value) { }

	// RVA: 0x563D60 Offset: 0x562760 VA: 0x180563D60
	public bool get_DeactivateCombinedChildrenMeshRenderers() { }

	// RVA: 0x563DB0 Offset: 0x5627B0 VA: 0x180563DB0
	public void set_DeactivateCombinedChildrenMeshRenderers(bool value) { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_GenerateUVMap() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_GenerateUVMap(bool value) { }

	// RVA: 0x563D80 Offset: 0x562780 VA: 0x180563D80
	public bool get_DestroyCombinedChildren() { }

	// RVA: 0x563DF0 Offset: 0x5627F0 VA: 0x180563DF0
	public void set_DestroyCombinedChildren(bool value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_FolderPath() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_FolderPath(string value) { }

	// RVA: 0x562150 Offset: 0x560B50 VA: 0x180562150
	private void CheckDeactivateCombinedChildren() { }

	// RVA: 0x562170 Offset: 0x560B70 VA: 0x180562170
	private void CheckDestroyCombinedChildren() { }

	// RVA: 0x563470 Offset: 0x561E70 VA: 0x180563470
	public void CombineMeshes(bool showCreatedMeshInfo) { }

	// RVA: 0x5639B0 Offset: 0x5623B0 VA: 0x1805639B0
	private MeshFilter[] GetMeshFiltersToCombine() { }

	// RVA: 0x562E30 Offset: 0x561830 VA: 0x180562E30
	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo) { }

	// RVA: 0x562180 Offset: 0x560B80 VA: 0x180562180
	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo) { }

	// RVA: 0x563810 Offset: 0x562210 VA: 0x180563810
	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void GenerateUV(Mesh combinedMesh) { }

	// RVA: 0x563CC0 Offset: 0x5626C0 VA: 0x180563CC0
	public void .ctor() { }
}
