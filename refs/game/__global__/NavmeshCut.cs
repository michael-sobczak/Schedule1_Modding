public class NavmeshCut : NavmeshClipper // TypeDefIndex: 13303
{
	// Fields
	[Tooltip("Shape of the cut")]
	public NavmeshCut.MeshType type; // 0x30
	[Tooltip("The contour(s) of the mesh will be extracted. This mesh should only be a 2D surface, not a volume (see documentation).")]
	public Mesh mesh; // 0x38
	public Vector2 rectangleSize; // 0x40
	public float circleRadius; // 0x48
	public int circleResolution; // 0x4C
	public float height; // 0x50
	[Tooltip("Scale of the custom mesh")]
	public float meshScale; // 0x54
	public Vector3 center; // 0x58
	[Tooltip("Distance between positions to require an update of the navmesh
A smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
	public float updateDistance; // 0x64
	[Tooltip("Only makes a split in the navmesh, but does not remove the geometry to make a hole")]
	public bool isDual; // 0x68
	public bool cutsAddedGeom; // 0x69
	[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
	public float updateRotationDistance; // 0x6C
	[Tooltip("Includes rotation in calculations. This is slower since a lot more matrix multiplications are needed but gives more flexibility.")]
	[FormerlySerializedAs("useRotation")]
	public bool useRotationAndScale; // 0x70
	private Vector3[][] contours; // 0x78
	protected Transform tr; // 0x80
	private Mesh lastMesh; // 0x88
	private Vector3 lastPosition; // 0x90
	private Quaternion lastRotation; // 0x9C
	private static readonly Dictionary<Int2, int> edges; // 0x0
	private static readonly Dictionary<int, int> pointers; // 0x8
	public static readonly Color GizmoColor; // 0x10

	// Methods

	// RVA: 0xB69B30 Offset: 0xB68530 VA: 0x180B69B30 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB6B920 Offset: 0xB6A320 VA: 0x180B6B920 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0xB6A400 Offset: 0xB68E00 VA: 0x180B6A400 Slot: 15
	public override void ForceUpdate() { }

	// RVA: 0xB6BAD0 Offset: 0xB6A4D0 VA: 0x180B6BAD0 Slot: 14
	public override bool RequiresUpdate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void UsedForCut() { }

	// RVA: 0xB6AF40 Offset: 0xB69940 VA: 0x180B6AF40 Slot: 12
	internal override void NotifyUpdated() { }

	// RVA: 0xB69BC0 Offset: 0xB685C0 VA: 0x180B69BC0
	private void CalculateMeshContour() { }

	// RVA: 0xB6A420 Offset: 0xB68E20 VA: 0x180B6A420 Slot: 13
	public override Rect GetBounds(GraphTransform inverseTransform) { }

	// RVA: 0xB6A700 Offset: 0xB69100 VA: 0x180B6A700
	public void GetContour(List<List<Vector3>> buffer) { }

	// RVA: 0xB6BC50 Offset: 0xB6A650 VA: 0x180B6BC50
	private void TransformBuffer(List<Vector3> buffer, bool reverse) { }

	// RVA: 0xB6B6C0 Offset: 0xB6A0C0 VA: 0x180B6B6C0
	public void OnDrawGizmos() { }

	// RVA: 0xB6AE50 Offset: 0xB69850 VA: 0x180B6AE50
	internal float GetY(GraphTransform transform) { }

	// RVA: 0xB6AFB0 Offset: 0xB699B0 VA: 0x180B6AFB0
	public void OnDrawGizmosSelected() { }

	// RVA: 0xB6C050 Offset: 0xB6AA50 VA: 0x180B6C050
	public void .ctor() { }

	// RVA: 0xB6BF40 Offset: 0xB6A940 VA: 0x180B6BF40
	private static void .cctor() { }
}
