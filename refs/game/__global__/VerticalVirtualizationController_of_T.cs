internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController // TypeDefIndex: 6207
{
	// Fields
	private readonly ObjectPool<T> m_Pool; // 0x0
	protected BaseVerticalCollectionView m_CollectionView; // 0x0
	protected List<T> m_ActiveItems; // 0x0
	protected T m_DraggedItem; // 0x0
	private int m_LastFocusedElementIndex; // 0x0
	private List<int> m_LastFocusedElementTreeChildIndexes; // 0x0
	protected readonly Func<T, bool> m_VisibleItemPredicateDelegate; // 0x0
	protected List<T> m_ScrollInsertionList; // 0x0
	private VisualElement m_EmptyRows; // 0x0

	// Properties
	public override IEnumerable<ReusableCollectionItem> activeItems { get; }
	internal int itemsCount { get; }
	internal T firstVisibleItem { get; }
	internal T lastVisibleItem { get; }
	public override int visibleItemCount { get; }
	protected SerializedVirtualizationData serializedData { get; }
	public override int firstVisibleIndex { get; set; }
	protected float lastHeight { get; }
	protected virtual bool alwaysRebindOnRefresh { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public override IEnumerable<ReusableCollectionItem> get_activeItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-VerticalVirtualizationController<object>.get_activeItems
	*/

	// RVA: -1 Offset: -1
	internal int get_itemsCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC4B0 Offset: 0x13BAEB0 VA: 0x1813BC4B0
	|-VerticalVirtualizationController<object>.get_itemsCount
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual bool VisibleItemPredicate(T i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BBC80 Offset: 0x13BA680 VA: 0x1813BBC80
	|-VerticalVirtualizationController<object>.VisibleItemPredicate
	*/

	// RVA: -1 Offset: -1
	internal T get_firstVisibleItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC490 Offset: 0x13BAE90 VA: 0x1813BC490
	|-VerticalVirtualizationController<object>.get_firstVisibleItem
	*/

	// RVA: -1 Offset: -1
	internal T get_lastVisibleItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC5B0 Offset: 0x13BAFB0 VA: 0x1813BC5B0
	|-VerticalVirtualizationController<object>.get_lastVisibleItem
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override int get_visibleItemCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC5F0 Offset: 0x13BAFF0 VA: 0x1813BC5F0
	|-VerticalVirtualizationController<object>.get_visibleItemCount
	*/

	// RVA: -1 Offset: -1
	protected SerializedVirtualizationData get_serializedData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC5D0 Offset: 0x13BAFD0 VA: 0x1813BC5D0
	|-VerticalVirtualizationController<object>.get_serializedData
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_firstVisibleIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC410 Offset: 0x13BAE10 VA: 0x1813BC410
	|-VerticalVirtualizationController<object>.get_firstVisibleIndex
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void set_firstVisibleIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC610 Offset: 0x13BB010 VA: 0x1813BC610
	|-VerticalVirtualizationController<object>.set_firstVisibleIndex
	*/

	// RVA: -1 Offset: -1
	protected float get_lastHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC590 Offset: 0x13BAF90 VA: 0x1813BC590
	|-VerticalVirtualizationController<object>.get_lastHeight
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected virtual bool get_alwaysRebindOnRefresh() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-VerticalVirtualizationController<object>.get_alwaysRebindOnRefresh
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(BaseVerticalCollectionView collectionView) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BBD30 Offset: 0x13BA730 VA: 0x1813BBD30
	|-VerticalVirtualizationController<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void Refresh(bool rebuild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA8E0 Offset: 0x13B92E0 VA: 0x1813BA8E0
	|-VerticalVirtualizationController<object>.Refresh
	*/

	// RVA: -1 Offset: -1
	protected void Setup(T recycledItem, int newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BAD90 Offset: 0x13B9790 VA: 0x1813BAD90
	|-VerticalVirtualizationController<object>.Setup
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override void OnFocus(VisualElement leafTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA500 Offset: 0x13B8F00 VA: 0x1813BA500
	|-VerticalVirtualizationController<object>.OnFocus
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void OnBlur(VisualElement willFocus) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA3C0 Offset: 0x13B8DC0 VA: 0x1813BA3C0
	|-VerticalVirtualizationController<object>.OnBlur
	*/

	// RVA: -1 Offset: -1
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA2C0 Offset: 0x13B8CC0 VA: 0x1813BA2C0
	|-VerticalVirtualizationController<object>.HandleFocus
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override void UpdateBackground() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BB5D0 Offset: 0x13B9FD0 VA: 0x1813BB5D0
	|-VerticalVirtualizationController<object>.UpdateBackground
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override void StartDragItem(ReusableCollectionItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BB3F0 Offset: 0x13B9DF0 VA: 0x1813BB3F0
	|-VerticalVirtualizationController<object>.StartDragItem
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void EndDrag(int dropIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B9CC0 Offset: 0x13B86C0 VA: 0x1813B9CC0
	|-VerticalVirtualizationController<object>.EndDrag
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA0F0 Offset: 0x13B8AF0 VA: 0x1813BA0F0
	|-VerticalVirtualizationController<object>.GetOrMakeItemAtIndex
	*/

	// RVA: -1 Offset: -1 Slot: 23
	internal virtual void ReleaseItem(int activeItemsIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BACB0 Offset: 0x13B96B0 VA: 0x1813BACB0
	|-VerticalVirtualizationController<object>.ReleaseItem
	*/

	// RVA: -1 Offset: -1
	private void OnDestroyItem(ReusableCollectionItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA440 Offset: 0x13B8E40 VA: 0x1813BA440
	|-VerticalVirtualizationController<object>.OnDestroyItem
	*/

	// RVA: -1 Offset: -1
	protected int GetDraggedIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BA050 Offset: 0x13B8A50 VA: 0x1813BA050
	|-VerticalVirtualizationController<object>.GetDraggedIndex
	*/
}
