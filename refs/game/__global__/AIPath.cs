public class AIPath : AIBase, IAstarAI // TypeDefIndex: 13099
{
	// Fields
	public float maxAcceleration; // 0x130
	[FormerlySerializedAs("turningSpeed")]
	public float rotationSpeed; // 0x134
	public float slowdownDistance; // 0x138
	public float pickNextWaypointDist; // 0x13C
	public float endReachedDistance; // 0x140
	public bool alwaysDrawGizmos; // 0x144
	public bool slowWhenNotFacingTarget; // 0x145
	public CloseToDestinationMode whenCloseToDestination; // 0x148
	public bool constrainInsideGraph; // 0x14C
	protected Path path; // 0x150
	protected PathInterpolator interpolator; // 0x158
	[CompilerGenerated]
	private bool <reachedEndOfPath>k__BackingField; // 0x160
	private static NNConstraint cachedNNConstraint; // 0x0

	// Properties
	public float remainingDistance { get; }
	public bool reachedDestination { get; }
	public bool reachedEndOfPath { get; set; }
	public bool hasPath { get; }
	public bool pathPending { get; }
	public Vector3 steeringTarget { get; }
	private float Pathfinding.IAstarAI.radius { get; set; }
	private float Pathfinding.IAstarAI.height { get; set; }
	private float Pathfinding.IAstarAI.maxSpeed { get; set; }
	private bool Pathfinding.IAstarAI.canSearch { get; set; }
	private bool Pathfinding.IAstarAI.canMove { get; set; }
	[Obsolete("When unifying the interfaces for different movement scripts, this property has been renamed to reachedEndOfPath.  [AstarUpgradable: 'TargetReached' -> 'reachedEndOfPath']")]
	public bool TargetReached { get; }
	[Obsolete("This field has been renamed to #rotationSpeed and is now in degrees per second instead of a damping factor")]
	public float turningSpeed { get; set; }
	[Obsolete("This member has been deprecated. Use 'maxSpeed' instead. [AstarUpgradable: 'speed' -> 'maxSpeed']")]
	public float speed { get; set; }
	[Obsolete("Only exists for compatibility reasons. Use desiredVelocity or steeringTarget instead.")]
	public Vector3 targetDirection { get; }

	// Methods

	// RVA: 0xAF03C0 Offset: 0xAEEDC0 VA: 0x180AF03C0 Slot: 25
	public override void Teleport(Vector3 newPosition, bool clearPath = True) { }

	// RVA: 0xAF08D0 Offset: 0xAEF2D0 VA: 0x180AF08D0 Slot: 53
	public float get_remainingDistance() { }

	// RVA: 0xAF0560 Offset: 0xAEEF60 VA: 0x180AF0560 Slot: 54
	public bool get_reachedDestination() { }

	[CompilerGenerated]
	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60 Slot: 55
	public bool get_reachedEndOfPath() { }

	[CompilerGenerated]
	// RVA: 0x71DBF0 Offset: 0x71C5F0 VA: 0x18071DBF0
	protected void set_reachedEndOfPath(bool value) { }

	// RVA: 0xAF0520 Offset: 0xAEEF20 VA: 0x180AF0520 Slot: 62
	public bool get_hasPath() { }

	// RVA: 0xAF0550 Offset: 0xAEEF50 VA: 0x180AF0550 Slot: 63
	public bool get_pathPending() { }

	// RVA: 0xAF0B00 Offset: 0xAEF500 VA: 0x180AF0B00 Slot: 66
	public Vector3 get_steeringTarget() { }

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

	// RVA: 0xAEEFB0 Offset: 0xAED9B0 VA: 0x180AEEFB0 Slot: 69
	public void GetRemainingPath(List<Vector3> buffer, out bool stale) { }

	// RVA: 0xAEFB90 Offset: 0xAEE590 VA: 0x180AEFB90 Slot: 26
	protected override void OnDisable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 76
	public virtual void OnTargetReached() { }

	// RVA: 0xAEFC10 Offset: 0xAEE610 VA: 0x180AEFC10 Slot: 34
	protected override void OnPathComplete(Path newPath) { }

	// RVA: 0xAEEF30 Offset: 0xAED930 VA: 0x180AEEF30 Slot: 35
	protected override void ClearPath() { }

	// RVA: 0xAEF100 Offset: 0xAEDB00 VA: 0x180AEF100 Slot: 30
	protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: 0xAEE7B0 Offset: 0xAED1B0 VA: 0x180AEE7B0 Slot: 77
	protected virtual void CalculateNextRotation(float slowdown, out Quaternion nextRotation) { }

	// RVA: 0xAEEB00 Offset: 0xAED500 VA: 0x180AEEB00 Slot: 39
	protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged) { }

	// RVA: 0xAF0390 Offset: 0xAEED90 VA: 0x180AF0390 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }

	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60
	public bool get_TargetReached() { }

	// RVA: 0xAF0C90 Offset: 0xAEF690 VA: 0x180AF0C90
	public float get_turningSpeed() { }

	// RVA: 0xAF0CB0 Offset: 0xAEF6B0 VA: 0x180AF0CB0
	public void set_turningSpeed(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_speed() { }

	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	public void set_speed(float value) { }

	// RVA: 0xAF0BD0 Offset: 0xAEF5D0 VA: 0x180AF0BD0
	public Vector3 get_targetDirection() { }

	[Obsolete("This method no longer calculates the velocity. Use the desiredVelocity property instead")]
	// RVA: 0xAEEA10 Offset: 0xAED410 VA: 0x180AEEA10
	public Vector3 CalculateVelocity(Vector3 position) { }

	// RVA: 0xAF0450 Offset: 0xAEEE50 VA: 0x180AF0450
	public void .ctor() { }

	// RVA: 0xAF03F0 Offset: 0xAEEDF0 VA: 0x180AF03F0
	private static void .cctor() { }
}
