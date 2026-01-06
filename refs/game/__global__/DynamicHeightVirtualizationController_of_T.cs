internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 6199
{
	// Fields
	private int m_HighestCachedIndex; // 0x0
	private readonly Dictionary<int, float> m_ItemHeightCache; // 0x0
	private readonly Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>> m_ContentHeightCache; // 0x0
	private readonly HashSet<int> m_WaitingCache; // 0x0
	private int m_ForcedFirstVisibleItem; // 0x0
	private int m_ForcedLastVisibleItem; // 0x0
	private bool m_StickToBottom; // 0x0
	private DynamicHeightVirtualizationController.VirtualizationChange<T> m_LastChange; // 0x0
	private DynamicHeightVirtualizationController.ScrollDirection<T> m_ScrollDirection; // 0x0
	private Vector2 m_DelayedScrollOffset; // 0x0
	private float m_AccumulatedHeight; // 0x0
	private float m_MinimumItemHeight; // 0x0
	private Action m_FillCallback; // 0x0
	private Action m_ScrollCallback; // 0x0
	private Action m_ScrollResetCallback; // 0x0
	private Action<ReusableCollectionItem> m_GeometryChangedCallback; // 0x0
	private IVisualElementScheduledItem m_ScheduledItem; // 0x0
	private IVisualElementScheduledItem m_ScrollScheduledItem; // 0x0
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; // 0x0
	private Predicate<int> m_IndexOutOfBoundsPredicate; // 0x0

	// Properties
	private float defaultExpectedHeight { get; }
	private float contentPadding { get; set; }
	private float contentHeight { get; set; }
	private int anchoredIndex { get; set; }
	private float anchorOffset { get; set; }
	private float viewportMaxOffset { get; }
	protected override bool alwaysRebindOnRefresh { get; }

	// Methods

	// RVA: -1 Offset: -1
	private float get_defaultExpectedHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A300 Offset: 0x1638D00 VA: 0x18163A300
	|-DynamicHeightVirtualizationController<object>.get_defaultExpectedHeight
	*/

	// RVA: -1 Offset: -1
	private float get_contentPadding() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A2C0 Offset: 0x1638CC0 VA: 0x18163A2C0
	|-DynamicHeightVirtualizationController<object>.get_contentPadding
	*/

	// RVA: -1 Offset: -1
	private void set_contentPadding(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A650 Offset: 0x1639050 VA: 0x18163A650
	|-DynamicHeightVirtualizationController<object>.set_contentPadding
	*/

	// RVA: -1 Offset: -1
	private float get_contentHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A280 Offset: 0x1638C80 VA: 0x18163A280
	|-DynamicHeightVirtualizationController<object>.get_contentHeight
	*/

	// RVA: -1 Offset: -1
	private void set_contentHeight(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A4C0 Offset: 0x1638EC0 VA: 0x18163A4C0
	|-DynamicHeightVirtualizationController<object>.set_contentHeight
	*/

	// RVA: -1 Offset: -1
	private int get_anchoredIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A250 Offset: 0x1638C50 VA: 0x18163A250
	|-DynamicHeightVirtualizationController<object>.get_anchoredIndex
	*/

	// RVA: -1 Offset: -1
	private void set_anchoredIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A470 Offset: 0x1638E70 VA: 0x18163A470
	|-DynamicHeightVirtualizationController<object>.set_anchoredIndex
	*/

	// RVA: -1 Offset: -1
	private float get_anchorOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A210 Offset: 0x1638C10 VA: 0x18163A210
	|-DynamicHeightVirtualizationController<object>.get_anchorOffset
	*/

	// RVA: -1 Offset: -1
	private void set_anchorOffset(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A410 Offset: 0x1638E10 VA: 0x18163A410
	|-DynamicHeightVirtualizationController<object>.set_anchorOffset
	*/

	// RVA: -1 Offset: -1
	private float get_viewportMaxOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163A3A0 Offset: 0x1638DA0 VA: 0x18163A3A0
	|-DynamicHeightVirtualizationController<object>.get_viewportMaxOffset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override bool get_alwaysRebindOnRefresh() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-DynamicHeightVirtualizationController<object>.get_alwaysRebindOnRefresh
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseVerticalCollectionView collectionView) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639EF0 Offset: 0x16388F0 VA: 0x181639EF0
	|-DynamicHeightVirtualizationController<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void Refresh(bool rebuild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16380B0 Offset: 0x1636AB0 VA: 0x1816380B0
	|-DynamicHeightVirtualizationController<object>.Refresh
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void ScrollToItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639030 Offset: 0x1637A30 VA: 0x181639030
	|-DynamicHeightVirtualizationController<object>.ScrollToItem
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void Resize(Vector2 size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16388C0 Offset: 0x16372C0 VA: 0x1816388C0
	|-DynamicHeightVirtualizationController<object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnScroll(Vector2 scrollOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1637D20 Offset: 0x1636720 VA: 0x181637D20
	|-DynamicHeightVirtualizationController<object>.OnScroll
	*/

	// RVA: -1 Offset: -1
	private void OnScrollUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16378C0 Offset: 0x16362C0 VA: 0x1816378C0
	|-DynamicHeightVirtualizationController<object>.OnScrollUpdate
	*/

	// RVA: -1 Offset: -1
	private void CycleItems(int firstIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1635AF0 Offset: 0x16344F0 VA: 0x181635AF0
	|-DynamicHeightVirtualizationController<object>.CycleItems
	*/

	// RVA: -1 Offset: -1
	private bool NeedsFill() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16375A0 Offset: 0x1635FA0 VA: 0x1816375A0
	|-DynamicHeightVirtualizationController<object>.NeedsFill
	*/

	// RVA: -1 Offset: -1
	private void Fill() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1636580 Offset: 0x1634F80 VA: 0x181636580
	|-DynamicHeightVirtualizationController<object>.Fill
	*/

	// RVA: -1 Offset: -1
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639DA0 Offset: 0x16387A0 VA: 0x181639DA0
	|-DynamicHeightVirtualizationController<object>.UpdateScrollViewContainer
	*/

	// RVA: -1 Offset: -1
	private void ApplyScrollViewUpdate(bool dimensionsOnly = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634D30 Offset: 0x1633730 VA: 0x181634D30
	|-DynamicHeightVirtualizationController<object>.ApplyScrollViewUpdate
	*/

	// RVA: -1 Offset: -1
	private void UpdateAnchor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639610 Offset: 0x1638010 VA: 0x181639610
	|-DynamicHeightVirtualizationController<object>.UpdateAnchor
	*/

	// RVA: -1 Offset: -1
	private void ScheduleFill() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638DC0 Offset: 0x16377C0 VA: 0x181638DC0
	|-DynamicHeightVirtualizationController<object>.ScheduleFill
	*/

	// RVA: -1 Offset: -1
	private void ScheduleScroll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638F60 Offset: 0x1637960 VA: 0x181638F60
	|-DynamicHeightVirtualizationController<object>.ScheduleScroll
	*/

	// RVA: -1 Offset: -1
	private void ScheduleScrollDirectionReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638E90 Offset: 0x1637890 VA: 0x181638E90
	|-DynamicHeightVirtualizationController<object>.ScheduleScrollDirectionReset
	*/

	// RVA: -1 Offset: -1
	private void ResetScroll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638850 Offset: 0x1637250 VA: 0x181638850
	|-DynamicHeightVirtualizationController<object>.ResetScroll
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override int GetIndexFromPosition(Vector2 position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16371D0 Offset: 0x1635BD0 VA: 0x1816371D0
	|-DynamicHeightVirtualizationController<object>.GetIndexFromPosition
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override float GetExpectedItemHeight(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1637080 Offset: 0x1635A80 VA: 0x181637080
	|-DynamicHeightVirtualizationController<object>.GetExpectedItemHeight
	*/

	// RVA: -1 Offset: -1
	private int GetFirstVisibleItem(float offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1637150 Offset: 0x1635B50 VA: 0x181637150
	|-DynamicHeightVirtualizationController<object>.GetFirstVisibleItem
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override float GetExpectedContentHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1636FB0 Offset: 0x16359B0 VA: 0x181636FB0
	|-DynamicHeightVirtualizationController<object>.GetExpectedContentHeight
	*/

	// RVA: -1 Offset: -1
	private float GetContentHeightForIndex(int lastIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1636E10 Offset: 0x1635810 VA: 0x181636E10
	|-DynamicHeightVirtualizationController<object>.GetContentHeightForIndex
	*/

	// RVA: -1 Offset: -1
	private DynamicHeightVirtualizationController.ContentHeightCacheInfo<T> GetCachedContentHeight(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1636D90 Offset: 0x1635790 VA: 0x181636D90
	|-DynamicHeightVirtualizationController<object>.GetCachedContentHeight
	*/

	// RVA: -1 Offset: -1
	private void RegisterItemHeight(int index, float height) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638390 Offset: 0x1636D90 VA: 0x181638390
	|-DynamicHeightVirtualizationController<object>.RegisterItemHeight
	*/

	// RVA: -1 Offset: -1
	private void UnregisterItemHeight(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639360 Offset: 0x1637D60 VA: 0x181639360
	|-DynamicHeightVirtualizationController<object>.UnregisterItemHeight
	*/

	// RVA: -1 Offset: -1
	private void CleanItemHeightCache() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1635720 Offset: 0x1634120 VA: 0x181635720
	|-DynamicHeightVirtualizationController<object>.CleanItemHeightCache
	*/

	// RVA: -1 Offset: -1
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16377C0 Offset: 0x16361C0 VA: 0x1816377C0
	|-DynamicHeightVirtualizationController<object>.OnRecycledItemGeometryChanged
	*/

	// RVA: -1 Offset: -1
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1639750 Offset: 0x1638150 VA: 0x181639750
	|-DynamicHeightVirtualizationController<object>.UpdateRegisteredHeight
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1637250 Offset: 0x1635C50 VA: 0x181637250
	|-DynamicHeightVirtualizationController<object>.GetOrMakeItemAtIndex
	*/

	// RVA: -1 Offset: -1 Slot: 23
	internal override void ReleaseItem(int activeItemsIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1638760 Offset: 0x1637160 VA: 0x181638760
	|-DynamicHeightVirtualizationController<object>.ReleaseItem
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override void StartDragItem(ReusableCollectionItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16392C0 Offset: 0x1637CC0 VA: 0x1816392C0
	|-DynamicHeightVirtualizationController<object>.StartDragItem
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void EndDrag(int dropIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1636290 Offset: 0x1634C90 VA: 0x181636290
	|-DynamicHeightVirtualizationController<object>.EndDrag
	*/

	// RVA: -1 Offset: -1
	private void HideItem(int activeItemsIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16372B0 Offset: 0x1635CB0 VA: 0x1816372B0
	|-DynamicHeightVirtualizationController<object>.HideItem
	*/

	// RVA: -1 Offset: -1
	private void MarkWaitingForLayout(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16374B0 Offset: 0x1635EB0 VA: 0x1816374B0
	|-DynamicHeightVirtualizationController<object>.MarkWaitingForLayout
	*/

	// RVA: -1 Offset: -1
	private bool IsIndexOutOfBounds(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1637430 Offset: 0x1635E30 VA: 0x181637430
	|-DynamicHeightVirtualizationController<object>.IsIndexOutOfBounds
	*/
}
