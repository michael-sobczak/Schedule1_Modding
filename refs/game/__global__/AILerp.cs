public class AILerp : VersionedMonoBehaviour, IAstarAI // TypeDefIndex: 13098
{
	// Fields
	public AutoRepathPolicy autoRepath; // 0x28
	public bool canMove; // 0x30
	public float speed; // 0x34
	[FormerlySerializedAs("rotationIn2D")]
	public OrientationMode orientation; // 0x38
	public bool enableRotation; // 0x3C
	public float rotationSpeed; // 0x40
	public bool interpolatePathSwitches; // 0x44
	public float switchPathInterpolationSpeed; // 0x48
	[CompilerGenerated]
	private bool <reachedEndOfPath>k__BackingField; // 0x4C
	[CompilerGenerated]
	private Vector3 <destination>k__BackingField; // 0x50
	public bool updatePosition; // 0x5C
	public bool updateRotation; // 0x5D
	[CompilerGenerated]
	private bool <isStopped>k__BackingField; // 0x5E
	[CompilerGenerated]
	private Action <onSearchPath>k__BackingField; // 0x60
	protected Seeker seeker; // 0x68
	protected Transform tr; // 0x70
	protected ABPath path; // 0x78
	protected bool canSearchAgain; // 0x80
	protected Vector3 previousMovementOrigin; // 0x84
	protected Vector3 previousMovementDirection; // 0x90
	protected float pathSwitchInterpolationTime; // 0x9C
	protected PathInterpolator interpolator; // 0xA0
	private bool startHasRun; // 0xA8
	private Vector3 previousPosition1; // 0xAC
	private Vector3 previousPosition2; // 0xB8
	private Vector3 simulatedPosition; // 0xC4
	private Quaternion simulatedRotation; // 0xD0
	[HideInInspector]
	[FormerlySerializedAs("target")]
	[SerializeField]
	private Transform targetCompatibility; // 0xE0
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("repathRate")]
	private float repathRateCompatibility; // 0xE8
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("canSearch")]
	private bool canSearchCompability; // 0xEC

	// Properties
	public float repathRate { get; set; }
	public bool canSearch { get; set; }
	[Obsolete("Use orientation instead")]
	public bool rotationIn2D { get; set; }
	public bool reachedEndOfPath { get; set; }
	public bool reachedDestination { get; }
	public Vector3 destination { get; set; }
	[Obsolete("Use the destination property or the AIDestinationSetter component instead")]
	public Transform target { get; set; }
	public Vector3 position { get; }
	public Quaternion rotation { get; set; }
	private float Pathfinding.IAstarAI.radius { get; set; }
	private float Pathfinding.IAstarAI.height { get; set; }
	private float Pathfinding.IAstarAI.maxSpeed { get; set; }
	private bool Pathfinding.IAstarAI.canSearch { get; set; }
	private bool Pathfinding.IAstarAI.canMove { get; set; }
	public Vector3 velocity { get; }
	private Vector3 Pathfinding.IAstarAI.desiredVelocity { get; }
	private Vector3 Pathfinding.IAstarAI.steeringTarget { get; }
	public float remainingDistance { get; set; }
	public bool hasPath { get; }
	public bool pathPending { get; }
	public bool isStopped { get; set; }
	public Action onSearchPath { get; set; }
	protected virtual bool shouldRecalculatePath { get; }

	// Methods

	// RVA: 0xAEE2A0 Offset: 0xAECCA0 VA: 0x180AEE2A0
	public float get_repathRate() { }

	// RVA: 0xAEE5D0 Offset: 0xAECFD0 VA: 0x180AEE5D0
	public void set_repathRate(float value) { }

	// RVA: 0xAED340 Offset: 0xAEBD40 VA: 0x180AED340
	public bool get_canSearch() { }

	// RVA: 0xAED530 Offset: 0xAEBF30 VA: 0x180AED530
	public void set_canSearch(bool value) { }

	// RVA: 0xAEE2C0 Offset: 0xAECCC0 VA: 0x180AEE2C0
	public bool get_rotationIn2D() { }

	// RVA: 0xAEE5F0 Offset: 0xAECFF0 VA: 0x180AEE5F0
	public void set_rotationIn2D(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0 Slot: 23
	public bool get_reachedEndOfPath() { }

	[CompilerGenerated]
	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	private void set_reachedEndOfPath(bool value) { }

	// RVA: 0xAEE140 Offset: 0xAECB40 VA: 0x180AEE140 Slot: 22
	public bool get_reachedDestination() { }

	[CompilerGenerated]
	// RVA: 0x4CD420 Offset: 0x4CBE20 VA: 0x1804CD420 Slot: 24
	public Vector3 get_destination() { }

	[CompilerGenerated]
	// RVA: 0xAEE570 Offset: 0xAECF70 VA: 0x180AEE570 Slot: 25
	public void set_destination(Vector3 value) { }

	// RVA: 0xAEE3E0 Offset: 0xAECDE0 VA: 0x180AEE3E0
	public Transform get_target() { }

	// RVA: 0xAEE660 Offset: 0xAED060 VA: 0x180AEE660
	public void set_target(Transform value) { }

	// RVA: 0xAEE0E0 Offset: 0xAECAE0 VA: 0x180AEE0E0 Slot: 14
	public Vector3 get_position() { }

	// RVA: 0xAEE2D0 Offset: 0xAECCD0 VA: 0x180AEE2D0 Slot: 15
	public Quaternion get_rotation() { }

	// RVA: 0xAEE610 Offset: 0xAED010 VA: 0x180AEE610 Slot: 16
	public void set_rotation(Quaternion value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 41
	private void Pathfinding.IAstarAI.Move(Vector3 deltaPosition) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 10
	private float Pathfinding.IAstarAI.get_radius() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	private void Pathfinding.IAstarAI.set_radius(float value) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 12
	private float Pathfinding.IAstarAI.get_height() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	private void Pathfinding.IAstarAI.set_height(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250 Slot: 17
	private float Pathfinding.IAstarAI.get_maxSpeed() { }

	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0 Slot: 18
	private void Pathfinding.IAstarAI.set_maxSpeed(float value) { }

	// RVA: 0xAED340 Offset: 0xAEBD40 VA: 0x180AED340 Slot: 26
	private bool Pathfinding.IAstarAI.get_canSearch() { }

	// RVA: 0xAED530 Offset: 0xAEBF30 VA: 0x180AED530 Slot: 27
	private void Pathfinding.IAstarAI.set_canSearch(bool value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 28
	private bool Pathfinding.IAstarAI.get_canMove() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50 Slot: 29
	private void Pathfinding.IAstarAI.set_canMove(bool value) { }

	// RVA: 0xAEE470 Offset: 0xAECE70 VA: 0x180AEE470 Slot: 19
	public Vector3 get_velocity() { }

	// RVA: 0xAED360 Offset: 0xAEBD60 VA: 0x180AED360 Slot: 20
	private Vector3 Pathfinding.IAstarAI.get_desiredVelocity() { }

	// RVA: 0xAED430 Offset: 0xAEBE30 VA: 0x180AED430 Slot: 34
	private Vector3 Pathfinding.IAstarAI.get_steeringTarget() { }

	// RVA: 0xAEE270 Offset: 0xAECC70 VA: 0x180AEE270 Slot: 21
	public float get_remainingDistance() { }

	// RVA: 0xAEE5A0 Offset: 0xAECFA0 VA: 0x180AEE5A0
	public void set_remainingDistance(float value) { }

	// RVA: 0xAEE0A0 Offset: 0xAECAA0 VA: 0x180AEE0A0 Slot: 30
	public bool get_hasPath() { }

	// RVA: 0xAEE0D0 Offset: 0xAECAD0 VA: 0x180AEE0D0 Slot: 31
	public bool get_pathPending() { }

	[CompilerGenerated]
	// RVA: 0x4CD960 Offset: 0x4CC360 VA: 0x1804CD960 Slot: 32
	public bool get_isStopped() { }

	[CompilerGenerated]
	// RVA: 0xAEE580 Offset: 0xAECF80 VA: 0x180AEE580 Slot: 33
	public void set_isStopped(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 35
	public Action get_onSearchPath() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0 Slot: 36
	public void set_onSearchPath(Action value) { }

	// RVA: 0xAEDFA0 Offset: 0xAEC9A0 VA: 0x180AEDFA0
	protected void .ctor() { }

	// RVA: 0xAEBC90 Offset: 0xAEA690 VA: 0x180AEBC90 Slot: 7
	protected override void Awake() { }

	// RVA: 0xAEDCD0 Offset: 0xAEC6D0 VA: 0x180AEDCD0 Slot: 44
	protected virtual void Start() { }

	// RVA: 0xAECD70 Offset: 0xAEB770 VA: 0x180AECD70 Slot: 45
	protected virtual void OnEnable() { }

	// RVA: 0xAEC990 Offset: 0xAEB390 VA: 0x180AEC990
	private void Init() { }

	// RVA: 0xAECBD0 Offset: 0xAEB5D0 VA: 0x180AECBD0
	public void OnDisable() { }

	// RVA: 0xAEC7C0 Offset: 0xAEB1C0 VA: 0x180AEC7C0 Slot: 37
	public void GetRemainingPath(List<Vector3> buffer, out bool stale) { }

	// RVA: 0xAEDCE0 Offset: 0xAEC6E0 VA: 0x180AEDCE0 Slot: 40
	public void Teleport(Vector3 position, bool clearPath = True) { }

	// RVA: 0xAEE320 Offset: 0xAECD20 VA: 0x180AEE320 Slot: 46
	protected virtual bool get_shouldRecalculatePath() { }

	[Obsolete("Use SearchPath instead")]
	// RVA: 0xAD5CC0 Offset: 0xAD46C0 VA: 0x180AD5CC0 Slot: 47
	public virtual void ForceSearchPath() { }

	// RVA: 0xAED550 Offset: 0xAEBF50 VA: 0x180AED550 Slot: 48
	public virtual void SearchPath() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 49
	public virtual void OnTargetReached() { }

	// RVA: 0xAECE70 Offset: 0xAEB870 VA: 0x180AECE70 Slot: 50
	protected virtual void OnPathComplete(Path _p) { }

	// RVA: 0xAEC150 Offset: 0xAEAB50 VA: 0x180AEC150 Slot: 51
	protected virtual void ClearPath() { }

	// RVA: 0xAED660 Offset: 0xAEC060 VA: 0x180AED660 Slot: 39
	public void SetPath(Path path, bool updateDestinationFromPath = True) { }

	// RVA: 0xAEC4A0 Offset: 0xAEAEA0 VA: 0x180AEC4A0 Slot: 52
	protected virtual void ConfigurePathSwitchInterpolation() { }

	// RVA: 0xAEC760 Offset: 0xAEB160 VA: 0x180AEC760 Slot: 53
	public virtual Vector3 GetFeetPosition() { }

	// RVA: 0xAEC280 Offset: 0xAEAC80 VA: 0x180AEC280 Slot: 54
	protected virtual void ConfigureNewPath() { }

	// RVA: 0xAEDDA0 Offset: 0xAEC7A0 VA: 0x180AEDDA0 Slot: 55
	protected virtual void Update() { }

	// RVA: 0xAECAA0 Offset: 0xAEB4A0 VA: 0x180AECAA0 Slot: 42
	public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: 0xAEC6A0 Offset: 0xAEB0A0 VA: 0x180AEC6A0 Slot: 43
	public void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation) { }

	// RVA: 0xAED950 Offset: 0xAEC350 VA: 0x180AED950
	private Quaternion SimulateRotationTowards(Vector3 direction, float deltaTime) { }

	// RVA: 0xAEBD80 Offset: 0xAEA780 VA: 0x180AEBD80 Slot: 56
	protected virtual Vector3 CalculateNextPosition(out Vector3 direction, float deltaTime) { }

	// RVA: 0xAED140 Offset: 0xAEBB40 VA: 0x180AED140 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }

	// RVA: 0xAECCE0 Offset: 0xAEB6E0 VA: 0x180AECCE0 Slot: 57
	public virtual void OnDrawGizmos() { }

	[CompilerGenerated]
	// RVA: 0x4D6330 Offset: 0x4D4D30 VA: 0x1804D6330
	private Vector3 <Awake>b__91_0() { }
}
