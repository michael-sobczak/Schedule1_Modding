public class MultiColumnTreeView : BaseTreeView // TypeDefIndex: 6373
{
	// Fields
	private Columns m_Columns; // 0x4D0
	private bool m_SortingEnabled; // 0x4D8
	private SortColumnDescriptions m_SortColumnDescriptions; // 0x4E0
	private List<SortColumnDescription> m_SortedColumns; // 0x4E8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action columnSortingChanged; // 0x4F0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x4F8

	// Properties
	public MultiColumnTreeViewController viewController { get; }
	public Columns columns { get; set; }
	public SortColumnDescriptions sortColumnDescriptions { get; set; }
	public bool sortingEnabled { set; }

	// Methods

	// RVA: 0x2E69C60 Offset: 0x2E68660 VA: 0x182E69C60
	public MultiColumnTreeViewController get_viewController() { }

	// RVA: 0x2E69C50 Offset: 0x2E68650 VA: 0x182E69C50
	public Columns get_columns() { }

	// RVA: 0x2E69CE0 Offset: 0x2E686E0 VA: 0x182E69CE0
	private void set_columns(Columns value) { }

	// RVA: 0x28171B0 Offset: 0x2815BB0 VA: 0x1828171B0
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x2E69D80 Offset: 0x2E68780 VA: 0x182E69D80
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x2E69E30 Offset: 0x2E68830 VA: 0x182E69E30
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x2E69BF0 Offset: 0x2E685F0 VA: 0x182E69BF0
	public void .ctor() { }

	// RVA: 0x2E69A20 Offset: 0x2E68420 VA: 0x182E69A20
	public void .ctor(Columns columns) { }

	// RVA: 0x2E696E0 Offset: 0x2E680E0 VA: 0x182E696E0 Slot: 105
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x2E69800 Offset: 0x2E68200 VA: 0x182E69800 Slot: 106
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x2E69780 Offset: 0x2E68180 VA: 0x182E69780 Slot: 104
	internal override void CreateVirtualizationController() { }

	// RVA: 0x2E697C0 Offset: 0x2E681C0 VA: 0x182E697C0
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x2E697E0 Offset: 0x2E681E0 VA: 0x182E697E0
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }
}
