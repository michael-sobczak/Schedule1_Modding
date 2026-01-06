internal struct TreeViewItemWrapper // TypeDefIndex: 6430
{
	// Fields
	public readonly TreeItem item; // 0x0
	public readonly int depth; // 0x10

	// Properties
	public int id { get; }
	public IEnumerable<int> childrenIds { get; }
	public bool hasChildren { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_id() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public IEnumerable<int> get_childrenIds() { }

	// RVA: 0x2E7E4D0 Offset: 0x2E7CED0 VA: 0x182E7E4D0
	public bool get_hasChildren() { }

	// RVA: 0x2E7E520 Offset: 0x2E7CF20 VA: 0x182E7E520
	public void .ctor(TreeItem item, int depth) { }
}
