public class TrashContent // TypeDefIndex: 2245
{
	// Fields
	public List<TrashContent.Entry> Entries; // 0x10

	// Methods

	// RVA: 0x84AAE0 Offset: 0x8494E0 VA: 0x18084AAE0
	public void AddTrash(string trashID, int quantity) { }

	// RVA: 0x84B280 Offset: 0x849C80 VA: 0x18084B280
	public void RemoveTrash(string trashID, int quantity) { }

	// RVA: 0x84B0F0 Offset: 0x849AF0 VA: 0x18084B0F0
	public int GetTrashQuantity(string trashID) { }

	// RVA: 0x84ADA0 Offset: 0x8497A0 VA: 0x18084ADA0
	public void Clear() { }

	// RVA: 0x84AFD0 Offset: 0x8499D0 VA: 0x18084AFD0
	public int GetTotalSize() { }

	// RVA: 0x84AE00 Offset: 0x849800 VA: 0x18084AE00
	public TrashContentData GetData() { }

	// RVA: 0x84B1E0 Offset: 0x849BE0 VA: 0x18084B1E0
	public void LoadFromData(TrashContentData data) { }

	// RVA: 0x84B3B0 Offset: 0x849DB0 VA: 0x18084B3B0
	public void .ctor() { }
}
