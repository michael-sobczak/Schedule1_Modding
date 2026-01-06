public class LandVehicle : NetworkBehaviour, IGUIDRegisterable, ISaveable // TypeDefIndex: 2170
{
	// Fields
	public const float KINEMATIC_THRESHOLD_DISTANCE = 30;
	public const float MAX_TURNOVER_SPEED = 5;
	public const float TURNOVER_FORCE = 8;
	public const bool USE_WHEEL = False;
	public const float SPEED_DISPLAY_MULTIPLIER = 1.4;
	public bool DEBUG; // 0x118
	[SerializeField]
	[Header("Settings")]
	protected string vehicleName; // 0x120
	[SerializeField]
	protected string vehicleCode; // 0x128
	[SerializeField]
	protected float vehiclePrice; // 0x130
	[CompilerGenerated]
	private bool <IsPlayerOwned>k__BackingField; // 0x134
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; // 0x135
	public bool UseHumanoidCollider; // 0x136
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x138
	public bool SpawnAsPlayerOwned; // 0x148
	[Header("References")]
	[SerializeField]
	protected GameObject vehicleModel; // 0x150
	[SerializeField]
	protected WheelCollider[] driveWheels; // 0x158
	[SerializeField]
	protected WheelCollider[] steerWheels; // 0x160
	[SerializeField]
	protected WheelCollider[] handbrakeWheels; // 0x168
	[HideInInspector]
	public List<Wheel> wheels; // 0x170
	[SerializeField]
	protected InteractableObject intObj; // 0x178
	[SerializeField]
	protected List<Transform> exitPoints; // 0x180
	public Rigidbody Rb; // 0x188
	public VehicleColor Color; // 0x190
	public VehicleSeat[] Seats; // 0x198
	public BoxCollider boundingBox; // 0x1A0
	public VehicleAgent Agent; // 0x1A8
	public SmoothedVelocityCalculator VelocityCalculator; // 0x1B0
	public StorageDoorAnimation Trunk; // 0x1B8
	public NavMeshObstacle NavMeshObstacle; // 0x1C0
	public NavmeshCut NavmeshCut; // 0x1C8
	public VehicleHumanoidCollider HumanoidColliderContainer; // 0x1D0
	public POI POI; // 0x1D8
	private List<PlayerPusher> pushers; // 0x1E0
	[SerializeField]
	protected Transform centerOfMass; // 0x1E8
	[SerializeField]
	protected Transform cameraOrigin; // 0x1F0
	[SerializeField]
	protected VehicleLights lights; // 0x1F8
	[Header("Steer settings")]
	[SerializeField]
	protected float maxSteeringAngle; // 0x200
	[SerializeField]
	protected float steerRate; // 0x204
	[SerializeField]
	protected bool flipSteer; // 0x208
	[CompilerGenerated]
	private bool <MaxSteerAngleOverridden>k__BackingField; // 0x209
	[CompilerGenerated]
	private float <OverriddenMaxSteerAngle>k__BackingField; // 0x20C
	[Header("Drive settings")]
	[SerializeField]
	protected AnimationCurve motorTorque; // 0x210
	public float TopSpeed; // 0x218
	[SerializeField]
	[Range(2, 16)]
	protected float diffGearing; // 0x21C
	[SerializeField]
	protected float handBrakeForce; // 0x220
	[SerializeField]
	protected AnimationCurve brakeForce; // 0x228
	[SerializeField]
	[Range(0.1, 3)]
	protected float BrakeForceMultiplier; // 0x230
	[SerializeField]
	[Range(0.5, 10)]
	protected float downforce; // 0x234
	[SerializeField]
	[Range(0, 1)]
	protected float reverseMultiplier; // 0x238
	[Header("Control overrides")]
	public bool overrideControls; // 0x23C
	public float throttleOverride; // 0x240
	public float steerOverride; // 0x244
	[Header("Storage settings")]
	public StorageEntity Storage; // 0x248
	private VehicleSeat localPlayerSeat; // 0x250
	[CompilerGenerated]
	private bool <LocalPlayerIsDriver>k__BackingField; // 0x258
	[CompilerGenerated]
	private bool <LocalPlayerIsInVehicle>k__BackingField; // 0x259
	private bool _isOccupied; // 0x25A
	[CompilerGenerated]
	private NPC[] <OccupantNPCs>k__BackingField; // 0x260
	[CompilerGenerated]
	private float <Speed_Kmh>k__BackingField; // 0x268
	[CompilerGenerated]
	private bool <IsPhysicallySimulated>k__BackingField; // 0x26C
	private RollingAverage<float> previousSpeeds; // 0x270
	private const int previousSpeedsSampleSize = 20;
	[CompilerGenerated]
	private float <currentThrottle>k__BackingField; // 0x278
	[SyncVar(Channel = 1, SendRate = 0.05, WritePermissions = 1)]
	[CompilerGenerated]
	public float <CurrentSteerAngle>k__BackingField; // 0x27C
	private float lastFrameSteerAngle; // 0x280
	private float lastReplicatedSteerAngle; // 0x284
	private bool justExitedVehicle; // 0x288
	[SyncVar(Channel = 1, SendRate = 0.1, WritePermissions = 1)]
	[CompilerGenerated]
	public bool <BrakesApplied>k__BackingField; // 0x289
	[SyncVar(Channel = 1, SendRate = 0.1, WritePermissions = 1)]
	[CompilerGenerated]
	public bool <IsReversing>k__BackingField; // 0x28A
	[CompilerGenerated]
	private bool <handbrakeApplied>k__BackingField; // 0x28B
	private Vector3 lastFramePosition; // 0x28C
	private Transform closestExitPoint; // 0x298
	private float timeOnSpawn; // 0x2A0
	private float timeOnLastOccupied; // 0x2A4
	[CompilerGenerated]
	private EVehicleColor <OwnedColor>k__BackingField; // 0x2A8
	[HideInInspector]
	public ParkData CurrentParkData; // 0x2B0
	[CompilerGenerated]
	private ParkingLot <CurrentParkingLot>k__BackingField; // 0x2B8
	[CompilerGenerated]
	private ParkingSpot <CurrentParkingSpot>k__BackingField; // 0x2C0
	private VehicleLoader loader; // 0x2C8
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x2D0
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x2D8
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x2E0
	public Action onVehicleStart; // 0x2E8
	public Action onVehicleStop; // 0x2F0
	public Action onHandbrakeApplied; // 0x2F8
	public Action<Collision> onCollision; // 0x300
	public SyncVar<float> syncVar___<CurrentSteerAngle>k__BackingField; // 0x308
	public SyncVar<bool> syncVar___<BrakesApplied>k__BackingField; // 0x310
	public SyncVar<bool> syncVar___<IsReversing>k__BackingField; // 0x318
	private bool NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted; // 0x320
	private bool NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted; // 0x321

	// Properties
	public string VehicleName { get; }
	public string VehicleCode { get; }
	public float VehiclePrice { get; }
	public bool IsPlayerOwned { get; set; }
	public bool IsVisible { get; set; }
	public Guid GUID { get; set; }
	public Vector3 BoundingBoxDimensions { get; }
	public Transform driverEntryPoint { get; }
	public float ActualMaxSteeringAngle { get; }
	public bool MaxSteerAngleOverridden { get; set; }
	public float OverriddenMaxSteerAngle { get; set; }
	public int Capacity { get; }
	public int CurrentPlayerOccupancy { get; }
	public bool LocalPlayerIsDriver { get; set; }
	public bool LocalPlayerIsInVehicle { get; set; }
	public bool IsOccupied { get; set; }
	public Player DriverPlayer { get; }
	public List<Player> OccupantPlayers { get; }
	public NPC[] OccupantNPCs { get; set; }
	public float Speed_Kmh { get; set; }
	public bool IsPhysicallySimulated { get; set; }
	public float currentThrottle { get; set; }
	public float CurrentSteerAngle { get; set; }
	[HideInInspector]
	public bool BrakesApplied { get; set; }
	[HideInInspector]
	public bool IsReversing { get; set; }
	public bool handbrakeApplied { get; set; }
	public float boundingBaseOffset { get; }
	private float timeSinceSpawn { get; }
	public float timeSinceLastOccupied { get; }
	public EVehicleColor OwnedColor { get; set; }
	public bool isParked { get; }
	public ParkingLot CurrentParkingLot { get; set; }
	public ParkingSpot CurrentParkingSpot { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public float SyncAccessor_<CurrentSteerAngle>k__BackingField { get; set; }
	public bool SyncAccessor_<BrakesApplied>k__BackingField { get; set; }
	public bool SyncAccessor_<IsReversing>k__BackingField { get; set; }

	// Methods

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public string get_VehicleName() { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public string get_VehicleCode() { }

	// RVA: 0x718AA0 Offset: 0x7174A0 VA: 0x180718AA0
	public float get_VehiclePrice() { }

	[CompilerGenerated]
	// RVA: 0x66FB80 Offset: 0x66E580 VA: 0x18066FB80
	public bool get_IsPlayerOwned() { }

	[CompilerGenerated]
	// RVA: 0x66FC30 Offset: 0x66E630 VA: 0x18066FC30
	protected void set_IsPlayerOwned(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F1C0 Offset: 0x81DBC0 VA: 0x18081F1C0
	public bool get_IsVisible() { }

	[CompilerGenerated]
	// RVA: 0x81F930 Offset: 0x81E330 VA: 0x18081F930
	protected void set_IsVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F180 Offset: 0x81DB80 VA: 0x18081F180 Slot: 19
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x81F830 Offset: 0x81E230 VA: 0x18081F830
	protected void set_GUID(Guid value) { }

	// RVA: 0x81EDE0 Offset: 0x81D7E0 VA: 0x18081EDE0
	public Vector3 get_BoundingBoxDimensions() { }

	// RVA: 0x81F5F0 Offset: 0x81DFF0 VA: 0x18081F5F0
	public Transform get_driverEntryPoint() { }

	// RVA: 0x81EDC0 Offset: 0x81D7C0 VA: 0x18081EDC0
	public float get_ActualMaxSteeringAngle() { }

	[CompilerGenerated]
	// RVA: 0x81F210 Offset: 0x81DC10 VA: 0x18081F210
	public bool get_MaxSteerAngleOverridden() { }

	[CompilerGenerated]
	// RVA: 0x81F9A0 Offset: 0x81E3A0 VA: 0x18081F9A0
	private void set_MaxSteerAngleOverridden(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F430 Offset: 0x81DE30 VA: 0x18081F430
	public float get_OverriddenMaxSteerAngle() { }

	[CompilerGenerated]
	// RVA: 0x81F9B0 Offset: 0x81E3B0 VA: 0x18081F9B0
	private void set_OverriddenMaxSteerAngle(float value) { }

	// RVA: 0x81EF70 Offset: 0x81D970 VA: 0x18081EF70
	public int get_Capacity() { }

	// RVA: 0x81EFA0 Offset: 0x81D9A0 VA: 0x18081EFA0
	public int get_CurrentPlayerOccupancy() { }

	[CompilerGenerated]
	// RVA: 0x81F1F0 Offset: 0x81DBF0 VA: 0x18081F1F0
	public bool get_LocalPlayerIsDriver() { }

	[CompilerGenerated]
	// RVA: 0x81F980 Offset: 0x81E380 VA: 0x18081F980
	protected void set_LocalPlayerIsDriver(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F200 Offset: 0x81DC00 VA: 0x18081F200
	public bool get_LocalPlayerIsInVehicle() { }

	[CompilerGenerated]
	// RVA: 0x81F990 Offset: 0x81E390 VA: 0x18081F990
	protected void set_LocalPlayerIsInVehicle(bool value) { }

	// RVA: 0x81F1A0 Offset: 0x81DBA0 VA: 0x18081F1A0
	public bool get_IsOccupied() { }

	// RVA: 0x81F850 Offset: 0x81E250 VA: 0x18081F850
	public void set_IsOccupied(bool value) { }

	// RVA: 0x81F0D0 Offset: 0x81DAD0 VA: 0x18081F0D0
	public Player get_DriverPlayer() { }

	// RVA: 0x81F220 Offset: 0x81DC20 VA: 0x18081F220
	public List<Player> get_OccupantPlayers() { }

	[CompilerGenerated]
	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0
	public NPC[] get_OccupantNPCs() { }

	[CompilerGenerated]
	// RVA: 0x718C10 Offset: 0x717610 VA: 0x180718C10
	protected void set_OccupantNPCs(NPC[] value) { }

	[CompilerGenerated]
	// RVA: 0x81F510 Offset: 0x81DF10 VA: 0x18081F510
	public float get_Speed_Kmh() { }

	[CompilerGenerated]
	// RVA: 0x81F9D0 Offset: 0x81E3D0 VA: 0x18081F9D0
	protected void set_Speed_Kmh(float value) { }

	[CompilerGenerated]
	// RVA: 0x640EF0 Offset: 0x63F8F0 VA: 0x180640EF0
	public bool get_IsPhysicallySimulated() { }

	[CompilerGenerated]
	// RVA: 0x6415C0 Offset: 0x63FFC0 VA: 0x1806415C0
	protected void set_IsPhysicallySimulated(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F5E0 Offset: 0x81DFE0 VA: 0x18081F5E0
	public float get_currentThrottle() { }

	[CompilerGenerated]
	// RVA: 0x81F9E0 Offset: 0x81E3E0 VA: 0x18081F9E0
	protected void set_currentThrottle(float value) { }

	[CompilerGenerated]
	// RVA: 0x81F0C0 Offset: 0x81DAC0 VA: 0x18081F0C0
	public float get_CurrentSteerAngle() { }

	[CompilerGenerated]
	// RVA: 0x81F7A0 Offset: 0x81E1A0 VA: 0x18081F7A0
	public void set_CurrentSteerAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x81EF60 Offset: 0x81D960 VA: 0x18081EF60
	public bool get_BrakesApplied() { }

	[CompilerGenerated]
	// RVA: 0x81F6F0 Offset: 0x81E0F0 VA: 0x18081F6F0
	public void set_BrakesApplied(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F1B0 Offset: 0x81DBB0 VA: 0x18081F1B0
	public bool get_IsReversing() { }

	[CompilerGenerated]
	// RVA: 0x81F8A0 Offset: 0x81E2A0 VA: 0x18081F8A0
	public void set_IsReversing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81F640 Offset: 0x81E040 VA: 0x18081F640
	public bool get_handbrakeApplied() { }

	[CompilerGenerated]
	// RVA: 0x81F9F0 Offset: 0x81E3F0 VA: 0x18081F9F0
	protected void set_handbrakeApplied(bool value) { }

	// RVA: 0x81F520 Offset: 0x81DF20 VA: 0x18081F520
	public float get_boundingBaseOffset() { }

	// RVA: 0x81F6D0 Offset: 0x81E0D0 VA: 0x18081F6D0
	private float get_timeSinceSpawn() { }

	// RVA: 0x81F6B0 Offset: 0x81E0B0 VA: 0x18081F6B0
	public float get_timeSinceLastOccupied() { }

	[CompilerGenerated]
	// RVA: 0x81F440 Offset: 0x81DE40 VA: 0x18081F440
	public EVehicleColor get_OwnedColor() { }

	[CompilerGenerated]
	// RVA: 0x81F9C0 Offset: 0x81E3C0 VA: 0x18081F9C0
	private void set_OwnedColor(EVehicleColor value) { }

	// RVA: 0x81F650 Offset: 0x81E050 VA: 0x18081F650
	public bool get_isParked() { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90
	public ParkingLot get_CurrentParkingLot() { }

	[CompilerGenerated]
	// RVA: 0x81F780 Offset: 0x81E180 VA: 0x18081F780
	protected void set_CurrentParkingLot(ParkingLot value) { }

	[CompilerGenerated]
	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public ParkingSpot get_CurrentParkingSpot() { }

	[CompilerGenerated]
	// RVA: 0x641350 Offset: 0x63FD50 VA: 0x180641350
	protected void set_CurrentParkingSpot(ParkingSpot value) { }

	// RVA: 0x81F480 Offset: 0x81DE80 VA: 0x18081F480 Slot: 22
	public string get_SaveFolderName() { }

	// RVA: 0x81F450 Offset: 0x81DE50 VA: 0x18081F450 Slot: 23
	public string get_SaveFileName() { }

	// RVA: 0x640C40 Offset: 0x63F640 VA: 0x180640C40 Slot: 24
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 25
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0 Slot: 26
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x81F940 Offset: 0x81E340 VA: 0x18081F940 Slot: 27
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 28
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x81F960 Offset: 0x81E360 VA: 0x18081F960 Slot: 29
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x81F190 Offset: 0x81DB90 VA: 0x18081F190 Slot: 30
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x81F840 Offset: 0x81E240 VA: 0x18081F840 Slot: 31
	public void set_HasChanged(bool value) { }

	// RVA: 0x815100 Offset: 0x813B00 VA: 0x180815100 Slot: 45
	public override void Awake() { }

	// RVA: 0x817450 Offset: 0x815E50 VA: 0x180817450 Slot: 46
	public virtual void InitializeSaveable() { }

	// RVA: 0x818620 Offset: 0x817020 VA: 0x180818620 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x8183E0 Offset: 0x816DE0 VA: 0x1808183E0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x8185F0 Offset: 0x816FF0 VA: 0x1808185F0 Slot: 11
	public override void OnStartClient() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x81C090 Offset: 0x81AA90 VA: 0x18081C090
	public void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned) { }

	// RVA: 0x818FC0 Offset: 0x8179C0 VA: 0x180818FC0
	private void RefreshPoI() { }

	// RVA: 0x81C020 Offset: 0x81AA20 VA: 0x18081C020 Slot: 21
	public void SetGUID(Guid guid) { }

	// RVA: 0x81CEE0 Offset: 0x81B8E0 VA: 0x18081CEE0 Slot: 47
	protected virtual void Start() { }

	// RVA: 0x816150 Offset: 0x814B50 VA: 0x180816150
	private void Exit(ExitAction action) { }

	// RVA: 0x818030 Offset: 0x816A30 VA: 0x180818030 Slot: 48
	protected virtual void OnDestroy() { }

	// RVA: 0x816EB0 Offset: 0x8158B0 VA: 0x180816EB0
	private void GetNetworth(MoneyManager.FloatContainer container) { }

	// RVA: 0x81E3D0 Offset: 0x81CDD0 VA: 0x18081E3D0 Slot: 49
	protected virtual void Update() { }

	// RVA: 0x8161A0 Offset: 0x814BA0 VA: 0x1808161A0 Slot: 50
	protected virtual void FixedUpdate() { }

	// RVA: 0x81DB20 Offset: 0x81C520 VA: 0x18081DB20
	private void UpdateSpeedCalculation() { }

	// RVA: 0x81D530 Offset: 0x81BF30 VA: 0x18081D530
	private void UpdateOutOfBounds() { }

	// RVA: 0x818000 Offset: 0x816A00 VA: 0x180818000
	private void OnCollisionEnter(Collision collision) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x81B170 Offset: 0x819B70 VA: 0x18081B170 Slot: 51
	protected virtual void SetOwner(NetworkConnection conn) { }

	[ObserversRpc]
	// RVA: 0x8182C0 Offset: 0x816CC0 VA: 0x1808182C0 Slot: 52
	protected virtual void OnOwnerChanged() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x81CA20 Offset: 0x81B420 VA: 0x18081CA20
	public void SetTransform_Server(Vector3 pos, Quaternion rot) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x81CAB0 Offset: 0x81B4B0 VA: 0x18081CAB0
	public void SetTransform(Vector3 pos, Quaternion rot) { }

	// RVA: 0x8151D0 Offset: 0x813BD0 VA: 0x1808151D0
	public void DestroyVehicle() { }

	// RVA: 0x81E160 Offset: 0x81CB60 VA: 0x18081E160 Slot: 53
	protected virtual void UpdateThrottle() { }

	// RVA: 0x814490 Offset: 0x812E90 VA: 0x180814490 Slot: 54
	protected virtual void ApplyThrottle() { }

	// RVA: 0x814320 Offset: 0x812D20 VA: 0x180814320
	public void ApplyHandbrake() { }

	// RVA: 0x814260 Offset: 0x812C60 VA: 0x180814260
	private void ApplyDownForce() { }

	// RVA: 0x81E1F0 Offset: 0x81CBF0 VA: 0x18081E1F0
	private void UpdateTurnOver() { }

	// RVA: 0x81DD10 Offset: 0x81C710 VA: 0x18081DD10 Slot: 55
	protected virtual void UpdateSteerAngle() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x81B410 Offset: 0x819E10 VA: 0x18081B410
	private void SetSteeringAngle(float sa) { }

	// RVA: 0x814400 Offset: 0x812E00 VA: 0x180814400 Slot: 56
	protected virtual void ApplySteerAngle() { }

	// RVA: 0x814080 Offset: 0x812A80 VA: 0x180814080
	public void AlignTo(Transform target, EParkingAlignment type, bool network = False) { }

	// RVA: 0x816620 Offset: 0x815020 VA: 0x180816620
	public Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type) { }

	// RVA: 0x718AA0 Offset: 0x7174A0 VA: 0x180718AA0
	public float GetVehicleValue() { }

	// RVA: 0x8186A0 Offset: 0x8170A0 VA: 0x1808186A0
	public void OverrideMaxSteerAngle(float maxAngle) { }

	// RVA: 0x819570 Offset: 0x817F70 VA: 0x180819570
	public void ResetMaxSteerAngle() { }

	// RVA: 0x81C2F0 Offset: 0x81ACF0 VA: 0x18081C2F0
	public void SetObstaclesActive(bool active) { }

	// RVA: 0x81D880 Offset: 0x81C280 VA: 0x18081D880
	private void UpdatePhysicallySimulated(bool forceApply = False) { }

	// RVA: 0x81CC60 Offset: 0x81B660 VA: 0x18081CC60
	private bool ShouldBePhysicallySimulated() { }

	// RVA: 0x816DF0 Offset: 0x8157F0 VA: 0x180816DF0
	public VehicleSeat GetFirstFreeSeat() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x81C760 Offset: 0x81B160 VA: 0x18081C760
	private void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x81C5F0 Offset: 0x81AFF0 VA: 0x18081C5F0
	private void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn) { }

	// RVA: 0x817360 Offset: 0x815D60 VA: 0x180817360
	private void Hovered() { }

	// RVA: 0x8174E0 Offset: 0x815EE0 VA: 0x1808174E0
	private void Interacted() { }

	// RVA: 0x81CE50 Offset: 0x81B850 VA: 0x18081CE50
	private void StartVehicle() { }

	// RVA: 0x81D4A0 Offset: 0x81BEA0 VA: 0x18081D4A0
	private void StopVehicle() { }

	// RVA: 0x815390 Offset: 0x813D90 VA: 0x180815390
	private void EnterVehicle() { }

	// RVA: 0x815D00 Offset: 0x814700 VA: 0x180815D00
	public void ExitVehicle() { }

	// RVA: 0x815380 Offset: 0x813D80 VA: 0x180815380
	private void EndJustExited() { }

	// RVA: 0x816D90 Offset: 0x815790 VA: 0x180816D90
	public Transform GetExitPoint(int seatIndex = 0) { }

	// RVA: 0x816A00 Offset: 0x815400 VA: 0x180816A00
	private Transform GetClosestExitPoint(Vector3 pos) { }

	// RVA: 0x816F30 Offset: 0x815930 VA: 0x180816F30
	private Transform GetValidExitPoint(List<Transform> possibleExitPoints) { }

	// RVA: 0x813E10 Offset: 0x812810 VA: 0x180813E10
	public void AddNPCOccupant(NPC npc) { }

	// RVA: 0x8192B0 Offset: 0x817CB0 VA: 0x1808192B0
	public void RemoveNPCOccupant(NPC npc) { }

	// RVA: 0x815150 Offset: 0x813B50 VA: 0x180815150 Slot: 57
	public virtual bool CanBeRecovered() { }

	// RVA: 0x818DF0 Offset: 0x8177F0 VA: 0x180818DF0 Slot: 58
	public virtual void RecoverVehicle() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x81BEE0 Offset: 0x81A8E0 VA: 0x18081BEE0
	public void SendOwnedColor(EVehicleColor col) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x81C370 Offset: 0x81AD70 VA: 0x18081C370 Slot: 59
	protected virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col) { }

	// RVA: 0x814230 Offset: 0x812C30 VA: 0x180814230
	public void ApplyColor(EVehicleColor col) { }

	// RVA: 0x8143C0 Offset: 0x812DC0 VA: 0x1808143C0
	public void ApplyOwnedColor() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x8186B0 Offset: 0x8170B0 VA: 0x1808186B0
	private void Park_Networked(NetworkConnection conn, ParkData parkData) { }

	// RVA: 0x818920 Offset: 0x817320 VA: 0x180818920
	public void Park(NetworkConnection conn, ParkData parkData, bool network) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x815920 Offset: 0x814320 VA: 0x180815920
	public void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = True) { }

	// RVA: 0x815B80 Offset: 0x814580 VA: 0x180815B80
	public void ExitPark(bool moveToExitPoint = True) { }

	// RVA: 0x81CBB0 Offset: 0x81B5B0 VA: 0x18081CBB0
	public void SetVisible(bool vis) { }

	// RVA: 0x8191D0 Offset: 0x817BD0 VA: 0x1808191D0
	public void RegisterPusher(PlayerPusher pusher) { }

	// RVA: 0x815170 Offset: 0x813B70 VA: 0x180815170
	public void DeregisterPusher(PlayerPusher pusher) { }

	// RVA: 0x816CB0 Offset: 0x8156B0 VA: 0x180816CB0
	public List<ItemInstance> GetContents() { }

	// RVA: 0x817150 Offset: 0x815B50 VA: 0x180817150 Slot: 60
	public virtual VehicleData GetVehicleData() { }

	// RVA: 0x816EF0 Offset: 0x8158F0 VA: 0x180816EF0 Slot: 33
	public string GetSaveString() { }

	// RVA: 0x816BE0 Offset: 0x8155E0 VA: 0x180816BE0
	private ItemSet GetContentsSet() { }

	// RVA: 0x817530 Offset: 0x815F30 VA: 0x180817530 Slot: 61
	public virtual void Load(VehicleData data, string containerPath) { }

	// RVA: 0x81E580 Offset: 0x81CF80 VA: 0x18081E580
	public void .ctor() { }

	// RVA: 0x8178C0 Offset: 0x8162C0 VA: 0x1808178C0 Slot: 62
	public override void NetworkInitialize___Early() { }

	// RVA: 0x817830 Offset: 0x816230 VA: 0x180817830 Slot: 63
	public override void NetworkInitialize__Late() { }

	// RVA: 0x8124B0 Offset: 0x810EB0 VA: 0x1808124B0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x81A980 Offset: 0x819380 VA: 0x18081A980
	private void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned) { }

	// RVA: 0x8196D0 Offset: 0x8180D0 VA: 0x1808196D0
	public void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned) { }

	// RVA: 0x819E90 Offset: 0x818890 VA: 0x180819E90
	private void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81BAB0 Offset: 0x81A4B0 VA: 0x18081BAB0
	private void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned) { }

	// RVA: 0x81A570 Offset: 0x818F70 VA: 0x18081A570
	private void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B170 Offset: 0x819B70 VA: 0x18081B170
	private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn) { }

	// RVA: 0x8198C0 Offset: 0x8182C0 VA: 0x1808198C0 Slot: 64
	protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn) { }

	// RVA: 0x81A230 Offset: 0x818C30 VA: 0x18081A230
	private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8182C0 Offset: 0x816CC0 VA: 0x1808182C0
	private void RpcWriter___Observers_OnOwnerChanged_2166136261() { }

	// RVA: 0x819590 Offset: 0x817F90 VA: 0x180819590 Slot: 65
	protected virtual void RpcLogic___OnOwnerChanged_2166136261() { }

	// RVA: 0x819D20 Offset: 0x818720 VA: 0x180819D20
	private void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B550 Offset: 0x819F50 VA: 0x18081B550
	private void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot) { }

	// RVA: 0x819C60 Offset: 0x818660 VA: 0x180819C60
	public void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot) { }

	// RVA: 0x81A3A0 Offset: 0x818DA0 VA: 0x18081A3A0
	private void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x81AD80 Offset: 0x819780 VA: 0x18081AD80
	private void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot) { }

	// RVA: 0x819B80 Offset: 0x818580 VA: 0x180819B80
	public void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot) { }

	// RVA: 0x81A020 Offset: 0x818A20 VA: 0x18081A020
	private void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B410 Offset: 0x819E10 VA: 0x18081B410
	private void RpcWriter___Server_SetSteeringAngle_431000436(float sa) { }

	// RVA: 0x819B70 Offset: 0x818570 VA: 0x180819B70
	private void RpcLogic___SetSteeringAngle_431000436(float sa) { }

	// RVA: 0x81A340 Offset: 0x818D40 VA: 0x18081A340
	private void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x81AC00 Offset: 0x819600 VA: 0x18081AC00
	private void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant) { }

	// RVA: 0x819900 Offset: 0x818300 VA: 0x180819900
	private void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant) { }

	// RVA: 0x819F90 Offset: 0x818990 VA: 0x180819F90
	private void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81BD70 Offset: 0x81A770 VA: 0x18081BD70
	private void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant) { }

	// RVA: 0x81A670 Offset: 0x819070 VA: 0x18081A670
	private void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B2A0 Offset: 0x819CA0 VA: 0x18081B2A0
	private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn) { }

	// RVA: 0x819B50 Offset: 0x818550 VA: 0x180819B50
	private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn) { }

	// RVA: 0x81A2A0 Offset: 0x818CA0 VA: 0x18081A2A0
	private void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x81B040 Offset: 0x819A40 VA: 0x18081B040
	private void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col) { }

	// RVA: 0x8196B0 Offset: 0x8180B0 VA: 0x1808196B0
	public void RpcLogic___SendOwnedColor_911055161(EVehicleColor col) { }

	// RVA: 0x81A1B0 Offset: 0x818BB0 VA: 0x18081A1B0
	private void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x81BC10 Offset: 0x81A610 VA: 0x18081BC10
	private void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col) { }

	// RVA: 0x819870 Offset: 0x818270 VA: 0x180819870 Slot: 66
	protected virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col) { }

	// RVA: 0x81A5F0 Offset: 0x818FF0 VA: 0x18081A5F0
	private void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81AAC0 Offset: 0x8194C0 VA: 0x18081AAC0
	private void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col) { }

	// RVA: 0x819F10 Offset: 0x818910 VA: 0x180819F10
	private void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81A840 Offset: 0x819240 VA: 0x18081A840
	private void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData) { }

	// RVA: 0x819690 Offset: 0x818090 VA: 0x180819690
	private void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData) { }

	// RVA: 0x819E30 Offset: 0x818830 VA: 0x180819E30
	private void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B950 Offset: 0x81A350 VA: 0x18081B950
	private void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData) { }

	// RVA: 0x81A510 Offset: 0x818F10 VA: 0x18081A510
	private void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81A700 Offset: 0x819100 VA: 0x18081A700
	private void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = True) { }

	// RVA: 0x819580 Offset: 0x817F80 VA: 0x180819580
	public void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = True) { }

	// RVA: 0x819CA0 Offset: 0x8186A0 VA: 0x180819CA0
	private void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81B7F0 Offset: 0x81A1F0 VA: 0x18081B7F0
	private void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = True) { }

	// RVA: 0x81A4A0 Offset: 0x818EA0 VA: 0x18081A4A0
	private void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x81F0C0 Offset: 0x81DAC0 VA: 0x18081F0C0
	public float sync___get_value_<CurrentSteerAngle>k__BackingField() { }

	// RVA: 0x81FAC0 Offset: 0x81E4C0 VA: 0x18081FAC0
	public void sync___set_value_<CurrentSteerAngle>k__BackingField(float value, bool asServer) { }

	// RVA: 0x818BD0 Offset: 0x8175D0 VA: 0x180818BD0 Slot: 67
	public override bool ReadSyncVar___ScheduleOne.Vehicles.LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x81EF60 Offset: 0x81D960 VA: 0x18081EF60
	public bool sync___get_value_<BrakesApplied>k__BackingField() { }

	// RVA: 0x81FA00 Offset: 0x81E400 VA: 0x18081FA00
	public void sync___set_value_<BrakesApplied>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x81F1B0 Offset: 0x81DBB0 VA: 0x18081F1B0
	public bool sync___get_value_<IsReversing>k__BackingField() { }

	// RVA: 0x81FB80 Offset: 0x81E580 VA: 0x18081FB80
	public void sync___set_value_<IsReversing>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x814C70 Offset: 0x813670 VA: 0x180814C70 Slot: 68
	protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.LandVehicle_Assembly-CSharp.dll() { }
}
