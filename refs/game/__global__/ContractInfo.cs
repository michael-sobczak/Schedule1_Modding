public class ContractInfo // TypeDefIndex: 688
{
	// Fields
	public float Payment; // 0x10
	public ProductList Products; // 0x18
	public string DeliveryLocationGUID; // 0x20
	public QuestWindowConfig DeliveryWindow; // 0x28
	public bool Expires; // 0x30
	public int ExpiresAfter; // 0x34
	public int PickupScheduleIndex; // 0x38
	public bool IsCounterOffer; // 0x3C
	[CompilerGenerated]
	private DeliveryLocation <DeliveryLocation>k__BackingField; // 0x40

	// Properties
	public DeliveryLocation DeliveryLocation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DeliveryLocation get_DeliveryLocation() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_DeliveryLocation(DeliveryLocation value) { }

	// RVA: 0xAB3DB0 Offset: 0xAB27B0 VA: 0x180AB3DB0
	public void .ctor(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xAB3920 Offset: 0xAB2320 VA: 0x180AB3920
	public DialogueChain ProcessMessage(DialogueChain messageChain) { }
}
