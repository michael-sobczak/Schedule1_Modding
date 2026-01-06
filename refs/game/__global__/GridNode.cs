public class GridNode : GridNodeBase // TypeDefIndex: 13245
{
	// Fields
	private static GridGraph[] _gridGraphs; // 0x0
	private const int GridFlagsConnectionOffset = 0;
	private const int GridFlagsConnectionBit0 = 1;
	private const int GridFlagsConnectionMask = 255;
	private const int GridFlagsEdgeNodeOffset = 10;
	private const int GridFlagsEdgeNodeMask = 1024;

	// Properties
	internal ushort InternalGridFlags { get; set; }
	public override bool HasConnectionsToAllEightNeighbours { get; }
	public bool EdgeNode { get; set; }

	// Methods

	// RVA: 0xB502E0 Offset: 0xB4ECE0 VA: 0x180B502E0
	public void .ctor(AstarPath astar) { }

	// RVA: 0xB50DD0 Offset: 0xB4F7D0 VA: 0x180B50DD0
	public static GridGraph GetGridGraph(uint graphIndex) { }

	// RVA: 0xB51FA0 Offset: 0xB509A0 VA: 0x180B51FA0
	public static void SetGridGraph(int graphIndex, GridGraph graph) { }

	// RVA: 0xB50850 Offset: 0xB4F250 VA: 0x180B50850
	public static void ClearGridGraph(int graphIndex, GridGraph graph) { }

	// RVA: 0xB52530 Offset: 0xB50F30 VA: 0x180B52530
	internal ushort get_InternalGridFlags() { }

	// RVA: 0xB52580 Offset: 0xB50F80 VA: 0x180B52580
	internal void set_InternalGridFlags(ushort value) { }

	// RVA: 0xB52520 Offset: 0xB50F20 VA: 0x180B52520 Slot: 22
	public override bool get_HasConnectionsToAllEightNeighbours() { }

	// RVA: 0xB517E0 Offset: 0xB501E0 VA: 0x180B517E0 Slot: 24
	public override bool HasConnectionInDirection(int dir) { }

	[Obsolete("Use HasConnectionInDirection")]
	// RVA: 0xB1E150 Offset: 0xB1CB50 VA: 0x180B1E150
	public bool GetConnectionInternal(int dir) { }

	// RVA: 0xB51EE0 Offset: 0xB508E0 VA: 0x180B51EE0
	public void SetConnectionInternal(int dir, bool value) { }

	// RVA: 0xB51E40 Offset: 0xB50840 VA: 0x180B51E40
	public void SetAllConnectionInternal(int connections) { }

	// RVA: 0xB51D50 Offset: 0xB50750 VA: 0x180B51D50
	public void ResetConnectionsInternal() { }

	// RVA: 0xB52510 Offset: 0xB50F10 VA: 0x180B52510
	public bool get_EdgeNode() { }

	// RVA: 0xB52540 Offset: 0xB50F40 VA: 0x180B52540
	public void set_EdgeNode(bool value) { }

	// RVA: 0xB50E40 Offset: 0xB4F840 VA: 0x180B50E40 Slot: 23
	public override GridNodeBase GetNeighbourAlongDirection(int direction) { }

	// RVA: 0xB50610 Offset: 0xB4F010 VA: 0x180B50610 Slot: 10
	public override void ClearConnections(bool alsoReverse) { }

	// RVA: 0xB50BF0 Offset: 0xB4F5F0 VA: 0x180B50BF0 Slot: 5
	public override void GetConnections(Action<GraphNode> action) { }

	// RVA: 0xB50940 Offset: 0xB4F340 VA: 0x180B50940 Slot: 16
	public override Vector3 ClosestPointOnNode(Vector3 p) { }

	// RVA: 0xB50F30 Offset: 0xB4F930 VA: 0x180B50F30 Slot: 12
	public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards) { }

	// RVA: 0xB521E0 Offset: 0xB50BE0 VA: 0x180B521E0 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB517F0 Offset: 0xB501F0 VA: 0x180B517F0 Slot: 13
	public override void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False) { }

	// RVA: 0xB51DD0 Offset: 0xB507D0 VA: 0x180B51DD0 Slot: 18
	public override void SerializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB50B80 Offset: 0xB4F580 VA: 0x180B50B80 Slot: 19
	public override void DeserializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB50550 Offset: 0xB4EF50 VA: 0x180B50550 Slot: 6
	public override void AddConnection(GraphNode node, uint cost) { }

	// RVA: 0xB51B40 Offset: 0xB50540 VA: 0x180B51B40 Slot: 8
	public override void RemoveConnection(GraphNode node) { }

	// RVA: 0xB51BF0 Offset: 0xB505F0 VA: 0x180B51BF0
	protected void RemoveGridConnection(GridNode node) { }

	// RVA: 0xB524A0 Offset: 0xB50EA0 VA: 0x180B524A0
	private static void .cctor() { }
}
