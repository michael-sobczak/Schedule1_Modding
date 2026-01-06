public class GraphGizmoHelper : IAstarPooledObject, IDisposable // TypeDefIndex: 13410
{
	// Fields
	[CompilerGenerated]
	private RetainedGizmos.Hasher <hasher>k__BackingField; // 0x10
	private RetainedGizmos gizmos; // 0x28
	private PathHandler debugData; // 0x30
	private ushort debugPathID; // 0x38
	private GraphDebugMode debugMode; // 0x3C
	private bool showSearchTree; // 0x40
	private float debugFloor; // 0x44
	private float debugRoof; // 0x48
	[CompilerGenerated]
	private RetainedGizmos.Builder <builder>k__BackingField; // 0x50
	private Vector3 drawConnectionStart; // 0x58
	private Color drawConnectionColor; // 0x64
	private readonly Action<GraphNode> drawConnection; // 0x78

	// Properties
	public RetainedGizmos.Hasher hasher { get; set; }
	public RetainedGizmos.Builder builder { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public RetainedGizmos.Hasher get_hasher() { }

	[CompilerGenerated]
	// RVA: 0xBBD040 Offset: 0xBBBA40 VA: 0x180BBD040
	private void set_hasher(RetainedGizmos.Hasher value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public RetainedGizmos.Builder get_builder() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_builder(RetainedGizmos.Builder value) { }

	// RVA: 0xBBCFA0 Offset: 0xBBB9A0 VA: 0x180BBCFA0
	public void .ctor() { }

	// RVA: 0xBBC930 Offset: 0xBBB330 VA: 0x180BBC930
	public void Init(AstarPath active, RetainedGizmos.Hasher hasher, RetainedGizmos gizmos) { }

	// RVA: 0xBBCE40 Offset: 0xBBB840 VA: 0x180BBCE40 Slot: 4
	public void OnEnterPool() { }

	// RVA: 0xBBC130 Offset: 0xBBAB30 VA: 0x180BBC130
	public void DrawConnections(GraphNode node) { }

	// RVA: 0xBBC020 Offset: 0xBBAA20 VA: 0x180BBC020
	private void DrawConnection(GraphNode other) { }

	// RVA: 0xBBCA50 Offset: 0xBBB450 VA: 0x180BBCA50
	public Color NodeColor(GraphNode node) { }

	// RVA: 0xBBC8F0 Offset: 0xBBB2F0 VA: 0x180BBC8F0
	public static bool InSearchTree(GraphNode node, PathHandler handler, ushort pathID) { }

	// RVA: 0xBBC590 Offset: 0xBBAF90 VA: 0x180BBC590
	public void DrawWireTriangle(Vector3 a, Vector3 b, Vector3 c, Color color) { }

	// RVA: 0xBBC350 Offset: 0xBBAD50 VA: 0x180BBC350
	public void DrawTriangles(Vector3[] vertices, Color[] colors, int numTriangles) { }

	// RVA: 0xBBC6D0 Offset: 0xBBB0D0 VA: 0x180BBC6D0
	public void DrawWireTriangles(Vector3[] vertices, Color[] colors, int numTriangles) { }

	// RVA: 0xBBCEB0 Offset: 0xBBB8B0 VA: 0x180BBCEB0
	public void Submit() { }

	// RVA: 0xBBCF10 Offset: 0xBBB910 VA: 0x180BBCF10 Slot: 5
	private void System.IDisposable.Dispose() { }
}
