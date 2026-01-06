public class MultiColumnListView : BaseListView // TypeDefIndex: 6370
{
	// Fields
	private Columns m_Columns; // 0x550
	private bool m_SortingEnabled; // 0x558
	private SortColumnDescriptions m_SortColumnDescriptions; // 0x560
	private List<SortColumnDescription> m_SortedColumns; // 0x568
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action columnSortingChanged; // 0x570
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x578

	// Properties
	public MultiColumnListViewController viewController { get; }
	public Columns columns { get; set; }
	public SortColumnDescriptions sortColumnDescriptions { get; set; }
	public bool sortingEnabled { set; }

	// Methods

	// RVA: 0x2E694B0 Offset: 0x2E67EB0 VA: 0x182E694B0
	public MultiColumnListViewController get_viewController() { }

	// RVA: 0x2E62EC0 Offset: 0x2E618C0 VA: 0x182E62EC0
	public Columns get_columns() { }

	// RVA: 0x2E69530 Offset: 0x2E67F30 VA: 0x182E69530
	private void set_columns(Columns value) { }

	// RVA: 0x2E62ED0 Offset: 0x2E618D0 VA: 0x182E62ED0
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x2E695D0 Offset: 0x2E67FD0 VA: 0x182E695D0
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x2E69680 Offset: 0x2E68080 VA: 0x182E69680
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x2E69450 Offset: 0x2E67E50 VA: 0x182E69450
	public void .ctor() { }

	// RVA: 0x2E69280 Offset: 0x2E67C80 VA: 0x182E69280
	public void .ctor(Columns columns) { }

	// RVA: 0x2E68F50 Offset: 0x2E67950 VA: 0x182E68F50 Slot: 105
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x2E69060 Offset: 0x2E67A60 VA: 0x182E69060 Slot: 106
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x2E68FE0 Offset: 0x2E679E0 VA: 0x182E68FE0 Slot: 104
	internal override void CreateVirtualizationController() { }

	// RVA: 0x2E69020 Offset: 0x2E67A20 VA: 0x182E69020
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x2E69040 Offset: 0x2E67A40 VA: 0x182E69040
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }
}
