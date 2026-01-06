public abstract class RVOObstacle : VersionedMonoBehaviour // TypeDefIndex: 13431
{
	// Fields
	public RVOObstacle.ObstacleVertexWinding obstacleMode; // 0x28
	public RVOLayer layer; // 0x2C
	protected Simulator sim; // 0x30
	private List<ObstacleVertex> addedObstacles; // 0x38
	private List<Vector3[]> sourceObstacles; // 0x40
	private bool gizmoDrawing; // 0x48
	private List<Vector3[]> gizmoVerts; // 0x50
	private RVOObstacle.ObstacleVertexWinding _obstacleMode; // 0x58
	private Matrix4x4 prevUpdateMatrix; // 0x5C

	// Properties
	protected abstract bool ExecuteInEditor { get; }
	protected abstract bool LocalCoordinates { get; }
	protected abstract bool StaticObstacle { get; }
	protected abstract float Height { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void CreateObstacles();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool get_ExecuteInEditor();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool get_LocalCoordinates();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract bool get_StaticObstacle();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract float get_Height();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract bool AreGizmosDirty();

	// RVA: 0xBC52D0 Offset: 0xBC3CD0 VA: 0x180BC52D0
	public void OnDrawGizmos() { }

	// RVA: 0xBC52C0 Offset: 0xBC3CC0 VA: 0x180BC52C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0xBC52E0 Offset: 0xBC3CE0 VA: 0x180BC52E0
	public void OnDrawGizmos(bool selected) { }

	// RVA: 0xBC5060 Offset: 0xBC3A60 VA: 0x180BC5060 Slot: 16
	protected virtual Matrix4x4 GetMatrix() { }

	// RVA: 0xBC5120 Offset: 0xBC3B20 VA: 0x180BC5120
	public void OnDisable() { }

	// RVA: 0xBC5D70 Offset: 0xBC4770 VA: 0x180BC5D70
	public void OnEnable() { }

	// RVA: 0xBC5F40 Offset: 0xBC4940 VA: 0x180BC5F40
	public void Start() { }

	// RVA: 0xBC6050 Offset: 0xBC4A50 VA: 0x180BC6050
	public void Update() { }

	// RVA: 0xBC4F20 Offset: 0xBC3920 VA: 0x180BC4F20
	protected void FindSimulator() { }

	// RVA: 0xBC4C10 Offset: 0xBC3610 VA: 0x180BC4C10
	protected void AddObstacle(Vector3[] vertices, float height) { }

	// RVA: 0xBC4A50 Offset: 0xBC3450 VA: 0x180BC4A50
	private void AddObstacleInternal(Vector3[] vertices, float height) { }

	// RVA: 0xBC6290 Offset: 0xBC4C90 VA: 0x180BC6290
	private void WindCorrectly(Vector3[] vertices) { }

	// RVA: 0xBC6620 Offset: 0xBC5020 VA: 0x180BC6620
	protected void .ctor() { }
}
