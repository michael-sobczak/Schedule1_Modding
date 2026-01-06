public class DealGenerationEvent // TypeDefIndex: 1513
{
	// Fields
	[Header("Settings")]
	public bool Enabled; // 0x10
	public bool CanBeAccepted; // 0x11
	public bool CanBeRejected; // 0x12
	[Header("Timing Settings")]
	public List<DealGenerationEvent.DayContainer> ApplicableDays; // 0x18
	public int GenerationTime; // 0x20
	public int GenerationWindowDuration; // 0x24
	[Header("Products and payment")]
	public ProductList ProductList; // 0x28
	public float Payment; // 0x30
	[Range(0, 5)]
	public float RelationshipRequirement; // 0x34
	[Header("Messages")]
	[SerializeField]
	private MessageChain[] RequestMessageChains; // 0x38
	public MessageChain[] ContractAcceptedResponses; // 0x40
	public MessageChain[] ContractRejectedResponses; // 0x48
	[Header("Location settings")]
	public DeliveryLocation DeliveryLocation; // 0x50
	public int PickupScheduleGroup; // 0x58
	[Header("Window/expiry settings")]
	public QuestWindowConfig DeliveryWindow; // 0x60
	public bool Expires; // 0x68
	[Range(1, 7)]
	[Tooltip("How many days after being accepted does this contract expire? Exact expiry is adjusted to match window end")]
	public int ExpiresAfter; // 0x6C

	// Methods

	// RVA: 0x6D1930 Offset: 0x6D0330 VA: 0x1806D1930
	public ContractInfo GenerateContractInfo(Customer customer) { }

	// RVA: 0x6D1FB0 Offset: 0x6D09B0 VA: 0x1806D1FB0
	public bool ShouldGenerate(Customer customer) { }

	// RVA: 0x6D1AE0 Offset: 0x6D04E0 VA: 0x1806D1AE0
	public MessageChain GetRandomRequestMessage() { }

	// RVA: 0x6D1BA0 Offset: 0x6D05A0 VA: 0x1806D1BA0
	public MessageChain ProcessMessage(MessageChain messageChain) { }

	// RVA: 0x6D1B40 Offset: 0x6D0540 VA: 0x1806D1B40
	public MessageChain GetRejectionMessage() { }

	// RVA: 0x6D1A40 Offset: 0x6D0440 VA: 0x1806D1A40
	public MessageChain GetAcceptanceMessage() { }

	// RVA: 0x6D1AA0 Offset: 0x6D04A0 VA: 0x1806D1AA0
	public string GetProductStringList() { }

	// RVA: 0x6D1AC0 Offset: 0x6D04C0 VA: 0x1806D1AC0
	public string GetQualityString() { }

	// RVA: 0x6D2160 Offset: 0x6D0B60 VA: 0x1806D2160
	public void .ctor() { }
}
