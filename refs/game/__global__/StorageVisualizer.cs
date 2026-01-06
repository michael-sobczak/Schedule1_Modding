public class StorageVisualizer : MonoBehaviour // TypeDefIndex: 2403
{
	// Fields
	[Header("References")]
	public StorageGrid[] StorageGrids; // 0x20
	public Transform ItemContainer; // 0x28
	[Header("Settings")]
	[Tooltip("Should storage visuals be fully recalculated when item(s) are removed?")]
	public bool FullRefreshOnItemRemoved; // 0x30
	protected List<ItemSlot> itemSlots; // 0x38
	protected int totalFootprintCapacity; // 0x40
	protected Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems; // 0x48
	public bool BlockRefreshes; // 0x50

	// Methods

	// RVA: 0x888140 Offset: 0x886B40 VA: 0x180888140 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x887FB0 Offset: 0x8869B0 VA: 0x180887FB0
	public void AddSlot(ItemSlot slot, bool update = False) { }

	// RVA: 0x888A70 Offset: 0x887470 VA: 0x180888A70
	public Dictionary<StorableItemInstance, int> GetVisualRepresentation() { }

	// RVA: 0x888AC0 Offset: 0x8874C0 VA: 0x180888AC0 Slot: 5
	public virtual void RefreshVisuals() { }

	// RVA: 0x8883F0 Offset: 0x886DF0 VA: 0x1808883F0
	private List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement) { }

	// RVA: 0x888220 Offset: 0x886C20 VA: 0x180888220
	private void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement) { }

	// RVA: 0x888780 Offset: 0x887180 VA: 0x180888780
	public Dictionary<StorableItemInstance, int> GetContentsDictionary() { }

	// RVA: 0x888AA0 Offset: 0x8874A0 VA: 0x180888AA0
	protected void QueueRefresh() { }

	// RVA: 0x880B00 Offset: 0x87F500 VA: 0x180880B00
	public void .ctor() { }
}
