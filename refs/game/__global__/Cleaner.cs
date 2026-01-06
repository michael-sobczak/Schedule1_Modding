public class Cleaner : Employee, IConfigurable // TypeDefIndex: 1420
{
	// Fields
	public const int MAX_ASSIGNED_BINS = 6;
	public TrashGrabberDefinition TrashGrabberDef; // 0x380
	[Header("References")]
	public PickUpTrashBehaviour PickUpTrashBehaviour; // 0x388
	public EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour; // 0x390
	public BagTrashCanBehaviour BagTrashCanBehaviour; // 0x398
	public DisposeTrashBagBehaviour DisposeTrashBagBehaviour; // 0x3A0
	public Sprite typeIcon; // 0x3A8
	[SerializeField]
	protected ConfigurationReplicator configReplicator; // 0x3B0
	[Header("UI")]
	public CleanerUIElement WorldspaceUIPrefab; // 0x3B8
	public Transform uiPoint; // 0x3C0
	[CompilerGenerated]
	private TrashGrabberInstance <trashGrabberInstance>k__BackingField; // 0x3C8
	[CompilerGenerated]
	private CleanerConfiguration <configuration>k__BackingField; // 0x3D0
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3D8
	[SyncVar]
	[CompilerGenerated]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3E0
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3E8
	private bool NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted; // 0x3F0
	private bool NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted; // 0x3F1

	// Properties
	public TrashGrabberInstance trashGrabberInstance { get; set; }
	public EntityConfiguration Configuration { get; }
	protected CleanerConfiguration configuration { get; set; }
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

	[CompilerGenerated]
	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	public TrashGrabberInstance get_trashGrabberInstance() { }

	[CompilerGenerated]
	// RVA: 0x681E50 Offset: 0x680850 VA: 0x180681E50
	private void set_trashGrabberInstance(TrashGrabberInstance value) { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240 Slot: 129
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	protected CleanerConfiguration get_configuration() { }

	[CompilerGenerated]
	// RVA: 0x67A2C0 Offset: 0x678CC0 VA: 0x18067A2C0
	protected void set_configuration(CleanerConfiguration value) { }

	// RVA: 0x6AA780 Offset: 0x6A9180 VA: 0x1806AA780 Slot: 130
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 131
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290 Slot: 132
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x67A2A0 Offset: 0x678CA0 VA: 0x18067A2A0 Slot: 133
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250 Slot: 134
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0x6A9750 Offset: 0x6A8150 VA: 0x1806A9750 Slot: 135
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6A9B00 Offset: 0x6A8500 VA: 0x1806A9B00 Slot: 149
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x6AA7A0 Offset: 0x6A91A0 VA: 0x1806AA7A0 Slot: 137
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 138
	public Transform get_Transform() { }

	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40 Slot: 139
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 141
	public bool get_CanBeSelected() { }

	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260 Slot: 142
	public Property get_ParentProperty() { }

	// RVA: 0x6A86E0 Offset: 0x6A70E0 VA: 0x1806A86E0 Slot: 112
	protected override void AssignProperty(Property prop, bool warp) { }

	// RVA: 0x6784B0 Offset: 0x676EB0 VA: 0x1806784B0 Slot: 113
	protected override void UnassignProperty() { }

	// RVA: 0x6A9720 Offset: 0x6A8120 VA: 0x1806A9720 Slot: 118
	protected override void ResetConfiguration() { }

	// RVA: 0x6A8CC0 Offset: 0x6A76C0 VA: 0x1806A8CC0 Slot: 119
	protected override void Fire() { }

	// RVA: 0x6A9500 Offset: 0x6A7F00 VA: 0x1806A9500 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x6A99A0 Offset: 0x6A83A0 VA: 0x1806A99A0 Slot: 150
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x6AA520 Offset: 0x6A8F20 VA: 0x1806AA520 Slot: 120
	protected override void UpdateBehaviour() { }

	// RVA: 0x6A9CF0 Offset: 0x6A86F0 VA: 0x1806A9CF0
	private void TryStartNewTask() { }

	// RVA: 0x6A8DE0 Offset: 0x6A77E0 VA: 0x1806A8DE0
	private TrashContainerItem GetFirstNonFullBin(TrashContainerItem[] bins) { }

	// RVA: 0x6A9C30 Offset: 0x6A8630 VA: 0x1806A9C30 Slot: 124
	public override void SetIdle(bool idle) { }

	// RVA: 0x6A91D0 Offset: 0x6A7BD0 VA: 0x1806A91D0
	private TrashContainerItem[] GetTrashContainersOrderedByDistance() { }

	// RVA: 0x6A8EF0 Offset: 0x6A78F0 VA: 0x1806A8EF0 Slot: 122
	public override EmployeeHome GetHome() { }

	// RVA: 0x6A8AD0 Offset: 0x6A74D0 VA: 0x1806A8AD0
	private void EnsureTrashGrabberInInventory() { }

	// RVA: 0x6A8650 Offset: 0x6A7050 VA: 0x1806A8650
	private bool AnyWorkInProgress() { }

	// RVA: 0x6A92A0 Offset: 0x6A7CA0 VA: 0x1806A92A0
	private int GetTrashGrabberAmount() { }

	// RVA: 0x6A8810 Offset: 0x6A7210 VA: 0x1806A8810 Slot: 143
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x6A8A40 Offset: 0x6A7440 VA: 0x1806A8A40 Slot: 144
	public void DestroyWorldspaceUI() { }

	// RVA: 0x6A8F10 Offset: 0x6A7910 VA: 0x1806A8F10 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x6A9140 Offset: 0x6A7B40 VA: 0x1806A9140 Slot: 98
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x6AA720 Offset: 0x6A9120 VA: 0x1806AA720 Slot: 99
	public override List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x681E10 Offset: 0x680810 VA: 0x180681E10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6AA2B0 Offset: 0x6A8CB0 VA: 0x1806AA2B0
	private int <GetTrashContainersOrderedByDistance>b__53_0(TrashContainerItem x, TrashContainerItem y) { }

	// RVA: 0x6A9350 Offset: 0x6A7D50 VA: 0x1806A9350 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6A92D0 Offset: 0x6A7CD0 VA: 0x1806A92D0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6A9870 Offset: 0x6A8270 VA: 0x1806A9870
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x6A9750 Offset: 0x6A8150 VA: 0x1806A9750 Slot: 151
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x6A97F0 Offset: 0x6A81F0 VA: 0x1806A97F0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x6AA7B0 Offset: 0x6A91B0 VA: 0x1806AA7B0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x6A9660 Offset: 0x6A8060 VA: 0x1806A9660 Slot: 152
	public override bool ReadSyncVar___ScheduleOne.Employees.Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6A87A0 Offset: 0x6A71A0 VA: 0x1806A87A0 Slot: 65
	public override void Awake() { }
}
