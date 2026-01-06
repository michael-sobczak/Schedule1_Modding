public class Pallet : NetworkBehaviour // TypeDefIndex: 2387
{
	// Fields
	public static List<Pallet> palletsOwnedByLocalPlayer; // 0x0
	public static int sizeX; // 0x8
	public static int sizeY; // 0xC
	[Header("Reference")]
	public Transform _storedItemContainer; // 0x118
	public Rigidbody rb; // 0x120
	public StorageGrid storageGrid; // 0x128
	public NetworkTransform networkTransform; // 0x130
	protected List<Forklift> forkliftsInContact; // 0x138
	public Guid currentSlotGUID; // 0x140
	private PalletSlot currentSlot; // 0x150
	private float timeSinceSlotCheck; // 0x158
	private float timeBoundToSlot; // 0x15C
	private float rb_Mass; // 0x160
	private float rb_Drag; // 0x164
	private float rb_AngularDrag; // 0x168
	protected Dictionary<StoredItem, Employee> _reservedItems; // 0x170
	private List<string> completedJobs; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public bool isEmpty { get; }
	protected bool carriedByForklift { get; }
	public Transform storedItemContainer { get; }
	public Dictionary<StoredItem, Employee> reservedItems { get; }

	// Methods

	// RVA: 0x87F2A0 Offset: 0x87DCA0 VA: 0x18087F2A0
	public bool get_isEmpty() { }

	// RVA: 0x87F250 Offset: 0x87DC50 VA: 0x18087F250
	protected bool get_carriedByForklift() { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Transform get_storedItemContainer() { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public Dictionary<StoredItem, Employee> get_reservedItems() { }

	// RVA: 0x879E70 Offset: 0x878870 VA: 0x180879E70 Slot: 19
	public override void Awake() { }

	// RVA: 0x87BAC0 Offset: 0x87A4C0 VA: 0x18087BAC0 Slot: 6
	public override void OnStartServer() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x87E480 Offset: 0x87CE80 VA: 0x18087E480 Slot: 20
	protected virtual void SetOwner(NetworkConnection conn) { }

	// RVA: 0x87B760 Offset: 0x87A160 VA: 0x18087B760 Slot: 13
	public override void OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0x87BA00 Offset: 0x87A400 VA: 0x18087BA00 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x87E910 Offset: 0x87D310 VA: 0x18087E910
	private void SendItemsToClient(NetworkConnection connection) { }

	// RVA: 0x87A5A0 Offset: 0x878FA0 VA: 0x18087A5A0 Slot: 21
	public virtual void DestroyPallet() { }

	// RVA: 0x87EFC0 Offset: 0x87D9C0 VA: 0x18087EFC0 Slot: 22
	protected virtual void Update() { }

	// RVA: 0x87AB10 Offset: 0x879510 VA: 0x18087AB10 Slot: 23
	protected virtual void FixedUpdate() { }

	// RVA: 0x87EB70 Offset: 0x87D570 VA: 0x18087EB70
	private void SetPosition(Vector3 position) { }

	// RVA: 0x87EDE0 Offset: 0x87D7E0 VA: 0x18087EDE0
	private void UpdateOwnership() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x879F00 Offset: 0x878900 VA: 0x180879F00
	public void BindToSlot_Server(Guid slotGuid) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0x87A070 Offset: 0x878A70 VA: 0x18087A070
	private void BindToSlot(NetworkConnection conn, Guid slotGuid) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x87A8E0 Offset: 0x8792E0 VA: 0x18087A8E0
	public void ExitSlot_Server() { }

	[ObserversRpc]
	// RVA: 0x87A9F0 Offset: 0x8793F0 VA: 0x18087A9F0
	private void ExitSlot() { }

	// RVA: 0x87EBC0 Offset: 0x87D5C0 VA: 0x18087EBC0
	public void TriggerStay(Collider other) { }

	// RVA: 0x87B340 Offset: 0x879D40 VA: 0x18087B340
	public List<StoredItem> GetStoredItems() { }

	// RVA: 0x87B250 Offset: 0x879C50 VA: 0x18087B250
	public List<StorageGrid> GetStorageGrids() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x87A470 Offset: 0x878E70 VA: 0x18087A470
	public void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = True) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x87A2D0 Offset: 0x878CD0 VA: 0x18087A2D0
	private void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x87A720 Offset: 0x879120 VA: 0x18087A720
	public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = True) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x87A5B0 Offset: 0x878FB0 VA: 0x18087A5B0
	private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID) { }

	// RVA: 0x87F130 Offset: 0x87DB30 VA: 0x18087F130
	public void .ctor() { }

	// RVA: 0x87F080 Offset: 0x87DA80 VA: 0x18087F080
	private static void .cctor() { }

	// RVA: 0x87B420 Offset: 0x879E20 VA: 0x18087B420 Slot: 24
	public override void NetworkInitialize___Early() { }

	// RVA: 0x801620 Offset: 0x800020 VA: 0x180801620 Slot: 25
	public override void NetworkInitialize__Late() { }

	// RVA: 0x87B3E0 Offset: 0x879DE0 VA: 0x18087B3E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x87E480 Offset: 0x87CE80 VA: 0x18087E480
	private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn) { }

	// RVA: 0x87CFF0 Offset: 0x87B9F0 VA: 0x18087CFF0 Slot: 26
	protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn) { }

	// RVA: 0x87D970 Offset: 0x87C370 VA: 0x18087D970
	private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x87E060 Offset: 0x87CA60 VA: 0x18087E060
	private void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid) { }

	// RVA: 0x87C310 Offset: 0x87AD10 VA: 0x18087C310
	public void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid) { }

	// RVA: 0x87D550 Offset: 0x87BF50 VA: 0x18087D550
	private void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x87DB80 Offset: 0x87C580 VA: 0x18087DB80
	private void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid) { }

	// RVA: 0x87BB60 Offset: 0x87A560 VA: 0x18087BB60
	private void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid) { }

	// RVA: 0x87D290 Offset: 0x87BC90 VA: 0x18087D290
	private void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87E5B0 Offset: 0x87CFB0 VA: 0x18087E5B0
	private void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid) { }

	// RVA: 0x87D9C0 Offset: 0x87C3C0 VA: 0x18087D9C0
	private void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87E370 Offset: 0x87CD70 VA: 0x18087E370
	private void RpcWriter___Server_ExitSlot_Server_2166136261() { }

	// RVA: 0x87A9F0 Offset: 0x8793F0 VA: 0x18087A9F0
	public void RpcLogic___ExitSlot_Server_2166136261() { }

	// RVA: 0x87D920 Offset: 0x87C320 VA: 0x18087D920
	private void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x87A9F0 Offset: 0x8793F0 VA: 0x18087A9F0
	private void RpcWriter___Observers_ExitSlot_2166136261() { }

	// RVA: 0x87CD20 Offset: 0x87B720 VA: 0x18087CD20
	private void RpcLogic___ExitSlot_2166136261() { }

	// RVA: 0x87D520 Offset: 0x87BF20 VA: 0x18087D520
	private void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87DCF0 Offset: 0x87C6F0 VA: 0x18087DCF0
	private void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = True) { }

	// RVA: 0x87C330 Offset: 0x87AD30 VA: 0x18087C330
	public void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = True) { }

	// RVA: 0x87D2F0 Offset: 0x87BCF0 VA: 0x18087D2F0
	private void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87E740 Offset: 0x87D140 VA: 0x18087E740
	private void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = True) { }

	// RVA: 0x87DA30 Offset: 0x87C430 VA: 0x18087DA30
	private void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87E1C0 Offset: 0x87CBC0 VA: 0x18087E1C0
	private void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID) { }

	// RVA: 0x87C690 Offset: 0x87B090 VA: 0x18087C690
	private void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID) { }

	// RVA: 0x87D5D0 Offset: 0x87BFD0 VA: 0x18087D5D0
	private void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x87DED0 Offset: 0x87C8D0 VA: 0x18087DED0
	private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = True) { }

	// RVA: 0x87C750 Offset: 0x87B150 VA: 0x18087C750
	public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = True) { }

	// RVA: 0x87D440 Offset: 0x87BE40 VA: 0x18087D440
	private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x87A5B0 Offset: 0x878FB0 VA: 0x18087A5B0
	private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID) { }

	// RVA: 0x87CB70 Offset: 0x87B570 VA: 0x18087CB70
	private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID) { }

	// RVA: 0x87D720 Offset: 0x87C120 VA: 0x18087D720
	private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x879E00 Offset: 0x878800 VA: 0x180879E00 Slot: 27
	protected virtual void Awake_UserLogic_ScheduleOne.Storage.Pallet_Assembly-CSharp.dll() { }
}
