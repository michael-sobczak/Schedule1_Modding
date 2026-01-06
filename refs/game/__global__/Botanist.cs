public class Botanist : Employee, IConfigurable // TypeDefIndex: 1413
{
	// Fields
	public const float CriticalWateringThreshold = 0.2;
	public const float WateringThreshold = 0.3;
	public const float MoistureLevelRandomMin = 0.9;
	public const float MoistureLevelRandomMax = 1;
	public const float SoilPourTime = 10;
	public const float WaterPourTime = 10;
	public const float AdditivePourTime = 10;
	public const float SeedSowTime = 15;
	public const float IndividualHarvestTime = 1;
	public const float ApplySpawnTime = 15;
	[Header("References")]
	public Sprite typeIcon; // 0x380
	[SerializeField]
	protected ConfigurationReplicator configReplicator; // 0x388
	[Header("UI")]
	public BotanistUIElement WorldspaceUIPrefab; // 0x390
	public Transform uiPoint; // 0x398
	[Header("Settings")]
	public int MaxAssignedPots; // 0x3A0
	public DialogueContainer NoAssignedStationsDialogue; // 0x3A8
	public DialogueContainer UnspecifiedPotsDialogue; // 0x3B0
	public DialogueContainer NullDestinationPotsDialogue; // 0x3B8
	public DialogueContainer MissingMaterialsDialogue; // 0x3C0
	public DialogueContainer NoPotsRequireWorkDialogue; // 0x3C8
	[CompilerGenerated]
	private BotanistConfiguration <configuration>k__BackingField; // 0x3D0
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3D8
	[CompilerGenerated]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3E0
	private StartDryingRackBehaviour _startDryingRackBehaviour; // 0x3E8
	private StopDryingRackBehaviour _stopDryingRackBehaviour; // 0x3F0
	private UseSpawnStationBehaviour _useSpawnStationBehaviour; // 0x3F8
	private AddSoilToGrowContainerBehaviour _addSoilToGrowContainerBehaviour; // 0x400
	private ApplyAdditiveToGrowContainerBehaviour _applyAdditiveToGrowContainerBehaviour; // 0x408
	private SowSeedInPotBehaviour _sowSeedInPotBehaviour; // 0x410
	private WaterPotBehaviour _waterPotBehaviour; // 0x418
	private HarvestPotBehaviour _harvestPotBehaviour; // 0x420
	private MistMushroomBedBehaviour _mistMushroomBedBehaviour; // 0x428
	private HarvestMushroomBedBehaviour _harvestMushroomBedBehaviour; // 0x430
	private ApplySpawnToMushroomBedBehaviour _applySpawnToMushroomBedBehaviour; // 0x438
	private List<Behaviour> _workBehaviours; // 0x440
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x448
	private bool NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted; // 0x450
	private bool NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted; // 0x451

	// Properties
	public EntityConfiguration Configuration { get; }
	protected BotanistConfiguration configuration { get; set; }
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

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240 Slot: 129
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	protected BotanistConfiguration get_configuration() { }

	[CompilerGenerated]
	// RVA: 0x67A2C0 Offset: 0x678CC0 VA: 0x18067A2C0
	protected void set_configuration(BotanistConfiguration value) { }

	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230 Slot: 130
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 131
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
	// RVA: 0x677EE0 Offset: 0x6768E0 VA: 0x180677EE0 Slot: 135
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x678290 Offset: 0x676C90 VA: 0x180678290 Slot: 149
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270 Slot: 137
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 138
	public Transform get_Transform() { }

	// RVA: 0x67A280 Offset: 0x678C80 VA: 0x18067A280 Slot: 139
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 141
	public bool get_CanBeSelected() { }

	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260 Slot: 142
	public Property get_ParentProperty() { }

	// RVA: 0x675110 Offset: 0x673B10 VA: 0x180675110 Slot: 65
	public override void Awake() { }

	// RVA: 0x6784F0 Offset: 0x676EF0 VA: 0x1806784F0 Slot: 120
	protected override void UpdateBehaviour() { }

	// RVA: 0x6779A0 Offset: 0x6763A0 VA: 0x1806779A0
	private bool IsEntityAccessible(ITransitEntity entity) { }

	// RVA: 0x678430 Offset: 0x676E30 VA: 0x180678430
	private void StartDryingRack(DryingRack rack) { }

	// RVA: 0x678470 Offset: 0x676E70 VA: 0x180678470
	private void StopDryingRack(DryingRack rack) { }

	// RVA: 0x677C80 Offset: 0x676680 VA: 0x180677C80 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x678130 Offset: 0x676B30 VA: 0x180678130 Slot: 150
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0x6747F0 Offset: 0x6731F0 VA: 0x1806747F0 Slot: 112
	protected override void AssignProperty(Property prop, bool warp) { }

	// RVA: 0x6784B0 Offset: 0x676EB0 VA: 0x1806784B0 Slot: 113
	protected override void UnassignProperty() { }

	// RVA: 0x677EA0 Offset: 0x6768A0 VA: 0x180677EA0 Slot: 118
	protected override void ResetConfiguration() { }

	// RVA: 0x675520 Offset: 0x673F20 VA: 0x180675520 Slot: 119
	protected override void Fire() { }

	// RVA: 0x675160 Offset: 0x673B60 VA: 0x180675160
	private bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity) { }

	// RVA: 0x6759B0 Offset: 0x6743B0 VA: 0x1806759B0
	public QualityItemInstance GetDryableInSupplies() { }

	// RVA: 0x6755E0 Offset: 0x673FE0 VA: 0x1806755E0
	private DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity) { }

	// RVA: 0x6783C0 Offset: 0x676DC0 VA: 0x1806783C0 Slot: 121
	protected override bool ShouldIdle() { }

	// RVA: 0x6763F0 Offset: 0x674DF0 VA: 0x1806763F0 Slot: 122
	public override EmployeeHome GetHome() { }

	// RVA: 0x6778E0 Offset: 0x6762E0 VA: 0x1806778E0
	public ITransitEntity GetSuppliesAsTransitEntity() { }

	// RVA: 0x676A00 Offset: 0x675400 VA: 0x180676A00
	private Pot GetPotForWatering(float threshold) { }

	// RVA: 0x6760B0 Offset: 0x674AB0 VA: 0x1806760B0
	private List<GrowContainer> GetGrowContainersForSoilPour() { }

	// RVA: 0x676DC0 Offset: 0x6757C0 VA: 0x180676DC0
	private List<Pot> GetPotsReadyForSeed() { }

	// RVA: 0x675D70 Offset: 0x674770 VA: 0x180675D70
	private List<GrowContainer> GetGrowContainersForAdditives() { }

	// RVA: 0x676B60 Offset: 0x675560 VA: 0x180676B60
	private List<Pot> GetPotsForHarvest() { }

	// RVA: 0x676410 Offset: 0x674E10 VA: 0x180676410
	private MushroomBed GetMushroomBedForMisting(float threshold) { }

	// RVA: 0x676570 Offset: 0x674F70 VA: 0x180676570
	private List<MushroomBed> GetMushroomBedsForHarvest() { }

	// RVA: 0x675830 Offset: 0x674230 VA: 0x180675830
	private List<MushroomBed> GetBedsReadyForSpawn() { }

	// RVA: 0x6771A0 Offset: 0x675BA0 VA: 0x1806771A0
	private List<DryingRack> GetRacksToStart() { }

	// RVA: 0x677310 Offset: 0x675D10 VA: 0x180677310
	private List<DryingRack> GetRacksToStop() { }

	// RVA: 0x676F40 Offset: 0x675940 VA: 0x180676F40
	private List<DryingRack> GetRacksReadyToMove() { }

	// RVA: 0x677770 Offset: 0x676170 VA: 0x180677770
	private List<MushroomSpawnStation> GetSpawnStationsReadyToUse() { }

	// RVA: 0x677510 Offset: 0x675F10 VA: 0x180677510
	private List<MushroomSpawnStation> GetSpawnStationsReadyToMove() { }

	// RVA: 0x675260 Offset: 0x673C60 VA: 0x180675260 Slot: 143
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0x675490 Offset: 0x673E90 VA: 0x180675490 Slot: 144
	public void DestroyWorldspaceUI() { }

	// RVA: 0x6767D0 Offset: 0x6751D0 VA: 0x1806767D0 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x677480 Offset: 0x675E80 VA: 0x180677480 Slot: 98
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0x67A140 Offset: 0x678B40 VA: 0x18067A140 Slot: 99
	public override List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x67A1A0 Offset: 0x678BA0 VA: 0x18067A1A0
	public void .ctor() { }

	// RVA: 0x677AD0 Offset: 0x6764D0 VA: 0x180677AD0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x677A70 Offset: 0x676470 VA: 0x180677A70 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x678000 Offset: 0x676A00 VA: 0x180678000
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x677EE0 Offset: 0x6768E0 VA: 0x180677EE0 Slot: 151
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0x677F80 Offset: 0x676980 VA: 0x180677F80
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0x67A2E0 Offset: 0x678CE0 VA: 0x18067A2E0
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x677DE0 Offset: 0x6767E0 VA: 0x180677DE0 Slot: 152
	public override bool ReadSyncVar___ScheduleOne.Employees.Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6748B0 Offset: 0x6732B0 VA: 0x1806748B0 Slot: 153
	protected override void Awake_UserLogic_ScheduleOne.Employees.Botanist_Assembly-CSharp.dll() { }
}
