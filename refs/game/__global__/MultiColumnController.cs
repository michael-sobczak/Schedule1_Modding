public class MultiColumnController : IDisposable // TypeDefIndex: 6367
{
	// Fields
	private static readonly PropertyName k_BoundColumnVePropertyName; // 0x0
	internal static readonly PropertyName bindableElementPropertyName; // 0x4
	internal static readonly string baseUssClassName; // 0x8
	private static readonly string k_HeaderContainerViewDataKey; // 0x10
	public static readonly string headerContainerUssClassName; // 0x18
	public static readonly string rowContainerUssClassName; // 0x20
	public static readonly string cellUssClassName; // 0x28
	public static readonly string cellLabelUssClassName; // 0x30
	private static readonly string k_HeaderViewDataKey; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action columnSortingChanged; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x18
	private BaseVerticalCollectionView m_View; // 0x20
	private VisualElement m_HeaderContainer; // 0x28
	private MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30

	// Properties
	internal MultiColumnCollectionHeader header { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E68CB0 Offset: 0x2E676B0 VA: 0x182E68CB0
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E68E00 Offset: 0x2E67800 VA: 0x182E68E00
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E68D50 Offset: 0x2E67750 VA: 0x182E68D50
	public void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E68EA0 Offset: 0x2E678A0 VA: 0x182E68EA0
	public void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x2E68780 Offset: 0x2E67180 VA: 0x182E68780
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: -1 Offset: -1
	private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF06CE0 Offset: 0xF056E0 VA: 0x180F06CE0
	|-MultiColumnController.BindCellItem<object>
	|
	|-RVA: 0xF06B90 Offset: 0xF05590 VA: 0x180F06B90
	|-MultiColumnController.BindCellItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E67FC0 Offset: 0x2E669C0 VA: 0x182E67FC0
	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	// RVA: 0x2E666F0 Offset: 0x2E650F0 VA: 0x182E666F0
	private static VisualElement DefaultMakeCellItem() { }

	// RVA: -1 Offset: -1
	private static void DefaultBindCellItem<T>(VisualElement ve, Column column, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07840 Offset: 0xF06240 VA: 0x180F07840
	|-MultiColumnController.DefaultBindCellItem<object>
	|
	|-RVA: 0xF07700 Offset: 0xF06100 VA: 0x180F07700
	|-MultiColumnController.DefaultBindCellItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E67270 Offset: 0x2E65C70 VA: 0x182E67270
	public VisualElement MakeItem() { }

	// RVA: -1 Offset: -1
	public void BindItem<T>(VisualElement element, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF072E0 Offset: 0xF05CE0 VA: 0x180F072E0
	|-MultiColumnController.BindItem<object>
	|
	|-RVA: 0xF06E20 Offset: 0xF05820 VA: 0x180F06E20
	|-MultiColumnController.BindItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E68000 Offset: 0x2E66A00 VA: 0x182E68000
	public void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x2E66780 Offset: 0x2E65180 VA: 0x182E66780
	public void DestroyItem(VisualElement element) { }

	// RVA: 0x2E67CA0 Offset: 0x2E666A0 VA: 0x182E67CA0
	public void PrepareView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x2E66AC0 Offset: 0x2E654C0 VA: 0x182E66AC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E679E0 Offset: 0x2E663E0 VA: 0x182E679E0
	private void OnHorizontalScrollerValueChanged(float v) { }

	// RVA: 0x2E67A00 Offset: 0x2E66400 VA: 0x182E67A00
	private void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E67640 Offset: 0x2E66040 VA: 0x182E67640
	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E68310 Offset: 0x2E66D10 VA: 0x182E68310
	private void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	// RVA: 0xFD5420 Offset: 0xFD3E20 VA: 0x180FD5420
	private void OnColumnSortingChanged() { }

	// RVA: 0x2E679C0 Offset: 0x2E663C0 VA: 0x182E679C0
	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	// RVA: 0x2E67690 Offset: 0x2E66090 VA: 0x182E67690
	private void OnColumnResized(int index, float width) { }

	// RVA: 0x2E675E0 Offset: 0x2E65FE0 VA: 0x182E675E0
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x2E675E0 Offset: 0x2E65FE0 VA: 0x182E675E0
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x2E67650 Offset: 0x2E66050 VA: 0x182E67650
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x2E67980 Offset: 0x2E66380 VA: 0x182E67980
	private void OnColumnsChanged(Column column, ColumnDataType type) { }

	// RVA: 0x2E67600 Offset: 0x2E66000 VA: 0x182E67600
	private void OnColumnChanged(ColumnsDataType type) { }

	// RVA: 0x2E675E0 Offset: 0x2E65FE0 VA: 0x182E675E0
	private void OnViewDataRestored() { }

	// RVA: 0x2E684D0 Offset: 0x2E66ED0 VA: 0x182E684D0
	private static void .cctor() { }
}
