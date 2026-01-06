public class NavmeshAdd : NavmeshClipper // TypeDefIndex: 13300
{
	// Fields
	public NavmeshAdd.MeshType type; // 0x30
	public Mesh mesh; // 0x38
	private Vector3[] verts; // 0x40
	private int[] tris; // 0x48
	public Vector2 rectangleSize; // 0x50
	public float meshScale; // 0x58
	public Vector3 center; // 0x5C
	[FormerlySerializedAs("useRotation")]
	public bool useRotationAndScale; // 0x68
	[Tooltip("Distance between positions to require an update of the navmesh
A smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
	public float updateDistance; // 0x6C
	[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
	public float updateRotationDistance; // 0x70
	protected Transform tr; // 0x78
	private Vector3 lastPosition; // 0x80
	private Quaternion lastRotation; // 0x8C
	public static readonly Color GizmoColor; // 0x0

	// Properties
	public Vector3 Center { get; }

	// Methods

	// RVA: 0xB69070 Offset: 0xB67A70 VA: 0x180B69070 Slot: 14
	public override bool RequiresUpdate() { }

	// RVA: 0xB684F0 Offset: 0xB66EF0 VA: 0x180B684F0 Slot: 15
	public override void ForceUpdate() { }

	// RVA: 0xB68460 Offset: 0xB66E60 VA: 0x180B68460 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB68D00 Offset: 0xB67700 VA: 0x180B68D00 Slot: 12
	internal override void NotifyUpdated() { }

	// RVA: 0xB692A0 Offset: 0xB67CA0 VA: 0x180B692A0
	public Vector3 get_Center() { }

	[ContextMenu("Rebuild Mesh")]
	// RVA: 0xB68D70 Offset: 0xB67770 VA: 0x180B68D70
	public void RebuildMesh() { }

	// RVA: 0xB68510 Offset: 0xB66F10 VA: 0x180B68510 Slot: 13
	public override Rect GetBounds(GraphTransform inverseTransform) { }

	// RVA: 0xB687D0 Offset: 0xB671D0 VA: 0x180B687D0
	public void GetMesh(ref Int3[] vbuffer, out int[] tbuffer, GraphTransform inverseTransform) { }

	// RVA: 0xB69220 Offset: 0xB67C20 VA: 0x180B69220
	public void .ctor() { }

	// RVA: 0xB691E0 Offset: 0xB67BE0 VA: 0x180B691E0
	private static void .cctor() { }
}
