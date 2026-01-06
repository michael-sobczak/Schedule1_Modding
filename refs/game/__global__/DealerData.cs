public class DealerData : NPCData // TypeDefIndex: 1062
{
	// Fields
	public bool Recruited; // 0x30
	public string[] AssignedCustomerIDs; // 0x38
	public string[] ActiveContractGUIDs; // 0x40
	public float Cash; // 0x48
	public ItemSet OverflowItems; // 0x50
	public bool HasBeenRecommended; // 0x58

	// Methods

	// RVA: 0x5D8AC0 Offset: 0x5D74C0 VA: 0x1805D8AC0
	public void .ctor(string id, bool recruited, string[] assignedCustomerIDs, string[] activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended) { }
}
