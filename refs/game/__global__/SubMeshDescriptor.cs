public struct SubMeshDescriptor // TypeDefIndex: 12181
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Bounds <bounds>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private MeshTopology <topology>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexStart>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <indexCount>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <baseVertex>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <firstVertex>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <vertexCount>k__BackingField; // 0x2C

	// Properties
	public Bounds bounds { get; set; }
	public MeshTopology topology { get; set; }
	public int indexStart { get; set; }
	public int indexCount { get; set; }
	public int baseVertex { get; set; }
	public int firstVertex { get; set; }
	public int vertexCount { get; set; }

	// Methods

	// RVA: 0x2CEC550 Offset: 0x2CEAF50 VA: 0x182CEC550
	public void .ctor(int indexStart, int indexCount, MeshTopology topology = 0) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1122D20 Offset: 0x1121720 VA: 0x181122D20
	public Bounds get_bounds() { }

	[CompilerGenerated]
	// RVA: 0x2CEC590 Offset: 0x2CEAF90 VA: 0x182CEC590
	public void set_bounds(Bounds value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public MeshTopology get_topology() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_topology(MeshTopology value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_indexStart() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_indexStart(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_indexCount() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_indexCount(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_baseVertex() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_baseVertex(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_firstVertex() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_firstVertex(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_vertexCount() { }

	[CompilerGenerated]
	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_vertexCount(int value) { }

	// RVA: 0x2CEC1F0 Offset: 0x2CEABF0 VA: 0x182CEC1F0 Slot: 3
	public override string ToString() { }
}
