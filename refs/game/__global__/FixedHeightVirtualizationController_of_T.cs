internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 6200
{
	// Properties
	private float resolvedItemHeight { get; }

	// Methods

	// RVA: -1 Offset: -1
	private float get_resolvedItemHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7870 Offset: 0x17C6270 VA: 0x1817C7870
	|-FixedHeightVirtualizationController<object>.get_resolvedItemHeight
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected override bool VisibleItemPredicate(T i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1366110 Offset: 0x1364B10 VA: 0x181366110
	|-FixedHeightVirtualizationController<object>.VisibleItemPredicate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseVerticalCollectionView collectionView) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C88B0 Offset: 0x17C72B0 VA: 0x1817C88B0
	|-FixedHeightVirtualizationController<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override int GetIndexFromPosition(Vector2 position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C78A0 Offset: 0x17C62A0 VA: 0x1817C78A0
	|-FixedHeightVirtualizationController<object>.GetIndexFromPosition
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override float GetExpectedItemHeight(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7870 Offset: 0x17C6270 VA: 0x1817C7870
	|-FixedHeightVirtualizationController<object>.GetExpectedItemHeight
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override float GetExpectedContentHeight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7810 Offset: 0x17C6210 VA: 0x1817C7810
	|-FixedHeightVirtualizationController<object>.GetExpectedContentHeight
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void ScrollToItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8660 Offset: 0x17C7060 VA: 0x1817C8660
	|-FixedHeightVirtualizationController<object>.ScrollToItem
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void Resize(Vector2 size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8230 Offset: 0x17C6C30 VA: 0x1817C8230
	|-FixedHeightVirtualizationController<object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnScroll(Vector2 scrollOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7A70 Offset: 0x17C6470 VA: 0x1817C7A70
	|-FixedHeightVirtualizationController<object>.OnScroll
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C78E0 Offset: 0x17C62E0 VA: 0x1817C78E0
	|-FixedHeightVirtualizationController<object>.GetOrMakeItemAtIndex
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void EndDrag(int dropIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C75F0 Offset: 0x17C5FF0 VA: 0x1817C75F0
	|-FixedHeightVirtualizationController<object>.EndDrag
	*/
}
