public class Simulator // TypeDefIndex: 13421
{
	// Fields
	private readonly bool doubleBuffering; // 0x10
	private float desiredDeltaTime; // 0x14
	private readonly Simulator.Worker[] workers; // 0x18
	private List<Agent> agents; // 0x20
	public List<ObstacleVertex> obstacles; // 0x28
	[CompilerGenerated]
	private RVOQuadtree <Quadtree>k__BackingField; // 0x30
	private float deltaTime; // 0x38
	private float lastStep; // 0x3C
	private bool doUpdateObstacles; // 0x40
	private bool doCleanObstacles; // 0x41
	public float symmetryBreakingBias; // 0x44
	public readonly MovementPlane movementPlane; // 0x48
	private Simulator.WorkerContext coroutineWorkerContext; // 0x50

	// Properties
	public RVOQuadtree Quadtree { get; set; }
	public float DeltaTime { get; }
	public bool Multithreading { get; }
	public float DesiredDeltaTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public RVOQuadtree get_Quadtree() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_Quadtree(RVOQuadtree value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_DeltaTime() { }

	// RVA: 0xBCAD00 Offset: 0xBC9700 VA: 0x180BCAD00
	public bool get_Multithreading() { }

	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_DesiredDeltaTime() { }

	// RVA: 0xBCAD20 Offset: 0xBC9720 VA: 0x180BCAD20
	public void set_DesiredDeltaTime(float value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<Agent> GetAgents() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<ObstacleVertex> GetObstacles() { }

	// RVA: 0xBCA8D0 Offset: 0xBC92D0 VA: 0x180BCA8D0
	public void .ctor(int workers, bool doubleBuffering, MovementPlane movementPlane) { }

	// RVA: 0xBC9730 Offset: 0xBC8130 VA: 0x180BC9730
	public void ClearAgents() { }

	// RVA: 0xBC9810 Offset: 0xBC8210 VA: 0x180BC9810
	public void OnDestroy() { }

	// RVA: 0xBC8A30 Offset: 0xBC7430 VA: 0x180BC8A30
	public IAgent AddAgent(IAgent agent) { }

	[Obsolete("Use AddAgent(Vector2,float) instead")]
	// RVA: 0xBC8A10 Offset: 0xBC7410 VA: 0x180BC8A10
	public IAgent AddAgent(Vector3 position) { }

	// RVA: 0xBC8C90 Offset: 0xBC7690 VA: 0x180BC8C90
	public IAgent AddAgent(Vector2 position, float elevationCoordinate) { }

	// RVA: 0xBC9990 Offset: 0xBC8390 VA: 0x180BC9990
	public void RemoveAgent(IAgent agent) { }

	// RVA: 0xBC92D0 Offset: 0xBC7CD0 VA: 0x180BC92D0
	public ObstacleVertex AddObstacle(ObstacleVertex v) { }

	// RVA: 0xBC9000 Offset: 0xBC7A00 VA: 0x180BC9000
	public ObstacleVertex AddObstacle(Vector3[] vertices, float height, bool cycle = True) { }

	// RVA: 0xBC8D10 Offset: 0xBC7710 VA: 0x180BC8D10
	public ObstacleVertex AddObstacle(Vector3[] vertices, float height, Matrix4x4 matrix, RVOLayer layer = 2, bool cycle = True) { }

	// RVA: 0xBC90C0 Offset: 0xBC7AC0 VA: 0x180BC90C0
	public ObstacleVertex AddObstacle(Vector3 a, Vector3 b, float height) { }

	// RVA: 0xBC9CB0 Offset: 0xBC86B0 VA: 0x180BC9CB0
	public void UpdateObstacle(ObstacleVertex obstacle, Vector3[] vertices, Matrix4x4 matrix) { }

	// RVA: 0xBC9CA0 Offset: 0xBC86A0 VA: 0x180BC9CA0
	private void ScheduleCleanObstacles() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CleanObstacles() { }

	// RVA: 0xBC9BE0 Offset: 0xBC85E0 VA: 0x180BC9BE0
	public void RemoveObstacle(ObstacleVertex v) { }

	// RVA: 0xBCA100 Offset: 0xBC8B00 VA: 0x180BCA100
	public void UpdateObstacles() { }

	// RVA: 0xBC9430 Offset: 0xBC7E30 VA: 0x180BC9430
	private void BuildQuadtree() { }

	// RVA: 0xBC9390 Offset: 0xBC7D90 VA: 0x180BC9390
	private void BlockUntilSimulationStepIsDone() { }

	// RVA: 0xBC98E0 Offset: 0xBC82E0 VA: 0x180BC98E0
	private void PreCalculation() { }

	// RVA: 0xBC9710 Offset: 0xBC8110 VA: 0x180BC9710
	private void CleanAndUpdateObstaclesIfNecessary() { }

	// RVA: 0xBCA110 Offset: 0xBC8B10 VA: 0x180BCA110
	public void Update() { }
}
