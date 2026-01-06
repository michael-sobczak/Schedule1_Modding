public class LabOven : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3256
{
	// Fields
	public const int SOLID_INGREDIENT_COOK_LIMIT = 10;
	public const float FOV_OVERRIDE = 70;
	[CompilerGenerated]
	private OvenCookOperation <CurrentOperation>k__BackingField; // 0x210
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x218
	public LabOven.ELightMode LightMode; // 0x220
	[Header("References")]
	public Transform CameraPosition_Default; // 0x228
	public Transform CameraPosition_Pour; // 0x230
	public Transform CameraPosition_PlaceItems; // 0x238
	public Transform CameraPosition_Breaking; // 0x240
	public InteractableObject IntObj; // 0x248
	public LabOvenDoor Door; // 0x250
	public LabOvenWireTray WireTray; // 0x258
	public ToggleableLight OvenLight; // 0x260
	public LabOvenButton Button; // 0x268
	public TextMeshPro TimerLabel; // 0x270
	public ToggleableLight Light; // 0x278
	public Transform PourableContainer; // 0x280
	public Transform ItemContainer; // 0x288
	public Animation PourAnimation; // 0x290
	public SkinnedMeshRenderer LiquidMesh; // 0x298
	public StorageVisualizer InputVisuals; // 0x2A0
	public StorageVisualizer OutputVisuals; // 0x2A8
	public MeshRenderer CookedLiquidMesh; // 0x2B0
	public Animation RemoveTrayAnimation; // 0x2B8
	public Transform SquareTray; // 0x2C0
	public Transform HammerSpawnPoint; // 0x2C8
	public Transform HammerContainer; // 0x2D0
	public Transform OafBastard; // 0x2D8
	public Transform DecalContainer; // 0x2E0
	public Transform DecalMaxBounds; // 0x2E8
	public Transform DecalMinBounds; // 0x2F0
	public BoxCollider CookedLiquidCollider; // 0x2F8
	public Transform[] ShardSpawnPoints; // 0x300
	public ParticleSystem ShatterParticles; // 0x308
	public Transform uiPoint; // 0x310
	public Transform[] accessPoints; // 0x318
	public ConfigurationReplicator configReplicator; // 0x320
	public Transform[] SolidIngredientSpawnPoints; // 0x328
	public BoxCollider TrayDetectionArea; // 0x330
	[Header("Sounds")]
	public AudioSourceController ButtonSound; // 0x338
	public AudioSourceController DingSound; // 0x340
	public AudioSourceController RunLoopSound; // 0x348
	public AudioSourceController ImpactSound; // 0x350
	public AudioSourceController ShatterSound; // 0x358
	[Header("UI")]
	public LabOvenUIElement WorldspaceUIPrefab; // 0x360
	public Sprite typeIcon; // 0x368
	[Header("Prefabs")]
	public LabOvenHammer HammerPrefab; // 0x370
	public GameObject SmashDecalPrefab; // 0x378
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	[CompilerGenerated]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x380
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	[HideInInspector]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x388
	public ItemSlot IngredientSlot; // 0x390
	public ItemSlot OutputSlot; // 0x398
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x3A0
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x3A8
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x3B0
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x3B1
	[CompilerGenerated]
	private LabOvenConfiguration <ovenConfiguration>k__BackingField; // 0x3B8
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3C0
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3C8
	private Vector3 pourableContainerDefaultPos; // 0x3D0
	private Quaternion pourableContainerDefaultRot; // 0x3DC
	private Vector3 squareTrayDefaultPos; // 0x3EC
	private Quaternion squareTrayDefaultRot; // 0x3F8
	private List<GameObject> decals; // 0x408
	private List<GameObject> shards; // 0x410
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x418
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x420
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x428
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted; // 0x430
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted; // 0x431

	// Properties
	public bool isOpen { get; }
	public OvenCookOperation CurrentOperation { get; set; }
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
	protected LabOvenConfiguration ovenConfiguration { get; set; }
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

	// RVA: 0xA20A90 Offset: 0xA1F490 VA: 0x180A20A90
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public OvenCookOperation get_CurrentOperation() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	private void set_CurrentOperation(OvenCookOperation value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA1B830 Offset: 0xA1A230 VA: 0x180A1B830 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA1B8D0 Offset: 0xA1A2D0 VA: 0x180A1B8D0 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0xA20A60 Offset: 0xA1F460 VA: 0x180A20A60 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA20BA0 Offset: 0xA1F5A0 VA: 0x180A20BA0 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x6AA7A0 Offset: 0x6A91A0 VA: 0x1806AA7A0 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0xA20BD0 Offset: 0xA1F5D0 VA: 0x180A20BD0 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0xA20A80 Offset: 0xA1F480 VA: 0x180A20A80 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA20A70 Offset: 0xA1F470 VA: 0x180A20A70 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA20BC0 Offset: 0xA1F5C0 VA: 0x180A20BC0
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170
	protected LabOvenConfiguration get_ovenConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x6CD1A0 Offset: 0x6CBBA0 VA: 0x1806CD1A0
	protected void set_ovenConfiguration(LabOvenConfiguration value) { }

	// RVA: 0x6DFA20 Offset: 0x6DE420 VA: 0x1806DFA20 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6CD180 Offset: 0x6CBB80 VA: 0x1806CD180 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA1B520 Offset: 0xA19F20 VA: 0x180A1B520 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA1E380 Offset: 0xA1CD80 VA: 0x180A1E380 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0xA02650 Offset: 0xA01050 VA: 0x180A02650 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	// RVA: 0xA17FB0 Offset: 0xA169B0 VA: 0x180A17FB0 Slot: 47
	public override void Awake() { }

	// RVA: 0xA19D80 Offset: 0xA18780 VA: 0x180A19D80 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA19B60 Offset: 0xA18560 VA: 0x180A19B60 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA1AC80 Offset: 0xA19680 VA: 0x180A1AC80 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA1E0E0 Offset: 0xA1CAE0 VA: 0x180A1E0E0 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA20700 Offset: 0xA1F100 VA: 0x180A20700
	private void Update() { }

	// RVA: 0xA1A3F0 Offset: 0xA18DF0 VA: 0x180A1A3F0
	private void MinPass() { }

	// RVA: 0xA20070 Offset: 0xA1EA70 VA: 0x180A20070
	private void TimeSkipped(int minsSkippped) { }

	// RVA: 0xA20270 Offset: 0xA1EC70 VA: 0x180A20270
	private void UpdateOvenAppearance() { }

	// RVA: 0xA196F0 Offset: 0xA180F0 VA: 0x180A196F0
	private void Exit(ExitAction action) { }

	// RVA: 0xA18000 Offset: 0xA16A00 VA: 0x180A18000 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA193B0 Offset: 0xA17DB0 VA: 0x180A193B0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA1EBF0 Offset: 0xA1D5F0 VA: 0x180A1EBF0
	public void SetOvenLit(bool lit) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA1EC40 Offset: 0xA1D640 VA: 0x180A1EC40 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA1EAC0 Offset: 0xA1D4C0 VA: 0x180A1EAC0 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA19C40 Offset: 0xA18640 VA: 0x180A19C40
	public void Hovered() { }

	// RVA: 0xA1A0C0 Offset: 0xA18AC0 VA: 0x180A1A0C0
	public void Interacted() { }

	// RVA: 0xA1AE40 Offset: 0xA19840 VA: 0x180A1AE40
	public void Open() { }

	// RVA: 0xA18450 Offset: 0xA16E50 VA: 0x180A18450
	public void Close() { }

	// RVA: 0xA1A170 Offset: 0xA18B70 VA: 0x180A1A170
	public bool IsIngredientCookable() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA1E240 Offset: 0xA1CC40 VA: 0x180A1E240
	public void SendCookOperation(OvenCookOperation operation) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA1E4B0 Offset: 0xA1CEB0 VA: 0x180A1E4B0
	public void SetCookOperation(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress) { }

	// RVA: 0xA1A2B0 Offset: 0xA18CB0 VA: 0x180A1A2B0
	public bool IsReadyToStart() { }

	// RVA: 0xA1A270 Offset: 0xA18C70 VA: 0x180A1A270
	public bool IsReadyForHarvest() { }

	// RVA: 0xA18100 Offset: 0xA16B00 VA: 0x180A18100
	public bool CanOutputSpaceFitCurrentOperation() { }

	// RVA: 0xA1EA70 Offset: 0xA1D470 VA: 0x180A1EA70
	public void SetLiquidColor(Color col) { }

	// RVA: 0xA20190 Offset: 0xA1EB90 VA: 0x180A20190
	private void UpdateLiquid() { }

	// RVA: 0xA18C30 Offset: 0xA17630 VA: 0x180A18C30
	public StationItem[] CreateStationItems(int quantity = 1) { }

	// RVA: 0xA1B3E0 Offset: 0xA19DE0 VA: 0x180A1B3E0
	public void ResetPourableContainer() { }

	// RVA: 0xA1B450 Offset: 0xA19E50 VA: 0x180A1B450
	public void ResetSquareTray() { }

	// RVA: 0xA187A0 Offset: 0xA171A0 VA: 0x180A187A0
	public LabOvenHammer CreateHammer() { }

	// RVA: 0xA18930 Offset: 0xA17330 VA: 0x180A18930
	public void CreateImpactEffects(Vector3 point, bool playSound = True) { }

	// RVA: 0xA1FB40 Offset: 0xA1E540 VA: 0x180A1FB40
	public void Shatter(int shardQuantity, GameObject shardPrefab) { }

	// RVA: 0xA18330 Offset: 0xA16D30 VA: 0x180A18330
	public void ClearShards() { }

	// RVA: 0xA18230 Offset: 0xA16C30 VA: 0x180A18230
	public void ClearDecals() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA1F9A0 Offset: 0xA1E3A0 VA: 0x180A1F9A0 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA1F6E0 Offset: 0xA1E0E0 VA: 0x180A1F6E0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA1E900 Offset: 0xA1D300 VA: 0x180A1E900 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA1E750 Offset: 0xA1D150 VA: 0x180A1E750
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA1F4F0 Offset: 0xA1DEF0 VA: 0x180A1F4F0 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA1F1D0 Offset: 0xA1DBD0 VA: 0x180A1F1D0
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA1F030 Offset: 0xA1DA30 VA: 0x180A1F030 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA1ED70 Offset: 0xA1D770 VA: 0x180A1ED70
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA190F0 Offset: 0xA17AF0 VA: 0x180A190F0 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA19320 Offset: 0xA17D20 VA: 0x180A19320 Slot: 129
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA19840 Offset: 0xA18240 VA: 0x180A19840 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA19B90 Offset: 0xA18590 VA: 0x180A19B90 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA208F0 Offset: 0xA1F2F0 VA: 0x180A208F0
	public void .ctor() { }

	// RVA: 0xA1A560 Offset: 0xA18F60 VA: 0x180A1A560 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA1A4D0 Offset: 0xA18ED0 VA: 0x180A1A4D0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA1D190 Offset: 0xA1BB90 VA: 0x180A1D190
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA1B520 Offset: 0xA19F20 VA: 0x180A1B520 Slot: 136
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA1C0C0 Offset: 0xA1AAC0 VA: 0x180A1C0C0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1D570 Offset: 0xA1BF70 VA: 0x180A1D570
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA1B8D0 Offset: 0xA1A2D0 VA: 0x180A1B8D0 Slot: 137
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA1C270 Offset: 0xA1AC70 VA: 0x180A1C270
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1D440 Offset: 0xA1BE40 VA: 0x180A1D440
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA1B830 Offset: 0xA1A230 VA: 0x180A1B830 Slot: 138
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA1C1F0 Offset: 0xA1ABF0 VA: 0x180A1C1F0
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1D060 Offset: 0xA1BA60 VA: 0x180A1D060
	private void RpcWriter___Server_SendCookOperation_3708012700(OvenCookOperation operation) { }

	// RVA: 0xA1B500 Offset: 0xA19F00 VA: 0x180A1B500
	public void RpcLogic___SendCookOperation_3708012700(OvenCookOperation operation) { }

	// RVA: 0xA1C040 Offset: 0xA1AA40 VA: 0x180A1C040
	private void RpcReader___Server_SendCookOperation_3708012700(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1C8D0 Offset: 0xA1B2D0 VA: 0x180A1C8D0
	private void RpcWriter___Observers_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress) { }

	// RVA: 0xA1B5C0 Offset: 0xA19FC0 VA: 0x180A1B5C0
	public void RpcLogic___SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress) { }

	// RVA: 0xA1BCE0 Offset: 0xA1A6E0 VA: 0x180A1BCE0
	private void RpcReader___Observers_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1DB10 Offset: 0xA1C510 VA: 0x180A1DB10
	private void RpcWriter___Target_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress) { }

	// RVA: 0xA1C620 Offset: 0xA1B020 VA: 0x180A1C620
	private void RpcReader___Target_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1D9A0 Offset: 0xA1C3A0 VA: 0x180A1D9A0
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA1BBA0 Offset: 0xA1A5A0 VA: 0x180A1BBA0 Slot: 139
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA1C530 Offset: 0xA1AF30 VA: 0x180A1C530
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1CEE0 Offset: 0xA1B8E0 VA: 0x180A1CEE0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA1BC20 Offset: 0xA1A620 VA: 0x180A1BC20
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA1BFB0 Offset: 0xA1A9B0 VA: 0x180A1BFB0
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1DF70 Offset: 0xA1C970 VA: 0x180A1DF70
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA1C840 Offset: 0xA1B240 VA: 0x180A1C840
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1D2C0 Offset: 0xA1BCC0 VA: 0x180A1D2C0
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA1B7A0 Offset: 0xA1A1A0 VA: 0x180A1B7A0 Slot: 140
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA1C140 Offset: 0xA1AB40 VA: 0x180A1C140
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1CA40 Offset: 0xA1B440 VA: 0x180A1CA40
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA1B7B0 Offset: 0xA1A1B0 VA: 0x180A1B7B0
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA1BD90 Offset: 0xA1A790 VA: 0x180A1BD90
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1D810 Offset: 0xA1C210 VA: 0x180A1D810
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA1BA70 Offset: 0xA1A470 VA: 0x180A1BA70 Slot: 141
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA1C3E0 Offset: 0xA1ADE0 VA: 0x180A1C3E0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1DDE0 Offset: 0xA1C7E0 VA: 0x180A1DDE0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA1BAF0 Offset: 0xA1A4F0 VA: 0x180A1BAF0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA1C750 Offset: 0xA1B150 VA: 0x180A1C750
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1CD40 Offset: 0xA1B740 VA: 0x180A1CD40
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA1BEC0 Offset: 0xA1A8C0 VA: 0x180A1BEC0
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1D6A0 Offset: 0xA1C0A0 VA: 0x180A1D6A0
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA1B970 Offset: 0xA1A370 VA: 0x180A1B970 Slot: 142
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA1C2F0 Offset: 0xA1ACF0 VA: 0x180A1C2F0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA1CBC0 Offset: 0xA1B5C0 VA: 0x180A1CBC0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA1B9F0 Offset: 0xA1A3F0 VA: 0x180A1B9F0
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA1BE30 Offset: 0xA1A830 VA: 0x180A1BE30
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA1DC70 Offset: 0xA1C670 VA: 0x180A1DC70
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA1C6C0 Offset: 0xA1B0C0 VA: 0x180A1C6C0
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA20CB0 Offset: 0xA1F6B0 VA: 0x180A20CB0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA1B240 Offset: 0xA19C40 VA: 0x180A1B240 Slot: 143
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.LabOven(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA20D70 Offset: 0xA1F770 VA: 0x180A20D70
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA20BF0 Offset: 0xA1F5F0 VA: 0x180A20BF0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA17D50 Offset: 0xA16750 VA: 0x180A17D50 Slot: 144
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.LabOven_Assembly-CSharp.dll() { }
}
