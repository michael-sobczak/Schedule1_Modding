public abstract class AIBase : VersionedMonoBehaviour // TypeDefIndex: 13097
{
	// Fields
	public float radius; // 0x28
	public float height; // 0x2C
	public bool canMove; // 0x30
	[FormerlySerializedAs("speed")]
	public float maxSpeed; // 0x34
	public Vector3 gravity; // 0x38
	public LayerMask groundMask; // 0x44
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("centerOffset")]
	private float centerOffsetCompatibility; // 0x48
	[HideInInspector]
	[FormerlySerializedAs("repathRate")]
	[SerializeField]
	private float repathRateCompatibility; // 0x4C
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("repeatedlySearchPaths")]
	[FormerlySerializedAs("canSearch")]
	private bool canSearchCompability; // 0x50
	[FormerlySerializedAs("rotationIn2D")]
	public OrientationMode orientation; // 0x54
	public bool enableRotation; // 0x58
	protected Vector3 simulatedPosition; // 0x5C
	protected Quaternion simulatedRotation; // 0x68
	private Vector3 accumulatedMovementDelta; // 0x78
	protected Vector2 velocity2D; // 0x84
	protected float verticalVelocity; // 0x8C
	protected Seeker seeker; // 0x90
	protected Transform tr; // 0x98
	protected Rigidbody rigid; // 0xA0
	protected Rigidbody2D rigid2D; // 0xA8
	protected CharacterController controller; // 0xB0
	protected RVOController rvoController; // 0xB8
	public IMovementPlane movementPlane; // 0xC0
	public bool updatePosition; // 0xC8
	public bool updateRotation; // 0xC9
	public AutoRepathPolicy autoRepath; // 0xD0
	[CompilerGenerated]
	private bool <usingGravity>k__BackingField; // 0xD8
	protected float lastDeltaTime; // 0xDC
	protected int prevFrame; // 0xE0
	protected Vector3 prevPosition1; // 0xE4
	protected Vector3 prevPosition2; // 0xF0
	protected Vector2 lastDeltaPosition; // 0xFC
	protected bool waitingForPathCalculation; // 0x104
	[HideInInspector]
	[SerializeField]
	[FormerlySerializedAs("target")]
	private Transform targetCompatibility; // 0x108
	private bool startHasRun; // 0x110
	[CompilerGenerated]
	private Vector3 <destination>k__BackingField; // 0x114
	[CompilerGenerated]
	private bool <isStopped>k__BackingField; // 0x120
	[CompilerGenerated]
	private Action <onSearchPath>k__BackingField; // 0x128
	public static readonly Color ShapeGizmoColor; // 0x0

	// Properties
	public float repathRate { get; set; }
	public bool canSearch { get; set; }
	[Obsolete("Use the height property instead (2x this value)")]
	public float centerOffset { get; set; }
	[Obsolete("Use orientation instead")]
	public bool rotationIn2D { get; set; }
	public Vector3 position { get; }
	public Quaternion rotation { get; set; }
	protected bool usingGravity { get; set; }
	[Obsolete("Use the destination property or the AIDestinationSetter component instead")]
	public Transform target { get; set; }
	public Vector3 destination { get; set; }
	public Vector3 velocity { get; }
	public Vector3 desiredVelocity { get; }
	public bool isStopped { get; set; }
	public Action onSearchPath { get; set; }
	protected virtual bool shouldRecalculatePath { get; }

	// Methods

	// RVA: 0xAEB430 Offset: 0xAE9E30 VA: 0x180AEB430
	public float get_repathRate() { }

	// RVA: 0xAEB730 Offset: 0xAEA130 VA: 0x180AEB730
	public void set_repathRate(float value) { }

	// RVA: 0xAEB290 Offset: 0xAE9C90 VA: 0x180AEB290
	public bool get_canSearch() { }

	// RVA: 0xAEB6C0 Offset: 0xAEA0C0 VA: 0x180AEB6C0
	public void set_canSearch(bool value) { }

	// RVA: 0xAEB2C0 Offset: 0xAE9CC0 VA: 0x180AEB2C0
	public float get_centerOffset() { }

	// RVA: 0xAEB700 Offset: 0xAEA100 VA: 0x180AEB700
	public void set_centerOffset(float value) { }

	// RVA: 0xAEB450 Offset: 0xAE9E50 VA: 0x180AEB450
	public bool get_rotationIn2D() { }

	// RVA: 0xAEB750 Offset: 0xAEA150 VA: 0x180AEB750
	public void set_rotationIn2D(bool value) { }

	// RVA: 0xAEB3D0 Offset: 0xAE9DD0 VA: 0x180AEB3D0 Slot: 10
	public Vector3 get_position() { }

	// RVA: 0xAEB460 Offset: 0xAE9E60 VA: 0x180AEB460 Slot: 11
	public Quaternion get_rotation() { }

	// RVA: 0xAEB770 Offset: 0xAEA170 VA: 0x180AEB770 Slot: 12
	public void set_rotation(Quaternion value) { }

	[CompilerGenerated]
	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	protected bool get_usingGravity() { }

	[CompilerGenerated]
	// RVA: 0xAEB920 Offset: 0xAEA320 VA: 0x180AEB920
	protected void set_usingGravity(bool value) { }

	// RVA: 0xAEB570 Offset: 0xAE9F70 VA: 0x180AEB570
	public Transform get_target() { }

	// RVA: 0xAEB7C0 Offset: 0xAEA1C0 VA: 0x180AEB7C0
	public void set_target(Transform value) { }

	[CompilerGenerated]
	// RVA: 0xAEB3B0 Offset: 0xAE9DB0 VA: 0x180AEB3B0 Slot: 13
	public Vector3 get_destination() { }

	[CompilerGenerated]
	// RVA: 0xAEB710 Offset: 0xAEA110 VA: 0x180AEB710 Slot: 14
	public void set_destination(Vector3 value) { }

	// RVA: 0xAEB600 Offset: 0xAEA000 VA: 0x180AEB600 Slot: 15
	public Vector3 get_velocity() { }

	// RVA: 0xAEB2D0 Offset: 0xAE9CD0 VA: 0x180AEB2D0 Slot: 16
	public Vector3 get_desiredVelocity() { }

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170 Slot: 17
	public bool get_isStopped() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0 Slot: 18
	public void set_isStopped(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 19
	public Action get_onSearchPath() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0 Slot: 20
	public void set_onSearchPath(Action value) { }

	// RVA: 0xAEB4B0 Offset: 0xAE9EB0 VA: 0x180AEB4B0 Slot: 21
	protected virtual bool get_shouldRecalculatePath() { }

	// RVA: 0xAEB120 Offset: 0xAE9B20 VA: 0x180AEB120
	protected void .ctor() { }

	// RVA: 0xAE8DE0 Offset: 0xAE77E0 VA: 0x180AE8DE0 Slot: 22
	public virtual void FindComponents() { }

	// RVA: 0xAE9980 Offset: 0xAE8380 VA: 0x180AE9980 Slot: 23
	protected virtual void OnEnable() { }

	// RVA: 0xAEAC40 Offset: 0xAE9640 VA: 0x180AEAC40 Slot: 24
	protected virtual void Start() { }

	// RVA: 0xAE90A0 Offset: 0xAE7AA0 VA: 0x180AE90A0
	private void Init() { }

	// RVA: 0xAEAC50 Offset: 0xAE9650 VA: 0x180AEAC50 Slot: 25
	public virtual void Teleport(Vector3 newPosition, bool clearPath = True) { }

	// RVA: 0xAE8460 Offset: 0xAE6E60 VA: 0x180AE8460
	protected void CancelCurrentPathRequest() { }

	// RVA: 0xAE9200 Offset: 0xAE7C00 VA: 0x180AE9200 Slot: 26
	protected virtual void OnDisable() { }

	// RVA: 0xAEAE50 Offset: 0xAE9850 VA: 0x180AEAE50 Slot: 27
	protected virtual void Update() { }

	// RVA: 0xAE8F20 Offset: 0xAE7920 VA: 0x180AE8F20 Slot: 28
	protected virtual void FixedUpdate() { }

	// RVA: 0xAE91D0 Offset: 0xAE7BD0 VA: 0x180AE91D0 Slot: 29
	public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation) { }

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

	// RVA: 0xAE83F0 Offset: 0xAE6DF0 VA: 0x180AE83F0 Slot: 31
	protected virtual void CalculatePathRequestEndpoints(out Vector3 start, out Vector3 end) { }

	// RVA: 0xAEA200 Offset: 0xAE8C00 VA: 0x180AEA200 Slot: 32
	public virtual void SearchPath() { }

	// RVA: 0xAE9040 Offset: 0xAE7A40 VA: 0x180AE9040 Slot: 33
	public virtual Vector3 GetFeetPosition() { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract void OnPathComplete(Path newPath);

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract void ClearPath();

	// RVA: 0xAEA350 Offset: 0xAE8D50 VA: 0x180AEA350 Slot: 36
	public void SetPath(Path path, bool updateDestinationFromPath = True) { }

	// RVA: 0xAE7F90 Offset: 0xAE6990 VA: 0x180AE7F90
	protected void ApplyGravity(float deltaTime) { }

	// RVA: 0xAE81E0 Offset: 0xAE6BE0 VA: 0x180AE81E0
	protected Vector2 CalculateDeltaToMoveThisFrame(Vector2 position, float distanceToEndOfPath, float deltaTime) { }

	// RVA: 0xAEA660 Offset: 0xAE9060 VA: 0x180AEA660
	public Quaternion SimulateRotationTowards(Vector3 direction, float maxDegrees) { }

	// RVA: 0xAEA790 Offset: 0xAE9190 VA: 0x180AEA790
	protected Quaternion SimulateRotationTowards(Vector2 direction, float maxDegrees) { }

	// RVA: 0xAE9180 Offset: 0xAE7B80 VA: 0x180AE9180 Slot: 37
	public virtual void Move(Vector3 deltaPosition) { }

	// RVA: 0xAE8570 Offset: 0xAE6F70 VA: 0x180AE8570 Slot: 38
	public virtual void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation) { }

	// RVA: 0xAE8C30 Offset: 0xAE7630 VA: 0x180AE8C30
	private void FinalizeRotation(Quaternion nextRotation) { }

	// RVA: 0xAE8740 Offset: 0xAE7140 VA: 0x180AE8740
	private void FinalizePosition(Vector3 nextPosition) { }

	// RVA: 0xAEADB0 Offset: 0xAE97B0 VA: 0x180AEADB0
	protected void UpdateVelocity() { }

	// RVA: 0xAE8550 Offset: 0xAE6F50 VA: 0x180AE8550 Slot: 39
	protected virtual Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged) { }

	// RVA: 0xAE9D30 Offset: 0xAE8730 VA: 0x180AE9D30
	protected Vector3 RaycastPosition(Vector3 position, float lastElevation) { }

	// RVA: 0xAE93A0 Offset: 0xAE7DA0 VA: 0x180AE93A0 Slot: 40
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0xAE9410 Offset: 0xAE7E10 VA: 0x180AE9410 Slot: 41
	protected virtual void OnDrawGizmos() { }

	// RVA: 0xAEA1E0 Offset: 0xAE8BE0 VA: 0x180AEA1E0 Slot: 8
	protected override void Reset() { }

	// RVA: 0xAEA120 Offset: 0xAE8B20 VA: 0x180AEA120
	private void ResetShape() { }

	// RVA: 0xAE9AA0 Offset: 0xAE84A0 VA: 0x180AE9AA0 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }

	// RVA: 0xAEB0E0 Offset: 0xAE9AE0 VA: 0x180AEB0E0
	private static void .cctor() { }
}
