public class TrashGrabberInstance : StorableItemInstance // TypeDefIndex: 3299
{
	// Fields
	public const int TRASH_CAPACITY = 20;
	private TrashContent Content; // 0x38

	// Methods

	// RVA: 0xA5D470 Offset: 0xA5BE70 VA: 0x180A5D470
	public void .ctor() { }

	// RVA: 0xA5D4E0 Offset: 0xA5BEE0 VA: 0x180A5D4E0
	public void .ctor(ItemDefinition definition, int quantity) { }

	// RVA: 0xA5CD20 Offset: 0xA5B720 VA: 0x180A5CD20 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0xA5D420 Offset: 0xA5BE20 VA: 0x180A5D420
	public void LoadContentData(TrashContentData content) { }

	// RVA: 0xA5CDE0 Offset: 0xA5B7E0 VA: 0x180A5CDE0 Slot: 14
	public override ItemData GetItemData() { }

	// RVA: 0xA5CCC0 Offset: 0xA5B6C0 VA: 0x180A5CCC0
	public void AddTrash(string id, int quantity) { }

	// RVA: 0xA5D440 Offset: 0xA5BE40 VA: 0x180A5D440
	public void RemoveTrash(string id, int quantity) { }

	// RVA: 0xA5CCF0 Offset: 0xA5B6F0 VA: 0x180A5CCF0
	public void ClearTrash() { }

	// RVA: 0xA5CE80 Offset: 0xA5B880 VA: 0x180A5CE80
	public int GetTotalSize() { }

	// RVA: 0xA5CEA0 Offset: 0xA5B8A0 VA: 0x180A5CEA0
	public List<string> GetTrashIDs() { }

	// RVA: 0xA5D080 Offset: 0xA5BA80 VA: 0x180A5D080
	public List<int> GetTrashQuantities() { }

	// RVA: 0xA5D250 Offset: 0xA5BC50 VA: 0x180A5D250
	public List<ushort> GetTrashUshortQuantities() { }
}
