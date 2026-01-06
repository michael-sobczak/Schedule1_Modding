public class LevelGridNode : GridNodeBase // TypeDefIndex: 13235
{
	// Fields
	private static LayerGridGraph[] _gridGraphs; // 0x0
	public ulong gridConnections; // 0x38
	protected static LayerGridGraph[] gridGraphs; // 0x8
	public const int NoConnection = 255;
	public const int ConnectionMask = 255;
	private const int ConnectionStride = 8;
	public const int MaxLayerCount = 255;

	// Properties
	public override bool HasConnectionsToAllEightNeighbours { get; }
	public int LayerCoordinateInGrid { get; set; }

	// Methods

	// RVA: 0xB21950 Offset: 0xB20350 VA: 0x180B21950
	public void .ctor(AstarPath astar) { }

	// RVA: 0xB3E1D0 Offset: 0xB3CBD0 VA: 0x180B3E1D0
	public static LayerGridGraph GetGridGraph(uint graphIndex) { }

	// RVA: 0xB3EEE0 Offset: 0xB3D8E0 VA: 0x180B3EEE0
	public static void SetGridGraph(int graphIndex, LayerGridGraph graph) { }

	// RVA: 0xB3ED10 Offset: 0xB3D710 VA: 0x180B3ED10
	public void ResetAllGridConnections() { }

	// RVA: 0xB3E750 Offset: 0xB3D150 VA: 0x180B3E750
	public bool HasAnyGridConnections() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	public override bool get_HasConnectionsToAllEightNeighbours() { }

	// RVA: 0xB3F430 Offset: 0xB3DE30 VA: 0x180B3F430
	public int get_LayerCoordinateInGrid() { }

	// RVA: 0xB3F440 Offset: 0xB3DE40 VA: 0x180B3F440
	public void set_LayerCoordinateInGrid(int value) { }

	// RVA: 0xB3F150 Offset: 0xB3DB50 VA: 0x180B3F150
	public void SetPosition(Int3 position) { }

	// RVA: 0xB3E1B0 Offset: 0xB3CBB0 VA: 0x180B3E1B0 Slot: 17
	public override int GetGizmoHashCode() { }

	// RVA: 0xB3E240 Offset: 0xB3CC40 VA: 0x180B3E240 Slot: 23
	public override GridNodeBase GetNeighbourAlongDirection(int direction) { }

	// RVA: 0xB3D9F0 Offset: 0xB3C3F0 VA: 0x180B3D9F0 Slot: 10
	public override void ClearConnections(bool alsoReverse) { }

	// RVA: 0xB3DFF0 Offset: 0xB3C9F0 VA: 0x180B3DFF0 Slot: 5
	public override void GetConnections(Action<GraphNode> action) { }

	[Obsolete("Use HasConnectionInDirection instead")]
	// RVA: 0xB3DFD0 Offset: 0xB3C9D0 VA: 0x180B3DFD0
	public bool GetConnection(int i) { }

	// RVA: 0xB3DFD0 Offset: 0xB3C9D0 VA: 0x180B3DFD0 Slot: 24
	public override bool HasConnectionInDirection(int direction) { }

	// RVA: 0xB3EE20 Offset: 0xB3D820 VA: 0x180B3EE20
	public void SetConnectionValue(int dir, int value) { }

	// RVA: 0xB3DFB0 Offset: 0xB3C9B0 VA: 0x180B3DFB0
	public int GetConnectionValue(int dir) { }

	// RVA: 0xB3D930 Offset: 0xB3C330 VA: 0x180B3D930 Slot: 6
	public override void AddConnection(GraphNode node, uint cost) { }

	// RVA: 0xB3EAE0 Offset: 0xB3D4E0 VA: 0x180B3EAE0 Slot: 8
	public override void RemoveConnection(GraphNode node) { }

	// RVA: 0xB3EB90 Offset: 0xB3D590 VA: 0x180B3EB90
	protected void RemoveGridConnection(LevelGridNode node) { }

	// RVA: 0xB3E350 Offset: 0xB3CD50 VA: 0x180B3E350 Slot: 12
	public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards) { }

	// RVA: 0xB3F160 Offset: 0xB3DB60 VA: 0x180B3F160 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB3E760 Offset: 0xB3D160 VA: 0x180B3E760 Slot: 13
	public override void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False) { }

	// RVA: 0xB3DC10 Offset: 0xB3C610 VA: 0x180B3DC10 Slot: 16
	public override Vector3 ClosestPointOnNode(Vector3 p) { }

	// RVA: 0xB3ED90 Offset: 0xB3D790 VA: 0x180B3ED90 Slot: 18
	public override void SerializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB3DE60 Offset: 0xB3C860 VA: 0x180B3DE60 Slot: 19
	public override void DeserializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB3F3C0 Offset: 0xB3DDC0 VA: 0x180B3F3C0
	private static void .cctor() { }
}
