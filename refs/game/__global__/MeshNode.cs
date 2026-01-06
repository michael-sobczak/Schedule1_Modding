public abstract class MeshNode : GraphNode // TypeDefIndex: 13198
{
	// Fields
	public Connection[] connections; // 0x28

	// Methods

	// RVA: 0xB17420 Offset: 0xB15E20 VA: 0x180B17420
	protected void .ctor(AstarPath astar) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Int3 GetVertex(int i);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetVertexCount();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Vector3 ClosestPointOnNodeXZ(Vector3 p);

	// RVA: 0xB1C9A0 Offset: 0xB1B3A0 VA: 0x180B1C9A0 Slot: 10
	public override void ClearConnections(bool alsoReverse) { }

	// RVA: 0xB1CE30 Offset: 0xB1B830 VA: 0x180B1CE30 Slot: 5
	public override void GetConnections(Action<GraphNode> action) { }

	// RVA: 0xB1CAE0 Offset: 0xB1B4E0 VA: 0x180B1CAE0 Slot: 11
	public override bool ContainsConnection(GraphNode node) { }

	// RVA: 0xB1D390 Offset: 0xB1BD90 VA: 0x180B1D390 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB1C980 Offset: 0xB1B380 VA: 0x180B1C980 Slot: 6
	public override void AddConnection(GraphNode node, uint cost) { }

	// RVA: 0xB1C660 Offset: 0xB1B060 VA: 0x180B1C660
	public void AddConnection(GraphNode node, uint cost, byte shapeEdge) { }

	// RVA: 0xB1CFB0 Offset: 0xB1B9B0 VA: 0x180B1CFB0 Slot: 8
	public override void RemoveConnection(GraphNode node) { }

	// RVA: 0xB1CB40 Offset: 0xB1B540 VA: 0x180B1CB40 Slot: 25
	public virtual bool ContainsPoint(Int3 point) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool ContainsPoint(Vector3 point);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool ContainsPointInGraphSpace(Int3 point);

	// RVA: 0xB1CED0 Offset: 0xB1B8D0 VA: 0x180B1CED0 Slot: 17
	public override int GetGizmoHashCode() { }

	// RVA: 0xB1D230 Offset: 0xB1BC30 VA: 0x180B1D230 Slot: 20
	public override void SerializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0xB1CBC0 Offset: 0xB1B5C0 VA: 0x180B1CBC0 Slot: 21
	public override void DeserializeReferences(GraphSerializationContext ctx) { }
}
