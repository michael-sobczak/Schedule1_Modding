public class NPCMovement : NetworkBehaviour // TypeDefIndex: 1657
{
	// Fields
	public const float VEHICLE_RUNOVER_THRESHOLD = 10;
	public const float SKATEBOARD_RUNOVER_THRESHOLD = 10;
	public const float LIGHT_FLINCH_THRESHOLD = 50;
	public const float HEAVY_FLINCH_THRESHOLD = 100;
	public const float RAGDOLL_THRESHOLD = 150;
	public const float MOMENTUM_ANNOYED_THRESHOLD = 10;
	public const float MOMENTUM_LIGHT_FLINCH_THRESHOLD = 20;
	public const float MOMENTUM_HEAVY_FLINCH_THRESHOLD = 40;
	public const float MOMENTUM_RAGDOLL_THRESHOLD = 60;
	public const bool USE_PATH_CACHE = True;
	public const float STUMBLE_DURATION = 0.66;
	public const float STUMBLE_FORCE = 7;
	public const float OBSTACLE_AVOIDANCE_RANGE = 25;
	public const float PLAYER_DIST_IMPACT_THRESHOLD = 30;
	public static Dictionary<Vector3, Vector3> cachedClosestReachablePoints; // 0x0
	public static List<Vector3> cachedClosestPointKeys; // 0x8
	public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1;
	public bool DEBUG; // 0x118
	[Header("Settings")]
	public float WalkSpeed; // 0x11C
	public float RunSpeed; // 0x120
	public float MoveSpeedMultiplier; // 0x124
	[Header("Obstacle Avoidance")]
	public bool ObstacleAvoidanceEnabled; // 0x128
	public ObstacleAvoidanceType DefaultObstacleAvoidanceType; // 0x12C
	[Header("Slippery Mode")]
	public bool SlipperyMode; // 0x130
	public float SlipperyModeMultiplier; // 0x134
	[Header("References")]
	public NavMeshAgent Agent; // 0x138
	public NPCSpeedController SpeedController; // 0x140
	public CapsuleCollider CapsuleCollider; // 0x148
	public NPCAnimation Animation; // 0x150
	public SmoothedVelocityCalculator VelocityCalculator; // 0x158
	public Draggable RagdollDraggable; // 0x160
	public Collider RagdollDraggableCollider; // 0x168
	protected NPC npc; // 0x170
	public float MovementSpeedScale; // 0x178
	[CompilerGenerated]
	private bool <HasDestination>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; // 0x17D
	[CompilerGenerated]
	private float <GravityMultiplier>k__BackingField; // 0x180
	[CompilerGenerated]
	private NPCMovement.EStance <Stance>k__BackingField; // 0x184
	[CompilerGenerated]
	private float <TimeSinceHitByCar>k__BackingField; // 0x188
	[CompilerGenerated]
	private float <CurrentLadderSpeed>k__BackingField; // 0x18C
	[CompilerGenerated]
	private Ladder <CurrentLadder>k__BackingField; // 0x190
	private float ragdollStaticTime; // 0x198
	public UnityEvent<LandVehicle> onHitByCar; // 0x1A0
	public UnityEvent onRagdollStart; // 0x1A8
	public UnityEvent onRagdollEnd; // 0x1B0
	[CompilerGenerated]
	private Vector3 <CurrentDestination>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private NPCPathCache <PathCache>k__BackingField; // 0x1C8
	private bool cacheNextPath; // 0x1D0
	private Vector3 currentDestination_Reachable; // 0x1D4
	private Action<NPCMovement.WalkResult> walkResultCallback; // 0x1E0
	private float currentMaxDistanceForSuccess; // 0x1E8
	private bool forceIsMoving; // 0x1EC
	private Coroutine faceDirectionRoutine; // 0x1F0
	private List<ConstantForce> ragdollForceComponents; // 0x1F8
	[CompilerGenerated]
	private bool <Disoriented>k__BackingField; // 0x200
	private float timeUntilNextStumble; // 0x204
	private float timeSinceStumble; // 0x208
	private Vector3 stumbleDirection; // 0x20C
	private CircularQueue<Vector3> desiredVelocityHistory; // 0x218
	private int desiredVelocityHistoryLength; // 0x220
	private float velocityHistorySpacing; // 0x224
	private float timeSinceLastVelocityHistoryRecord; // 0x228
	private NavMeshPath agentCurrentPath; // 0x230
	private float agentCurrentSpeed; // 0x238
	private Vector3[] agentCurrentPathCorners; // 0x240
	private Coroutine ladderClimbRoutine; // 0x248
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted; // 0x250
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted; // 0x251

	// Properties
	public bool HasDestination { get; set; }
	public bool IsMoving { get; }
	public bool IsPaused { get; set; }
	public Vector3 FootPosition { get; }
	public float GravityMultiplier { get; set; }
	public NPCMovement.EStance Stance { get; set; }
	public float TimeSinceHitByCar { get; set; }
	public bool FaceDirectionInProgress { get; }
	public bool IsOnLadder { get; }
	public float CurrentLadderSpeed { get; set; }
	public bool IsClimbingUpwards { get; }
	public Ladder CurrentLadder { get; set; }
	public Vector3 CurrentDestination { get; set; }
	public NPCPathCache PathCache { get; set; }
	public bool Disoriented { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726320 Offset: 0x724D20 VA: 0x180726320
	public bool get_HasDestination() { }

	[CompilerGenerated]
	// RVA: 0x7264D0 Offset: 0x724ED0 VA: 0x1807264D0
	protected void set_HasDestination(bool value) { }

	// RVA: 0x726350 Offset: 0x724D50 VA: 0x180726350
	public bool get_IsMoving() { }

	[CompilerGenerated]
	// RVA: 0x726420 Offset: 0x724E20 VA: 0x180726420
	public bool get_IsPaused() { }

	[CompilerGenerated]
	// RVA: 0x7264E0 Offset: 0x724EE0 VA: 0x1807264E0
	protected void set_IsPaused(bool value) { }

	// RVA: 0x7262C0 Offset: 0x724CC0 VA: 0x1807262C0
	public Vector3 get_FootPosition() { }

	[CompilerGenerated]
	// RVA: 0x726310 Offset: 0x724D10 VA: 0x180726310
	public float get_GravityMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x7264C0 Offset: 0x724EC0 VA: 0x1807264C0
	protected void set_GravityMultiplier(float value) { }

	[CompilerGenerated]
	// RVA: 0x726440 Offset: 0x724E40 VA: 0x180726440
	public NPCMovement.EStance get_Stance() { }

	[CompilerGenerated]
	// RVA: 0x7240A0 Offset: 0x722AA0 VA: 0x1807240A0
	protected void set_Stance(NPCMovement.EStance value) { }

	[CompilerGenerated]
	// RVA: 0x726450 Offset: 0x724E50 VA: 0x180726450
	public float get_TimeSinceHitByCar() { }

	[CompilerGenerated]
	// RVA: 0x726510 Offset: 0x724F10 VA: 0x180726510
	protected void set_TimeSinceHitByCar(float value) { }

	// RVA: 0x7262B0 Offset: 0x724CB0 VA: 0x1807262B0
	public bool get_FaceDirectionInProgress() { }

	// RVA: 0x7263C0 Offset: 0x724DC0 VA: 0x1807263C0
	public bool get_IsOnLadder() { }

	[CompilerGenerated]
	// RVA: 0x726280 Offset: 0x724C80 VA: 0x180726280
	public float get_CurrentLadderSpeed() { }

	[CompilerGenerated]
	// RVA: 0x726480 Offset: 0x724E80 VA: 0x180726480
	protected void set_CurrentLadderSpeed(float value) { }

	// RVA: 0x726330 Offset: 0x724D30 VA: 0x180726330
	public bool get_IsClimbingUpwards() { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Ladder get_CurrentLadder() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_CurrentLadder(Ladder value) { }

	[CompilerGenerated]
	// RVA: 0x726260 Offset: 0x724C60 VA: 0x180726260
	public Vector3 get_CurrentDestination() { }

	[CompilerGenerated]
	// RVA: 0x726460 Offset: 0x724E60 VA: 0x180726460
	protected void set_CurrentDestination(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public NPCPathCache get_PathCache() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	private void set_PathCache(NPCPathCache value) { }

	[CompilerGenerated]
	// RVA: 0x7262A0 Offset: 0x724CA0 VA: 0x1807262A0
	public bool get_Disoriented() { }

	[CompilerGenerated]
	// RVA: 0x7264B0 Offset: 0x724EB0 VA: 0x1807264B0
	public void set_Disoriented(bool value) { }

	// RVA: 0x71E2E0 Offset: 0x71CCE0 VA: 0x18071E2E0 Slot: 19
	public override void Awake() { }

	// RVA: 0x724290 Offset: 0x722C90 VA: 0x180724290
	private void Start() { }

	// RVA: 0x721080 Offset: 0x71FA80 VA: 0x180721080 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x7254D0 Offset: 0x723ED0 VA: 0x1807254D0 Slot: 20
	protected virtual void Update() { }

	// RVA: 0x722D00 Offset: 0x721700 VA: 0x180722D00
	public void SetAgentEnabled(bool enabled) { }

	// RVA: 0x724D80 Offset: 0x723780 VA: 0x180724D80
	private void UpdateRagdoll() { }

	// RVA: 0x7244F0 Offset: 0x722EF0 VA: 0x1807244F0
	private void Stumble() { }

	// RVA: 0x724AD0 Offset: 0x7234D0 VA: 0x180724AD0
	private void UpdateDestination() { }

	// RVA: 0x71FB50 Offset: 0x71E550 VA: 0x18071FB50 Slot: 21
	protected virtual void FixedUpdate() { }

	// RVA: 0x7251C0 Offset: 0x723BC0 VA: 0x1807251C0
	private void UpdateStumble() { }

	// RVA: 0x7250B0 Offset: 0x723AB0 VA: 0x1807250B0
	private void UpdateSpeed() { }

	// RVA: 0x721370 Offset: 0x71FD70 VA: 0x180721370
	private void RecordVelocity() { }

	// RVA: 0x724F00 Offset: 0x723900 VA: 0x180724F00
	private void UpdateSlippery() { }

	// RVA: 0x724900 Offset: 0x723300 VA: 0x180724900
	private void UpdateCache() { }

	// RVA: 0x71EA10 Offset: 0x71D410 VA: 0x18071EA10
	public bool CanRecoverFromRagdoll() { }

	// RVA: 0x724800 Offset: 0x723200 VA: 0x180724800
	private void UpdateAvoidance() { }

	// RVA: 0x7210C0 Offset: 0x71FAC0 VA: 0x1807210C0
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x720FA0 Offset: 0x71F9A0 VA: 0x180720FA0
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x71EAC0 Offset: 0x71D4C0 VA: 0x18071EAC0
	private void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint) { }

	// RVA: 0x725AA0 Offset: 0x7244A0 VA: 0x180725AA0
	public void Warp(Transform target) { }

	// RVA: 0x725AF0 Offset: 0x7244F0 VA: 0x180725AF0
	public void Warp(Vector3 position) { }

	[ObserversRpc(ExcludeServer = True)]
	// RVA: 0x7211E0 Offset: 0x71FBE0 VA: 0x1807211E0
	private void ReceiveWarp(Vector3 position) { }

	// RVA: 0x725A60 Offset: 0x724460 VA: 0x180725A60
	public void VisibilityChange(bool visible) { }

	// RVA: 0x71E9A0 Offset: 0x71D3A0 VA: 0x18071E9A0
	public bool CanMove() { }

	// RVA: 0x722E10 Offset: 0x721810 VA: 0x180722E10
	public void SetAgentType(NPCMovement.EAgentType type) { }

	// RVA: 0x723FF0 Offset: 0x7229F0 VA: 0x180723FF0
	public void SetSeat(AvatarSeat seat) { }

	// RVA: 0x7240A0 Offset: 0x722AA0 VA: 0x1807240A0
	public void SetStance(NPCMovement.EStance stance) { }

	// RVA: 0x723D00 Offset: 0x722700 VA: 0x180723D00
	public void SetGravityMultiplier(float multiplier) { }

	// RVA: 0x723F10 Offset: 0x722910 VA: 0x180723F10
	public void SetRagdollDraggable(bool draggable) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x71DC20 Offset: 0x71C620 VA: 0x18071DC20
	public void ActivateRagdoll_Server() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x71DD30 Offset: 0x71C730 VA: 0x18071DD30
	public void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x71DDF0 Offset: 0x71C7F0 VA: 0x18071DDF0
	public void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x71F3B0 Offset: 0x71DDB0 VA: 0x18071F3B0
	public void DeactivateRagdoll() { }

	// RVA: 0x7240B0 Offset: 0x722AB0 VA: 0x1807240B0
	private bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1, float maxRadius = 10, int steps = 3) { }

	// RVA: 0x722F50 Offset: 0x721950 VA: 0x180722F50
	public void SetDestination(Transform target) { }

	// RVA: 0x722F00 Offset: 0x721900 VA: 0x180722F00
	public void SetDestination(Vector3 pos) { }

	// RVA: 0x723C30 Offset: 0x722630 VA: 0x180723C30
	public void SetDestination(ITransitEntity entity) { }

	// RVA: 0x723BE0 Offset: 0x7225E0 VA: 0x180723BE0
	public void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback, float maximumDistanceForSuccess = 1, float cacheMaxDistSqr = 1) { }

	// RVA: 0x722FC0 Offset: 0x7219C0 VA: 0x180722FC0
	private void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback, bool interruptExistingCallback = True, float successThreshold = 1, float cacheMaxDistSqr = 1) { }

	// RVA: 0x720D50 Offset: 0x71F750 VA: 0x180720D50
	private bool IsNPCPositionValid(Vector3 position) { }

	// RVA: 0x71F4D0 Offset: 0x71DED0 VA: 0x18071F4D0
	private void EndSetDestination(NPCMovement.WalkResult result) { }

	// RVA: 0x7243C0 Offset: 0x722DC0 VA: 0x1807243C0
	public void Stop() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void WarpToNavMesh() { }

	// RVA: 0x71F940 Offset: 0x71E340 VA: 0x18071F940
	public void FacePoint(Vector3 point, float lerpTime = 0.5) { }

	// RVA: 0x71F720 Offset: 0x71E120 VA: 0x18071F720
	public void FaceDirection(Vector3 forward, float lerpTime = 0.5) { }

	[IteratorStateMachine(typeof(NPCMovement.<FaceDirection_Process>d__154))]
	// RVA: 0x71F680 Offset: 0x71E080 VA: 0x18071F680
	protected IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime) { }

	// RVA: 0x721150 Offset: 0x71FB50 VA: 0x180721150
	public void PauseMovement() { }

	// RVA: 0x721440 Offset: 0x71FE40 VA: 0x180721440
	public void ResumeMovement() { }

	// RVA: 0x720AF0 Offset: 0x71F4F0 VA: 0x180720AF0
	public bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5) { }

	// RVA: 0x720190 Offset: 0x71EB90 VA: 0x180720190
	public bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint) { }

	// RVA: 0x71E780 Offset: 0x71D180 VA: 0x18071E780
	public bool CanGetTo(Vector3 position, float proximityReq = 1) { }

	// RVA: 0x71E7C0 Offset: 0x71D1C0 VA: 0x18071E7C0
	public bool CanGetTo(ITransitEntity entity, float proximityReq = 1) { }

	// RVA: 0x71E330 Offset: 0x71CD30 VA: 0x18071E330
	public bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path) { }

	// RVA: 0x720730 Offset: 0x71F130 VA: 0x180720730
	private NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1) { }

	// RVA: 0x7246A0 Offset: 0x7230A0 VA: 0x1807246A0
	public void TraverseLadder(Ladder ladder) { }

	// RVA: 0x71EA50 Offset: 0x71D450 VA: 0x18071EA50
	private void CancelTraverseLadder() { }

	// RVA: 0x726020 Offset: 0x724A20 VA: 0x180726020
	public void .ctor() { }

	// RVA: 0x725F30 Offset: 0x724930 VA: 0x180725F30
	private static void .cctor() { }

	// RVA: 0x720DF0 Offset: 0x71F7F0 VA: 0x180720DF0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x720DD0 Offset: 0x71F7D0 VA: 0x180720DD0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7211E0 Offset: 0x71FBE0 VA: 0x1807211E0
	private void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position) { }

	// RVA: 0x722050 Offset: 0x720A50 VA: 0x180722050
	private void RpcLogic___ReceiveWarp_4276783012(Vector3 position) { }

	// RVA: 0x7225F0 Offset: 0x720FF0 VA: 0x1807225F0
	private void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x722BF0 Offset: 0x7215F0 VA: 0x180722BF0
	private void RpcWriter___Server_ActivateRagdoll_Server_2166136261() { }

	// RVA: 0x7218A0 Offset: 0x7202A0 VA: 0x1807218A0
	public void RpcLogic___ActivateRagdoll_Server_2166136261() { }

	// RVA: 0x7226A0 Offset: 0x7210A0 VA: 0x1807226A0
	private void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7226F0 Offset: 0x7210F0 VA: 0x1807226F0
	private void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	// RVA: 0x721490 Offset: 0x71FE90 VA: 0x180721490
	public void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	// RVA: 0x7222F0 Offset: 0x720CF0 VA: 0x1807222F0
	private void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7228E0 Offset: 0x7212E0 VA: 0x1807228E0
	private void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	// RVA: 0x7219A0 Offset: 0x7203A0 VA: 0x1807219A0
	public void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude) { }

	// RVA: 0x722450 Offset: 0x720E50 VA: 0x180722450
	private void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x722AD0 Offset: 0x7214D0 VA: 0x180722AD0
	private void RpcWriter___Observers_DeactivateRagdoll_2166136261() { }

	// RVA: 0x721C60 Offset: 0x720660 VA: 0x180721C60
	public void RpcLogic___DeactivateRagdoll_2166136261() { }

	// RVA: 0x7225B0 Offset: 0x720FB0 VA: 0x1807225B0
	private void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x71DEB0 Offset: 0x71C8B0 VA: 0x18071DEB0 Slot: 24
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCMovement_Assembly-CSharp.dll() { }
}
