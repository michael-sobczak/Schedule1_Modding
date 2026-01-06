public class Pot : GrowContainer, IConfigurable // TypeDefIndex: 3297
{
	// Fields
	public const float MaxWarmthGrowthMultiplier = 1.5;
	public const float WarmthMinThreshold = 20;
	public const float WarmthMaxThreshold = 40;
	public const float RotationSpeed = 10;
	[Header("References")]
	public Transform ModelTransform; // 0x328
	public Transform SeedStartPoint; // 0x330
	public Transform SeedRestingPoint; // 0x338
	public Transform LookAtPoint; // 0x340
	public Transform PlantContainer; // 0x348
	public Transform TaskBounds; // 0x350
	public Transform LeafDropPoint; // 0x358
	public ParticleSystem PoofParticles; // 0x360
	public AudioSourceController PoofSound; // 0x368
	public ConfigurationReplicator ConfigurationReplicator; // 0x370
	public Transform Dirt_Flat; // 0x378
	public Transform Dirt_Parted; // 0x380
	public SoilChunk[] SoilChunks; // 0x388
	[Header("UI")]
	public PotUIElement WorldspaceUIPrefab; // 0x390
	public Sprite typeIcon; // 0x398
	[Header("Pot Settings")]
	public float PotRadius; // 0x3A0
	[Range(0.2, 2)]
	public float YieldMultiplier; // 0x3A4
	[Range(0.2, 2)]
	public float GrowSpeedMultiplier; // 0x3A8
	[CompilerGenerated]
	private Plant <Plant>k__BackingField; // 0x3B0
	[CompilerGenerated]
	private PotConfiguration <potConfiguration>k__BackingField; // 0x3B8
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x3C0
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x3C8
	private float rotation; // 0x3D0
	private bool rotationOverridden; // 0x3D4
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3D8
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted; // 0x3E0
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted; // 0x3E1

	// Properties
	public Plant Plant { get; set; }
	public EntityConfiguration Configuration { get; }
	protected PotConfiguration potConfiguration { get; set; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6AA780 Offset: 0x6A9180 VA: 0x1806AA780
	public Plant get_Plant() { }

	[CompilerGenerated]
	// RVA: 0xA43570 Offset: 0xA41F70 VA: 0x180A43570
	protected void set_Plant(Plant value) { }

	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170 Slot: 123
	public EntityConfiguration get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170
	protected PotConfiguration get_potConfiguration() { }

	[CompilerGenerated]
	// RVA: 0x6CD1A0 Offset: 0x6CBBA0 VA: 0x1806CD1A0
	protected void set_potConfiguration(PotConfiguration value) { }

	// RVA: 0xA026D0 Offset: 0xA010D0 VA: 0x180A026D0 Slot: 124
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 125
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40 Slot: 126
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0x6CD180 Offset: 0x6CBB80 VA: 0x1806CD180 Slot: 127
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30 Slot: 128
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA41680 Offset: 0xA40080 VA: 0x180A41680 Slot: 129
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA42CA0 Offset: 0xA416A0 VA: 0x180A42CA0 Slot: 143
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0x67A280 Offset: 0x678C80 VA: 0x18067A280 Slot: 131
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 132
	public Transform get_Transform() { }

	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 133
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 135
	public bool get_CanBeSelected() { }

	// RVA: 0xA3ED30 Offset: 0xA3D730 VA: 0x180A3ED30 Slot: 47
	public override void Awake() { }

	// RVA: 0xA434B0 Offset: 0xA41EB0 VA: 0x180A434B0 Slot: 48
	protected override void Start() { }

	// RVA: 0xA40840 Offset: 0xA3F240 VA: 0x180A40840 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA42B90 Offset: 0xA41590 VA: 0x180A42B90 Slot: 144
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA3FAA0 Offset: 0xA3E4A0 VA: 0x180A3FAA0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA19B60 Offset: 0xA18560 VA: 0x180A19B60 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA3F7D0 Offset: 0xA3E1D0 VA: 0x180A3F7D0 Slot: 51
	public override string GetDefaultManagementName() { }

	// RVA: 0xA3F390 Offset: 0xA3DD90 VA: 0x180A3F390 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA3FE30 Offset: 0xA3E830 VA: 0x180A3FE30 Slot: 145
	protected virtual void LateUpdate() { }

	// RVA: 0xA3FE30 Offset: 0xA3E830 VA: 0x180A3FE30
	private void UpdateRotation() { }

	// RVA: 0xA405B0 Offset: 0xA3EFB0 VA: 0x180A405B0 Slot: 103
	protected override void OnMinPass() { }

	// RVA: 0xA40AB0 Offset: 0xA3F4B0 VA: 0x180A40AB0 Slot: 104
	protected override void OnTimeSkipped(int minsSkipped) { }

	// RVA: 0xA3ED80 Offset: 0xA3D780 VA: 0x180A3ED80
	public bool CanAcceptSeed(out string reason) { }

	// RVA: 0xA3FC80 Offset: 0xA3E680 VA: 0x180A3FC80
	public bool IsReadyForHarvest(out string reason) { }

	// RVA: 0xA3EF70 Offset: 0xA3D970 VA: 0x180A3EF70 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA40B80 Offset: 0xA3F580 VA: 0x180A40B80
	public void OverrideRotation(float angle) { }

	// RVA: 0xA3EBC0 Offset: 0xA3D5C0 VA: 0x180A3EBC0 Slot: 115
	protected override AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication) { }

	// RVA: 0xA3EE70 Offset: 0xA3D870 VA: 0x180A3EE70 Slot: 117
	public override bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason) { }

	// RVA: 0xA3FBA0 Offset: 0xA3E5A0 VA: 0x180A3FBA0 Slot: 105
	public override bool IsPointAboveGrowSurface(Vector3 point) { }

	// RVA: 0xA42DD0 Offset: 0xA417D0 VA: 0x180A42DD0 Slot: 106
	public override void SetGrowableVisible(bool visible) { }

	// RVA: 0xA3F880 Offset: 0xA3E280 VA: 0x180A3F880 Slot: 118
	protected override Vector3 GetRandomPourTargetPosition() { }

	// RVA: 0xA3F7E0 Offset: 0xA3E1E0 VA: 0x180A3F7E0 Slot: 107
	public override float GetGrowSurfaceSideLength() { }

	// RVA: 0xA3FA20 Offset: 0xA3E420 VA: 0x180A3FA20 Slot: 116
	public override float GetTemperatureGrowthMultiplier() { }

	// RVA: 0xA3F070 Offset: 0xA3DA70 VA: 0x180A3F070 Slot: 108
	public override bool ContainsGrowable() { }

	// RVA: 0xA3F7F0 Offset: 0xA3E1F0 VA: 0x180A3F7F0 Slot: 109
	public override float GetGrowthProgressNormalized() { }

	// RVA: 0xA43290 Offset: 0xA41C90 VA: 0x180A43290
	public void SetSoilState(Pot.ESoilState state) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA40E40 Offset: 0xA3F840 VA: 0x180A40E40
	public void PlantSeed_Server(string seedID, float normalizedSeedProgress) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA40B90 Offset: 0xA3F590 VA: 0x180A40B90
	private void PlantSeed_Client(NetworkConnection conn, string seedID, float normalizedSeedProgress) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xA42610 Offset: 0xA41010 VA: 0x180A42610
	public void SetGrowthProgress_Server(float progress) { }

	[ObserversRpc]
	// RVA: 0xA420B0 Offset: 0xA40AB0 VA: 0x180A420B0
	private void SetGrowthProgress_Client(float progress) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA43120 Offset: 0xA41B20 VA: 0x180A43120
	public void SetHarvestableActive_Server(int harvestableIndex, bool active) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA42E60 Offset: 0xA41860 VA: 0x180A42E60
	private void SetHarvestableActive_Client(NetworkConnection conn, int harvestableIndex, bool active) { }

	// RVA: 0xA40650 Offset: 0xA3F050 VA: 0x180A40650
	private void OnPlantFullyHarvested() { }

	// RVA: 0xA3F0D0 Offset: 0xA3DAD0 VA: 0x180A3F0D0 Slot: 137
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA3F300 Offset: 0xA3DD00 VA: 0x180A3F300 Slot: 138
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA3F460 Offset: 0xA3DE60 VA: 0x180A3F460 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA3F970 Offset: 0xA3E370 VA: 0x180A3F970 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA400A0 Offset: 0xA3EAA0 VA: 0x180A400A0 Slot: 146
	public virtual void Load(PotData potData) { }

	// RVA: 0xA3FFE0 Offset: 0xA3E9E0 VA: 0x180A3FFE0
	private void LoadPlant(PlantData data) { }

	// RVA: 0xA43540 Offset: 0xA41F40 VA: 0x180A43540
	public void .ctor() { }

	// RVA: 0xA401D0 Offset: 0xA3EBD0 VA: 0x180A401D0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA40170 Offset: 0xA3EB70 VA: 0x180A40170 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA424E0 Offset: 0xA40EE0 VA: 0x180A424E0
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA41680 Offset: 0xA40080 VA: 0x180A41680 Slot: 147
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA41C60 Offset: 0xA40660 VA: 0x180A41C60
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA42380 Offset: 0xA40D80 VA: 0x180A42380
	private void RpcWriter___Server_PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress) { }

	// RVA: 0xA41660 Offset: 0xA40060 VA: 0x180A41660
	public void RpcLogic___PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress) { }

	// RVA: 0xA41BC0 Offset: 0xA405C0 VA: 0x180A41BC0
	private void RpcReader___Server_PlantSeed_Server_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA41F40 Offset: 0xA40940 VA: 0x180A41F40
	private void RpcWriter___Observers_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress) { }

	// RVA: 0xA41060 Offset: 0xA3FA60 VA: 0x180A41060
	private void RpcLogic___PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress) { }

	// RVA: 0xA41960 Offset: 0xA40360 VA: 0x180A41960
	private void RpcReader___Observers_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA428C0 Offset: 0xA412C0 VA: 0x180A428C0
	private void RpcWriter___Target_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress) { }

	// RVA: 0xA41E10 Offset: 0xA40810 VA: 0x180A41E10
	private void RpcReader___Target_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA42610 Offset: 0xA41010 VA: 0x180A42610
	private void RpcWriter___Server_SetGrowthProgress_Server_431000436(float progress) { }

	// RVA: 0xA41810 Offset: 0xA40210 VA: 0x180A41810
	public void RpcLogic___SetGrowthProgress_Server_431000436(float progress) { }

	// RVA: 0xA41CE0 Offset: 0xA406E0 VA: 0x180A41CE0
	private void RpcReader___Server_SetGrowthProgress_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA420B0 Offset: 0xA40AB0 VA: 0x180A420B0
	private void RpcWriter___Observers_SetGrowthProgress_Client_431000436(float progress) { }

	// RVA: 0xA41720 Offset: 0xA40120 VA: 0x180A41720
	private void RpcLogic___SetGrowthProgress_Client_431000436(float progress) { }

	// RVA: 0xA419F0 Offset: 0xA403F0 VA: 0x180A419F0
	private void RpcReader___Observers_SetGrowthProgress_Client_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA42750 Offset: 0xA41150 VA: 0x180A42750
	private void RpcWriter___Server_SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active) { }

	// RVA: 0xA41940 Offset: 0xA40340 VA: 0x180A41940
	public void RpcLogic___SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active) { }

	// RVA: 0xA41D40 Offset: 0xA40740 VA: 0x180A41D40
	private void RpcReader___Server_SetHarvestableActive_Server_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA42200 Offset: 0xA40C00 VA: 0x180A42200
	private void RpcWriter___Observers_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active) { }

	// RVA: 0xA41820 Offset: 0xA40220 VA: 0x180A41820
	private void RpcLogic___SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active) { }

	// RVA: 0xA41B00 Offset: 0xA40500 VA: 0x180A41B00
	private void RpcReader___Observers_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA42A20 Offset: 0xA41420 VA: 0x180A42A20
	private void RpcWriter___Target_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active) { }

	// RVA: 0xA41E90 Offset: 0xA40890 VA: 0x180A41E90
	private void RpcReader___Target_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA43590 Offset: 0xA41F90 VA: 0x180A43590
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA40FA0 Offset: 0xA3F9A0 VA: 0x180A40FA0 Slot: 148
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xA3ED00 Offset: 0xA3D700 VA: 0x180A3ED00 Slot: 149
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.Pot_Assembly-CSharp.dll() { }
}
