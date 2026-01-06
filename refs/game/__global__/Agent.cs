public class Agent : IAgent // TypeDefIndex: 13436
{
	// Fields
	internal float radius; // 0x10
	internal float height; // 0x14
	internal float desiredSpeed; // 0x18
	internal float maxSpeed; // 0x1C
	internal float agentTimeHorizon; // 0x20
	internal float obstacleTimeHorizon; // 0x24
	internal bool locked; // 0x28
	private RVOLayer layer; // 0x2C
	private RVOLayer collidesWith; // 0x30
	private int maxNeighbours; // 0x34
	internal Vector2 position; // 0x38
	private float elevationCoordinate; // 0x40
	private Vector2 currentVelocity; // 0x44
	private Vector2 desiredTargetPointInVelocitySpace; // 0x4C
	private Vector2 desiredVelocity; // 0x54
	private Vector2 nextTargetPoint; // 0x5C
	private float nextDesiredSpeed; // 0x64
	private float nextMaxSpeed; // 0x68
	private Vector2 collisionNormal; // 0x6C
	private bool manuallyControlled; // 0x74
	private bool debugDraw; // 0x75
	[CompilerGenerated]
	private Vector2 <Position>k__BackingField; // 0x78
	[CompilerGenerated]
	private float <ElevationCoordinate>k__BackingField; // 0x80
	[CompilerGenerated]
	private Vector2 <CalculatedTargetPoint>k__BackingField; // 0x84
	[CompilerGenerated]
	private float <CalculatedSpeed>k__BackingField; // 0x8C
	[CompilerGenerated]
	private bool <Locked>k__BackingField; // 0x90
	[CompilerGenerated]
	private float <Radius>k__BackingField; // 0x94
	[CompilerGenerated]
	private float <Height>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <AgentTimeHorizon>k__BackingField; // 0x9C
	[CompilerGenerated]
	private float <ObstacleTimeHorizon>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <MaxNeighbours>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <NeighbourCount>k__BackingField; // 0xA8
	[CompilerGenerated]
	private RVOLayer <Layer>k__BackingField; // 0xAC
	[CompilerGenerated]
	private RVOLayer <CollidesWith>k__BackingField; // 0xB0
	[CompilerGenerated]
	private float <Priority>k__BackingField; // 0xB4
	[CompilerGenerated]
	private Action <PreCalculationCallback>k__BackingField; // 0xB8
	internal Agent next; // 0xC0
	private float calculatedSpeed; // 0xC8
	private Vector2 calculatedTargetPoint; // 0xCC
	internal Simulator simulator; // 0xD8
	private List<Agent> neighbours; // 0xE0
	private List<float> neighbourDists; // 0xE8
	private List<ObstacleVertex> obstaclesBuffered; // 0xF0
	private List<ObstacleVertex> obstacles; // 0xF8
	private const float DesiredVelocityWeight = 0.1;
	private const float WallWeight = 5;

	// Properties
	public Vector2 Position { get; set; }
	public float ElevationCoordinate { get; set; }
	public Vector2 CalculatedTargetPoint { get; set; }
	public float CalculatedSpeed { get; set; }
	public bool Locked { get; set; }
	public float Radius { get; set; }
	public float Height { get; set; }
	public float AgentTimeHorizon { get; set; }
	public float ObstacleTimeHorizon { get; set; }
	public int MaxNeighbours { get; set; }
	public int NeighbourCount { get; set; }
	public RVOLayer Layer { get; set; }
	public RVOLayer CollidesWith { get; set; }
	public bool DebugDraw { get; set; }
	public float Priority { get; set; }
	private Action PreCalculationCallback { get; set; }
	public List<ObstacleVertex> NeighbourObstacles { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBBA770 Offset: 0xBB9170 VA: 0x180BBA770 Slot: 4
	public Vector2 get_Position() { }

	[CompilerGenerated]
	// RVA: 0xBBA840 Offset: 0xBB9240 VA: 0x180BBA840 Slot: 5
	public void set_Position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300 Slot: 6
	public float get_ElevationCoordinate() { }

	[CompilerGenerated]
	// RVA: 0xA546B0 Offset: 0xA530B0 VA: 0x180A546B0 Slot: 7
	public void set_ElevationCoordinate(float value) { }

	[CompilerGenerated]
	// RVA: 0xBBA720 Offset: 0xBB9120 VA: 0x180BBA720 Slot: 8
	public Vector2 get_CalculatedTargetPoint() { }

	[CompilerGenerated]
	// RVA: 0xBBA7B0 Offset: 0xBB91B0 VA: 0x180BBA7B0
	private void set_CalculatedTargetPoint(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x8D2160 Offset: 0x8D0B60 VA: 0x1808D2160 Slot: 9
	public float get_CalculatedSpeed() { }

	[CompilerGenerated]
	// RVA: 0xBBA7A0 Offset: 0xBB91A0 VA: 0x180BBA7A0
	private void set_CalculatedSpeed(float value) { }

	[CompilerGenerated]
	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00 Slot: 11
	public bool get_Locked() { }

	[CompilerGenerated]
	// RVA: 0x979B10 Offset: 0x978510 VA: 0x180979B10 Slot: 12
	public void set_Locked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2000 Offset: 0x8D0A00 VA: 0x1808D2000 Slot: 13
	public float get_Radius() { }

	[CompilerGenerated]
	// RVA: 0xBBA860 Offset: 0xBB9260 VA: 0x180BBA860 Slot: 14
	public void set_Radius(float value) { }

	[CompilerGenerated]
	// RVA: 0x8B33F0 Offset: 0x8B1DF0 VA: 0x1808B33F0 Slot: 15
	public float get_Height() { }

	[CompilerGenerated]
	// RVA: 0x8B3500 Offset: 0x8B1F00 VA: 0x1808B3500 Slot: 16
	public void set_Height(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A5280 Offset: 0x6A3C80 VA: 0x1806A5280 Slot: 17
	public float get_AgentTimeHorizon() { }

	[CompilerGenerated]
	// RVA: 0x8B34F0 Offset: 0x8B1EF0 VA: 0x1808B34F0 Slot: 18
	public void set_AgentTimeHorizon(float value) { }

	[CompilerGenerated]
	// RVA: 0x8B3450 Offset: 0x8B1E50 VA: 0x1808B3450 Slot: 19
	public float get_ObstacleTimeHorizon() { }

	[CompilerGenerated]
	// RVA: 0x8B3540 Offset: 0x8B1F40 VA: 0x1808B3540 Slot: 20
	public void set_ObstacleTimeHorizon(float value) { }

	[CompilerGenerated]
	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760 Slot: 21
	public int get_MaxNeighbours() { }

	[CompilerGenerated]
	// RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830 Slot: 22
	public void set_MaxNeighbours(int value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050 Slot: 23
	public int get_NeighbourCount() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	private void set_NeighbourCount(int value) { }

	[CompilerGenerated]
	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750 Slot: 24
	public RVOLayer get_Layer() { }

	[CompilerGenerated]
	// RVA: 0xBBA820 Offset: 0xBB9220 VA: 0x180BBA820 Slot: 25
	public void set_Layer(RVOLayer value) { }

	[CompilerGenerated]
	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740 Slot: 26
	public RVOLayer get_CollidesWith() { }

	[CompilerGenerated]
	// RVA: 0xBBA7C0 Offset: 0xBB91C0 VA: 0x180BBA7C0 Slot: 27
	public void set_CollidesWith(RVOLayer value) { }

	// RVA: 0x6586F0 Offset: 0x6570F0 VA: 0x1806586F0 Slot: 28
	public bool get_DebugDraw() { }

	// RVA: 0xBBA7D0 Offset: 0xBB91D0 VA: 0x180BBA7D0 Slot: 29
	public void set_DebugDraw(bool value) { }

	[CompilerGenerated]
	// RVA: 0xBBA790 Offset: 0xBB9190 VA: 0x180BBA790 Slot: 31
	public float get_Priority() { }

	[CompilerGenerated]
	// RVA: 0xBBA850 Offset: 0xBB9250 VA: 0x180BBA850 Slot: 32
	public void set_Priority(float value) { }

	[CompilerGenerated]
	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	private Action get_PreCalculationCallback() { }

	[CompilerGenerated]
	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0 Slot: 33
	public void set_PreCalculationCallback(Action value) { }

	// RVA: 0xBBA0C0 Offset: 0xBB8AC0 VA: 0x180BBA0C0 Slot: 10
	public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed) { }

	// RVA: 0xBBA0B0 Offset: 0xBB8AB0 VA: 0x180BBA0B0 Slot: 34
	public void SetCollisionNormal(Vector2 normal) { }

	// RVA: 0xBB9090 Offset: 0xBB7A90 VA: 0x180BB9090 Slot: 35
	public void ForceSetVelocity(Vector2 velocity) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 30
	public List<ObstacleVertex> get_NeighbourObstacles() { }

	// RVA: 0xBBA4C0 Offset: 0xBB8EC0 VA: 0x180BBA4C0
	public void .ctor(Vector2 pos, float elevationCoordinate) { }

	// RVA: 0xBB7F50 Offset: 0xBB6950 VA: 0x180BB7F50
	public void BufferSwitch() { }

	// RVA: 0xBBA030 Offset: 0xBB8A30 VA: 0x180BBA030
	public void PreCalculation() { }

	// RVA: 0xBB9FB0 Offset: 0xBB89B0 VA: 0x180BB9FB0
	public void PostCalculation() { }

	// RVA: 0xBB8200 Offset: 0xBB6C00 VA: 0x180BB8200
	public void CalculateNeighbours() { }

	// RVA: 0xBBA170 Offset: 0xBB8B70 VA: 0x180BBA170
	private static float Sqr(float x) { }

	// RVA: 0xBB9CC0 Offset: 0xBB86C0 VA: 0x180BB9CC0
	internal float InsertAgentNeighbour(Agent agent, float rangeSq) { }

	// RVA: 0xB825F0 Offset: 0xB80FF0 VA: 0x180B825F0
	private static Vector3 FromXZ(Vector2 p) { }

	// RVA: 0x7BCB30 Offset: 0x7BB530 VA: 0x1807BCB30
	private static Vector2 ToXZ(Vector3 p) { }

	// RVA: 0xBBA180 Offset: 0xBB8B80 VA: 0x180BBA180
	private Vector2 To2D(Vector3 p, out float elevation) { }

	// RVA: 0xBB88D0 Offset: 0xBB72D0 VA: 0x180BB88D0
	private static void DrawVO(Vector2 circleCenter, float radius, Vector2 origin) { }

	// RVA: 0xBB8380 Offset: 0xBB6D80 VA: 0x180BB8380
	internal void CalculateVelocity(Simulator.WorkerContext context) { }

	// RVA: 0xBBA060 Offset: 0xBB8A60 VA: 0x180BBA060
	private static Color Rainbow(float v) { }

	// RVA: 0xBB9560 Offset: 0xBB7F60 VA: 0x180BB9560
	private void GenerateObstacleVOs(Agent.VOBuffer vos) { }

	// RVA: 0xBB9110 Offset: 0xBB7B10 VA: 0x180BB9110
	private void GenerateNeighbourAgentVOs(Agent.VOBuffer vos) { }

	// RVA: 0xBB9AA0 Offset: 0xBB84A0 VA: 0x180BB9AA0
	private Vector2 GradientDescent(Agent.VOBuffer vos, Vector2 sampleAround1, Vector2 sampleAround2) { }

	// RVA: 0xBB7DE0 Offset: 0xBB67E0 VA: 0x180BB7DE0
	private static bool BiasDesiredVelocity(Agent.VOBuffer vos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians) { }

	// RVA: 0xBB8CE0 Offset: 0xBB76E0 VA: 0x180BB8CE0
	private Vector2 EvaluateGradient(Agent.VOBuffer vos, Vector2 p, out float value) { }

	// RVA: 0xBBA1E0 Offset: 0xBB8BE0 VA: 0x180BBA1E0
	private Vector2 Trace(Agent.VOBuffer vos, Vector2 p, out float score) { }
}
