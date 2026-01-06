internal interface IListDragAndDropArgs // TypeDefIndex: 6467
{
	// Properties
	public abstract int insertAtIndex { get; }
	public abstract int parentId { get; }
	public abstract int childIndex { get; }
	public abstract DragAndDropData dragAndDropData { get; }
	public abstract DragAndDropPosition dragAndDropPosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_insertAtIndex();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_parentId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_childIndex();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract DragAndDropData get_dragAndDropData();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DragAndDropPosition get_dragAndDropPosition();
}
