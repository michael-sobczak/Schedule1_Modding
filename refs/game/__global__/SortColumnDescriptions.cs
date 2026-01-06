public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable // TypeDefIndex: 6380
{
	// Fields
	[SerializeField]
	private readonly IList<SortColumnDescription> m_Descriptions; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action changed; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E6B640 Offset: 0x2E6A040 VA: 0x182E6B640
	internal void add_changed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E6B780 Offset: 0x2E6A180 VA: 0x182E6B780
	internal void remove_changed(Action value) { }

	// RVA: 0x2E6B0E0 Offset: 0x2E69AE0 VA: 0x182E6B0E0 Slot: 11
	public IEnumerator<SortColumnDescription> GetEnumerator() { }

	// RVA: 0x2E6B0E0 Offset: 0x2E69AE0 VA: 0x182E6B0E0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2E6ADB0 Offset: 0x2E697B0 VA: 0x182E6ADB0 Slot: 6
	public void Add(SortColumnDescription item) { }

	// RVA: 0x2E6AE20 Offset: 0x2E69820 VA: 0x182E6AE20 Slot: 7
	public void Clear() { }

	// RVA: 0x2E6AFB0 Offset: 0x2E699B0 VA: 0x182E6AFB0 Slot: 8
	public bool Contains(SortColumnDescription item) { }

	// RVA: 0x2E6B010 Offset: 0x2E69A10 VA: 0x182E6B010 Slot: 9
	public void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	// RVA: 0x2E6B3F0 Offset: 0x2E69DF0 VA: 0x182E6B3F0 Slot: 10
	public bool Remove(SortColumnDescription desc) { }

	// RVA: 0x10EDAF0 Offset: 0x10EC4F0 VA: 0x1810EDAF0
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	// RVA: 0x2E6B6E0 Offset: 0x2E6A0E0 VA: 0x182E6B6E0 Slot: 4
	public int get_Count() { }

	// RVA: 0x2E6B730 Offset: 0x2E6A130 VA: 0x182E6B730 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x2E6B130 Offset: 0x2E69B30 VA: 0x182E6B130
	public void Insert(int index, SortColumnDescription desc) { }

	// RVA: 0x2E6B5C0 Offset: 0x2E69FC0 VA: 0x182E6B5C0
	public void .ctor() { }
}
