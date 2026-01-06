public class PackagingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3275
{
	// Fields
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x210
	[Header("References")]
	public Light OverheadLight; // 0x218
	public MeshRenderer OverheadLightMeshRend; // 0x220
	public RockerSwitch Switch; // 0x228
	public Transform CameraPosition; // 0x230
	public Transform CameraPosition_Task; // 0x238
	public InteractableObject IntObj; // 0x240
	public Transform ActivePackagingAlignent; // 0x248
	public Transform[] ActiveProductAlignments; // 0x250
	public Transform Container; // 0x258
	public Collider OutputCollider; // 0x260
	public Transform Hatch; // 0x268
	public Transform[] PackagingAlignments; // 0x270
	public Transform[] ProductAlignments; // 0x278
	public Transform uiPoint; // 0x280
	[SerializeField]
	protected ConfigurationReplicator configReplicator; // 0x288
	public Transform StandPoint; // 0x290
	public Transform[] accessPoints; // 0x298
	public AudioSourceController HatchOpenSound; // 0x2A0
	public AudioSourceController HatchCloseSound; // 0x2A8
	[Header("UI")]
	public PackagingStationUIElement WorldspaceUIPrefab; // 0x2B0
	public Sprite typeIcon; // 0x2B8
	[Header("Slot Display Points")]
	public Transform PackagingSlotPosition; // 0x2C0
	public Transform ProductSlotPosition; // 0x2C8
	public Transform OutputSlotPosition; // 0x2D0
	[Header("Materials")]
	public Material LightMeshOnMat; // 0x2D8
	public Material LightMeshOffMat; // 0x2E0
	[Header("Settings")]
	public float PackagerEmployeeSpeedMultiplier; // 0x2E8
	public Vector3 HatchClosedRotation; // 0x2EC
	public Vector3 HatchOpenRotation; // 0x2F8
	public float HatchLerpTime; // 0x304
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x308
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	[CompilerGenerated]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x310
	public ItemSlot PackagingSlot; // 0x318
	public ItemSlot ProductSlot; // 0x320
	public ItemSlot OutputSlot; // 0x328
	private bool hatchOpen; // 0x330
	private Coroutine hatchRoutine; // 0x338
	private List<string> PackagingSlotModelID; // 0x340
	private List<string> ProductSlotModelID; // 0x348
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x350
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x358
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x360
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x361
	[CompilerGenerated]
	private PackagingStationConfiguration <stationConfiguration>k__BackingField; // 0x368
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x370
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x378
	private bool visualsLocked; // 0x380
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x388
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x390
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x398
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted; // 0x3A0
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted; // 0x3A1

	// Properties
	public List<ItemSlot> ItemSlots { get; set; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public EntityConfiguration Configuration { get; }
	protected PackagingStationConfiguration stationConfiguration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA50 Offset: 0x6DE450 VA: 0x1806DFA50 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA37BE0 Offset: 0xA365E0 VA: 0x180A37BE0 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA3C770 Offset: 0xA3B170 VA: 0x180A3C770 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0xA02670 Offset: 0xA01070 VA: 0x180A02670 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA02800 Offset: 0xA01200 VA: 0x180A02800 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0xA026A0 Offset: 0xA010A0 VA: 0x180A026A0 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA02830 Offset: 0xA01230 VA: 0x180A02830 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x8793C0 Offset: 0x877DC0 VA: 0x1808793C0 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0xA026C0 Offset: 0xA010C0 VA: 0x180A026C0 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA02680 Offset: 0xA01080 VA: 0x180A02680 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA02820 Offset: 0xA01220 VA: 0x180A02820
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0xA02650 Offset: 0xA01050 VA: 0x180A02650 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0xA02650 Offset: 0xA01050 VA: 0x180A02650
	protected PackagingStationConfiguration get_stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0xA02870 Offset: 0xA01270 VA: 0x180A02870
	protected void set_stationConfiguration(PackagingStationConfiguration value) { }

	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0xA026D0 Offset: 0xA010D0 VA: 0x180A026D0 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0xA02850 Offset: 0xA01250 VA: 0x180A02850 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA37AB0 Offset: 0xA364B0 VA: 0x180A37AB0 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3A2D0 Offset: 0xA38CD0 VA: 0x180A3A2D0 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	// RVA: 0xA35350 Offset: 0xA33D50 VA: 0x180A35350 Slot: 47
	public override void Awake() { }

	// RVA: 0xA36650 Offset: 0xA35050 VA: 0x180A36650 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x9FBF40 Offset: 0x9FA940 VA: 0x1809FBF40 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA35F00 Offset: 0xA34900 VA: 0x180A35F00 Slot: 51
	public override string GetDefaultManagementName() { }

	// RVA: 0xA36F60 Offset: 0xA35960 VA: 0x180A36F60 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA3A170 Offset: 0xA38B70 VA: 0x180A3A170 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA35CD0 Offset: 0xA346D0 VA: 0x180A35CD0
	private void Exit(ExitAction action) { }

	// RVA: 0xA353A0 Offset: 0xA33DA0 VA: 0x180A353A0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA35B80 Offset: 0xA34580 VA: 0x180A35B80 Slot: 56
	protected override void Destroy() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3A990 Offset: 0xA39390 VA: 0x180A3A990 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3A860 Offset: 0xA39260 VA: 0x180A3A860 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA36510 Offset: 0xA34F10 VA: 0x180A36510
	public void Hovered() { }

	// RVA: 0xA367C0 Offset: 0xA351C0 VA: 0x180A367C0
	public void Interacted() { }

	// RVA: 0xA37170 Offset: 0xA35B70 VA: 0x180A37170
	public void Open() { }

	// RVA: 0xA354E0 Offset: 0xA33EE0 VA: 0x180A354E0
	public void Close() { }

	// RVA: 0xA35FC0 Offset: 0xA349C0 VA: 0x180A35FC0
	public PackagingStation.EState GetState(PackagingStation.EMode mode) { }

	// RVA: 0xA3B8E0 Offset: 0xA3A2E0 VA: 0x180A3B8E0
	public void Unpack() { }

	// RVA: 0xA37570 Offset: 0xA35F70 VA: 0x180A37570
	public void PackSingleInstance() { }

	// RVA: 0xA3A400 Offset: 0xA38E00 VA: 0x180A3A400
	public void SetHatchOpen(bool open) { }

	// RVA: 0xA3BAE0 Offset: 0xA3A4E0 VA: 0x180A3BAE0
	public void UpdatePackagingVisuals() { }

	// RVA: 0x641650 Offset: 0x640050 VA: 0x180641650
	public void SetVisualsLocked(bool locked) { }

	// RVA: 0xA3BB20 Offset: 0xA3A520 VA: 0x180A3BB20
	public void UpdatePackagingVisuals(int quantity) { }

	// RVA: 0xA3C080 Offset: 0xA3AA80 VA: 0x180A3C080
	public void UpdateProductVisuals() { }

	// RVA: 0xA3C0C0 Offset: 0xA3AAC0 VA: 0x180A3C0C0
	public void UpdateProductVisuals(int quantity) { }

	// RVA: 0xA3B890 Offset: 0xA3A290 VA: 0x180A3B890 Slot: 136
	public virtual void StartTask() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA3B6F0 Offset: 0xA3A0F0 VA: 0x180A3B6F0 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA3B430 Offset: 0xA39E30 VA: 0x180A3B430
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA3A6F0 Offset: 0xA390F0 VA: 0x180A3A6F0 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA3A540 Offset: 0xA38F40 VA: 0x180A3A540
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA3B240 Offset: 0xA39C40 VA: 0x180A3B240 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA3AF20 Offset: 0xA39920 VA: 0x180A3AF20
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA3AD80 Offset: 0xA39780 VA: 0x180A3AD80 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA3AAC0 Offset: 0xA394C0 VA: 0x180A3AAC0
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA358C0 Offset: 0xA342C0 VA: 0x180A358C0 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA35AF0 Offset: 0xA344F0 VA: 0x180A35AF0 Slot: 129
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA35DE0 Offset: 0xA347E0 VA: 0x180A35DE0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA35F10 Offset: 0xA34910 VA: 0x180A35F10 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA3C5E0 Offset: 0xA3AFE0 VA: 0x180A3C5E0
	public void .ctor() { }

	// RVA: 0xA36900 Offset: 0xA35300 VA: 0x180A36900 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA36870 Offset: 0xA35270 VA: 0x180A36870 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA39380 Offset: 0xA37D80 VA: 0x180A39380
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA37AB0 Offset: 0xA364B0 VA: 0x180A37AB0 Slot: 137
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA385F0 Offset: 0xA36FF0 VA: 0x180A385F0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA39760 Offset: 0xA38160 VA: 0x180A39760
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA37C80 Offset: 0xA36680 VA: 0x180A37C80 Slot: 138
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA387A0 Offset: 0xA371A0 VA: 0x180A387A0
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA39630 Offset: 0xA38030 VA: 0x180A39630
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA37BE0 Offset: 0xA365E0 VA: 0x180A37BE0 Slot: 139
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA38720 Offset: 0xA37120 VA: 0x180A38720
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA39B90 Offset: 0xA38590 VA: 0x180A39B90
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA38200 Offset: 0xA36C00 VA: 0x180A38200 Slot: 140
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA38A60 Offset: 0xA37460 VA: 0x180A38A60
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA39200 Offset: 0xA37C00 VA: 0x180A39200
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA38280 Offset: 0xA36C80 VA: 0x180A38280
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA38560 Offset: 0xA36F60 VA: 0x180A38560
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA3A000 Offset: 0xA38A00 VA: 0x180A3A000
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA38CD0 Offset: 0xA376D0 VA: 0x180A38CD0
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA394B0 Offset: 0xA37EB0 VA: 0x180A394B0
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA37B50 Offset: 0xA36550 VA: 0x180A37B50 Slot: 141
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA38670 Offset: 0xA37070 VA: 0x180A38670
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA38D60 Offset: 0xA37760 VA: 0x180A38D60
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA37B60 Offset: 0xA36560 VA: 0x180A37B60
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA38340 Offset: 0xA36D40 VA: 0x180A38340
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA39A00 Offset: 0xA38400 VA: 0x180A39A00
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA380D0 Offset: 0xA36AD0 VA: 0x180A380D0 Slot: 142
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA38910 Offset: 0xA37310 VA: 0x180A38910
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA39E70 Offset: 0xA38870 VA: 0x180A39E70
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA38150 Offset: 0xA36B50 VA: 0x180A38150
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA38BE0 Offset: 0xA375E0 VA: 0x180A38BE0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA39060 Offset: 0xA37A60 VA: 0x180A39060
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA38470 Offset: 0xA36E70 VA: 0x180A38470
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA39890 Offset: 0xA38290 VA: 0x180A39890
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA37FD0 Offset: 0xA369D0 VA: 0x180A37FD0 Slot: 143
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA38820 Offset: 0xA37220 VA: 0x180A38820
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA38EE0 Offset: 0xA378E0 VA: 0x180A38EE0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA38050 Offset: 0xA36A50 VA: 0x180A38050
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA383E0 Offset: 0xA36DE0 VA: 0x180A383E0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA39D00 Offset: 0xA38700 VA: 0x180A39D00
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA38B50 Offset: 0xA37550 VA: 0x180A38B50
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6DFA50 Offset: 0x6DE450 VA: 0x1806DFA50
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA3C8D0 Offset: 0xA3B2D0 VA: 0x180A3C8D0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA37910 Offset: 0xA36310 VA: 0x180A37910 Slot: 144
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.PackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA3C990 Offset: 0xA3B390 VA: 0x180A3C990
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA3C810 Offset: 0xA3B210 VA: 0x180A3C810
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA34BE0 Offset: 0xA335E0 VA: 0x180A34BE0 Slot: 145
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.PackagingStation_Assembly-CSharp.dll() { }
}
