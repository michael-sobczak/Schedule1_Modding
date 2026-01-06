public class ChemistryStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3243
{
	// Fields
	public const float FOV_OVERRIDE = 65;
	public const int INPUT_SLOT_COUNT = 3;
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x210
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x218
	[HideInInspector]
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x220
	[CompilerGenerated]
	private ChemistryCookOperation <CurrentCookOperation>k__BackingField; // 0x228
	public ItemSlot[] IngredientSlots; // 0x230
	public ItemSlot OutputSlot; // 0x238
	[Header("References")]
	public InteractableObject IntObj; // 0x240
	public Transform CameraPosition_Default; // 0x248
	public Transform CameraPosition_Stirring; // 0x250
	public Transform StaticBeaker; // 0x258
	public Transform StaticFunnel; // 0x260
	public Transform StaticStirringRod; // 0x268
	public Transform ItemContainer; // 0x270
	public LabStand LabStand; // 0x278
	public StorageVisualizer InputVisuals; // 0x280
	public StorageVisualizer OutputVisuals; // 0x288
	public Rigidbody AnchorRb; // 0x290
	public BunsenBurner Burner; // 0x298
	public BoilingFlask BoilingFlask; // 0x2A0
	public DigitalAlarm Alarm; // 0x2A8
	public Transform uiPoint; // 0x2B0
	public Transform[] accessPoints; // 0x2B8
	public ConfigurationReplicator configReplicator; // 0x2C0
	public BoxCollider TrashSpawnVolume; // 0x2C8
	public Transform ExplosionPoint; // 0x2D0
	[Header("Slot Display Points")]
	public Transform InputSlotsPosition; // 0x2D8
	public Transform OutputSlotPosition; // 0x2E0
	[Header("Transforms")]
	public Transform[] IngredientTransforms; // 0x2E8
	public Transform BeakerAlignmentTransform; // 0x2F0
	[Header("Prefabs")]
	public GameObject BeakerPrefab; // 0x2F8
	public StirringRod StirringRodPrefab; // 0x300
	[Header("UI")]
	public ChemistryStationUIElement WorldspaceUIPrefab; // 0x308
	public Sprite typeIcon; // 0x310
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x318
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x320
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x328
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x329
	[CompilerGenerated]
	private ChemistryStationConfiguration <stationConfiguration>k__BackingField; // 0x330
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x338
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x340
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x348
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x350
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x358
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted; // 0x360
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted; // 0x361

	// Properties
	public bool isOpen { get; }
	public List<ItemSlot> ItemSlots { get; set; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public ChemistryCookOperation CurrentCookOperation { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public EntityConfiguration Configuration { get; }
	protected ChemistryStationConfiguration stationConfiguration { get; set; }
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

	// RVA: 0xA0ADB0 Offset: 0xA097B0 VA: 0x180A0ADB0
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA068E0 Offset: 0xA052E0 VA: 0x180A068E0 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA06980 Offset: 0xA05380 VA: 0x180A06980 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public ChemistryCookOperation get_CurrentCookOperation() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	public void set_CurrentCookOperation(ChemistryCookOperation value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x6DFAB0 Offset: 0x6DE4B0 VA: 0x1806DFAB0 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x6DFA20 Offset: 0x6DE420 VA: 0x1806DFA20 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x6DFA90 Offset: 0x6DE490 VA: 0x1806DFA90 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x6DFA60 Offset: 0x6DE460 VA: 0x1806DFA60 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA0AD90 Offset: 0xA09790 VA: 0x180A0AD90 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA0AE60 Offset: 0xA09860 VA: 0x180A0AE60
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0xA0AD80 Offset: 0xA09780 VA: 0x180A0AD80 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0xA0AD80 Offset: 0xA09780 VA: 0x180A0AD80
	protected ChemistryStationConfiguration get_stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0xA0AE90 Offset: 0xA09890 VA: 0x180A0AE90
	protected void set_stationConfiguration(ChemistryStationConfiguration value) { }

	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0xA0ADA0 Offset: 0xA097A0 VA: 0x180A0ADA0 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0xA0AE70 Offset: 0xA09870 VA: 0x180A0AE70 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0xA02690 Offset: 0xA01090 VA: 0x180A02690 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA06610 Offset: 0xA05010 VA: 0x180A06610 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA09380 Offset: 0xA07D80 VA: 0x180A09380 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	// RVA: 0xA031E0 Offset: 0xA01BE0 VA: 0x180A031E0 Slot: 47
	public override void Awake() { }

	// RVA: 0xA04CA0 Offset: 0xA036A0 VA: 0x180A04CA0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA04A50 Offset: 0xA03450 VA: 0x180A04A50 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA05BB0 Offset: 0xA045B0 VA: 0x180A05BB0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA090F0 Offset: 0xA07AF0 VA: 0x180A090F0 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA03230 Offset: 0xA01C30 VA: 0x180A03230 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA040C0 Offset: 0xA02AC0 VA: 0x180A040C0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA05090 Offset: 0xA03A90 VA: 0x180A05090 Slot: 136
	protected virtual void MinPass() { }

	// RVA: 0xA0AA60 Offset: 0xA09460 VA: 0x180A0AA60
	private void TimeSkipped(int minsSkippped) { }

	// RVA: 0xA0AAC0 Offset: 0xA094C0 VA: 0x180A0AAC0
	private void UpdateClock() { }

	// RVA: 0xA0AC10 Offset: 0xA09610 VA: 0x180A0AC10 Slot: 137
	protected virtual void Update() { }

	// RVA: 0xA03680 Offset: 0xA02080 VA: 0x180A03680
	public Beaker CreateBeaker() { }

	// RVA: 0xA037F0 Offset: 0xA021F0 VA: 0x180A037F0
	public StirringRod CreateStirringRod() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA09250 Offset: 0xA07C50 VA: 0x180A09250
	public void SendCookOperation(ChemistryCookOperation op) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA094B0 Offset: 0xA07EB0 VA: 0x180A094B0
	public void SetCookOperation(NetworkConnection conn, ChemistryCookOperation operation) { }

	[ObserversRpc]
	// RVA: 0xA04550 Offset: 0xA02F50 VA: 0x180A04550
	public void FinalizeOperation() { }

	// RVA: 0xA06300 Offset: 0xA04D00 VA: 0x180A06300
	public void ResetStation() { }

	// RVA: 0xA043F0 Offset: 0xA02DF0 VA: 0x180A043F0
	public bool DoesOutputHaveSpace(StationRecipe recipe) { }

	// RVA: 0xA04970 Offset: 0xA03370 VA: 0x180A04970
	public List<ItemInstance> GetIngredients() { }

	// RVA: 0xA04B30 Offset: 0xA03530 VA: 0x180A04B30
	public bool HasIngredientsForRecipe(StationRecipe recipe) { }

	// RVA: 0xA03970 Offset: 0xA02370 VA: 0x180A03970
	public void CreateTrash(List<StationItem> mixerItems) { }

	// RVA: 0xA04B60 Offset: 0xA03560 VA: 0x180A04B60
	public void Hovered() { }

	// RVA: 0xA04FE0 Offset: 0xA039E0 VA: 0x180A04FE0
	public void Interacted() { }

	// RVA: 0xA04460 Offset: 0xA02E60 VA: 0x180A04460
	private void Exit(ExitAction action) { }

	// RVA: 0xA05D70 Offset: 0xA04770 VA: 0x180A05D70
	public void Open() { }

	// RVA: 0xA03330 Offset: 0xA01D30 VA: 0x180A03330
	public void Close() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA09B60 Offset: 0xA08560 VA: 0x180A09B60 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA09A30 Offset: 0xA08430 VA: 0x180A09A30 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA0A8C0 Offset: 0xA092C0 VA: 0x180A0A8C0 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA0A600 Offset: 0xA09000 VA: 0x180A0A600
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA098C0 Offset: 0xA082C0 VA: 0x180A098C0 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA09710 Offset: 0xA08110 VA: 0x180A09710
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA0A410 Offset: 0xA08E10 VA: 0x180A0A410 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA0A0F0 Offset: 0xA08AF0 VA: 0x180A0A0F0
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA09F50 Offset: 0xA08950 VA: 0x180A09F50 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA09C90 Offset: 0xA08690 VA: 0x180A09C90
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA03E10 Offset: 0xA02810 VA: 0x180A03E10 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA04030 Offset: 0xA02A30 VA: 0x180A04030 Slot: 129
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA04670 Offset: 0xA03070 VA: 0x180A04670 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA04A80 Offset: 0xA03480 VA: 0x180A04A80 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA0AC90 Offset: 0xA09690 VA: 0x180A0AC90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__98_0() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__98_1() { }

	// RVA: 0xA05450 Offset: 0xA03E50 VA: 0x180A05450 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA053C0 Offset: 0xA03DC0 VA: 0x180A053C0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA081A0 Offset: 0xA06BA0 VA: 0x180A081A0
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA06610 Offset: 0xA05010 VA: 0x180A06610 Slot: 138
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA07140 Offset: 0xA05B40 VA: 0x180A07140
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA08070 Offset: 0xA06A70 VA: 0x180A08070
	private void RpcWriter___Server_SendCookOperation_3552222198(ChemistryCookOperation op) { }

	// RVA: 0xA06600 Offset: 0xA05000 VA: 0x180A06600
	public void RpcLogic___SendCookOperation_3552222198(ChemistryCookOperation op) { }

	// RVA: 0xA070D0 Offset: 0xA05AD0 VA: 0x180A070D0
	private void RpcReader___Server_SendCookOperation_3552222198(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA07910 Offset: 0xA06310 VA: 0x180A07910
	private void RpcWriter___Observers_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation) { }

	// RVA: 0xA066B0 Offset: 0xA050B0 VA: 0x180A066B0
	public void RpcLogic___SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation) { }

	// RVA: 0xA06DC0 Offset: 0xA057C0 VA: 0x180A06DC0
	private void RpcReader___Observers_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA08B20 Offset: 0xA07520 VA: 0x180A08B20
	private void RpcWriter___Target_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation) { }

	// RVA: 0xA076A0 Offset: 0xA060A0 VA: 0x180A076A0
	private void RpcReader___Target_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA04550 Offset: 0xA02F50 VA: 0x180A04550
	private void RpcWriter___Observers_FinalizeOperation_2166136261() { }

	// RVA: 0xA063B0 Offset: 0xA04DB0 VA: 0x180A063B0
	public void RpcLogic___FinalizeOperation_2166136261() { }

	// RVA: 0xA06D90 Offset: 0xA05790 VA: 0x180A06D90
	private void RpcReader___Observers_FinalizeOperation_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA08580 Offset: 0xA06F80 VA: 0x180A08580
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA06980 Offset: 0xA05380 VA: 0x180A06980 Slot: 139
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA072F0 Offset: 0xA05CF0 VA: 0x180A072F0
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA08450 Offset: 0xA06E50 VA: 0x180A08450
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA068E0 Offset: 0xA052E0 VA: 0x180A068E0 Slot: 140
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA07270 Offset: 0xA05C70 VA: 0x180A07270
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA089B0 Offset: 0xA073B0 VA: 0x180A089B0
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA06C50 Offset: 0xA05650 VA: 0x180A06C50 Slot: 141
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA075B0 Offset: 0xA05FB0 VA: 0x180A075B0
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA07EF0 Offset: 0xA068F0 VA: 0x180A07EF0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA06CD0 Offset: 0xA056D0 VA: 0x180A06CD0
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA07040 Offset: 0xA05A40 VA: 0x180A07040
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA08F80 Offset: 0xA07980 VA: 0x180A08F80
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA07880 Offset: 0xA06280 VA: 0x180A07880
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA082D0 Offset: 0xA06CD0 VA: 0x180A082D0
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA06850 Offset: 0xA05250 VA: 0x180A06850 Slot: 142
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA071C0 Offset: 0xA05BC0 VA: 0x180A071C0
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA07A50 Offset: 0xA06450 VA: 0x180A07A50
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA06860 Offset: 0xA05260 VA: 0x180A06860
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA06E20 Offset: 0xA05820 VA: 0x180A06E20
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA08820 Offset: 0xA07220 VA: 0x180A08820
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA06B20 Offset: 0xA05520 VA: 0x180A06B20 Slot: 143
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA07460 Offset: 0xA05E60 VA: 0x180A07460
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA08DF0 Offset: 0xA077F0 VA: 0x180A08DF0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA06BA0 Offset: 0xA055A0 VA: 0x180A06BA0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA07790 Offset: 0xA06190 VA: 0x180A07790
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA07D50 Offset: 0xA06750 VA: 0x180A07D50
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA06F50 Offset: 0xA05950 VA: 0x180A06F50
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA086B0 Offset: 0xA070B0 VA: 0x180A086B0
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA06A20 Offset: 0xA05420 VA: 0x180A06A20 Slot: 144
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA07370 Offset: 0xA05D70 VA: 0x180A07370
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA07BD0 Offset: 0xA065D0 VA: 0x180A07BD0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA06AA0 Offset: 0xA054A0 VA: 0x180A06AA0
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA06EC0 Offset: 0xA058C0 VA: 0x180A06EC0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA08C80 Offset: 0xA07680 VA: 0x180A08C80
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA07700 Offset: 0xA06100 VA: 0x180A07700
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA0AF70 Offset: 0xA09970 VA: 0x180A0AF70
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA06160 Offset: 0xA04B60 VA: 0x180A06160 Slot: 145
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.ChemistryStation(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA0B030 Offset: 0xA09A30 VA: 0x180A0B030
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA02690 Offset: 0xA01090 VA: 0x180A02690
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA0AEB0 Offset: 0xA098B0 VA: 0x180A0AEB0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA02D60 Offset: 0xA01760 VA: 0x180A02D60 Slot: 146
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.ChemistryStation_Assembly-CSharp.dll() { }
}
