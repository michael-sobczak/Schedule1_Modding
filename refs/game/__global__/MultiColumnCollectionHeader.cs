internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 7224
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string columnContainerUssClassName; // 0x8
	public static readonly string handleContainerUssClassName; // 0x10
	public static readonly string reorderableUssClassName; // 0x18
	private bool m_SortingEnabled; // 0x3C8
	private List<SortColumnDescription> m_SortedColumns; // 0x3D0
	private SortColumnDescriptions m_SortDescriptions; // 0x3D8
	private List<MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates; // 0x3E0
	private bool m_SortingUpdatesTemporarilyDisabled; // 0x3E8
	private MultiColumnCollectionHeader.ViewState m_ViewState; // 0x3F0
	private bool m_ApplyingViewState; // 0x3F8
	private bool m_DoLayoutScheduled; // 0x3F9
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Dictionary<Column, MultiColumnCollectionHeader.ColumnData> <columnDataMap>k__BackingField; // 0x400
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ColumnLayout <columnLayout>k__BackingField; // 0x408
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly VisualElement <columnContainer>k__BackingField; // 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; // 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Columns <columns>k__BackingField; // 0x420
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<int, float> columnResized; // 0x428
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action columnSortingChanged; // 0x430
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; // 0x438
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action viewDataRestored; // 0x440

	// Properties
	internal bool isApplyingViewState { get; }
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> columnDataMap { get; }
	public ColumnLayout columnLayout { get; }
	public VisualElement columnContainer { get; }
	public VisualElement resizeHandleContainer { get; }
	public IEnumerable<SortColumnDescription> sortedColumns { get; }
	public SortColumnDescriptions sortDescriptions { get; set; }
	public Columns columns { get; }
	public bool sortingEnabled { get; set; }

	// Methods

	// RVA: 0x2E49390 Offset: 0x2E47D90 VA: 0x182E49390
	internal bool get_isApplyingViewState() { }

	[CompilerGenerated]
	// RVA: 0x126D640 Offset: 0x126C040 VA: 0x18126D640
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	[CompilerGenerated]
	// RVA: 0x13E2480 Offset: 0x13E0E80 VA: 0x1813E2480
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x13E24A0 Offset: 0x13E0EA0 VA: 0x1813E24A0
	public VisualElement get_columnContainer() { }

	[CompilerGenerated]
	// RVA: 0x13E2490 Offset: 0x13E0E90 VA: 0x1813E2490
	public VisualElement get_resizeHandleContainer() { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290
	public SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x2E49680 Offset: 0x2E48080 VA: 0x182E49680
	protected internal void set_sortDescriptions(SortColumnDescriptions value) { }

	[CompilerGenerated]
	// RVA: 0x2E49380 Offset: 0x2E47D80 VA: 0x182E49380
	public Columns get_columns() { }

	// RVA: 0x2C19D00 Offset: 0x2C18700 VA: 0x182C19D00
	public bool get_sortingEnabled() { }

	// RVA: 0x2E49730 Offset: 0x2E48130 VA: 0x182E49730
	public void set_sortingEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E490A0 Offset: 0x2E47AA0 VA: 0x182E490A0
	public void add_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x2E493A0 Offset: 0x2E47DA0 VA: 0x182E493A0
	public void remove_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x2E49160 Offset: 0x2E47B60 VA: 0x182E49160
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E49460 Offset: 0x2E47E60 VA: 0x182E49460
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E49210 Offset: 0x2E47C10 VA: 0x182E49210
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E49510 Offset: 0x2E47F10 VA: 0x182E49510
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E492D0 Offset: 0x2E47CD0 VA: 0x182E492D0
	internal void add_viewDataRestored(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E495D0 Offset: 0x2E47FD0 VA: 0x182E495D0
	internal void remove_viewDataRestored(Action value) { }

	// RVA: 0x2E488C0 Offset: 0x2E472C0 VA: 0x182E488C0
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: 0x2E47150 Offset: 0x2E45B50 VA: 0x182E47150
	private void ScheduleDoLayout() { }

	// RVA: 0x2E47110 Offset: 0x2E45B10 VA: 0x182E47110
	private void ResizeToFit() { }

	// RVA: 0x2E47C10 Offset: 0x2E46610 VA: 0x182E47C10
	private void UpdateSortedColumns() { }

	// RVA: 0x2E47480 Offset: 0x2E45E80 VA: 0x182E47480
	private void UpdateColumnControls() { }

	// RVA: 0x2E454E0 Offset: 0x2E43EE0 VA: 0x182E454E0
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x2E454F0 Offset: 0x2E43EF0 VA: 0x182E454F0
	private void OnColumnAdded(Column column) { }

	// RVA: 0x2E45FD0 Offset: 0x2E449D0 VA: 0x182E45FD0
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x2E459E0 Offset: 0x2E443E0 VA: 0x182E459E0
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x2E46300 Offset: 0x2E44D00 VA: 0x182E46300
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x2E464D0 Offset: 0x2E44ED0 VA: 0x182E464D0
	private void OnColumnResized(Column column) { }

	// RVA: 0x2E46510 Offset: 0x2E44F10 VA: 0x182E46510
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x2E46E00 Offset: 0x2E45800 VA: 0x182E46E00
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x2E46CB0 Offset: 0x2E456B0 VA: 0x182E46CB0
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x2E45480 Offset: 0x2E43E80 VA: 0x182E45480
	private void DoLayout() { }

	// RVA: 0x2E45C20 Offset: 0x2E44620 VA: 0x182E45C20
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E45A70 Offset: 0x2E44470 VA: 0x182E45A70
	private void OnColumnClicked(EventBase evt) { }

	// RVA: 0x2E479B0 Offset: 0x2E463B0 VA: 0x182E479B0
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x2E47210 Offset: 0x2E45C10 VA: 0x182E47210
	public void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x2E46FB0 Offset: 0x2E459B0 VA: 0x182E46FB0
	private void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x2E470D0 Offset: 0x2E45AD0 VA: 0x182E470D0
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x2E44750 Offset: 0x2E43150 VA: 0x182E44750
	private void ApplyColumnSorting() { }

	// RVA: 0x2E48220 Offset: 0x2E46C20 VA: 0x182E48220
	private void UpdateSortingStatus() { }

	// RVA: 0x2E46EA0 Offset: 0x2E458A0 VA: 0x182E46EA0 Slot: 96
	internal override void OnViewDataReady() { }

	// RVA: 0x2E464D0 Offset: 0x2E44ED0 VA: 0x182E464D0
	private void SaveViewState() { }

	// RVA: 0x2E44E70 Offset: 0x2E43870 VA: 0x182E44E70
	private void CleanupColumnData(MultiColumnCollectionHeader.ColumnData data) { }

	// RVA: 0x2E450B0 Offset: 0x2E43AB0 VA: 0x182E450B0 Slot: 100
	public void Dispose() { }

	// RVA: 0x2E48750 Offset: 0x2E47150 VA: 0x182E48750
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2E47110 Offset: 0x2E45B10 VA: 0x182E47110
	private void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }
}
