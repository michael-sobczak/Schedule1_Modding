public class RichAI : AIBase, IAstarAI // TypeDefIndex: 13103
{
	// Fields
	public float acceleration; // 0x130
	public float rotationSpeed; // 0x134
	public float slowdownTime; // 0x138
	public float endReachedDistance; // 0x13C
	public float wallForce; // 0x140
	public float wallDist; // 0x144
	public bool funnelSimplification; // 0x148
	public bool slowWhenNotFacingTarget; // 0x149
	public Func<RichSpecial, IEnumerator> onTraverseOffMeshLink; // 0x150
	protected readonly RichPath richPath; // 0x158
	protected bool delayUpdatePath; // 0x160
	protected bool lastCorner; // 0x161
	protected float distanceToSteeringTarget; // 0x164
	protected readonly List<Vector3> nextCorners; // 0x168
	protected readonly List<Vector3> wallBuffer; // 0x170
	[CompilerGenerated]
	private bool <traversingOffMeshLink>k__BackingField; // 0x178
	[CompilerGenerated]
	private Vector3 <steeringTarget>k__BackingField; // 0x17C
	protected static readonly Color GizmoColorPath; // 0x0
	[FormerlySerializedAs("anim")]
	[SerializeField]
	[HideInInspector]
	private Animation animCompatibility; // 0x188

	// Properties
	public bool traversingOffMeshLink { get; set; }
	public float remainingDistance { get; }
	public bool reachedEndOfPath { get; }
	public bool reachedDestination { get; }
	public bool hasPath { get; }
	public bool pathPending { get; }
	public Vector3 steeringTarget { get; set; }
	private float Pathfinding.IAstarAI.radius { get; set; }
	private float Pathfinding.IAstarAI.height { get; set; }
	private float Pathfinding.IAstarAI.maxSpeed { get; set; }
	private bool Pathfinding.IAstarAI.canSearch { get; set; }
	private bool Pathfinding.IAstarAI.canMove { get; set; }
	public bool approachingPartEndpoint { get; }
	public bool approachingPathEndpoint { get; }
	protected override bool shouldRecalculatePath { get; }
	[Obsolete("Use velocity instead (lowercase 'v'). [AstarUpgradable: 'Velocity' -> 'velocity']")]
	public Vector3 Velocity { get; }
	[Obsolete("Use steeringTarget instead. [AstarUpgradable: 'NextWaypoint' -> 'steeringTarget']")]
	public Vector3 NextWaypoint { get; }
	[Obsolete("Use Vector3.Distance(transform.position, ai.steeringTarget) instead.")]
	public float DistanceToNextWaypoint { get; }
	[Obsolete("Use canSearch instead. [AstarUpgradable: 'repeatedlySearchPaths' -> 'canSearch']")]
	public bool repeatedlySearchPaths { get; set; }
	[Obsolete("When unifying the interfaces for different movement scripts, this property has been renamed to reachedEndOfPath (lowercase t).  [AstarUpgradable: 'TargetReached' -> 'reachedEndOfPath']")]
	public bool TargetReached { get; }
	[Obsolete("Use pathPending instead (lowercase 'p'). [AstarUpgradable: 'PathPending' -> 'pathPending']")]
	public bool PathPending { get; }
	[Obsolete("Use approachingPartEndpoint (lowercase 'a') instead")]
	public bool ApproachingPartEndpoint { get; }
	[Obsolete("Use approachingPathEndpoint (lowercase 'a') instead")]
	public bool ApproachingPathEndpoint { get; }
	[Obsolete("This property has been renamed to 'traversingOffMeshLink'. [AstarUpgradable: 'TraversingSpecial' -> 'traversingOffMeshLink']")]
	public bool TraversingSpecial { get; }
	[Obsolete("This property has been renamed to steeringTarget")]
	public Vector3 TargetPoint { get; }
	[Obsolete("Use the onTraverseOffMeshLink event or the ... component instead. Setting this value will add a ... component")]
	public Animation anim { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B390 Offset: 0x739D90 VA: 0x18073B390
	public bool get_traversingOffMeshLink() { }

	[CompilerGenerated]
	// RVA: 0x73B510 Offset: 0x739F10 VA: 0x18073B510
	protected void set_traversingOffMeshLink(bool value) { }

	// RVA: 0xAF9120 Offset: 0xAF7B20 VA: 0x180AF9120 Slot: 53
	public float get_remainingDistance() { }

	// RVA: 0xAF8B40 Offset: 0xAF7540 VA: 0x180AF8B40 Slot: 55
	public bool get_reachedEndOfPath() { }

	// RVA: 0xAF8DA0 Offset: 0xAF77A0 VA: 0x180AF8DA0 Slot: 54
	public bool get_reachedDestination() { }

	// RVA: 0xAF8D70 Offset: 0xAF7770 VA: 0x180AF8D70 Slot: 62
	public bool get_hasPath() { }

	// RVA: 0xAF8B20 Offset: 0xAF7520 VA: 0x180AF8B20 Slot: 63
	public bool get_pathPending() { }

	[CompilerGenerated]
	// RVA: 0xAF8B00 Offset: 0xAF7500 VA: 0x180AF8B00 Slot: 66
	public Vector3 get_steeringTarget() { }

	[CompilerGenerated]
	// RVA: 0xAF9420 Offset: 0xAF7E20 VA: 0x180AF9420
	protected void set_steeringTarget(Vector3 value) { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0 Slot: 42
	private float Pathfinding.IAstarAI.get_radius() { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820 Slot: 43
	private void Pathfinding.IAstarAI.set_radius(float value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0 Slot: 44
	private float Pathfinding.IAstarAI.get_height() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40 Slot: 45
	private void Pathfinding.IAstarAI.set_height(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250 Slot: 49
	private float Pathfinding.IAstarAI.get_maxSpeed() { }

	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0 Slot: 50
	private void Pathfinding.IAstarAI.set_maxSpeed(float value) { }

	// RVA: 0xAEB290 Offset: 0xAE9C90 VA: 0x180AEB290 Slot: 58
	private bool Pathfinding.IAstarAI.get_canSearch() { }

	// RVA: 0xAEB6C0 Offset: 0xAEA0C0 VA: 0x180AEB6C0 Slot: 59
	private void Pathfinding.IAstarAI.set_canSearch(bool value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 60
	private bool Pathfinding.IAstarAI.get_canMove() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50 Slot: 61
	private void Pathfinding.IAstarAI.set_canMove(bool value) { }

	// RVA: 0xAF8A90 Offset: 0xAF7490 VA: 0x180AF8A90
	public bool get_approachingPartEndpoint() { }

	// RVA: 0xAF8CE0 Offset: 0xAF76E0 VA: 0x180AF8CE0
	public bool get_approachingPathEndpoint() { }

	// RVA: 0xAF7920 Offset: 0xAF6320 VA: 0x180AF7920 Slot: 25
	public override void Teleport(Vector3 newPosition, bool clearPath = True) { }

	// RVA: 0xAF7100 Offset: 0xAF5B00 VA: 0x180AF7100 Slot: 26
	protected override void OnDisable() { }

	// RVA: 0xAF9250 Offset: 0xAF7C50 VA: 0x180AF9250 Slot: 21
	protected override bool get_shouldRecalculatePath() { }

	// RVA: 0xAF77C0 Offset: 0xAF61C0 VA: 0x180AF77C0 Slot: 32
	public override void SearchPath() { }

	// RVA: 0xAF7310 Offset: 0xAF5D10 VA: 0x180AF7310 Slot: 34
	protected override void OnPathComplete(Path p) { }

	// RVA: 0xAF65E0 Offset: 0xAF4FE0 VA: 0x180AF65E0 Slot: 35
	protected override void ClearPath() { }

	// RVA: 0xAF6FC0 Offset: 0xAF59C0 VA: 0x180AF6FC0
	protected void NextPart() { }

	// RVA: 0xAF6C10 Offset: 0xAF5610 VA: 0x180AF6C10 Slot: 69
	public void GetRemainingPath(List<Vector3> buffer, out bool stale) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 76
	protected virtual void OnTargetReached() { }

	// RVA: 0xAF8750 Offset: 0xAF7150 VA: 0x180AF8750 Slot: 77
	protected virtual Vector3 UpdateTarget(RichFunnel fn) { }

	// RVA: 0xAF6C60 Offset: 0xAF5660 VA: 0x180AF6C60 Slot: 30
	protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: 0xAF7CA0 Offset: 0xAF66A0 VA: 0x180AF7CA0
	private void TraverseFunnel(RichFunnel fn, float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: 0xAF6630 Offset: 0xAF5030 VA: 0x180AF6630
	private void FinalMovement(Vector3 position3D, float deltaTime, float distanceToEndOfPath, float slowdownFactor, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: 0xAF6250 Offset: 0xAF4C50 VA: 0x180AF6250 Slot: 39
	protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged) { }

	// RVA: 0xAF5D60 Offset: 0xAF4760 VA: 0x180AF5D60
	private Vector2 CalculateWallForce(Vector2 position, float elevation, Vector2 directionToTarget) { }

	[IteratorStateMachine(typeof(RichAI.<TraverseSpecial>d__68))]
	// RVA: 0xAF86C0 Offset: 0xAF70C0 VA: 0x180AF86C0 Slot: 78
	protected virtual IEnumerator TraverseSpecial(RichSpecial link) { }

	[IteratorStateMachine(typeof(RichAI.<TraverseOffMeshLinkFallback>d__69))]
	// RVA: 0xAF8630 Offset: 0xAF7030 VA: 0x180AF8630
	protected IEnumerator TraverseOffMeshLinkFallback(RichSpecial link) { }

	// RVA: 0xAF7130 Offset: 0xAF5B30 VA: 0x180AF7130 Slot: 41
	protected override void OnDrawGizmos() { }

	// RVA: 0xAF7650 Offset: 0xAF6050 VA: 0x180AF7650 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }

	[Obsolete("Use SearchPath instead. [AstarUpgradable: 'UpdatePath' -> 'SearchPath']")]
	// RVA: 0x64BA60 Offset: 0x64A460 VA: 0x18064BA60
	public void UpdatePath() { }

	// RVA: 0xAF8B80 Offset: 0xAF7580 VA: 0x180AF8B80
	public Vector3 get_Velocity() { }

	// RVA: 0xAF8B00 Offset: 0xAF7500 VA: 0x180AF8B00
	public Vector3 get_NextWaypoint() { }

	// RVA: 0x8D1F40 Offset: 0x8D0940 VA: 0x1808D1F40
	public float get_DistanceToNextWaypoint() { }

	// RVA: 0xAEB290 Offset: 0xAE9C90 VA: 0x180AEB290
	public bool get_repeatedlySearchPaths() { }

	// RVA: 0xAEB6C0 Offset: 0xAEA0C0 VA: 0x180AEB6C0
	public void set_repeatedlySearchPaths(bool value) { }

	// RVA: 0xAF8B40 Offset: 0xAF7540 VA: 0x180AF8B40
	public bool get_TargetReached() { }

	// RVA: 0xAF8B20 Offset: 0xAF7520 VA: 0x180AF8B20
	public bool get_PathPending() { }

	// RVA: 0xAF8A90 Offset: 0xAF7490 VA: 0x180AF8A90
	public bool get_ApproachingPartEndpoint() { }

	// RVA: 0xAF8AF0 Offset: 0xAF74F0 VA: 0x180AF8AF0
	public bool get_ApproachingPathEndpoint() { }

	// RVA: 0x73B390 Offset: 0x739D90 VA: 0x18073B390
	public bool get_TraversingSpecial() { }

	// RVA: 0xAF8B00 Offset: 0xAF7500 VA: 0x180AF8B00
	public Vector3 get_TargetPoint() { }

	// RVA: 0xAF8C50 Offset: 0xAF7650 VA: 0x180AF8C50
	public Animation get_anim() { }

	// RVA: 0xAF9330 Offset: 0xAF7D30 VA: 0x180AF9330
	public void set_anim(Animation value) { }

	// RVA: 0xAF88C0 Offset: 0xAF72C0 VA: 0x180AF88C0
	public void .ctor() { }

	// RVA: 0xAF8880 Offset: 0xAF7280 VA: 0x180AF8880
	private static void .cctor() { }
}
