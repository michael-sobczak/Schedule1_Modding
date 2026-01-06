public class Customer : NetworkBehaviour, ISaveable // TypeDefIndex: 1497
{
	// Fields
	public static Action<Customer> onCustomerUnlocked; // 0x0
	public static List<Customer> LockedCustomers; // 0x8
	public static List<Customer> UnlockedCustomers; // 0x10
	public const float AFFINITY_MAX_EFFECT = 0.3;
	public const float PROPERTY_MAX_EFFECT = 0.4;
	public const float QUALITY_MAX_EFFECT = 0.3;
	public const float DEAL_REJECTED_RELATIONSHIP_CHANGE = -0.5;
	public const int ATTACK_DEAL_COOLDOWN = 48;
	public const float RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL = 0.25;
	public const float CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE = -0.075;
	public bool DEBUG; // 0x118
	public const float APPROACH_MIN_ADDICTION = 0.33;
	public const float APPROACH_CHANCE_PER_DAY_MAX = 0.5;
	public const float APPROACH_MIN_COOLDOWN = 2160;
	public const float APPROACH_MAX_COOLDOWN = 4320;
	public const int DEAL_COOLDOWN = 600;
	public static string[] PlayerAcceptMessages; // 0x18
	public static string[] PlayerRejectMessages; // 0x20
	public const int DEAL_ATTENDANCE_TOLERANCE = 10;
	public const int MIN_TRAVEL_TIME = 15;
	public const int MAX_TRAVEL_TIME = 360;
	public const int OFFER_EXPIRY_TIME_MINS = 600;
	public const float MIN_ORDER_APPEAL = 0.05;
	public const float ADDICTION_DRAIN_PER_DAY = 0.0625;
	public const bool SAMPLE_REQUIRES_RECOMMENDATION = False;
	public const float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = 0.5;
	public const float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = 0.6;
	public const float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = 0.6;
	[SyncVar(Channel = 1)]
	[CompilerGenerated]
	public float <CurrentAddiction>k__BackingField; // 0x11C
	private ContractInfo offeredContractInfo; // 0x120
	[CompilerGenerated]
	private GameDateTime <OfferedContractTime>k__BackingField; // 0x128
	[CompilerGenerated]
	private Contract <CurrentContract>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <IsAwaitingDelivery>k__BackingField; // 0x138
	[CompilerGenerated]
	private int <TimeSinceLastDealCompleted>k__BackingField; // 0x13C
	[CompilerGenerated]
	private int <TimeSinceLastDealOffered>k__BackingField; // 0x140
	[CompilerGenerated]
	private int <TimeSincePlayerApproached>k__BackingField; // 0x144
	[CompilerGenerated]
	private int <TimeSinceInstantDealOffered>k__BackingField; // 0x148
	[CompilerGenerated]
	private int <OfferedDeals>k__BackingField; // 0x14C
	[CompilerGenerated]
	private int <CompletedDeliveries>k__BackingField; // 0x150
	[CompilerGenerated]
	[SyncVar]
	public bool <HasBeenRecommended>k__BackingField; // 0x154
	[CompilerGenerated]
	private NPC <NPC>k__BackingField; // 0x158
	[CompilerGenerated]
	private Dealer <AssignedDealer>k__BackingField; // 0x160
	public NPCSignal_WaitForDelivery DealSignal; // 0x168
	[Header("Settings")]
	public bool AvailableInDemo; // 0x170
	[SerializeField]
	protected CustomerData customerData; // 0x178
	public DeliveryLocation DefaultDeliveryLocation; // 0x180
	[Header("Events")]
	public UnityEvent onUnlocked; // 0x188
	public UnityEvent onDealCompleted; // 0x190
	public UnityEvent<Contract> onContractAssigned; // 0x198
	private bool awaitingSample; // 0x1A0
	private DialogueController.DialogueChoice sampleChoice; // 0x1A8
	private DialogueController.DialogueChoice completeContractChoice; // 0x1B0
	private DialogueController.DialogueChoice offerDealChoice; // 0x1B8
	private DialogueController.GreetingOverride awaitingDealGreeting; // 0x1C0
	private int minsSinceUnlocked; // 0x1C8
	private bool sampleOfferedToday; // 0x1CC
	[CompilerGenerated]
	private NPCPoI <potentialCustomerPoI>k__BackingField; // 0x1D0
	private CustomerAffinityData currentAffinityData; // 0x1D8
	private bool pendingInstantDeal; // 0x1E0
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x1F8
	private ProductItemInstance consumedSample; // 0x200
	public SyncVar<float> syncVar___<CurrentAddiction>k__BackingField; // 0x208
	public SyncVar<bool> syncVar___<HasBeenRecommended>k__BackingField; // 0x210
	private bool NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted; // 0x218
	private bool NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted; // 0x219

	// Properties
	public float CurrentAddiction { get; set; }
	public ContractInfo OfferedContractInfo { get; set; }
	public GameDateTime OfferedContractTime { get; set; }
	public Contract CurrentContract { get; set; }
	public bool IsAwaitingDelivery { get; set; }
	public int TimeSinceLastDealCompleted { get; set; }
	public int TimeSinceLastDealOffered { get; set; }
	public int TimeSincePlayerApproached { get; set; }
	public int TimeSinceInstantDealOffered { get; set; }
	public int OfferedDeals { get; set; }
	public int CompletedDeliveries { get; set; }
	public bool HasBeenRecommended { get; set; }
	public NPC NPC { get; set; }
	public Dealer AssignedDealer { get; set; }
	public CustomerData CustomerData { get; }
	private DialogueDatabase dialogueDatabase { get; }
	public NPCPoI potentialCustomerPoI { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public float SyncAccessor_<CurrentAddiction>k__BackingField { get; set; }
	public bool SyncAccessor_<HasBeenRecommended>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_CurrentAddiction() { }

	[CompilerGenerated]
	// RVA: 0x6BFDD0 Offset: 0x6BE7D0 VA: 0x1806BFDD0
	protected void set_CurrentAddiction(float value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public ContractInfo get_OfferedContractInfo() { }

	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	protected void set_OfferedContractInfo(ContractInfo value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public GameDateTime get_OfferedContractTime() { }

	[CompilerGenerated]
	// RVA: 0x6BFF50 Offset: 0x6BE950 VA: 0x1806BFF50
	protected void set_OfferedContractTime(GameDateTime value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public Contract get_CurrentContract() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	protected void set_CurrentContract(Contract value) { }

	[CompilerGenerated]
	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90
	public bool get_IsAwaitingDelivery() { }

	[CompilerGenerated]
	// RVA: 0x6BFF00 Offset: 0x6BE900 VA: 0x1806BFF00
	protected void set_IsAwaitingDelivery(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD80 Offset: 0x6BE780 VA: 0x1806BFD80
	public int get_TimeSinceLastDealCompleted() { }

	[CompilerGenerated]
	// RVA: 0x6BFF80 Offset: 0x6BE980 VA: 0x1806BFF80
	protected void set_TimeSinceLastDealCompleted(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD90 Offset: 0x6BE790 VA: 0x1806BFD90
	public int get_TimeSinceLastDealOffered() { }

	[CompilerGenerated]
	// RVA: 0x6BFF90 Offset: 0x6BE990 VA: 0x1806BFF90
	protected void set_TimeSinceLastDealOffered(int value) { }

	[CompilerGenerated]
	// RVA: 0x513060 Offset: 0x511A60 VA: 0x180513060
	public int get_TimeSincePlayerApproached() { }

	[CompilerGenerated]
	// RVA: 0x6BFFA0 Offset: 0x6BE9A0 VA: 0x1806BFFA0
	protected void set_TimeSincePlayerApproached(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD70 Offset: 0x6BE770 VA: 0x1806BFD70
	public int get_TimeSinceInstantDealOffered() { }

	[CompilerGenerated]
	// RVA: 0x6BFF70 Offset: 0x6BE970 VA: 0x1806BFF70
	protected void set_TimeSinceInstantDealOffered(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD00 Offset: 0x6BE700 VA: 0x1806BFD00
	public int get_OfferedDeals() { }

	[CompilerGenerated]
	// RVA: 0x6BFF60 Offset: 0x6BE960 VA: 0x1806BFF60
	protected void set_OfferedDeals(int value) { }

	[CompilerGenerated]
	// RVA: 0x653850 Offset: 0x652250 VA: 0x180653850
	public int get_CompletedDeliveries() { }

	[CompilerGenerated]
	// RVA: 0x653B00 Offset: 0x652500 VA: 0x180653B00
	protected void set_CompletedDeliveries(int value) { }

	[CompilerGenerated]
	// RVA: 0x513130 Offset: 0x511B30 VA: 0x180513130
	public bool get_HasBeenRecommended() { }

	[CompilerGenerated]
	// RVA: 0x6BFE60 Offset: 0x6BE860 VA: 0x1806BFE60
	protected void set_HasBeenRecommended(bool value) { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020
	public NPC get_NPC() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120
	protected void set_NPC(NPC value) { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600
	public Dealer get_AssignedDealer() { }

	[CompilerGenerated]
	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140
	protected void set_AssignedDealer(Dealer value) { }

	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public CustomerData get_CustomerData() { }

	// RVA: 0x6BFDA0 Offset: 0x6BE7A0 VA: 0x1806BFDA0
	private DialogueDatabase get_dialogueDatabase() { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public NPCPoI get_potentialCustomerPoI() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	private void set_potentialCustomerPoI(NPCPoI value) { }

	// RVA: 0x6BFD40 Offset: 0x6BE740 VA: 0x1806BFD40 Slot: 19
	public string get_SaveFolderName() { }

	// RVA: 0x6BFD10 Offset: 0x6BE710 VA: 0x1806BFD10 Slot: 20
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 21
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0 Slot: 23
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10 Slot: 24
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0 Slot: 25
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30 Slot: 26
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCD0 Offset: 0x6BE6D0 VA: 0x1806BFCD0 Slot: 27
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x6BFEF0 Offset: 0x6BE8F0 VA: 0x1806BFEF0 Slot: 28
	public void set_HasChanged(bool value) { }

	// RVA: 0x6AB180 Offset: 0x6A9B80 VA: 0x1806AB180 Slot: 42
	public override void Awake() { }

	// RVA: 0x6B2620 Offset: 0x6B1020 VA: 0x1806B2620 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x6BD630 Offset: 0x6BC030 VA: 0x1806BD630
	private void Start() { }

	// RVA: 0x6B2590 Offset: 0x6B0F90 VA: 0x1806B2590 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x6B23F0 Offset: 0x6B0DF0 VA: 0x1806B23F0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x6B1970 Offset: 0x6B0370 VA: 0x1806B1970
	private void OnDestroy() { }

	// RVA: 0x6BBFD0 Offset: 0x6BA9D0 VA: 0x1806BBFD0
	private void SetUpDialogue() { }

	// RVA: 0x6BC8F0 Offset: 0x6BB2F0 VA: 0x1806BC8F0
	private void SetupPoI() { }

	// RVA: 0x6AF580 Offset: 0x6ADF80 VA: 0x1806AF580 Slot: 43
	public virtual void InitializeSaveable() { }

	// RVA: 0x6B1CA0 Offset: 0x6B06A0 VA: 0x1806B1CA0 Slot: 44
	protected virtual void OnMinPass() { }

	// RVA: 0x6B25B0 Offset: 0x6B0FB0 VA: 0x1806B25B0 Slot: 45
	protected virtual void OnTick() { }

	// RVA: 0x6B0ED0 Offset: 0x6AF8D0 VA: 0x1806B0ED0
	private void OfferContractToDealer(ContractInfo info, Dealer dealer) { }

	// RVA: 0x6B1910 Offset: 0x6B0310 VA: 0x1806B1910 Slot: 46
	protected virtual void OnDayPass() { }

	// RVA: 0x6BEE70 Offset: 0x6BD870 VA: 0x1806BEE70
	private void UpdateDealAttendance() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x6AB310 Offset: 0x6A9D10 VA: 0x1806AB310
	private void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active) { }

	// RVA: 0x6BF590 Offset: 0x6BDF90 VA: 0x1806BF590
	private void UpdateOfferExpiry() { }

	// RVA: 0x6AD6F0 Offset: 0x6AC0F0 VA: 0x1806AD6F0
	public void ForceDealOffer() { }

	// RVA: 0x6AE340 Offset: 0x6ACD40 VA: 0x1806AE340
	private List<ProductDefinition> GetOrderableProducts(Dealer dealer) { }

	// RVA: 0x6BDCE0 Offset: 0x6BC6E0 VA: 0x1806BDCE0
	private ContractInfo TryGenerateContract(Dealer dealer) { }

	// RVA: 0x6AEF30 Offset: 0x6AD930 VA: 0x1806AEF30
	private ProductDefinition GetWeightedRandomProduct(Dealer dealer, out float appeal) { }

	// RVA: 0x6B1680 Offset: 0x6B0080 VA: 0x1806B1680 Slot: 47
	protected virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify) { }

	// RVA: 0x6BBCC0 Offset: 0x6BA6C0 VA: 0x1806BBCC0
	public void SetHasBeenRecommended() { }

	// RVA: 0x6B0FF0 Offset: 0x6AF9F0 VA: 0x1806B0FF0 Slot: 48
	public virtual void OfferContract(ContractInfo info) { }

	[ObserversRpc]
	// RVA: 0x6BA2C0 Offset: 0x6B8CC0 VA: 0x1806BA2C0
	private void SetOfferedContract(ContractInfo info, GameDateTime offerTime) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6AD5E0 Offset: 0x6ABFE0 VA: 0x1806AD5E0 Slot: 49
	public virtual void ExpireOffer() { }

	// RVA: 0x6AAC70 Offset: 0x6A9670 VA: 0x1806AAC70 Slot: 50
	public virtual void AssignContract(Contract contract) { }

	// RVA: 0x6B0B70 Offset: 0x6AF570 VA: 0x1806B0B70 Slot: 51
	protected virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = True) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6BBA80 Offset: 0x6BA480 VA: 0x1806BBA80
	private void SendSetUpResponseCallbacks() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6BC7D0 Offset: 0x6BB1D0 VA: 0x1806BC7D0
	private void SetUpResponseCallbacks() { }

	// RVA: 0x6AA9B0 Offset: 0x6A93B0 VA: 0x1806AA9B0 Slot: 52
	protected virtual void AcceptContractClicked() { }

	// RVA: 0x6ABEF0 Offset: 0x6AA8F0 VA: 0x1806ABEF0 Slot: 53
	protected virtual void CounterOfferClicked() { }

	// RVA: 0x6BB650 Offset: 0x6BA050 VA: 0x1806BB650 Slot: 54
	protected virtual void SendCounteroffer(ProductDefinition product, int quantity, float price) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6B3310 Offset: 0x6B1D10 VA: 0x1806B3310
	private void ProcessCounterOfferServerSide(string productID, int quantity, float price) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6BBB90 Offset: 0x6BA590 VA: 0x1806BBB90
	private void SetContractIsCounterOffer() { }

	// RVA: 0x6B2B20 Offset: 0x6B1520 VA: 0x1806B2B20 Slot: 55
	protected virtual void PlayerAcceptedContract(EDealWindow window) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6BA790 Offset: 0x6B9190 VA: 0x1806BA790
	private void SendContractAccepted(EDealWindow window, bool trackContract) { }

	// RVA: 0x6AB6F0 Offset: 0x6AA0F0 VA: 0x1806AB6F0
	public Contract ContractAccepted(EDealWindow window, bool trackContract, Dealer dealer) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6B4A90 Offset: 0x6B3490 VA: 0x1806B4A90
	private void ReceiveContractAccepted() { }

	// RVA: 0x6B2980 Offset: 0x6B1380 VA: 0x1806B2980 Slot: 56
	protected virtual void PlayContractAcceptedReaction() { }

	// RVA: 0x6AC9B0 Offset: 0x6AB3B0 VA: 0x1806AC9B0 Slot: 57
	protected virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price) { }

	// RVA: 0x6AEED0 Offset: 0x6AD8D0 VA: 0x1806AEED0
	public static float GetValueProposition(ProductDefinition product, float price) { }

	// RVA: 0x6ABA30 Offset: 0x6AA430 VA: 0x1806ABA30 Slot: 58
	protected virtual void ContractRejected() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6B4BD0 Offset: 0x6B35D0 VA: 0x1806B4BD0
	private void ReceiveContractRejected() { }

	// RVA: 0x6B2A50 Offset: 0x6B1450 VA: 0x1806B2A50 Slot: 59
	protected virtual void PlayContractRejectedReaction() { }

	// RVA: 0x6BBCE0 Offset: 0x6BA6E0 VA: 0x1806BBCE0 Slot: 60
	public virtual void SetIsAwaitingDelivery(bool awaiting) { }

	// RVA: 0x6AF900 Offset: 0x6AE300 VA: 0x1806AF900
	public bool IsAtDealLocation() { }

	// RVA: 0x6BF7E0 Offset: 0x6BE1E0 VA: 0x1806BF7E0
	private void UpdatePotentialCustomerPoI() { }

	// RVA: 0x6BBF40 Offset: 0x6BA940 VA: 0x1806BBF40
	public void SetPotentialCustomerPoIEnabled(bool enabled) { }

	// RVA: 0x6BCFF0 Offset: 0x6BB9F0 VA: 0x1806BCFF0 Slot: 61
	protected virtual bool ShouldTryGenerateDeal() { }

	// RVA: 0x6AFA80 Offset: 0x6AE480 VA: 0x1806AFA80
	private bool IsDealTime() { }

	// RVA: 0x6B1440 Offset: 0x6AFE40 VA: 0x1806B1440 Slot: 62
	public virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted) { }

	// RVA: 0x6AC240 Offset: 0x6AAC40 VA: 0x1806AC240 Slot: 63
	public virtual void CustomerRejectedDeal(bool offeredByPlayer) { }

	// RVA: 0x6B3790 Offset: 0x6B2190 VA: 0x1806B3790 Slot: 64
	public virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = True) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6B35F0 Offset: 0x6B1FF0 VA: 0x1806B35F0
	private void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject) { }

	[ObserversRpc]
	// RVA: 0x6B3480 Offset: 0x6B1E80 VA: 0x1806B3480
	private void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend) { }

	// RVA: 0x6ABC00 Offset: 0x6AA600 VA: 0x1806ABC00
	public void ContractWellReceived(string npcToRecommend) { }

	// RVA: 0x6B5400 Offset: 0x6B3E00 VA: 0x1806B5400
	private void RecommendDealer(Dealer dealer) { }

	// RVA: 0x6B5980 Offset: 0x6B4380 VA: 0x1806B5980
	private void RecommendSupplier(Supplier supplier) { }

	// RVA: 0x6B4E70 Offset: 0x6B3870 VA: 0x1806B4E70
	private void RecommendCustomer(Customer friend) { }

	// RVA: 0x6AC160 Offset: 0x6AAB60 VA: 0x1806AC160 Slot: 65
	public virtual void CurrentContractEnded(EQuestState outcome) { }

	// RVA: 0x6ACEC0 Offset: 0x6AB8C0 VA: 0x1806ACEC0 Slot: 66
	public virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount, out float qualityDifference) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6AB1D0 Offset: 0x6A9BD0 VA: 0x1806AB1D0
	public void ChangeAddiction(float change) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9FF0 VA: 0x1806AB5F0
	private void ConsumeProduct(ItemInstance item) { }

	// RVA: 0x6BD4B0 Offset: 0x6BBEB0 VA: 0x1806BD4B0 Slot: 67
	protected virtual bool ShowOfferDealOption(bool enabled) { }

	// RVA: 0x6B1590 Offset: 0x6AFF90 VA: 0x1806B1590 Slot: 68
	protected virtual bool OfferDealValid(out string invalidReason) { }

	// RVA: 0x6AF610 Offset: 0x6AE010 VA: 0x1806AF610 Slot: 69
	protected virtual void InstantDealOffered() { }

	// RVA: 0x6ADAC0 Offset: 0x6AC4C0 VA: 0x1806ADAC0
	public float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice) { }

	// RVA: 0x6BCC50 Offset: 0x6BB650 VA: 0x1806BCC50 Slot: 70
	protected virtual bool ShouldTryApproachPlayer() { }

	[Button]
	// RVA: 0x6B6070 Offset: 0x6B4A70 VA: 0x1806B6070
	public void RequestProduct() { }

	// RVA: 0x6B60D0 Offset: 0x6B4AD0 VA: 0x1806B60D0
	public void RequestProduct(Player target) { }

	// RVA: 0x6B3000 Offset: 0x6B1A00 VA: 0x1806B3000
	public void PlayerRejectedProductRequest() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6B5F60 Offset: 0x6B4960 VA: 0x1806B5F60
	public void RejectProductRequestOffer() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6B5E40 Offset: 0x6B4840 VA: 0x1806B5E40
	private void RejectProductRequestOffer_Local() { }

	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140
	public void AssignDealer(Dealer dealer) { }

	// RVA: 0x6AEE90 Offset: 0x6AD890 VA: 0x1806AEE90 Slot: 71
	public virtual string GetSaveString() { }

	// RVA: 0x6AD850 Offset: 0x6AC250 VA: 0x1806AD850
	public CustomerData GetCustomerData() { }

	// RVA: 0x6BF8A0 Offset: 0x6BE2A0 VA: 0x1806BF8A0 Slot: 72
	public virtual List<string> WriteData(string parentFolderPath) { }

	[TargetRpc]
	// RVA: 0x6B4D10 Offset: 0x6B3710 VA: 0x1806B4D10
	private void ReceiveCustomerData(NetworkConnection conn, CustomerData data) { }

	// RVA: 0x6B0060 Offset: 0x6AEA60 VA: 0x1806B0060 Slot: 73
	public virtual void Load(CustomerData data) { }

	// RVA: 0x6AFE40 Offset: 0x6AE840 VA: 0x1806AFE40 Slot: 74
	protected virtual bool IsReadyForHandover(bool enabled) { }

	// RVA: 0x6AFCE0 Offset: 0x6AE6E0 VA: 0x1806AFCE0 Slot: 75
	protected virtual bool IsHandoverChoiceValid(out string invalidReason) { }

	// RVA: 0x6AF440 Offset: 0x6ADE40 VA: 0x1806AF440
	public void HandoverChosen() { }

	// RVA: 0x6BD380 Offset: 0x6BBD80 VA: 0x1806BD380 Slot: 76
	protected virtual bool ShowDirectApproachOption(bool enabled) { }

	// RVA: 0x6AFF30 Offset: 0x6AE930 VA: 0x1806AFF30 Slot: 77
	public virtual bool IsUnlockable() { }

	// RVA: 0x6BB440 Offset: 0x6B9E40 VA: 0x1806BB440 Slot: 78
	protected virtual bool SampleOptionValid(out string invalidReason) { }

	// RVA: 0x6AFF80 Offset: 0x6AE980 VA: 0x1806AFF80
	public bool KnownAndRecommended() { }

	// RVA: 0x6BB3B0 Offset: 0x6B9DB0 VA: 0x1806BB3B0
	public void SampleOffered() { }

	// RVA: 0x6AE930 Offset: 0x6AD330 VA: 0x1806AE930 Slot: 79
	protected virtual float GetSampleRequestSuccessChance() { }

	// RVA: 0x6BAB70 Offset: 0x6B9570 VA: 0x1806BAB70 Slot: 80
	protected virtual void SampleAccepted() { }

	// RVA: 0x6AEA80 Offset: 0x6AD480 VA: 0x1806AEA80
	private float GetSampleSuccess(List<ItemInstance> items, float price) { }

	// RVA: 0x6B46D0 Offset: 0x6B30D0 VA: 0x1806B46D0
	private void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6B45A0 Offset: 0x6B2FA0 VA: 0x1806B45A0
	private void ProcessSampleServerSide(List<ItemInstance> items) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6B4480 Offset: 0x6B2E80 VA: 0x1806B4480
	private void ProcessSampleClient() { }

	// RVA: 0x6BAD10 Offset: 0x6B9710 VA: 0x1806BAD10
	private void SampleConsumed() { }

	// RVA: 0x6AC890 Offset: 0x6AB290 VA: 0x1806AC890
	private void EndWait() { }

	// RVA: 0x6AC660 Offset: 0x6AB060 VA: 0x1806AC660 Slot: 81
	protected virtual void DirectApproachRejected() { }

	[ObserversRpc]
	// RVA: 0x6BA080 Offset: 0x6B8A80 VA: 0x1806BA080
	private void SampleWasSufficient() { }

	[ObserversRpc]
	// RVA: 0x6B9F60 Offset: 0x6B8960 VA: 0x1806B9F60
	private void SampleWasInsufficient() { }

	// RVA: 0x6AE5D0 Offset: 0x6ACFD0 VA: 0x1806AE5D0
	public float GetProductEnjoyment(ProductDefinition product, EQuality quality) { }

	// RVA: 0x6AE3F0 Offset: 0x6ACDF0 VA: 0x1806AE3F0
	public List<EDrugType> GetOrderedDrugTypes() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6AAB10 Offset: 0x6A9510 VA: 0x1806AAB10
	public void AdjustAffinity(EDrugType drugType, float change) { }

	[Button]
	// RVA: 0x6AAD90 Offset: 0x6A9790 VA: 0x1806AAD90
	public void AutocreateCustomerSettings() { }

	// RVA: 0x6BFBD0 Offset: 0x6BE5D0 VA: 0x1806BFBD0
	public void .ctor() { }

	// RVA: 0x6BF900 Offset: 0x6BE300 VA: 0x1806BF900
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6BE5D0 Offset: 0x6BCFD0 VA: 0x1806BE5D0
	private void <Awake>b__132_0() { }

	[CompilerGenerated]
	// RVA: 0x6BEC70 Offset: 0x6BD670 VA: 0x1806BEC70
	private void <Start>b__134_1(NPCRelationData.EUnlockType <p0>, bool <p1>) { }

	[CompilerGenerated]
	// RVA: 0x6BEC80 Offset: 0x6BD680 VA: 0x1806BEC80
	private void <Start>g__RegisterLoadEvent|134_0() { }

	[CompilerGenerated]
	// RVA: 0x6BE710 Offset: 0x6BD110 VA: 0x1806BE710
	private void <InstantDealOffered>g__HandoverClosed|197_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice) { }

	[CompilerGenerated]
	// RVA: 0x6BE6C0 Offset: 0x6BD0C0 VA: 0x1806BE6C0
	private void <HandoverChosen>b__213_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price) { }

	[CompilerGenerated]
	// RVA: 0x6BE5E0 Offset: 0x6BCFE0 VA: 0x1806BE5E0
	private float <GetOrderedDrugTypes>b__231_0(EDrugType x) { }

	// RVA: 0x6B0370 Offset: 0x6AED70 VA: 0x1806B0370 Slot: 82
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6B0300 Offset: 0x6AED00 VA: 0x1806B0300 Slot: 83
	public override void NetworkInitialize__Late() { }

	// RVA: 0x6B02C0 Offset: 0x6AECC0 VA: 0x1806B02C0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6B9970 Offset: 0x6B8370 VA: 0x1806B9970
	private void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active) { }

	// RVA: 0x6B6380 Offset: 0x6B4D80 VA: 0x1806B6380
	private void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active) { }

	// RVA: 0x6B8CF0 Offset: 0x6B76F0 VA: 0x1806B8CF0
	private void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BAA00 Offset: 0x6B9400 VA: 0x1806BAA00
	private void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active) { }

	// RVA: 0x6B9820 Offset: 0x6B8220 VA: 0x1806B9820
	private void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BA2C0 Offset: 0x6B8CC0 VA: 0x1806BA2C0
	private void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime) { }

	// RVA: 0x6B88C0 Offset: 0x6B72C0 VA: 0x1806B88C0
	private void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime) { }

	// RVA: 0x6B91A0 Offset: 0x6B7BA0 VA: 0x1806B91A0
	private void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BA550 Offset: 0x6B8F50 VA: 0x1806BA550
	private void RpcWriter___Server_ExpireOffer_2166136261() { }

	// RVA: 0x6B63F0 Offset: 0x6B4DF0 VA: 0x1806B63F0 Slot: 84
	public virtual void RpcLogic___ExpireOffer_2166136261() { }

	// RVA: 0x6B9460 Offset: 0x6B7E60 VA: 0x1806B9460
	private void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6BA8F0 Offset: 0x6B92F0 VA: 0x1806BA8F0
	private void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261() { }

	// RVA: 0x6B8890 Offset: 0x6B7290 VA: 0x1806B8890
	private void RpcLogic___SendSetUpResponseCallbacks_2166136261() { }

	// RVA: 0x6B97D0 Offset: 0x6B81D0 VA: 0x1806B97D0
	private void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6BA430 Offset: 0x6B8E30 VA: 0x1806BA430
	private void RpcWriter___Observers_SetUpResponseCallbacks_2166136261() { }

	// RVA: 0x6B8900 Offset: 0x6B7300 VA: 0x1806B8900
	private void RpcLogic___SetUpResponseCallbacks_2166136261() { }

	// RVA: 0x6B9220 Offset: 0x6B7C20 VA: 0x1806B9220
	private void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6B3310 Offset: 0x6B1D10 VA: 0x1806B3310
	private void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price) { }

	// RVA: 0x6B64F0 Offset: 0x6B4EF0 VA: 0x1806B64F0
	private void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price) { }

	// RVA: 0x6B94B0 Offset: 0x6B7EB0 VA: 0x1806B94B0
	private void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6BA1A0 Offset: 0x6B8BA0 VA: 0x1806BA1A0
	private void RpcWriter___Observers_SetContractIsCounterOffer_2166136261() { }

	// RVA: 0x6B88A0 Offset: 0x6B72A0 VA: 0x1806B88A0
	private void RpcLogic___SetContractIsCounterOffer_2166136261() { }

	// RVA: 0x6B9160 Offset: 0x6B7B60 VA: 0x1806B9160
	private void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BA790 Offset: 0x6B9190 VA: 0x1806BA790
	private void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract) { }

	// RVA: 0x6B8870 Offset: 0x6B7270 VA: 0x1806B8870
	private void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract) { }

	// RVA: 0x6B9730 Offset: 0x6B8130 VA: 0x1806B9730
	private void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6B9C00 Offset: 0x6B8600 VA: 0x1806B9C00
	private void RpcWriter___Observers_ReceiveContractAccepted_2166136261() { }

	// RVA: 0x6B8010 Offset: 0x6B6A10 VA: 0x1806B8010
	private void RpcLogic___ReceiveContractAccepted_2166136261() { }

	// RVA: 0x6B8F00 Offset: 0x6B7900 VA: 0x1806B8F00
	private void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6B9D20 Offset: 0x6B8720 VA: 0x1806B9D20
	private void RpcWriter___Observers_ReceiveContractRejected_2166136261() { }

	// RVA: 0x6B8010 Offset: 0x6B6A10 VA: 0x1806B8010
	private void RpcLogic___ReceiveContractRejected_2166136261() { }

	// RVA: 0x6B8F00 Offset: 0x6B7900 VA: 0x1806B8F00
	private void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6B35F0 Offset: 0x6B1FF0 VA: 0x1806B35F0
	private void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject) { }

	// RVA: 0x6B6BD0 Offset: 0x6B55D0 VA: 0x1806B6BD0
	private void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject) { }

	// RVA: 0x6B9550 Offset: 0x6B7F50 VA: 0x1806B9550
	private void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6B3480 Offset: 0x6B1E80 VA: 0x1806B3480
	private void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend) { }

	// RVA: 0x6B6B40 Offset: 0x6B5540 VA: 0x1806B6B40
	private void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend) { }

	// RVA: 0x6B8DB0 Offset: 0x6B77B0 VA: 0x1806B8DB0
	private void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6AB1D0 Offset: 0x6A9BD0 VA: 0x1806AB1D0
	private void RpcWriter___Server_ChangeAddiction_431000436(float change) { }

	// RVA: 0x6B6320 Offset: 0x6B4D20 VA: 0x1806B6320
	public void RpcLogic___ChangeAddiction_431000436(float change) { }

	// RVA: 0x6B93D0 Offset: 0x6B7DD0 VA: 0x1806B93D0
	private void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6B5F60 Offset: 0x6B4960 VA: 0x1806B5F60
	private void RpcWriter___Server_RejectProductRequestOffer_2166136261() { }

	// RVA: 0x6B8050 Offset: 0x6B6A50 VA: 0x1806B8050
	public void RpcLogic___RejectProductRequestOffer_2166136261() { }

	// RVA: 0x6B9700 Offset: 0x6B8100 VA: 0x1806B9700
	private void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6B9E40 Offset: 0x6B8840 VA: 0x1806B9E40
	private void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261() { }

	// RVA: 0x6B8360 Offset: 0x6B6D60 VA: 0x1806B8360
	private void RpcLogic___RejectProductRequestOffer_Local_2166136261() { }

	// RVA: 0x6B8F50 Offset: 0x6B7950 VA: 0x1806B8F50
	private void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6B4D10 Offset: 0x6B3710 VA: 0x1806B4D10
	private void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data) { }

	// RVA: 0x6B8030 Offset: 0x6B6A30 VA: 0x1806B8030
	private void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data) { }

	// RVA: 0x6B9910 Offset: 0x6B8310 VA: 0x1806B9910
	private void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BA660 Offset: 0x6B9060 VA: 0x1806BA660
	private void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items) { }

	// RVA: 0x6B7D30 Offset: 0x6B6730 VA: 0x1806B7D30
	private void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items) { }

	// RVA: 0x6B9690 Offset: 0x6B8090 VA: 0x1806B9690
	private void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6B9AE0 Offset: 0x6B84E0 VA: 0x1806B9AE0
	private void RpcWriter___Observers_ProcessSampleClient_2166136261() { }

	// RVA: 0x6B7C00 Offset: 0x6B6600 VA: 0x1806B7C00
	private void RpcLogic___ProcessSampleClient_2166136261() { }

	// RVA: 0x6B8EC0 Offset: 0x6B78C0 VA: 0x1806B8EC0
	private void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6BA080 Offset: 0x6B8A80 VA: 0x1806BA080
	private void RpcWriter___Observers_SampleWasSufficient_2166136261() { }

	// RVA: 0x6B86E0 Offset: 0x6B70E0 VA: 0x1806B86E0
	private void RpcLogic___SampleWasSufficient_2166136261() { }

	// RVA: 0x6B8FC0 Offset: 0x6B79C0 VA: 0x1806B8FC0
	private void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6B9F60 Offset: 0x6B8960 VA: 0x1806B9F60
	private void RpcWriter___Observers_SampleWasInsufficient_2166136261() { }

	// RVA: 0x6B8490 Offset: 0x6B6E90 VA: 0x1806B8490
	private void RpcLogic___SampleWasInsufficient_2166136261() { }

	// RVA: 0x6B8F90 Offset: 0x6B7990 VA: 0x1806B8F90
	private void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6AAB10 Offset: 0x6A9510 VA: 0x1806AAB10
	private void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change) { }

	// RVA: 0x6B61F0 Offset: 0x6B4BF0 VA: 0x1806B61F0
	public void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change) { }

	// RVA: 0x6B9260 Offset: 0x6B7C60 VA: 0x1806B9260
	private void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float sync___get_value_<CurrentAddiction>k__BackingField() { }

	// RVA: 0x6BFFB0 Offset: 0x6BE9B0 VA: 0x1806BFFB0
	public void sync___set_value_<CurrentAddiction>k__BackingField(float value, bool asServer) { }

	// RVA: 0x6B48F0 Offset: 0x6B32F0 VA: 0x1806B48F0 Slot: 85
	public override bool ReadSyncVar___ScheduleOne.Economy.Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x513130 Offset: 0x511B30 VA: 0x180513130
	public bool sync___get_value_<HasBeenRecommended>k__BackingField() { }

	// RVA: 0x6C0070 Offset: 0x6BEA70 VA: 0x1806C0070
	public void sync___set_value_<HasBeenRecommended>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x6AAE30 Offset: 0x6A9830 VA: 0x1806AAE30 Slot: 86
	protected virtual void Awake_UserLogic_ScheduleOne.Economy.Customer_Assembly-CSharp.dll() { }
}
