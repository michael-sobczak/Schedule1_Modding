public class Packager : Employee, IConfigurable // TypeDefIndex: 1430
{
	// Fields
	[Header("References")]
	public Sprite typeIcon; // 0x380
	[SerializeField]
	protected ConfigurationReplicator configReplicator; // 0x388
	public PackagingStationBehaviour PackagingBehaviour; // 0x390
	public BrickPressBehaviour BrickPressBehaviour; // 0x398
	[Header("UI")]
	public PackagerUIElement WorldspaceUIPrefab; // 0x3A0
	public Transform uiPoint; // 0x3A8
	[Header("Settings")]
	public int MaxAssignedStations; // 0x3B0
	[Header("Proficiency Settings")]
	public float PackagingSpeedMultiplier; // 0x3B4
	[CompilerGenerated]
	private PackagerConfiguration <configuration>k__BackingField; // 0x3B8
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3C0
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3C8
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3D0
	private bool NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted; // 0x3D8
	private bool NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted; // 0x3D9

	// Properties
	public EntityConfiguration Configuration { get; }
	protected PackagerConfiguration configuration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	public Property ParentProperty { get; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170 Slot: 129
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170
	protected PackagerConfiguration get_configuration() { }

	[CompilerGenerated]
	// RVA: 0x6CD1A0 Offset: 0x6CBBA0 VA: 0x1806CD1A0
	protected void set_configuration(PackagerConfiguration value) { }

	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230 Slot: 130
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 131
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40 Slot: 132
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6CD180 Offset: 0x6CBB80 VA: 0x1806CD180 Slot: 133
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30 Slot: 134
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0x6CC310 Offset: 0x6CAD10 VA: 0x1806CC310 Slot: 135
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6CC6C0 Offset: 0x6CB0C0 VA: 0x1806CC6C0 Slot: 149
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270 Slot: 137
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 138
	public Transform get_Transform() { }

	// RVA: 0x6AA7A0 Offset: 0x6A91A0 VA: 0x1806AA7A0 Slot: 139
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 141
	public bool get_CanBeSelected() { }

	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260 Slot: 142
	public Property get_ParentProperty() { }

	// RVA: 0x6CADA0 Offset: 0x6C97A0 VA: 0x1806CADA0 Slot: 112
	protected override void AssignProperty(Property prop, bool warp) { }

	// RVA: 0x6784B0 Offset: 0x676EB0 VA: 0x1806784B0 Slot: 113
	protected override void UnassignProperty() { }

	// RVA: 0x6CC2E0 Offset: 0x6CACE0 VA: 0x1806CC2E0 Slot: 118
	protected override void ResetConfiguration() { }

	// RVA: 0x6CB120 Offset: 0x6C9B20 VA: 0x1806CB120 Slot: 119
	protected override void Fire() { }

	// RVA: 0x6CC0A0 Offset: 0x6CAAA0 VA: 0x1806CC0A0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x6CC560 Offset: 0x6CAF60 VA: 0x1806CC560 Slot: 150
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x6CCB70 Offset: 0x6CB570 VA: 0x1806CCB70 Slot: 120
	protected override void UpdateBehaviour() { }

	// RVA: 0x6CCA90 Offset: 0x6CB490 VA: 0x1806CCA90
	private void StartPackaging(PackagingStation station) { }

	// RVA: 0x681560 Offset: 0x67FF60 VA: 0x180681560
	private void StartPress(BrickPress press) { }

	// RVA: 0x6CC920 Offset: 0x6CB320 VA: 0x1806CC920
	private void StartMoveItem(PackagingStation station) { }

	// RVA: 0x6CC820 Offset: 0x6CB220 VA: 0x1806CC820
	private void StartMoveItem(BrickPress press) { }

	// RVA: 0x6CBB00 Offset: 0x6CA500 VA: 0x1806CBB00
	protected PackagingStation GetStationToAttend() { }

	// RVA: 0x6CB480 Offset: 0x6C9E80 VA: 0x1806CB480
	protected BrickPress GetBrickPress() { }

	// RVA: 0x6CB8C0 Offset: 0x6CA2C0 VA: 0x1806CB8C0
	protected PackagingStation GetStationMoveItems() { }

	// RVA: 0x6CB240 Offset: 0x6C9C40 VA: 0x1806CB240
	protected BrickPress GetBrickPressMoveItems() { }

	// RVA: 0x6CBC60 Offset: 0x6CA660 VA: 0x1806CBC60
	protected AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item) { }

	// RVA: 0x6CC7F0 Offset: 0x6CB1F0 VA: 0x1806CC7F0 Slot: 121
	protected override bool ShouldIdle() { }

	// RVA: 0x6CB5E0 Offset: 0x6C9FE0 VA: 0x1806CB5E0 Slot: 122
	public override EmployeeHome GetHome() { }

	// RVA: 0x6CAE60 Offset: 0x6C9860 VA: 0x1806CAE60 Slot: 143
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x6CB090 Offset: 0x6C9A90 VA: 0x1806CB090 Slot: 144
	public void DestroyWorldspaceUI() { }

	// RVA: 0x6CB600 Offset: 0x6CA000 VA: 0x1806CB600 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x6CB830 Offset: 0x6CA230 VA: 0x1806CB830 Slot: 98
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x6CD0E0 Offset: 0x6CBAE0 VA: 0x1806CD0E0 Slot: 99
	public override List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x6CD140 Offset: 0x6CBB40 VA: 0x1806CD140
	public void .ctor() { }

	// RVA: 0x6CBEF0 Offset: 0x6CA8F0 VA: 0x1806CBEF0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6CBE70 Offset: 0x6CA870 VA: 0x1806CBE70 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6CC430 Offset: 0x6CAE30 VA: 0x1806CC430
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x6CC310 Offset: 0x6CAD10 VA: 0x1806CC310 Slot: 151
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x6CC3B0 Offset: 0x6CADB0 VA: 0x1806CC3B0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x6CD1C0 Offset: 0x6CBBC0 VA: 0x1806CD1C0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x6CC220 Offset: 0x6CAC20 VA: 0x1806CC220 Slot: 152
	public override bool ReadSyncVar___ScheduleOne.Employees.Packager(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6A87A0 Offset: 0x6A71A0 VA: 0x1806A87A0 Slot: 65
	public override void Awake() { }
}
