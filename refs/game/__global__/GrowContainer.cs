public abstract class GrowContainer : GridItem, IUsable, ITransitEntity // TypeDefIndex: 2359
{
	// Fields
	public const float DryThreshold = 0;
	[SerializeField]
	[Header("Grow Container Settings")]
	[CompilerGenerated]
	private float <SoilCapacity>k__BackingField; // 0x210
	[SerializeField]
	[CompilerGenerated]
	private float <MoistureCapacity>k__BackingField; // 0x214
	[CompilerGenerated]
	[SerializeField]
	private bool <HidePlantDuringPourTasks>k__BackingField; // 0x218
	[SerializeField]
	private float _moistureDrainPerHour; // 0x21C
	[SerializeField]
	public SoilDefinition[] AllowedSoils; // 0x220
	[SerializeField]
	public AdditiveDefinition[] AllowedAdditives; // 0x228
	[SerializeField]
	[Header("Grow Container References")]
	private GrowContainerInteraction _interactionHandler; // 0x230
	[SerializeField]
	protected MeshRenderer[] _soilMeshRenderers; // 0x238
	[SerializeField]
	[CompilerGenerated]
	private Transform <SoilContainer>k__BackingField; // 0x240
	[SerializeField]
	protected Transform _soilMinTransform; // 0x248
	[SerializeField]
	protected Transform _soilMaxTransform; // 0x250
	[SerializeField]
	private MeshRenderer _additiveDisplayTemplate; // 0x258
	[CompilerGenerated]
	[SerializeField]
	private Transform <PourableStartPoint>k__BackingField; // 0x260
	[CompilerGenerated]
	[SerializeField]
	private GrowContainerSurfaceCover <SurfaceCover>k__BackingField; // 0x268
	[CompilerGenerated]
	[SerializeField]
	private GrowContainerCameraHandler <CameraHandler>k__BackingField; // 0x270
	[SerializeField]
	[CompilerGenerated]
	private TemperatureDisplay <TemperatureDisplay>k__BackingField; // 0x278
	[SerializeField]
	protected Transform _pourTarget; // 0x280
	[SerializeField]
	protected Transform _uiPoint; // 0x288
	[SerializeField]
	protected Transform[] _accessPoints; // 0x290
	[SerializeField]
	private ParticleSystem[] _soilClearedParticles; // 0x298
	[SerializeField]
	private AudioSourceController _soilClearedSound; // 0x2A0
	[Header("Optional References")]
	[SerializeField]
	private UsableLightSource _lightSourceOverride; // 0x2A8
	[CompilerGenerated]
	private SoilDefinition <CurrentSoil>k__BackingField; // 0x2B0
	[CompilerGenerated]
	private List<AdditiveDefinition> <AppliedAdditives>k__BackingField; // 0x2B8
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x2C0
	[CompilerGenerated]
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x2C8
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x2D0
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x2D8
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x2E0
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x2E1
	public Action onMinPass; // 0x2E8
	public Action<int> onTimeSkip; // 0x2F0
	protected float _currentSoilAmount; // 0x2F8
	protected float _currentMoistureAmount; // 0x2FC
	protected int _remainingSoilUses; // 0x300
	private List<MeshRenderer> _activeAdditiveDisplays; // 0x308
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x310
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x318
	private bool NetworkInitialize___EarlyScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted; // 0x320
	private bool NetworkInitialize__LateScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted; // 0x321

	// Properties
	public float SoilCapacity { get; set; }
	public float MoistureCapacity { get; set; }
	public bool HidePlantDuringPourTasks { get; set; }
	public Transform SoilContainer { get; set; }
	public Transform PourableStartPoint { get; set; }
	public GrowContainerSurfaceCover SurfaceCover { get; set; }
	public GrowContainerCameraHandler CameraHandler { get; set; }
	public TemperatureDisplay TemperatureDisplay { get; set; }
	public float NormalizedSoilAmount { get; }
	public bool IsFullyFilledWithSoil { get; }
	public float NormalizedMoistureAmount { get; }
	public SoilDefinition CurrentSoil { get; set; }
	public List<AdditiveDefinition> AppliedAdditives { get; set; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x860B60 Offset: 0x85F560 VA: 0x180860B60
	public float get_SoilCapacity() { }

	[CompilerGenerated]
	// RVA: 0x860C70 Offset: 0x85F670 VA: 0x180860C70
	private void set_SoilCapacity(float value) { }

	[CompilerGenerated]
	// RVA: 0x860AE0 Offset: 0x85F4E0 VA: 0x180860AE0
	public float get_MoistureCapacity() { }

	[CompilerGenerated]
	// RVA: 0x860BC0 Offset: 0x85F5C0 VA: 0x180860BC0
	private void set_MoistureCapacity(float value) { }

	[CompilerGenerated]
	// RVA: 0x860A30 Offset: 0x85F430 VA: 0x180860A30
	public bool get_HidePlantDuringPourTasks() { }

	[CompilerGenerated]
	// RVA: 0x860BA0 Offset: 0x85F5A0 VA: 0x180860BA0
	private void set_HidePlantDuringPourTasks(bool value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70
	public Transform get_SoilContainer() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80
	private void set_SoilContainer(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0
	public Transform get_PourableStartPoint() { }

	[CompilerGenerated]
	// RVA: 0x718C10 Offset: 0x717610 VA: 0x180718C10
	private void set_PourableStartPoint(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x860B70 Offset: 0x85F570 VA: 0x180860B70
	public GrowContainerSurfaceCover get_SurfaceCover() { }

	[CompilerGenerated]
	// RVA: 0x860CA0 Offset: 0x85F6A0 VA: 0x180860CA0
	private void set_SurfaceCover(GrowContainerSurfaceCover value) { }

	[CompilerGenerated]
	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0
	public GrowContainerCameraHandler get_CameraHandler() { }

	[CompilerGenerated]
	// RVA: 0x718BB0 Offset: 0x7175B0 VA: 0x180718BB0
	private void set_CameraHandler(GrowContainerCameraHandler value) { }

	[CompilerGenerated]
	// RVA: 0x640D50 Offset: 0x63F750 VA: 0x180640D50
	public TemperatureDisplay get_TemperatureDisplay() { }

	[CompilerGenerated]
	// RVA: 0x641370 Offset: 0x63FD70 VA: 0x180641370
	private void set_TemperatureDisplay(TemperatureDisplay value) { }

	// RVA: 0x860B40 Offset: 0x85F540 VA: 0x180860B40
	public float get_NormalizedSoilAmount() { }

	// RVA: 0x860A50 Offset: 0x85F450 VA: 0x180860A50
	public bool get_IsFullyFilledWithSoil() { }

	// RVA: 0x860B20 Offset: 0x85F520 VA: 0x180860B20
	public float get_NormalizedMoistureAmount() { }

	[CompilerGenerated]
	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20
	public SoilDefinition get_CurrentSoil() { }

	[CompilerGenerated]
	// RVA: 0x860B80 Offset: 0x85F580 VA: 0x180860B80
	private void set_CurrentSoil(SoilDefinition value) { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90
	public List<AdditiveDefinition> get_AppliedAdditives() { }

	[CompilerGenerated]
	// RVA: 0x81F780 Offset: 0x81E180 VA: 0x18081F780
	private void set_AppliedAdditives(List<AdditiveDefinition> value) { }

	[CompilerGenerated]
	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0x85E520 Offset: 0x85CF20 VA: 0x18085E520 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640C40 Offset: 0x63F640 VA: 0x180640C40 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0x860BD0 Offset: 0x85F5D0 VA: 0x180860BD0 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x860AF0 Offset: 0x85F4F0 VA: 0x180860AF0 Slot: 81
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0 Slot: 82
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x81F940 Offset: 0x81E340 VA: 0x18081F940 Slot: 83
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 84
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x81F960 Offset: 0x81E360 VA: 0x18081F960 Slot: 85
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0 Slot: 86
	public Transform get_LinkOrigin() { }

	// RVA: 0x860A10 Offset: 0x85F410 VA: 0x180860A10 Slot: 87
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x81F190 Offset: 0x81DB90 VA: 0x18081F190 Slot: 88
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x860A40 Offset: 0x85F440 VA: 0x180860A40 Slot: 89
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x860BB0 Offset: 0x85F5B0 VA: 0x180860BB0
	public void set_IsAcceptingItems(bool value) { }

	// RVA: 0x85C760 Offset: 0x85B160 VA: 0x18085C760
	public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState) { }

	// RVA: 0x85C7B0 Offset: 0x85B1B0 VA: 0x18085C7B0
	public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, Vector3 labelPosition) { }

	// RVA: 0x85C1F0 Offset: 0x85ABF0 VA: 0x18085C1F0 Slot: 47
	public override void Awake() { }

	// RVA: 0x85CEE0 Offset: 0x85B8E0 VA: 0x18085CEE0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x85CE30 Offset: 0x85B830 VA: 0x18085CE30
	private void HeatmapVisibilityChanged(Property property, bool visible) { }

	// RVA: 0x85C800 Offset: 0x85B200 VA: 0x18085C800 Slot: 56
	protected override void Destroy() { }

	// RVA: 0x85DD40 Offset: 0x85C740 VA: 0x18085DD40 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x85DC60 Offset: 0x85C660 VA: 0x18085DC60 Slot: 103
	protected virtual void OnMinPass() { }

	// RVA: 0x85DF40 Offset: 0x85C940 VA: 0x18085DF40 Slot: 104
	protected virtual void OnTimeSkipped(int minsSkipped) { }

	// RVA: 0x85CB30 Offset: 0x85B530 VA: 0x18085CB30
	private void DrainMoisture(int minutes) { }

	// RVA: 0x85CB70 Offset: 0x85B570 VA: 0x18085CB70
	public float GetAverageLightExposure(out float growSpeedMultiplier) { }

	// RVA: -1 Offset: -1 Slot: 105
	public abstract bool IsPointAboveGrowSurface(Vector3 point);

	// RVA: -1 Offset: -1 Slot: 106
	public abstract void SetGrowableVisible(bool visible);

	// RVA: -1 Offset: -1 Slot: 107
	public abstract float GetGrowSurfaceSideLength();

	// RVA: -1 Offset: -1 Slot: 108
	public abstract bool ContainsGrowable();

	// RVA: -1 Offset: -1 Slot: 109
	public abstract float GetGrowthProgressNormalized();

	// RVA: 0x860510 Offset: 0x85EF10 VA: 0x180860510 Slot: 110
	public virtual void SetSoil(SoilDefinition soil) { }

	// RVA: 0x85C420 Offset: 0x85AE20 VA: 0x18085C420
	public void ChangeSoilAmount(float amount) { }

	// RVA: 0x860250 Offset: 0x85EC50 VA: 0x180860250
	public void SetSoilAmount(float amount) { }

	// RVA: 0x6C87C0 Offset: 0x6C71C0 VA: 0x1806C87C0
	public void SetRemainingSoilUses(int uses) { }

	// RVA: 0x860690 Offset: 0x85F090 VA: 0x180860690
	public void SyncSoilData() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x85F7C0 Offset: 0x85E1C0 VA: 0x18085F7C0
	private void SetSoilData_Server(string soilID, float amount, int uses) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0x860290 Offset: 0x85EC90 VA: 0x180860290
	private void SetSoilData_Client(NetworkConnection conn, string soilID, float amount, int uses) { }

	// RVA: 0x85E2A0 Offset: 0x85CCA0 VA: 0x18085E2A0 Slot: 111
	protected virtual void RefreshSoilVisuals() { }

	// RVA: 0x85C650 Offset: 0x85B050 VA: 0x18085C650 Slot: 112
	protected virtual void ClearSoil() { }

	// RVA: 0x85D4D0 Offset: 0x85BED0 VA: 0x18085D4D0
	public bool IsSoilAllowed(SoilDefinition soil) { }

	// RVA: 0x85CD70 Offset: 0x85B770 VA: 0x18085CD70 Slot: 113
	protected virtual Material GetSoilMaterial() { }

	// RVA: 0x85C400 Offset: 0x85AE00 VA: 0x18085C400
	public void ChangeMoistureAmount(float amount) { }

	// RVA: 0x85FD70 Offset: 0x85E770 VA: 0x18085FD70 Slot: 114
	public virtual void SetMoistureAmount(float amount) { }

	// RVA: 0x860550 Offset: 0x85EF50 VA: 0x180860550
	public void SyncMoistureData() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x85F420 Offset: 0x85DE20 VA: 0x18085F420
	private void SetMoistureData_Server(float amount) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0x85FDB0 Offset: 0x85E7B0 VA: 0x18085FDB0
	private void SetMoistureData_Client(NetworkConnection conn, float amount) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x85BD10 Offset: 0x85A710 VA: 0x18085BD10
	public void ApplyAdditive_Server(string additiveID) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x85BA70 Offset: 0x85A470 VA: 0x18085BA70
	private void ApplyAdditive_Client(NetworkConnection conn, string additiveID, bool initialApplication) { }

	// RVA: 0x85BE50 Offset: 0x85A850 VA: 0x18085BE50 Slot: 115
	protected virtual AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication) { }

	// RVA: 0x718A60 Offset: 0x717460 VA: 0x180718A60 Slot: 116
	public virtual float GetTemperatureGrowthMultiplier() { }

	// RVA: 0x85D3C0 Offset: 0x85BDC0 VA: 0x18085D3C0
	public bool IsAdditiveApplied(string additiveID) { }

	// RVA: 0x85C470 Offset: 0x85AE70 VA: 0x18085C470
	protected void ClearAdditives() { }

	// RVA: 0x85C2A0 Offset: 0x85ACA0 VA: 0x18085C2A0 Slot: 117
	public virtual bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason) { }

	// RVA: 0x860210 Offset: 0x85EC10 VA: 0x180860210
	public void SetPourTargetActive(bool active) { }

	// RVA: 0x85DFC0 Offset: 0x85C9C0 VA: 0x18085DFC0
	public void RandomizePourTargetPosition() { }

	// RVA: 0x85CD30 Offset: 0x85B730 VA: 0x18085CD30
	public Vector3 GetCurrentTargetPosition() { }

	// RVA: -1 Offset: -1 Slot: 118
	protected abstract Vector3 GetRandomPourTargetPosition();

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8600E0 Offset: 0x85EAE0 VA: 0x1808600E0 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x85FFB0 Offset: 0x85E9B0 VA: 0x18085FFB0 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0x85D5A0 Offset: 0x85BFA0 VA: 0x18085D5A0
	protected void Load(GrowContainerData data) { }

	// RVA: 0x860890 Offset: 0x85F290 VA: 0x180860890
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x860880 Offset: 0x85F280 VA: 0x180860880
	private float <InitializeGridItem>b__99_0() { }

	// RVA: 0x85D760 Offset: 0x85C160 VA: 0x18085D760 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x85D6F0 Offset: 0x85C0F0 VA: 0x18085D6F0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x85F7C0 Offset: 0x85E1C0 VA: 0x18085F7C0
	private void RpcWriter___Server_SetSoilData_Server_3104499779(string soilID, float amount, int uses) { }

	// RVA: 0x85E860 Offset: 0x85D260 VA: 0x18085E860
	private void RpcLogic___SetSoilData_Server_3104499779(string soilID, float amount, int uses) { }

	// RVA: 0x85EC30 Offset: 0x85D630 VA: 0x18085EC30
	private void RpcReader___Server_SetSoilData_Server_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x85F160 Offset: 0x85DB60 VA: 0x18085F160
	private void RpcWriter___Observers_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses) { }

	// RVA: 0x85E7A0 Offset: 0x85D1A0 VA: 0x18085E7A0
	private void RpcLogic___SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses) { }

	// RVA: 0x85E9A0 Offset: 0x85D3A0 VA: 0x18085E9A0
	private void RpcReader___Observers_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85FBF0 Offset: 0x85E5F0 VA: 0x18085FBF0
	private void RpcWriter___Target_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses) { }

	// RVA: 0x85EDF0 Offset: 0x85D7F0 VA: 0x18085EDF0
	private void RpcReader___Target_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85F420 Offset: 0x85DE20 VA: 0x18085F420
	private void RpcWriter___Server_SetMoistureData_Server_431000436(float amount) { }

	// RVA: 0x85E510 Offset: 0x85CF10 VA: 0x18085E510
	private void RpcLogic___SetMoistureData_Server_431000436(float amount) { }

	// RVA: 0x85EAD0 Offset: 0x85D4D0 VA: 0x18085EAD0
	private void RpcReader___Server_SetMoistureData_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x85F010 Offset: 0x85DA10 VA: 0x18085F010
	private void RpcWriter___Observers_SetMoistureData_Client_530160725(NetworkConnection conn, float amount) { }

	// RVA: 0x85E4F0 Offset: 0x85CEF0 VA: 0x18085E4F0
	private void RpcLogic___SetMoistureData_Client_530160725(NetworkConnection conn, float amount) { }

	// RVA: 0x85E940 Offset: 0x85D340 VA: 0x18085E940
	private void RpcReader___Observers_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85FA90 Offset: 0x85E490 VA: 0x18085FA90
	private void RpcWriter___Target_SetMoistureData_Client_530160725(NetworkConnection conn, float amount) { }

	// RVA: 0x85ED80 Offset: 0x85D780 VA: 0x18085ED80
	private void RpcReader___Target_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85F2F0 Offset: 0x85DCF0 VA: 0x18085F2F0
	private void RpcWriter___Server_ApplyAdditive_Server_3615296227(string additiveID) { }

	// RVA: 0x85E4D0 Offset: 0x85CED0 VA: 0x18085E4D0
	public void RpcLogic___ApplyAdditive_Server_3615296227(string additiveID) { }

	// RVA: 0x85EA50 Offset: 0x85D450 VA: 0x18085EA50
	private void RpcReader___Server_ApplyAdditive_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x85EEA0 Offset: 0x85D8A0 VA: 0x18085EEA0
	private void RpcWriter___Observers_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication) { }

	// RVA: 0x85E4B0 Offset: 0x85CEB0 VA: 0x18085E4B0
	private void RpcLogic___ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication) { }

	// RVA: 0x85E890 Offset: 0x85D290 VA: 0x18085E890
	private void RpcReader___Observers_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85F930 Offset: 0x85E330 VA: 0x18085F930
	private void RpcWriter___Target_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication) { }

	// RVA: 0x85ECE0 Offset: 0x85D6E0 VA: 0x18085ECE0
	private void RpcReader___Target_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x85F690 Offset: 0x85E090 VA: 0x18085F690
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x85E5C0 Offset: 0x85CFC0 VA: 0x18085E5C0 Slot: 119
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x85EBB0 Offset: 0x85D5B0 VA: 0x18085EBB0
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x85F560 Offset: 0x85DF60 VA: 0x18085F560
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x85E520 Offset: 0x85CF20 VA: 0x18085E520 Slot: 120
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x85EB30 Offset: 0x85D530 VA: 0x18085EB30
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0x860CC0 Offset: 0x85F6C0 VA: 0x180860CC0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x85E170 Offset: 0x85CB70 VA: 0x18085E170 Slot: 121
	public override bool ReadSyncVar___ScheduleOne.Growing.GrowContainer(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640C40 Offset: 0x63F640 VA: 0x180640C40
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0x860D80 Offset: 0x85F780 VA: 0x180860D80
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x85C170 Offset: 0x85AB70 VA: 0x18085C170 Slot: 122
	protected override void Awake_UserLogic_ScheduleOne.Growing.GrowContainer_Assembly-CSharp.dll() { }
}
