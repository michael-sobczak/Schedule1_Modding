public class PointNode : GraphNode // TypeDefIndex: 13247
{
	// Fields
	public Connection[] connections; // 0x28
	public Connection[] looseConnections; // 0x30
	public GameObject gameObject; // 0x38

	// Methods

	// RVA: 0xB3F150 Offset: 0xB3DB50 VA: 0x180B3F150
	public void SetPosition(Int3 value) { }

	// RVA: 0xB502E0 Offset: 0xB4ECE0 VA: 0x180B502E0
	public void .ctor(AstarPath astar) { }

	// RVA: 0xB564E0 Offset: 0xB54EE0 VA: 0x180B564E0 Slot: 16
	public override Vector3 ClosestPointOnNode(Vector3 p) { }

	// RVA: 0xB1CE30 Offset: 0xB1B830 VA: 0x180B1CE30 Slot: 5
	public override void GetConnections(Action<GraphNode> action) { }

	// RVA: 0xB563C0 Offset: 0xB54DC0 VA: 0x180B563C0 Slot: 10
	public override void ClearConnections(bool alsoReverse) { }

	// RVA: 0xB1D390 Offset: 0xB1BD90 VA: 0x180B1D390 Slot: 4
	public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: 0xB56530 Offset: 0xB54F30 VA: 0x180B56530 Slot: 11
	public override bool ContainsConnection(GraphNode node) { }

	// RVA: 0xB55C00 Offset: 0xB54600 VA: 0x180B55C00 Slot: 6
	public override void AddConnection(GraphNode node, uint cost) { }

	// RVA: 0xB55FE0 Offset: 0xB549E0 VA: 0x180B55FE0 Slot: 7
	public override void AddLooseConnection(GraphNode node, uint cost) { }

	// RVA: 0xB56A20 Offset: 0xB55420 VA: 0x180B56A20 Slot: 8
	public override void RemoveConnection(GraphNode node) { }

	// RVA: 0xB56C50 Offset: 0xB55650 VA: 0x180B56C50 Slot: 9
	public override void RemoveLooseConnection(GraphNode node) { }

	// RVA: 0xB56810 Offset: 0xB55210 VA: 0x180B56810 Slot: 13
	public override void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False) { }

	// RVA: 0xB56780 Offset: 0xB55180 VA: 0x180B56780 Slot: 17
	public override int GetGizmoHashCode() { }

	// RVA: 0xB56E80 Offset: 0xB55880 VA: 0x180B56E80 Slot: 18
	public override void SerializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB56580 Offset: 0xB54F80 VA: 0x180B56580 Slot: 19
	public override void DeserializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB56ED0 Offset: 0xB558D0 VA: 0x180B56ED0 Slot: 20
	public override void SerializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0xB565D0 Offset: 0xB54FD0 VA: 0x180B565D0 Slot: 21
	public override void DeserializeReferences(GraphSerializationContext ctx) { }
}
