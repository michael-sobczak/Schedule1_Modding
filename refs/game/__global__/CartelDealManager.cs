public class CartelDealManager : NetworkBehaviour // TypeDefIndex: 2084
{
	// Fields
	public const int DEAL_DUE_TIME_DAYS = 3;
	public const float PAYMENT_MULTIPLIER = 0.65;
	public const int DEAL_COOLDOWN_HOURS = 24;
	[CompilerGenerated]
	private CartelDealInfo <ActiveDeal>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <HoursUntilNextDealRequest>k__BackingField; // 0x120
	[Header("References")]
	public NPC RequestingNPC; // 0x128
	public Quest_DealForCartel DealQuest; // 0x130
	public WorldStorageEntity DeliveryEntity; // 0x138
	public Transform CashSpawnPoint; // 0x140
	public Quest MethRequestPrereqQuest; // 0x148
	public Supplier CokeRequestPrereqSupplier; // 0x150
	[Header("Settings")]
	public CashPickup CashPrefab; // 0x158
	public ProductDefinition[] RequestableWeed; // 0x160
	public ProductDefinition MethDefinition; // 0x168
	public ProductDefinition CocaineDefinition; // 0x170
	public int ProductQuantityMin; // 0x178
	public int ProductQuantityMax; // 0x17C
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public CartelDealInfo ActiveDeal { get; set; }
	public int HoursUntilNextDealRequest { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public CartelDealInfo get_ActiveDeal() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_ActiveDeal(CartelDealInfo value) { }

	[CompilerGenerated]
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public int get_HoursUntilNextDealRequest() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	private void set_HoursUntilNextDealRequest(int value) { }

	// RVA: 0x800720 Offset: 0x7FF120 VA: 0x180800720 Slot: 19
	public override void Awake() { }

	// RVA: 0x8026D0 Offset: 0x8010D0 VA: 0x1808026D0
	private void Start() { }

	// RVA: 0x801710 Offset: 0x800110 VA: 0x180801710 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x801550 Offset: 0x7FFF50 VA: 0x180801550
	private void MinPass() { }

	// RVA: 0x801770 Offset: 0x800170 VA: 0x180801770
	private void OnTimeSkip(int mins) { }

	// RVA: 0x801080 Offset: 0x7FFA80 VA: 0x180801080
	private void HourPass() { }

	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	public void SetHoursUntilDealRequest(int hours) { }

	// RVA: 0x801FD0 Offset: 0x8009D0 VA: 0x180801FD0
	private void SleepEnd() { }

	// RVA: 0x801480 Offset: 0x7FFE80 VA: 0x180801480
	private void MarkDealOverdue() { }

	// RVA: 0x800F00 Offset: 0x7FF900 VA: 0x180800F00
	private void ExpireDeal() { }

	// RVA: 0x8007D0 Offset: 0x7FF1D0 VA: 0x1808007D0
	private void CheckDealCompletion() { }

	// RVA: 0x800A10 Offset: 0x7FF410 VA: 0x180800A10
	private void CompleteDeal() { }

	// RVA: 0x800E10 Offset: 0x7FF810 VA: 0x180800E10
	private void DepositCash(float amount) { }

	[Button]
	// RVA: 0x8021A0 Offset: 0x800BA0 VA: 0x1808021A0
	private void StartDeal() { }

	// RVA: 0x8013B0 Offset: 0x7FFDB0 VA: 0x1808013B0
	public void LoadDeal(CartelDealInfo dealInfo) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x801130 Offset: 0x7FFB30 VA: 0x180801130
	private void InitializeDealQuest(NetworkConnection conn, CartelDealInfo dealInfo) { }

	// RVA: 0x801D60 Offset: 0x800760 VA: 0x180801D60
	private void SendRequestMessage(CartelDealInfo dealInfo) { }

	// RVA: 0x801CB0 Offset: 0x8006B0 VA: 0x180801CB0
	private void SendOverdueMessage() { }

	// RVA: 0x801C00 Offset: 0x800600 VA: 0x180801C00
	private void SendExpiryMessage() { }

	// RVA: 0x8013C0 Offset: 0x7FFDC0 VA: 0x1808013C0
	public void Load(CartelData data) { }

	// RVA: 0x800770 Offset: 0x7FF170 VA: 0x180800770
	private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus) { }

	// RVA: 0x802C00 Offset: 0x801600 VA: 0x180802C00
	public void .ctor() { }

	// RVA: 0x801640 Offset: 0x800040 VA: 0x180801640 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x801620 Offset: 0x800020 VA: 0x180801620 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x801960 Offset: 0x800360 VA: 0x180801960
	private void RpcWriter___Observers_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo) { }

	// RVA: 0x801800 Offset: 0x800200 VA: 0x180801800
	private void RpcLogic___InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo) { }

	// RVA: 0x801860 Offset: 0x800260 VA: 0x180801860
	private void RpcReader___Observers_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x801AA0 Offset: 0x8004A0 VA: 0x180801AA0
	private void RpcWriter___Target_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo) { }

	// RVA: 0x8018E0 Offset: 0x8002E0 VA: 0x1808018E0
	private void RpcReader___Target_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x800710 Offset: 0x7FF110 VA: 0x180800710
	private void Awake_UserLogic_ScheduleOne.Cartel.CartelDealManager_Assembly-CSharp.dll() { }
}
