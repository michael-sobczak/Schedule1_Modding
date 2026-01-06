public class GameObjectToMesh : CGModule // TypeDefIndex: 10725
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGGameObject) }, Array = True)]
	public CGModuleInputSlot InGameObjects; // 0xC0
	[HideInInspector]
	[OutputSlotInfo(typeof(CGVMesh), Array = True)]
	public CGModuleOutputSlot OutVMesh; // 0xC8
	[SerializeField]
	[Tooltip("Whether to include or not the meshes from the input Game Objects' children")]
	private bool useChildrenMeshes; // 0xD0
	[Tooltip("Forces the output mesh to be centered")]
	[SerializeField]
	private bool centerMesh; // 0xD1

	// Properties
	public bool UseChildrenMeshes { get; set; }
	public bool CenterMesh { get; set; }

	// Methods

	// RVA: 0x5187E0 Offset: 0x5171E0 VA: 0x1805187E0
	public bool get_UseChildrenMeshes() { }

	// RVA: 0x5316F0 Offset: 0x5300F0 VA: 0x1805316F0
	public void set_UseChildrenMeshes(bool value) { }

	// RVA: 0x518770 Offset: 0x517170 VA: 0x180518770
	public bool get_CenterMesh() { }

	// RVA: 0x5316D0 Offset: 0x5300D0 VA: 0x1805316D0
	public void set_CenterMesh(bool value) { }

	// RVA: 0x5315C0 Offset: 0x52FFC0 VA: 0x1805315C0 Slot: 13
	public override void Reset() { }

	// RVA: 0x530C40 Offset: 0x52F640 VA: 0x180530C40 Slot: 14
	public override void Refresh() { }

	// RVA: 0x530660 Offset: 0x52F060 VA: 0x180530660
	public static Mesh CombineMeshFilters(MeshFilter[] meshFilters, out List<Material> materials, Matrix4x4 originTrs, List<string> errorMessages) { }

	// RVA: 0x531620 Offset: 0x530020 VA: 0x180531620
	public void .ctor() { }
}
