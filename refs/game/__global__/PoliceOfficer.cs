public class PoliceOfficer : NPC // TypeDefIndex: 2061
{
	// Fields
	public const float DEACTIVATION_TIME = 1;
	public const float INVESTIGATION_COOLDOWN = 60;
	public const float INVESTIGATION_MAX_DISTANCE = 8;
	public const float INVESTIGATION_MIN_VISIBILITY = 0.2;
	public const float INVESTIGATION_CHECK_INTERVAL = 1;
	public const float BODY_SEARCH_CHANCE_DEFAULT = 0.1;
	public const float MIN_CHATTER_INTERVAL = 15;
	public const float MAX_CHATTER_INTERVAL = 45;
	public static Action<VisionEventReceipt> OnPoliceVisionEvent; // 0x0
	public static List<PoliceOfficer> Officers; // 0x8
	public LandVehicle AssignedVehicle; // 0x2F0
	[Header("References")]
	public PursuitBehaviour PursuitBehaviour; // 0x2F8
	public VehiclePursuitBehaviour VehiclePursuitBehaviour; // 0x300
	public BodySearchBehaviour BodySearchBehaviour; // 0x308
	public CheckpointBehaviour CheckpointBehaviour; // 0x310
	public FootPatrolBehaviour FootPatrolBehaviour; // 0x318
	public ProximityCircle ProxCircle; // 0x320
	public VehiclePatrolBehaviour VehiclePatrolBehaviour; // 0x328
	public SentryBehaviour SentryBehaviour; // 0x330
	public PoliceChatterVO ChatterVO; // 0x338
	public Behaviour[] DeactivationBlockingBehaviours; // 0x340
	[Header("Dialogue")]
	public DialogueContainer CheckpointDialogue; // 0x348
	[Header("Tools")]
	public AvatarEquippable BatonPrefab; // 0x350
	public AvatarEquippable TaserPrefab; // 0x358
	public AvatarEquippable GunPrefab; // 0x360
	[Header("Settings")]
	public bool AutoDeactivate; // 0x368
	public bool ChatterEnabled; // 0x369
	[Range(0, 1)]
	[Header("Behaviour Settings")]
	public float Suspicion; // 0x36C
	[Range(0, 1)]
	public float Leniency; // 0x370
	[Header("Body Search Settings")]
	[Range(0, 1)]
	public float BodySearchChance; // 0x374
	[Range(1, 10)]
	public float BodySearchDuration; // 0x378
	[HideInInspector]
	public PoliceBelt belt; // 0x380
	private float timeSinceReadyToPool; // 0x388
	private float timeSinceOutOfSight; // 0x38C
	private float chatterCountDown; // 0x390
	private Investigation currentBodySearchInvestigation; // 0x398
	private bool generalCrimeResponseActive; // 0x3A0
	private bool NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted; // 0x3A1
	private bool NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted; // 0x3A2

	// Properties
	public NetworkObject PursuitTarget { get; }

	// Methods

	// RVA: 0x7E9EE0 Offset: 0x7E88E0 VA: 0x1807E9EE0
	public NetworkObject get_PursuitTarget() { }

	// RVA: 0x7E5630 Offset: 0x7E4030 VA: 0x1807E5630 Slot: 65
	public override void Awake() { }

	// RVA: 0x7E8FD0 Offset: 0x7E79D0 VA: 0x1807E8FD0 Slot: 71
	protected override void Start() { }

	// RVA: 0x7E7320 Offset: 0x7E5D20 VA: 0x1807E7320 Slot: 72
	protected override void OnDestroy() { }

	// RVA: 0x7E9D30 Offset: 0x7E8730 VA: 0x1807E9D30
	protected void Update() { }

	// RVA: 0x7E7400 Offset: 0x7E5E00 VA: 0x1807E7400 Slot: 74
	protected override void OnTick() { }

	// RVA: 0x7E98E0 Offset: 0x7E82E0 VA: 0x1807E98E0
	private void UpdateVision() { }

	// RVA: 0x7E6090 Offset: 0x7E4A90 VA: 0x1807E6090
	private void CheckDeactivation() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x7E5970 Offset: 0x7E4370 VA: 0x1807E5970 Slot: 111
	public virtual void BeginFootPursuit_Networked(string playerCode, bool includeColleagues = True) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7E5AC0 Offset: 0x7E44C0 VA: 0x1807E5AC0
	private void BeginFootPursuit(string playerCode) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x7E5C00 Offset: 0x7E4600 VA: 0x1807E5C00 Slot: 112
	public virtual void BeginVehiclePursuit_Networked(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7E5D80 Offset: 0x7E4780 VA: 0x1807E5D80
	private void BeginVehiclePursuit(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	// RVA: 0x7E5680 Offset: 0x7E4080 VA: 0x1807E5680
	public void BeginBodySearch_LocalPlayer() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x7E5700 Offset: 0x7E4100 VA: 0x1807E5700 Slot: 113
	public virtual void BeginBodySearch_Networked(string playerCode) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7E5830 Offset: 0x7E4230 VA: 0x1807E5830
	private void BeginBodySearch(string playerCode) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7E51D0 Offset: 0x7E3BD0 VA: 0x1807E51D0 Slot: 114
	public virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location) { }

	// RVA: 0x7E9190 Offset: 0x7E7B90 VA: 0x1807E9190
	public void UnassignFromCheckpoint() { }

	// RVA: 0x7E8EB0 Offset: 0x7E78B0 VA: 0x1807E8EB0
	public void StartFootPatrol(PatrolGroup group, bool warpToStartPoint) { }

	// RVA: 0x7E8F50 Offset: 0x7E7950 VA: 0x1807E8F50
	public void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle) { }

	// RVA: 0x7E5300 Offset: 0x7E3D00 VA: 0x1807E5300 Slot: 115
	public virtual void AssignToSentryLocation(SentryLocation location) { }

	// RVA: 0x7E9210 Offset: 0x7E7C10 VA: 0x1807E9210
	public void UnassignFromSentryLocation() { }

	// RVA: 0x7E5180 Offset: 0x7E3B80 VA: 0x1807E5180
	public void Activate() { }

	// RVA: 0x7E6C80 Offset: 0x7E5680 VA: 0x1807E6C80
	public void Deactivate() { }

	// RVA: 0x7E8CE0 Offset: 0x7E76E0 VA: 0x1807E8CE0
	protected bool ShouldNoticeGeneralCrime(Player player) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 93
	public override bool ShouldSave() { }

	// RVA: 0x7E6E60 Offset: 0x7E5860 VA: 0x1807E6E60 Slot: 90
	public override string GetNameAddress() { }

	// RVA: 0x7E92B0 Offset: 0x7E7CB0 VA: 0x1807E92B0
	private void UpdateChatter() { }

	// RVA: 0x7E7490 Offset: 0x7E5E90 VA: 0x1807E7490
	private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt) { }

	// RVA: 0x7E6EA0 Offset: 0x7E58A0 VA: 0x1807E6EA0
	public static PoliceOfficer GetNearestOfficer(Vector3 position, out float distanceToTarget, bool onlyConscious = True) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDie() { }

	// RVA: 0x7E9260 Offset: 0x7E7C60 VA: 0x1807E9260 Slot: 116
	public virtual void UpdateBodySearch() { }

	// RVA: 0x7E5FE0 Offset: 0x7E49E0 VA: 0x1807E5FE0
	private bool CanInvestigate() { }

	// RVA: 0x7E9370 Offset: 0x7E7D70 VA: 0x1807E9370
	private void UpdateExistingInvestigation() { }

	// RVA: 0x7E6750 Offset: 0x7E5150 VA: 0x1807E6750
	private void CheckNewInvestigation() { }

	// RVA: 0x7E8DF0 Offset: 0x7E77F0 VA: 0x1807E8DF0
	private void StartBodySearchInvestigation(Player player) { }

	// RVA: 0x7E9080 Offset: 0x7E7A80 VA: 0x1807E9080
	private void StopBodySearchInvestigation() { }

	// RVA: 0x7E6BA0 Offset: 0x7E55A0 VA: 0x1807E6BA0
	public void ConductBodySearch(Player player) { }

	// RVA: 0x7E5F10 Offset: 0x7E4910 VA: 0x1807E5F10
	private bool CanInvestigatePlayer(Player player) { }

	// RVA: 0x7E9EA0 Offset: 0x7E88A0 VA: 0x1807E9EA0
	public void .ctor() { }

	// RVA: 0x7E9E10 Offset: 0x7E8810 VA: 0x1807E9E10
	private static void .cctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(PoliceOfficer.<<Deactivate>g__Wait|60_0>d))]
	// RVA: 0x7E9120 Offset: 0x7E7B20 VA: 0x1807E9120
	private IEnumerator <Deactivate>g__Wait|60_0() { }

	[CompilerGenerated]
	// RVA: 0x7E90F0 Offset: 0x7E7AF0 VA: 0x1807E90F0
	private bool <Deactivate>b__60_1() { }

	// RVA: 0x7E70E0 Offset: 0x7E5AE0 VA: 0x1807E70E0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7E70C0 Offset: 0x7E5AC0 VA: 0x1807E70C0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7E8A20 Offset: 0x7E7420 VA: 0x1807E8A20
	private void RpcWriter___Server_BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = True) { }

	// RVA: 0x7E78E0 Offset: 0x7E62E0 VA: 0x1807E78E0 Slot: 117
	public virtual void RpcLogic___BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = True) { }

	// RVA: 0x7E8230 Offset: 0x7E6C30 VA: 0x1807E8230
	private void RpcReader___Server_BeginFootPursuit_Networked_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7E8640 Offset: 0x7E7040 VA: 0x1807E8640
	private void RpcWriter___Observers_BeginFootPursuit_3615296227(string playerCode) { }

	// RVA: 0x7E77D0 Offset: 0x7E61D0 VA: 0x1807E77D0
	private void RpcLogic___BeginFootPursuit_3615296227(string playerCode) { }

	// RVA: 0x7E80A0 Offset: 0x7E6AA0 VA: 0x1807E80A0
	private void RpcReader___Observers_BeginFootPursuit_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E8B80 Offset: 0x7E7580 VA: 0x1807E8B80
	private void RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	// RVA: 0x7E5D80 Offset: 0x7E4780 VA: 0x1807E5D80 Slot: 118
	public virtual void RpcLogic___BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	// RVA: 0x7E82E0 Offset: 0x7E6CE0 VA: 0x1807E82E0
	private void RpcReader___Server_BeginVehiclePursuit_Networked_1834136777(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7E8780 Offset: 0x7E7180 VA: 0x1807E8780
	private void RpcWriter___Observers_BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	// RVA: 0x7E7E40 Offset: 0x7E6840 VA: 0x1807E7E40
	private void RpcLogic___BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted) { }

	// RVA: 0x7E8100 Offset: 0x7E6B00 VA: 0x1807E8100
	private void RpcReader___Observers_BeginVehiclePursuit_1834136777(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E88F0 Offset: 0x7E72F0 VA: 0x1807E88F0
	private void RpcWriter___Server_BeginBodySearch_Networked_3615296227(string playerCode) { }

	// RVA: 0x7E5830 Offset: 0x7E4230 VA: 0x1807E5830 Slot: 119
	public virtual void RpcLogic___BeginBodySearch_Networked_3615296227(string playerCode) { }

	// RVA: 0x7E81C0 Offset: 0x7E6BC0 VA: 0x1807E81C0
	private void RpcReader___Server_BeginBodySearch_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7E8500 Offset: 0x7E6F00 VA: 0x1807E8500
	private void RpcWriter___Observers_BeginBodySearch_3615296227(string playerCode) { }

	// RVA: 0x7E76A0 Offset: 0x7E60A0 VA: 0x1807E76A0
	private void RpcLogic___BeginBodySearch_3615296227(string playerCode) { }

	// RVA: 0x7E8040 Offset: 0x7E6A40 VA: 0x1807E8040
	private void RpcReader___Observers_BeginBodySearch_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E83C0 Offset: 0x7E6DC0 VA: 0x1807E83C0
	private void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location) { }

	// RVA: 0x7E7530 Offset: 0x7E5F30 VA: 0x1807E7530 Slot: 120
	public virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location) { }

	// RVA: 0x7E7FF0 Offset: 0x7E69F0 VA: 0x1807E7FF0
	private void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E5350 Offset: 0x7E3D50 VA: 0x1807E5350 Slot: 121
	protected override void Awake_UserLogic_ScheduleOne.Police.PoliceOfficer_Assembly-CSharp.dll() { }
}
