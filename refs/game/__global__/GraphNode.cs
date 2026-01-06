public abstract class GraphNode // TypeDefIndex: 13197
{
	// Fields
	private int nodeIndex; // 0x10
	protected uint flags; // 0x14
	private uint penalty; // 0x18
	private const int NodeIndexMask = 268435455;
	private const int DestroyedNodeIndex = 268435454;
	private const int TemporaryFlag1Mask = 268435456;
	private const int TemporaryFlag2Mask = 536870912;
	public Int3 position; // 0x1C
	private const int FlagsWalkableOffset = 0;
	private const uint FlagsWalkableMask = 1;
	private const int FlagsHierarchicalIndexOffset = 1;
	private const uint HierarchicalIndexMask = 262142;
	private const int HierarchicalDirtyOffset = 18;
	private const uint HierarchicalDirtyMask = 262144;
	private const int FlagsGraphOffset = 24;
	private const uint FlagsGraphMask = 4278190080;
	public const uint MaxHierarchicalNodeIndex = 131071;
	public const uint MaxGraphIndex = 255;
	private const int FlagsTagOffset = 19;
	private const uint FlagsTagMask = 16252928;

	// Properties
	public NavGraph Graph { get; }
	public bool Destroyed { get; }
	public int NodeIndex { get; set; }
	internal bool TemporaryFlag1 { get; set; }
	internal bool TemporaryFlag2 { get; set; }
	public uint Flags { get; set; }
	public uint Penalty { get; set; }
	public bool Walkable { get; set; }
	internal int HierarchicalNodeIndex { get; set; }
	internal bool IsHierarchicalNodeDirty { get; set; }
	public uint Area { get; }
	public uint GraphIndex { get; set; }
	public uint Tag { get; set; }

	// Methods

	// RVA: 0xB17570 Offset: 0xB15F70 VA: 0x180B17570
	public NavGraph get_Graph() { }

	// RVA: 0xB17420 Offset: 0xB15E20 VA: 0x180B17420
	protected void .ctor(AstarPath astar) { }

	// RVA: 0xB17040 Offset: 0xB15A40 VA: 0x180B17040
	public void Destroy() { }

	// RVA: 0xB17540 Offset: 0xB15F40 VA: 0x180B17540
	public bool get_Destroyed() { }

	// RVA: 0xB175B0 Offset: 0xB15FB0 VA: 0x180B175B0
	public int get_NodeIndex() { }

	// RVA: 0xB17670 Offset: 0xB16070 VA: 0x180B17670
	private void set_NodeIndex(int value) { }

	// RVA: 0xB175D0 Offset: 0xB15FD0 VA: 0x180B175D0
	internal bool get_TemporaryFlag1() { }

	// RVA: 0xB17730 Offset: 0xB16130 VA: 0x180B17730
	internal void set_TemporaryFlag1(bool value) { }

	// RVA: 0xB175E0 Offset: 0xB15FE0 VA: 0x180B175E0
	internal bool get_TemporaryFlag2() { }

	// RVA: 0xB17760 Offset: 0xB16160 VA: 0x180B17760
	internal void set_TemporaryFlag2(bool value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public uint get_Flags() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_Flags(uint value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public uint get_Penalty() { }

	// RVA: 0xB17680 Offset: 0xB16080 VA: 0x180B17680
	public void set_Penalty(uint value) { }

	// RVA: 0xB175F0 Offset: 0xB15FF0 VA: 0x180B175F0
	public bool get_Walkable() { }

	// RVA: 0xB17790 Offset: 0xB16190 VA: 0x180B17790
	public void set_Walkable(bool value) { }

	// RVA: 0xB17590 Offset: 0xB15F90 VA: 0x180B17590
	internal int get_HierarchicalNodeIndex() { }

	// RVA: 0xB17620 Offset: 0xB16020 VA: 0x180B17620
	internal void set_HierarchicalNodeIndex(int value) { }

	// RVA: 0xB175A0 Offset: 0xB15FA0 VA: 0x180B175A0
	internal bool get_IsHierarchicalNodeDirty() { }

	// RVA: 0xB17640 Offset: 0xB16040 VA: 0x180B17640
	internal void set_IsHierarchicalNodeDirty(bool value) { }

	// RVA: 0xB174B0 Offset: 0xB15EB0 VA: 0x180B174B0
	public uint get_Area() { }

	// RVA: 0xB17560 Offset: 0xB15F60 VA: 0x180B17560
	public uint get_GraphIndex() { }

	// RVA: 0xB17600 Offset: 0xB16000 VA: 0x180B17600
	public void set_GraphIndex(uint value) { }

	// RVA: 0xB175C0 Offset: 0xB15FC0 VA: 0x180B175C0
	public uint get_Tag() { }

	// RVA: 0xB17720 Offset: 0xB16120 VA: 0x180B17720
	public void set_Tag(uint value) { }

	// RVA: 0xB17250 Offset: 0xB15C50 VA: 0x180B17250
	public void SetConnectivityDirty() { }

	[Obsolete("This method is deprecated because it never did anything, you can safely remove any calls to this method")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void RecalculateConnectionCosts() { }

	// RVA: 0xB172D0 Offset: 0xB15CD0 VA: 0x180B172D0 Slot: 4
	public virtual void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetConnections(Action<GraphNode> action);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddConnection(GraphNode node, uint cost);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void AddLooseConnection(GraphNode node, uint cost) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void RemoveConnection(GraphNode node);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void RemoveLooseConnection(GraphNode node) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ClearConnections(bool alsoReverse);

	// RVA: 0xB16E50 Offset: 0xB15850 VA: 0x180B16E50 Slot: 11
	public virtual bool ContainsConnection(GraphNode node) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public virtual bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Open(Path path, PathNode pathNode, PathHandler handler, bool useLoose = False);

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 14
	public virtual float SurfaceArea() { }

	// RVA: 0xB17180 Offset: 0xB15B80 VA: 0x180B17180 Slot: 15
	public virtual Vector3 RandomPointOnSurface() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector3 ClosestPointOnNode(Vector3 p);

	// RVA: 0xB17150 Offset: 0xB15B50 VA: 0x180B17150 Slot: 17
	public virtual int GetGizmoHashCode() { }

	// RVA: 0xB171E0 Offset: 0xB15BE0 VA: 0x180B171E0 Slot: 18
	public virtual void SerializeNode(GraphSerializationContext ctx) { }

	// RVA: 0xB16F30 Offset: 0xB15930 VA: 0x180B16F30 Slot: 19
	public virtual void DeserializeNode(GraphSerializationContext ctx) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void SerializeReferences(GraphSerializationContext ctx) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public virtual void DeserializeReferences(GraphSerializationContext ctx) { }
}
