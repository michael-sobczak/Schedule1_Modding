public class PathHandler // TypeDefIndex: 13205
{
	// Fields
	private ushort pathID; // 0x10
	public readonly int threadID; // 0x14
	public readonly int totalThreadCount; // 0x18
	public readonly BinaryHeap heap; // 0x20
	public PathNode[] nodes; // 0x28
	public readonly StringBuilder DebugStringBuilder; // 0x30

	// Properties
	public ushort PathID { get; }

	// Methods

	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public ushort get_PathID() { }

	// RVA: 0xB25A00 Offset: 0xB24400 VA: 0x180B25A00
	public void .ctor(int threadID, int totalThreadCount) { }

	// RVA: 0xB257F0 Offset: 0xB241F0 VA: 0x180B257F0
	public void InitializeForPath(Path p) { }

	// RVA: 0xB25630 Offset: 0xB24030 VA: 0x180B25630
	public void DestroyNode(GraphNode node) { }

	// RVA: 0xB25820 Offset: 0xB24220 VA: 0x180B25820
	public void InitializeNode(GraphNode node) { }

	// RVA: 0xB25690 Offset: 0xB24090 VA: 0x180B25690
	public PathNode GetPathNode(int nodeIndex) { }

	// RVA: 0xB256C0 Offset: 0xB240C0 VA: 0x180B256C0
	public PathNode GetPathNode(GraphNode node) { }

	// RVA: 0xB255C0 Offset: 0xB23FC0 VA: 0x180B255C0
	public void ClearPathIDs() { }
}
