public class MushroomSpawnStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 2430
{
	// Fields
	[SerializeField]
	private Transform _uiPoint; // 0x210
	[SerializeField]
	private Transform[] _accessPoints; // 0x218
	[SerializeField]
	private ItemDefinition _grainBagDefinition; // 0x220
	[SerializeField]
	private SporeSyringeDefinition[] _validSporeSyringeDefinitions; // 0x228
	[SerializeField]
	private StorageVisualizer _grainBagVisualizer; // 0x230
	[SerializeField]
	private StorageVisualizer _syringeVisualizer; // 0x238
	[SerializeField]
	private StorageVisualizer _outputVisualizer; // 0x240
	[SerializeField]
	private ConfigurationReplicator _configReplicator; // 0x248
	[SerializeField]
	private Sprite _typeIcon; // 0x250
	[SerializeField]
	private WorldspaceUIElement _worldspaceUIPrefab; // 0x258
	[SerializeField]
	[CompilerGenerated]
	private Transform <CameraTransform>k__BackingField; // 0x260
	[CompilerGenerated]
	[SerializeField]
	private Transform <TaskCameraTransform>k__BackingField; // 0x268
	[SerializeField]
	[CompilerGenerated]
	private Transform <TaskContainer>k__BackingField; // 0x270
	[SerializeField]
	[CompilerGenerated]
	private Transform <SyringeStartTransform>k__BackingField; // 0x278
	[CompilerGenerated]
	[SerializeField]
	private Transform <GrainBagStartTransform>k__BackingField; // 0x280
	[SerializeField]
	private UnityEvent onUse; // 0x288
	[SerializeField]
	private UnityEvent onUseEnded; // 0x290
	[CompilerGenerated]
	private ItemSlot <GrainBagSlot>k__BackingField; // 0x298
	[CompilerGenerated]
	private ItemSlot <SyringeSlot>k__BackingField; // 0x2A0
	[CompilerGenerated]
	private ItemSlot <OutputSlot>k__BackingField; // 0x2A8
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x2B0
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x2B8
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x2C0
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x2C8
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x2D0
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x2D8
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x2D9
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x2E0
	[HideInInspector]
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x2E8
	[CompilerGenerated]
	private SpawnStationConfiguration <_stationConfiguration>k__BackingField; // 0x2F0
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x2F8
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x300
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x308
	private bool NetworkInitialize___EarlyScheduleOne.StationFramework.MushroomSpawnStationAssembly-CSharp.dll_Excuted; // 0x310
	private bool NetworkInitialize__LateScheduleOne.StationFramework.MushroomSpawnStationAssembly-CSharp.dll_Excuted; // 0x311

	// Properties
	public Transform CameraTransform { get; set; }
	public Transform TaskCameraTransform { get; set; }
	public Transform TaskContainer { get; set; }
	public Transform SyringeStartTransform { get; set; }
	public Transform GrainBagStartTransform { get; set; }
	public ItemSlot GrainBagSlot { get; set; }
	public ItemSlot SyringeSlot { get; set; }
	public ItemSlot OutputSlot { get; set; }
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
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	private SpawnStationConfiguration _stationConfiguration { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0
	public Transform get_CameraTransform() { }

	[CompilerGenerated]
	// RVA: 0x718C10 Offset: 0x717610 VA: 0x180718C10
	private void set_CameraTransform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70
	public Transform get_TaskCameraTransform() { }

	[CompilerGenerated]
	// RVA: 0x860CA0 Offset: 0x85F6A0 VA: 0x180860CA0
	private void set_TaskCameraTransform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0
	public Transform get_TaskContainer() { }

	[CompilerGenerated]
	// RVA: 0x718BB0 Offset: 0x7175B0 VA: 0x180718BB0
	private void set_TaskContainer(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50
	public Transform get_SyringeStartTransform() { }

	[CompilerGenerated]
	// RVA: 0x641370 Offset: 0x63FD70 VA: 0x180641370
	private void set_SyringeStartTransform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10
	public Transform get_GrainBagStartTransform() { }

	[CompilerGenerated]
	// RVA: 0x6415F0 Offset: 0x63FFF0 VA: 0x1806415F0
	private void set_GrainBagStartTransform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x8793C0 Offset: 0x877DC0 VA: 0x1808793C0
	public ItemSlot get_GrainBagSlot() { }

	[CompilerGenerated]
	// RVA: 0x879420 Offset: 0x877E20 VA: 0x180879420
	private void set_GrainBagSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x718C70 Offset: 0x717670 VA: 0x180718C70
	public ItemSlot get_SyringeSlot() { }

	[CompilerGenerated]
	// RVA: 0x8795B0 Offset: 0x877FB0 VA: 0x1808795B0
	private void set_SyringeSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x879400 Offset: 0x877E00 VA: 0x180879400
	public ItemSlot get_OutputSlot() { }

	[CompilerGenerated]
	// RVA: 0x8794F0 Offset: 0x877EF0 VA: 0x1808794F0
	private void set_OutputSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x860B80 Offset: 0x85F580 VA: 0x180860B80 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0x879450 Offset: 0x877E50 VA: 0x180879450 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0x879510 Offset: 0x877F10 VA: 0x180879510 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x640C40 Offset: 0x63F640 VA: 0x180640C40 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x641330 Offset: 0x63FD30 VA: 0x180641330 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x81F940 Offset: 0x81E340 VA: 0x18081F940 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x879410 Offset: 0x877E10 VA: 0x180879410 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x8793D0 Offset: 0x877DD0 VA: 0x1808793D0 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x879440 Offset: 0x877E40 VA: 0x180879440
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40 Slot: 114
	public EntityConfiguration get_Configuration() { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x640F20 Offset: 0x63F920 VA: 0x180640F20 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x8795D0 Offset: 0x877FD0 VA: 0x1808795D0 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x640F30 Offset: 0x63F930 VA: 0x180640F30 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0x8755E0 Offset: 0x873FE0 VA: 0x1808755E0 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	[CompilerGenerated]
	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40
	private SpawnStationConfiguration get__stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x641630 Offset: 0x640030 VA: 0x180641630
	private void set__stationConfiguration(SpawnStationConfiguration value) { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }

	// RVA: 0x874410 Offset: 0x872E10 VA: 0x180874410 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x874330 Offset: 0x872D30 VA: 0x180874330 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0x8752D0 Offset: 0x873CD0 VA: 0x1808752D0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x873F80 Offset: 0x872980 VA: 0x180873F80 Slot: 56
	protected override void Destroy() { }

	// RVA: 0x873B90 Offset: 0x872590 VA: 0x180873B90 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x8790C0 Offset: 0x877AC0 VA: 0x1808790C0
	public void Use() { }

	// RVA: 0x875120 Offset: 0x873B20 VA: 0x180875120
	private void OnInterfaceExited() { }

	// RVA: 0x874050 Offset: 0x872A50 VA: 0x180874050
	public bool DoesStationContainRequiredItems() { }

	// RVA: 0x8740A0 Offset: 0x872AA0 VA: 0x1808740A0
	public bool DoesStationHaveOutputSpace() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8781C0 Offset: 0x876BC0 VA: 0x1808781C0 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x878090 Offset: 0x876A90 VA: 0x180878090 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x877C40 Offset: 0x876640 VA: 0x180877C40 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x877B30 Offset: 0x876530 VA: 0x180877B30 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x873CC0 Offset: 0x8726C0 VA: 0x180873CC0 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x873EF0 Offset: 0x8728F0 VA: 0x180873EF0 Slot: 129
	public void DestroyWorldspaceUI() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x878F20 Offset: 0x877920 VA: 0x180878F20 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x878C60 Offset: 0x877660 VA: 0x180878C60
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x877F20 Offset: 0x876920 VA: 0x180877F20 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x877D70 Offset: 0x876770 VA: 0x180877D70
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x878A70 Offset: 0x877470 VA: 0x180878A70 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x878750 Offset: 0x877150 VA: 0x180878750
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x8785B0 Offset: 0x876FB0 VA: 0x1808785B0 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8782F0 Offset: 0x876CF0 VA: 0x1808782F0
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x874210 Offset: 0x872C10 VA: 0x180874210 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x874360 Offset: 0x872D60 VA: 0x180874360 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x8792B0 Offset: 0x877CB0 VA: 0x1808792B0
	public void .ctor() { }

	// RVA: 0x874AC0 Offset: 0x8734C0 VA: 0x180874AC0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x874A30 Offset: 0x873430 VA: 0x180874A30 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x877120 Offset: 0x875B20 VA: 0x180877120
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x875850 Offset: 0x874250 VA: 0x180875850 Slot: 136
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x876160 Offset: 0x874B60 VA: 0x180876160
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x876FF0 Offset: 0x8759F0 VA: 0x180876FF0
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x875710 Offset: 0x874110 VA: 0x180875710 Slot: 137
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x8760E0 Offset: 0x874AE0 VA: 0x1808760E0
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x876D40 Offset: 0x875740 VA: 0x180876D40
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x8755E0 Offset: 0x873FE0 VA: 0x1808755E0 Slot: 138
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x875FB0 Offset: 0x8749B0 VA: 0x180875FB0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x877550 Offset: 0x875F50 VA: 0x180877550
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x875BC0 Offset: 0x8745C0 VA: 0x180875BC0 Slot: 139
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x876420 Offset: 0x874E20 VA: 0x180876420
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x876BC0 Offset: 0x8755C0 VA: 0x180876BC0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x875C40 Offset: 0x874640 VA: 0x180875C40
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x875F20 Offset: 0x874920 VA: 0x180875F20
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8779C0 Offset: 0x8763C0 VA: 0x1808779C0
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x876690 Offset: 0x875090 VA: 0x180876690
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x876E70 Offset: 0x875870 VA: 0x180876E70
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x875680 Offset: 0x874080 VA: 0x180875680 Slot: 140
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x876030 Offset: 0x874A30 VA: 0x180876030
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x876720 Offset: 0x875120 VA: 0x180876720
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x875690 Offset: 0x874090 VA: 0x180875690
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x875D00 Offset: 0x874700 VA: 0x180875D00
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8773C0 Offset: 0x875DC0 VA: 0x1808773C0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x875A90 Offset: 0x874490 VA: 0x180875A90 Slot: 141
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x8762D0 Offset: 0x874CD0 VA: 0x1808762D0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x877830 Offset: 0x876230 VA: 0x180877830
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x875B10 Offset: 0x874510 VA: 0x180875B10
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x8765A0 Offset: 0x874FA0 VA: 0x1808765A0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x876A20 Offset: 0x875420 VA: 0x180876A20
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x875E30 Offset: 0x874830 VA: 0x180875E30
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x877250 Offset: 0x875C50 VA: 0x180877250
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x875990 Offset: 0x874390 VA: 0x180875990 Slot: 142
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x8761E0 Offset: 0x874BE0 VA: 0x1808761E0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8768A0 Offset: 0x8752A0 VA: 0x1808768A0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x875A10 Offset: 0x874410 VA: 0x180875A10
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x875DA0 Offset: 0x8747A0 VA: 0x180875DA0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8776C0 Offset: 0x8760C0 VA: 0x1808776C0
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x876510 Offset: 0x874F10 VA: 0x180876510
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0x8796B0 Offset: 0x8780B0 VA: 0x1808796B0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x875440 Offset: 0x873E40 VA: 0x180875440 Slot: 143
	public override bool ReadSyncVar___ScheduleOne.StationFramework.MushroomSpawnStation(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0x879770 Offset: 0x878170 VA: 0x180879770
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x640F30 Offset: 0x63F930 VA: 0x180640F30
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x8795F0 Offset: 0x877FF0 VA: 0x1808795F0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x873B30 Offset: 0x872530 VA: 0x180873B30 Slot: 144
	protected override void Awake_UserLogic_ScheduleOne.StationFramework.MushroomSpawnStation_Assembly-CSharp.dll() { }
}
