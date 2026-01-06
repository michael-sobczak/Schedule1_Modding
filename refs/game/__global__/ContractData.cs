public class ContractData : QuestData // TypeDefIndex: 1101
{
	// Fields
	public string CustomerGUID; // 0x60
	public float Payment; // 0x68
	public ProductList ProductList; // 0x70
	public string DeliveryLocationGUID; // 0x78
	public QuestWindowConfig DeliveryWindow; // 0x80
	public int PickupScheduleIndex; // 0x88
	public GameDateTimeData AcceptTime; // 0x90

	// Methods

	// RVA: 0x5D8780 Offset: 0x5D7180 VA: 0x1805D8780
	public void .ctor(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) { }
}
