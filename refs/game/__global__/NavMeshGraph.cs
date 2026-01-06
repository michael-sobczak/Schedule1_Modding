public class NavMeshGraph : NavmeshBase, IUpdatableGraph // TypeDefIndex: 13244
{
	// Fields
	[JsonMember]
	public Mesh sourceMesh; // 0x130
	[JsonMember]
	public Vector3 offset; // 0x138
	[JsonMember]
	public Vector3 rotation; // 0x144
	[JsonMember]
	public float scale; // 0x150
	[JsonMember]
	public bool recalculateNormals; // 0x154
	[JsonMember]
	private Vector3 cachedSourceMeshBoundsMin; // 0x158

	// Properties
	protected override bool RecalculateNormals { get; }
	public override float TileWorldSizeX { get; }
	public override float TileWorldSizeZ { get; }
	protected override float MaxTileConnectionEdgeDistance { get; }

	// Methods

	// RVA: 0x513130 Offset: 0x511B30 VA: 0x180513130 Slot: 40
	protected override bool get_RecalculateNormals() { }

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840 Slot: 37
	public override float get_TileWorldSizeX() { }

	// RVA: 0x537070 Offset: 0x535A70 VA: 0x180537070 Slot: 38
	public override float get_TileWorldSizeZ() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 39
	protected override float get_MaxTileConnectionEdgeDistance() { }

	// RVA: 0xB52590 Offset: 0xB50F90 VA: 0x180B52590 Slot: 41
	public override GraphTransform CalculateTransform() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 45
	private GraphUpdateThreading Pathfinding.IUpdatableGraph.CanUpdateAsync(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 43
	private void Pathfinding.IUpdatableGraph.UpdateAreaInit(GraphUpdateObject o) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 44
	private void Pathfinding.IUpdatableGraph.UpdateAreaPost(GraphUpdateObject o) { }

	// RVA: 0xB52A90 Offset: 0xB51490 VA: 0x180B52A90 Slot: 42
	private void Pathfinding.IUpdatableGraph.UpdateArea(GraphUpdateObject o) { }

	// RVA: 0xB52B30 Offset: 0xB51530 VA: 0x180B52B30
	public static void UpdateArea(GraphUpdateObject o, INavmeshHolder graph) { }

	[IteratorStateMachine(typeof(NavMeshGraph.<ScanInternal>d__20))]
	// RVA: 0xB52AB0 Offset: 0xB514B0 VA: 0x180B52AB0 Slot: 20
	protected override IEnumerable<Progress> ScanInternal() { }

	// RVA: 0xB52950 Offset: 0xB51350 VA: 0x180B52950 Slot: 24
	protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB53070 Offset: 0xB51A70 VA: 0x180B53070
	public void .ctor() { }
}
