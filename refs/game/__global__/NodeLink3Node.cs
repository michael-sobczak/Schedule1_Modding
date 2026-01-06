public class NodeLink3Node : PointNode // TypeDefIndex: 13180
{
	// Fields
	public NodeLink3 link; // 0x40
	public Vector3 portalA; // 0x48
	public Vector3 portalB; // 0x54

	// Methods

	// RVA: 0xB21950 Offset: 0xB20350 VA: 0x180B21950
	public void .ctor(AstarPath active) { }

	// RVA: 0xB21750 Offset: 0xB20150 VA: 0x180B21750 Slot: 12
	public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards) { }

	// RVA: 0xB21580 Offset: 0xB1FF80 VA: 0x180B21580
	public GraphNode GetOther(GraphNode a) { }

	// RVA: 0xB21530 Offset: 0xB1FF30 VA: 0x180B21530
	private GraphNode GetOtherInternal(GraphNode a) { }
}
