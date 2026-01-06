public class ATM : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable // TypeDefIndex: 3191
{
	// Fields
	public const bool DepositLimitEnabled = True;
	public const float WEEKLY_DEPOSIT_LIMIT = 10000;
	public const float IMPACT_THRESHOLD_BREAK = 165;
	public const int REPAIR_TIME_DAYS = 0;
	public const int MIN_CASH_DROP = 2;
	public const int MAX_CASH_DROP = 8;
	public static float WeeklyDepositSum; // 0x0
	[CompilerGenerated]
	private bool <IsBroken>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <DaysUntilRepair>k__BackingField; // 0x11C
	public CashPickup CashPrefab; // 0x120
	[SerializeField]
	[Header("References")]
	protected InteractableObject intObj; // 0x128
	[SerializeField]
	protected Transform camPos; // 0x130
	[SerializeField]
	protected ATMInterface interfaceATM; // 0x138
	public Transform AccessPoint; // 0x140
	public Transform CashSpawnPoint; // 0x148
	public PhysicsDamageable Damageable; // 0x150
	[Header("Settings")]
	public static float viewLerpTime; // 0x4
	[CompilerGenerated]
	private bool <isInUse>k__BackingField; // 0x158
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x15C
	[SerializeField]
	protected string BakedGUID; // 0x170
	public UnityEvent onBreak; // 0x178
	public UnityEvent onRepair; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public bool IsBroken { get; set; }
	public int DaysUntilRepair { get; set; }
	public bool isInUse { get; set; }
	public Guid GUID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsBroken() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	protected void set_IsBroken(bool value) { }

	[CompilerGenerated]
	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public int get_DaysUntilRepair() { }

	[CompilerGenerated]
	// RVA: 0x9C2380 Offset: 0x9C0D80 VA: 0x1809C2380
	protected void set_DaysUntilRepair(int value) { }

	[CompilerGenerated]
	// RVA: 0x5995F0 Offset: 0x597FF0 VA: 0x1805995F0
	public bool get_isInUse() { }

	[CompilerGenerated]
	// RVA: 0x9C23A0 Offset: 0x9C0DA0 VA: 0x1809C23A0
	protected void set_isInUse(bool value) { }

	[CompilerGenerated]
	// RVA: 0x9C2370 Offset: 0x9C0D70 VA: 0x1809C2370 Slot: 22
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x9C2390 Offset: 0x9C0D90 VA: 0x1809C2390
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x9C14B0 Offset: 0x9BFEB0 VA: 0x1809C14B0
	public void RegenerateGUID() { }

	// RVA: 0x9C01A0 Offset: 0x9BEBA0 VA: 0x1809C01A0 Slot: 26
	public override void Awake() { }

	// RVA: 0x9C1F70 Offset: 0x9C0970 VA: 0x1809C1F70 Slot: 27
	protected virtual void Start() { }

	// RVA: 0x9C1470 Offset: 0x9BFE70 VA: 0x1809C1470 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x9C1F00 Offset: 0x9C0900 VA: 0x1809C1F00 Slot: 21
	public void SetGUID(Guid guid) { }

	// RVA: 0x9C05A0 Offset: 0x9BEFA0 VA: 0x1809C05A0
	public void DayPass() { }

	// RVA: 0x9C2260 Offset: 0x9C0C60 VA: 0x1809C2260
	public void WeekPass() { }

	// RVA: 0x9C0E30 Offset: 0x9BF830 VA: 0x1809C0E30
	public void Hovered() { }

	// RVA: 0x9C11B0 Offset: 0x9BFBB0 VA: 0x1809C11B0
	public void Interacted() { }

	// RVA: 0x9C0800 Offset: 0x9BF200 VA: 0x1809C0800
	public void Enter() { }

	// RVA: 0x9C0B10 Offset: 0x9BF510 VA: 0x1809C0B10
	public void Exit() { }

	// RVA: 0x9C0EC0 Offset: 0x9BF8C0 VA: 0x1809C0EC0
	private void Impacted(Impact impact) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9C1DE0 Offset: 0x9C07E0 VA: 0x1809C1DE0
	private void SendBreak() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x9C0330 Offset: 0x9BED30 VA: 0x1809C0330
	private void Break(NetworkConnection conn) { }

	[ObserversRpc]
	// RVA: 0x9C1500 Offset: 0x9BFF00 VA: 0x1809C1500
	private void Repair() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9C06F0 Offset: 0x9BF0F0 VA: 0x1809C06F0
	private void DropCash() { }

	// RVA: 0x9C11D0 Offset: 0x9BFBD0 VA: 0x1809C11D0 Slot: 24
	public void Load(GenericSaveData data) { }

	// RVA: 0x9C0D60 Offset: 0x9BF760 VA: 0x1809C0D60 Slot: 25
	public GenericSaveData GetSaveData() { }

	// RVA: 0x9C2310 Offset: 0x9C0D10 VA: 0x1809C2310
	public void .ctor() { }

	// RVA: 0x9C22C0 Offset: 0x9C0CC0 VA: 0x1809C22C0
	private static void .cctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(ATM.<<Impacted>g__BreakRoutine|45_0>d))]
	// RVA: 0x9C21F0 Offset: 0x9C0BF0 VA: 0x1809C21F0
	private IEnumerator <Impacted>g__BreakRoutine|45_0() { }

	// RVA: 0x9C12C0 Offset: 0x9BFCC0 VA: 0x1809C12C0 Slot: 28
	public override void NetworkInitialize___Early() { }

	// RVA: 0x66D210 Offset: 0x66BC10 VA: 0x18066D210 Slot: 29
	public override void NetworkInitialize__Late() { }

	// RVA: 0x9C1280 Offset: 0x9BFC80 VA: 0x1809C1280 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9C1BA0 Offset: 0x9C05A0 VA: 0x1809C1BA0
	private void RpcWriter___Server_SendBreak_2166136261() { }

	// RVA: 0x9C18E0 Offset: 0x9C02E0 VA: 0x1809C18E0
	private void RpcLogic___SendBreak_2166136261() { }

	// RVA: 0x9C19D0 Offset: 0x9C03D0 VA: 0x1809C19D0
	private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C1A80 Offset: 0x9C0480 VA: 0x1809C1A80
	private void RpcWriter___Observers_Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9C1620 Offset: 0x9C0020 VA: 0x1809C1620
	private void RpcLogic___Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9C1900 Offset: 0x9C0300 VA: 0x1809C1900
	private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C1CB0 Offset: 0x9C06B0 VA: 0x1809C1CB0
	private void RpcWriter___Target_Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9C1A30 Offset: 0x9C0430 VA: 0x1809C1A30
	private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C1500 Offset: 0x9BFF00 VA: 0x1809C1500
	private void RpcWriter___Observers_Repair_2166136261() { }

	// RVA: 0x9C18B0 Offset: 0x9C02B0 VA: 0x1809C18B0
	private void RpcLogic___Repair_2166136261() { }

	// RVA: 0x9C1950 Offset: 0x9C0350 VA: 0x1809C1950
	private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C06F0 Offset: 0x9BF0F0 VA: 0x1809C06F0
	private void RpcWriter___Server_DropCash_2166136261() { }

	// RVA: 0x9C1650 Offset: 0x9C0050 VA: 0x1809C1650
	private void RpcLogic___DropCash_2166136261() { }

	// RVA: 0x9C19A0 Offset: 0x9C03A0 VA: 0x1809C19A0
	private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C0040 Offset: 0x9BEA40 VA: 0x1809C0040
	private void Awake_UserLogic_ScheduleOne.Money.ATM_Assembly-CSharp.dll() { }
}
