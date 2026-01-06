public class BrickPress : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3226
{
	// Fields
	public const int INPUT_SLOT_COUNT = 2;
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x210
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x218
	[HideInInspector]
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x220
	[Header("References")]
	public Transform CameraPosition; // 0x228
	public Transform CameraPosition_Pouring; // 0x230
	public Transform CameraPosition_Raising; // 0x238
	public InteractableObject IntObj; // 0x240
	public Transform uiPoint; // 0x248
	public Transform StandPoint; // 0x250
	public Transform[] accessPoints; // 0x258
	public StorageVisualizer OutputVisuals; // 0x260
	public BrickPressContainer Container1; // 0x268
	public BrickPressContainer Container2; // 0x270
	public Transform ContainerSpawnPoint; // 0x278
	public PackagingDefinition BrickPackaging; // 0x280
	public BoxCollider MouldDetection; // 0x288
	public BrickPressHandle Handle; // 0x290
	public Transform PressTransform; // 0x298
	public Transform PressTransform_Raised; // 0x2A0
	public Transform PressTransform_Lowered; // 0x2A8
	public AudioSourceController SlamSound; // 0x2B0
	public ConfigurationReplicator configReplicator; // 0x2B8
	[Header("Prefabs")]
	public Draggable FunctionalContainerPrefab; // 0x2C0
	[Header("UI")]
	public BrickPressUIElement WorldspaceUIPrefab; // 0x2C8
	public Sprite typeIcon; // 0x2D0
	[CompilerGenerated]
	private ItemSlot[] <ProductSlots>k__BackingField; // 0x2D8
	[CompilerGenerated]
	private ItemSlot <OutputSlot>k__BackingField; // 0x2E0
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x2E8
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x2F0
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x2F8
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x2F9
	[CompilerGenerated]
	private BrickPressConfiguration <stationConfiguration>k__BackingField; // 0x300
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x308
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x310
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x318
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x320
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x328
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted; // 0x330
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted; // 0x331

	// Properties
	public bool isOpen { get; }
	public List<ItemSlot> ItemSlots { get; set; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public ItemSlot[] ProductSlots { get; set; }
	public ItemSlot OutputSlot { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public EntityConfiguration Configuration { get; }
	protected BrickPressConfiguration stationConfiguration { get; set; }
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

	// RVA: 0x9CAF00 Offset: 0x9C9900 VA: 0x1809CAF00
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
	// RVA: 0x9C7380 Offset: 0x9C5D80 VA: 0x1809C7380 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0x9C7420 Offset: 0x9C5E20 VA: 0x1809C7420 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0
	public ItemSlot[] get_ProductSlots() { }

	[CompilerGenerated]
	// RVA: 0x81F960 Offset: 0x81E360 VA: 0x18081F960
	private void set_ProductSlots(ItemSlot[] value) { }

	[CompilerGenerated]
	// RVA: 0x640F20 Offset: 0x63F920 VA: 0x180640F20
	public ItemSlot get_OutputSlot() { }

	[CompilerGenerated]
	// RVA: 0x8795D0 Offset: 0x877FD0 VA: 0x1808795D0
	private void set_OutputSlot(ItemSlot value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x640F30 Offset: 0x63F930 VA: 0x180640F30 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x641610 Offset: 0x640010 VA: 0x180641610 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x641630 Offset: 0x640030 VA: 0x180641630 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x640DD0 Offset: 0x63F7D0 VA: 0x180640DD0 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x9CAEE0 Offset: 0x9C98E0 VA: 0x1809CAEE0 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x9CAFB0 Offset: 0x9C99B0 VA: 0x1809CAFB0
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x6DFA80 Offset: 0x6DE480 VA: 0x1806DFA80 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x6DFA80 Offset: 0x6DE480 VA: 0x1806DFA80
	protected BrickPressConfiguration get_stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x6DFBA0 Offset: 0x6DE5A0 VA: 0x1806DFBA0
	protected void set_stationConfiguration(BrickPressConfiguration value) { }

	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x6DFA50 Offset: 0x6DE450 VA: 0x1806DFA50 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6DFB60 Offset: 0x6DE560 VA: 0x1806DFB60 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0x9C7250 Offset: 0x9C5C50 VA: 0x1809C7250 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9C9770 Offset: 0x9C8170 VA: 0x1809C9770 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	// RVA: 0x9C3D70 Offset: 0x9C2770 VA: 0x1809C3D70 Slot: 47
	public override void Awake() { }

	// RVA: 0x9C6050 Offset: 0x9C4A50 VA: 0x1809C6050 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x9C5740 Offset: 0x9C4140 VA: 0x1809C5740 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0x9C6270 Offset: 0x9C4C70 VA: 0x1809C6270 Slot: 136
	protected virtual void LateUpdate() { }

	// RVA: 0x9C6A80 Offset: 0x9C5480 VA: 0x1809C6A80 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x9C9660 Offset: 0x9C8060 VA: 0x1809C9660 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x9C4E30 Offset: 0x9C3830 VA: 0x1809C4E30
	private void Exit(ExitAction action) { }

	// RVA: 0x9C3DC0 Offset: 0x9C27C0 VA: 0x1809C3DC0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x9C4CE0 Offset: 0x9C36E0 VA: 0x1809C4CE0 Slot: 56
	protected override void Destroy() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9C9CF0 Offset: 0x9C86F0 VA: 0x1809C9CF0 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9C9BC0 Offset: 0x9C85C0 VA: 0x1809C9BC0 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0x9C5B20 Offset: 0x9C4520 VA: 0x1809C5B20
	public PackagingStation.EState GetState() { }

	// RVA: 0x9CAC60 Offset: 0x9C9660 VA: 0x1809CAC60
	private void UpdateInputVisuals() { }

	// RVA: 0x9C5DE0 Offset: 0x9C47E0 VA: 0x1809C5DE0
	public bool HasSufficientProduct(out ProductItemInstance product) { }

	// RVA: 0x9C5040 Offset: 0x9C3A40 VA: 0x1809C5040
	public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity) { }

	// RVA: 0x9C44A0 Offset: 0x9C2EA0 VA: 0x1809C44A0
	public Draggable CreateFunctionalContainer(ProductItemInstance instance, float productScale, out List<FunctionalProduct> products) { }

	// RVA: 0x9C7030 Offset: 0x9C5A30 VA: 0x1809C7030
	public void PlayPressAnim() { }

	// RVA: 0x9C4250 Offset: 0x9C2C50 VA: 0x1809C4250
	public void CompletePress(ProductItemInstance product) { }

	// RVA: 0x9C5770 Offset: 0x9C4170 VA: 0x1809C5770
	public List<FunctionalProduct> GetProductInMould() { }

	// RVA: 0x9C4A20 Offset: 0x9C3420 VA: 0x1809C4A20 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x9C4C50 Offset: 0x9C3650 VA: 0x1809C4C50 Slot: 129
	public void DestroyWorldspaceUI() { }

	// RVA: 0x9C5F10 Offset: 0x9C4910 VA: 0x1809C5F10
	public void Hovered() { }

	// RVA: 0x9C61C0 Offset: 0x9C4BC0 VA: 0x1809C61C0
	public void Interacted() { }

	// RVA: 0x9C6C30 Offset: 0x9C5630 VA: 0x1809C6C30
	public void Open() { }

	// RVA: 0x9C3F00 Offset: 0x9C2900 VA: 0x1809C3F00
	public void Close() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x9CAA50 Offset: 0x9C9450 VA: 0x1809CAA50 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x9CA790 Offset: 0x9C9190 VA: 0x1809CA790
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x9C9A50 Offset: 0x9C8450 VA: 0x1809C9A50 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9C98A0 Offset: 0x9C82A0 VA: 0x1809C98A0
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x9CA5A0 Offset: 0x9C8FA0 VA: 0x1809CA5A0 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x9CA280 Offset: 0x9C8C80 VA: 0x1809CA280
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x9CA0E0 Offset: 0x9C8AE0 VA: 0x1809CA0E0 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x9C9E20 Offset: 0x9C8820 VA: 0x1809C9E20
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C4F20 Offset: 0x9C3920 VA: 0x1809C4F20 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x9C5A70 Offset: 0x9C4470 VA: 0x1809C5A70 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x9CADE0 Offset: 0x9C97E0 VA: 0x1809CADE0
	public void .ctor() { }

	[IteratorStateMachine(typeof(BrickPress.<<PlayPressAnim>g__Routine|109_0>d))]
	[CompilerGenerated]
	// RVA: 0x9CABF0 Offset: 0x9C95F0 VA: 0x1809CABF0
	private IEnumerator <PlayPressAnim>g__Routine|109_0() { }

	// RVA: 0x9C6420 Offset: 0x9C4E20 VA: 0x1809C6420 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9C6390 Offset: 0x9C4D90 VA: 0x1809C6390 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9C8870 Offset: 0x9C7270 VA: 0x1809C8870
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x9C7250 Offset: 0x9C5C50 VA: 0x1809C7250 Slot: 137
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x9C7AE0 Offset: 0x9C64E0 VA: 0x1809C7AE0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C8C50 Offset: 0x9C7650 VA: 0x1809C8C50
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x9C7420 Offset: 0x9C5E20 VA: 0x1809C7420 Slot: 138
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x9C7C90 Offset: 0x9C6690 VA: 0x1809C7C90
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C8B20 Offset: 0x9C7520 VA: 0x1809C8B20
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x9C7380 Offset: 0x9C5D80 VA: 0x1809C7380 Slot: 139
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x9C7C10 Offset: 0x9C6610 VA: 0x1809C7C10
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C9080 Offset: 0x9C7A80 VA: 0x1809C9080
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9C76F0 Offset: 0x9C60F0 VA: 0x1809C76F0 Slot: 140
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9C7F50 Offset: 0x9C6950 VA: 0x1809C7F50
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C86F0 Offset: 0x9C70F0 VA: 0x1809C86F0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9C7770 Offset: 0x9C6170 VA: 0x1809C7770
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9C7A50 Offset: 0x9C6450 VA: 0x1809C7A50
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C94F0 Offset: 0x9C7EF0 VA: 0x1809C94F0
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x9C81C0 Offset: 0x9C6BC0 VA: 0x1809C81C0
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C89A0 Offset: 0x9C73A0 VA: 0x1809C89A0
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9C72F0 Offset: 0x9C5CF0 VA: 0x1809C72F0 Slot: 141
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9C7B60 Offset: 0x9C6560 VA: 0x1809C7B60
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C8250 Offset: 0x9C6C50 VA: 0x1809C8250
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9C7300 Offset: 0x9C5D00 VA: 0x1809C7300
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x9C7830 Offset: 0x9C6230 VA: 0x1809C7830
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C8EF0 Offset: 0x9C78F0 VA: 0x1809C8EF0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9C75C0 Offset: 0x9C5FC0 VA: 0x1809C75C0 Slot: 142
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9C7E00 Offset: 0x9C6800 VA: 0x1809C7E00
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C9360 Offset: 0x9C7D60 VA: 0x1809C9360
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9C7640 Offset: 0x9C6040 VA: 0x1809C7640
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9C80D0 Offset: 0x9C6AD0 VA: 0x1809C80D0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C8550 Offset: 0x9C6F50 VA: 0x1809C8550
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x9C7960 Offset: 0x9C6360 VA: 0x1809C7960
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C8D80 Offset: 0x9C7780 VA: 0x1809C8D80
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C74C0 Offset: 0x9C5EC0 VA: 0x1809C74C0 Slot: 143
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C7D10 Offset: 0x9C6710 VA: 0x1809C7D10
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9C83D0 Offset: 0x9C6DD0 VA: 0x1809C83D0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C7540 Offset: 0x9C5F40 VA: 0x1809C7540
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C78D0 Offset: 0x9C62D0 VA: 0x1809C78D0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9C91F0 Offset: 0x9C7BF0 VA: 0x1809C91F0
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x9C8040 Offset: 0x9C6A40 VA: 0x1809C8040
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0x9CB0A0 Offset: 0x9C9AA0 VA: 0x1809CB0A0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x9C70B0 Offset: 0x9C5AB0 VA: 0x1809C70B0 Slot: 144
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.BrickPress(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0x9CB160 Offset: 0x9C9B60 VA: 0x1809CB160
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x9CAFE0 Offset: 0x9C99E0 VA: 0x1809CAFE0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x9C3960 Offset: 0x9C2360 VA: 0x1809C3960 Slot: 145
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.BrickPress_Assembly-CSharp.dll() { }
}
