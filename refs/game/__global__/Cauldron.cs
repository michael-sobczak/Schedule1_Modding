public class Cauldron : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3234
{
	// Fields
	public const int INGREDIENT_SLOT_COUNT = 4;
	public const int COCA_LEAF_REQUIRED = 20;
	public ItemSlot[] IngredientSlots; // 0x210
	public ItemSlot LiquidSlot; // 0x218
	public ItemSlot OutputSlot; // 0x220
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x228
	public int CookTime; // 0x230
	[Header("References")]
	public Transform CameraPosition; // 0x238
	public Transform CameraPosition_CombineIngredients; // 0x240
	public Transform CameraPosition_StartMachine; // 0x248
	public InteractableObject IntObj; // 0x250
	public Transform[] accessPoints; // 0x258
	public Transform StandPoint; // 0x260
	public Transform uiPoint; // 0x268
	public StorageVisualizer LiquidVisuals; // 0x270
	public StorageVisualizer OutputVisuals; // 0x278
	public CauldronDisplayTub PrimaryTub; // 0x280
	public CauldronDisplayTub SecondaryTub; // 0x288
	public Transform ItemContainer; // 0x290
	public Transform GasolineSpawnPoint; // 0x298
	public Transform TubSpawnPoint; // 0x2A0
	public Transform[] LeafSpawns; // 0x2A8
	public Light OverheadLight; // 0x2B0
	public Fillable CauldronFillable; // 0x2B8
	public Clickable StartButtonClickable; // 0x2C0
	public DigitalAlarm Alarm; // 0x2C8
	public ToggleableLight Light; // 0x2D0
	public ConfigurationReplicator configReplicator; // 0x2D8
	public BoxCollider TrashSpawnVolume; // 0x2E0
	public Transform LeafDragProjectionPlane; // 0x2E8
	[Header("Prefabs")]
	public StationItem CocaLeafPrefab; // 0x2F0
	public StationItem GasolinePrefab; // 0x2F8
	public Draggable TubPrefab; // 0x300
	public QualityItemDefinition CocaineBaseDefinition; // 0x308
	[Header("UI")]
	public CauldronUIElement WorldspaceUIPrefab; // 0x310
	public Sprite typeIcon; // 0x318
	public UnityEvent onStartButtonClicked; // 0x320
	public UnityEvent onCookStart; // 0x328
	public UnityEvent onCookEnd; // 0x330
	public int RemainingCookTime; // 0x338
	public EQuality InputQuality; // 0x33C
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x340
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x348
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x350
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x358
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x360
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x361
	[CompilerGenerated]
	private CauldronConfiguration <cauldronConfiguration>k__BackingField; // 0x368
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x370
	[SyncVar]
	[CompilerGenerated]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x378
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x380
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x388
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x390
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted; // 0x398
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted; // 0x399

	// Properties
	public bool isOpen { get; }
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
	protected CauldronConfiguration cauldronConfiguration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	private bool isCooking { get; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	// RVA: 0xA026F0 Offset: 0xA010F0 VA: 0x180A026F0
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0xA02690 Offset: 0xA01090 VA: 0x180A02690 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0x9FDBF0 Offset: 0x9FC5F0 VA: 0x1809FDBF0 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0xA026B0 Offset: 0xA010B0 VA: 0x180A026B0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0x9FDC90 Offset: 0x9FC690 VA: 0x1809FDC90 Slot: 76
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

	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0 Slot: 98
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
	protected CauldronConfiguration get_cauldronConfiguration() { }

	[CompilerGenerated]
	// RVA: 0xA02870 Offset: 0xA01270 VA: 0x180A02870
	protected void set_cauldronConfiguration(CauldronConfiguration value) { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 116
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
	// RVA: 0x9FDAC0 Offset: 0x9FC4C0 VA: 0x1809FDAC0 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA007F0 Offset: 0x9FF1F0 VA: 0x180A007F0 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	// RVA: 0xA026E0 Offset: 0xA010E0 VA: 0x180A026E0
	private bool get_isCooking() { }

	// RVA: 0x9FA380 Offset: 0x9F8D80 VA: 0x1809FA380 Slot: 47
	public override void Awake() { }

	// RVA: 0x9FC3F0 Offset: 0x9FADF0 VA: 0x1809FC3F0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x9FBF40 Offset: 0x9FA940 VA: 0x1809FBF40 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA01F30 Offset: 0xA00930 VA: 0x180A01F30 Slot: 48
	protected override void Start() { }

	// RVA: 0x9FD060 Offset: 0x9FBA60 VA: 0x1809FD060 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA00690 Offset: 0x9FF090 VA: 0x180A00690 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x9FAFA0 Offset: 0x9F99A0 VA: 0x1809FAFA0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0x9FC610 Offset: 0x9FB010 VA: 0x1809FC610
	private void MinPass() { }

	// RVA: 0xA021D0 Offset: 0xA00BD0 VA: 0x180A021D0
	private void TimeSkipped(int minsPassed) { }

	// RVA: 0x9FB2D0 Offset: 0x9F9CD0 VA: 0x1809FB2D0
	private void Exit(ExitAction action) { }

	// RVA: 0x9FC2B0 Offset: 0x9FACB0 VA: 0x1809FC2B0
	public void Hovered() { }

	// RVA: 0x9FC560 Offset: 0x9FAF60 VA: 0x1809FC560
	public void Interacted() { }

	// RVA: 0x9FD1F0 Offset: 0x9FBBF0 VA: 0x1809FD1F0
	public void Open() { }

	// RVA: 0x9FA4F0 Offset: 0x9F8EF0 VA: 0x1809FA4F0
	public void Close() { }

	// RVA: 0x9FA3F0 Offset: 0x9F8DF0 VA: 0x1809FA3F0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA02460 Offset: 0xA00E60 VA: 0x180A02460
	private void UpdateIngredientVisuals() { }

	// RVA: 0x9FB850 Offset: 0x9FA250 VA: 0x1809FB850
	public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity) { }

	// RVA: 0x9FC020 Offset: 0x9FAA20 VA: 0x1809FC020
	public Cauldron.EState GetState() { }

	// RVA: 0x9FC240 Offset: 0x9FAC40 VA: 0x1809FC240
	public bool HasOutputSpace() { }

	// RVA: 0x9FD790 Offset: 0x9FC190 VA: 0x1809FD790
	public EQuality RemoveIngredients() { }

	// RVA: 0x9FC170 Offset: 0x9FAB70 VA: 0x1809FC170
	public bool HasIngredients() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9FF5C0 Offset: 0x9FDFC0 VA: 0x1809FF5C0
	public void SendCookOperation(int remainingCookTime, EQuality quality) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA01C70 Offset: 0xA00670 VA: 0x180A01C70
	public void StartCookOperation(NetworkConnection conn, int remainingCookTime, EQuality quality) { }

	[ObserversRpc]
	// RVA: 0x9FB420 Offset: 0x9F9E20 VA: 0x1809FB420
	public void FinishCookOperation() { }

	// RVA: 0x9FA3D0 Offset: 0x9F8DD0 VA: 0x1809FA3D0
	private void ButtonClicked(RaycastHit hit) { }

	// RVA: 0x9FA840 Offset: 0x9F9240 VA: 0x1809FA840
	public void CreateTrash(List<StationItem> mixerItems) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA00D70 Offset: 0x9FF770 VA: 0x180A00D70 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA00C40 Offset: 0x9FF640 VA: 0x180A00C40 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA01AD0 Offset: 0xA004D0 VA: 0x180A01AD0 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA01810 Offset: 0xA00210 VA: 0x180A01810
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA00AD0 Offset: 0x9FF4D0 VA: 0x180A00AD0 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA00920 Offset: 0x9FF320 VA: 0x180A00920
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA01620 Offset: 0xA00020 VA: 0x180A01620 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA01300 Offset: 0x9FFD00 VA: 0x180A01300
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA01160 Offset: 0x9FFB60 VA: 0x180A01160 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA00EA0 Offset: 0x9FF8A0 VA: 0x180A00EA0
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FACE0 Offset: 0x9F96E0 VA: 0x1809FACE0 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x9FAF10 Offset: 0x9F9910 VA: 0x1809FAF10 Slot: 129
	public void DestroyWorldspaceUI() { }

	// RVA: 0x9FB540 Offset: 0x9F9F40 VA: 0x1809FB540 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x9FBF70 Offset: 0x9FA970 VA: 0x1809FBF70 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA02530 Offset: 0xA00F30 VA: 0x180A02530
	public void .ctor() { }

	// RVA: 0x9FC900 Offset: 0x9FB300 VA: 0x1809FC900 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9FC870 Offset: 0x9FB270 VA: 0x1809FC870 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9FF730 Offset: 0x9FE130 VA: 0x1809FF730
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x9FDAC0 Offset: 0x9FC4C0 VA: 0x1809FDAC0 Slot: 136
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x9FE630 Offset: 0x9FD030 VA: 0x1809FE630
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FF5C0 Offset: 0x9FDFC0 VA: 0x1809FF5C0
	private void RpcWriter___Server_SendCookOperation_3536682170(int remainingCookTime, EQuality quality) { }

	// RVA: 0x9FDAA0 Offset: 0x9FC4A0 VA: 0x1809FDAA0
	public void RpcLogic___SendCookOperation_3536682170(int remainingCookTime, EQuality quality) { }

	// RVA: 0x9FE5B0 Offset: 0x9FCFB0 VA: 0x1809FE5B0
	private void RpcReader___Server_SendCookOperation_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FF450 Offset: 0x9FDE50 VA: 0x1809FF450
	private void RpcWriter___Observers_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality) { }

	// RVA: 0x9FE0A0 Offset: 0x9FCAA0 VA: 0x1809FE0A0
	public void RpcLogic___StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality) { }

	// RVA: 0x9FE520 Offset: 0x9FCF20 VA: 0x1809FE520
	private void RpcReader___Observers_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA00520 Offset: 0x9FEF20 VA: 0x180A00520
	private void RpcWriter___Target_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality) { }

	// RVA: 0x9FEDA0 Offset: 0x9FD7A0 VA: 0x1809FEDA0
	private void RpcReader___Target_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FB420 Offset: 0x9F9E20 VA: 0x1809FB420
	private void RpcWriter___Observers_FinishCookOperation_2166136261() { }

	// RVA: 0x9FD990 Offset: 0x9FC390 VA: 0x1809FD990
	public void RpcLogic___FinishCookOperation_2166136261() { }

	// RVA: 0x9FE150 Offset: 0x9FCB50 VA: 0x1809FE150
	private void RpcReader___Observers_FinishCookOperation_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FFB10 Offset: 0x9FE510 VA: 0x1809FFB10
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x9FDC90 Offset: 0x9FC690 VA: 0x1809FDC90 Slot: 137
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x9FE7E0 Offset: 0x9FD1E0 VA: 0x1809FE7E0
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FF9E0 Offset: 0x9FE3E0 VA: 0x1809FF9E0
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x9FDBF0 Offset: 0x9FC5F0 VA: 0x1809FDBF0 Slot: 138
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x9FE760 Offset: 0x9FD160 VA: 0x1809FE760
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FFF40 Offset: 0x9FE940 VA: 0x1809FFF40
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9FDF60 Offset: 0x9FC960 VA: 0x1809FDF60 Slot: 139
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9FEAA0 Offset: 0x9FD4A0 VA: 0x1809FEAA0
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FF2D0 Offset: 0x9FDCD0 VA: 0x1809FF2D0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9FDFE0 Offset: 0x9FC9E0 VA: 0x1809FDFE0
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9FE490 Offset: 0x9FCE90 VA: 0x1809FE490
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA003B0 Offset: 0x9FEDB0 VA: 0x180A003B0
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9FED10 Offset: 0x9FD710 VA: 0x1809FED10
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FF860 Offset: 0x9FE260 VA: 0x1809FF860
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9FDB60 Offset: 0x9FC560 VA: 0x1809FDB60 Slot: 140
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9FE6B0 Offset: 0x9FD0B0 VA: 0x1809FE6B0
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FEE30 Offset: 0x9FD830 VA: 0x1809FEE30
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9FDB70 Offset: 0x9FC570 VA: 0x1809FDB70
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9FE270 Offset: 0x9FCC70 VA: 0x1809FE270
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FFDB0 Offset: 0x9FE7B0 VA: 0x1809FFDB0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9FDE30 Offset: 0x9FC830 VA: 0x1809FDE30 Slot: 141
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9FE950 Offset: 0x9FD350 VA: 0x1809FE950
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA00220 Offset: 0x9FEC20 VA: 0x180A00220
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9FDEB0 Offset: 0x9FC8B0 VA: 0x1809FDEB0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9FEC20 Offset: 0x9FD620 VA: 0x1809FEC20
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FF130 Offset: 0x9FDB30 VA: 0x1809FF130
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9FE3A0 Offset: 0x9FCDA0 VA: 0x1809FE3A0
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9FFC40 Offset: 0x9FE640 VA: 0x1809FFC40
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FDD30 Offset: 0x9FC730 VA: 0x1809FDD30 Slot: 142
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FE860 Offset: 0x9FD260 VA: 0x1809FE860
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9FEFB0 Offset: 0x9FD9B0 VA: 0x1809FEFB0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FDDB0 Offset: 0x9FC7B0 VA: 0x1809FDDB0
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FE310 Offset: 0x9FCD10 VA: 0x1809FE310
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA000B0 Offset: 0x9FEAB0 VA: 0x180A000B0
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9FEB90 Offset: 0x9FD590 VA: 0x1809FEB90
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA02690 Offset: 0xA01090 VA: 0x180A02690
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA02950 Offset: 0xA01350 VA: 0x180A02950
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x9FD5F0 Offset: 0x9FBFF0 VA: 0x1809FD5F0 Slot: 143
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.Cauldron(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xA026B0 Offset: 0xA010B0 VA: 0x180A026B0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA02A10 Offset: 0xA01410 VA: 0x180A02A10
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA02890 Offset: 0xA01290 VA: 0x180A02890
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x9F9CB0 Offset: 0x9F86B0 VA: 0x1809F9CB0 Slot: 144
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.Cauldron_Assembly-CSharp.dll() { }
}
