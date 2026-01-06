internal interface IDragAndDropController<TArgs> // TypeDefIndex: 6470
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanStartDrag(IEnumerable<int> itemIds);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.CanStartDrag
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.SetupDragAndDrop
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DragVisualMode HandleDragAndDrop(TArgs args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.HandleDragAndDrop
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDrop(TArgs args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.OnDrop
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void DragCleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-IDragAndDropController<object>.DragCleanup
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.DragCleanup
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-IDragAndDropController<object>.HandleAutoExpand
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.HandleAutoExpand
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual IEnumerable<int> GetSortedSelectedIds() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1852350 Offset: 0x1850D50 VA: 0x181852350
	|-IDragAndDropController<object>.GetSortedSelectedIds
	|
	|-RVA: 0x1852380 Offset: 0x1850D80 VA: 0x181852380
	|-IDragAndDropController<__Il2CppFullySharedGenericType>.GetSortedSelectedIds
	*/
}
