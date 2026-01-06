public class MixingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable // TypeDefIndex: 3265
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x210
	[CompilerGenerated]
	private MixOperation <CurrentMixOperation>k__BackingField; // 0x218
	[CompilerGenerated]
	private int <CurrentMixTime>k__BackingField; // 0x220
	public ItemSlot ProductSlot; // 0x228
	public ItemSlot MixerSlot; // 0x230
	public ItemSlot OutputSlot; // 0x238
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x240
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x248
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x250
	public bool RequiresIngredientInsertion; // 0x258
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x260
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x268
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x270
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x271
	[CompilerGenerated]
	private MixingStationConfiguration <stationConfiguration>k__BackingField; // 0x278
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x280
	[SyncVar]
	[CompilerGenerated]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x288
	[Header("Settings")]
	public int MixTimePerItem; // 0x290
	public int MaxMixQuantity; // 0x294
	[Header("Prefabs")]
	public GameObject JugPrefab; // 0x298
	[Header("References")]
	public InteractableObject IntObj; // 0x2A0
	public Transform CameraPosition; // 0x2A8
	public Transform CameraPosition_CombineIngredients; // 0x2B0
	public Transform CameraPosition_StartMachine; // 0x2B8
	public StorageVisualizer InputVisuals; // 0x2C0
	public StorageVisualizer OutputVisuals; // 0x2C8
	public DigitalAlarm Clock; // 0x2D0
	public ToggleableLight Light; // 0x2D8
	public NewMixDiscoveryBox DiscoveryBox; // 0x2E0
	public Transform ItemContainer; // 0x2E8
	public Transform[] IngredientTransforms; // 0x2F0
	public Fillable BowlFillable; // 0x2F8
	public Clickable StartButton; // 0x300
	public Transform JugAlignment; // 0x308
	public Rigidbody Anchor; // 0x310
	public BoxCollider TrashSpawnVolume; // 0x318
	public Transform uiPoint; // 0x320
	public Transform[] accessPoints; // 0x328
	public ConfigurationReplicator configReplicator; // 0x330
	[Header("Sounds")]
	public StartLoopStopAudio MachineSound; // 0x338
	public AudioSourceController StartSound; // 0x340
	public AudioSourceController StopSound; // 0x348
	[Header("UI")]
	[Header("Mix Timing")]
	public MixingStationUIElement WorldspaceUIPrefab; // 0x350
	public Sprite typeIcon; // 0x358
	public UnityEvent onMixStart; // 0x360
	public UnityEvent onMixDone; // 0x368
	public UnityEvent onOutputCollected; // 0x370
	public UnityEvent onStartButtonClicked; // 0x378
	[CompilerGenerated]
	private Vector3 <DiscoveryBoxOffset>k__BackingField; // 0x380
	[CompilerGenerated]
	private Quaternion <DiscoveryBoxRotation>k__BackingField; // 0x38C
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x3A0
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x3A8
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3B0
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted; // 0x3B8
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted; // 0x3B9

	// Properties
	public bool IsOpen { get; set; }
	public MixOperation CurrentMixOperation { get; set; }
	public bool IsMixingDone { get; }
	public int CurrentMixTime { get; set; }
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
	protected MixingStationConfiguration stationConfiguration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	public Vector3 DiscoveryBoxOffset { get; set; }
	public Quaternion DiscoveryBoxRotation { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68F9C0 Offset: 0x68E3C0 VA: 0x18068F9C0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x68F9D0 Offset: 0x68E3D0 VA: 0x18068F9D0
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public MixOperation get_CurrentMixOperation() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	public void set_CurrentMixOperation(MixOperation value) { }

	// RVA: 0xA2A2E0 Offset: 0xA28CE0 VA: 0x180A2A2E0
	public bool get_IsMixingDone() { }

	[CompilerGenerated]
	// RVA: 0xA2A290 Offset: 0xA28C90 VA: 0x180A2A290
	public int get_CurrentMixTime() { }

	[CompilerGenerated]
	// RVA: 0xA2A320 Offset: 0xA28D20 VA: 0x180A2A320
	protected void set_CurrentMixTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA256E0 Offset: 0xA240E0 VA: 0x180A256E0 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA2A370 Offset: 0xA28D70 VA: 0x180A2A370 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 92
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0 Slot: 93
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x718C10 Offset: 0x717610 VA: 0x180718C10 Slot: 94
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70 Slot: 95
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x860CA0 Offset: 0x85F6A0 VA: 0x180860CA0 Slot: 96
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x6DFA20 Offset: 0x6DE420 VA: 0x1806DFA20 Slot: 97
	public Transform get_LinkOrigin() { }

	// RVA: 0x9E17F0 Offset: 0x9E01F0 VA: 0x1809E17F0 Slot: 98
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0xA2A310 Offset: 0xA28D10 VA: 0x180A2A310 Slot: 99
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA2A2D0 Offset: 0xA28CD0 VA: 0x180A2A2D0 Slot: 100
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA2A360 Offset: 0xA28D60 VA: 0x180A2A360
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50 Slot: 114
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50
	protected MixingStationConfiguration get_stationConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x641370 Offset: 0x63FD70 VA: 0x180641370
	protected void set_stationConfiguration(MixingStationConfiguration value) { }

	// RVA: 0xA0AD80 Offset: 0xA09780 VA: 0x180A0AD80 Slot: 115
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 116
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 117
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6415F0 Offset: 0x63FFF0 VA: 0x1806415F0 Slot: 118
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 119
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA25500 Offset: 0xA23F00 VA: 0x180A25500 Slot: 120
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA287A0 Offset: 0xA271A0 VA: 0x180A287A0 Slot: 134
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0xA026A0 Offset: 0xA010A0 VA: 0x180A026A0 Slot: 122
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 123
	public Transform get_Transform() { }

	// RVA: 0x6DFA20 Offset: 0x6DE420 VA: 0x1806DFA20 Slot: 124
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 126
	public bool get_CanBeSelected() { }

	[CompilerGenerated]
	// RVA: 0xA2A2A0 Offset: 0xA28CA0 VA: 0x180A2A2A0
	public Vector3 get_DiscoveryBoxOffset() { }

	[CompilerGenerated]
	// RVA: 0xA2A330 Offset: 0xA28D30 VA: 0x180A2A330
	private void set_DiscoveryBoxOffset(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0xA2A2C0 Offset: 0xA28CC0 VA: 0x180A2A2C0
	public Quaternion get_DiscoveryBoxRotation() { }

	[CompilerGenerated]
	// RVA: 0xA2A350 Offset: 0xA28D50 VA: 0x180A2A350
	private void set_DiscoveryBoxRotation(Quaternion value) { }

	// RVA: 0xA22250 Offset: 0xA20C50 VA: 0x180A22250 Slot: 47
	public override void Awake() { }

	// RVA: 0xA29F40 Offset: 0xA28940 VA: 0x180A29F40 Slot: 48
	protected override void Start() { }

	// RVA: 0xA23950 Offset: 0xA22350 VA: 0x180A23950 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA232B0 Offset: 0xA21CB0 VA: 0x180A232B0 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA231D0 Offset: 0xA21BD0 VA: 0x180A231D0 Slot: 51
	public override string GetDefaultManagementName() { }

	// RVA: 0xA24A10 Offset: 0xA23410 VA: 0x180A24A10 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA284D0 Offset: 0xA26ED0 VA: 0x180A284D0 Slot: 135
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA222A0 Offset: 0xA20CA0 VA: 0x180A222A0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA22A70 Offset: 0xA21470 VA: 0x180A22A70 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA2A210 Offset: 0xA28C10 VA: 0x180A2A210
	private void TimeSkipped(int minsPassed) { }

	// RVA: 0xA23B00 Offset: 0xA22500 VA: 0x180A23B00 Slot: 136
	protected virtual void MinPass() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA28630 Offset: 0xA27030 VA: 0x180A28630
	public void SendMixingOperation(MixOperation operation, int mixTime) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA28BF0 Offset: 0xA275F0 VA: 0x180A28BF0 Slot: 137
	public virtual void SetMixOperation(NetworkConnection conn, MixOperation operation, int mixTIme) { }

	// RVA: 0xA24160 Offset: 0xA22B60 VA: 0x180A24160 Slot: 138
	public virtual void MixingStart() { }

	[ObserversRpc]
	// RVA: 0xA23F60 Offset: 0xA22960 VA: 0x180A23F60
	public void MixingDone_Networked() { }

	// RVA: 0xA24080 Offset: 0xA22A80 VA: 0x180A24080 Slot: 139
	public virtual void MixingDone() { }

	// RVA: 0xA22D30 Offset: 0xA21730 VA: 0x180A22D30
	public bool DoesOutputHaveSpace(StationRecipe recipe) { }

	// RVA: 0xA231E0 Offset: 0xA21BE0 VA: 0x180A231E0
	public List<ItemInstance> GetIngredients() { }

	// RVA: 0xA232E0 Offset: 0xA21CE0 VA: 0x180A232E0
	public int GetMixQuantity() { }

	// RVA: 0xA223C0 Offset: 0xA20DC0 VA: 0x180A223C0
	public bool CanStartMix() { }

	// RVA: 0xA236C0 Offset: 0xA220C0 VA: 0x180A236C0
	public ProductDefinition GetProduct() { }

	// RVA: 0xA23580 Offset: 0xA21F80 VA: 0x180A23580
	public PropertyItemDefinition GetMixer() { }

	// RVA: 0xA23560 Offset: 0xA21F60 VA: 0x180A23560
	public int GetMixTimeForCurrentOperation() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xA27DE0 Offset: 0xA267E0 VA: 0x180A27DE0
	public void TryCreateOutputItems() { }

	// RVA: 0xA29A80 Offset: 0xA28480 VA: 0x180A29A80
	public void SetStartButtonClickable(bool clickable) { }

	// RVA: 0xA25210 Offset: 0xA23C10 VA: 0x180A25210
	private void OutputChanged() { }

	// RVA: 0xA29F00 Offset: 0xA28900 VA: 0x180A29F00
	private void StartButtonClicked(RaycastHit hit) { }

	// RVA: 0xA24D90 Offset: 0xA23790 VA: 0x180A24D90
	public void Open() { }

	// RVA: 0xA22400 Offset: 0xA20E00 VA: 0x180A22400
	public void Close() { }

	// RVA: 0xA23810 Offset: 0xA22210 VA: 0x180A23810
	public void Hovered() { }

	// RVA: 0xA23A50 Offset: 0xA22450 VA: 0x180A23A50
	public void Interacted() { }

	// RVA: 0xA227B0 Offset: 0xA211B0 VA: 0x180A227B0 Slot: 128
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA229E0 Offset: 0xA213E0 VA: 0x180A229E0 Slot: 129
	public void DestroyWorldspaceUI() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA29D60 Offset: 0xA28760 VA: 0x180A29D60 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA29AA0 Offset: 0xA284A0 VA: 0x180A29AA0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA28A80 Offset: 0xA27480 VA: 0x180A28A80 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA288D0 Offset: 0xA272D0 VA: 0x180A288D0
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA29890 Offset: 0xA28290 VA: 0x180A29890 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA29570 Offset: 0xA27F70 VA: 0x180A29570
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA293D0 Offset: 0xA27DD0 VA: 0x180A293D0 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA29110 Offset: 0xA27B10 VA: 0x180A29110
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA28FE0 Offset: 0xA279E0 VA: 0x180A28FE0 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA28EB0 Offset: 0xA278B0 VA: 0x180A28EB0 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA22E50 Offset: 0xA21850 VA: 0x180A22E50 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA23760 Offset: 0xA22160 VA: 0x180A23760 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA21AC0 Offset: 0xA204C0 VA: 0x180A21AC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__117_0() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__117_1() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__117_2() { }

	[CompilerGenerated]
	// RVA: 0xA2A250 Offset: 0xA28C50 VA: 0x180A2A250
	private void <OnSpawnServer>g__SendMixOperation|122_0(NetworkConnection connection) { }

	// RVA: 0xA24260 Offset: 0xA22C60 VA: 0x180A24260 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA241D0 Offset: 0xA22BD0 VA: 0x180A241D0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA27460 Offset: 0xA25E60 VA: 0x180A27460
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA25500 Offset: 0xA23F00 VA: 0x180A25500 Slot: 140
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA26320 Offset: 0xA24D20 VA: 0x180A26320
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA272F0 Offset: 0xA25CF0 VA: 0x180A272F0
	private void RpcWriter___Server_SendMixingOperation_2669582547(MixOperation operation, int mixTime) { }

	// RVA: 0xA254D0 Offset: 0xA23ED0 VA: 0x180A254D0
	public void RpcLogic___SendMixingOperation_2669582547(MixOperation operation, int mixTime) { }

	// RVA: 0xA26270 Offset: 0xA24C70 VA: 0x180A26270
	private void RpcReader___Server_SendMixingOperation_2669582547(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA26CD0 Offset: 0xA256D0 VA: 0x180A26CD0
	private void RpcWriter___Observers_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme) { }

	// RVA: 0xA25630 Offset: 0xA24030 VA: 0x180A25630 Slot: 141
	public virtual void RpcLogic___SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme) { }

	// RVA: 0xA25FD0 Offset: 0xA249D0 VA: 0x180A25FD0
	private void RpcReader___Observers_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27EF0 Offset: 0xA268F0 VA: 0x180A27EF0
	private void RpcWriter___Target_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme) { }

	// RVA: 0xA268B0 Offset: 0xA252B0 VA: 0x180A268B0
	private void RpcReader___Target_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA23F60 Offset: 0xA22960 VA: 0x180A23F60
	private void RpcWriter___Observers_MixingDone_Networked_2166136261() { }

	// RVA: 0xA254B0 Offset: 0xA23EB0 VA: 0x180A254B0
	public void RpcLogic___MixingDone_Networked_2166136261() { }

	// RVA: 0xA25EF0 Offset: 0xA248F0 VA: 0x180A25EF0
	private void RpcReader___Observers_MixingDone_Networked_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27DE0 Offset: 0xA267E0 VA: 0x180A27DE0
	private void RpcWriter___Server_TryCreateOutputItems_2166136261() { }

	// RVA: 0xA25CD0 Offset: 0xA246D0 VA: 0x180A25CD0
	public void RpcLogic___TryCreateOutputItems_2166136261() { }

	// RVA: 0xA26880 Offset: 0xA25280 VA: 0x180A26880
	private void RpcReader___Server_TryCreateOutputItems_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA27C70 Offset: 0xA26670 VA: 0x180A27C70
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA25B90 Offset: 0xA24590 VA: 0x180A25B90 Slot: 142
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA26790 Offset: 0xA25190 VA: 0x180A26790
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA27170 Offset: 0xA25B70 VA: 0x180A27170
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA25C10 Offset: 0xA24610 VA: 0x180A25C10
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA261E0 Offset: 0xA24BE0 VA: 0x180A261E0
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA28360 Offset: 0xA26D60 VA: 0x180A28360
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA26AC0 Offset: 0xA254C0 VA: 0x180A26AC0
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27590 Offset: 0xA25F90 VA: 0x180A27590
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA255A0 Offset: 0xA23FA0 VA: 0x180A255A0 Slot: 143
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA263A0 Offset: 0xA24DA0 VA: 0x180A263A0
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA26B50 Offset: 0xA25550 VA: 0x180A26B50
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA255B0 Offset: 0xA23FB0 VA: 0x180A255B0
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA25F30 Offset: 0xA24930 VA: 0x180A25F30
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27AE0 Offset: 0xA264E0 VA: 0x180A27AE0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA25A60 Offset: 0xA24460 VA: 0x180A25A60 Slot: 144
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA26640 Offset: 0xA25040 VA: 0x180A26640
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA281D0 Offset: 0xA26BD0 VA: 0x180A281D0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA25AE0 Offset: 0xA244E0 VA: 0x180A25AE0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA269D0 Offset: 0xA253D0 VA: 0x180A269D0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA26FD0 Offset: 0xA259D0 VA: 0x180A26FD0
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA260F0 Offset: 0xA24AF0 VA: 0x180A260F0
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27970 Offset: 0xA26370 VA: 0x180A27970
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA25960 Offset: 0xA24360 VA: 0x180A25960 Slot: 145
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA26550 Offset: 0xA24F50 VA: 0x180A26550
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA26E50 Offset: 0xA25850 VA: 0x180A26E50
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA259E0 Offset: 0xA243E0 VA: 0x180A259E0
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA26060 Offset: 0xA24A60 VA: 0x180A26060
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA28060 Offset: 0xA26A60 VA: 0x180A28060
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA26940 Offset: 0xA25340 VA: 0x180A26940
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA27840 Offset: 0xA26240 VA: 0x180A27840
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA25780 Offset: 0xA24180 VA: 0x180A25780 Slot: 146
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA264D0 Offset: 0xA24ED0 VA: 0x180A264D0
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA27710 Offset: 0xA26110 VA: 0x180A27710
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA256E0 Offset: 0xA240E0 VA: 0x180A256E0 Slot: 147
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA26450 Offset: 0xA24E50 VA: 0x180A26450
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA2A4D0 Offset: 0xA28ED0 VA: 0x180A2A4D0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA25310 Offset: 0xA23D10 VA: 0x180A25310 Slot: 148
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.MixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA2A590 Offset: 0xA28F90 VA: 0x180A2A590
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA2A410 Offset: 0xA28E10 VA: 0x180A2A410
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA21BD0 Offset: 0xA205D0 VA: 0x180A21BD0 Slot: 149
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.MixingStation_Assembly-CSharp.dll() { }
}
