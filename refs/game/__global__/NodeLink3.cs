public class NodeLink3 : GraphModifier // TypeDefIndex: 13181
{
	// Fields
	protected static Dictionary<GraphNode, NodeLink3> reference; // 0x0
	public Transform end; // 0x40
	public float costFactor; // 0x48
	public bool oneWay; // 0x4C
	private NodeLink3Node startNode; // 0x50
	private NodeLink3Node endNode; // 0x58
	private MeshNode connectedNode1; // 0x60
	private MeshNode connectedNode2; // 0x68
	private Vector3 clamped1; // 0x70
	private Vector3 clamped2; // 0x7C
	private bool postScanCalled; // 0x88
	private static readonly Color GizmosColor; // 0x8
	private static readonly Color GizmosColorSelected; // 0x18

	// Properties
	public Transform StartTransform { get; }
	public Transform EndTransform { get; }
	public GraphNode StartNode { get; }
	public GraphNode EndNode { get; }

	// Methods

	// RVA: 0xB230F0 Offset: 0xB21AF0 VA: 0x180B230F0
	public static NodeLink3 GetNodeLink(GraphNode node) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0
	public Transform get_StartTransform() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Transform get_EndTransform() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public GraphNode get_StartNode() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public GraphNode get_EndNode() { }

	// RVA: 0xB24230 Offset: 0xB22C30 VA: 0x180B24230 Slot: 13
	public override void OnPostScan() { }

	// RVA: 0xB23180 Offset: 0xB21B80 VA: 0x180B23180
	public void InternalOnPostScan() { }

	// RVA: 0xB24130 Offset: 0xB22B30 VA: 0x180B24130 Slot: 18
	public override void OnGraphsPostUpdate() { }

	// RVA: 0xB23FD0 Offset: 0xB229D0 VA: 0x180B23FD0 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0xB23690 Offset: 0xB22090 VA: 0x180B23690 Slot: 11
	protected override void OnDisable() { }

	// RVA: 0xB21180 Offset: 0xB1FB80 VA: 0x180B21180
	private void RemoveConnections(GraphNode node) { }

	[ContextMenu("Recalculate neighbours")]
	// RVA: 0xB23090 Offset: 0xB21A90 VA: 0x180B23090
	private void ContextApplyForce() { }

	// RVA: 0xB21960 Offset: 0xB20360 VA: 0x180B21960
	public void Apply(bool forceNewCheck) { }

	// RVA: 0xB23870 Offset: 0xB22270 VA: 0x180B23870 Slot: 19
	public virtual void OnDrawGizmosSelected() { }

	// RVA: 0xB23880 Offset: 0xB22280 VA: 0x180B23880
	public void OnDrawGizmos() { }

	// RVA: 0xB23890 Offset: 0xB22290 VA: 0x180B23890
	public void OnDrawGizmos(bool selected) { }

	// RVA: 0xB24490 Offset: 0xB22E90 VA: 0x180B24490
	public void .ctor() { }

	// RVA: 0xB243D0 Offset: 0xB22DD0 VA: 0x180B243D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xB243B0 Offset: 0xB22DB0 VA: 0x180B243B0
	private bool <OnPostScan>b__20_0(bool force) { }
}
