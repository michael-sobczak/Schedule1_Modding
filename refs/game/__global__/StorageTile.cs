public class StorageTile : MonoBehaviour // TypeDefIndex: 2401
{
	// Fields
	public int x; // 0x20
	public int y; // 0x24
	[SerializeField]
	public StorageGrid ownerGrid; // 0x28
	public Action onOccupantChanged; // 0x30
	[CompilerGenerated]
	private StoredItem <occupant>k__BackingField; // 0x38

	// Properties
	public StorageGrid _ownerGrid { get; }
	public StoredItem occupant { get; set; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public StorageGrid get__ownerGrid() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public StoredItem get_occupant() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_occupant(StoredItem value) { }

	// RVA: 0x887A70 Offset: 0x886470 VA: 0x180887A70
	public void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid) { }

	// RVA: 0x887A90 Offset: 0x886490 VA: 0x180887A90
	public void SetOccupant(StoredItem occ) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
