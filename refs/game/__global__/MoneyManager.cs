public class MoneyManager : NetworkSingleton<MoneyManager>, IBaseSaveable, ISaveable // TypeDefIndex: 3196
{
	// Fields
	public const string MONEY_TEXT_COLOR = "#54E717";
	public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";
	public const string ONLINE_BALANCE_COLOR = "#4CBFFF";
	public List<Transaction> ledger; // 0x120
	[SyncVar(WritePermissions = 1)]
	public float onlineBalance; // 0x128
	[SyncVar(WritePermissions = 1)]
	public float lifetimeEarnings; // 0x12C
	[CompilerGenerated]
	private float <LastCalculatedNetworth>k__BackingField; // 0x130
	[SerializeField]
	protected AudioSourceController CashSound; // 0x138
	[Header("Prefabs")]
	[SerializeField]
	protected GameObject moneyChangePrefab; // 0x140
	[SerializeField]
	protected GameObject cashChangePrefab; // 0x148
	public Sprite LaunderingNotificationIcon; // 0x150
	public Action<MoneyManager.FloatContainer> onNetworthCalculation; // 0x158
	private MoneyLoader loader; // 0x160
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x168
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x170
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x178
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x17C
	public SyncVar<float> syncVar___onlineBalance; // 0x180
	public SyncVar<float> syncVar___lifetimeEarnings; // 0x188
	private bool NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted; // 0x190
	private bool NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted; // 0x191

	// Properties
	public float LifetimeEarnings { get; }
	public float LastCalculatedNetworth { get; set; }
	public float cashBalance { get; }
	protected CashInstance cashInstance { get; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }
	public float SyncAccessor_onlineBalance { get; set; }
	public float SyncAccessor_lifetimeEarnings { get; set; }

	// Methods

	// RVA: 0x9D0880 Offset: 0x9CF280 VA: 0x1809D0880
	public static string ApplyMoneyTextColor(string text) { }

	// RVA: 0x9D0830 Offset: 0x9CF230 VA: 0x1809D0830
	public static string ApplyMoneyTextColorDarker(string text) { }

	// RVA: 0x9D08D0 Offset: 0x9CF2D0 VA: 0x1809D08D0
	public static string ApplyOnlineBalanceColor(string text) { }

	// RVA: 0x513080 Offset: 0x511A80 VA: 0x180513080
	public float get_LifetimeEarnings() { }

	[CompilerGenerated]
	// RVA: 0x718AA0 Offset: 0x7174A0 VA: 0x180718AA0
	public float get_LastCalculatedNetworth() { }

	[CompilerGenerated]
	// RVA: 0x718C30 Offset: 0x717630 VA: 0x180718C30
	protected void set_LastCalculatedNetworth(float value) { }

	// RVA: 0x9D3BA0 Offset: 0x9D25A0 VA: 0x1809D3BA0
	public float get_cashBalance() { }

	// RVA: 0x9D3BC0 Offset: 0x9D25C0 VA: 0x1809D3BC0
	protected CashInstance get_cashInstance() { }

	// RVA: 0x9D3B70 Offset: 0x9D2570 VA: 0x1809D3B70 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x9D3B40 Offset: 0x9D2540 VA: 0x1809D3B40 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x73B390 Offset: 0x739D90 VA: 0x18073B390 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x73B510 Offset: 0x739F10 VA: 0x18073B510 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x77BCD0 Offset: 0x77A6D0 VA: 0x18077BCD0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x9D0970 Offset: 0x9CF370 VA: 0x1809D0970 Slot: 20
	public override void Awake() { }

	// RVA: 0x9D17F0 Offset: 0x9D01F0 VA: 0x1809D17F0 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x9D36A0 Offset: 0x9D20A0 VA: 0x1809D36A0 Slot: 19
	protected override void Start() { }

	// RVA: 0x9D2480 Offset: 0x9D0E80 VA: 0x1809D2480 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x9D23E0 Offset: 0x9D0DE0 VA: 0x1809D23E0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x9D20D0 Offset: 0x9D0AD0 VA: 0x1809D20D0 Slot: 21
	protected override void OnDestroy() { }

	// RVA: 0x9D1AB0 Offset: 0x9D04B0 VA: 0x1809D1AB0
	private void Loaded() { }

	// RVA: 0x9D39E0 Offset: 0x9D23E0 VA: 0x1809D39E0
	private void Update() { }

	// RVA: 0x9D1B50 Offset: 0x9D0550 VA: 0x1809D1B50
	private void MinPass() { }

	// RVA: 0x9D14D0 Offset: 0x9CFED0 VA: 0x1809D14D0
	public CashInstance GetCashInstance(float amount) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9D10C0 Offset: 0x9CFAC0 VA: 0x1809D10C0
	public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	[ObserversRpc]
	// RVA: 0x9D2790 Offset: 0x9D1190 VA: 0x1809D2790
	private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	[IteratorStateMachine(typeof(MoneyManager.<ShowOnlineBalanceChange>d__61))]
	// RVA: 0x9D3630 Offset: 0x9D2030 VA: 0x1809D3630
	protected IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9D0E10 Offset: 0x9CF810 VA: 0x1809D0E10
	public void ChangeLifetimeEarnings(float change) { }

	// RVA: 0x9D2560 Offset: 0x9D0F60 VA: 0x1809D2560
	public void PlayCashSound() { }

	// RVA: 0x9D09F0 Offset: 0x9CF3F0 VA: 0x1809D09F0
	public void ChangeCashBalance(float change, bool visualizeChange = True, bool playCashSound = False) { }

	[IteratorStateMachine(typeof(MoneyManager.<ShowCashChange>d__65))]
	// RVA: 0x9D35C0 Offset: 0x9D1FC0 VA: 0x1809D35C0
	protected IEnumerator ShowCashChange(RectTransform changeDisplay) { }

	// RVA: 0x9D1270 Offset: 0x9CFC70 VA: 0x1809D1270
	public static string FormatAmount(float amount, bool showDecimals = False, bool includeColor = False) { }

	// RVA: 0x9D1660 Offset: 0x9D0060 VA: 0x1809D1660 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x9D1880 Offset: 0x9D0280 VA: 0x1809D1880
	public void Load(MoneyData data) { }

	// RVA: 0x9D0F50 Offset: 0x9CF950 VA: 0x1809D0F50
	public void CheckNetworthAchievements() { }

	// RVA: 0x9D15B0 Offset: 0x9CFFB0 VA: 0x1809D15B0
	public float GetNetWorth() { }

	// RVA: 0x9D39F0 Offset: 0x9D23F0 VA: 0x1809D39F0
	public void .ctor() { }

	// RVA: 0x9D1DD0 Offset: 0x9D07D0 VA: 0x1809D1DD0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9D1D30 Offset: 0x9D0730 VA: 0x1809D1D30 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9D3450 Offset: 0x9D1E50 VA: 0x1809D3450
	private void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	// RVA: 0x9D2790 Offset: 0x9D1190 VA: 0x1809D2790
	public void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	// RVA: 0x9D3380 Offset: 0x9D1D80 VA: 0x1809D3380
	private void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9D2790 Offset: 0x9D1190 VA: 0x1809D2790
	private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	// RVA: 0x9D2A80 Offset: 0x9D1480 VA: 0x1809D2A80
	private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }

	// RVA: 0x9D3130 Offset: 0x9D1B30 VA: 0x1809D3130
	private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9D0E10 Offset: 0x9CF810 VA: 0x1809D0E10
	private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change) { }

	// RVA: 0x9D2920 Offset: 0x9D1320 VA: 0x1809D2920
	public void RpcLogic___ChangeLifetimeEarnings_431000436(float change) { }

	// RVA: 0x9D31F0 Offset: 0x9D1BF0 VA: 0x1809D31F0
	private void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x512C10 Offset: 0x511610 VA: 0x180512C10
	public float sync___get_value_onlineBalance() { }

	// RVA: 0x9D3D00 Offset: 0x9D2700 VA: 0x1809D3D00
	public void sync___set_value_onlineBalance(float value, bool asServer) { }

	// RVA: 0x9D2610 Offset: 0x9D1010 VA: 0x1809D2610 Slot: 51
	public override bool ReadSyncVar___ScheduleOne.Money.MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x513080 Offset: 0x511A80 VA: 0x180513080
	public float sync___get_value_lifetimeEarnings() { }

	// RVA: 0x9D3C40 Offset: 0x9D2640 VA: 0x1809D3C40
	public void sync___set_value_lifetimeEarnings(float value, bool asServer) { }

	// RVA: 0x9D0920 Offset: 0x9CF320 VA: 0x1809D0920 Slot: 52
	protected override void Awake_UserLogic_ScheduleOne.Money.MoneyManager_Assembly-CSharp.dll() { }
}
