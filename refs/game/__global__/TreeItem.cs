internal struct TreeItem // TypeDefIndex: 6429
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <id>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <parentId>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly IEnumerable<int> <childrenIds>k__BackingField; // 0x8

	// Properties
	public int id { get; }
	public int parentId { get; }
	public IEnumerable<int> childrenIds { get; }
	public bool hasChildren { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_parentId() { }

	[CompilerGenerated]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public IEnumerable<int> get_childrenIds() { }

	// RVA: 0x2E7E4D0 Offset: 0x2E7CED0 VA: 0x182E7E4D0
	public bool get_hasChildren() { }

	// RVA: 0x1333E80 Offset: 0x1332880 VA: 0x181333E80
	public void .ctor(int id, int parentId = -1, IEnumerable<int> childrenIds) { }
}
