public abstract class GridNodeBase : GraphNode // TypeDefIndex: 13246
{
	// Fields
	private const int GridFlagsWalkableErosionOffset = 8;
	private const int GridFlagsWalkableErosionMask = 256;
	private const int GridFlagsWalkableTmpOffset = 9;
	private const int GridFlagsWalkableTmpMask = 512;
	protected const int NodeInGridIndexLayerOffset = 24;
	protected const int NodeInGridIndexMask = 16777215;
	protected int nodeInGridIndex; // 0x28
	protected ushort gridFlags; // 0x2C
	public Connection[] connections; // 0x30

	// Properties
	public int NodeInGridIndex { get; set; }
	public int XCoordinateInGrid { get; }
	public int ZCoordinateInGrid { get; }
	public bool WalkableErosion { get; set; }
	public bool TmpWalkable { get; set; }
	public abstract bool HasConnectionsToAllEightNeighbours { get; }

	// Methods

	// RVA: 0xB502E0 Offset: 0xB4ECE0 VA: 0x180B502E0
	protected void .ctor(AstarPath astar) { }

	// RVA: 0xB502F0 Offset: 0xB4ECF0 VA: 0x180B502F0
	public int get_NodeInGridIndex() { }

	// RVA: 0xB504C0 Offset: 0xB4EEC0 VA: 0x180B504C0
	public void set_NodeInGridIndex(int value) { }

	// RVA: 0xB50320 Offset: 0xB4ED20 VA: 0x180B50320
	public int get_XCoordinateInGrid() { }

	// RVA: 0xB503F0 Offset: 0xB4EDF0 VA: 0x180B503F0
	public int get_ZCoordinateInGrid() { }

	// RVA: 0xB50310 Offset: 0xB4ED10 VA: 0x180B50310
	public bool get_WalkableErosion() { }

	// RVA: 0xB50510 Offset: 0xB4EF10 VA: 0x180B50510
	public void set_WalkableErosion(bool value) { }

	// RVA: 0xB50300 Offset: 0xB4ED00 VA: 0x180B50300
	public bool get_TmpWalkable() { }

	// RVA: 0xB504D0 Offset: 0xB4EED0 VA: 0x180B504D0
	public void set_TmpWalkable(bool value) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_HasConnectionsToAllEightNeighbours();

	// RVA: 0xB4FFA0 Offset: 0xB4E9A0 VA: 0x180B4FFA0 Slot: 14
	public override float SurfaceArea() { }

	// RVA: 0xB4FA50 Offset: 0xB4E450 VA: 0x180B4FA50 Slot: 15
	public override Vector3 RandomPointOnSurface() { }

	// RVA: 0xB4F5B0 Offset: 0xB4DFB0 VA: 0x180B4F5B0
	public Vector2 NormalizePoint(Vector3 worldPoint) { }

	// RVA: 0xB50060 Offset: 0xB4EA60 VA: 0x180B50060
	public Vector3 UnNormalizePoint(Vector2 normalizedPointOnSurface) { }

	// RVA: 0xB4F4E0 Offset: 0xB4DEE0 VA: 0x180B4F4E0 Slot: 17
	public override int GetGizmoHashCode() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract GridNodeBase GetNeighbourAlongDirection(int direction);

	// RVA: 0xB4F580 Offset: 0xB4DF80 VA: 0x180B4F580 Slot: 24
	public virtual bool HasConnectionInDirection(int direction) { }

	// RVA: 0xB4F190 Offset: 0xB4DB90 VA: 0x180B4F190 Slot: 11
	public override bool ContainsConnection(GraphNode node) { }

	// RVA: 0xB4F080 Offset: 0xB4DA80 VA: 0x180B4F080
	public void ClearCustomConnections(bool alsoReverse) { }

	// RVA: 0xB4F080 Offset: 0xB4DA80 VA: 0x180B4F080 Slot: 10
	public override void ClearConnections(bool alsoReverse) { }

	// RVA: 0xB4F440 Offset: 0xB4DE40 VA: 0x180B4F440 Slot: 5
	public override void GetConnections(Action<GraphNode> action) { }

	// RVA: 0xB501F0 Offset: 0xB4EBF0 VA: 0x180B501F0 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB4F850 Offset: 0xB4E250 VA: 0x180B4F850 Slot: 13
	public override void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False) { }

	// RVA: 0xB4EDF0 Offset: 0xB4D7F0 VA: 0x180B4EDF0 Slot: 6
	public override void AddConnection(GraphNode node, uint cost) { }

	// RVA: 0xB4FC40 Offset: 0xB4E640 VA: 0x180B4FC40 Slot: 8
	public override void RemoveConnection(GraphNode node) { }

	// RVA: 0xB4FE70 Offset: 0xB4E870 VA: 0x180B4FE70 Slot: 20
	public override void SerializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0xB4F230 Offset: 0xB4DC30 VA: 0x180B4F230 Slot: 21
	public override void DeserializeReferences(GraphSerializationContext ctx) { }
}
