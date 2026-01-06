public class PlaceableStorageEntity : GridItem, ITransitEntity, IUsable, IConfigurable // TypeDefIndex: 3278
{
	// Fields
	[Header("References")]
	public StorageEntity StorageEntity; // 0x210
	public Transform[] accessPoints; // 0x218
	[SerializeField]
	private Transform _linkOrigin; // 0x220
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x228
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x230
	[HideInInspector]
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x238
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x240
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x248
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x249
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x250
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x258
	private EntityConfiguration _configuration; // 0x260
	private ConfigurationReplicator _configReplicator; // 0x268
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x270
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x278
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x280
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted; // 0x288
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted; // 0x289

	// Properties
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
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
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	// RVA: 0x8793E0 Offset: 0x877DE0 VA: 0x1808793E0 Slot: 71
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0 Slot: 72
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0 Slot: 73
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00 Slot: 74
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x6415D0 Offset: 0x63FFD0 VA: 0x1806415D0 Slot: 75
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0 Slot: 76
	public Transform get_LinkOrigin() { }

	[CompilerGenerated]
	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560 Slot: 95
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA3DB00 Offset: 0xA3C500 VA: 0x180A3DB00 Slot: 96
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70 Slot: 97
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA3DBA0 Offset: 0xA3C5A0 VA: 0x180A3DBA0 Slot: 98
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 77
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x640EC0 Offset: 0x63F8C0 VA: 0x180640EC0 Slot: 78
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x640ED0 Offset: 0x63F8D0 VA: 0x180640ED0 Slot: 79
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x635530 Offset: 0x633F30 VA: 0x180635530
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0 Slot: 103
	public EntityConfiguration get_Configuration() { }

	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70 Slot: 104
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0xA3E8F0 Offset: 0xA3D2F0 VA: 0x180A3E8F0 Slot: 105
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0 Slot: 106
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6412E0 Offset: 0x63FCE0 VA: 0x1806412E0 Slot: 107
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0 Slot: 108
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA3DA60 Offset: 0xA3C460 VA: 0x180A3DA60 Slot: 109
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	// RVA: 0xA3E900 Offset: 0xA3D300 VA: 0x180A3E900 Slot: 111
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 112
	public Transform get_Transform() { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0 Slot: 113
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 115
	public bool get_CanBeSelected() { }

	// RVA: 0xA3CAB0 Offset: 0xA3B4B0 VA: 0x180A3CAB0 Slot: 47
	public override void Awake() { }

	// RVA: 0xA3E640 Offset: 0xA3D040 VA: 0x180A3E640 Slot: 48
	protected override void Start() { }

	// RVA: 0xA3D740 Offset: 0xA3C140 VA: 0x180A3D740 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA3D220 Offset: 0xA3BC20 VA: 0x180A3D220 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA3D140 Offset: 0xA3BB40 VA: 0x180A3D140 Slot: 50
	public override string GetManagementName() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3E510 Offset: 0xA3CF10 VA: 0x180A3E510 Slot: 101
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3E3E0 Offset: 0xA3CDE0 VA: 0x180A3E3E0 Slot: 102
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA3CB40 Offset: 0xA3B540 VA: 0x180A3CB40 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA3CF30 Offset: 0xA3B930 VA: 0x180A3CF30 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA3D000 Offset: 0xA3BA00 VA: 0x180A3D000 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA3D170 Offset: 0xA3BB70 VA: 0x180A3D170 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA3E2B0 Offset: 0xA3CCB0 VA: 0x180A3E2B0 Slot: 123
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0xA3E150 Offset: 0xA3CB50 VA: 0x180A3E150 Slot: 124
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA3CC40 Offset: 0xA3B640 VA: 0x180A3CC40 Slot: 117
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA3CEA0 Offset: 0xA3B8A0 VA: 0x180A3CEA0 Slot: 118
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA3E830 Offset: 0xA3D230 VA: 0x180A3E830
	public void .ctor() { }

	// RVA: 0xA3D3D0 Offset: 0xA3BDD0 VA: 0x180A3D3D0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA3D340 Offset: 0xA3BD40 VA: 0x180A3D340 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA3E020 Offset: 0xA3CA20 VA: 0x180A3E020
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA3DBA0 Offset: 0xA3C5A0 VA: 0x180A3DBA0 Slot: 125
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA3DD40 Offset: 0xA3C740 VA: 0x180A3DD40
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA3DEF0 Offset: 0xA3C8F0 VA: 0x180A3DEF0
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA3DB00 Offset: 0xA3C500 VA: 0x180A3DB00 Slot: 126
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA3DCC0 Offset: 0xA3C6C0 VA: 0x180A3DCC0
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA3DDC0 Offset: 0xA3C7C0 VA: 0x180A3DDC0
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA3DA60 Offset: 0xA3C460 VA: 0x180A3DA60 Slot: 127
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA3DC40 Offset: 0xA3C640 VA: 0x180A3DC40
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA3EA40 Offset: 0xA3D440 VA: 0x180A3EA40
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA3D8C0 Offset: 0xA3C2C0 VA: 0x180A3D8C0 Slot: 128
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.PlaceableStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA3EB00 Offset: 0xA3D500 VA: 0x180A3EB00
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA3E980 Offset: 0xA3D380 VA: 0x180A3E980
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA3CA50 Offset: 0xA3B450 VA: 0x180A3CA50 Slot: 129
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.PlaceableStorageEntity_Assembly-CSharp.dll() { }
}
