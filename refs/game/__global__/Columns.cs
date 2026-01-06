public class Columns : ICollection<Column>, IEnumerable<Column>, IEnumerable // TypeDefIndex: 6366
{
	// Fields
	private IList<Column> m_Columns; // 0x10
	private List<Column> m_DisplayColumns; // 0x18
	private List<Column> m_VisibleColumns; // 0x20
	private bool m_VisibleColumnsDirty; // 0x28
	private Columns.StretchMode m_StretchMode; // 0x2C
	private bool m_Reorderable; // 0x30
	private bool m_Resizable; // 0x31
	private bool m_ResizePreview; // 0x32
	private string m_PrimaryColumnName; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnsDataType> changed; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column, int> columnAdded; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column> columnRemoved; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column, ColumnDataType> columnChanged; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column> columnResized; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column, int, int> columnReordered; // 0x68

	// Properties
	public string primaryColumnName { get; set; }
	public bool reorderable { get; set; }
	public bool resizable { get; set; }
	public bool resizePreview { get; set; }
	internal IEnumerable<Column> displayList { get; }
	internal IEnumerable<Column> visibleList { get; }
	public Columns.StretchMode stretchMode { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	public Column Item { get; }
	public Column Item { get; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_primaryColumnName() { }

	// RVA: 0x2E5EEB0 Offset: 0x2E5D8B0 VA: 0x182E5EEB0
	public void set_primaryColumnName(string value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_reorderable() { }

	// RVA: 0x2E5EF10 Offset: 0x2E5D910 VA: 0x182E5EF10
	public void set_reorderable(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_resizable() { }

	// RVA: 0x2E5EF40 Offset: 0x2E5D940 VA: 0x182E5EF40
	public void set_resizable(bool value) { }

	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0
	public bool get_resizePreview() { }

	// RVA: 0x2E5EF70 Offset: 0x2E5D970 VA: 0x182E5EF70
	public void set_resizePreview(bool value) { }

	// RVA: 0x2E5EA50 Offset: 0x2E5D450 VA: 0x182E5EA50
	internal IEnumerable<Column> get_displayList() { }

	// RVA: 0x2E5EA70 Offset: 0x2E5D470 VA: 0x182E5EA70
	internal IEnumerable<Column> get_visibleList() { }

	[CompilerGenerated]
	// RVA: 0x2E5E3B0 Offset: 0x2E5CDB0 VA: 0x182E5E3B0
	internal void add_changed(Action<ColumnsDataType> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5EA90 Offset: 0x2E5D490 VA: 0x182E5EA90
	internal void remove_changed(Action<ColumnsDataType> value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public Columns.StretchMode get_stretchMode() { }

	// RVA: 0x2E5EFA0 Offset: 0x2E5D9A0 VA: 0x182E5EFA0
	public void set_stretchMode(Columns.StretchMode value) { }

	[CompilerGenerated]
	// RVA: 0x2E5E460 Offset: 0x2E5CE60 VA: 0x182E5E460
	internal void add_columnAdded(Action<Column, int> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5EB40 Offset: 0x2E5D540 VA: 0x182E5EB40
	internal void remove_columnAdded(Action<Column, int> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5E5C0 Offset: 0x2E5CFC0 VA: 0x182E5E5C0
	internal void add_columnRemoved(Action<Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5ECA0 Offset: 0x2E5D6A0 VA: 0x182E5ECA0
	internal void remove_columnRemoved(Action<Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5E510 Offset: 0x2E5CF10 VA: 0x182E5E510
	internal void add_columnChanged(Action<Column, ColumnDataType> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5EBF0 Offset: 0x2E5D5F0 VA: 0x182E5EBF0
	internal void remove_columnChanged(Action<Column, ColumnDataType> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5E720 Offset: 0x2E5D120 VA: 0x182E5E720
	internal void add_columnResized(Action<Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5EE00 Offset: 0x2E5D800 VA: 0x182E5EE00
	internal void remove_columnResized(Action<Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5E670 Offset: 0x2E5D070 VA: 0x182E5E670
	internal void add_columnReordered(Action<Column, int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5ED50 Offset: 0x2E5D750 VA: 0x182E5ED50
	internal void remove_columnReordered(Action<Column, int, int> value) { }

	// RVA: 0x2E5DCF0 Offset: 0x2E5C6F0 VA: 0x182E5DCF0
	public bool IsPrimary(Column column) { }

	// RVA: 0x2E5D8A0 Offset: 0x2E5C2A0 VA: 0x182E5D8A0 Slot: 11
	public IEnumerator<Column> GetEnumerator() { }

	// RVA: 0x2E5D8A0 Offset: 0x2E5C2A0 VA: 0x182E5D8A0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2E5D300 Offset: 0x2E5BD00 VA: 0x182E5D300 Slot: 6
	public void Add(Column item) { }

	// RVA: 0x2E5D370 Offset: 0x2E5BD70 VA: 0x182E5D370 Slot: 7
	public void Clear() { }

	// RVA: 0x2E5D710 Offset: 0x2E5C110 VA: 0x182E5D710 Slot: 8
	public bool Contains(Column item) { }

	// RVA: 0x2E5D590 Offset: 0x2E5BF90 VA: 0x182E5D590
	public bool Contains(string name) { }

	// RVA: 0x2E5D770 Offset: 0x2E5C170 VA: 0x182E5D770 Slot: 9
	public void CopyTo(Column[] array, int arrayIndex) { }

	// RVA: 0x2E5DE10 Offset: 0x2E5C810 VA: 0x182E5DE10 Slot: 10
	public bool Remove(Column column) { }

	// RVA: 0x2E5DD70 Offset: 0x2E5C770 VA: 0x182E5DD70
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0xD109B0 Offset: 0xD0F3B0 VA: 0x180D109B0
	private void OnColumnResized(Column column) { }

	// RVA: 0x2E5E7D0 Offset: 0x2E5D1D0 VA: 0x182E5E7D0 Slot: 4
	public int get_Count() { }

	// RVA: 0x2E5E820 Offset: 0x2E5D220 VA: 0x182E5E820 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x2E5D8F0 Offset: 0x2E5C2F0 VA: 0x182E5D8F0
	public int IndexOf(Column column) { }

	// RVA: 0x2E5DA40 Offset: 0x2E5C440 VA: 0x182E5DA40
	public void Insert(int index, Column column) { }

	// RVA: 0x2E5E870 Offset: 0x2E5D270 VA: 0x182E5E870
	public Column get_Item(int index) { }

	// RVA: 0x2E5E8D0 Offset: 0x2E5D2D0 VA: 0x182E5E8D0
	public Column get_Item(string name) { }

	// RVA: 0x2E5DFF0 Offset: 0x2E5C9F0 VA: 0x182E5DFF0
	public void ReorderDisplay(int from, int to) { }

	// RVA: 0x2E5D9C0 Offset: 0x2E5C3C0 VA: 0x182E5D9C0
	private void InitOrderColumns() { }

	// RVA: 0x2E5D840 Offset: 0x2E5C240 VA: 0x182E5D840
	private void DirtyVisibleColumns() { }

	// RVA: 0x2E5E130 Offset: 0x2E5CB30 VA: 0x182E5E130
	private void UpdateVisibleColumns() { }

	// RVA: 0xD3EE10 Offset: 0xD3D810 VA: 0x180D3EE10
	private void NotifyChange(ColumnsDataType type) { }

	// RVA: 0x2E5E320 Offset: 0x2E5CD20 VA: 0x182E5E320
	public void .ctor() { }
}
