public class NodeLink2 : GraphModifier // TypeDefIndex: 13179
{
	// Fields
	protected static Dictionary<GraphNode, NodeLink2> reference; // 0x0
	public Transform end; // 0x40
	public float costFactor; // 0x48
	public bool oneWay; // 0x4C
	[CompilerGenerated]
	private PointNode <startNode>k__BackingField; // 0x50
	[CompilerGenerated]
	private PointNode <endNode>k__BackingField; // 0x58
	private GraphNode connectedNode1; // 0x60
	private GraphNode connectedNode2; // 0x68
	private Vector3 clamped1; // 0x70
	private Vector3 clamped2; // 0x7C
	private bool postScanCalled; // 0x88
	private static readonly Color GizmosColor; // 0x8
	private static readonly Color GizmosColorSelected; // 0x18

	// Properties
	public Transform StartTransform { get; }
	public Transform EndTransform { get; }
	public PointNode startNode { get; set; }
	public PointNode endNode { get; set; }
	[Obsolete("Use startNode instead (lowercase s)")]
	public GraphNode StartNode { get; }
	[Obsolete("Use endNode instead (lowercase e)")]
	public GraphNode EndNode { get; }

	// Methods

	// RVA: 0xB1FE00 Offset: 0xB1E800 VA: 0x180B1FE00
	public static NodeLink2 GetNodeLink(GraphNode node) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0
	public Transform get_StartTransform() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Transform get_EndTransform() { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public PointNode get_startNode() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_startNode(PointNode value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public PointNode get_endNode() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_endNode(PointNode value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public GraphNode get_StartNode() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public GraphNode get_EndNode() { }

	// RVA: 0xB21170 Offset: 0xB1FB70 VA: 0x180B21170 Slot: 13
	public override void OnPostScan() { }

	// RVA: 0xB1FE90 Offset: 0xB1E890 VA: 0x180B1FE90
	public void InternalOnPostScan() { }

	// RVA: 0xB21070 Offset: 0xB1FA70 VA: 0x180B21070 Slot: 18
	public override void OnGraphsPostUpdate() { }

	// RVA: 0xB20E70 Offset: 0xB1F870 VA: 0x180B20E70 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0xB20530 Offset: 0xB1EF30 VA: 0x180B20530 Slot: 11
	protected override void OnDisable() { }

	// RVA: 0xB21180 Offset: 0xB1FB80 VA: 0x180B21180
	private void RemoveConnections(GraphNode node) { }

	[ContextMenu("Recalculate neighbours")]
	// RVA: 0xB1F830 Offset: 0xB1E230 VA: 0x180B1F830
	private void ContextApplyForce() { }

	// RVA: 0xB1EC00 Offset: 0xB1D600 VA: 0x180B1EC00
	public void Apply(bool forceNewCheck) { }

	// RVA: 0xB20710 Offset: 0xB1F110 VA: 0x180B20710 Slot: 19
	public virtual void OnDrawGizmosSelected() { }

	// RVA: 0xB20E60 Offset: 0xB1F860 VA: 0x180B20E60
	public void OnDrawGizmos() { }

	// RVA: 0xB20720 Offset: 0xB1F120 VA: 0x180B20720
	public void OnDrawGizmos(bool selected) { }

	// RVA: 0xB211B0 Offset: 0xB1FBB0 VA: 0x180B211B0
	internal static void SerializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0xB1F890 Offset: 0xB1E290 VA: 0x180B1F890
	internal static void DeserializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0xB214E0 Offset: 0xB1FEE0 VA: 0x180B214E0
	public void .ctor() { }

	// RVA: 0xB21420 Offset: 0xB1FE20 VA: 0x180B21420
	private static void .cctor() { }
}
