public class RecastMeshObj : VersionedMonoBehaviour // TypeDefIndex: 13279
{
	// Fields
	protected static RecastBBTree tree; // 0x0
	protected static List<RecastMeshObj> dynamicMeshObjs; // 0x8
	[HideInInspector]
	public Bounds bounds; // 0x28
	public bool dynamic; // 0x40
	public int area; // 0x44
	private bool _dynamic; // 0x48
	private bool registered; // 0x49

	// Methods

	// RVA: 0xB75620 Offset: 0xB74020 VA: 0x180B75620
	public static void GetAllInBounds(List<RecastMeshObj> buffer, Bounds bounds) { }

	// RVA: 0xB75FB0 Offset: 0xB749B0 VA: 0x180B75FB0
	private void OnEnable() { }

	// RVA: 0xB76220 Offset: 0xB74C20 VA: 0x180B76220
	private void Register() { }

	// RVA: 0xB75FC0 Offset: 0xB749C0 VA: 0x180B75FC0
	private void RecalculateBounds() { }

	// RVA: 0xB75C80 Offset: 0xB74680 VA: 0x180B75C80
	public Bounds GetBounds() { }

	// RVA: 0xB75D00 Offset: 0xB74700 VA: 0x180B75D00
	public MeshFilter GetMeshFilter() { }

	// RVA: 0xB75CC0 Offset: 0xB746C0 VA: 0x180B75CC0
	public Collider GetCollider() { }

	// RVA: 0xB75D40 Offset: 0xB74740 VA: 0x180B75D40
	private void OnDisable() { }

	// RVA: 0xB76610 Offset: 0xB75010 VA: 0x180B76610
	public void .ctor() { }

	// RVA: 0xB76530 Offset: 0xB74F30 VA: 0x180B76530
	private static void .cctor() { }
}
