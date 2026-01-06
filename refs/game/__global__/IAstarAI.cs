public interface IAstarAI // TypeDefIndex: 13100
{
	// Properties
	public abstract float radius { get; set; }
	public abstract float height { get; set; }
	public abstract Vector3 position { get; }
	public abstract Quaternion rotation { get; set; }
	public abstract float maxSpeed { get; set; }
	public abstract Vector3 velocity { get; }
	public abstract Vector3 desiredVelocity { get; }
	public abstract float remainingDistance { get; }
	public abstract bool reachedDestination { get; }
	public abstract bool reachedEndOfPath { get; }
	public abstract Vector3 destination { get; set; }
	public abstract bool canSearch { get; set; }
	public abstract bool canMove { get; set; }
	public abstract bool hasPath { get; }
	public abstract bool pathPending { get; }
	public abstract bool isStopped { get; set; }
	public abstract Vector3 steeringTarget { get; }
	public abstract Action onSearchPath { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_radius();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_radius(float value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_height();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_height(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Quaternion get_rotation();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_rotation(Quaternion value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_maxSpeed();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_maxSpeed(float value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Vector3 get_velocity();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector3 get_desiredVelocity();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_remainingDistance();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_reachedDestination();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_reachedEndOfPath();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Vector3 get_destination();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_destination(Vector3 value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_canSearch();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_canSearch(bool value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_canMove();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_canMove(bool value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_hasPath();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool get_pathPending();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_isStopped();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_isStopped(bool value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Vector3 get_steeringTarget();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Action get_onSearchPath();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void set_onSearchPath(Action value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void GetRemainingPath(List<Vector3> buffer, out bool stale);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SearchPath();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void SetPath(Path path, bool updateDestinationFromPath = True);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void Teleport(Vector3 newPosition, bool clearPath = True);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void Move(Vector3 deltaPosition);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation);
}
