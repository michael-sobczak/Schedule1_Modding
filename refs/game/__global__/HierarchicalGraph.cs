public class HierarchicalGraph // TypeDefIndex: 13174
{
	// Fields
	private const int Tiling = 16;
	private const int MaxChildrenPerNode = 256;
	private const int MinChildrenPerNode = 128;
	private List<GraphNode>[] children; // 0x10
	private List<int>[] connections; // 0x18
	private int[] areas; // 0x20
	private byte[] dirty; // 0x28
	[CompilerGenerated]
	private int <version>k__BackingField; // 0x30
	public Action onConnectedComponentsChanged; // 0x38
	private Action<GraphNode> connectionCallback; // 0x40
	private Queue<GraphNode> temporaryQueue; // 0x48
	private List<GraphNode> currentChildren; // 0x50
	private List<int> currentConnections; // 0x58
	private int currentHierarchicalNodeIndex; // 0x60
	private Stack<int> temporaryStack; // 0x68
	private int numDirtyNodes; // 0x70
	private GraphNode[] dirtyNodes; // 0x78
	private Stack<int> freeNodeIndices; // 0x80
	private int gizmoVersion; // 0x88
	[CompilerGenerated]
	private int <NumConnectedComponents>k__BackingField; // 0x8C

	// Properties
	public int version { get; set; }
	public int NumConnectedComponents { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_version() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_version(int value) { }

	// RVA: 0xB1B280 Offset: 0xB19C80 VA: 0x180B1B280
	public void .ctor() { }

	// RVA: 0xB1A750 Offset: 0xB19150 VA: 0x180B1A750
	private void Grow() { }

	// RVA: 0xB1A6E0 Offset: 0xB190E0 VA: 0x180B1A6E0
	private int GetHierarchicalNodeIndex() { }

	// RVA: 0xB1AAB0 Offset: 0xB194B0 VA: 0x180B1AAB0
	internal void OnCreatedNode(GraphNode node) { }

	// RVA: 0xB19FF0 Offset: 0xB189F0 VA: 0x180B19FF0
	public void AddDirtyNode(GraphNode node) { }

	[CompilerGenerated]
	// RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0
	public int get_NumConnectedComponents() { }

	[CompilerGenerated]
	// RVA: 0xB1B4A0 Offset: 0xB19EA0 VA: 0x180B1B4A0
	private void set_NumConnectedComponents(int value) { }

	// RVA: 0xB1A6B0 Offset: 0xB190B0 VA: 0x180B1A6B0
	public uint GetConnectedComponent(int hierarchicalNodeIndex) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void RemoveHierarchicalNode(int hierarchicalNode, bool removeAdjacentSmallNodes) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void RecalculateIfNecessary() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void RecalculateAll() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void FloodFill() { }

	// RVA: 0xB1A3F0 Offset: 0xB18DF0 VA: 0x180B1A3F0
	private void FindHierarchicalNodeChildren(int hierarchicalNode, GraphNode startNode) { }

	// RVA: 0xB1ABB0 Offset: 0xB195B0 VA: 0x180B1ABB0
	public void OnDrawGizmos(RetainedGizmos gizmos) { }

	[CompilerGenerated]
	// RVA: 0xB1B140 Offset: 0xB19B40 VA: 0x180B1B140
	private void <.ctor>b__22_0(GraphNode neighbour) { }

	[CompilerGenerated]
	// RVA: 0xB1B130 Offset: 0xB19B30 VA: 0x180B1B130
	private void <RecalculateAll>b__34_0(GraphNode node) { }
}
