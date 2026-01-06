public class MushroomBed : GrowContainer, IConfigurable // TypeDefIndex: 3290
{
	// Fields
	[Header("Mushroom Bed")]
	[SerializeField]
	private float _internalSideLength; // 0x328
	[SerializeField]
	private ConfigurationReplicator _configurationReplicator; // 0x330
	[SerializeField]
	private Sprite _typeIcon; // 0x338
	[SerializeField]
	private MushroomBedUIElement _worldspaceUIPrefab; // 0x340
	[SerializeField]
	private ParticleSystem _poofParticles; // 0x348
	[SerializeField]
	private AudioSourceController _poofSound; // 0x350
	[SerializeField]
	private Transform _colonyAlignment; // 0x358
	[SerializeField]
	private Transform _mixFXContainer; // 0x360
	[SerializeField]
	private ParticleSystem[] _mixParticles; // 0x368
	[SerializeField]
	private AudioSourceController _mixSound; // 0x370
	[CompilerGenerated]
	private ShroomColony <CurrentColony>k__BackingField; // 0x378
	[CompilerGenerated]
	private WorldspaceUIElement <WorldspaceUI>k__BackingField; // 0x380
	[SyncVar]
	[HideInInspector]
	[CompilerGenerated]
	public NetworkObject <CurrentPlayerConfigurer>k__BackingField; // 0x388
	[CompilerGenerated]
	private MushroomBedConfiguration <_configuration>k__BackingField; // 0x390
	private Material _soilMaterialInstance; // 0x398
	private MushroomBed.EMushroomBedSoilAppearance _currentSoilAppearance; // 0x3A0
	private bool _mushroomBedColdAtLeastOnce; // 0x3A4
	public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField; // 0x3A8
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MushroomBedAssembly-CSharp.dll_Excuted; // 0x3B0
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MushroomBedAssembly-CSharp.dll_Excuted; // 0x3B1

	// Properties
	public ShroomColony CurrentColony { get; set; }
	public EntityConfiguration Configuration { get; }
	public ConfigurationReplicator ConfigReplicator { get; }
	public EConfigurableType ConfigurableType { get; }
	public WorldspaceUIElement WorldspaceUI { get; set; }
	public NetworkObject CurrentPlayerConfigurer { get; set; }
	public Sprite TypeIcon { get; }
	public Transform Transform { get; }
	public Transform UIPoint { get; }
	public bool CanBeSelected { get; }
	protected MushroomBedConfiguration _configuration { get; set; }
	public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660
	public ShroomColony get_CurrentColony() { }

	[CompilerGenerated]
	// RVA: 0xA34AC0 Offset: 0xA334C0 VA: 0x180A34AC0
	public void set_CurrentColony(ShroomColony value) { }

	// RVA: 0xA34AB0 Offset: 0xA334B0 VA: 0x180A34AB0 Slot: 123
	public EntityConfiguration get_Configuration() { }

	// RVA: 0xA0AD80 Offset: 0xA09780 VA: 0x180A0AD80 Slot: 124
	public ConfigurationReplicator get_ConfigReplicator() { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 125
	public EConfigurableType get_ConfigurableType() { }

	[CompilerGenerated]
	// RVA: 0x67A270 Offset: 0x678C70 VA: 0x18067A270 Slot: 126
	public WorldspaceUIElement get_WorldspaceUI() { }

	[CompilerGenerated]
	// RVA: 0xA34AE0 Offset: 0xA334E0 VA: 0x180A34AE0 Slot: 127
	public void set_WorldspaceUI(WorldspaceUIElement value) { }

	[CompilerGenerated]
	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230 Slot: 128
	public NetworkObject get_CurrentPlayerConfigurer() { }

	[CompilerGenerated]
	// RVA: 0xA342C0 Offset: 0xA32CC0 VA: 0x180A342C0 Slot: 129
	public void set_CurrentPlayerConfigurer(NetworkObject value) { }

	// RVA: 0xA0ADA0 Offset: 0xA097A0 VA: 0x180A0ADA0 Slot: 131
	public Sprite get_TypeIcon() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 132
	public Transform get_Transform() { }

	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 133
	public Transform get_UIPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 135
	public bool get_CanBeSelected() { }

	[CompilerGenerated]
	// RVA: 0xA34AB0 Offset: 0xA334B0 VA: 0x180A34AB0
	protected MushroomBedConfiguration get__configuration() { }

	[CompilerGenerated]
	// RVA: 0xA34B00 Offset: 0xA33500 VA: 0x180A34B00
	protected void set__configuration(MushroomBedConfiguration value) { }

	// RVA: 0xA33E00 Offset: 0xA32800 VA: 0x180A33E00 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA34590 Offset: 0xA32F90 VA: 0x180A34590 Slot: 144
	public void SendConfigurationToClient(NetworkConnection conn) { }

	// RVA: 0xA334F0 Offset: 0xA31EF0 VA: 0x180A334F0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA332B0 Offset: 0xA31CB0 VA: 0x180A332B0 Slot: 50
	public override string GetManagementName() { }

	// RVA: 0xA32DD0 Offset: 0xA317D0 VA: 0x180A32DD0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA322D0 Offset: 0xA30CD0 VA: 0x180A322D0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA335F0 Offset: 0xA31FF0 VA: 0x180A335F0 Slot: 105
	public override bool IsPointAboveGrowSurface(Vector3 point) { }

	// RVA: 0xA34820 Offset: 0xA33220 VA: 0x180A34820 Slot: 106
	public override void SetGrowableVisible(bool visible) { }

	// RVA: 0xA321D0 Offset: 0xA30BD0 VA: 0x180A321D0 Slot: 117
	public override bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason) { }

	// RVA: 0xA332E0 Offset: 0xA31CE0 VA: 0x180A332E0 Slot: 118
	protected override Vector3 GetRandomPourTargetPosition() { }

	// RVA: 0xA33210 Offset: 0xA31C10 VA: 0x180A33210 Slot: 107
	public override float GetGrowSurfaceSideLength() { }

	// RVA: 0x67A280 Offset: 0x678C80 VA: 0x18067A280 Slot: 113
	protected override Material GetSoilMaterial() { }

	// RVA: 0xA34970 Offset: 0xA33370 VA: 0x180A34970 Slot: 110
	public override void SetSoil(SoilDefinition soil) { }

	// RVA: 0xA348B0 Offset: 0xA332B0 VA: 0x180A348B0 Slot: 114
	public override void SetMoistureAmount(float amount) { }

	// RVA: 0xA32660 Offset: 0xA31060 VA: 0x180A32660
	public void ConfigureSoilAppearance(MushroomBed.EMushroomBedSoilAppearance appearance, Texture2D sporeMask) { }

	// RVA: 0xA33690 Offset: 0xA32090 VA: 0x180A33690
	public bool IsReadyForHarvest(out string reason) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA346F0 Offset: 0xA330F0 VA: 0x180A346F0 Slot: 143
	public void SetConfigurer(NetworkObject player) { }

	// RVA: 0xA31C80 Offset: 0xA30680 VA: 0x180A31C80 Slot: 115
	protected override AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication) { }

	// RVA: 0xA340D0 Offset: 0xA32AD0 VA: 0x180A340D0
	public void PlayMixFXAtPoint(Vector3 point) { }

	// RVA: 0xA33F60 Offset: 0xA32960 VA: 0x180A33F60 Slot: 67
	protected override void OnTileTemperatureChanged(Tile tile, float newTemp) { }

	// RVA: 0xA327B0 Offset: 0xA311B0 VA: 0x180A327B0 Slot: 108
	public override bool ContainsGrowable() { }

	// RVA: 0xA33220 Offset: 0xA31C20 VA: 0x180A33220 Slot: 109
	public override float GetGrowthProgressNormalized() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xA32810 Offset: 0xA31210 VA: 0x180A32810
	public void CreateAndAssignColony_Server(string shroomSpawnID) { }

	// RVA: 0xA32940 Offset: 0xA31340 VA: 0x180A32940
	private void CreateAndAssignColony(ShroomSpawnDefinition shroomSpawn) { }

	// RVA: 0xA31DD0 Offset: 0xA307D0 VA: 0x180A31DD0
	public void AssignColony(ShroomColony colony) { }

	// RVA: 0xA33BF0 Offset: 0xA325F0 VA: 0x180A33BF0
	private void OnColonyFullyHarvested() { }

	// RVA: 0xA325B0 Offset: 0xA30FB0 VA: 0x180A325B0 Slot: 112
	protected override void ClearSoil() { }

	// RVA: 0xA323D0 Offset: 0xA30DD0 VA: 0x180A323D0
	public void CheckShowTemperatureHint() { }

	// RVA: 0xA32B10 Offset: 0xA31510 VA: 0x180A32B10 Slot: 137
	public WorldspaceUIElement CreateWorldspaceUI() { }

	// RVA: 0xA32D40 Offset: 0xA31740 VA: 0x180A32D40 Slot: 138
	public void DestroyWorldspaceUI() { }

	// RVA: 0xA32EA0 Offset: 0xA318A0 VA: 0x180A32EA0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA33440 Offset: 0xA31E40 VA: 0x180A33440 Slot: 60
	public override DynamicSaveData GetSaveData() { }

	// RVA: 0xA33840 Offset: 0xA32240 VA: 0x180A33840 Slot: 145
	public virtual void Load(MushroomBedData mushroomBedData) { }

	// RVA: 0xA34A90 Offset: 0xA33490 VA: 0x180A34A90
	public void .ctor() { }

	// RVA: 0xA33A00 Offset: 0xA32400 VA: 0x180A33A00 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA339A0 Offset: 0xA323A0 VA: 0x180A339A0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA34460 Offset: 0xA32E60 VA: 0x180A34460
	private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA342C0 Offset: 0xA32CC0 VA: 0x180A342C0 Slot: 146
	public void RpcLogic___SetConfigurer_3323014238(NetworkObject player) { }

	// RVA: 0xA343E0 Offset: 0xA32DE0 VA: 0x180A343E0
	private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA32810 Offset: 0xA31210 VA: 0x180A32810
	private void RpcWriter___Server_CreateAndAssignColony_Server_3615296227(string shroomSpawnID) { }

	// RVA: 0xA34260 Offset: 0xA32C60 VA: 0x180A34260
	public void RpcLogic___CreateAndAssignColony_Server_3615296227(string shroomSpawnID) { }

	// RVA: 0xA34360 Offset: 0xA32D60 VA: 0x180A34360
	private void RpcReader___Server_CreateAndAssignColony_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67A230 Offset: 0x678C30 VA: 0x18067A230
	public NetworkObject sync___get_value_<CurrentPlayerConfigurer>k__BackingField() { }

	// RVA: 0xA34B20 Offset: 0xA33520 VA: 0x180A34B20
	public void sync___set_value_<CurrentPlayerConfigurer>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA341A0 Offset: 0xA32BA0 VA: 0x180A341A0 Slot: 147
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.MushroomBed(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xA32180 Offset: 0xA30B80 VA: 0x180A32180 Slot: 47
	public override void Awake() { }
}
