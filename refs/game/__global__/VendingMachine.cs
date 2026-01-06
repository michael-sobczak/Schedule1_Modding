public class VendingMachine : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable // TypeDefIndex: 3207
{
	// Fields
	public static List<VendingMachine> AllMachines; // 0x0
	public const float COST = 2;
	public const int REPAIR_TIME_DAYS = 0;
	public const float IMPACT_THRESHOLD_FREE_ITEM = 50;
	public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33;
	public const float IMPACT_THRESHOLD_BREAK = 165;
	public const int MIN_CASH_DROP = 1;
	public const int MAX_CASH_DROP = 4;
	[CompilerGenerated]
	private bool <IsBroken>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <DaysUntilRepair>k__BackingField; // 0x11C
	[Header("Settings")]
	public int LitStartTime; // 0x120
	public int LitOnEndTime; // 0x124
	public NetworkedItemPickup CukePrefab; // 0x128
	public CashPickup CashPrefab; // 0x130
	[Header("References")]
	public MeshRenderer DoorMesh; // 0x138
	public MeshRenderer BodyMesh; // 0x140
	public Material DoorOffMat; // 0x148
	public Material DoorOnMat; // 0x150
	public Material BodyOffMat; // 0x158
	public Material BodyOnMat; // 0x160
	public OptimizedLight[] Lights; // 0x168
	public AudioSourceController PaySound; // 0x170
	public AudioSourceController DispenseSound; // 0x178
	public Animation Anim; // 0x180
	public Transform ItemSpawnPoint; // 0x188
	public InteractableObject IntObj; // 0x190
	public Transform AccessPoint; // 0x198
	public PhysicsDamageable Damageable; // 0x1A0
	public Transform CashSpawnPoint; // 0x1A8
	public UnityEvent onBreak; // 0x1B0
	public UnityEvent onRepair; // 0x1B8
	[CompilerGenerated]
	private NetworkedItemPickup <lastDroppedItem>k__BackingField; // 0x1C0
	private bool isLit; // 0x1C8
	private bool purchaseInProgress; // 0x1C9
	private float timeOnLastFreeItem; // 0x1CC
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x1D0
	[SerializeField]
	protected string BakedGUID; // 0x1E0
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted; // 0x1E8
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted; // 0x1E9

	// Properties
	public bool IsBroken { get; set; }
	public int DaysUntilRepair { get; set; }
	public NetworkedItemPickup lastDroppedItem { get; set; }
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
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public NetworkedItemPickup get_lastDroppedItem() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_lastDroppedItem(NetworkedItemPickup value) { }

	[CompilerGenerated]
	// RVA: 0x9DDE80 Offset: 0x9DC880 VA: 0x1809DDE80 Slot: 22
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x9DDE90 Offset: 0x9DC890 VA: 0x1809DDE90
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x9DC380 Offset: 0x9DAD80 VA: 0x1809DC380
	public void RegenerateGUID() { }

	// RVA: 0x9DAE30 Offset: 0x9D9830 VA: 0x1809DAE30 Slot: 26
	public override void Awake() { }

	// RVA: 0x9DDA10 Offset: 0x9DC410 VA: 0x1809DDA10
	private void Start() { }

	// RVA: 0x9DC220 Offset: 0x9DAC20 VA: 0x1809DC220 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x9DD700 Offset: 0x9DC100 VA: 0x1809DD700 Slot: 21
	public void SetGUID(Guid guid) { }

	// RVA: 0x9DC000 Offset: 0x9DAA00 VA: 0x1809DC000
	private void OnDestroy() { }

	// RVA: 0x9DBC80 Offset: 0x9DA680 VA: 0x1809DBC80
	private void MinPass() { }

	// RVA: 0x9DB100 Offset: 0x9D9B00 VA: 0x1809DB100
	public void DayPass() { }

	// RVA: 0x9DB530 Offset: 0x9D9F30 VA: 0x1809DB530
	public void Hovered() { }

	// RVA: 0x9DB9C0 Offset: 0x9DA3C0 VA: 0x1809DB9C0
	public void Interacted() { }

	// RVA: 0x9DBAF0 Offset: 0x9DA4F0 VA: 0x1809DBAF0
	private void LocalPurchase() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9DD5F0 Offset: 0x9DBFF0 VA: 0x1809DD5F0
	public void SendPurchase() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9DC260 Offset: 0x9DAC60 VA: 0x1809DC260
	public void PurchaseRoutine() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9DB350 Offset: 0x9D9D50 VA: 0x1809DB350
	public void DropItem() { }

	// RVA: 0x9DC3D0 Offset: 0x9DADD0 VA: 0x1809DC3D0
	public void RemoveLastDropped() { }

	// RVA: 0x9DB650 Offset: 0x9DA050 VA: 0x1809DB650
	private void Impacted(Impact impact) { }

	// RVA: 0x9DD770 Offset: 0x9DC170 VA: 0x1809DD770
	private void SetLit(bool lit) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9DD4D0 Offset: 0x9DBED0 VA: 0x1809DD4D0
	private void SendBreak() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9DAE80 Offset: 0x9D9880 VA: 0x1809DAE80
	private void Break(NetworkConnection conn) { }

	[ObserversRpc]
	// RVA: 0x9DC4A0 Offset: 0x9DAEA0 VA: 0x1809DC4A0
	private void Repair() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9DB240 Offset: 0x9D9C40 VA: 0x1809DB240
	private void DropCash() { }

	// RVA: 0x9DBA40 Offset: 0x9DA440 VA: 0x1809DBA40 Slot: 24
	public void Load(GenericSaveData data) { }

	// RVA: 0x9DB460 Offset: 0x9D9E60 VA: 0x1809DB460 Slot: 25
	public GenericSaveData GetSaveData() { }

	// RVA: 0x9DDE10 Offset: 0x9DC810 VA: 0x1809DDE10
	public void .ctor() { }

	// RVA: 0x9DDD80 Offset: 0x9DC780 VA: 0x1809DDD80
	private static void .cctor() { }

	[IteratorStateMachine(typeof(VendingMachine.<<PurchaseRoutine>g__Routine|61_0>d))]
	[CompilerGenerated]
	// RVA: 0x9DDD10 Offset: 0x9DC710 VA: 0x1809DDD10
	private IEnumerator <PurchaseRoutine>g__Routine|61_0() { }

	[IteratorStateMachine(typeof(VendingMachine.<<Impacted>g__BreakRoutine|64_0>d))]
	[CompilerGenerated]
	// RVA: 0x9DDC30 Offset: 0x9DC630 VA: 0x1809DDC30
	private IEnumerator <Impacted>g__BreakRoutine|64_0() { }

	[IteratorStateMachine(typeof(VendingMachine.<<Impacted>g__Drop|64_1>d))]
	[CompilerGenerated]
	// RVA: 0x9DDCA0 Offset: 0x9DC6A0 VA: 0x1809DDCA0
	private IEnumerator <Impacted>g__Drop|64_1() { }

	// RVA: 0x9DBD90 Offset: 0x9DA790 VA: 0x1809DBD90 Slot: 27
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9D4980 Offset: 0x9D3380 VA: 0x1809D4980 Slot: 28
	public override void NetworkInitialize__Late() { }

	// RVA: 0x9DBD50 Offset: 0x9DA750 VA: 0x1809DBD50 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9DD290 Offset: 0x9DBC90 VA: 0x1809DD290
	private void RpcWriter___Server_SendPurchase_2166136261() { }

	// RVA: 0x9DC260 Offset: 0x9DAC60 VA: 0x1809DC260
	public void RpcLogic___SendPurchase_2166136261() { }

	// RVA: 0x9DCE90 Offset: 0x9DB890 VA: 0x1809DCE90
	private void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9DD060 Offset: 0x9DBA60 VA: 0x1809DD060
	private void RpcWriter___Observers_PurchaseRoutine_2166136261() { }

	// RVA: 0x9DC9D0 Offset: 0x9DB3D0 VA: 0x1809DC9D0
	public void RpcLogic___PurchaseRoutine_2166136261() { }

	// RVA: 0x9DCBE0 Offset: 0x9DB5E0 VA: 0x1809DCBE0
	private void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9DB350 Offset: 0x9D9D50 VA: 0x1809DB350
	private void RpcWriter___Server_DropItem_2166136261() { }

	// RVA: 0x9DC890 Offset: 0x9DB290 VA: 0x1809DC890
	public void RpcLogic___DropItem_2166136261() { }

	// RVA: 0x9DCCE0 Offset: 0x9DB6E0 VA: 0x1809DCCE0
	private void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9DD180 Offset: 0x9DBB80 VA: 0x1809DD180
	private void RpcWriter___Server_SendBreak_2166136261() { }

	// RVA: 0x9DCB60 Offset: 0x9DB560 VA: 0x1809DCB60
	private void RpcLogic___SendBreak_2166136261() { }

	// RVA: 0x9DCE30 Offset: 0x9DB830 VA: 0x1809DCE30
	private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9DCF40 Offset: 0x9DB940 VA: 0x1809DCF40
	private void RpcWriter___Observers_Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9DC5C0 Offset: 0x9DAFC0 VA: 0x1809DC5C0
	private void RpcLogic___Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9DCB80 Offset: 0x9DB580 VA: 0x1809DCB80
	private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9DD3A0 Offset: 0x9DBDA0 VA: 0x1809DD3A0
	private void RpcWriter___Target_Break_328543758(NetworkConnection conn) { }

	// RVA: 0x9DCEE0 Offset: 0x9DB8E0 VA: 0x1809DCEE0
	private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9DC4A0 Offset: 0x9DAEA0 VA: 0x1809DC4A0
	private void RpcWriter___Observers_Repair_2166136261() { }

	// RVA: 0x9DCAD0 Offset: 0x9DB4D0 VA: 0x1809DCAD0
	private void RpcLogic___Repair_2166136261() { }

	// RVA: 0x9DCC20 Offset: 0x9DB620 VA: 0x1809DCC20
	private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9DB240 Offset: 0x9D9C40 VA: 0x1809DB240
	private void RpcWriter___Server_DropCash_2166136261() { }

	// RVA: 0x9DC610 Offset: 0x9DB010 VA: 0x1809DC610
	private void RpcLogic___DropCash_2166136261() { }

	// RVA: 0x9DCCB0 Offset: 0x9DB6B0 VA: 0x1809DCCB0
	private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9DABC0 Offset: 0x9D95C0 VA: 0x1809DABC0
	private void Awake_UserLogic_ScheduleOne.ObjectScripts.VendingMachine_Assembly-CSharp.dll() { }
}
