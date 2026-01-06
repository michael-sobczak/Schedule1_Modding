public class StartEndModifier : PathModifier // TypeDefIndex: 13298
{
	// Fields
	public bool addPoints; // 0x18
	public StartEndModifier.Exactness exactStartPoint; // 0x1C
	public StartEndModifier.Exactness exactEndPoint; // 0x20
	public Func<Vector3> adjustStartPoint; // 0x28
	public bool useRaycasting; // 0x30
	public LayerMask mask; // 0x34
	public bool useGraphRaycasting; // 0x38
	private List<GraphNode> connectionBuffer; // 0x40
	private Action<GraphNode> connectionBufferAddDelegate; // 0x48

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public override int get_Order() { }

	// RVA: 0xB791F0 Offset: 0xB77BF0 VA: 0x180B791F0 Slot: 9
	public override void Apply(Path _p) { }

	// RVA: 0xB796F0 Offset: 0xB780F0 VA: 0x180B796F0
	private Vector3 Snap(ABPath path, StartEndModifier.Exactness mode, bool start, out bool forceAddPoint, out int closestConnectionIndex) { }

	// RVA: 0xB794B0 Offset: 0xB77EB0 VA: 0x180B794B0
	protected Vector3 GetClampedPoint(Vector3 from, Vector3 to, GraphNode hint) { }

	// RVA: 0xB79DE0 Offset: 0xB787E0 VA: 0x180B79DE0
	public void .ctor() { }
}
