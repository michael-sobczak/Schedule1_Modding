public class SortColumnDescription // TypeDefIndex: 6377
{
	// Fields
	[SerializeField]
	private int m_ColumnIndex; // 0x10
	[SerializeField]
	private string m_ColumnName; // 0x18
	[SerializeField]
	private SortDirection m_SortDirection; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Column <column>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<SortColumnDescription> changed; // 0x30

	// Properties
	public string columnName { get; set; }
	public int columnIndex { get; set; }
	public Column column { get; set; }
	public SortDirection direction { get; set; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_columnName() { }

	// RVA: 0x2E6AD20 Offset: 0x2E69720 VA: 0x182E6AD20
	public void set_columnName(string value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_columnIndex() { }

	// RVA: 0x2E6ACF0 Offset: 0x2E696F0 VA: 0x182E6ACF0
	public void set_columnIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Column get_column() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_column(Column value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public SortDirection get_direction() { }

	// RVA: 0x2E6AD80 Offset: 0x2E69780 VA: 0x182E6AD80
	public void set_direction(SortDirection value) { }

	[CompilerGenerated]
	// RVA: 0x2E6AB90 Offset: 0x2E69590 VA: 0x182E6AB90
	internal void add_changed(Action<SortColumnDescription> value) { }

	[CompilerGenerated]
	// RVA: 0x2E6AC40 Offset: 0x2E69640 VA: 0x182E6AC40
	internal void remove_changed(Action<SortColumnDescription> value) { }

	// RVA: 0x5E0C50 Offset: 0x5DF650 VA: 0x1805E0C50
	public void .ctor() { }

	// RVA: 0x2E6AB10 Offset: 0x2E69510 VA: 0x182E6AB10
	public void .ctor(int columnIndex, SortDirection direction) { }

	// RVA: 0x2E6AA70 Offset: 0x2E69470 VA: 0x182E6AA70
	public void .ctor(string columnName, SortDirection direction) { }
}
