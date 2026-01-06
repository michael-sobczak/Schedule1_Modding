public class Dealer : NPC, IItemSlotOwner // TypeDefIndex: 1510
{
	// Fields
	public const int MAX_CUSTOMERS = 8;
	public const int DEAL_ARRIVAL_DELAY = 30;
	public const int MIN_TRAVEL_TIME = 15;
	public const int MAX_TRAVEL_TIME = 360;
	public const int OVERFLOW_SLOT_COUNT = 10;
	public const float CASH_REMINDER_THRESHOLD = 500;
	public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05;
	public static Color32 DealerLabelColor; // 0x0
	public static Action<Dealer> onDealerRecruited; // 0x8
	public static List<Dealer> AllPlayerDealers; // 0x10
	[CompilerGenerated]
	private bool <IsRecruited>k__BackingField; // 0x2F0
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x2F8
	[CompilerGenerated]
	private NPCPoI <PotentialDealerPoI>k__BackingField; // 0x300
	[CompilerGenerated]
	private NPCPoI <DealerPoI>k__BackingField; // 0x308
	[CompilerGenerated]
	[SyncVar(OnChange = "UpdateCollectCashChoice")]
	public float <Cash>k__BackingField; // 0x310
	[CompilerGenerated]
	private List<Customer> <AssignedCustomers>k__BackingField; // 0x318
	[CompilerGenerated]
	private List<Contract> <ActiveContracts>k__BackingField; // 0x320
	[CompilerGenerated]
	private bool <HasBeenRecommended>k__BackingField; // 0x328
	public Action onContractAccepted; // 0x330
	[Header("Dealer References")]
	public NPCEnterableBuilding Home; // 0x338
	public NPCEvent_StayInBuilding HomeEvent; // 0x340
	public DialogueController_Dealer DialogueController; // 0x348
	[Header("Dialogue stuff")]
	public DialogueContainer RecruitDialogue; // 0x350
	public DialogueContainer CollectCashDialogue; // 0x358
	public DialogueContainer AssignCustomersDialogue; // 0x360
	[Header("Dealer Settings")]
	public EDealerType DealerType; // 0x368
	public string HomeName; // 0x370
	public float SigningFee; // 0x378
	public float Cut; // 0x37C
	public bool SellInsufficientQualityItems; // 0x380
	public bool SellExcessQualityItems; // 0x381
	[Header("Variables")]
	public string CompletedDealsVariable; // 0x388
	[Header("UnityEvents")]
	public UnityEvent onRecommended; // 0x390
	public UnityEvent onCompleteDeal; // 0x398
	[Header("Seasonal Events")]
	public AvatarSettings ChristmasOutfit; // 0x3A0
	private ItemSlot[] overflowSlots; // 0x3A8
	private Contract currentContract; // 0x3B0
	private DialogueController.DialogueChoice recruitChoice; // 0x3B8
	private DialogueController.DialogueChoice collectCashChoice; // 0x3C0
	private DialogueController.DialogueChoice assignCustomersChoice; // 0x3C8
	private int itemCountOnTradeStart; // 0x3D0
	private DealerAttendDealBehaviour _attendDealBehaviour; // 0x3D8
	public SyncVar<float> syncVar___<Cash>k__BackingField; // 0x3E0
	private bool NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted; // 0x3E8
	private bool NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted; // 0x3E9

	// Properties
	public bool IsRecruited { get; set; }
	public List<ItemSlot> ItemSlots { get; set; }
	public NPCPoI PotentialDealerPoI { get; set; }
	public NPCPoI DealerPoI { get; set; }
	public float Cash { get; set; }
	public List<Customer> AssignedCustomers { get; set; }
	public List<Contract> ActiveContracts { get; set; }
	public bool HasBeenRecommended { get; set; }
	public float SyncAccessor_<Cash>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6DFA70 Offset: 0x6DE470 VA: 0x1806DFA70
	public bool get_IsRecruited() { }

	[CompilerGenerated]
	// RVA: 0x6DFB90 Offset: 0x6DE590 VA: 0x1806DFB90
	private void set_IsRecruited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260 Slot: 111
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x6C87A0 Offset: 0x6C71A0 VA: 0x1806C87A0 Slot: 112
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA80 Offset: 0x6DE480 VA: 0x1806DFA80
	public NPCPoI get_PotentialDealerPoI() { }

	[CompilerGenerated]
	// RVA: 0x6DFBA0 Offset: 0x6DE5A0 VA: 0x1806DFBA0
	private void set_PotentialDealerPoI(NPCPoI value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA50 Offset: 0x6DE450 VA: 0x1806DFA50
	public NPCPoI get_DealerPoI() { }

	[CompilerGenerated]
	// RVA: 0x6DFB60 Offset: 0x6DE560 VA: 0x1806DFB60
	private void set_DealerPoI(NPCPoI value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA40 Offset: 0x6DE440 VA: 0x1806DFA40
	public float get_Cash() { }

	[CompilerGenerated]
	// RVA: 0x6DFAD0 Offset: 0x6DE4D0 VA: 0x1806DFAD0
	private void set_Cash(float value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30
	public List<Customer> get_AssignedCustomers() { }

	[CompilerGenerated]
	// RVA: 0x6DFAB0 Offset: 0x6DE4B0 VA: 0x1806DFAB0
	private void set_AssignedCustomers(List<Customer> value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA20 Offset: 0x6DE420 VA: 0x1806DFA20
	public List<Contract> get_ActiveContracts() { }

	[CompilerGenerated]
	// RVA: 0x6DFA90 Offset: 0x6DE490 VA: 0x1806DFA90
	private void set_ActiveContracts(List<Contract> value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA60 Offset: 0x6DE460 VA: 0x1806DFA60
	public bool get_HasBeenRecommended() { }

	[CompilerGenerated]
	// RVA: 0x6DFB80 Offset: 0x6DE580 VA: 0x1806DFB80
	private void set_HasBeenRecommended(bool value) { }

	// RVA: 0x6D2F90 Offset: 0x6D1990 VA: 0x1806D2F90 Slot: 65
	public override void Awake() { }

	// RVA: 0x6D7570 Offset: 0x6D5F70 VA: 0x1806D7570 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x6D71C0 Offset: 0x6D5BC0 VA: 0x1806D71C0 Slot: 72
	protected override void OnDestroy() { }

	// RVA: 0x6DDFA0 Offset: 0x6DC9A0 VA: 0x1806DDFA0 Slot: 71
	protected override void Start() { }

	// RVA: 0x6D7250 Offset: 0x6D5C50 VA: 0x1806D7250 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x6DD580 Offset: 0x6DBF80 VA: 0x1806DD580
	private void SetupPoI() { }

	// RVA: 0x6DD340 Offset: 0x6DBD40 VA: 0x1806DD340
	private void SetUpDialogue() { }

	// RVA: 0x6D73E0 Offset: 0x6D5DE0 VA: 0x1806D73E0 Slot: 74
	protected override void OnTick() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6D6720 Offset: 0x6D5120 VA: 0x1806D6720
	public void MarkAsRecommended() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6D7EE0 Offset: 0x6D68E0 VA: 0x1806D7EE0
	private void SetRecommended() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6D5C00 Offset: 0x6D4600 VA: 0x1806D5C00
	public void InitialRecruitment() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6DC000 Offset: 0x6DAA00 VA: 0x1806DC000 Slot: 122
	public virtual void SetIsRecruited(NetworkConnection conn) { }

	// RVA: 0x6D70C0 Offset: 0x6D5AC0 VA: 0x1806D70C0 Slot: 123
	protected virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b) { }

	// RVA: 0x6DF6C0 Offset: 0x6DE0C0 VA: 0x1806DF6C0 Slot: 124
	protected virtual void UpdatePotentialDealerPoI() { }

	// RVA: 0x6D3A40 Offset: 0x6D2440 VA: 0x1806D3A40
	private void DealerUnconscious() { }

	// RVA: 0x6DE360 Offset: 0x6DCD60 VA: 0x1806DE360
	private void TradeItems() { }

	// RVA: 0x6DE1C0 Offset: 0x6DCBC0 VA: 0x1806DE1C0
	private void TradeItemsDone() { }

	// RVA: 0x6D2FE0 Offset: 0x6D19E0 VA: 0x1806D2FE0
	private bool CanCollectCash(out string reason) { }

	// RVA: 0x6DF630 Offset: 0x6DE030 VA: 0x1806DF630
	private void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer) { }

	// RVA: 0x6D3580 Offset: 0x6D1F80 VA: 0x1806D3580
	private void CollectCash() { }

	// RVA: 0x6D3510 Offset: 0x6D1F10 VA: 0x1806D3510
	private void CheckCurrentDealValidity() { }

	// RVA: 0x6D3040 Offset: 0x6D1A40 VA: 0x1806D3040
	private bool CanOfferRecruitment(out string reason) { }

	// RVA: 0x6D3150 Offset: 0x6D1B50 VA: 0x1806D3150
	private void CheckAttendStart() { }

	// RVA: 0x6DDA80 Offset: 0x6DC480 VA: 0x1806DDA80 Slot: 125
	public virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer) { }

	// RVA: 0x6D3740 Offset: 0x6D2140 VA: 0x1806D3740 Slot: 126
	public virtual void ContractedOffered(ContractInfo contractInfo, Customer customer) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6DBDA0 Offset: 0x6DA7A0 VA: 0x1806DBDA0
	public void SendAddCustomer(string npcID) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6D27C0 Offset: 0x6D11C0 VA: 0x1806D27C0
	private void AddCustomer(NetworkConnection conn, string npcID) { }

	// RVA: 0x6D26D0 Offset: 0x6D10D0 VA: 0x1806D26D0 Slot: 127
	protected virtual void AddCustomer(Customer customer) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6DBED0 Offset: 0x6DA8D0 VA: 0x1806DBED0
	public void SendRemoveCustomer(string npcID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6D7A90 Offset: 0x6D6490 VA: 0x1806D7A90
	private void RemoveCustomer(string npcID) { }

	// RVA: 0x6D79F0 Offset: 0x6D63F0 VA: 0x1806D79F0 Slot: 128
	public virtual void RemoveCustomer(Customer customer) { }

	// RVA: 0x6D3140 Offset: 0x6D1B40 VA: 0x1806D3140
	public void ChangeCash(float change) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6DAE30 Offset: 0x6D9830 VA: 0x1806DAE30
	public void SetCash(float cash) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6D3630 Offset: 0x6D2030 VA: 0x1806D3630 Slot: 129
	public virtual void CompletedDeal() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6DB560 Offset: 0x6D9F60 VA: 0x1806DB560
	public void SubmitPayment(float payment) { }

	// RVA: 0x6DE660 Offset: 0x6DD060 VA: 0x1806DE660
	public void TryRobDealer() { }

	// RVA: 0x6D5300 Offset: 0x6D3D00 VA: 0x1806D5300
	public List<ProductDefinition> GetOrderableProducts() { }

	// RVA: 0x6D58D0 Offset: 0x6D42D0 VA: 0x1806D58D0
	public int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality) { }

	// RVA: 0x6D3D50 Offset: 0x6D2750 VA: 0x1806D3D50
	private EDealWindow GetDealWindow() { }

	// RVA: 0x6D3BC0 Offset: 0x6D25C0 VA: 0x1806D3BC0
	private int GetContractCountInWindow(EDealWindow window) { }

	// RVA: 0x6D24E0 Offset: 0x6D0EE0 VA: 0x1806D24E0
	private void AddContract(Contract contract) { }

	// RVA: 0x6D38E0 Offset: 0x6D22E0 VA: 0x1806D38E0
	private void CustomerContractEnded(Contract contract) { }

	// RVA: 0x6DDE50 Offset: 0x6DC850 VA: 0x1806DDE50
	private void SortContracts() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 130
	protected virtual void RecruitmentRequested() { }

	// RVA: 0x6D7710 Offset: 0x6D6110 VA: 0x1806D7710
	public bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items) { }

	// RVA: 0x6D4180 Offset: 0x6D2B80 VA: 0x1806D4180
	private List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity) { }

	// RVA: 0x6D3B10 Offset: 0x6D2510 VA: 0x1806D3B10
	public List<ItemSlot> GetAllSlots() { }

	// RVA: 0x6D2A20 Offset: 0x6D1420 VA: 0x1806D2A20
	public void AddItemToInventory(ItemInstance item) { }

	// RVA: 0x6DE540 Offset: 0x6DCF40 VA: 0x1806DE540
	public void TryMoveOverflowItems() { }

	// RVA: 0x6D5AD0 Offset: 0x6D44D0 VA: 0x1806D5AD0
	public int GetTotalInventoryItemCount() { }

	// RVA: 0x6D56C0 Offset: 0x6D40C0 VA: 0x1806D56C0
	public int GetPackagedProductAmount() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x6DD1A0 Offset: 0x6DBBA0 VA: 0x1806DD1A0 Slot: 113
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x6DCEE0 Offset: 0x6DB8E0 VA: 0x1806DCEE0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x6DC400 Offset: 0x6DAE00 VA: 0x1806DC400 Slot: 114
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6DC250 Offset: 0x6DAC50 VA: 0x1806DC250
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x6DCCF0 Offset: 0x6DB6F0 VA: 0x1806DCCF0 Slot: 115
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6DC9D0 Offset: 0x6DB3D0 VA: 0x1806DC9D0
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x6DC830 Offset: 0x6DB230 VA: 0x1806DC830 Slot: 116
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x6DC570 Offset: 0x6DAF70 VA: 0x1806DC570
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D5010 Offset: 0x6D3A10 VA: 0x1806D5010 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x6D5D20 Offset: 0x6D4720 VA: 0x1806D5D20 Slot: 101
	public override void Load(DynamicSaveData dynamicData, NPCData npcData) { }

	// RVA: 0x6D61B0 Offset: 0x6D4BB0 VA: 0x1806D61B0 Slot: 100
	public override void Load(NPCData data, string containerPath) { }

	// RVA: 0x6DF820 Offset: 0x6DE220 VA: 0x1806DF820
	public void .ctor() { }

	// RVA: 0x6DF770 Offset: 0x6DE170 VA: 0x1806DF770
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6D7EC0 Offset: 0x6D68C0 VA: 0x1806D7EC0
	private void <Awake>b__66_0(NPCRelationData.EUnlockType <p0>, bool <p1>) { }

	[CompilerGenerated]
	// RVA: 0x6DF040 Offset: 0x6DDA40 VA: 0x1806DF040
	private void <TryRobDealer>g__SummariseLosses|101_0(List<ItemInstance> items, float cash) { }

	// RVA: 0x6D6890 Offset: 0x6D5290 VA: 0x1806D6890 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6D6830 Offset: 0x6D5230 VA: 0x1806D6830 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6DAAC0 Offset: 0x6D94C0 VA: 0x1806DAAC0
	private void RpcWriter___Server_MarkAsRecommended_2166136261() { }

	// RVA: 0x6D7EE0 Offset: 0x6D68E0 VA: 0x1806D7EE0
	public void RpcLogic___MarkAsRecommended_2166136261() { }

	// RVA: 0x6D93C0 Offset: 0x6D7DC0 VA: 0x1806D93C0
	private void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA3F0 Offset: 0x6D8DF0 VA: 0x1806DA3F0
	private void RpcWriter___Observers_SetRecommended_2166136261() { }

	// RVA: 0x6D8850 Offset: 0x6D7250 VA: 0x1806D8850
	private void RpcLogic___SetRecommended_2166136261() { }

	// RVA: 0x6D8F90 Offset: 0x6D7990 VA: 0x1806D8F90
	private void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DA9B0 Offset: 0x6D93B0 VA: 0x1806DA9B0
	private void RpcWriter___Server_InitialRecruitment_2166136261() { }

	// RVA: 0x6D7EC0 Offset: 0x6D68C0 VA: 0x1806D7EC0
	public void RpcLogic___InitialRecruitment_2166136261() { }

	// RVA: 0x6D9360 Offset: 0x6D7D60 VA: 0x1806D9360
	private void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA150 Offset: 0x6D8B50 VA: 0x1806DA150
	private void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn) { }

	// RVA: 0x6D82B0 Offset: 0x6D6CB0 VA: 0x1806D82B0 Slot: 131
	public virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn) { }

	// RVA: 0x6D8EB0 Offset: 0x6D78B0 VA: 0x1806D8EB0
	private void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DB800 Offset: 0x6DA200 VA: 0x1806DB800
	private void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn) { }

	// RVA: 0x6D9C80 Offset: 0x6D8680 VA: 0x1806D9C80
	private void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DABD0 Offset: 0x6D95D0 VA: 0x1806DABD0
	private void RpcWriter___Server_SendAddCustomer_3615296227(string npcID) { }

	// RVA: 0x6D81C0 Offset: 0x6D6BC0 VA: 0x1806D81C0
	public void RpcLogic___SendAddCustomer_3615296227(string npcID) { }

	// RVA: 0x6D9410 Offset: 0x6D7E10 VA: 0x1806D9410
	private void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6D9ED0 Offset: 0x6D88D0 VA: 0x1806D9ED0
	private void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID) { }

	// RVA: 0x6D7BD0 Offset: 0x6D65D0 VA: 0x1806D7BD0
	private void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID) { }

	// RVA: 0x6D8DF0 Offset: 0x6D77F0 VA: 0x1806D8DF0
	private void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DB6A0 Offset: 0x6DA0A0 VA: 0x1806DB6A0
	private void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID) { }

	// RVA: 0x6D9C20 Offset: 0x6D8620 VA: 0x1806D9C20
	private void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DAD00 Offset: 0x6D9700 VA: 0x1806DAD00
	private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID) { }

	// RVA: 0x6D7A90 Offset: 0x6D6490 VA: 0x1806D7A90
	public void RpcLogic___SendRemoveCustomer_3615296227(string npcID) { }

	// RVA: 0x6D9490 Offset: 0x6D7E90 VA: 0x1806D9490
	private void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA010 Offset: 0x6D8A10 VA: 0x1806DA010
	private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID) { }

	// RVA: 0x6D8020 Offset: 0x6D6A20 VA: 0x1806D8020
	private void RpcLogic___RemoveCustomer_3615296227(string npcID) { }

	// RVA: 0x6D8E50 Offset: 0x6D7850 VA: 0x1806D8E50
	private void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DAE30 Offset: 0x6D9830 VA: 0x1806DAE30
	private void RpcWriter___Server_SetCash_431000436(float cash) { }

	// RVA: 0x6D81D0 Offset: 0x6D6BD0 VA: 0x1806D81D0
	public void RpcLogic___SetCash_431000436(float cash) { }

	// RVA: 0x6D9500 Offset: 0x6D7F00 VA: 0x1806D9500
	private void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6D3630 Offset: 0x6D2030 VA: 0x1806D3630
	private void RpcWriter___Server_CompletedDeal_2166136261() { }

	// RVA: 0x6D7D70 Offset: 0x6D6770 VA: 0x1806D7D70 Slot: 132
	public virtual void RpcLogic___CompletedDeal_2166136261() { }

	// RVA: 0x6D9200 Offset: 0x6D7C00 VA: 0x1806D9200
	private void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DB560 Offset: 0x6D9F60 VA: 0x1806DB560
	private void RpcWriter___Server_SubmitPayment_431000436(float payment) { }

	// RVA: 0x6D8BF0 Offset: 0x6D75F0 VA: 0x1806D8BF0
	public void RpcLogic___SubmitPayment_431000436(float payment) { }

	// RVA: 0x6D99F0 Offset: 0x6D83F0 VA: 0x1806D99F0
	private void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DB3F0 Offset: 0x6D9DF0 VA: 0x1806DB3F0
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x6D8AB0 Offset: 0x6D74B0 VA: 0x1806D8AB0 Slot: 133
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x6D9900 Offset: 0x6D8300 VA: 0x1806D9900
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA830 Offset: 0x6D9230 VA: 0x1806DA830
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x6D8B30 Offset: 0x6D7530 VA: 0x1806D8B30
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x6D9170 Offset: 0x6D7B70 VA: 0x1806D9170
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DBC30 Offset: 0x6DA630 VA: 0x1806DBC30
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x6D9E40 Offset: 0x6D8840 VA: 0x1806D9E40
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DAF70 Offset: 0x6D9970 VA: 0x1806DAF70
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x6D87C0 Offset: 0x6D71C0 VA: 0x1806D87C0 Slot: 134
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x6D9610 Offset: 0x6D8010 VA: 0x1806D9610
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA270 Offset: 0x6D8C70 VA: 0x1806DA270
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x6D87D0 Offset: 0x6D71D0 VA: 0x1806D87D0
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x6D8EF0 Offset: 0x6D78F0 VA: 0x1806D8EF0
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DB260 Offset: 0x6D9C60 VA: 0x1806DB260
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x6D8980 Offset: 0x6D7380 VA: 0x1806D8980 Slot: 135
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x6D97B0 Offset: 0x6D81B0 VA: 0x1806D97B0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DBAA0 Offset: 0x6DA4A0 VA: 0x1806DBAA0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x6D8A00 Offset: 0x6D7400 VA: 0x1806D8A00
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x6D9D50 Offset: 0x6D8750 VA: 0x1806D9D50
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DA690 Offset: 0x6D9090 VA: 0x1806DA690
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x6D9080 Offset: 0x6D7A80 VA: 0x1806D9080
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DB0F0 Offset: 0x6D9AF0 VA: 0x1806DB0F0
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D8880 Offset: 0x6D7280 VA: 0x1806D8880 Slot: 136
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D96C0 Offset: 0x6D80C0 VA: 0x1806D96C0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6DA510 Offset: 0x6D8F10 VA: 0x1806DA510
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D8900 Offset: 0x6D7300 VA: 0x1806D8900
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D8FF0 Offset: 0x6D79F0 VA: 0x1806D8FF0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DB930 Offset: 0x6DA330 VA: 0x1806DB930
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x6D9CC0 Offset: 0x6D86C0 VA: 0x1806D9CC0
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DFA40 Offset: 0x6DE440 VA: 0x1806DFA40
	public float sync___get_value_<Cash>k__BackingField() { }

	// RVA: 0x6DFBC0 Offset: 0x6DE5C0 VA: 0x1806DFBC0
	public void sync___set_value_<Cash>k__BackingField(float value, bool asServer) { }

	// RVA: 0x6D75C0 Offset: 0x6D5FC0 VA: 0x1806D75C0 Slot: 137
	public override bool ReadSyncVar___ScheduleOne.Economy.Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6D2BC0 Offset: 0x6D15C0 VA: 0x1806D2BC0 Slot: 138
	protected override void Awake_UserLogic_ScheduleOne.Economy.Dealer_Assembly-CSharp.dll() { }
}
