public class Chemist : Employee, IConfigurable // TypeDefIndex: 1416
{
	// Fields
	public const int MAX_ASSIGNED_STATIONS = 4;
	[Header("References")]
	public Sprite typeIcon; // 0x380
	[SerializeField]
	protected ConfigurationReplicator configReplicator; // 0x388
	[Header("Behaviours")]
	public StartChemistryStationBehaviour StartChemistryStationBehaviour; // 0x390
	public StartLabOvenBehaviour StartLabOvenBehaviour; // 0x398
	public FinishLabOvenBehaviour FinishLabOvenBehaviour; // 0x3A0
	public StartCauldronBehaviour StartCauldronBehaviour; // 0x3A8
	public StartMixingStationBehaviour StartMixingStationBehaviour; // 0x3B0
	[Header("UI")]
	public ChemistUIElement WorldspaceUIPrefab; // 0x3B8
	public Transform uiPoint; // 0x3C0
	[CompilerGenerated]
	private ChemistConfiguration <configuration>k__BackingField; // 0x3C8
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3D0
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3D8
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3E0
	private bool NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted; // 0x3E8
	private bool NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted; // 0x3E9

	// Properties
	public EntityConfiguration Configuration { get; }
	protected ChemistConfiguration configuration { get; set; }
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

	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30 Slot: 129
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	protected ChemistConfiguration get_configuration() { }

	[CompilerGenerated]
	// RVA: 0x681E50 Offset: 0x680850 VA: 0x180681E50
	protected void set_configuration(ChemistConfiguration value) { }

	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230 Slot: 130
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 131
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240 Slot: 132
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x67A2C0 Offset: 0x678CC0 VA: 0x18067A2C0 Slot: 133
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290 Slot: 134
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0x680FE0 Offset: 0x67F9E0 VA: 0x180680FE0 Slot: 135
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x681340 Offset: 0x67FD40 VA: 0x180681340 Slot: 149
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270 Slot: 137
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 138
	public Transform get_Transform() { }

	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40 Slot: 139
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 141
	public bool get_CanBeSelected() { }

	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260 Slot: 142
	public Property get_ParentProperty() { }

	// RVA: 0x67EBA0 Offset: 0x67D5A0 VA: 0x18067EBA0 Slot: 112
	protected override void AssignProperty(Property prop, bool warp) { }

	// RVA: 0x6784B0 Offset: 0x676EB0 VA: 0x1806784B0 Slot: 113
	protected override void UnassignProperty() { }

	// RVA: 0x680FA0 Offset: 0x67F9A0 VA: 0x180680FA0 Slot: 118
	protected override void ResetConfiguration() { }

	// RVA: 0x67EFB0 Offset: 0x67D9B0 VA: 0x18067EFB0 Slot: 119
	protected override void Fire() { }

	// RVA: 0x680DD0 Offset: 0x67F7D0 VA: 0x180680DD0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x681230 Offset: 0x67FC30 VA: 0x180681230 Slot: 150
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x681C20 Offset: 0x680620 VA: 0x180681C20 Slot: 120
	protected override void UpdateBehaviour() { }

	// RVA: 0x6815E0 Offset: 0x67FFE0 VA: 0x1806815E0
	private void TryStartNewTask() { }

	// RVA: 0x67EB10 Offset: 0x67D510 VA: 0x18067EB10
	private bool AnyWorkInProgress() { }

	// RVA: 0x681470 Offset: 0x67FE70 VA: 0x180681470 Slot: 121
	protected override bool ShouldIdle() { }

	// RVA: 0x681520 Offset: 0x67FF20 VA: 0x180681520
	private void StartChemistryStation(ChemistryStation station) { }

	// RVA: 0x6814E0 Offset: 0x67FEE0 VA: 0x1806814E0
	private void StartCauldron(Cauldron cauldron) { }

	// RVA: 0x681560 Offset: 0x67FF60 VA: 0x180681560
	private void StartLabOven(LabOven oven) { }

	// RVA: 0x67EF70 Offset: 0x67D970 VA: 0x18067EF70
	private void FinishLabOven(LabOven oven) { }

	// RVA: 0x6815A0 Offset: 0x67FFA0 VA: 0x1806815A0
	private void StartMixingStation(MixingStation station) { }

	// RVA: 0x67FBB0 Offset: 0x67E5B0 VA: 0x18067FBB0 Slot: 122
	public override EmployeeHome GetHome() { }

	// RVA: 0x67FBD0 Offset: 0x67E5D0 VA: 0x18067FBD0
	public List<LabOven> GetLabOvensReadyToFinish() { }

	// RVA: 0x6800E0 Offset: 0x67EAE0 VA: 0x1806800E0
	public List<LabOven> GetLabOvensReadyToStart() { }

	// RVA: 0x67F870 Offset: 0x67E270 VA: 0x18067F870
	public List<ChemistryStation> GetChemistryStationsReadyToStart() { }

	// RVA: 0x67F370 Offset: 0x67DD70 VA: 0x18067F370
	public List<Cauldron> GetCauldronsReadyToStart() { }

	// RVA: 0x6805E0 Offset: 0x67EFE0 VA: 0x1806805E0
	public List<MixingStation> GetMixingStationsReadyToStart() { }

	// RVA: 0x67FE40 Offset: 0x67E840 VA: 0x18067FE40
	protected List<LabOven> GetLabOvensReadyToMove() { }

	// RVA: 0x67F5D0 Offset: 0x67DFD0 VA: 0x18067F5D0
	protected List<ChemistryStation> GetChemStationsReadyToMove() { }

	// RVA: 0x67F0D0 Offset: 0x67DAD0 VA: 0x18067F0D0
	protected List<Cauldron> GetCauldronsReadyToMove() { }

	// RVA: 0x680340 Offset: 0x67ED40 VA: 0x180680340
	protected List<MixingStation> GetMixStationsReadyToMove() { }

	// RVA: 0x67ECB0 Offset: 0x67D6B0 VA: 0x18067ECB0 Slot: 143
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x67EEE0 Offset: 0x67D8E0 VA: 0x18067EEE0 Slot: 144
	public void DestroyWorldspaceUI() { }

	// RVA: 0x680900 Offset: 0x67F300 VA: 0x180680900 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x680B30 Offset: 0x67F530 VA: 0x180680B30 Slot: 98
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x681DB0 Offset: 0x6807B0 VA: 0x180681DB0 Slot: 99
	public override List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x681E10 Offset: 0x680810 VA: 0x180681E10
	public void .ctor() { }

	// RVA: 0x680C20 Offset: 0x67F620 VA: 0x180680C20 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x680BC0 Offset: 0x67F5C0 VA: 0x180680BC0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x681100 Offset: 0x67FB00 VA: 0x180681100
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x680FE0 Offset: 0x67F9E0 VA: 0x180680FE0 Slot: 151
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x681080 Offset: 0x67FA80 VA: 0x180681080
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x681E70 Offset: 0x680870 VA: 0x180681E70
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x680EE0 Offset: 0x67F8E0 VA: 0x180680EE0 Slot: 152
	public override bool ReadSyncVar___ScheduleOne.Employees.Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x67EC60 Offset: 0x67D660 VA: 0x18067EC60 Slot: 65
	public override void Awake() { }
}
