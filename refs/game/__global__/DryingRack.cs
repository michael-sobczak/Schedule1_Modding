public class DryingRack : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3251
{
	// Fields
	public const int DRY_MINS_PER_TIER = 720;
	[Header("Settings")]
	public int ItemCapacity; // 0x210
	[Header("References")]
	public Transform[] CameraPositions; // 0x218
	public InteractableObject IntObj; // 0x220
	public Transform uiPoint; // 0x228
	public Transform[] accessPoints; // 0x230
	public StorageVisualizer InputVisuals; // 0x238
	public StorageVisualizer OutputVisuals; // 0x240
	public StorageVisualizer HangingVisuals; // 0x248
	public Transform[] HangAlignments; // 0x250
	public ConfigurationReplicator configReplicator; // 0x258
	[Header("UI")]
	public DryingRackUIElement WorldspaceUIPrefab; // 0x260
	public Sprite typeIcon; // 0x268
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x270
	[HideInInspector]
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x278
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x280
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x288
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x290
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x298
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x299
	[CompilerGenerated]
	private DryingRackConfiguration <stationConfiguration>k__BackingField; // 0x2A0
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x2A8
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x2B0
	[CompilerGenerated]
	private ItemSlot <InputSlot>k__BackingField; // 0x2B8
	[CompilerGenerated]
	private ItemSlot <OutputSlot>k__BackingField; // 0x2C0
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x2C8
	[CompilerGenerated]
	private List<DryingOperation> <DryingOperations>k__BackingField; // 0x2D0
	public Action<DryingOperation> onOperationStart; // 0x2D8
	public Action<DryingOperation> onOperationComplete; // 0x2E0
	public Action onOperationsChanged; // 0x2E8
	private ItemSlot[] hangSlots; // 0x2F0
	private List<int> requestIDs; // 0x2F8
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x300
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x308
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x310
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted; // 0x318
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted; // 0x319

	// Properties
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public List<ItemSlot> ItemSlots { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public EntityConfiguration Configuration { get; }
	protected DryingRackConfiguration stationConfiguration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	public ItemSlot InputSlot { get; set; }
	public ItemSlot OutputSlot { get; set; }
	public bool IsOpen { get; set; }
	public List<DryingOperation> DryingOperations { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA0F070 Offset: 0xA0DA70 VA: 0x180A0F070 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA0F230 Offset: 0xA0DC30 VA: 0x180A0F230 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x6415F0 Offset: 0x63FFF0 VA: 0x1806415F0 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA141E0 Offset: 0xA12BE0 VA: 0x180A141E0 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x860A10 Offset: 0x85F410 VA: 0x180860A10 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA14220 Offset: 0xA12C20 VA: 0x180A14220 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0xA141D0 Offset: 0xA12BD0 VA: 0x180A141D0 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA141B0 Offset: 0xA12BB0 VA: 0x180A141B0 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA14200 Offset: 0xA12C00 VA: 0x180A14200
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x718C70 Offset: 0x717670 VA: 0x180718C70 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x718C70 Offset: 0x717670 VA: 0x180718C70
	protected DryingRackConfiguration get_stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x8795B0 Offset: 0x877FB0 VA: 0x1808795B0
	protected void set_stationConfiguration(DryingRackConfiguration value) { }

	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0xA141A0 Offset: 0xA12BA0 VA: 0x180A141A0 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x879400 Offset: 0x877E00 VA: 0x180879400 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x8794F0 Offset: 0x877EF0 VA: 0x1808794F0 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA0EF40 Offset: 0xA0D940 VA: 0x180A0EF40 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA12770 Offset: 0xA11170 VA: 0x180A12770 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90
	public ItemSlot get_InputSlot() { }

	[CompilerGenerated]
	// RVA: 0x81F780 Offset: 0x81E180 VA: 0x18081F780
	private void set_InputSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public ItemSlot get_OutputSlot() { }

	[CompilerGenerated]
	// RVA: 0x641350 Offset: 0x63FD50 VA: 0x180641350
	private void set_OutputSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0xA141C0 Offset: 0xA12BC0 VA: 0x180A141C0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0xA14210 Offset: 0xA12C10 VA: 0x180A14210
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0
	public List<DryingOperation> get_DryingOperations() { }

	[CompilerGenerated]
	// RVA: 0x81F940 Offset: 0x81E340 VA: 0x18081F940
	public void set_DryingOperations(List<DryingOperation> value) { }

	// RVA: 0xA0B590 Offset: 0xA09F90 VA: 0x180A0B590 Slot: 47
	public override void Awake() { }

	// RVA: 0xA0C830 Offset: 0xA0B230 VA: 0x180A0C830 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA0C290 Offset: 0xA0AC90 VA: 0x180A0C290 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA0D500 Offset: 0xA0BF00 VA: 0x180A0D500 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA12660 Offset: 0xA11060 VA: 0x180A12660 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA0BF70 Offset: 0xA0A970 VA: 0x180A0BF70
	private void Exit(ExitAction action) { }

	// RVA: 0xA0B5E0 Offset: 0xA09FE0 VA: 0x180A0B5E0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA0BD50 Offset: 0xA0A750 VA: 0x180A0BD50 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA0CB10 Offset: 0xA0B510 VA: 0x180A0CB10
	private void MinPass() { }

	// RVA: 0xA0B6E0 Offset: 0xA0A0E0 VA: 0x180A0B6E0
	public bool CanStartOperation() { }

	// RVA: 0xA13BF0 Offset: 0xA125F0 VA: 0x180A13BF0
	public void StartOperation() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA13E60 Offset: 0xA12860 VA: 0x180A13E60
	public void TryEndOperation(int operationIndex, bool allowSplitting, EQuality quality, int requestID) { }

	// RVA: 0xA0C2C0 Offset: 0xA0ACC0 VA: 0x180A0C2C0
	public List<DryingOperation> GetOperationsAtTargetQuality() { }

	// RVA: 0xA0C430 Offset: 0xA0AE30 VA: 0x180A0C430
	public int GetOutputCapacityForOperation(DryingOperation operation, EQuality quality) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xA11450 Offset: 0xA0FE50 VA: 0x180A11450
	private void SendOperation(DryingOperation op) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0xA0DE90 Offset: 0xA0C890 VA: 0x180A0DE90
	private void PleaseReceiveOp(NetworkConnection conn, DryingOperation op) { }

	[ObserversRpc(RunLocally = True, ExcludeServer = True)]
	// RVA: 0xA0EB20 Offset: 0xA0D520 VA: 0x180A0EB20
	private void RemoveOperation(int opIndex) { }

	[ObserversRpc]
	// RVA: 0xA10E30 Offset: 0xA0F830 VA: 0x180A10E30
	private void SetOperationQuantity(int opIndex, int quantity) { }

	// RVA: 0xA0C5D0 Offset: 0xA0AFD0 VA: 0x180A0C5D0
	public int GetTotalDryingItems() { }

	// RVA: 0xA0E230 Offset: 0xA0CC30 VA: 0x180A0E230
	public void RefreshHangingVisuals() { }

	// RVA: 0xA0BA90 Offset: 0xA0A490 VA: 0x180A0BA90 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA0BCC0 Offset: 0xA0A6C0 VA: 0x180A0BCC0 Slot: 129
	public void DestroyWorldspaceUI() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA12CF0 Offset: 0xA116F0 VA: 0x180A12CF0 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA12BC0 Offset: 0xA115C0 VA: 0x180A12BC0 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA0C6F0 Offset: 0xA0B0F0 VA: 0x180A0C6F0
	public void Hovered() { }

	// RVA: 0xA0CA60 Offset: 0xA0B460 VA: 0x180A0CA60
	public void Interacted() { }

	// RVA: 0xA0D770 Offset: 0xA0C170 VA: 0x180A0D770
	public void Open() { }

	// RVA: 0xA0B750 Offset: 0xA0A150 VA: 0x180A0B750
	public void Close() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA13A50 Offset: 0xA12450 VA: 0x180A13A50 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA13790 Offset: 0xA12190 VA: 0x180A13790
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA12A50 Offset: 0xA11450 VA: 0x180A12A50 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA128A0 Offset: 0xA112A0 VA: 0x180A128A0
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA135A0 Offset: 0xA11FA0 VA: 0x180A135A0 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA13280 Offset: 0xA11C80 VA: 0x180A13280
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA130E0 Offset: 0xA11AE0 VA: 0x180A130E0 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA12E20 Offset: 0xA11820 VA: 0x180A12E20
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA0BFC0 Offset: 0xA0A9C0 VA: 0x180A0BFC0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA0C520 Offset: 0xA0AF20 VA: 0x180A0C520 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA14010 Offset: 0xA12A10 VA: 0x180A14010
	public void .ctor() { }

	// RVA: 0xA0CD10 Offset: 0xA0B710 VA: 0x180A0CD10 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA0CC80 Offset: 0xA0B680 VA: 0x180A0CC80 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA11580 Offset: 0xA0FF80 VA: 0x180A11580
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA0EF40 Offset: 0xA0D940 VA: 0x180A0EF40 Slot: 136
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA10150 Offset: 0xA0EB50 VA: 0x180A10150
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA11F00 Offset: 0xA10900 VA: 0x180A11F00
	private void RpcWriter___Server_TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID) { }

	// RVA: 0xA0F640 Offset: 0xA0E040 VA: 0x180A0F640
	public void RpcLogic___TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID) { }

	// RVA: 0xA106B0 Offset: 0xA0F0B0 VA: 0x180A106B0
	private void RpcReader___Server_TryEndOperation_4146970406(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA11450 Offset: 0xA0FE50 VA: 0x180A11450
	private void RpcWriter___Server_SendOperation_1307702229(DryingOperation op) { }

	// RVA: 0xA0EF30 Offset: 0xA0D930 VA: 0x180A0EF30
	private void RpcLogic___SendOperation_1307702229(DryingOperation op) { }

	// RVA: 0xA10100 Offset: 0xA0EB00 VA: 0x180A10100
	private void RpcReader___Server_SendOperation_1307702229(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA12090 Offset: 0xA10A90 VA: 0x180A12090
	private void RpcWriter___Target_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op) { }

	// RVA: 0xA0EC70 Offset: 0xA0D670 VA: 0x180A0EC70
	private void RpcLogic___PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op) { }

	// RVA: 0xA107B0 Offset: 0xA0F1B0 VA: 0x180A107B0
	private void RpcReader___Target_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA10A20 Offset: 0xA0F420 VA: 0x180A10A20
	private void RpcWriter___Observers_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op) { }

	// RVA: 0xA0FC10 Offset: 0xA0E610 VA: 0x180A0FC10
	private void RpcReader___Observers_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA10B60 Offset: 0xA0F560 VA: 0x180A10B60
	private void RpcWriter___Observers_RemoveOperation_3316948804(int opIndex) { }

	// RVA: 0xA0EDD0 Offset: 0xA0D7D0 VA: 0x180A0EDD0
	private void RpcLogic___RemoveOperation_3316948804(int opIndex) { }

	// RVA: 0xA0FC60 Offset: 0xA0E660 VA: 0x180A0FC60
	private void RpcReader___Observers_RemoveOperation_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA10E30 Offset: 0xA0F830 VA: 0x180A10E30
	private void RpcWriter___Observers_SetOperationQuantity_1692629761(int opIndex, int quantity) { }

	// RVA: 0xA0F110 Offset: 0xA0DB10 VA: 0x180A0F110
	private void RpcLogic___SetOperationQuantity_1692629761(int opIndex, int quantity) { }

	// RVA: 0xA0FD70 Offset: 0xA0E770 VA: 0x180A0FD70
	private void RpcReader___Observers_SetOperationQuantity_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA11960 Offset: 0xA10360 VA: 0x180A11960
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA0F230 Offset: 0xA0DC30 VA: 0x180A0F230 Slot: 137
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA10300 Offset: 0xA0ED00 VA: 0x180A10300
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA11830 Offset: 0xA10230 VA: 0x180A11830
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA0F070 Offset: 0xA0DA70 VA: 0x180A0F070 Slot: 138
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA10280 Offset: 0xA0EC80 VA: 0x180A10280
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA11D90 Offset: 0xA10790 VA: 0x180A11D90
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA0F500 Offset: 0xA0DF00 VA: 0x180A0F500 Slot: 139
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA105C0 Offset: 0xA0EFC0 VA: 0x180A105C0
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA112D0 Offset: 0xA0FCD0 VA: 0x180A112D0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA0F580 Offset: 0xA0DF80 VA: 0x180A0F580
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA10070 Offset: 0xA0EA70 VA: 0x180A10070
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA124F0 Offset: 0xA10EF0 VA: 0x180A124F0
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA10990 Offset: 0xA0F390 VA: 0x180A10990
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA116B0 Offset: 0xA100B0 VA: 0x180A116B0
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA0EFE0 Offset: 0xA0D9E0 VA: 0x180A0EFE0 Slot: 140
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA101D0 Offset: 0xA0EBD0 VA: 0x180A101D0
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA10CB0 Offset: 0xA0F6B0 VA: 0x180A10CB0
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA0EFF0 Offset: 0xA0D9F0 VA: 0x180A0EFF0
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA0FCD0 Offset: 0xA0E6D0 VA: 0x180A0FCD0
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA11C00 Offset: 0xA10600 VA: 0x180A11C00
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA0F3D0 Offset: 0xA0DDD0 VA: 0x180A0F3D0 Slot: 141
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA10470 Offset: 0xA0EE70 VA: 0x180A10470
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA12360 Offset: 0xA10D60 VA: 0x180A12360
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA0F450 Offset: 0xA0DE50 VA: 0x180A0F450
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA108A0 Offset: 0xA0F2A0 VA: 0x180A108A0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA11130 Offset: 0xA0FB30 VA: 0x180A11130
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA0FF80 Offset: 0xA0E980 VA: 0x180A0FF80
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA11A90 Offset: 0xA10490 VA: 0x180A11A90
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA0F2D0 Offset: 0xA0DCD0 VA: 0x180A0F2D0 Slot: 142
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA10380 Offset: 0xA0ED80 VA: 0x180A10380
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA10FB0 Offset: 0xA0F9B0 VA: 0x180A10FB0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA0F350 Offset: 0xA0DD50 VA: 0x180A0F350
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA0FEF0 Offset: 0xA0E8F0 VA: 0x180A0FEF0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA121F0 Offset: 0xA10BF0 VA: 0x180A121F0
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA10810 Offset: 0xA0F210 VA: 0x180A10810
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA14300 Offset: 0xA12D00 VA: 0x180A14300
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA0E090 Offset: 0xA0CA90 VA: 0x180A0E090 Slot: 143
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.DryingRack(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA143C0 Offset: 0xA12DC0 VA: 0x180A143C0
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA14240 Offset: 0xA12C40 VA: 0x180A14240
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA0B230 Offset: 0xA09C30 VA: 0x180A0B230 Slot: 144
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.DryingRack_Assembly-CSharp.dll() { }
}
