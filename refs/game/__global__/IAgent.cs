public interface IAgent // TypeDefIndex: 13416
{
	// Properties
	public abstract Vector2 Position { get; set; }
	public abstract float ElevationCoordinate { get; set; }
	public abstract Vector2 CalculatedTargetPoint { get; }
	public abstract float CalculatedSpeed { get; }
	public abstract bool Locked { get; set; }
	public abstract float Radius { get; set; }
	public abstract float Height { get; set; }
	public abstract float AgentTimeHorizon { get; set; }
	public abstract float ObstacleTimeHorizon { get; set; }
	public abstract int MaxNeighbours { get; set; }
	public abstract int NeighbourCount { get; }
	public abstract RVOLayer Layer { get; set; }
	public abstract RVOLayer CollidesWith { get; set; }
	public abstract bool DebugDraw { get; set; }
	[Obsolete]
	public abstract List<ObstacleVertex> NeighbourObstacles { get; }
	public abstract float Priority { get; set; }
	public abstract Action PreCalculationCallback { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_Position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Position(Vector2 value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_ElevationCoordinate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_ElevationCoordinate(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector2 get_CalculatedTargetPoint();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_CalculatedSpeed();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_Locked();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_Locked(bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract float get_Radius();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_Radius(float value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_Height();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Height(float value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_AgentTimeHorizon();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_AgentTimeHorizon(float value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract float get_ObstacleTimeHorizon();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_ObstacleTimeHorizon(float value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_MaxNeighbours();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void set_MaxNeighbours(int value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int get_NeighbourCount();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract RVOLayer get_Layer();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_Layer(RVOLayer value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract RVOLayer get_CollidesWith();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_CollidesWith(RVOLayer value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool get_DebugDraw();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_DebugDraw(bool value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract List<ObstacleVertex> get_NeighbourObstacles();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract float get_Priority();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_Priority(float value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void set_PreCalculationCallback(Action value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetCollisionNormal(Vector2 normal);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void ForceSetVelocity(Vector2 velocity);
}
