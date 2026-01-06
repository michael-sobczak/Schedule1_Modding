public class RaycastModifier : MonoModifier // TypeDefIndex: 13294
{
	// Fields
	public bool useRaycasting; // 0x30
	public LayerMask mask; // 0x34
	[Tooltip("Checks around the line between two points, not just the exact line.
Make sure the ground is either too far below or is not inside the mask since otherwise the raycast might always hit the ground.")]
	public bool thickRaycast; // 0x38
	[Tooltip("Distance from the ray which will be checked for colliders")]
	public float thickRaycastRadius; // 0x3C
	[Tooltip("Check for intersections with 2D colliders instead of 3D colliders.")]
	public bool use2DPhysics; // 0x40
	[Tooltip("Offset from the original positions to perform the raycast.
Can be useful to avoid the raycast intersecting the ground or similar things you do not want to it intersect")]
	public Vector3 raycastOffset; // 0x44
	[Tooltip("Use raycasting on the graphs. Only currently works with GridGraph and NavmeshGraph and RecastGraph. This is a pro version feature.")]
	public bool useGraphRaycasting; // 0x50
	[Tooltip("When using the high quality mode the script will try harder to find a shorter path. This is significantly slower than the greedy low quality approach.")]
	public RaycastModifier.Quality quality; // 0x54
	private static readonly int[] iterationsByQuality; // 0x0
	private static List<Vector3> buffer; // 0x8
	private static float[] DPCosts; // 0x10
	private static int[] DPParents; // 0x18
	private RaycastModifier.Filter cachedFilter; // 0x58
	private NNConstraint cachedNNConstraint; // 0x60

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0xB648E0 Offset: 0xB632E0 VA: 0x180B648E0 Slot: 15
	public override int get_Order() { }

	// RVA: 0xB73700 Offset: 0xB72100 VA: 0x180B73700 Slot: 17
	public override void Apply(Path p) { }

	// RVA: 0xB730E0 Offset: 0xB71AE0 VA: 0x180B730E0
	private List<Vector3> ApplyGreedy(Path p, List<Vector3> points, Func<GraphNode, bool> filter, NNConstraint nnConstraint) { }

	// RVA: 0xB72720 Offset: 0xB71120 VA: 0x180B72720
	private List<Vector3> ApplyDP(Path p, List<Vector3> points, Func<GraphNode, bool> filter, NNConstraint nnConstraint) { }

	// RVA: 0xB73C00 Offset: 0xB72600 VA: 0x180B73C00
	protected bool ValidateLine(GraphNode n1, GraphNode n2, Vector3 v1, Vector3 v2, Func<GraphNode, bool> filter, NNConstraint nnConstraint) { }

	// RVA: 0xB747A0 Offset: 0xB731A0 VA: 0x180B747A0
	public void .ctor() { }

	// RVA: 0xB74620 Offset: 0xB73020 VA: 0x180B74620
	private static void .cctor() { }
}
